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

        public void Like(int id)
        {
            postRepository.ReadOneElement(id).Like++;
            postRepository.Update(postRepository.ReadOneElement(id));
        }

        public void Dislike(int id)
        {
            postRepository.ReadOneElement(id).Dislike++;
            postRepository.Update(postRepository.ReadOneElement(id));
        }
    }
}
