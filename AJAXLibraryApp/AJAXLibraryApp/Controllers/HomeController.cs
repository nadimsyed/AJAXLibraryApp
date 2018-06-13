using AJAXLibraryApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AJAXLibraryApp.Controllers
{
    public class HomeController : Controller
    {
        //TODO: for extended challenge try on same line and comment out 3 fields
        //TODO: for distinct author in javascript
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult GetBooksByAuthor(string author)
        {
            LibraryEntities db = new LibraryEntities();

            List<book> list = db.books.Where(
               c => c.Author.Contains(author)
                ).ToList();

            return Json(list);
        }

        [HttpPost]
        public ActionResult GetBooksByTitle(string title)
        {
            LibraryEntities db = new LibraryEntities();

            List<book> list = db.books.Where(
               c => c.Title.Contains(title)
                ).ToList();

            return Json(list);
        }

        [HttpPost]
        public ActionResult GetBooksByYear(int? year)
        {
            LibraryEntities db = new LibraryEntities();

            List<book> list = db.books.Where(
               c => c.YearPublished == year
                ).ToList();

            return Json(list);
        }

        [HttpPost]
        public ActionResult GetBooksByPublisher(string publisher)
        {
            LibraryEntities db = new LibraryEntities();

            List<book> list = db.books.Where(
               c => c.Publisher.Contains(publisher)
                ).ToList();

            return Json(list);
        }

        //[HttpPost]
        //public ActionResult GetBooksByAuthorTitleYear(string mash)
        //{
        //    LibraryEntities db = new LibraryEntities();

        //    string[] rat = mash.Split(' ');

        //    foreach (string item in rat)
        //    {
        //        bool truth = int.tryParse(item, out int year);
        //        if (truth)
        //        {
        //            List<book> listYear = db.books.Where(
        //               c => c.YearPublished == year
        //                ).ToList();
        //        }
        //    }

        //    List<book> list = db.books.Where(
        //       c => c.Publisher.Contains(mash)
        //        ).ToList();

        //    return Json(list);
        //}
    }
}