using Dapper;
using NailStudio.DAL.Querys;
using NailStudioBot.Core;
using NailStudioBot.Core.Dtos;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NailStudio.DAL
{
    public class ReservationsRepository
    {
        public void InsertReservation(ReservationsDto reservation)
        {
            string conectionString = Options.ConectionString;
            using (var connection = new NpgsqlConnection(conectionString))
            {
                string query = ReservationsQuerys.InsertReservationQuery;
                var args = new
                {
                    reservation.StartDateTime,
                    reservation.Sum,
                    reservation.ClientId,
                    reservation.StatusId,
                    reservation.IsAction
                };

                connection.Open();
                connection.Query(query, args);
            }
        }

        public List<ReservationsDto> GetAllReservations()
        {
            string conectionString = Options.ConectionString;
            using (var connection = new NpgsqlConnection(conectionString))

            {
                string query = ReservationsQuerys.GetAllReservationsQuery;

                connection.Open();
                return connection.Query<ReservationsDto>(query).ToList();
            }
        }

        public void UpdateReservation(ReservationsDto reservation)
        {
            string conectionString = Options.ConectionString;
            using (var connection = new NpgsqlConnection(conectionString))
            {
                string query = ReservationsQuerys.UpdateReservationQuery;
                var args = new
                {
                    reservation.StartDateTime,
                    reservation.Sum,
                    reservation.ClientId,
                    reservation.StatusId,
                    reservation.IsAction,
                    reservation.Id
                };

                connection.Open();
                connection.Execute(query, args);
            }
        }

        public void DeleteReservationById(int id)
        {
            string conectionString = Options.ConectionString;
            using (var connection = new NpgsqlConnection(conectionString))
            {
                string query = ReservationsQuerys.DeleteReservationByIdQuery;
                var args = new { id };

                connection.Open();
                connection.Execute(query, args);
            }
        }



    }
}
