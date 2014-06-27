using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AbObjects.Implementation;
using System.Collections;

namespace WebSite.Controllers
{
    public class HomeController: Controller
    {
        public ActionResult Index()
        {
            ViewBag.PersonName = "Shailesh";
            return View();
        }
       
        public ActionResult ClientList()
        {
            Person client1 = new Person();
            client1.FirstName = "Shailesh";
            client1.LastName = "Bagade";
            client1.PersonId = 1;
            client1.Location = "Navi Mumbai";

            Person client2 = new Person();
            client2.FirstName = "V";
            client2.LastName = "Bagade";
            client2.PersonId = 2;
            client2.Location = "Navi Mumbai";

            List<Person> clientList = new List<Person>();
            clientList.Add(client1);
            clientList.Add(client2);

            return View(clientList);
        }
    }
}