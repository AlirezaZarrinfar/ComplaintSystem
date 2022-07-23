using AutoMapper;
using ComplaintSystem.Model;
using ComplaintSystem.Utilities.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplaintSystem.Logic.Services
{

    public class AddUsersService : IAddUsersService
    {
        public static List<User> users;
        public bool addUsers(UserViewModel model)
        {
            User user = new User { Id = (users.Last().Id)+1, Name = model.Name, Role = model.Role };
            users.Add(user);
            return true;
        }
    }
}
