using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Simple_CRUD_Operations.Db;

namespace Simple_CRUD_Operations
{
    class DBCommands
    {
        public void AddUser(User user)
        {
            using (var db = new UserStoredDbContext())
            {
                db.Users.Add(user);
                db.SaveChanges();
            }
        }
        
        public void RemoveUser(User user)
        {
            using (var db = new UserStoredDbContext())
            {
                db.Users.Attach(user);
                db.Users.Remove(user);
                db.SaveChanges();
            }
        }
    }
}
