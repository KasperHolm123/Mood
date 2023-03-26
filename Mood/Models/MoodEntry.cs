using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mood.Models
{
    [Table("moodentry")]
    public class MoodEntry
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        [Required]
        public string CreationDate { get; set; }
        [Required]
        public string CreationTime { get; set; }
        [Required]
        public int MoodID
        {
            get => (int)Mood;
            set => Mood = (MoodState)value;
        }
        public MoodState Mood { get; set; }
        [Required]
        public string Picture { get; set; }
    }

    public enum MoodState
    {
        VeryGood = 1,
        Good = 2,
        Decent = 3,
        Bad = 4,
        VeryBad = 5
    }

    public static class MoodEntryExtensions
    {
        public static string ReturnPicture(MoodState state) => state switch
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
    
