using Mood.Interfaces;
using Mood.Repositories;
using Mood.Services;
using Mood.Systems;
using Mood.ViewModels;
using Mood.Views;

namespace Mood;
public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.UseCustomViews()
			.UseCustomViewModels()
			.UseCustomServices()
			.UseCustomRepositories()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

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
