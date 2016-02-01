using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RichF1.Models         //this is where I created my teams and their attributes that become columns in the tables.
{
    public class RaceTeam
    {
        private ICollection<Racer> _racers;

        public RaceTeam()
        {
            _racers = new List<Racer>();
        }

        public int RaceTeamId { set; get; }
        [Display(Name = "Team Pic:")]
        public string TeamImg { set; get; }
        [Display(Name = "Team:")]
        public string RaceTeamName { set; get; }
        [Display(Name = "Team Number:")]
        public int RaceTeamNum { set; get; }
        [Display(Name = "Country:")]
        public string RaceTeamNation { set; get; }
        [Display(Name = "Power Unit:")]
        public string EngineMaker { set; get; }
        [Display(Name = "Tyre Brand:")]
        public string TyreMaker { set; get; }
        [Display(Name = "Championship Wins:")]
        public int ChampionshipWins { set; get; }
        [Display(Name = "Founded:")]
        public int EstablishedDate { set; get; }
        


        public virtual ICollection<Racer> Racers
        {
            get { return _racers; }
            set { _racers = value; }
        }
    }
}