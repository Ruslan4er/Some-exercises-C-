using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_to_Entity
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new userstoredbEntities())
            {
                // Выборка SELECT 2 подхода
                var result = from user in db.Users
                             where user.Login == "Admon"
                             orderby user.UserProfile.Name
                             select user;

                var result1 = db.Users.Where(p => p.Login == "Admon").OrderBy(p => p.UserProfile.Name);
                foreach (var user in result)
                    Console.WriteLine("{0}-{1}-{2}", user.Id, user.Login, user.UserProfile.Name);
                foreach (var user in result1)
                    Console.WriteLine("{0}-{1}-{2}", user.UserProfile.Name, user.Login, user.Orders.Count);

                // Объединение таблиц 2 подхода
                var result2 = db.Users.Join(db.Orders,
                    u => u.Id,
                    o => o.UserId,
                    (u, o) => new
                    {
                        Name = u.Login,
                        UId = u.Id,
                        Orders = o.Cost
                    });
                foreach (var value in result2)
                {
                    Console.WriteLine("{0}-{1}-{2}", value.Name, value.Orders, value.UId);
                }

                var result3 = from u in db.Users
                              join o in db.Orders on u.Id equals o.UserId
                              select new
                              {
                                  Id = u.Id, Login = u.Login, Password = u.Password,
                                  Cost = o.Cost
                              };
                foreach (var j in result3)
                {
                    Console.WriteLine("{0}|{1}|{2}|{3}",j.Id,j.Login,j.Password,j.Cost);
                }

            }
        }
    }
}
