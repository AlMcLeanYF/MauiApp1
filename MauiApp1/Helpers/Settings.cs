using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Helpers
{
    public static class Settings
    {
        const AppTheme theme = AppTheme.Light;

        public static AppTheme Theme
        {
            get => Enum.Parse<AppTheme>(Preferences.Get(nameof(Theme), Enum.GetName(theme)));
            set => Preferences.Set(nameof(Theme), value.ToString());
        }
    }
}
