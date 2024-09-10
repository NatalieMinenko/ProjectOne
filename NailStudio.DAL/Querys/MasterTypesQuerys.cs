using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NailStudio.DAL.Querys
{
    public class MasterTypesQuerys
    {
        public const string AddMastersQuery = $"INSERT INTO \"MasterTypes\" (\"Name\") VALUES (@name);";

        public const string UpdateMastersQuery = $"UPDATE \"MasterTypes\" set \"Name\"= @name where \"Id\" = @id";

        public const string GetAllMasterTypesQuery = $"SELECT \"Id\", \"Name\" FROM public.\"MasterTypes\";";

        public const string DeleteMasterTypesByIdQuery = $"DELETE FROM public.\"MasterTypes\" WHERE \"Id\" = @id";
    }
}
