using Dapper;
using Npgsql;
using System.Collections.Generic;
using System.IO;

namespace ConsoleDliaTestov
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string conectionString = "Server=localhost; Port=5432; User Id=postgres; Password=postgres; Database=MyFirstDB;";
            using (var connection = new NpgsqlConnection(conectionString))
            {
                string query = "INSERT INTO \"Users\"(\"Name\") VALUES ('Olga');";
                connection.Open();
                connection.Query(query);
            }
        }
    }
}
    
