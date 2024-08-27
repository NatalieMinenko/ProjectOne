using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NailStudio.DAL.Querys
{
    public class ServicesQverys
    {
        public const string AddServicesQuery = $"INSERT INTO \"Services\"(\"Name\", \"Duration\", \"IsActive\", \"IsDeleted\")\r\n VALUES (@name, @duration, @isActive, @isDeleted);\r\n \";";
        public const string GetAllServicesQuery = $"SELECT \" Id \",Name\", Duration\", IsActive\"IsDeleted\" FROM.public\"Services";
        public const string UpdateServicesQuery = $"UPDATE\"Services\"SET\"Name\"= @name,\"Duration\"= @duration,\"IsActive\" = @isActive\"IsDeleted\" = @isDeleted\" WHERE \"Id\"= @id;";
        public const string DeleteServicesQuery = $"DELETE FROM\"Services\"WHERE \"Id\"= @id;";

    }
}
