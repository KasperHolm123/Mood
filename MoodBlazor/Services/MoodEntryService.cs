using MoodBlazor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodBlazor.Services
{
    public class MoodEntryService
    {

        public List<MoodEntry> MoodEntries { get; set; }

        public MoodEntryService()
        {
            MoodEntries = new()
            {
                new MoodEntry
                {
                    State = "Good",
                    CreationDate = DateTime.Now
                },
                new MoodEntry
                {
                    State = "Decent",
                    CreationDate = DateTime.Now
                },
                new MoodEntry
                {
                    State = "Very Good",
                    CreationDate = DateTime.Now
                }
            };
        }
    }
}
