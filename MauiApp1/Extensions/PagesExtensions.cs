using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Extensions
{
    public static class PagesExtensions
    {
        public static MauiAppBuilder ConfigurePages(this MauiAppBuilder builder)
        {
            // main tabs of the app
            builder.Services.AddSingleton<MainPage>();
            builder.Services.AddSingleton<SecondPage>();

            // pages that are navigated to
            //builder.Services.AddTransient<CategoriesPage>();

            return builder;
        }
    }
}
