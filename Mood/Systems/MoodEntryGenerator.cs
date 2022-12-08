using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Intents;
using Mood.Models.ViewTemplates;
using Mood.Systems;

namespace Mood.Systems
{
    public static class MoodEntryGenerator<T>
    {
        public static object ReturnTemplate(Template x)
        {
            switch (x)
            {
                case Template.MoodEntryTemplate:
                    return new MoodEntryTemplate();
                default:
                    return default;
            }
        }
    }

    public enum Template
    {
        MoodEntryTemplate = 0,
    }
}
