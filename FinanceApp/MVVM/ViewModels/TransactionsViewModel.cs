using FinanceApp.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceApp.MVVM.ViewModels
{
    public class TransactionsViewModel
    {
        public Transaction Transaction { get; set; } = new Transaction();
        
        public string SaveTransaction()
        {
            App.TransactionsRepo.SaveItem(Transaction);
            return App.TransactionsRepo.StatusMessage;
        }
    }
}
