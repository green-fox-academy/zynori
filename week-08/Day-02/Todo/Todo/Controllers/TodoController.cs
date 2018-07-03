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
    }
}