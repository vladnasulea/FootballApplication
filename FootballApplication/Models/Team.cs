using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FootballApplication.Models
{
    public class Team
    {
        public int Id { get; set; }
        public string TeamName { get; set; }
        public string Country { get; set; }
        public string PlayingLeague { get; set; }
        
        public virtual List<Player> Players { get; set; }
         
    }
}