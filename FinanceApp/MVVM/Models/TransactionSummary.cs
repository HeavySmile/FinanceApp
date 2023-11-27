using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceApp.MVVM.Models
{
    public class TransactionSummary
    {
        public DateTime TransactionDate { get; set; }
        public string ShownDate { get; set; }
        public decimal TransactionTotal { get; set; }
    }
}
