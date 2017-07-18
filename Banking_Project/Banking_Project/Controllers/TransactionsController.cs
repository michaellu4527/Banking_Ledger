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
        User account = new User();
        //private TransactionsController balance = new AccountViewModels
        
        // GET: Transactions/Deposit
        // Handles depositing money into an account
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
            account.Balance = account.Balance + deposit;
            return View();
        }

        // GET: Transactions/Withdraw
        // Handles withdrawing money from an account. Subtracts withdrawn amount from total balance.
        public ActionResult Withdraw()
        {
            return View();
        }

        // GET: Transactions/Balance
        // Simply returns the current balance on the account
        public ActionResult Balance(double withdraw)
        {
            account.Balance = account.Balance - withdraw;
            return View();
        }

        // GET: Transactions/History
        // Returns the past 5 transactions made on the account
        public ActionResult History()
        {
            return View();
        }
    }
}