using Mood.Views;

namespace Mood;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute(nameof(MoodCreationView), typeof(MoodCreationView));
        Routing.RegisterRoute(nameof(SettingsView), typeof(SettingsView));
    }
}
