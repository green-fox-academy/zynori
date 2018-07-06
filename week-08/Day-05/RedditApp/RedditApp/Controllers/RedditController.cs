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
        private PostService postService;

        public RedditController(PostService postService)
        {
            this.postService = postService;
        }

        public IActionResult Index()
        {
            return View(postService.GetPosts());
        }

        [HttpGet("/submit")]
        public IActionResult Submit()
        {
            return View();
        }

        [HttpPost("/submit")]
        public IActionResult Submit(Post post)
        {
            postService.Submit(post);
            return RedirectToAction("Index");
        }
    }
}