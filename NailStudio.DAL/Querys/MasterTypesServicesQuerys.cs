using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NailStudio.DAL.Querys
{
    public class MasterTypesServicesQuerys
    {
        public const string GetAllMasterTypesServicesQuery = $"SELECT \"ServicesId\", \"MasterTypesId\" FROM public.\"MasterTypes_Services\";";

        public const string GetAllCostQuery = $"SELECT \"Cost\" FROM public.\"MasterTypes_Services\";";

    }
}
