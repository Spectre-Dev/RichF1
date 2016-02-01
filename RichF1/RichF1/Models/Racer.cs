using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RichF1.Models     //this is where I created my drivers and their attributes that become columns in the tables.
{
    public class Racer
    {
        private ICollection<RaceTeam> _raceTeams;

        public Racer()
        {
            _raceTeams = new List<RaceTeam>();
        }

        public int RacerId { set; get; }
        [Display(Name = "Driver Image:")]
        public string RacerImg { set; get; }
        [Display(Name = "Driver Name:")]
        public string RacerName { set; get; }
        [Display(Name = "Age:")]
        public int RacerAge { set; get; }
        [Display(Name = "Nationality:")]
        public string RacerNation { set; get; }
        [Display(Name = "Race Number:")]

        public int RacerNum { set; get; }
        [Display(Name = "Race WIns:")]
        public int RaceWins { set; get; }
        [Display(Name = "Championship Wins:")]
        public int ChampWins { set; get; }



        public virtual ICollection<RaceTeam> RaceTeams
        {
            get { return _raceTeams; }
            set { _raceTeams = value; }
        }
    }
}