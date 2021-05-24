using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
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
        //// GET: Tweet
        //public IActionResult Index()
        //{
        //    if (User.Identity.IsAuthenticated)
        //    {
        //        return View(tweetService.GetActive().
        //            OrderByDescending(d => d.ID).ToList());
        //    }
        //    else
        //    {
        //        return Redirect("/Account/Login");
        //    }
        //}

        //// GET: Tweet/Details/5
        //public IActionResult Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var tweet = tweetService.GetDefault(p => p.ID.Equals(id));

        //    if (tweet == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(tweet);
        //}

        public IActionResult HomeTweet()
        {
            return View();
        }

        [HttpPost]
        public IActionResult HomeTweet(Tweet item)
        {
            return View(item);
        }

        public IActionResult Profile()
        {
            return View();
        }



    }
}
