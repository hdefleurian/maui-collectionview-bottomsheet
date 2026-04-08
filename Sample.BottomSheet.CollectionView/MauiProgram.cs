using Microsoft.Extensions.Logging;

using Plugin.Maui.BottomSheet.Hosting;

using Sample.BottomSheet.CollectionView.BottomSheet;
using Sample.BottomSheet.CollectionView.ViewModels;
using Sample.BottomSheet.CollectionView.ViewModels.BottomSheet;

namespace Sample.BottomSheet.CollectionView
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseBottomSheet()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

            builder.Services.AddTransient<MainPageViewModel>();
            builder.Services.AddTransient<SampleBottomSheetViewModel>();
            builder.Services.AddBottomSheet<SampleBottomSheet, SampleBottomSheetViewModel>("sample");

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
