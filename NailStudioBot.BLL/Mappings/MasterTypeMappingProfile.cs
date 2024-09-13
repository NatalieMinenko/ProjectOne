using AutoMapper;
using NailStudioBot.Core.Dtos;
using NailStudioBot.Core.InputModels;
using NailStudioBot.Core.OutPutModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NailStudioBot.BLL.Mappings
{
    public class MasterTypeMappingProfile : Profile
    {
        public MasterTypeMappingProfile()
        {
            CreateMap<MasterTypeInputModel, MasterTypesDto>();
            CreateMap<MasterTypesDto, MasterTypeOutputModel>();
        }
        
    }
}
