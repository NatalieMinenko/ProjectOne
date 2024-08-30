using Dapper;
using NailStudio.DAL.Querys;
using NailStudioBot.Core;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NailStudioBot.Core.Dtos;

namespace NailStudio.DAL
{
    public class ServicesRepository
    {
        public void AddServices(string name)
        {
            string conectionString = Options.ConectionString;
            using (var connection = new NpgsqlConnection(conectionString))
            {
                string query = ServicesQuerys.AddServicesQuery;
                var args = new { name = name };

                connection.Open();
                connection.Query(query, args);
            }
        }
        public void UpdateServices(ServicesDto service)
        {
            string conectionString = Options.ConectionString;
            using (var connection = new NpgsqlConnection(conectionString))
            {
                string query = ServicesQuerys.UpdateServicesQuery;
                var args = new { name = service.Name, id = service.Id };

                connection.Open();
                connection.Query(query, args);
            }
        }

        public List<ServicesDto> GetAllServices()
        {
            string conectionString = Options.ConectionString;
            using (var connection = new NpgsqlConnection(conectionString))
            {
                string query = ServicesQuerys.GetAllServicesQuery;

                connection.Open();
                return connection.Query<ServicesDto>(query).ToList();
            }
        }

        public void DeleteServices(ServicesDto service)
        {
            string conectionString = Options.ConectionString;
            using (var connection = new NpgsqlConnection(conectionString))
            {
                string query = ServicesQuerys.DeleteServicesQuery;
                var args = new { name = service.Name, id = service.Id };

                connection.Open();
                connection.Query(query, args);
            }
        }
        public void FindMasterByServiceId(ServicesDto service)
        {
            string connectionString = Options.ConectionString;
            using (var connection = new NpgsqlConnection(connectionString))
            {
                string query = ServicesQuerys.FindMasterByServiceIdQuery;
                var args = new { name = service.Name, id = service.Id };

                connection.Open();
                connection.Query(query, args);
            }
        }
        public void NameAllServices(ServicesDto service)
        {
            string connectionString = Options.ConectionString;
            using (var connection = new NpgsqlConnection(connectionString))
            {
                string query = ServicesQuerys.NameAllServicesQuery;
                var args = new { name = service.Name, id = service.Id };

                connection.Open();
                connection.Query(query, args);
            }
        }
    }
}
