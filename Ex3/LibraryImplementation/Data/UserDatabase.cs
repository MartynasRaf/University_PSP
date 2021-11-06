using LibraryImplementation.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace LibraryImplementation.Data
{
    public class UserDatabase
    {

        static UserDatabase instance;

        // Create the database connection as a singleton.
        public static UserDatabase Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new UserDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Notes.db3"));
                }
                return instance;
            }
        }


        readonly SQLiteAsyncConnection database;

        public UserDatabase(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<User>().Wait();
        }

        public Task<List<User>> GetUsersAsync()
        {
            //Get all notes.
            return database.Table<User>().ToListAsync();
        }

        public Task<User> GetUserAsync(int id)
        {
            // Get a specific note.
            return database.Table<User>()
                            .Where(i => i.ID == id)
                            .FirstOrDefaultAsync();
        }

        public Task<int> SaveUserAsync(User user)
        {
            if (user.ID != 0)
            {
                // Update an existing note.
                return database.UpdateAsync(user);
            }
            else
            {
                // Save a new note.
                return database.InsertAsync(user);
            }
        }

        public Task<int> DeleteUserAsync(User user)
        {
            // Delete a note.
            return database.DeleteAsync(user);
        }

        public Task<int> DeleteAllAsync()
        {
            return database.DeleteAllAsync<User>();
        }

    }
}
