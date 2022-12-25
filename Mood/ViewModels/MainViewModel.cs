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
using System.ComponentModel;

namespace Mood.ViewModels
{

    [QueryProperty("NewMoodEntry", "NewMoodEntry")]
    public partial class MainViewModel : ObservableObject
    {
        public ObservableCollection<MoodEntry> MoodEntries { get; set; } // holds all existing and newly created entries

        // This field holds the most recently created MoodEntry
        MoodEntry newMoodEntry;
        public MoodEntry NewMoodEntry
        {
            get => newMoodEntry;
            set
            {
                newMoodEntry = value;
                MoodEntries.Add(newMoodEntry);
            }
        }

        public MainViewModel()
        {
            MoodEntries = new();
        }

        /// <summary>
        /// Changes the current page to MoodCreationView
        /// </summary>
        /// <returns></returns>
        [RelayCommand]
        async Task ChangeView(string v)
        {
            await Shell.Current.GoToAsync(v);
        }
    }
}
