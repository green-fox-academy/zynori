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
        private PostRepository postRepository;

        public PostService(PostRepository postRepository)
        {
            this.postRepository = postRepository;
        }

        public List<Post> GetPosts()
        {
            return postRepository.ListAll();
        }

        public void Submit(Post post)
        {
            postRepository.Create(post);
        }
    }
}
