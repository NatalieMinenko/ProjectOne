using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NailStudio.DAL.Querys
{
    public class ServicesQuerys
    {
        public const string AddServicesQuery = "INSERT INTO \"Services\" (\"Name\", \"Duration\", \"IsActive\", \"IsDeleted\") " +
         "VALUES (@name, @duration, @isActive, @isDeleted);";

        public const string GetAllServicesQuery = "SELECT \"Id\", \"Name\", \"Duration\", \"IsActive\", \"IsDeleted\" FROM \"Services\";";

        public const string UpdateServicesQuery = "UPDATE \"Services\" SET \"Name\" = @name, \"Duration\" = @duration, " +
             "\"IsActive\" = @isActive, \"IsDeleted\" = @isDeleted WHERE \"Id\" = @id;";

        public const string DeleteServicesQuery = "DELETE FROM \"Services\" WHERE \"Id\" = @id;";

        public const string FindMasterByServiceIdQuery = "SELECT S.\"Id\", S.\"Name\", S.\"Duration\", MTS.\"Cost\", MT.\"Id\", " +
           "MT.\"Name\", U.\"Id\", U.\"Name\" " +
           "FROM \"Services\" AS S " +
           "JOIN \"MasterType_Services\" AS MTS ON MTS.\"ServiceId\" = S.\"Id\" " +
           "JOIN \"MasterTypes\" AS MT ON MT.\"Id\" = MTS.\"MasterTypeId\" " +
           "JOIN \"Users\" AS U ON U.\"MasterTypeId\" = MT.\"Id\" " +
           "WHERE S.\"Id\" = @id;";

        public const string NameAllServicesQuery = "SELECT \"Name\" FROM \"Services\"WHERE \"IsActive\" = true AND \"IsDeleted\" = false;";
    }
}
