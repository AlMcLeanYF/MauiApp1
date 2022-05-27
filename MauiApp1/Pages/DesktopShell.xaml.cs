using MauiApp1.ViewModels;

namespace MauiApp1.Pages
{
    public partial class DesktopShell : Shell
    {
        public DesktopShell()
        {
            InitializeComponent();

            BindingContext = new ShellViewModel();
        }
    }
}