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
                    State = MoodState.Bad,
                    CreationDate = DateTime.Now
                },
                new MoodEntry
                {
                    State = MoodState.Decent,
                    CreationDate = DateTime.Now
                },
                new MoodEntry
                {
                    State = MoodState.VeryGood,
                    CreationDate = DateTime.Now
                }
            };
        }
    }
}
