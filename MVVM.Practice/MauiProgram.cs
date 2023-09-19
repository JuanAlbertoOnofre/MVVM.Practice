using Microsoft.Extensions.Logging;
using MVVM.Practice.ViewModel;

namespace MVVM.Practice
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
            builder.RegiosterViewModel();
            builder.RegiosterViews();
            return builder.Build();
        }

        public static MauiAppBuilder RegiosterViewModel(this MauiAppBuilder mauiAppBuilder)
        {
            mauiAppBuilder.Services.AddSingleton<HomeViewModel>();
            return mauiAppBuilder;
        }

        public static MauiAppBuilder RegiosterViews(this MauiAppBuilder mauiAppBuilder)
        {
            mauiAppBuilder.Services.AddTransient<MainPage>();
            return mauiAppBuilder;
        }
    }
}