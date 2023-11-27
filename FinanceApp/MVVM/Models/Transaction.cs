using CommunityToolkit.Mvvm.ComponentModel;
using FinanceApp.Abstractions;
using Humanizer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceApp.MVVM.Models
{
    [ObservableObject]
    public partial class Transaction : TableData
    {
        public Transaction()
        {
            
        }
        public string Name { get; set; }
        public decimal Amount { get; set; }
        public bool IsIncome { get; set; }
        public DateTime Date { get; set; }
        public string HumanDate 
        {
            get => Date.Humanize();
        }
    }
}
