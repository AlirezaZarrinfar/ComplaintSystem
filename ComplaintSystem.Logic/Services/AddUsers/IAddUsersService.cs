using ComplaintSystem.Model;
using ComplaintSystem.Utilities.ViewModels;
using System.Collections.Generic;

namespace ComplaintSystem.Logic.Services
{
    public interface IAddUsersService
    {
        bool addUsers(UserViewModel model);
    }
}
