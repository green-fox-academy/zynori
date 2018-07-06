using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RedditApp.Models;
using RedditApp.Services;

namespace RedditApp.Controllers
{
    [Route("")]
    public class RedditController : Controller
    {
        PostService postService;

        public RedditController(PostService postService)
        {
            this.postService = postService;
        }

        public IActionResult Index()
        {
            return View(postService.ListAll());
        }

        [HttpGet("/submit")]
        public IActionResult Submit()
        {
            return View();
        }

        [HttpPost("/submit")]
        public IActionResult Submit(Post post)
        {
            return Redirect("Index");
        }
    }
}