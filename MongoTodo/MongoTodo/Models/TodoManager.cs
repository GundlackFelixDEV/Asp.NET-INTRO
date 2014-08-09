using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MongoTodo.Models
{
    public class TodoManager
    {
        private static List<Todo> todoItems;

        public TodoManager()
        {
            if (todoItems == null)
                todoItems = new List<Todo>();

        }

        public List<Todo> allItems
        {
            get
            {
                return todoItems;
            }
        }

        public void newItem(Todo aItem)
        {
            var newId = (todoItems.Count == 0)?1:todoItems.Max(t => t.Id);
            aItem.Id = newId;
            todoItems.Add(aItem);
        }

        public Todo findItem(int id)
        {
            return todoItems.FirstOrDefault(i => i.Id == id);
        }

        public void editItem(Todo aItem)
        {
            Todo item = findItem(aItem.Id);
            if(item != null)
            {
                item.Description = aItem.Description;
                item.Titel = aItem.Titel;
                item.Due = aItem.Due;
                item.Priority = aItem.Priority;
                item.Change = DateTime.Now;
            }
            else
            {
                throw(new InvalidOperationException(string.Format("Item {0} not found!",aItem.Id));
            }
        }


    }
}