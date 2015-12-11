using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EventBooker.Controllers
{
    public class EventController : Controller
    {
        // GET: Event
        public ActionResult Index()
        {
            return View();
        }

        // GET: Event
        public ActionResult Edit(int ID)
        {
            ViewBag.Message = String.Format("Your application description page. ID {0}", ID);

            return View();
        }
 
    }
}