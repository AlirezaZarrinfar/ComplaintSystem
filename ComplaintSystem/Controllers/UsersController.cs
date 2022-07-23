using ComplaintSystem.Logic.Services;
using ComplaintSystem.Logic.Services.LoginUsers;
using ComplaintSystem.Utilities.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComplaintSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private ILoginUsersService _loginService;
        private IAddUsersService _addUsersService;
        public UsersController(ILoginUsersService loginService , IAddUsersService addUsersService)
        {
            _loginService = loginService;
            _addUsersService = addUsersService;
        }
        [HttpGet]
        public IActionResult login(int id)
        {
            var res = _loginService.checkUserRole(id);
            return Ok(res);
        }

        [HttpPost]
        public IActionResult login(UserViewModel model)
        {
            var res = _addUsersService.addUsers(model);
            return Ok(res);
        }


    }
}
