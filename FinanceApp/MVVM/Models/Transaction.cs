using FinanceApp.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceApp.MVVM.Models
{
    public class Transaction : TableData
    {
        public Transaction()
        {
            
        }
        public string Name { get; set; }
        public decimal Amount { get; set; }
        public bool IsIncome { get; set; }
        public DateTime Date { get; set; }
    }
}
