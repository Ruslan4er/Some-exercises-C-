using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TestWebApplication.Models
{
    public class BookContext : DbContext
    {
        public DbSet<Book> Books { get; set; }

        public DbSet<Purchase> Purchases { get; set; }
    }

    public class BookDbInitialazer : DropCreateDatabaseAlways<BookContext>
    {
        protected override void Seed(BookContext db)
        {
            db.Books.Add(new Book { Name = "Война и Мир", Author = "Толстой", Price = 220 });
            db.Books.Add(new Book { Name = "Отцы и дети", Author = "Тургенев", Price = 180 });
            db.Books.Add(new Book { Name = "Чайка", Author = "Чехов", Price = 150 });

            base.Seed(db);
        }
    }
}