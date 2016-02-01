using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace RichF1.Models
{
        public class RichF1ModelContext : DbContext
        {

            public RichF1ModelContext() : base("RichF1ModelContext")
            {

            }
            public DbSet<Racer> Racers { set; get; }
            public DbSet<RaceTeam> RaceTeams { set; get; }
            public DbSet<Sponsor> Sponsors { set; get; }

            public DbSet<RaceTrack> RaceTracks { set; get; }
        }   
}