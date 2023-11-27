using FinanceApp.MVVM.ViewModels;
using PropertyChanged;

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

    protected override void OnAppearing()
    {
        base.OnAppearing();
        var vm = (DashboardViewModel)BindingContext;
        vm.FillData();
    }
}

