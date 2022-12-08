using Mood.ViewModels;
using Plugin.LocalNotification;

namespace Mood;

public partial class MainPage : ContentPage
{
	public MainPage(MainViewModel model)
	{
		InitializeComponent();
		BindingContext = model;
	}
}

