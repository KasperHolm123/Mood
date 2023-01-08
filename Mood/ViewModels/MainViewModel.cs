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
using SQLite;
using Mood.Repositories;
using Mood.Interfaces;

namespace Mood.ViewModels
{
    public partial class MainViewModel : ObservableObject, IQueryAttributable
    {
        #region Fields

        private readonly IMoodEntryRepository _repo;

        public ObservableCollection<MoodEntry> MoodEntries { get; set; } // holds all existing and newly created entries

        MoodEntry selectedEntry;
        public MoodEntry SelectedEntry
        {
            get => selectedEntry;
            set
            {
                selectedEntry = value;
                OnPropertyChanged();
            }
        }

        #endregion

        public MainViewModel(IMoodEntryRepository repo)
        {
            _repo = repo;
            MoodEntries = new(_repo.GetAll());
        }
        
        /// <summary>
        /// Apply query attributes if any are supplied.
        /// Any and all atttributes will be cleared after use.
        /// </summary>
        /// <param name="query"></param>
        public void ApplyQueryAttributes(IDictionary<string, object> query)
        {
            if (query.ContainsKey("NewMoodEntry"))
            {
                var entity = query["NewMoodEntry"] as MoodEntry;
                MoodEntries.Add(entity);
                _repo.Add(entity);
            }
            query.Clear();
        }

        /// <summary>
        /// Deletes the passed-in MoodEntry
        /// </summary>
        /// <param name="e"></param>
        [RelayCommand]
        public void DeleteEntry(MoodEntry e)
        {
            if (e != null)
                MoodEntries.Remove(e);
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
