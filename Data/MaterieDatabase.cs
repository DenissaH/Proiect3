using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proiect3.Models;

namespace Proiect3.Data
{
    public class MaterieDatabase
    {
        readonly SQLiteAsyncConnection _database;

        public MaterieDatabase(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Materie>().Wait();
        }
        public Task<List<Materie>> GetMaterieAsync()
        {
            return _database.Table<Materie>().ToListAsync();
        }
        public Task<Materie> GetMaterieAsync(int id)
        {
            return _database.Table<Materie>()
                            .Where(i => i.Id == id)
                            .FirstOrDefaultAsync();
        }
        public Task<int> SaveMaterieAsync(Materie slist)
        {
            if (slist.Id != 0)
            {
                return _database.UpdateAsync(slist);
            }
            else
            {
                return _database.InsertAsync(slist);
            }
        }
        public Task<int> DeleteMaterieAsync(Materie slist)
        {
            return _database.DeleteAsync(slist);
        }
    }
}
