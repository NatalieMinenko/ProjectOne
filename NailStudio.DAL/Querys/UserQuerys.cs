using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NailStudio.DAL.Querys
{
    public class UserQuerys
    {
        public const string AddUserQuery = $"INSERT INTO \"Users\"(\"Name\") VALUES ('@name');";

        public const string UpdateUserQuery=$"update \"Users\" set\"Name\"=@name where \"Id\"=@id";
    }
}
