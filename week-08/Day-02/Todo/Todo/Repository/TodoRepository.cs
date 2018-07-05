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
        private long idToFind;

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
        
        public void ChangeUrgent(long id)
        {
            TodoModel toChange = todoContext.Todos.Where(f => f.Id == id).FirstOrDefault();
            toChange.IsUrgent = (toChange.IsUrgent) ? false : true;
            todoContext.SaveChanges();
        }

        public void ChangeDone(long id)
        {
            TodoModel toDone = todoContext.Todos.Where(f => f.Id == id).FirstOrDefault();
            toDone.IsDone = (toDone.IsDone) ? false : true;
            todoContext.SaveChanges();
        } 

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
    }
}
