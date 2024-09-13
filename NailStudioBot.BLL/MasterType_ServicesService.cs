using AutoMapper;
using NailStudio.DAL;
using NailStudioBot.BLL.Mappings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NailStudioBot.BLL
{
    public class MasterType_ServicesService
    {
        public MasterTypesServicesRepository MasterTypesServicesRepository { get; set; }
        private Mapper _mapper;

        public MasterType_ServicesService()
        {
            MasterTypesServicesRepository = new MasterTypesServicesRepository();
            var config = new MapperConfiguration(
                cfg =>
                {
                    cfg.AddProfile(new MasterType_ServicesMappingProfile());
                });
            _mapper = new Mapper(config);
        }
        public void DeleteMasterTypeServices(int id)
        {
            MasterTypesServicesRepository.DeleteMasterTypesServicesById(id);
        }
    }
}
