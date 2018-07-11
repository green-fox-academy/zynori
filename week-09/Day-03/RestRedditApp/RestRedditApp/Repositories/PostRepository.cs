using RestRedditApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestRedditApp.Repositories
{
    public class PostRepository : IPostRepository<Post>
    {
        private PostContext postContext;

        public PostRepository(PostContext postContext)
        {
            this.postContext = postContext;
        }

        public void Create(Post post)
        {
            postContext.Add(post);
            postContext.SaveChanges();
        }

        public List<Post> ReadAllPost()
        {
            return postContext.Posts.ToList();
        }

        public Post GetPost(int id)
        {
            return postContext.Posts.FirstOrDefault(p => p.Id == id);
        }

        public void Update(Post post)
        {
            postContext.Update(post);
            postContext.SaveChanges();
        }

        public void Delete(Post post)
        {
            postContext.Remove(post);
            postContext.SaveChanges();
        }
    }
}
