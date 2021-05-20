using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using Twitter.Core.Entity.Enums;
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


        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(User user)
        {

            if (userService.Any(x => x.Email == user.Email
            && x.Password == user.Password && x.Status == Status.Active))
            {
        
                User logged = userService.GetByDefaults(
                    x => x.Email == user.Email && x.Password == user.Password);

                var claims = new List<Claim>()
                {
                    new Claim("ID", logged.ID.ToString()),
                    new Claim(ClaimTypes.Email, logged.Email),
                    new Claim(ClaimTypes.Name, logged.Username)
                };
                var userIdentity = new ClaimsIdentity(claims, "login");
                ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);
                await HttpContext.SignInAsync(principal);
                return RedirectToAction("Index", "Home", new { area = "Administrator" });
            }
            else
            {
                TempData["Message"] = "Aktif Kullanıcı Değilsiniz!";
            }
            return View();
        }
    }

       
}
