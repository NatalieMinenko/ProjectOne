using NailStudio.DAL.Querys;
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
                var args = new { Name = name };

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

        public List<UserRolesDto> GetUserRolesById(int id)
        {
            string conectionString = Options.ConectionString;
            using (var connection = new NpgsqlConnection(conectionString))
            {
                string query = UserRolesQuerys.GetUserRolesByIdQuery;
                var args = new { id };

                connection.Open();
                return connection.Query<UserRolesDto>(query).ToList();
            }
        }

        public void DeleteUserRoles(int id)
        {
            string conectionString = Options.ConectionString;
            using (var connection = new NpgsqlConnection(conectionString))
            {
                string query = UserRolesQuerys.DeleteUserRolesQuery;
                var args = new { id };

                connection.Open();
                connection.Query(query, args);
            }
        }
    }


}
