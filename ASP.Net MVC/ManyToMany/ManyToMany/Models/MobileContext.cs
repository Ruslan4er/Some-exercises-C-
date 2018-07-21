using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ManyToMany.Models
{
    public class MobileContext:DbContext
    {
        public DbSet<Phone> Phones { get; set; }
    }

    public class MobileDbInitializer : DropCreateDatabaseAlways<MobileContext>
    {
        protected override void Seed(MobileContext db)
        {
            db.Phones.Add(new Phone {Model = "Модель 1", Producer = "Производитель 1"});
            db.Phones.Add(new Phone {Model = "Модель 1", Producer = "Производитель 1"});
            db.Phones.Add(new Phone {Model = "Модель 1", Producer = "Производитель 1"});
            db.Phones.Add(new Phone {Model = "Модель 1", Producer = "Производитель 1"});
            db.Phones.Add(new Phone {Model = "Модель 1", Producer = "Производитель 1"});
            db.Phones.Add(new Phone {Model = "Модель 1", Producer = "Производитель 1"});
            db.Phones.Add(new Phone {Model = "Модель 1", Producer = "Производитель 1"});
            db.Phones.Add(new Phone {Model = "Модель 1", Producer = "Производитель 1"});
            db.Phones.Add(new Phone {Model = "Модель 1", Producer = "Производитель 1"});
            db.Phones.Add(new Phone {Model = "Модель 2", Producer = "Производитель 1"});
            db.Phones.Add(new Phone {Model = "Модель 3", Producer = "Производитель 1"});
            db.Phones.Add(new Phone {Model = "Модель 1", Producer = "Производитель 2"});
            db.Phones.Add(new Phone {Model = "Модель 2", Producer = "Производитель 2"});
            db.Phones.Add(new Phone {Model = "Модель 3", Producer = "Производитель 2"});
            db.Phones.Add(new Phone {Model = "Модель 3", Producer = "Производитель 2"});
            db.Phones.Add(new Phone {Model = "Модель 3", Producer = "Производитель 2"});
            db.Phones.Add(new Phone {Model = "Модель 3", Producer = "Производитель 2"});
            db.Phones.Add(new Phone {Model = "Модель 3", Producer = "Производитель 2"});
            db.SaveChanges();
        }
    }
}