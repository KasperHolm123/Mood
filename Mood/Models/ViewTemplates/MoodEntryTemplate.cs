using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mood.Models;

namespace Mood.Models.ViewTemplates
{
    /// <summary>
    /// Mood entry template to be used in the UI layer
    /// </summary>
    public class MoodEntryTemplate
    {
        public Label grid;
        public MoodEntryTemplate(MoodEntry m)
        {
            /*
            grid = new();
            var label = new Label()
            {
                Text = mood.Mood.ToString(),
            };

            grid.Children.Add(label);
            */
            grid = new()
            {
                Text = m.Mood.ToString()
            };
        }
    }
}
