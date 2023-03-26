using Mood.Interfaces;
using Mood.Repositories;
using Mood.Services;
using Mood.ViewModels;
using Mood.Views;

namespace Mood
{
    public static class ServicesManager
    {
        public static MauiAppBuilder UseCustomServices(this MauiAppBuilder builder)
        {
            builder.Services.AddSingleton<IAlertService, AlertService>();
            return builder;
        }

        public static MauiAppBuilder UseCustomViews(this MauiAppBuilder builder)
        {
            builder.Services.AddSingleton<MainPage>();
            builder.Services.AddTransient<MoodCreationView>();
            builder.Services.AddTransient<SettingsView>();
            return builder;
        }

        public static MauiAppBuilder UseCustomViewModels(this MauiAppBuilder builder)
        {
            builder.Services.AddSingleton<MainViewModel>();
            builder.Services.AddTransient<MoodCreationViewModel>();
            builder.Services.AddTransient<SettingsViewModel>();
            return builder;
        }

        public static MauiAppBuilder UseCustomRepositories(this MauiAppBuilder builder)
        {
            builder.Services.AddSingleton<IMoodEntryRepository, MoodEntryRepository>();
            return builder;
        }
    }
}
