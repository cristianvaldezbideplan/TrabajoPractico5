using AppFakeStore.Services;
using AppFakeStore.ViewModels;
using AppFakeStore.Views;
using Microsoft.Extensions.Logging;

namespace AppFakeStore
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
                    fonts.AddFont("fontello.ttf", "MaterialDesignIcons1");
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                    fonts.AddFont("MaterialIcons-Regular.ttf", "MaterialDesignIcons");
                });

            builder.Services.AddSingleton<IProductoService, ProductoService>();
            builder.Services.AddSingleton<ICarritoCompraService, CarritoCompraService>();
            builder.Services.AddSingleton<IUsuariosService, UsuariosService>();
            builder.Services.AddSingleton<IRegistroService, RegistroService>();

            builder.Services.AddTransient<ProductoListaViewModel>();
            builder.Services.AddTransient<ProductoListaPage>();

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
