using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Todo.Models;

namespace Todo.Repository
{
    public class TodoRepository : ITodoContext
    {
        private TodoContext todoContext;

        public TodoRepository(TodoContext todoContext)
        {
            this.todoContext = todoContext;
        }

        public List<TodoModel> ListAll()
        {
            return todoContext.Todos.ToList();
        }

        public void AddTodo(TodoModel todo)
        {
            todoContext.Todos.Add(todo);
            todoContext.SaveChanges();
        }
    }
}
