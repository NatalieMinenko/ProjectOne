﻿using NailStudio.DAL.Querys;
using NailStudioBot.Core.Dtos;
using Dapper;
using Npgsql;
using NailStudioBot.Core;


namespace NailStudio.DAL
{
    public class UserRolesRepository
    {
        public void AddUserRoles(string name)
        {
            string conectionString = Options.ConectionString;
            using (var connection = new NpgsqlConnection(conectionString))
            {
                string query = UserRolesQuerys.AddUserRolesQuery;
                var args = new { @Name = name, Id = 4 };

                connection.Open();
                connection.Query(query, args);
            }
        }
        public void UpdateUserRoles(UserRolesDto userRoles)
        {
            string conectionString = Options.ConectionString;
            using (var connection = new NpgsqlConnection(conectionString))
            {
                string query = UserRolesQuerys.UpdateUserRolesQuery;
                var args = new { name = userRoles.Name, id = userRoles.Id };

                connection.Open();
                connection.Query(query, args);
            }
        }
        public List<UserRolesDto> GetAllUserRoles()
        {
            string conectionString = Options.ConectionString;
            using (var connection = new NpgsqlConnection(conectionString))
            {
                string query = UserRolesQuerys.GetAllUserRolesQuery;

                connection.Open();
                return connection.Query<UserRolesDto>(query).ToList();
            }
        }

        public List<UsersDto> GetUserRolesById()
        {
            string conectionString = Options.ConectionString;
            using (var connection = new NpgsqlConnection(conectionString))
            {
                string query = UserRolesQuerys.GetUserRolesByIdQuery;

                connection.Open();
                return connection.Query<UserRolesDto>(query).ToList();
            }
        }

        public void DeleteUserRoles(UserRolesDto userRoles)
        {
            string conectionString = Options.ConectionString;
            using (var connection = new NpgsqlConnection(conectionString))
            {
                string query = UserRolesQuerys.DeleteUserRolesQuery;
                var args = new { name = userRoles.Name, id = userRoles.Id };

                connection.Open();
                connection.Query(query, args);
            }
        }
    }


}
