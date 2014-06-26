using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebSite.Controllers
{
    public class HomeController: Controller
    {
        public ActionResult Index()
        {
            ViewBag.PersonName = "Shailesh";
            return View();
        }
        public ActionResult AbClient()
        {
            AbObjects.IPerson client = new AbObjects.Implementation.Person();
            client.FirstName = "Shailesh";
            client.LastName = "Bagade";

            return View(client);
        }
    }
}