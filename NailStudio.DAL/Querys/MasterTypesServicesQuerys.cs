using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NailStudio.DAL.Querys
{
    public class MasterTypesServicesQuerys
    {
        public const string GetAllMasterTypesServicesQuery = $"SELECT \"MasterTypeId\", \"ServiceId\", \"Cost\" FROM public.\"MasterType_Services\";";
        public const string DeleteMasterTypeServicesById = $"DELETE FROM public.\"MasterType_Services\"WHERE \"ServiceId\"=@ServiceId;";

    }
}
