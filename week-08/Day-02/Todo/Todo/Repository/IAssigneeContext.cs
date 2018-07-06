using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Todo.Models;

namespace Todo.Repository
{
    public interface IAssigneeContext
    {
        List<Assignee> ListAll();
        void AddAssignee(Assignee assignee);
    }
}
