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
    public class StatusReservationsRepository
    {
        public List<StatusReservationsDto> GetAllStatuses()
        {
            string conectionString = Options.ConectionString;
            using (var connection = new NpgsqlConnection(conectionString))
            {
                string query = StatusReservations.GetAllStatusesQuery;

                connection.Open();
                return connection.Query<StatusReservationsDto>(query).ToList();
            }
        }

        public void InsertStatus(StatusReservationsDto status)
        {
            string conectionString = Options.ConectionString;
            using (var connection = new NpgsqlConnection(conectionString))
            {
                string query = StatusReservations.InsertStatusQuery;
                var args = new { status.Name };

                connection.Open();
                connection.Execute(query, args);
            }
        }

        public void UpdateStatus(StatusReservationsDto status)
        {
            string conectionString = Options.ConectionString;
            using (var connection = new NpgsqlConnection(conectionString))
            {
                string query = StatusReservations.UpdateStatusQuery;
                var args = new { status.Name, status.Id };

                connection.Open();
                connection.Execute(query, args);
            }
        }

        public void DeleteStatusById(int id)
        {
            string conectionString = Options.ConectionString;
            using (var connection = new NpgsqlConnection(conectionString))
            {
                string query = StatusReservations.DeleteStatusByIdQuery;
                var args = new { id };

                connection.Open();
                connection.Execute(query, args);
            }
        }
    }
}
