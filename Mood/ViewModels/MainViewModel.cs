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
using System.Collections.ObjectModel;
using Mood.Models.ViewTemplates;

namespace Mood.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        // holds all existing and newly created entries
        public ObservableCollection<object> MoodEntries { get; set; }

        public MainViewModel()
        {
            MoodEntries = new();
        }

        /// <summary>
        /// Create a new mood entry and add it to a collection that implements IEnumerable
        /// </summary>
        [RelayCommand]
        private void CreateMood()
        {
            var mood = new MoodEntry
            {
                CreationDate = DateTime.Now,
                CreationTime = DateTime.Now,
                Mood = MoodEnum.Good
            };
            MoodEntries.Add(MoodEntryGenerator.ReturnTemplate(ObjectTemplate.MoodEntryTemplate, mood));
        }

        /// <summary>
        /// Changes the current page to MoodCreationView
        /// </summary>
        /// <returns></returns>
        [RelayCommand]
        async Task Tap()
        {
            await Shell.Current.GoToAsync(nameof(MoodCreationView));
        }
    }
}
