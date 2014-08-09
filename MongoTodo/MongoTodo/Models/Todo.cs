using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MongoTodo.Models
{
    public class Todo
    {
        public Todo()
        {
            Id = -1;
        }
        public string Titel { get; set; }
        public string Description { get; set; }
        public int Priority { get; set; }
        public int Id { get; set; }
        public DateTime Create { get; set; }
        public DateTime Change { get; set; }
        public DateTime Due { get; set; }
    }
}