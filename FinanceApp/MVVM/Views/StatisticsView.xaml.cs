using FinanceApp.MVVM.ViewModels;

namespace FinanceApp.MVVM.Views;

public partial class StatisticsView : ContentPage
{
	public StatisticsView()
	{
		InitializeComponent();
		BindingContext = new StatisticsViewModel();
	}

    protected override void OnAppearing()
    {
        var vm = (StatisticsViewModel)BindingContext;
        vm.GetTransactionsSummary();
    }
}