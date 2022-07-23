using ComplaintSystem.Logic.Services;
using ComplaintSystem.Model;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComplaintSystem
{
    public class Program
    {

        public static void Main(string[] args)
        {
            User user1 = new User { Id = 0, Name = "ali", Role = "admin" };
            User user2 = new User { Id = 1, Name = "reza", Role = "customer" };
            AddUsersService.users = new List<User>();
            AddUsersService.users.Add(user1);
            AddUsersService.users.Add(user2);
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
