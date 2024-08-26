using Dapper;
using Npgsql;
using NailStudioBot.DAL;
using NailStudioBot.Core.Dtos;
using System.Collections.Generic;
using System.IO;

namespace ConsoleDliaTestov
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserRepository userRepository = new UserRepository();

            userRepository.UpdateUser(new UsersDto() { Name = "AAAAA", Id = 1 });

            var a = userRepository.GetAllUsers();

            Console.WriteLine(a.Count);


            //string conectionString = "Server=localhost; Port=5432; User Id=postgres; Password=postgres; Database=MyFirstDB;";
            //using (var connection = new NpgsqlConnection(conectionString))
            //{
            //    string query = "INSERT INTO \"Users\"(\"Name\") VALUES ('Olga');";
            //    connection.Open();
            //    connection.Query(query);
            //}
        }
    }
}
    
