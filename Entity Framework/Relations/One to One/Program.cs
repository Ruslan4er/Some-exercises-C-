using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace One_to_One
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new userstoredbEntities())
            {

                var user1 = new User { Login = "Admon", Password = "122212345" };
                var user2 = new User { Login = "Adminchick", Password = "5432asdasd1" };
                var user3 = new User
                {
                    Login = "Admon",
                    Password = "122212345",
                    UserProfile = new UserProfile { Age = 31, Name = "MIKI" }
                };
                db.Users.AddRange(new List<User> { user1, user2, user3 });
                db.SaveChanges();

                var userProfil1 = new UserProfile { Age = 29, Name = "Johny", Id = user1.Id };
                var userProfil2 = new UserProfile { Age = 19, Name = "Katty", Id = user2.Id };

                db.UserProfiles.AddRange(new List<UserProfile> { userProfil1, userProfil2 });
                db.SaveChanges();

                var user = db.Users.FirstOrDefault(u => u.Login == "Admon");
                if (user != null)
                {
                    user.Password = "11111111111";
                    db.Entry(user).State = EntityState.Modified;
                    db.SaveChanges();
                }


               
            }




        }
    }
}
