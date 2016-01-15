using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PSDemo.Models
{
    public class Document
    {
        [Key]
        public long DocumentID { get; set; }
                
        public TableHeader TableHeader { get; set; }

        public List<LineItem> LineItems { get; set; }


    }
}