using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NailStudio.DAL.Querys
{
    public class ReservationsQuerys
    {
        public const string InsertReservationQuery = $"INSERT INTO \"Reservations\"(StartDateTime\", Sum\", ClientId\",StatusId\",IsAction\")" +
            $"VALUES (@StartDateTime, @Sum, @ClientId, @StatusId, @IsAction);";
        public const string GetAllReservationsQuery = $"SELECT\"Id\", StartDateTime\",Sum\",ClientId\",StatusId\",IsAction\"FROM public.Reservations\";";

        //public const string UpdateReservationQuery = $"UPDATE\"Reservations\"SET StartDateTime\" = @StartDateTime,\"Sum= @Sum," +
        //    $" ClientId = @ClientId,StatusId\" = @StatusId,\"IsAction\" = @IsAction  WHERE \"Id = @Id;";


        public const string UpdateReservationQuery = $"INSERT INTO \"Reservations\"(\"StartDateTime\", \"Sum\", \"ClientId\", \"StatusId\", \"IsAction\")\r\n  " +
            $"  VALUES (start_date_time, sum_amount, client_id, status_id, is_action);";


    }
}

