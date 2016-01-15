using PSDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PSDemo.Controllers
{
    public class DocumentController : Controller
    {
        // GET: Document
        public ActionResult Index()
        {
            List<LineItem> lineItems = new List<LineItem>() 
            {
                new LineItem() { LineItemID = 1, Text = "Title row", PreviousValue = null, CurrentValue = null, RowFormat = new StyleFormat() { IsBold = true} },
                new LineItem() { LineItemID = 2, Text = "Regular text row 1", PreviousValue = 1222, CurrentValue = 1234 },
                new LineItem() { LineItemID = 3, Text = "Regular text row 2", PreviousValue = 486, CurrentValue = 756 },
                new LineItem() { LineItemID = 4, Text = "Regular text row 3", PreviousValue = 325, CurrentValue = 654 },
                new LineItem() { LineItemID = 5, Text = "Totals row", PreviousValue = 2645, CurrentValue = 3245, RowFormat = new StyleFormat() { IsBold = true}  }
            };

            TableHeader tblHeader = new TableHeader()
            {
                DescriptionHeader = "Description",
                PreviousDateHeader = "As at " + new DateTime(2015, 02, 28).ToString("dd MMMM yyyy"),
                CurrentDateHeader = "As at " + new DateTime(2015, 08, 31).ToString("dd MMMM yyyy"),
                RowFormat = new StyleFormat() { BackgroundColor = "#A4A4A4", IsBold = true}
            };

            Document bs = new Document()
            {
                DocumentID = 123456,
                TableHeader = tblHeader,
                LineItems = lineItems
            };
            return View(bs);
        }


        public ActionResult LineItems()
        {
            List<LineItem> lineItems = new List<LineItem>() 
            {
                new LineItem() { LineItemID = 1, Text = "Title row", PreviousValue = null, CurrentValue = null },
                new LineItem() { LineItemID = 2, Text = "Regular row 1", PreviousValue = 1222, CurrentValue = 1234 },
                new LineItem() { LineItemID = 3, Text = "Regular text row 2", PreviousValue = 486, CurrentValue = 756 },
                new LineItem() { LineItemID = 4, Text = "Regular text row 3", PreviousValue = 325, CurrentValue = 654 },
                new LineItem() { LineItemID = 5, Text = "Totals row", PreviousValue = 2645, CurrentValue = 3245 }
            };

            return View(lineItems);
        }










        // GET: Document/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Document/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Document/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Document/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Document/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Document/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Document/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
