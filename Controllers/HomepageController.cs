using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HotelApp.Controllers
{
    public class HomepageController : Controller
    {
       
        public ActionResult Homepage()
        {
            return View();
        }
        public ActionResult HomepageLayout()
        {
            return View();
        }
    }
}
