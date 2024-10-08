﻿using Dapper;
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
        public void AddServices(ServicesDto services)
        {
            string conectionString = Options.ConectionString;
            using (var connection = new NpgsqlConnection(conectionString))
            {
                string query = ServicesQuerys.AddServicesQuery;
                var args = new
                {
                    name = services.Name,
                    duration = services.Duration,
                    isActive = services.IsActive,
                    isDeleted = services.IsDeleted
                };

                connection.Open();
                connection.Execute(query, args);
            }
        }
        
        public void UpdateServices(ServicesDto service)
        {
            string conectionString = Options.ConectionString;
            using (var connection = new NpgsqlConnection(conectionString))
            {
                string query = ServicesQuerys.UpdateServicesQuery;
                var args = new { service.Name, service.Duration, service.IsActive, service.IsDeleted, service.Id };

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

        public void DeleteServices(int id)
        {
            string conectionString = Options.ConectionString;
            using (var connection = new NpgsqlConnection(conectionString))
            {
                string query = ServicesQuerys.DeleteServicesQuery;
                var args = new {id};

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
                var args = new { id = service.Id };

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

        public ServicesDto GetServicesById(int id)
        {
            string conectionString = Options.ConectionString;
            using (var connection = new NpgsqlConnection(conectionString))
            {
                string query = UserQuerys.GetUsersByIdQuery;
                var args = new { id };

                connection.Open();
                return connection.QuerySingleOrDefault<ServicesDto>(query, args); //можно получить 1 или null
            }
        }

    }
}
