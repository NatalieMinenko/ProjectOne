using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NailStudio.DAL.Querys
{
    public class StatusReservationsQuery
    {
         
        public const string GetAllStatusesQuery = "SELECT \"Id\", \"Name\" FROM \"StatusReservations\";";

        public const string AddStatusQuery = "INSERT INTO \"StatusReservations\"(\"Name\") VALUES (@Name);";

        public const string UpdateStatusQuery = "UPDATE \"StatusReservations\" SET \"Name\" = @Name WHERE \"Id\" = @Id;";

        public const string DeleteStatusByIdQuery = "DELETE FROM \"StatusReservations\" WHERE \"Id\" = @Id;";
    }
}

