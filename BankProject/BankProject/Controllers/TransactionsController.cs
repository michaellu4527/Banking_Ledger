using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BankProject.Controllers
{
    public class TransactionsController : Controller
    {
        // GET: Transactions/Deposit
        public ActionResult Deposit()
        {
            return View();
        }

        // GET: Transactions/Withdraw
        public ActionResult Withdraw()
        {
            return View();
        }

        // GET: Transactions/Balance
        public ActionResult Balance()
        {
            return View();
        }

        // GET: Transactions/History
        public ActionResult History()
        {
            return View();
        }
    }
}