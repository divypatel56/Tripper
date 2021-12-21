using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace Tripper
{
    public class Database
    {
        readonly SQLiteAsyncConnection _database; public Database(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Booking>().Wait();
        }

        public Task<List<Booking>> GetBookingAsync()
        {
            return _database.Table<Booking>().ToListAsync();
        }
        public Task<int> SaveBookingAsync(Booking booking)
        {
            return _database.InsertAsync(booking);
        }
    }
}
