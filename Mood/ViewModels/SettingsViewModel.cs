using CommunityToolkit.Mvvm.Input;
using Mood.Interfaces;
using Mood.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mood.ViewModels
{
    public partial class SettingsViewModel
    {
        private readonly IMoodEntryRepository _repo;
        public SettingsViewModel(IMoodEntryRepository repo)
        {
            _repo = repo;
        }

        [RelayCommand]
        public void ClearEntries()
        {
            App.AlertSvc.ShowConfirmation("Clear Mood Entries?", "Are you sure you want to delete all mood entries? This process cannot be reverted.",
                (result =>
                {
                    if (result) _repo.ClearTable(typeof(MoodEntry));
                }));
        }
    }
}
