using Mood.Interfaces;
using Mood.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mood.Repositories
{
    public class MoodEntryRepository : IMoodEntryRepository
    {
        private string path = Path.Combine("storage/emulated/0/Android/data/com.companyname.mood/files", "db_sqlite.db3");
        public void Add(MoodEntry entity)
        {
            using SQLiteConnection conn = new(path);
            conn.CreateTable<MoodEntry>();
        }

        public void Delete(MoodEntry entity)
        {
            throw new NotImplementedException();
        }

        public MoodEntry Get(MoodEntry entity)
        {
            throw new NotImplementedException();
        }

        public MoodEntry GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(MoodEntry entity)
        {
            throw new NotImplementedException();
        }
    }
}
