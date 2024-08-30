using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NailStudio.DAL.Querys
{
    public class ServicesQuerys
    {
        public const string AddServicesQuery = $"INSERT INTO \"Services\"(\"Name\", \"Duration\", \"IsActive\"," +
            $" \"IsDeleted\")\r\n VALUES (@name, @duration, @isActive, @isDeleted);\r\n \";";

        public const string GetAllServicesQuery = $"SELECT \" Id \",Name\", Duration\", IsActive\"IsDeleted\" FROM.public\"Services";

        public const string UpdateServicesQuery = $"UPDATE\"Services\"SET\"Name\"= @name,\"Duration\"= @duration," +
            $"\"IsActive\" = @isActive\"IsDeleted\" = @isDeleted\" WHERE \"Id\"= @id;";

        public const string DeleteServicesQuery = $"DELETE FROM\"Services\"WHERE \"Id\"= @id;";

        public const string FindMasterByServiceIdQuery = $"select S.\"Id\", S.\"Name\", S.\"Duration\", MTS.\"Cost\", MT.\"Id\"," +
            $" MT.\"Name\", U.\"Id\", U.\"Name\"\r\n" +
            $"from \"Services\" as S\r\njoin \"MasterType_Services\" as MTS on MTS.\"ServiceId\"= S.\"Id\"\r\n" +
            $"join \"MasterTypes\" as MT on MT.\"Id\" = MTS.\"MasterTypeId\"\r\n" +
            $"join \"Users\" as U on U.\"MasterTypeId\" = MT.\"Id\"\r\nwhere S.\"Id\" = @id;";

        public const string NameAllServicesQuery = $"select \"Name\" from \"Services\"\r\nwhere \"IsActive\"=true " +
            $"and \"IsDeleted\"=false;"
    }
}
