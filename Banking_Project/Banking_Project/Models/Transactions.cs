using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Banking_Project.Models
{
    public class TransactionsViewModel
    {
        [Display(Name = "Balance")]
        public double Balance { get; set; }

        [Display(Name = "Account Number")]
        public string AccountID { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }

    }
}