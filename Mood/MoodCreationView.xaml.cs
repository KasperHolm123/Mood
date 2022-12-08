using Mood.ViewModels;

namespace Mood;

public partial class MoodCreationView : ContentPage
{
	public MoodCreationView(MoodCreationViewModel model)
	{
		InitializeComponent();
		BindingContext = model;
	}
}