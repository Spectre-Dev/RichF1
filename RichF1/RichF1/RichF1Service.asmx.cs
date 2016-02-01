using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using RichF1.Models;

namespace RichF1
{
    /// <summary>
    /// Summary description for RichF1Service
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class RichF1Service : System.Web.Services.WebService
    {
        private RichF1ModelContext db = new RichF1ModelContext();

        [WebMethod]
        public string[] GetRacersByName(string namePart)     //this is my web service method for searching drivers
        {
            List<string> Racers = new List<string>();
            if (namePart != "")
            {
                foreach (var Racer in db.Racers
                                       .Where(a => a.RacerName.Contains(namePart))
                                       .ToList())
                {
                    Racers.Add(Racer.RacerName);
                }
            }

            return Racers.ToArray();
        }
        [WebMethod]
        public string[] GetRacerByNameAuto(string namePart)     //this is the auto search version.
        {
            List<string> Racers = new List<string>();

            if (namePart != "")
            {
                foreach (var author in db.Racers
                                        .Where(a => a.RacerName.StartsWith(namePart))
                                        .ToList())
                {
                    Racers.Add(author.RacerName);
                }
            }

            return Racers.ToArray();
        }
        [WebMethod]
        public string[] GetTeamByName(string namePart)     //this is my web service method for searching teams
        {
            List<string> RaceTeams = new List<string>();
            if (namePart != "")
            {
                foreach (var RaceTeam in db.RaceTeams
                                       .Where(a => a.RaceTeamName.Contains(namePart))
                                       .ToList())
                {
                    RaceTeams.Add(RaceTeam.RaceTeamName);
                }
            }

            return RaceTeams.ToArray();
        }
        [WebMethod]
        public string[] GetTeamByNameAuto(string namePart)
        {
            List<string> RaceTeams = new List<string>();

            if (namePart != "")
            {
                foreach (var RaceTeam in db.RaceTeams
                                        .Where(a => a.RaceTeamName.StartsWith(namePart))
                                        .ToList())
                {
                    RaceTeams.Add(RaceTeam.RaceTeamName);
                }
            }

            return RaceTeams.ToArray();
        }

        [WebMethod]
        public string[] GetTrackByName(string namePart)     //this is my web service method for searching track
        {
            List<string> RaceTracks = new List<string>();
            if (namePart != "")
            {
                foreach (var RaceTrack in db.RaceTracks
                                       .Where(a => a.Trackname.Contains(namePart))
                                       .ToList())
                {
                    RaceTracks.Add(RaceTrack.Trackname);
                }
            }

            return RaceTracks.ToArray();
        }
        [WebMethod]
        public string[] GetTrackByNameAuto(string namePart)
        {
            List<string> RaceTracks = new List<string>();

            if (namePart != "")
            {
                foreach (var RaceTrack in db.RaceTracks
                                        .Where(a => a.Trackname.StartsWith(namePart))
                                        .ToList())
                {
                    RaceTracks.Add(RaceTrack.Trackname);
                }
            }

            return RaceTracks.ToArray();
        }

    }
}
