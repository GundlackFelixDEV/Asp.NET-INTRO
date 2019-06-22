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

        public List<Todo> AllItems
        {
            get
            {
                return todoItems;
            }
        }

        public void newItem(string aTitel)
        {
            var newId = (todoItems.Count == 0)?1:todoItems.Max(t => t.Id) + 1;
            Todo newItem = new Todo();
            newItem.Titel = aTitel;
            newItem.Id = newId;
            todoItems.Add(newItem);
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
                throw(new InvalidOperationException(string.Format("Item {0} not found!",aItem.Id)));
            }
        }


    }
}