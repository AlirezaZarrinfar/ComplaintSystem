using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ComplaintSystem.Logic.Services.LoginUsers
{
    public interface ILoginUsersService
    {
        string checkUserRole(int id);
    }
}
