using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MongoORM.Models;
using MongoORM.Repository;

namespace MongoORM.Controllers
{
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookRepository repo;

        public BookController(IBookRepository repository)
        {
            repo = repository;
        }

        [HttpGet("/api/books")]
        public Task<List<Book>> Index()
        {
            return repo.GetAll();
        }

        [HttpPost("/api/books/create")]
        public Task CreateBook(Book book)
        {
            return repo.SaveBook(book);
        }
    }
}
