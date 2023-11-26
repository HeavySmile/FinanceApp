using CommunityToolkit.Mvvm.ComponentModel;
using FinanceApp.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceApp.MVVM.ViewModels
{
    public partial class DashboardViewModel : ObservableObject
    {
        public ObservableCollection<Transaction> Transactions { get; set; }
        public decimal Balance { get; set; }
        public decimal Income { get; set; }
        public decimal Expenses { get; set; }

        public DashboardViewModel()
        {
            FillData();
        }

        private void FillData()
        {
            var transactions = App.TransactionsRepo.GetItems();
            transactions = transactions.OrderByDescending(x => x.Date).ToList();
            Transactions = new ObservableCollection<Transaction>(transactions);

            Balance = 0;
            Income = 0;
            Expenses = 0;

            transactions.ForEach(x => 
            {
                if (x.IsIncome) Income += x.Amount;
                else Expenses += x.Amount;
            });

            Balance = Income - Expenses;
        }
    }
}
