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
        RegisterViewModel model = new RegisterViewModel();

        // GET: Transactions/Deposit
        // Handles depositing money into an account
        [HttpGet]
        public ActionResult Deposit()
        {
            return View(model);
        }

        [HttpPost]
        [OutputCache (Duration=60)]
        public ActionResult Deposit(double deposit)
        {
            model.Balance = model.Balance + deposit;
            return View(model);
        }

        // GET: Transactions/Withdraw
        [HttpGet]
        public ActionResult Withdraw()
        {
            return View(model);
        }

        // POST: Transactions/Withdraw
        // Handles withdrawing money from an account. Subtracts withdrawn amount from total balance.
        [HttpPost]
        public ActionResult Withdraw(double withdraw)
        {
            model.Balance = model.Balance + withdraw;
            return View(model);
        }

        // GET: Transactions/Balance
        // Simply returns the current balance on the account
        [HttpGet]
        [OutputCache(Duration = 60)]
        public ActionResult Balance()
        {
            return View(model);
        }

        // GET: Transactions/History
        // Returns the past 5 transactions made on the account
        public ActionResult History()
        {
            return View();
        }
    }
}