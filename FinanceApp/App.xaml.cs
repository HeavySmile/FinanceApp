using FinanceApp.MVVM.Models;
using FinanceApp.MVVM.Views;
using FinanceApp.Repositories;

namespace FinanceApp
{
    public partial class App : Application
    {
        public static BaseRepository<Transaction> TransactionsRepo { get; private set; }
        public App(BaseRepository<Transaction> _transactionRepo)
        {
            InitializeComponent();

            TransactionsRepo = _transactionRepo;
            MainPage = new AppContainer();

            Microsoft.Maui.Handlers.EntryHandler.Mapper.AppendToMapping(nameof(BorderlessEntry), (handler, view) =>
            {
#if __ANDROID__
                    handler.PlatformView.SetBackgroundColor(Android.Graphics.Color.Transparent);
#elif __IOS__
                    handler.PlatformView.BackgroundColor = UIKit.UIColor.Clear;
                    handler.PlatformView.BorderStyle = UIKit.UITextBorderStyle.None;
#endif
            });

            Microsoft.Maui.Handlers.DatePickerHandler.Mapper.AppendToMapping(nameof(BorderlessDatePicker), (handler, view) =>
            {
#if __ANDROID__
                handler.PlatformView.SetBackgroundColor(Android.Graphics.Color.Transparent);
#elif __IOS__
                    handler.PlatformView.BackgroundColor = UIKit.UIColor.Clear;
                    //handler.PlatformView.BorderStyle = UIKit.UITextBorderStyle.None;
#endif
            });
        }
    }
}