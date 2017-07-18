using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Banking_Project.Controllers
{
    public class HomeController : Controller
    {
        // Simply displays the Bank home page. Doesn't need to do anything else.
        public ActionResult Index()
        {
            return View();
        }
    }
}