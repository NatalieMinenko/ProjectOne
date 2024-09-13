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
    public class MasterType_ServicesMappingProfile : Profile
    {
        public MasterType_ServicesMappingProfile()
        {
            CreateMap<MasterType_ServicesInputModel, MasterType_ServicesDto>();
            CreateMap<MasterType_ServicesDto, MasterType_ServicesInputModel>();
            CreateMap<MasterType_ServicesDto, MasterType_ServicesOutputModel>();
        }
    }
}
