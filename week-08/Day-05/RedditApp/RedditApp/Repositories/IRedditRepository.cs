using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedditApp.Repositories
{
    interface IRedditRepository<Type>
    {
        void Create(Type type);
        List<Type> ListAll();
        Type ReadOneElement(int id);
        void Update(Type type);
        void Delete(Type type);
    }
}
