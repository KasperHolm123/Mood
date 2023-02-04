using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Mood.Models;
using System.Collections.ObjectModel;
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
        /// Opens a popup window giving the user to either confirm the deletion or
        /// cancel it.
        /// </summary>
        /// <param name="e"></param>
        [RelayCommand]
        public async void DeleteEntry(MoodEntry e)
        {
            App.AlertSvc.ShowConfirmation("Delete?", "OK", (result =>
            {
                if (result)
                {
                    MoodEntries.Remove(e);
                    _repo.Delete(e);
                }
            }));
        }

        /// <summary>
        /// Handles the creation of mood entry information panel
        /// </summary>
        /// <param name="e"></param>
        [RelayCommand]
        public void HandleMoodEntryPopup(MoodEntry e)
        {

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
