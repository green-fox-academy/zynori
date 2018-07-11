using RestRedditApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestRedditApp.Services
{
    public interface IService
    {
        List<Post> GetAllPost();
        void AddNewPost(Post post);
        void UpVote(int id);
        void DownVote(int id);
    }
}
