using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FootballApplication.Models
{
    public class Player
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int GoalsThisSeason { get; set; }
        public int YearTurnedPro { get; set; }

        public int TeamId { get; set; }
        public Team Team { get; set; }

    }
}