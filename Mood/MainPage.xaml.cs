using Mood.ViewModels;
using Plugin.LocalNotification;

namespace Mood;

public partial class MainPage : ContentPage
{
	public MainPage(MainViewModel m)
	{
		InitializeComponent();
		BindingContext = m;
	}
}

