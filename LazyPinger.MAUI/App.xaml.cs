using Microsoft.Maui.Controls;

namespace LazyPingerMAUI
{
    public partial class App : Application
    {
        public static IServiceProvider Services { get; private set; }

        public App(IServiceProvider services)
        {
            InitializeComponent();

            if (Application.Current is not null)
                Application.Current.UserAppTheme = AppTheme.Dark;

            MainPage = new AppShell();
            Services = services;
        }
    }
}
