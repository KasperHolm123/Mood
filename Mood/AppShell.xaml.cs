namespace Mood;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute(nameof(MoodCreationView), typeof(MoodCreationView));
	}
}
