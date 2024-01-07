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
    public class ProfesorDatabase
    {
        readonly SQLiteAsyncConnection _database;
    public ProfesorDatabase(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Profesor>().Wait();
        }
    public Task<List<Profesor>> GetProfesorAsync()
        {
            return _database.Table<Profesor>().ToListAsync();
        }
        public Task<Profesor> GetProfesorAsync(int id)
        {
            return _database.Table<Profesor>()
                            .Where(i => i.Id == id)
                            .FirstOrDefaultAsync();
        }

        public Task<int> SaveProfesorAsync(Profesor slist)
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

        public Task<int> DeleteProfeorAsync(Profesor slist)
        {
            return _database.DeleteAsync(slist);
        }

        internal Task SaveProfesorListAsync(ProfesorList slist)
        {
            throw new NotImplementedException();
        }

        internal Task DeleteProfesorListAsync(ProfesorList slist)
        {
            throw new NotImplementedException();
        }

        internal Task<IEnumerable> GetEleviListAsync()
        {
            throw new NotImplementedException();
        }
    }
}
