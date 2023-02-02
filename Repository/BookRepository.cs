using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Entities;
using MongoORM.Models;

namespace MongoORM.Repository
{
    public class BookRepository : IBookRepository
    {
        public Task SaveBook(Book bookToSave)
        {
            return bookToSave.SaveAsync();
        }

        public Task<List<Book>> GetAll()
        {
            return DB.Find<Book>()
                     .Match(_ => true)
                     .ExecuteAsync();
        }

        public Task<Book> GetByTitle(string title)
        {
            return DB.Find<Book>()
                     .Match(b => b.Title == title)
                     .ExecuteSingleAsync();
        }

    }
}
