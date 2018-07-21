using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestWebApplication2.Models
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Coatch { get; set; }

        public ICollection<Player> Players { get; set; }

        public Team()
        {
            Players = new List<Player>();
        }
    }
}