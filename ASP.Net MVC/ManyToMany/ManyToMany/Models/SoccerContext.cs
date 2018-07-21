using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ManyToMany.Models
{
    public class SoccerContext : DbContext
    {
        public DbSet<Player> Players { get; set; }
        public DbSet<Team> Teams { get; set; }
    }

    class SoccerDbInitializer: DropCreateDatabaseAlways<SoccerContext>
    {
        protected override void Seed(SoccerContext db)
        {
            var team1 = new Team {Name = "Команда 1"};
            db.Teams.Add(team1);
            var team2 = new Team {Name = "Команда 2"};
            db.Teams.Add(team2);
            db.SaveChanges();

            db.Players.AddRange(new[]
            {
                new Player {Name = "Игрок 1", Age = 32, Position = "Нападающий", Team = team1},
                new Player {Name = "Игрок 2", Age = 24, Position = "Защитник", Team = team2},
                new Player {Name = "Игрок 3", Age = 26, Position = "Полузащитник", Team = team1},
                new Player {Name = "Игрок 4", Age = 25, Position = "Защитник", Team = team1},
                new Player {Name = "Игрок 5", Age = 35, Position = "Нападающий", Team = team2},
                new Player {Name = "Игрок 6", Age = 34, Position = "Защитник", Team = team2},
                new Player {Name = "Игрок 7", Age = 22, Position = "Нападающий", Team = team2},
            });
        }
    }
}