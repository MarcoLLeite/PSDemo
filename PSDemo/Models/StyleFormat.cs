using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSDemo.Models
{
    public class StyleFormat
    {
        public bool IsBold { get; set; }

        public string BackgroundColor { get; set; }

        public string DescriptionHorizontalAlignment { get; set; }
        public string PreviousDateHorizontalAlignment { get; set; }
        public string CurrentDateHorizontalAlignment { get; set; }
        

        public StyleFormat()
        {
            this.IsBold = false;
            this.BackgroundColor = "";

            this.DescriptionHorizontalAlignment = "left";
            this.PreviousDateHorizontalAlignment = "right";
            this.CurrentDateHorizontalAlignment = "right";

        }
    }
}