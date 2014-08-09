using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MongoTodo.Models;

namespace MongoTodo.Controllers
{
    public class TodoManagerController : Controller
    {
        // GET: TodoManager
        public ActionResult Index()
        {
            return View("Main",new TodoManager().AllItems);
        }
    }
}