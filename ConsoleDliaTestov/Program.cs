using Dapper;
using Npgsql;
using NailStudio.DAL;
using NailStudioBot.Core.Dtos;
using System.Collections.Generic;
using System.IO;

namespace ConsoleDliaTestov
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(Environment.GetEnvironmentVariable("Bot"));

            //UserRepository userRepository = new UserRepository();
            //userRepository.AddUser("Svetik");
            //userRepository.UpdateUser(new UsersDto() { Name = "Ksenia", Id = 5 });
            //var a = userRepository.GetAllUsers();

            UserRolesRepository userRolesRepository = new UserRolesRepository();
            userRolesRepository.AddUserRoles("Test");
            var a = userRolesRepository.GetAllUserRoles();

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
    
