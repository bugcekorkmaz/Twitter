using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Twitter.Core.Services;
using Twitter.Model.Entities;

namespace Twitter.Controllers
{
    public class AccountController : Controller
    {
        private readonly ICoreService<User> userService;
        private IWebHostEnvironment env;

        public AccountController(ICoreService<User> userService, IWebHostEnvironment env)
        {
            this.userService = userService;
            this.env = env;
        }      

    }

       
}
