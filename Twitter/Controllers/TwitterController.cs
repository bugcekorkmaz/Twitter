using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using Twitter.Core.Services;
using Twitter.Model.Entities;

namespace Twitter.Controllers
{
    public class TwitterController : Controller
    {
        private readonly ICoreService<User> userService;
        private readonly ICoreService<Tweet> tweetService;
        private IWebHostEnvironment env;

        public TwitterController(ICoreService<User> userService, ICoreService<Tweet> tweetService, IWebHostEnvironment env)
        {
            this.userService = userService;
            this.tweetService = tweetService;
            this.env = env;
        }
        public IActionResult HomeTweet()
        {
            return View();
        }

        [HttpPost]
        public IActionResult HomeTweet(Tweet item)
        {

            if (ModelState.IsValid)
            {
                bool result = tweetService.Add(item);
                if (result)
                {
                    return RedirectToAction("Profile");
                }
                else
                {
                    return View(item);
                }
            }
            else
            {
                return View();
            }
        }

        public IActionResult Profile()
        {
            return View();
        }

     }
}
