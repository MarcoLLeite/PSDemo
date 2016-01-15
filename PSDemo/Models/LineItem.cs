using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PSDemo.Models
{
    public class LineItem
    {
        [Key]
        public long LineItemID { get; set; }

        public StyleFormat RowFormat { get; set; }
        
        public string Text { get; set; }

        public double? PreviousValue { get; set; }

        public double? CurrentValue { get; set; }

        public LineItem()
        { 
            this.RowFormat = new StyleFormat(); 
        }

    }
}