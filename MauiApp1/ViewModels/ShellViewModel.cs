using CommunityToolkit.Mvvm.ComponentModel;
using MauiApp1.Models;
using MauiApp1.Resources.Strings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.ViewModels
{
    public class ShellViewModel : ObservableObject
    {
        public AppSection MainPage { get; set; }
        public AppSection SecondPage { get; set; }

        public ShellViewModel()
        {
            MainPage = new AppSection() { Title = AppResource.MainPage, Icon = "discover.png", IconDark = "discover_dark.png", TargetType = typeof(MainPage) };
            SecondPage = new AppSection() { Title = AppResource.SecondPage, Icon = "subscriptions.png", IconDark = "subscriptions_dark.png", TargetType = typeof(SecondPage) };
        }
    }
}
