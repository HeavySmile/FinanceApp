using FinanceApp.MVVM.ViewModels;

namespace FinanceApp.MVVM.Views;

public partial class TransactionsView : ContentPage
{
	public TransactionsView()
	{
		InitializeComponent();
		BindingContext = new TransactionsViewModel();
	}

    private async void Save_Clicked(object sender, EventArgs e)
    {
        var currentViewModel = BindingContext as TransactionsViewModel;
        var message = currentViewModel.SaveTransaction();
        await DisplayAlert("Info", message, "OK");
        await Navigation.PopToRootAsync();
    }

    private async void Cancel_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopToRootAsync();
    }
}