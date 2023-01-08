using Mood.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mood.Systems
{
    public static class DatabaseConstructor
    {
        private static readonly string path = Path.Combine("storage/emulated/0/Android/data/com.companyname.mood/files", "db_sqlite.db3");
        public static void Up()
        {
            using SQLiteConnection conn = new(path);
            conn.CreateTable<MoodEntry>();
        }

        public static void Down()
        {
            File.Delete(path);
        }
    }
}
