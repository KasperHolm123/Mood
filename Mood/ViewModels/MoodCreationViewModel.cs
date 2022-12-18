using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mood.ViewModels
{
    public partial class MoodCreationViewModel
    {

        [RelayCommand]
        async Task CreateEntry()
        {
            await Shell.Current.GoToAsync(nameof(MainPage));
        }

        async Task GoToMainView()
        {
        }
    }
}
