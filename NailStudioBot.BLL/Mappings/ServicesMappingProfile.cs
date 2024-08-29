using AutoMapper;
using NailStudioBot.Core.Dtos;
using NailStudioBot.Core.InputModels;
using NailStudioBot.Core.OutPutModels;

namespace mapper
{
    public class ServicesMappingProfile: Profile
    {
        public ServicesMappingProfile()
        {
            CreateMap<ServicesInputModel, ServicesDto>();
            CreateMap<ServicesDto, ServicesOutputModel>();
        }
    }
}
