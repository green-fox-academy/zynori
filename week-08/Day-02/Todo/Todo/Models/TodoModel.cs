using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Todo.Repository;

namespace Todo.Models
{
    public class TodoModel
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public bool IsUrgent { get; set; }
        public bool IsDone { get; set; }
    }
}
