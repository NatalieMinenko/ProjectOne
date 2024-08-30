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
    }
}
