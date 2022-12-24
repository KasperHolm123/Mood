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
        /// <summary>
        /// Returns an object used in the UI layer
        /// </summary>
        /// <param name="x"></param>
        /// <param name="m"></param>
        /// <returns></returns>
        public static object ReturnTemplate(ObjectTemplate x, MoodEntry m)
        {
            switch (x)
            {
                case ObjectTemplate.MoodEntryTemplate:
                    return new MoodEntryTemplate(m).grid;
                default:
                    return default;
            }
        }
    }

    /// <summary>
    /// Contains all available UI templates
    /// </summary>
    public enum ObjectTemplate
    {
        MoodEntryTemplate = 0,
    }
}
