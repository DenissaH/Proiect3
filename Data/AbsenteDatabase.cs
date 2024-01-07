using System;
using SQLite;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proiect3.Models;

namespace Proiect3.Data
{
    public class AbsenteDatabase
    {
        readonly SQLiteAsyncConnection _database;
        public AbsenteDatabase(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Absenta>().Wait();
        }
        public Task<List<Absenta>> GetAbentaAsync()
        {
            return _database.Table<Absenta>().ToListAsync();
        }

        public Task<Absenta> GetAbsentaAsync(int id)
        {
            return _database.Table<Absenta>()
                            .Where(i => i.Id == id)
                            .FirstOrDefaultAsync();
        }
        public Task<int> SaveAbsentaAsync(Absenta slist)
        {
            if (slist.Id!= 0)
            {
                return _database.UpdateAsync(slist);
            }
            else
            {
                return _database.InsertAsync(slist);
            }
        }
        public Task<int> DeleteAbsentaAsync(Absenta slist)
        {
            return _database.DeleteAsync(slist);
        }
    }
}
