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

            //1,2,3.Users - “ест Add/Update/GetAllUsers Users - работает.
            //UserRepository userRepository = new UserRepository();
            //userRepository.AddUser("Svetik");
            //userRepository.UpdateUser(new UsersDto() { Name = "Ksenia", Id = 5 });
            //var a = userRepository.GetAllUsers();

            //UserRepository userRepository = new UserRepository();
            //userRepository.AddUser("TestTest2");
            //var a = userRepository.GetAllUsers();

            //4.Users - GetUsersById - работает
            //UserRepository userRepository2 = new UserRepository();
            //var a = userRepository2.GetUsersById(2);

            //5.Users - DeleteUsers - работает
            //UserRepository userRepository1 = new UserRepository();
            //userRepository1.DeleteUsers(58);
            //var a = userRepository1.GetAllUsers();

            //1,2,3.UserRoles - Add|GetAll UserRoles - работает!
            //UserRolesRepository userRolesRepository = new UserRolesRepository();
            //userRolesRepository.AddUserRoles("TestRoles");
            //userRolesRepository.UpdateUserRoles(new UserRolesDto() { Name = "QQQ", Id = 100 });
            //var a = userRolesRepository.GetAllUserRoles();

            //4. UserRoles - GetUserRolesId - работает
            //UserRolesRepository userRolesRepository = new UserRolesRepository();
            //var a = userRolesRepository.GetUserRolesById(1);

            //5. UserRoles - DeleteUserRoles - работает
            //UserRolesRepository userRolesRepository = new UserRolesRepository();
            //userRolesRepository.DeleteUserRoles(100);
            //var a = userRolesRepository.GetAllUserRoles();

            //1,2,3. StatusReservations - GetAllStatuses - работает
            //StatusReservationsRepository statusReservationsRepository = new StatusReservationsRepository();
            //statusReservationsRepository.AddStatus("Test");
            //statusReservationsRepository.UpdateStatus(new StatusReservationsDto() { Name = "Test2", Id = 6 });
            //var a = statusReservationsRepository.GetAllStatuses();

            //4 - StatusReservations - DeleteStatusById - работает!
            //StatusReservationsRepository statusReservationsRepository = new StatusReservationsRepository();
            //statusReservationsRepository.DeleteStatusById(6);
            //var a = statusReservationsRepository.GetAllStatuses();



            //ServicesServices servicesServices = new ServicesServices();
            //var gg = servicesServices.GetAllServices();
            //Console.WriteLine();
            //–аботает
            //ReservationsRepository reservationsRepository = new ReservationsRepository();
            //reservationsRepository.InsertReservation(new ReservationsDto() { ClientId = 3, StartDateTime = new DateTime(2015, 7, 20, 18, 30, 25), Sum=1000, IsAction=true});
            //ReservationsRepository reservationsRepository = new ReservationsRepository();
            //reservationsRepository.DeleteReservationById(10);
            //reservationsRepository.UpdateReservation(new ReservationsDto() { Id = 1, IsAction = false, StartDateTime= new DateTime(2015, 7, 20, 18, 30, 25), StatusId=2 });
            //var c =reservationsRepository.GetAllReservations();+
      

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
    
