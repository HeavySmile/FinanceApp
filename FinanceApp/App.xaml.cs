using FinanceApp.MVVM.Views;

namespace FinanceApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new TransactionsView();

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
                    handler.PlatformView.BorderStyle = UIKit.UITextBorderStyle.None;
#endif
            });
        }
    }
}