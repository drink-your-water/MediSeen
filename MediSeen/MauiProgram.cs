using MediSeen.IViews;
using MediSeen.Services;
using MediSeen.MVVM.Views.Android;
using MediSeen.MVVM.Views.Windows;

namespace MediSeen;
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
            })
            .UseViewServices();

#if ANDROID || IOS
        builder.Services.AddSingleton<IMainPage, AndroidMainPage>();
        builder.Services.AddTransient<ISecondPage, CameraPage>();
        builder.Services.AddTransient<IThirdPage, SearchPage>();
#else
        builder.Services.AddSingleton<IMainPage, WindowsMainPage>();
        builder.Services.AddTransient<ISecondPage, InventoryPage>();
        builder.Services.AddTransient<IThirdPage, AvailabilityPage>();
#endif

        return builder.Build();
    }
}
