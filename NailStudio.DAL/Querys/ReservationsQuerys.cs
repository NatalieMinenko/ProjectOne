using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NailStudio.DAL.Querys
{
    public class ReservationsQuerys
    {
        public const string InsertReservationQuery = $"INSERT INTO \"Reservations\"(\"StartDateTime\", \"Sum\", \"ClientId\", \"StatusId\", \"IsAction\")" +
            $" VALUES (@StartDateTime, @Sum, @ClientId, @StatusId, @IsAction);";
        public const string GetAllReservationsQuery = $"SELECT \"Id\", \"StartDateTime\", \"Sum\", \"ClientId\", \"StatusId\", \"IsAction\" FROM \"Reservations\";";

        public const string UpdateReservationQuery = $"UPDATE \"Reservations\" SET \"StartDateTime\" = @StartDateTime, \"Sum\" = @Sum, " +
            $"\"ClientId\" = @ClientId, \"StatusId\" = @StatusId, \"IsAction\" = @IsAction WHERE \"Id\" = @Id;";

        public const string DeleteReservationByIdQuery = $"DELETE FROM \"Reservations\" WHERE \"Id\" = @Id;";

        public const string GetReservationByIdQuery = $"SELECT \"Id\", \"Name\" FROM public.\"Reservations\" WHERE \"Id\"=@Id;";


    }
}

