using MauiApp1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Extensions
{
    public static class ServicesExtensions
    {
        public static MauiAppBuilder ConfigureServices(this MauiAppBuilder builder)
        {
            builder.Services.AddSingleton<TestDataService>();

            // From sample app

            //            builder.Services.AddSingleton<ShowsService>();
            //            builder.Services.AddSingleton<ListenLaterService>();
            //#if WINDOWS
            //        builder.Services.TryAddSingleton<SharedMauiLib.INativeAudioService, SharedMauiLib.Platforms.Windows.NativeAudioService>();
            //#elif ANDROID
            //            builder.Services.TryAddSingleton<SharedMauiLib.INativeAudioService, SharedMauiLib.Platforms.Android.NativeAudioService>();
            //#elif MACCATALYST
            //        builder.Services.TryAddSingleton<SharedMauiLib.INativeAudioService, SharedMauiLib.Platforms.MacCatalyst.NativeAudioService>();
            //        builder.Services.TryAddSingleton< Platforms.MacCatalyst.ConnectivityService>();
            //#elif IOS
            //        builder.Services.TryAddSingleton<SharedMauiLib.INativeAudioService, SharedMauiLib.Platforms.iOS.NativeAudioService>();
            //#endif

            //            builder.Services.TryAddTransient<WifiOptionsService>();
            //            builder.Services.TryAddSingleton<PlayerService>();

            //            builder.Services.AddScoped<ThemeInterop>();
            //            builder.Services.AddScoped<ClipboardInterop>();
            //            builder.Services.AddScoped<ListenTogetherHubClient>(_ =>
            //                new ListenTogetherHubClient(Config.ListenTogetherUrl));


            return builder;
        }
    }
}
