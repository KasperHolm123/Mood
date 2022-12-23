using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Plugin.LocalNotification;
using Mood.Views;
using Mood.Systems;
using Mood.Models;

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
            var mood = new MoodEntry
            {
                CreationDate = DateTime.Now,
                CreationTime = DateTime.Now,
                Mood = MoodEnum.Good
            };
            MoodEntryGenerator.ReturnTemplate(ObjectTemplate.MoodEntryTemplate, mood);
        }

        [RelayCommand]
        async Task Tap()
        {
            await Shell.Current.GoToAsync(nameof(MoodCreationView));
        }
    }
}
