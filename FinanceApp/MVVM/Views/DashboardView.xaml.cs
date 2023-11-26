using FinanceApp.MVVM.ViewModels;

namespace FinanceApp.MVVM.Views;

public partial class DashboardView : ContentPage
{
	public DashboardView()
	{
		InitializeComponent();
		BindingContext = new DashboardViewModel();
	}

    private async void AddTransaction_Clicked(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new TransactionsView());
    }
}