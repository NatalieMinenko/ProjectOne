﻿using AutoMapper;
using mapper;
using NailStudio.DAL;
using NailStudioBot.BLL.Mappings;
using NailStudioBot.Core.Dtos;
using NailStudioBot.Core.InputModels;
using NailStudioBot.Core.OutPutModels;

namespace NailStudioBot.BLL
{
    public class ServicesServices
    {
        public ServicesRepository ServicesRepository { get; set; }
        public MasterTypesServicesRepository MasterTypesRepository { get; set; }

        private Mapper _mapper;



        public ServicesServices()
        {
            MasterTypesRepository = new MasterTypesServicesRepository();
            ServicesRepository = new ServicesRepository();
            var config = new MapperConfiguration(
                cfg =>
                {
                    cfg.AddProfile(new ServicesMappingProfile());
                    cfg.AddProfile(new MasterType_ServicesMappingProfile());
                });
            _mapper = new Mapper(config);
        }

        public void AddService(ServicesInputModel service)
        {
            var servicesDto = _mapper.Map<ServicesDto>(service);
            ServicesRepository.AddServices(servicesDto);
        }

        public List<ServicesOutputModel> GetAllServices()
        {
            List<ServicesDto> servicesDtos = ServicesRepository.GetAllServices();
            List<ServicesOutputModel> service = _mapper.Map<List<ServicesOutputModel>>(servicesDtos);
            return service;
        }

        public void UpdateService(int id, ServicesInputModel service)
        {
            var servicesDto = _mapper.Map<ServicesDto>(service);
            servicesDto.Id = id;
            ServicesRepository.UpdateServices(servicesDto);
        }

        public ServicesOutputModel GetServicesById(int id)
        {
            var userDto = ServicesRepository.GetServicesById(id);
            return _mapper.Map<ServicesOutputModel>(userDto);
        }

        public void DeleteService(int id)
        {
            MasterTypesRepository.DeleteMasterTypesServicesById(id);
            ServicesRepository.DeleteServices(id);
        }

        public bool ServicesExists(int id)
        {
            return GetServicesById(id) != null;
        }

    }
}
