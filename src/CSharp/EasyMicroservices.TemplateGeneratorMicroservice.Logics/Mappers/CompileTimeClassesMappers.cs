﻿using System.Threading.Tasks;
using EasyMicroservices.Mapper.CompileTimeMapper.Interfaces;
using EasyMicroservices.Mapper.Interfaces;
using EasyMicroservices.TemplateGeneratorMicroservice.DatabaseLogics;
using System.Linq;

namespace CompileTimeMapper
{
    public class FormDetailEntity_FormDetailContract_Mapper : IMapper
    {
        readonly IMapperProvider _mapper;
        public FormDetailEntity_FormDetailContract_Mapper(IMapperProvider mapper)
        {
            _mapper = mapper;
        }

        public global::EasyMicroservices.TemplateGeneratorMicroservice.Database.Entities.FormDetailEntity Map(global::EasyMicroservices.TemplateGeneratorMicroservice.Contracts.Common.FormDetailContract fromObject, string uniqueRecordId, string language, object[] parameters)
        {
            if (fromObject == default)
                return default;
            var mapped = new global::EasyMicroservices.TemplateGeneratorMicroservice.Database.Entities.FormDetailEntity()
            {
                FormId = fromObject.FormId,
                Key = fromObject.Key,
                Title = fromObject.Title,
                Value = fromObject.Value,
            };
            return mapped;
        }

        public global::EasyMicroservices.TemplateGeneratorMicroservice.Contracts.Common.FormDetailContract Map(global::EasyMicroservices.TemplateGeneratorMicroservice.Database.Entities.FormDetailEntity fromObject, string uniqueRecordId, string language, object[] parameters)
        {
            if (fromObject == default)
                return default;
            var mapped = new global::EasyMicroservices.TemplateGeneratorMicroservice.Contracts.Common.FormDetailContract()
            {
                FormId = fromObject.FormId,
                Key = fromObject.Key,
                Title = fromObject.Title,
                Value = fromObject.Value,
            };
            return mapped;
        }

        public async Task<global::EasyMicroservices.TemplateGeneratorMicroservice.Database.Entities.FormDetailEntity> MapAsync(global::EasyMicroservices.TemplateGeneratorMicroservice.Contracts.Common.FormDetailContract fromObject, string uniqueRecordId, string language, object[] parameters)
        {
            if (fromObject == default)
                return default;
            var mapped = new global::EasyMicroservices.TemplateGeneratorMicroservice.Database.Entities.FormDetailEntity()
            {
                FormId = fromObject.FormId,
                Key = fromObject.Key,
                Title = fromObject.Title,
                Value = fromObject.Value,
            };
            return mapped;
        }

        public async Task<global::EasyMicroservices.TemplateGeneratorMicroservice.Contracts.Common.FormDetailContract> MapAsync(global::EasyMicroservices.TemplateGeneratorMicroservice.Database.Entities.FormDetailEntity fromObject, string uniqueRecordId, string language, object[] parameters)
        {
            if (fromObject == default)
                return default;
            var mapped = new global::EasyMicroservices.TemplateGeneratorMicroservice.Contracts.Common.FormDetailContract()
            {
                FormId = fromObject.FormId,
                Key = fromObject.Key,
                Title = fromObject.Title,
                Value = fromObject.Value,
            };
            return mapped;
        }
        public object MapObject(object fromObject, string uniqueRecordId, string language, object[] parameters)
        {
            if (fromObject == default)
                return default;
            if (fromObject.GetType() == typeof(EasyMicroservices.TemplateGeneratorMicroservice.Database.Entities.FormDetailEntity))
                return Map((EasyMicroservices.TemplateGeneratorMicroservice.Database.Entities.FormDetailEntity)fromObject, uniqueRecordId, language, parameters);
            return Map((EasyMicroservices.TemplateGeneratorMicroservice.Contracts.Common.FormDetailContract)fromObject, uniqueRecordId, language, parameters);
        }
        public async Task<object> MapObjectAsync(object fromObject, string uniqueRecordId, string language, object[] parameters)
        {
            if (fromObject == default)
                return default;
            if (fromObject.GetType() == typeof(EasyMicroservices.TemplateGeneratorMicroservice.Database.Entities.FormDetailEntity))
                return await MapAsync((EasyMicroservices.TemplateGeneratorMicroservice.Database.Entities.FormDetailEntity)fromObject, uniqueRecordId, language, parameters);
            return await MapAsync((EasyMicroservices.TemplateGeneratorMicroservice.Contracts.Common.FormDetailContract)fromObject, uniqueRecordId, language, parameters);
        }
    }
    public class FormEntity_CreateFormRequestContract_Mapper : IMapper
    {
        readonly IMapperProvider _mapper;
        public FormEntity_CreateFormRequestContract_Mapper(IMapperProvider mapper)
        {
            _mapper = mapper;
        }

        public global::EasyMicroservices.TemplateGeneratorMicroservice.Database.Entities.FormEntity Map(global::EasyMicroservices.TemplateGeneratorMicroservice.Contracts.Requests.CreateFormRequestContract fromObject, string uniqueRecordId, string language, object[] parameters)
        {
            if (fromObject == default)
                return default;
            var mapped = new global::EasyMicroservices.TemplateGeneratorMicroservice.Database.Entities.FormEntity()
            {
                Description = fromObject.Description,
                FormItems = _mapper.MapToList<global::EasyMicroservices.TemplateGeneratorMicroservice.Database.Entities.FormItemEntity>(fromObject.FormItems, uniqueRecordId, language, parameters),
                Name = fromObject.Name,
            };
            return mapped;
        }

        public global::EasyMicroservices.TemplateGeneratorMicroservice.Contracts.Requests.CreateFormRequestContract Map(global::EasyMicroservices.TemplateGeneratorMicroservice.Database.Entities.FormEntity fromObject, string uniqueRecordId, string language, object[] parameters)
        {
            if (fromObject == default)
                return default;
            var mapped = new global::EasyMicroservices.TemplateGeneratorMicroservice.Contracts.Requests.CreateFormRequestContract()
            {
                Description = fromObject.Description,
                FormItems = _mapper.MapToList<global::EasyMicroservices.TemplateGeneratorMicroservice.Contracts.Common.FormItemContract>(fromObject.FormItems, uniqueRecordId, language, parameters),
                Name = fromObject.Name,
            };
            return mapped;
        }

        public async Task<global::EasyMicroservices.TemplateGeneratorMicroservice.Database.Entities.FormEntity> MapAsync(global::EasyMicroservices.TemplateGeneratorMicroservice.Contracts.Requests.CreateFormRequestContract fromObject, string uniqueRecordId, string language, object[] parameters)
        {
            if (fromObject == default)
                return default;
            var mapped = new global::EasyMicroservices.TemplateGeneratorMicroservice.Database.Entities.FormEntity()
            {
                Description = fromObject.Description,
                FormItems = await _mapper.MapToListAsync<global::EasyMicroservices.TemplateGeneratorMicroservice.Database.Entities.FormItemEntity>(fromObject.FormItems, uniqueRecordId, language, parameters),
                Name = fromObject.Name,
            };
            return mapped;
        }

        public async Task<global::EasyMicroservices.TemplateGeneratorMicroservice.Contracts.Requests.CreateFormRequestContract> MapAsync(global::EasyMicroservices.TemplateGeneratorMicroservice.Database.Entities.FormEntity fromObject, string uniqueRecordId, string language, object[] parameters)
        {
            if (fromObject == default)
                return default;
            var mapped = new global::EasyMicroservices.TemplateGeneratorMicroservice.Contracts.Requests.CreateFormRequestContract()
            {
                Description = fromObject.Description,
                FormItems = await _mapper.MapToListAsync<global::EasyMicroservices.TemplateGeneratorMicroservice.Contracts.Common.FormItemContract>(fromObject.FormItems, uniqueRecordId, language, parameters),
                Name = fromObject.Name,
            };
            return mapped;
        }
        public object MapObject(object fromObject, string uniqueRecordId, string language, object[] parameters)
        {
            if (fromObject == default)
                return default;
            if (fromObject.GetType() == typeof(EasyMicroservices.TemplateGeneratorMicroservice.Database.Entities.FormEntity))
                return Map((EasyMicroservices.TemplateGeneratorMicroservice.Database.Entities.FormEntity)fromObject, uniqueRecordId, language, parameters);
            return Map((EasyMicroservices.TemplateGeneratorMicroservice.Contracts.Requests.CreateFormRequestContract)fromObject, uniqueRecordId, language, parameters);
        }
        public async Task<object> MapObjectAsync(object fromObject, string uniqueRecordId, string language, object[] parameters)
        {
            if (fromObject == default)
                return default;
            if (fromObject.GetType() == typeof(EasyMicroservices.TemplateGeneratorMicroservice.Database.Entities.FormEntity))
                return await MapAsync((EasyMicroservices.TemplateGeneratorMicroservice.Database.Entities.FormEntity)fromObject, uniqueRecordId, language, parameters);
            return await MapAsync((EasyMicroservices.TemplateGeneratorMicroservice.Contracts.Requests.CreateFormRequestContract)fromObject, uniqueRecordId, language, parameters);
        }
    }
    public class FormEntity_FormContract_Mapper : IMapper
    {
        readonly IMapperProvider _mapper;
        public FormEntity_FormContract_Mapper(IMapperProvider mapper)
        {
            _mapper = mapper;
        }

        public global::EasyMicroservices.TemplateGeneratorMicroservice.Database.Entities.FormEntity Map(global::EasyMicroservices.TemplateGeneratorMicroservice.Contracts.Common.FormContract fromObject, string uniqueRecordId, string language, object[] parameters)
        {
            if (fromObject == default)
                return default;
            var mapped = new global::EasyMicroservices.TemplateGeneratorMicroservice.Database.Entities.FormEntity()
            {
                Description = fromObject.Description,
                FormItems = _mapper.MapToList<global::EasyMicroservices.TemplateGeneratorMicroservice.Database.Entities.FormItemEntity>(fromObject.Items, uniqueRecordId, language, parameters),
                Id = fromObject.Id,
                Name = fromObject.Name,
            };
            return mapped;
        }

        public global::EasyMicroservices.TemplateGeneratorMicroservice.Contracts.Common.FormContract Map(global::EasyMicroservices.TemplateGeneratorMicroservice.Database.Entities.FormEntity fromObject, string uniqueRecordId, string language, object[] parameters)
        {
            if (fromObject == default)
                return default;
            var mapped = new global::EasyMicroservices.TemplateGeneratorMicroservice.Contracts.Common.FormContract()
            {
                Description = fromObject.Description,
                Id = fromObject.Id,
                Items = _mapper.MapToList<global::EasyMicroservices.TemplateGeneratorMicroservice.Contracts.Common.FormItemContract>(fromObject.FormItems, uniqueRecordId, language, parameters),
                Name = fromObject.Name,
            };
            return mapped;
        }

        public async Task<global::EasyMicroservices.TemplateGeneratorMicroservice.Database.Entities.FormEntity> MapAsync(global::EasyMicroservices.TemplateGeneratorMicroservice.Contracts.Common.FormContract fromObject, string uniqueRecordId, string language, object[] parameters)
        {
            if (fromObject == default)
                return default;
            var mapped = new global::EasyMicroservices.TemplateGeneratorMicroservice.Database.Entities.FormEntity()
            {
                Description = fromObject.Description,
                FormItems = await _mapper.MapToListAsync<global::EasyMicroservices.TemplateGeneratorMicroservice.Database.Entities.FormItemEntity>(fromObject.Items, uniqueRecordId, language, parameters),
                Id = fromObject.Id,
                Name = fromObject.Name,
            };
            return mapped;
        }

        public async Task<global::EasyMicroservices.TemplateGeneratorMicroservice.Contracts.Common.FormContract> MapAsync(global::EasyMicroservices.TemplateGeneratorMicroservice.Database.Entities.FormEntity fromObject, string uniqueRecordId, string language, object[] parameters)
        {
            if (fromObject == default)
                return default;
            var mapped = new global::EasyMicroservices.TemplateGeneratorMicroservice.Contracts.Common.FormContract()
            {
                Description = fromObject.Description,
                Id = fromObject.Id,
                Items = await _mapper.MapToListAsync<global::EasyMicroservices.TemplateGeneratorMicroservice.Contracts.Common.FormItemContract>(fromObject.FormItems, uniqueRecordId, language, parameters),
                Name = fromObject.Name,
            };
            return mapped;
        }
        public object MapObject(object fromObject, string uniqueRecordId, string language, object[] parameters)
        {
            if (fromObject == default)
                return default;
            if (fromObject.GetType() == typeof(EasyMicroservices.TemplateGeneratorMicroservice.Database.Entities.FormEntity))
                return Map((EasyMicroservices.TemplateGeneratorMicroservice.Database.Entities.FormEntity)fromObject, uniqueRecordId, language, parameters);
            return Map((EasyMicroservices.TemplateGeneratorMicroservice.Contracts.Common.FormContract)fromObject, uniqueRecordId, language, parameters);
        }
        public async Task<object> MapObjectAsync(object fromObject, string uniqueRecordId, string language, object[] parameters)
        {
            if (fromObject == default)
                return default;
            if (fromObject.GetType() == typeof(EasyMicroservices.TemplateGeneratorMicroservice.Database.Entities.FormEntity))
                return await MapAsync((EasyMicroservices.TemplateGeneratorMicroservice.Database.Entities.FormEntity)fromObject, uniqueRecordId, language, parameters);
            return await MapAsync((EasyMicroservices.TemplateGeneratorMicroservice.Contracts.Common.FormContract)fromObject, uniqueRecordId, language, parameters);
        }
    }
    public class FormFilledEntity_FormValuesRequestContract_Mapper : IMapper
    {
        readonly IMapperProvider _mapper;
        public FormFilledEntity_FormValuesRequestContract_Mapper(IMapperProvider mapper)
        {
            _mapper = mapper;
        }

        public global::EasyMicroservices.TemplateGeneratorMicroservice.Database.Entities.FormFilledEntity Map(global::EasyMicroservices.TemplateGeneratorMicroservice.Contracts.Requests.FormValuesRequestContract fromObject, string uniqueRecordId, string language, object[] parameters)
        {
            if (fromObject == default)
                return default;
            var mapped = new global::EasyMicroservices.TemplateGeneratorMicroservice.Database.Entities.FormFilledEntity()
            {
                FormId = fromObject.FormId,
                FormItemValues = _mapper.MapToList<global::EasyMicroservices.TemplateGeneratorMicroservice.Database.Entities.FormItemValueEntity>(fromObject.FormItemValues, uniqueRecordId, language, parameters),
            };
            return mapped;
        }

        public global::EasyMicroservices.TemplateGeneratorMicroservice.Contracts.Requests.FormValuesRequestContract Map(global::EasyMicroservices.TemplateGeneratorMicroservice.Database.Entities.FormFilledEntity fromObject, string uniqueRecordId, string language, object[] parameters)
        {
            if (fromObject == default)
                return default;
            var mapped = new global::EasyMicroservices.TemplateGeneratorMicroservice.Contracts.Requests.FormValuesRequestContract()
            {
                FormId = fromObject.FormId,
                FormItemValues = _mapper.MapToList<global::EasyMicroservices.TemplateGeneratorMicroservice.Contracts.Common.FormItemValueContract>(fromObject.FormItemValues, uniqueRecordId, language, parameters),
            };
            return mapped;
        }

        public async Task<global::EasyMicroservices.TemplateGeneratorMicroservice.Database.Entities.FormFilledEntity> MapAsync(global::EasyMicroservices.TemplateGeneratorMicroservice.Contracts.Requests.FormValuesRequestContract fromObject, string uniqueRecordId, string language, object[] parameters)
        {
            if (fromObject == default)
                return default;
            var mapped = new global::EasyMicroservices.TemplateGeneratorMicroservice.Database.Entities.FormFilledEntity()
            {
                FormId = fromObject.FormId,
                FormItemValues = await _mapper.MapToListAsync<global::EasyMicroservices.TemplateGeneratorMicroservice.Database.Entities.FormItemValueEntity>(fromObject.FormItemValues, uniqueRecordId, language, parameters),
            };
            return mapped;
        }

        public async Task<global::EasyMicroservices.TemplateGeneratorMicroservice.Contracts.Requests.FormValuesRequestContract> MapAsync(global::EasyMicroservices.TemplateGeneratorMicroservice.Database.Entities.FormFilledEntity fromObject, string uniqueRecordId, string language, object[] parameters)
        {
            if (fromObject == default)
                return default;
            var mapped = new global::EasyMicroservices.TemplateGeneratorMicroservice.Contracts.Requests.FormValuesRequestContract()
            {
                FormId = fromObject.FormId,
                FormItemValues = await _mapper.MapToListAsync<global::EasyMicroservices.TemplateGeneratorMicroservice.Contracts.Common.FormItemValueContract>(fromObject.FormItemValues, uniqueRecordId, language, parameters),
            };
            return mapped;
        }
        public object MapObject(object fromObject, string uniqueRecordId, string language, object[] parameters)
        {
            if (fromObject == default)
                return default;
            if (fromObject.GetType() == typeof(EasyMicroservices.TemplateGeneratorMicroservice.Database.Entities.FormFilledEntity))
                return Map((EasyMicroservices.TemplateGeneratorMicroservice.Database.Entities.FormFilledEntity)fromObject, uniqueRecordId, language, parameters);
            return Map((EasyMicroservices.TemplateGeneratorMicroservice.Contracts.Requests.FormValuesRequestContract)fromObject, uniqueRecordId, language, parameters);
        }
        public async Task<object> MapObjectAsync(object fromObject, string uniqueRecordId, string language, object[] parameters)
        {
            if (fromObject == default)
                return default;
            if (fromObject.GetType() == typeof(EasyMicroservices.TemplateGeneratorMicroservice.Database.Entities.FormFilledEntity))
                return await MapAsync((EasyMicroservices.TemplateGeneratorMicroservice.Database.Entities.FormFilledEntity)fromObject, uniqueRecordId, language, parameters);
            return await MapAsync((EasyMicroservices.TemplateGeneratorMicroservice.Contracts.Requests.FormValuesRequestContract)fromObject, uniqueRecordId, language, parameters);
        }
    }
    public class FormItemEntity_FormItemContract_Mapper : IMapper
    {
        readonly IMapperProvider _mapper;
        public FormItemEntity_FormItemContract_Mapper(IMapperProvider mapper)
        {
            _mapper = mapper;
        }

        public global::EasyMicroservices.TemplateGeneratorMicroservice.Database.Entities.FormItemEntity Map(global::EasyMicroservices.TemplateGeneratorMicroservice.Contracts.Common.FormItemContract fromObject, string uniqueRecordId, string language, object[] parameters)
        {
            if (fromObject == default)
                return default;
            var mapped = new global::EasyMicroservices.TemplateGeneratorMicroservice.Database.Entities.FormItemEntity()
            {
                Children = _mapper.MapToList<global::EasyMicroservices.TemplateGeneratorMicroservice.Database.Entities.FormItemEntity>(fromObject.Items, uniqueRecordId, language, parameters),
                Id = fromObject.Id,
                Index = fromObject.Index,
                Title = fromObject.Title,
            };
            return mapped;
        }

        public global::EasyMicroservices.TemplateGeneratorMicroservice.Contracts.Common.FormItemContract Map(global::EasyMicroservices.TemplateGeneratorMicroservice.Database.Entities.FormItemEntity fromObject, string uniqueRecordId, string language, object[] parameters)
        {
            if (fromObject == default)
                return default;
            var mapped = new global::EasyMicroservices.TemplateGeneratorMicroservice.Contracts.Common.FormItemContract()
            {
                Id = fromObject.Id,
                Index = fromObject.Index,
                Items = _mapper.MapToList<global::EasyMicroservices.TemplateGeneratorMicroservice.Contracts.Common.FormItemContract>(fromObject.Children, uniqueRecordId, language, parameters),
                Title = fromObject.Title,
                Type = (fromObject.ItemType?.Type).GetValueOrDefault(),
            };
            return mapped;
        }

        public async Task<global::EasyMicroservices.TemplateGeneratorMicroservice.Database.Entities.FormItemEntity> MapAsync(global::EasyMicroservices.TemplateGeneratorMicroservice.Contracts.Common.FormItemContract fromObject, string uniqueRecordId, string language, object[] parameters)
        {
            if (fromObject == default)
                return default;
            var mapped = new global::EasyMicroservices.TemplateGeneratorMicroservice.Database.Entities.FormItemEntity()
            {
                Children = await _mapper.MapToListAsync<global::EasyMicroservices.TemplateGeneratorMicroservice.Database.Entities.FormItemEntity>(fromObject.Items, uniqueRecordId, language, parameters),
                Id = fromObject.Id,
                Index = fromObject.Index,
                Title = fromObject.Title,
            };
            mapped.ItemTypeId = await ItemTypeDatabaseLogic.GetItemTypeIdByType(fromObject.Type);
            return mapped;
        }

        public async Task<global::EasyMicroservices.TemplateGeneratorMicroservice.Contracts.Common.FormItemContract> MapAsync(global::EasyMicroservices.TemplateGeneratorMicroservice.Database.Entities.FormItemEntity fromObject, string uniqueRecordId, string language, object[] parameters)
        {
            if (fromObject == default)
                return default;
            var mapped = new global::EasyMicroservices.TemplateGeneratorMicroservice.Contracts.Common.FormItemContract()
            {
                Id = fromObject.Id,
                Index = fromObject.Index,
                Items = await _mapper.MapToListAsync<global::EasyMicroservices.TemplateGeneratorMicroservice.Contracts.Common.FormItemContract>(fromObject.Children, uniqueRecordId, language, parameters),
                Title = fromObject.Title,
                Type = (fromObject.ItemType?.Type).GetValueOrDefault(),
            };
            return mapped;
        }
        public object MapObject(object fromObject, string uniqueRecordId, string language, object[] parameters)
        {
            if (fromObject == default)
                return default;
            if (fromObject.GetType() == typeof(EasyMicroservices.TemplateGeneratorMicroservice.Database.Entities.FormItemEntity))
                return Map((EasyMicroservices.TemplateGeneratorMicroservice.Database.Entities.FormItemEntity)fromObject, uniqueRecordId, language, parameters);
            return Map((EasyMicroservices.TemplateGeneratorMicroservice.Contracts.Common.FormItemContract)fromObject, uniqueRecordId, language, parameters);
        }
        public async Task<object> MapObjectAsync(object fromObject, string uniqueRecordId, string language, object[] parameters)
        {
            if (fromObject == default)
                return default;
            if (fromObject.GetType() == typeof(EasyMicroservices.TemplateGeneratorMicroservice.Database.Entities.FormItemEntity))
                return await MapAsync((EasyMicroservices.TemplateGeneratorMicroservice.Database.Entities.FormItemEntity)fromObject, uniqueRecordId, language, parameters);
            return await MapAsync((EasyMicroservices.TemplateGeneratorMicroservice.Contracts.Common.FormItemContract)fromObject, uniqueRecordId, language, parameters);
        }
    }
    public class FormItemValueEntity_FormItemValueContract_Mapper : IMapper
    {
        readonly IMapperProvider _mapper;
        public FormItemValueEntity_FormItemValueContract_Mapper(IMapperProvider mapper)
        {
            _mapper = mapper;
        }

        public global::EasyMicroservices.TemplateGeneratorMicroservice.Database.Entities.FormItemValueEntity Map(global::EasyMicroservices.TemplateGeneratorMicroservice.Contracts.Common.FormItemValueContract fromObject, string uniqueRecordId, string language, object[] parameters)
        {
            if (fromObject == default)
                return default;
            var mapped = new global::EasyMicroservices.TemplateGeneratorMicroservice.Database.Entities.FormItemValueEntity()
            {
                FormItemId = fromObject.FormItemId,
                Value = fromObject.Value,
            };
            return mapped;
        }

        public global::EasyMicroservices.TemplateGeneratorMicroservice.Contracts.Common.FormItemValueContract Map(global::EasyMicroservices.TemplateGeneratorMicroservice.Database.Entities.FormItemValueEntity fromObject, string uniqueRecordId, string language, object[] parameters)
        {
            if (fromObject == default)
                return default;
            var mapped = new global::EasyMicroservices.TemplateGeneratorMicroservice.Contracts.Common.FormItemValueContract()
            {
                FormItemId = fromObject.FormItemId,
                Value = fromObject.Value,
            };
            return mapped;
        }

        public async Task<global::EasyMicroservices.TemplateGeneratorMicroservice.Database.Entities.FormItemValueEntity> MapAsync(global::EasyMicroservices.TemplateGeneratorMicroservice.Contracts.Common.FormItemValueContract fromObject, string uniqueRecordId, string language, object[] parameters)
        {
            if (fromObject == default)
                return default;
            var mapped = new global::EasyMicroservices.TemplateGeneratorMicroservice.Database.Entities.FormItemValueEntity()
            {
                FormItemId = fromObject.FormItemId,
                Value = fromObject.Value,
            };
            return mapped;
        }

        public async Task<global::EasyMicroservices.TemplateGeneratorMicroservice.Contracts.Common.FormItemValueContract> MapAsync(global::EasyMicroservices.TemplateGeneratorMicroservice.Database.Entities.FormItemValueEntity fromObject, string uniqueRecordId, string language, object[] parameters)
        {
            if (fromObject == default)
                return default;
            var mapped = new global::EasyMicroservices.TemplateGeneratorMicroservice.Contracts.Common.FormItemValueContract()
            {
                FormItemId = fromObject.FormItemId,
                Value = fromObject.Value,
            };
            return mapped;
        }
        public object MapObject(object fromObject, string uniqueRecordId, string language, object[] parameters)
        {
            if (fromObject == default)
                return default;
            if (fromObject.GetType() == typeof(EasyMicroservices.TemplateGeneratorMicroservice.Database.Entities.FormItemValueEntity))
                return Map((EasyMicroservices.TemplateGeneratorMicroservice.Database.Entities.FormItemValueEntity)fromObject, uniqueRecordId, language, parameters);
            return Map((EasyMicroservices.TemplateGeneratorMicroservice.Contracts.Common.FormItemValueContract)fromObject, uniqueRecordId, language, parameters);
        }
        public async Task<object> MapObjectAsync(object fromObject, string uniqueRecordId, string language, object[] parameters)
        {
            if (fromObject == default)
                return default;
            if (fromObject.GetType() == typeof(EasyMicroservices.TemplateGeneratorMicroservice.Database.Entities.FormItemValueEntity))
                return await MapAsync((EasyMicroservices.TemplateGeneratorMicroservice.Database.Entities.FormItemValueEntity)fromObject, uniqueRecordId, language, parameters);
            return await MapAsync((EasyMicroservices.TemplateGeneratorMicroservice.Contracts.Common.FormItemValueContract)fromObject, uniqueRecordId, language, parameters);
        }
    }
}