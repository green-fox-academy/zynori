using Microsoft.EntityFrameworkCore;
using RedditApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedditApp.Repositories
{
    public class PostContext : DbContext
    {
        public DbSet<Post> Posts { get; set; }
        public PostContext(DbContextOptions<PostContext> options) : base(options)
        {

        }
    }
}
