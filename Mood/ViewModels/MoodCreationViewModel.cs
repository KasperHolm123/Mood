using CommunityToolkit.Mvvm.Input;
using Mood.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mood.ViewModels
{
    public partial class MoodCreationViewModel
    {
        public MoodCreationViewModel()
        {
            
        }

        /// <summary>
        /// Creates a new MoodEntry, sends it the MainPageViewModel and redirects the use back to MainPage
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        [RelayCommand]
        async Task CreateEntry(string x)
        {
            var m = new MoodEntry
            {
                CreationDate = DateTime.Now.ToString("M"), // date should be changed to get their data from a datepicker in the UI.
                CreationTime = DateTime.Now.ToString("T"),
                Mood = (MoodEnum)int.Parse(x) // the mood should also depend on which button the user taps on.
            };
            await Shell.Current.GoToAsync("..", new Dictionary<string, object>
            {
                { "NewMoodEntry", m }
            });
        }

        [RelayCommand]
        async Task Tap()
        {
            await Shell.Current.GoToAsync("..");
        }
    }
}
