using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mood.Models
{
    public class MoodEntry
    {
        public string CreationDate { get; set; }
        public string CreationTime { get; set; }
        public MoodEnum Mood { get; set; }
        public string Picture { get; set; }

    }

    public enum MoodEnum
    {
        VeryGood = 1,
        Good = 2,
        Decent = 3,
        Bad = 4,
        VeryBad = 5
    }

    public static class MoodPictures
    {
        public static readonly string VeryGood = "verygood.png";
        public static readonly string Good = "good.png";
        public static readonly string Decent = "decent.png";
        public static readonly string Bad = "bad.png";
        public static readonly string VeryBad = "verybad.png";

        public static string ReturnPicture(string p)
        {
            return p switch
            {
                "1" => VeryGood,
                "2" => Good,
                "3" => Decent,
                "4" => Bad,
                "5" => VeryBad,
                _ => default
            };
        }
    }
}
    
