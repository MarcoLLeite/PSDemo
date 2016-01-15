using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSDemo.Models
{
    public class TableHeader
    {

        public string DescriptionHeader { get; set; }

        public string PreviousDateHeader { get; set; }

        public string CurrentDateHeader { get; set; }

        public StyleFormat RowFormat { get; set; }

        public TableHeader()
        {
            this.RowFormat = new StyleFormat();
        }
    }
}