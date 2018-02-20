using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Simple_CRUD_Operations.Db;

namespace Simple_CRUD_Operations
{
    class UserStoredDbContext : DbContext
    {
        public UserStoredDbContext()
            : base("userstoredbEntities")
        { }

        public DbSet<User> Users { get; set; }
    }
}
