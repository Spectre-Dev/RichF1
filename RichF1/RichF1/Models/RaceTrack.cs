using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RichF1.Models         //this is where I created my tracks and their attributes that become columns in the tables.
{
    public class RaceTrack
    {
        private ICollection<Sponsor> _sponsors;

        public RaceTrack()
        {
            _sponsors = new List<Sponsor>();
        }

        public int RaceTrackId { set; get; }
        [Display(Name = "Track Layout:")]      //this annotation displays the name in the heading of my tables
        public string TrackImg { set; get; }
        [Display(Name = "Track Name:")]
        public string Trackname { set; get; }
        [Display(Name = "Race Number:")]
        public int RaceTrackNum { set; get; }
        [Display(Name = "Country:")]
        public string Location { set; get; }
        [Display(Name = "Established In:")]
        public int EstablishedDate { set; get; }
        [Display(Name = "Race Month:")]
        public string RaceMonth { set; get; }

        public virtual ICollection<Sponsor> Sponsors
        {
            get { return _sponsors; }
            set { _sponsors = value; }
        }
    }
}