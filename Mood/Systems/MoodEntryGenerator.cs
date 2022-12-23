using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mood.Models;
using Mood.Models.ViewTemplates;
using Mood.Systems;

namespace Mood.Systems
{
    public static class MoodEntryGenerator
    {
        public static object ReturnTemplate(ObjectTemplate x, MoodEntry mood)
        {
            switch (x)
            {
                case ObjectTemplate.MoodEntryTemplate:
                    return new MoodEntryTemplate(mood);
                default:
                    return default;
            }
        }
    }

    public enum ObjectTemplate
    {
        MoodEntryTemplate = 0,
    }
}
