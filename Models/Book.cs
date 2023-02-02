using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Entities;

namespace MongoORM.Models
{
public class Book : Entity
    {
        public string Title { get; set; }
          public string Name { get; set; }

        static Book()
        {
            DB.Index<Book>()
              .Key(b => b.Title, KeyType.Ascending)
              .CreateAsync();
        }
    }
}