using RestRedditApp.Models;
using RestRedditApp.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestRedditApp.Services
{
    public class PostService
    {
        PostRepository postRepository;

        public PostService(PostRepository postRepository)
        {
            this.postRepository = postRepository;
        }

        public List<Post> GetAllPost()
        {
            return postRepository.ReadAllPost();
        }

        public void AddNewPost(Post post)
        {
            postRepository.Create(post);
        }

        public void UpVote(int id)
        {
            postRepository.GetPost(id).Score++;
            postRepository.Update(postRepository.GetPost(id));
        }

        public void DownVote(int id)
        {
            postRepository.GetPost(id).Score--;
            postRepository.Update(postRepository.GetPost(id));
        }
    }
}
