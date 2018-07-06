using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Todo.Models;
using Todo.Repository;

namespace Todo.Services
{
    public class TodoService
    {
        TodoRepository todoRepository;

        public TodoService(TodoRepository todoRepository)
        {
            this.todoRepository = todoRepository;
        }

        public List<TodoModel> ListAll()
        {
            return todoRepository.ListAll();
        }

        public void AddTodo(TodoModel todo)
        {
            todoRepository.AddTodo(todo);
        }

        public void ChangeUrgent(long id)
        {
            todoRepository.ChangeUrgent(id);
        }

        public void ChangeDone(long id)
        {
            todoRepository.ChangeDone(id);
        }

        public void DeleteTodo(long id)
        {
            todoRepository.DeleteTodo(id);
        }

        public List<TodoModel> Search(string input)
        {
            return todoRepository.Search(input);
        }
    }
}
