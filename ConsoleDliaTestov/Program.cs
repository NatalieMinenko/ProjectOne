using Dapper;
using Npgsql;
using NailStudio.DAL;
using NailStudioBot.Core.Dtos;
using System.Collections.Generic;
using System.IO;
using NailStudioBot.BLL;

namespace ConsoleDliaTestov
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(Environment.GetEnvironmentVariable("Bot"));

            //1.Users - Тест Add/Update/GetAllUsers Users - работает.
            //UserRepository userRepository = new UserRepository();
            //userRepository.AddUser("Svetik");
            //userRepository.UpdateUser(new UsersDto() { Name = "Ksenia", Id = 5 });
            //var a = userRepository.GetAllUsers();

            UserRepository userRepository = new UserRepository();
            userRepository.AddUser("TestTest2");
            var a = userRepository.GetAllUsers();

            //2.Users - GetUsersById 
            //UserRepository userRepository = new UserRepository(2);
            //var a = userRepository.GetUsersById();

            //3.Users - DeleteUsers - работает
            //UserRepository userRepository1 = new UserRepository();
            //userRepository1.DeleteUsers(48);
            //var a = userRepository1.GetAllUsers();

            //Console.WriteLine();

            //4.UserRoles - Add|GetAll UserRoles - работает!
            //UserRolesRepository userRolesRepository = new UserRolesRepository();
            //userRolesRepository.AddUserRoles("Test");
            //var a = userRolesRepository.GetAllUserRoles();

            //Console.WriteLine(a.Count);

            //ServicesServices servicesServices = new ServicesServices();
            //var gg = servicesServices.GetAllServices();
            //Console.WriteLine();


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
    
