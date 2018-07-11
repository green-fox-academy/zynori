using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestRedditApp.Repositories
{
    public interface IPostRepository<Type>
    {
        void Create(Type type);
        List<Type> ReadAllPost();
        Type GetPost(int id);
        void Update(Type type);
        void Delete(Type type);
    }
}
