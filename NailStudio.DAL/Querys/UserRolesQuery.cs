using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NailStudio.DAL.Querys
{
    public class UserRolesQuerys
    {
        public const string AddUserRolesQuery = $"INSERT INTO public.\"UserRoles\"(\"Id\", \"Name\") VALUES(@Id, @Name);";
        
        public const string UpdateUserRolesQuery = $"UPDATE public.\"UserRoles\" set\"Name\"=@name where \"Id\"=@id";

        public const string GetAllUserRolesQuery = $"SELECT \"Id\", \"Name\" FROM public.\"UserRoles\";";

        public const string GetUserRolesByIdQuery = $"SELECT \"Id\", \"Name\" FROM public.\"UserRoles\" WHERE \"Id\"=@id;";

        public const string DeleteUserRolesQuery = $"DELETE FROM\"UserRoles\"WHERE \"Id\"= @id;";
    }
}
