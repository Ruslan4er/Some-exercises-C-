using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTestApp
{
    class UserContext:DbContext
    {
        // В конструкторе задаём строку подключения
        public UserContext() :
            base("UserDB")
        {}

        public DbSet<User> Users { get; set; }
    }
}
