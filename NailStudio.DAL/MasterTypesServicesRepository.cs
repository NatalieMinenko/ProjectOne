using NailStudio.DAL.Querys;
using NailStudioBot.Core.Dtos;
using NailStudioBot.Core;
using Npgsql;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NailStudio.DAL
{
    public class MasterTypesServicesRepository
    {
        public List<MasterType_ServicesDto> GetAllMasterTypesServices(MasterType_ServicesDto masterType_Services)
        {
            string conectionString = Options.ConectionString;
            using (var connection = new NpgsqlConnection(conectionString))
            {
                string query = MasterTypesServicesQuerys.GetAllMasterTypesServicesQuery;
                var args = new 
                {
                  masterTypeId = masterType_Services.MasterTypeId, 
                  servicesId = masterType_Services.ServicesId,
                  cost = masterType_Services.Cost
                };

                connection.Open();
                return connection.Query<MasterType_ServicesDto>(query).ToList();
            }
        }

    }
}
