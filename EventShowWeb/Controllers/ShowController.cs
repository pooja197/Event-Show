using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EventShowWeb.Controllers
{
    public class ShowController : Controller
    {
        // GET: Show
        public ActionResult Index()
        {
            var model = new NoteListItem[0];
            return View();
        }
        public ActionResult Create()
        {
            return View();
        }
    }
}