using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mood.Models
{
    public class MoodEntry
    {
        public DateTime CreationDate { get; set; }
        public DateTime CreationTime { get; set; }
        public MoodEnum Mood { get; set; }

    }

    public enum MoodEnum
    {
        VeryGood = 5,
        Good = 4,
        Decent = 3,
        Bad = 2,
        VeryBad = 1
    }
}
