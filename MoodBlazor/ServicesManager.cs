using Microsoft.Extensions.DependencyInjection;
using MoodBlazor.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodBlazor
{
    public static class ServicesManager
    {

        public static MauiAppBuilder UseCustomServices(this MauiAppBuilder builder)
        {
            builder.Services.AddSingleton<MoodEntryService>();
            return builder;
        }
    }
}
