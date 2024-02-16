using Microsoft.Extensions.Logging;
using SunmiPOSLib;
using ZXing.Net.Maui.Controls;

namespace SunmiSampleApp;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		    builder
			.UseMauiApp<App>()
			.UseSunmiPrinter()
            .UseBarcodeReader()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});
        builder.Services.AddSingleton(SunmiPrinter.Current);
#if DEBUG
        builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}

