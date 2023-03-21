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
            conn.Insert(entity);
        }

        public void ClearTable(Type table)
        {
            using SQLiteConnection conn = new(path);
            var map = conn.GetMapping(table);
            conn.DeleteAll(map);
        }

        public void Delete(MoodEntry entity)
        {
            using SQLiteConnection conn = new(path);
            conn.Delete(entity);
        }

        public MoodEntry Get(MoodEntry entity)
        {
            throw new NotImplementedException();
        }

        public List<MoodEntry> GetAll()
        {
            using SQLiteConnection conn = new(path);
            return conn.Table<MoodEntry>().ToList();
        }

        public void Update(MoodEntry entity)
        {
            throw new NotImplementedException();
        }
    }
}
