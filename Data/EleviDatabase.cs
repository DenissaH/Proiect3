using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proiect3.Models;
using System.Collections;

namespace Proiect3.Data
{
    public class EleviDatabase
    {
        readonly SQLiteAsyncConnection _database;
        public EleviDatabase(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<EleviList>().Wait();
        }
        public Task<List<EleviList>> GetEleviListAsync()
        {
            return _database.Table<EleviList>().ToListAsync();
        }
        public Task<EleviList> GetEleviListAsync(int id)
        {
            return _database.Table<EleviList>()
                            .Where(i => i.ID == id)
                            .FirstOrDefaultAsync();
        }
        public Task<int> SaveEleviListAsync(EleviList slist)
        {
            if (slist.ID != 0)
            {
                return _database.UpdateAsync(slist);
            }
            else
            {
                return _database.InsertAsync(slist);
            }
        }
        public Task<int> DeleteEleviListAsync(EleviList slist)
        {
            return _database.DeleteAsync(slist);
        }

        internal Task<IEnumerable> GetProfesorAsync()
        {
            throw new NotImplementedException();
        }
    }
}
