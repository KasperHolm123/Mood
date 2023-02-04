using Mood.Interfaces;

namespace Mood;

public partial class App : Application
{
    public static IServiceProvider Services;
    public static IAlertService AlertSvc;
    public App(IServiceProvider provider)
	{
		InitializeComponent();

		MainPage = new AppShell();

        Services = provider;
        AlertSvc = Services.GetService<IAlertService>();
    }
}
