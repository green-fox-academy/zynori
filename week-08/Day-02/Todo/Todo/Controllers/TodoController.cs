using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Todo.Models;
using Todo.Repository;
using Todo.Services;

namespace Todo.Controllers
{
    public class TodoController : Controller
    {
        private TodoService todoService;

        public TodoController(TodoService todoService)
        {
            this.todoService = todoService;
        }

        [Route("/list")]
        public IActionResult List()
        {
            return View(todoService.ListAll());
        }

        [HttpGet("/addTodo")]
        public IActionResult AddTodo()
        {
            return View();
        }

        [HttpPost("/addTodo")]
        public IActionResult AddTodo(TodoModel todo)
        {
            todoService.AddTodo(todo);
            return Redirect("List");
        }

        [HttpPost("changeUrgent")]
        public IActionResult ChangeUrgent(long id)
        {
            todoService.ChangeUrgent(id);
            return Redirect("List");
        }

        [HttpPost("changeDone")]
        public IActionResult ChangeDone(long id)
        {
            todoService.ChangeDone(id);
            return Redirect("List");
        }

        [HttpPost("deleteTodo")]
        public IActionResult DeleteTodo(long id)
        {
            todoService.DeleteTodo(id);
            return Redirect("List");
        }

        [HttpPost("search")]
        public IActionResult Search(string input)
        {
            return View("List", todoService.Search(input));
        }
    }
}