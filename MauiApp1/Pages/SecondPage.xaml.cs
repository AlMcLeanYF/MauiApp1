using MauiApp1.ViewModels;

namespace MauiApp1.Pages
{
    public partial class SecondPage : ContentPage
    {
        SecondPageViewModel vm => BindingContext as SecondPageViewModel;
        public SecondPage(SecondPageViewModel vm)
        {
            InitializeComponent();
            BindingContext = vm;
        }


        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await vm.InitializeAsync();
        }
    }
}