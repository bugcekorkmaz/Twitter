using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public TwitterController(ICoreService<User> userService, ICoreService<Tweet> tweetService,IWebHostEnvironment env)
        {
            this.userService = userService;
            this.tweetService = tweetService;
            this.env = env;
        } 

        public IActionResult Home()
        {
            return View();
        }

        public IActionResult Profile()
        {
            return View();
        }



    }
}
