using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relations
{
    class UniversityContext: DbContext
    {
        public UniversityContext():
            base("universityEntities")
        {}

        public DbSet<User> Users { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
