using MauiApp1.ViewModels;

namespace MauiApp1.Pages
{
    public partial class MobileShell : Shell
    {
        public MobileShell()
        {
            InitializeComponent();

            BindingContext = new ShellViewModel();
        }
    }
}