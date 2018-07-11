using Microsoft.EntityFrameworkCore;
using RestRedditApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestRedditApp.Repositories
{
    public class PostContext : DbContext
    {
        public DbSet<Post> Posts { get; set; }
        public PostContext(DbContextOptions<PostContext> options) : base(options)
        {

        }
    }
}
