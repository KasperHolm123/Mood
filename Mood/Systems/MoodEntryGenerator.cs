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
        /// <returns></returns>
        public static object ReturnTemplate(ObjectTemplate x)
        {
            return x switch
            {
                _ => default,
            };
        }
        public static object ReturnTemplate(ObjectTemplate x, MoodEntry m)
        {
            return x switch
            {
                ObjectTemplate.MoodEntryTemplate => new MoodEntryTemplate(m).grid,
                _ => default,
            };
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
