﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HotelApp.Controllers
{
    public class AdminLoginController : Controller
    {
        // GET: AdminLogin
        public ActionResult AdminLoginPage()
        {
            return View();
        }   
        
        public ActionResult LoginPage() 
        {
            return View();
        }
    }
}
