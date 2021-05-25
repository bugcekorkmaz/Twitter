using Blog.Web.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Twitter.Core.Services;
using Twitter.Model.Entities;

namespace Twitter.Areas.Administrator.Controllers
{
    [Area("Administrator"), Authorize]
    public class UserController : Controller
    {
        private readonly ICoreService<User> userService;
        private IWebHostEnvironment env;

        public UserController(ICoreService<User> userService, IWebHostEnvironment env)
        {
            this.userService = userService;
            this.env = env;
        }
        public IActionResult Index()
        {
            return View(userService.GetAll());
        }
        public IActionResult Insert()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Insert(User item, List<IFormFile> files)
        {
            if (ModelState.IsValid)
            {
                Upload upload = new Upload();
                bool imgResult;
                string imgPath = upload.ImageUpload(files, env, out imgResult);

                if (imgResult)
                {
                    item.ProfileImage = imgPath;
                }
                else
                {
                    ViewBag.Message = imgPath;
                    return View(item);
                }

                bool result = userService.Add(item);

                if (result)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["Message"] = $"Kayıt işlemi sırasında bir hata oluştu." +
                        $"Lütfen tüm alanları kontrol edip tekrar deneyin.";
                }
            }
            else
            {
                TempData["Message"] = $"İşlem başarısız oldu";
            }

            return View(item);
        }
    }
}
