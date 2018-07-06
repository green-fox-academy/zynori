using RedditApp.Models;
using RedditApp.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedditApp.Services
{
    public class PostService
    {
        PostRepository postRepository;

        public PostService(PostRepository postRepository)
        {
            this.postRepository = postRepository;
        }

        public List<Post> ListAll()
        {
            return postRepository.ListAll();
        }
    }
}
