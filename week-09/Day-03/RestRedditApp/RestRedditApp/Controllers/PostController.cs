using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RestRedditApp.Models;
using RestRedditApp.Services;

namespace RestRedditApp.Controllers
{
    [Produces("application/json")]
    [Route("")]
    public class PostController : Controller
    {
        private IService database;

        public PostController(IService database)
        {
            this.database = database;
        }

        [HttpGet("/posts")]
        public IActionResult GetPosts()
        {
            return Json(new { posts = database.GetAllPost() });
        }

        [HttpPost("/posts")]
        public IActionResult AddPost([FromBody]Post post)
        {
            database.AddNewPost(post);
            return RedirectToAction("GetPosts");
        }

        [HttpPut("/posts/{id}/upvote")]
        public IActionResult UpVote(int id)
        {
            database.UpVote(id);
            return RedirectToAction("GetPosts");
        }

        [HttpPut("/posts/{id}/downvote")]
        public IActionResult DownVote(int id)
        {
            database.DownVote(id);
            return RedirectToAction("GetPosts");
        }
    }
}