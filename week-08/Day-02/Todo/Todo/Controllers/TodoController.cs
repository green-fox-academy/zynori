using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Todo.Models;
using Todo.Repository;

namespace Todo.Controllers
{
    public class TodoController : Controller
    {
        private TodoRepository todoRepository;

        public TodoController(TodoRepository todoRepository)
        {
            this.todoRepository = todoRepository;
        }

        [Route("/list")]
        public IActionResult List()
        {
            return View(todoRepository.ListAll());
        }

        [HttpGet("/addTodo")]
        public IActionResult AddTodo()
        {
            return View();
        }

        [HttpPost("/addTodo")]
        public IActionResult AddTodo(TodoModel todo)
        {
            todoRepository.AddTodo(todo);
            return Redirect("List");
        }

        [HttpPost("changeUrgent")]
        public IActionResult ChangeUrgent(long id)
        {
            todoRepository.ChangeUrgent(id);
            return Redirect("List");
        }

        [HttpPost("changeDone")]
        public IActionResult ChangeDone(long id)
        {
            todoRepository.ChangeDone(id);
            return Redirect("List");
        }

        [HttpPost("deleteTodo")]
        public IActionResult DeleteTodo(long id)
        {
            todoRepository.DeleteTodo(id);
            return Redirect("List");
        }

        [HttpPost("search")]
        public IActionResult Search(string input)
        {
            return View("List", todoRepository.Search(input));
        }
    }
}