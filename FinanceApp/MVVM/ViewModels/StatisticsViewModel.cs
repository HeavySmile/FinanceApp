using FinanceApp.MVVM.Models;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceApp.MVVM.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class StatisticsViewModel
    {
        public ObservableCollection<TransactionSummary> Summary { get; set; }
        public ObservableCollection<Transaction> SpendingList { get; set; }

        public void GetTransactionsSummary()
        {
            var data = App.TransactionsRepo.GetItems();
            var result = new List<TransactionSummary>();
            var groupedTransactions = data.GroupBy(x => x.Date.Date).ToList();

            groupedTransactions.ForEach(x =>
            {
                var transactionSummary = new TransactionSummary()
                {
                    TransactionDate = x.Key,
                    TransactionTotal = x.Sum(x => x.IsIncome ? x.Amount : -x.Amount),
                    ShownDate = x.Key.ToString("dd/MM")
                };
                result.Add(transactionSummary);
            });

            result = result.OrderBy(x => x.TransactionDate).ToList();
            Summary = new ObservableCollection<TransactionSummary>(result);

            var spendingList = data.Where(x => !x.IsIncome);
            SpendingList = new ObservableCollection<Transaction>(spendingList);
        }
    }
}
