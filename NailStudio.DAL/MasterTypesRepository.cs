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
                var args = new { Name = name };

                connection.Open();
                connection.Query(query, args);
            }
        }

        public void UpdateMasters(MasterTypesDto masterTypes)
        {
            string conectionString = Options.ConectionString;
            using (var connection = new NpgsqlConnection(conectionString))
            {
                string query = MasterTypesQuerys.UpdateMastersQuery;
                var args = new { name = masterTypes.Name, id = masterTypes.Id };

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
        public void DeleteMasterTypesById(int id)
        {
            string conectionString = Options.ConectionString;
            using (var connection = new NpgsqlConnection(conectionString))
            {
                string query = MasterTypesQuerys.DeleteMasterTypesByIdQuery;
                var args = new { id };

                connection.Open();
                connection.Query(query, args);
            }
        }
    }
}
