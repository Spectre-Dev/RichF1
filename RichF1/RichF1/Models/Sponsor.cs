using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RichF1.Models             //this is where I created my sponsors and their attributes that become columns in the tables.
{
    public class Sponsor
    {
        private ICollection<Racer> _racers;

        public Sponsor()
        {
            _racers = new List<Racer>();
        }

        public int SponsorId { set; get; }
        [Display(Name = "Sponsor:")]
        public string SponsorName { set; get; }
        [Display(Name = "Home Nation:")]
        public string SponsorCountry { set; get; }
        [Display(Name = "Founded In:")]
        public int DateFounded { set; get; }

        public virtual ICollection<Racer> Racers
        {
            get { return _racers; }
            set { _racers = value; }
        }
    }
}