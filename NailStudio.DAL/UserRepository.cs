using Dapper;
using Npgsql;
using NailStudioBot.Core;
using NailStudio.DAL.Querys;

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
        public void UpdateUser(string name)
        {
            string conectionString = Options.ConectionString;
            using (var connection = new NpgsqlConnection(conectionString))
            {
                string query = UserQuerys.UpdateUserQuery;
                var args = new { name = name, id=1 };

                connection.Open();
                connection.Query(query, args);
            }
        }
    }
}
