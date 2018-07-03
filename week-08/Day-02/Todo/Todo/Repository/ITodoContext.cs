using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Todo.Models;

namespace Todo.Repository
{
    interface ITodoContext
    {
        List<TodoModel> ListAll();
        void AddTodo(TodoModel todo);
    }
}
