using Microsoft.EntityFrameworkCore;
using RestRedditApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestRedditApp.Repositories
{
    public class RedditContext : DbContext
    {
        public DbSet<Post> Posts { get; set; }
        public DbSet<User> Users { get; set; }
        public RedditContext(DbContextOptions<RedditContext> options) : base(options)
        {

        }
    }
}
