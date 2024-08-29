using AutoMapper;
using NailStudioBot.Core.Dtos;
using NailStudioBot.Core.InputModels;
using NailStudioBot.Core.OutPutModels;

namespace NailStudioBot.BLL.Mappings
{
    public class UsersMappingProfile: Profile
    {
        public UsersMappingProfile() 
        {
            CreateMap<UsersInputModel, UsersDto>();
            CreateMap<UsersDto, UsersOutputModel>();
        }
    }
}
