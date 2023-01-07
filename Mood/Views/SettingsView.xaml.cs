using Mood.ViewModels;

namespace Mood.Views;

public partial class SettingsView : ContentPage
{
	public SettingsView(SettingsViewModel s)
	{
		InitializeComponent();
		BindingContext= s;
	}
}