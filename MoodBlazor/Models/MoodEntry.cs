using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodBlazor.Models
{
    public class MoodEntry
    {
        public string State { get; set; }
        public DateTime CreationDate { get; set; }
    }

    public enum MoodStates
    {
        VeryGood,
        Good,
        Decent,
        Bad,
        VeryBad
    }
}
