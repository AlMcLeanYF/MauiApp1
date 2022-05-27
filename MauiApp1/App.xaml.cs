using MauiApp1.Extensions;
using MauiApp1.Helpers;

namespace MauiApp1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            TheTheme.SetTheme();

            if (Config.Desktop)
                MainPage = new DesktopShell();
            else
                MainPage = new MobileShell();

            Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));
            Routing.RegisterRoute(nameof(SecondPage), typeof(SecondPage));

            RecurringTaskExtensions.StartTasks();
        }
    }
}