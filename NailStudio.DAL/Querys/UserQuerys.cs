using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NailStudio.DAL.Querys
{
    public class UserQuerys
    {
        public const string AddUserQuery = $"INSERT INTO \"Users\"(\"Name\", \"RoleId\", \"MasterTypeId\") VALUES (@Name, @RoleId,@MasterTypeId);";
        //public const string AddUserQuery = $" INSERT INTO \"Users\"(\"Name\")\r\n   " +
        //    $" VALUES (Name);";

        public const string UpdateUserQuery=$"UPDATE \"Users\" set\"Name\"=@name where \"Id\"=@id";

        public const string GetAllUsersQuery = $"SELECT \"Id\", \"Name\" FROM public.\"Users\";";

        public const string GetUsersByIdQuery = $"SELECT \"Id\", \"Name\" FROM public.\"Users\" WHERE \"Id\"=@id;";

        public const string DeleteUserQuery = $"DELETE FROM\"Users\"WHERE \"Id\"= @id;";

        public const string GetMastersByServiceAndCost = $"select U.\"Id\", U.\"Name\", U.\"MasterTypeId\", UR.\"Name\", MT.\"Name\", S.\"Name\", MTS.\"Cost\"" +

        $"from \"Users\" as U left join \"UserRoles\" as UR on U.\"RoleId\" = UR.\"Id\" left join \"MasterTypes\" as MT on U.\"MasterTypeId\"=MT.\"Id\"" +

        $"join \"MasterType_Services\" as MTS on MT.\"Id\"=MTS.\"MasterTypeId\" + join \"Services\" as S on MTS.\"ServiceId\"=S.\"Id\" where UR.\"Id\" = 3";
    }
}
