using System.Linq;

namespace ComplaintSystem.Logic.Services.LoginUsers
{
    public class LoginUsersService : ILoginUsersService
    {
        public string checkUserRole(int id)
        {
            var user = AddUsersService.users.SingleOrDefault(p => p.Id == id);
            return user.Role;
        }
    }
}
