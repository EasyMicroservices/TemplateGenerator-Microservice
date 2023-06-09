using EasyMicroservices.TemplateGeneratorMicroservice.Contracts.Common;
using EasyMicroservices.TemplateGeneratorMicroservice.Contracts.Requests;
using EasyMicroservices.TemplateGeneratorMicroservice.Database;
using EasyMicroservices.TemplateGeneratorMicroservice.Database.Contexts;
using EasyMicroservices.TemplateGeneratorMicroservice.Database.Entities;
using EasyMicroservices.TemplateGeneratorMicroservice.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Any;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using System.Reflection;

namespace EasyMicroservices.TemplateGeneratorMicroservice.WebApi
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            //builder.Services.AddAuthorization();
            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen(options =>
            {
                options.SchemaFilter<GenericFilter>();
                options.SchemaFilter<XEnumNamesSchemaFilter>();
            });

            builder.Services.AddScoped((serviceProvider) => new DependencyManager().GetContractLogic<FormEntity, CreateFormRequestContract, FormContract, FormContract>());
            builder.Services.AddScoped((serviceProvider) => new DependencyManager().GetContractLogic<FormFilledEntity, FormValuesRequestContract, FormContract, FormContract>());
            builder.Services.AddScoped((serviceProvider) => new DependencyManager().GetContractLogic<FormDetailEntity, FormDetailContract, FormDetailContract, FormDetailContract>());
            builder.Services.AddScoped<IDependencyManager>(service => new DependencyManager());
            builder.Services.AddScoped(service => new WhiteLabelManager(service, service.GetService<IDependencyManager>()));
            builder.Services.AddHttpContextAccessor();
            builder.Services.AddScoped<IDatabaseBuilder>(serviceProvider => new DatabaseBuilder());
            builder.Services.AddTransient(serviceProvider => new TemplateGeneratorContext(serviceProvider.GetService<IDatabaseBuilder>()));
            //builder.WebHost.UseUrls("https://*:7185");
            var app = builder.Build();
            app.UseDeveloperExceptionPage();
            // Configure the HTTP request pipeline.
            app.UseSwagger();
            app.UseSwaggerUI();

            app.UseHttpsRedirection();
            app.UseAuthorization();
            app.MapControllers();
            
            using (var scope = app.Services.CreateScope())
            {
                using var context = scope.ServiceProvider.GetService<TemplateGeneratorContext>();
                await context.Database.MigrateAsync();
                await context.DisposeAsync();
                var service = scope.ServiceProvider.GetService<WhiteLabelManager>();
                await service.Initialize("TemplateGenerator", "https://localhost:7184", typeof(TemplateGeneratorContext));
            }
            //CreateDatabase();
            
            StartUp startUp = new();
            await startUp.Run(new DependencyManager());
            app.Run();
        }

        static void CreateDatabase()
        {
            using TemplateGeneratorContext context = new(new DatabaseBuilder());
            if (context.Database.EnsureCreated())
            {
                //auto migration when database created first time

                //add migration history table

                string createEFMigrationsHistoryCommand = $@"
USE [{context.Database.GetDbConnection().Database}];
SET ANSI_NULLS ON;
SET QUOTED_IDENTIFIER ON;
CREATE TABLE [dbo].[__EFMigrationsHistory](
    [MigrationId] [nvarchar](150) NOT NULL,
    [ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
    [MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY];
";
                context.Database.ExecuteSqlRaw(createEFMigrationsHistoryCommand);

                //insert all of migrations
                var dbAssebmly = context.GetType().Assembly;
                foreach (var item in dbAssebmly.GetTypes())
                {
                    if (item.BaseType == typeof(Migration))
                    {
                        string migrationName = item.GetCustomAttributes<MigrationAttribute>().First().Id;
                        var version = typeof(Migration).Assembly.GetName().Version;
                        string efVersion = $"{version.Major}.{version.Minor}.{version.Build}";
                        context.Database.ExecuteSqlRaw("INSERT INTO __EFMigrationsHistory(MigrationId,ProductVersion) VALUES ({0},{1})", migrationName, efVersion);
                    }
                }
            }
            context.Database.Migrate();
        }
    }

    public class GenericFilter : ISchemaFilter
    {
        public void Apply(OpenApiSchema schema, SchemaFilterContext context)
        {
            var type = context.Type;

            if (type.IsGenericType == false)
                return;

            schema.Title = $"{type.Name[0..^2]}<{type.GenericTypeArguments[0].Name}>";
        }
    }

    public class XEnumNamesSchemaFilter : ISchemaFilter
    {
        private const string NAME = "x-enumNames";
        public void Apply(OpenApiSchema model, SchemaFilterContext context)
        {
            var typeInfo = context.Type;
            // Chances are something in the pipeline might generate this automatically at some point in the future
            // therefore it's best to check if it exists.
            if (typeInfo.IsEnum && !model.Extensions.ContainsKey(NAME))
            {
                var names = Enum.GetNames(context.Type);
                var arr = new OpenApiArray();
                arr.AddRange(names.Select(name => new OpenApiString(name)));
                model.Extensions.Add(NAME, arr);
            }
        }
    }
}