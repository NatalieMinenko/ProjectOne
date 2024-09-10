using Dapper;
using Npgsql;
using NailStudioBot.Core;
using NailStudio.DAL.Querys;
using NailStudioBot.Core.Dtos;

namespace NailStudio.DAL
{
    public class UserRepository
    {
        public void AddUser(string name, string phone)
        {
            string conectionString = Options.ConectionString;
            using (var connection = new NpgsqlConnection(conectionString))
            {
                string query = UserQuerys.AddUserQuery;
                var args = new { Name = name, RoleId=1, MasterTypeId = 3, Phone = phone};

                connection.Open();
                connection.Query(query, args);
            }
        }
        public void UpdateUser(UsersDto user)
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
        public List<UsersDto> GetAllUsers()
        {
            string conectionString = Options.ConectionString;
            using (var connection = new NpgsqlConnection(conectionString))
            {
                string query = UserQuerys.GetAllUsersQuery;

                connection.Open();
                return connection.Query<UsersDto>(query).ToList();
            }
        }

        public UsersDto GetUserById(int id)
        {
            string conectionString = Options.ConectionString;
            using (var connection = new NpgsqlConnection(conectionString))
            {
                string query = UserQuerys.GetUsersByIdQuery;
                var args = new { id };

                connection.Open();
                return connection.QuerySingleOrDefault<UsersDto>(query, args); //можно получить 1 или null
            }
        }

        public void DeleteUsers(int id)
        {
            string conectionString = Options.ConectionString;
            using (var connection = new NpgsqlConnection(conectionString))
            {
                string query = UserQuerys.DeleteUserQuery;
                var args = new { id };

                connection.Open();
                connection.Query(query, args);
            }
        }
    }
}
