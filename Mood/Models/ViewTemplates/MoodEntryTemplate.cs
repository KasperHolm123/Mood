using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mood.Models;

namespace Mood.Models.ViewTemplates
{
    public class MoodEntryTemplate
    {
        public MoodEntryTemplate(MoodEntry mood)
        {
            var grid = new Grid();

            var label = new Label()
            {
                Text=mood.Mood.ToString(),
            };

            grid.Children.Add(label);
        }
    }
}
