using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
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

        public IActionResult Index()
        {
            return View("Index");
        }

        [Route("todo/list")]
        public IActionResult List()
        {
            return View("List");
        }
    }
}