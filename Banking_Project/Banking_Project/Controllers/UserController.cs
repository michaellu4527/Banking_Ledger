using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Banking_Project.Models;

namespace Banking_Project.Controllers
{
    public class UserController : Controller
    {
        User user = new User();

        public UserController()
        {
            Guid guid = Guid.NewGuid();
            string accountID = guid.ToString();
            user.AccountID = accountID;
            user.Balance = 100;
        }
        // GET: User
        public ActionResult Index()
        {
            return View();
        }
    }
}