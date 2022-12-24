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
        public ObservableCollection<MoodEntry> MoodEntries { get; set; } // holds all existing and newly created entries

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
            var m = new MoodEntry
            {
                CreationDate = DateTime.Now.ToString("M"), // date should be changed to get their data from a datepicker in the UI.
                CreationTime = DateTime.Now.ToString("T"),
                Mood = MoodEnum.Good // the mood should also depend on which button the user taps on.
            };
            MoodEntries.Add(m);
        }

        /// <summary>
        /// Changes the current page to MoodCreationView
        /// </summary>
        /// <returns></returns>
        [RelayCommand]
        async Task Tap() // change name
        {
            await Shell.Current.GoToAsync(nameof(MoodCreationView));
        }
    }
}
