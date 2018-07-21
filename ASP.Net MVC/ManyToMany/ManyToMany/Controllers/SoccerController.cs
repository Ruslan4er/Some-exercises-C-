using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ManyToMany.Models;

namespace ManyToMany.Controllers
{
    public class SoccerController : Controller
    {
        // GET: Soccer

        SoccerContext db = new SoccerContext();


        public ActionResult Index(int? team, string position)
        {
            IQueryable<Player> players = db.Players.Include(p => p.Team);

            if (team != null && team != 0)
            {
                players = players.Where(p => p.TeamId == team);
            }
            if (!string.IsNullOrEmpty(position) && !position.Equals("Все"))
            {
                players = players.Where(p => p.Position == position);
            }

            List<Team> teams = db.Teams.ToList();
            teams.Insert(0, new Team { Name = "Все", Id = 0 });

            PlayerListViewModel plvm = new PlayerListViewModel
            {
                Players = players.ToList(),
                Teams = new SelectList(teams, "Id", "Name"),
                Positions = new SelectList(new List<string>
                {
                    "Все",
                    "Нападающий",
                    "Полузащитник",
                    "Защитник",
                    "Вратарь"
                })
            };
            return View("Soccer", plvm);
        }
    }
}