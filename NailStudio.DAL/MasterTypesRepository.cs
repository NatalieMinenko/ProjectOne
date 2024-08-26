using NailStudio.DAL.Querys;
using NailStudioBot.Core;
using Npgsql;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NailStudioBot.Core.Dtos;

namespace NailStudio.DAL
{
    public class MasterTypesRepository
    {
        public void AddMasters(string name)
        {
            string conectionString = Options.ConectionString;
            using (var connection = new NpgsqlConnection(conectionString))
            {
                string query = MasterTypesQuerys.AddMastersQuery;
                var args = new { name = name };

                connection.Open();
                connection.Query(query, args);
            }
        }

        public void UpdateMasters(MasterTypesDto user)
        {
            string conectionString = Options.ConectionString;
            using (var connection = new NpgsqlConnection(conectionString))
            {
                string query = UserQuerys.UpdateUserQuery;
                var args = new { name = user.Name, id = user.Id };

                connection.Open();
                connection.Query(query, args);
            }
        }
        public List<MasterTypesDto> GetAllMasterTypes()
        {
            string conectionString = Options.ConectionString;
            using (var connection = new NpgsqlConnection(conectionString))
            {
                string query = MasterTypesQuerys.GetAllMasterTypesQuery;

                connection.Open();
                return connection.Query<MasterTypesDto>(query).ToList();
            }
        }
    }
}
