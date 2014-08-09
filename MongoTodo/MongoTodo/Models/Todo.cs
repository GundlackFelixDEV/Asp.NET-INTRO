using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MongoTodo.Models
{
    [MetadataType(typeof(EventMetaData))]
    public class Todo
    {
        public Todo()
        {
            Id = -1;
            Create = DateTime.Now;
            Due = DateTime.Now.AddDays(1);
            Change = DateTime.Now;
        }
        public string Titel { get; set; }
        public string Description { get; set; }
        public int Priority { get; set; }
        public int Id { get; set; }
        public DateTime Create { get; set; }
        public DateTime Change { get; set; }
        public DateTime Due { get; set; }
    }

    public class EventMetaData
    {
        [DisplayFormat(DataFormatString = "{0:dd\\/MMMM\\/yy}")]
        public object Create;

        [DisplayFormat(DataFormatString = "{0:dd\\/MMMM\\/yy}")]
        public object Change;

        [DisplayFormat(DataFormatString = "{0:dd\\/MMMM\\/yy}")]
        public object Due;

        [Required, StringLength(32, ErrorMessage = "{0} darf aus max. {1} Zeichen bestehen.")]
        public object Titel;

        [StringLength(256, ErrorMessage = "{0} darf aus max. {1} Zeichen bestehen.")]
        public object Description;
    }


}