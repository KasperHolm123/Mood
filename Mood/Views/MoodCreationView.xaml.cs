using Mood.ViewModels;

namespace Mood.Views;

public partial class MoodCreationView : ContentPage
{
	public MoodCreationView(MoodCreationViewModel model)
	{
		InitializeComponent();
		BindingContext = model;
	}
}