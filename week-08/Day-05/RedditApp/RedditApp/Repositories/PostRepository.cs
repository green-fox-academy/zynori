using RedditApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedditApp.Repositories
{
    public class PostRepository : IRedditRepository<Post>
    {
        private PostContext postContext;

        public PostRepository(PostContext postContext)
        {
            this.postContext = postContext;
        }

        public void Create(Post post)
        {
            postContext.Posts.Add(post);
            postContext.SaveChanges();
        }

        public List<Post> ListAll()
        {
            return postContext.Posts.ToList();
        }

        public Post ReadOneElement(int id)
        {
            Post getPost = postContext.Posts.Where(t => t.Id == id).FirstOrDefault();
            return getPost;
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
