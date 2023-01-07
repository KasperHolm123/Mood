using Mood.ViewModels;
using Mood.Views;
using Plugin.LocalNotification;

namespace Mood;
public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			//.UseLocalNotification()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

		// AddSingleton keeps the page and viewmodel in memory
		builder.Services.AddSingleton<MainPage>();
        builder.Services.AddSingleton<MainViewModel>();

		// AddTransient kills the page and viewmodel everytime it is left by the user
        builder.Services.AddTransient<MoodCreationView>();
        builder.Services.AddTransient<MoodCreationViewModel>();

        builder.Services.AddTransient<SettingsView>();
        builder.Services.AddTransient<SettingsViewModel>();

        return builder.Build();
	}
}
