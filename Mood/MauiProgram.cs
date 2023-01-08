using Mood.Interfaces;
using Mood.Repositories;
using Mood.Systems;
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

        #region Views/ViewModels
        // AddSingleton keeps the page and viewmodel in memory
        builder.Services.AddSingleton<MainPage>();
        builder.Services.AddSingleton<MainViewModel>();

		// AddTransient kills the page and viewmodel everytime it is left by the user
        builder.Services.AddTransient<MoodCreationView>();
        builder.Services.AddTransient<MoodCreationViewModel>();

        builder.Services.AddTransient<SettingsView>();
        builder.Services.AddTransient<SettingsViewModel>();
        #endregion

        #region Repositories
        builder.Services.AddSingleton<IMoodEntryRepository, MoodEntryRepository>();
        #endregion

        #region Database construction
        // Making sure the target device has database
        if (!Directory.Exists("storage/emulated/0/Android/data/com.companyname.mood/files"))
        {
            Directory.CreateDirectory("storage/emulated/0/Android/data/com.companyname.mood/files");
        }
        if (!File.Exists(Path.Combine("storage/emulated/0/Android/data/com.companyname.mood/files", "db_sqlite.db3")))
		{
			DatabaseConstructor.Up();
		}
        #endregion

        return builder.Build();
	}
}
