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

            if (userService.Any(x => (x.Email == user.UserNameOrEmail || x.Username == user.UserNameOrEmail)
            && x.Password == user.Password && x.Status == Status.Active))
            {

                User logged = userService.GetByDefaults(
                   x => (x.Email == user.UserNameOrEmail || x.Username == user.UserNameOrEmail)
            && x.Password == user.Password);

                var claims = new List<Claim>()
                {
                    new Claim("ID", logged.ID.ToString()),
                    new Claim(ClaimTypes.Email, logged.Email),
                    new Claim(ClaimTypes.Name, logged.Username)
                };
                var userIdentity = new ClaimsIdentity(claims, "login");
                ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);
                await HttpContext.SignInAsync(principal);
                return RedirectToAction("Home", "Twitter");
            }
            else
            {
                TempData["Message"] = "Aktif Kullanıcı Değilsiniz!";
            }
            return View();
        }

        [HttpGet]
        public IActionResult SignUpOrLogin()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SignUpOrLogin(User user)
        {
            if (ModelState.IsValid)
            {
                if (!userService.Any(x => x.Email == user.Email))
                {
                    if (userService.Add(user))
                    {
                        return RedirectToAction("Login", "Account");
                    }
                    else
                    {
                        TempData["Message"] = "Kayıt işlemi sırasında bir hata oluştu. Lütfen tüm alanları kontrol edip, tekrar deneyiniz.";
                    }
                }
                else
                {
                    TempData["Message"] = "Kayıtlı e-posta adresi girdiniz. Lütfen farklı bir e-posta adresi giriniz.";
                }
            }
            else
            {
                TempData["Message"] = "İşlem başarısız oldu.";
            }
            return View(user);
        }

    }


}
