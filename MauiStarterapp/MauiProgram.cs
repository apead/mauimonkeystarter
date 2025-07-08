
using MauiStarterapp.Services;
using MauiStarterapp.ViewModels;
using Microsoft.Extensions.Logging;

namespace MauiStarterapp
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif
            builder.Services.AddTransient<Views.SingleMonkeyPage>();
            builder.Services.AddSingleton<SingleMonkeyViewModel>();

            builder.Services.AddTransient<Views.ListOfMonkeysPage>();
            builder.Services.AddSingleton<ListOfMonkeysViewModel>();
            builder.Services.AddSingleton<MonkeyService>();

            return builder.Build();
        }
    }
}
