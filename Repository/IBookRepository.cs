using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoORM.Models;

namespace MongoORM.Repository
{
 public interface IBookRepository
    {
        public Task SaveBook(Book bookToSave);
        public Task<Book> GetByTitle(string title);
        public Task<List<Book>> GetAll();
    }
}