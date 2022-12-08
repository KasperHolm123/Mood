using Plugin.LocalNotification;

namespace Mood;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
		FillEntryStack();
	}

	private void CreateMood(object sender, EventArgs e)
	{
		var request = new NotificationRequest
		{
			NotificationId = 1,
			Title = "Test notification",
			Subtitle = "Test",
			Description = "This is a test notification",
			BadgeNumber = 0,
			Schedule = new NotificationRequestSchedule
			{
				NotifyTime = DateTime.Now.AddSeconds(5)
			}
		};

		LocalNotificationCenter.Current.Show(request);
	}

	private void FillEntryStack()
	{
		entry1.Text = DateTime.Now.ToShortTimeString();
	}
}

