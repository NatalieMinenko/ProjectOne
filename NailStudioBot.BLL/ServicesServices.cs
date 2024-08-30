using AutoMapper;
using mapper;
using NailStudio.DAL;
using NailStudioBot.Core.Dtos;
using NailStudioBot.Core.InputModels;
using NailStudioBot.Core.OutPutModels;

namespace NailStudioBot.BLL
{
    public class ServicesServices
    {
        public ServicesRepository ServicesRepisitory { get; set; }

        private Mapper _mapper;

        public ServicesServices()
        {
            ServicesRepisitory = new ServicesRepository();
            var config = new MapperConfiguration(
                cfg =>
                {
                    cfg.AddProfile(new ServicesMappingProfile());
                });
            _mapper = new Mapper(config);
        }

        public void AddServices(ServicesInputModel service)
        {
            var servicesDto = _mapper.Map<ServicesDto>(service);

            ServicesRepisitory.AddServices(servicesDto.Name);
        }

        public List<ServicesOutputModel> GetAllServices()
        {
            List<ServicesDto> servicesDtos = ServicesRepisitory.GetAllServices();
            List<ServicesOutputModel> service = _mapper.Map<List<ServicesOutputModel>>(servicesDtos);
            return service;
        }

    }
}
