using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mood.Models.Interfaces
{
    public interface IDatabase
    {
        void Get();
        void Upsert();
        void Delete();
        void GetAll();
        void Update();
    }
}
