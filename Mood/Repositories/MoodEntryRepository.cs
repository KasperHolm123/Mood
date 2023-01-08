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
    public class MoodEntryRepository : IRepository<MoodEntry>
    {
        public void Add(MoodEntry entity)
        {
            using (SQLiteConnection conn = new("awoij"))
            {
                
            }
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
