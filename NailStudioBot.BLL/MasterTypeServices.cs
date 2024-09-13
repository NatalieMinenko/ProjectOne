using AutoMapper;
using NailStudio.DAL;
using NailStudioBot.BLL.Mappings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NailStudioBot.Core;
using NailStudioBot.Core.OutPutModels;
using NailStudioBot.Core.Dtos;
using NailStudioBot.Core.InputModels;

namespace NailStudioBot.BLL
{
    public class MasterTypeServices
    {
        public MasterTypesRepository MasterTypesRepository { get; set; }

        private Mapper _mapper;
        
        public MasterTypeServices()
        {
            MasterTypesRepository = new MasterTypesRepository();
            var config = new MapperConfiguration(
                cfg =>
                {
                    cfg.AddProfile(new MasterTypeMappingProfile());
                });
            _mapper = new Mapper(config);
        }
        public void AddMasters(MasterTypeInputModel name)
        {
            var masterTypesDto = _mapper.Map<MasterTypesDto>(name);
            MasterTypesRepository.AddMasters(masterTypesDto.Name);
        }

        public List<MasterTypeOutputModel> GetAllMasterTypes()
        {
            List<MasterTypesDto> MasterTypesDtos = MasterTypesRepository.GetAllMasterTypes();
            List<MasterTypeOutputModel> masters = _mapper.Map<List<MasterTypeOutputModel>>(MasterTypesDtos);
            return masters;

        }
    }
}
