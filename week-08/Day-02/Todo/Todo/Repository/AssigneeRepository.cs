using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Todo.Models;

namespace Todo.Repository
{
    public class AssigneeRepository : IAssigneeContext
    {
        private TodoContext todoContext;

        public AssigneeRepository(TodoContext todoContext)
        {
            this.todoContext = todoContext;
        }
        
        public List<Assignee> ListAll()
        {
            return todoContext.Assignees.ToList();
        }

        public void AddAssignee(Assignee assignee)
        {
            todoContext.Assignees.Add(assignee);
            todoContext.SaveChanges();
        }
        /*
        public void DeleteTodo(long id)
        {
            TodoModel toDelete = todoContext.Todos.Where(f => f.Id == id).FirstOrDefault();
            todoContext.Remove(toDelete);
            todoContext.SaveChanges();
        }

        public List<TodoModel> Search(string input)
        {
            return todoContext.Todos.Where(s => s.Title.ToLower().Contains(input.ToLower())).ToList();
        }
        */
    }
}
