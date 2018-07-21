using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class BookContext: DbContext
    {
        public DbSet<Book> Books { get; set; }
    }

    public class DbBookInitializer:DropCreateDatabaseAlways<BookContext>
    {
        protected override void Seed(BookContext db)
        {
            db.Books.AddRange(new List<Book>
            {
                new Book{Name = "Книга 1", Author = "Автор 1",Year = 1002},
                new Book{Name = "Книга 2", Author = "Автор 2",Year = 1202},
                new Book{Name = "Книга 3", Author = "Автор 3",Year = 1502},
                new Book{Name = "Книга 4", Author = "Автор 4",Year = 2022},
            });
            
            base.Seed(db);
        }
    }
}