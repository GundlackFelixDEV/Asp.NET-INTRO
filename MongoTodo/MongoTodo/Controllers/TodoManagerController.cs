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

        [HttpPost]
        public ActionResult Add(Todo aItem)
        {            
           if (ViewData.ModelState.IsValid)
            {
                return Add(aItem.Titel);
            }
            else
            {
                return RedirectToAction("Index");
            }
        }
        public ActionResult Add(String aTitel)
        {
            if(ViewData.ModelState.IsValid)
            {
                new TodoManager().newItem(aTitel);
                return RedirectToAction("Index");
            }

            return View(aTitel);
        }

        public ActionResult AddTodo()
        {
            var model = new Todo();
            return PartialView(model);
        }

        public ActionResult EditTodo(int id)
        {
            Todo item = new TodoManager().findItem(id);
            if (item == null)
            {
                ViewData.ModelState.AddModelError("Edit",string.Format("Item {0} not found!",id));
                return RedirectToAction("Index");
            }
            return View("EditTodo", item);
        }

        [HttpPost]
        public ActionResult EditTodo(Todo aItem)
        {
            try
            {
                if(ViewData.ModelState.IsValid)
                {
                    new TodoManager().editItem(aItem);
                    ViewBag.Message = "Item edited!";
                }
                else
                {
                    return RedirectToAction("EditToDo");
                }

            }
            catch (InvalidOperationException e)
            {
                ViewData.ModelState.AddModelError("Edit", e.Message);
            }
            return RedirectToAction("Index");
        }

    }
}