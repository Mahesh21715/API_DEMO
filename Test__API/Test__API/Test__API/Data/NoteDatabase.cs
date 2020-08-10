using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Test_API;

namespace Test__API
{
    class NoteDatabase
    {
        readonly SQLiteAsyncConnection _database;

        public NoteDatabase(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<UserData>().Wait();
        }

        public Task<List<UserData>> GetNotesAsync()
        {
            return _database.Table<UserData>().ToListAsync();
        }

        public Task<UserData> GetNoteAsync(int id)
        {
            return _database.Table<UserData>()
                            .Where(i => i.Id == id)
                            .FirstOrDefaultAsync();
        }

        public Task<int> SaveNoteAsync(UserData note)
        {
            if (note.Id != 0)
            {
                return _database.UpdateAsync(note);
            }
            else
            {
                return _database.InsertAsync(note);
            }
        }

        public Task<int> DeleteNoteAsync(UserData note)
        {
            return _database.DeleteAsync(note);
        }
    }
}
