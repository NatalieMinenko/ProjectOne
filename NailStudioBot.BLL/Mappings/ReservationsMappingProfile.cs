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
    public class ReservationsMappingProfile:Profile
    {
        public ReservationsMappingProfile()
        {
            CreateMap<ReservationsInputModel, ReservationsDto>();
            CreateMap<ReservationsDto, ReservationsOutputModel>();
        }
    }
}
