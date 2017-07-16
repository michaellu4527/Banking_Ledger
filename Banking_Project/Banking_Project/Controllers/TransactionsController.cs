using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Banking_Project.Models;

namespace Banking_Project.Controllers
{
    public class TransactionsController : Controller
    {
        //private TransactionsController balance = new AccountViewModels
        // GET: Transactions/Deposit
        [HttpGet]
        public ActionResult Deposit()
        {
            // Need to add deposited money to total balance. Then update cache accordingly
            // balance = balance + deposit

            

            return View();
        }

        [HttpPost]
        public ActionResult Deposit(double deposit)
        {
            //total = total + deposit;
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