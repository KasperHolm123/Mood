using Microsoft.AspNetCore.Components;
using MoodBlazor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodBlazor.Pages
{
    public class IndexBase : ComponentBase
    {
        public List<MoodEntry> MoodEntries { get; set; }

        public IndexBase()
        {
            MoodEntries = new()
            {
                new MoodEntry { State = "Good"},
                new MoodEntry { State = "Decent"},
                new MoodEntry { State = "Very Good"}
            };
        }
    }
}
