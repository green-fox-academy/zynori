using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestRedditApp.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public int TimeStamp { get; set; }
        public int Score { get; set; }
    }
}
