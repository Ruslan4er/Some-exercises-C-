using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AjaxWebApp.Models
{
    public class BookContext: DbContext
    {
        public DbSet<Book> Books { get; set; }
    }

    public class BookDbInitializer : DropCreateDatabaseAlways<BookContext>
    {
        protected override void Seed(BookContext db)
        {
            db.Books.AddRange(new[]
            {
                new Book {Name = "Книга 1", Author = "Автор 1"},
                new Book {Name = "Книга 2", Author = "Автор 2"},
                new Book {Name = "Книга 3", Author = "Автор 1"},
                new Book {Name = "Книга 4", Author = "Автор 4"},
                new Book {Name = "Книга 5", Author = "Автор 1"},
                new Book {Name = "Книга 6", Author = "Автор 6"},
            });
            base.Seed(db);
        }
    }
}