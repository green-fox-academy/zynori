using RedditApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedditApp.Repositories
{
    public class PostRepository
    {
        private PostContext postContext;

        public PostRepository(PostContext postContext)
        {
            this.postContext = postContext;
        }

        public List<Post> ListAll()
        {
            return postContext.Posts.ToList();
        }

        public void Create(Post post)
        {
            postContext.Posts.Add(post);
            postContext.SaveChanges();
        }
    }
}
