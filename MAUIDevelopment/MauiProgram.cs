using DevExpress.Maui.CollectionView;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Maui.Controls.Compatibility.Hosting;
using DevExpress.Maui;

namespace MAUIDevelopment;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .UseDevExpress()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            })
        .ConfigureMauiHandlers(handlers =>
         {
             handlers.AddHandler<DXCollectionView, DXCollectionViewHandler>();
         })
        .UseMauiCompatibility()
                .ConfigureEffects((effects) =>
                {
                    effects.AddCompatibilityEffects(AppDomain.CurrentDomain.GetAssemblies());
                });

        builder.Services.AddSingleton<MainPage>();
        builder.Services.AddTransient<Views.ListView>();

        builder.Services.AddTransient<Views.DetailsPage>();
        builder.Services.AddTransient<Views.DevExpressPage>();
        builder.Services.AddTransient<Views.DevExpressGridPage>();
        builder.Services.AddTransient<ViewModels.DetailsViewModel>();

        return builder.Build();
    }
}
