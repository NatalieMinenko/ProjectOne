﻿using Dapper;
using Npgsql;
using NailStudioBot.Core;
using NailStudio.DAL.Querys;
using NailStudioBot.Core.Dtos;

namespace NailStudio.DAL
{
    public class UserRepository
    {
        public void AddUser(string name)
        {
            string conectionString = Options.ConectionString;
            using (var connection = new NpgsqlConnection(conectionString))
            {
                string query = UserQuerys.AddUserQuery;
                var args = new {name = name};

                connection.Open();
                connection.Query(query, args);
            }
        }
        public void UpdateUser(UserDto user)
        {
            string conectionString = Options.ConectionString;
            using (var connection = new NpgsqlConnection(conectionString))
            {
                string query = UserQuerys.UpdateUserQuery;
                var args = new {name = user.Name, id = user.Id };

                connection.Open();
                connection.Query(query, args);
            }
        }
        public List<UserDto> GetAllUsers()
        {
            string conectionString = Options.ConectionString;
            using (var connection = new NpgsqlConnection(conectionString))
            {
                string query = UserQuerys.GetAllUsersQuery;

                connection.Open();
                return connection.Query<UserDto>(query).ToList();
            }
        }
    }
}
