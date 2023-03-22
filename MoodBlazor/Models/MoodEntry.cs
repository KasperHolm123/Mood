using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodBlazor.Models
{
    public class MoodEntry
    {
        public MoodState State { get; set; }
        public DateTime CreationDate { get; set; }
        public string Picture
        {
            get => MoodEntryExtensions.ReturnPicture(State);
        }
    }

    public enum MoodState
    {
        VeryGood,
        Good,
        Decent,
        Bad,
        VeryBad
    }

    public static class MoodEntryExtensions
    {
        public static string ReturnPicture(this MoodState state) => state switch
        {
            MoodState.VeryGood => "verygood.png",
            MoodState.Good => "good.png",
            MoodState.Decent => "decent.png",
            MoodState.Bad => "bad.png",
            MoodState.VeryBad => "verybad.png",
            _ => throw new NotImplementedException()
        };
    }
}
