using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Plugin.LocalNotification;

namespace Mood.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        public MainViewModel()
        {

        }

        [RelayCommand]
        private void CreateMood()
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

        [RelayCommand]
        async Task Tap()
        {
            await Shell.Current.GoToAsync(nameof(MoodCreationView));
        }
    }
}
