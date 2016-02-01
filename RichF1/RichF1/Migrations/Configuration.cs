namespace RichF1.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using RichF1.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<RichF1.Models.RichF1ModelContext>
    {
        public Configuration()  //this is where I am seeding in drivers, teams, tracks, sponsors to the database etc. 
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "RichF1.Models.RichF1ModelContext";
        }

        protected override void Seed(RichF1.Models.RichF1ModelContext context)
        {
            string alternativeTxt = "Image not available:";     //this is used instead when images aren't available,
           
            context.Racers.AddOrUpdate(p => p.RacerName,     //seeding the drivers
              new Racer
              {
                  RacerImg = "~/Content/images/alexander.jpg",
                  RacerName = "Alexander Rossi",
                  RacerNation = "USA",
                  RacerAge = 24,
                  RacerNum = 53,
                  RaceWins = 0,
                  ChampWins = 0,
              },
                new Racer
                {
                    RacerImg = "~/Content/images/carlos.jpg",
                    RacerName = "Carlos Sainz",
                    RacerNation = "Spain",
                    RacerAge = 21,
                    RacerNum = 55,
                    RaceWins = 0,
                    ChampWins = 0,
                },
                new Racer
                {
                    RacerImg = "~/Content/images/daniel.jpg",
                    RacerName = "Daniel Ricciardo",
                    RacerNation = "Australia",
                    RacerAge = 26,
                    RacerNum = 3,
                    RaceWins = 3,
                    ChampWins = 0,
                },
                new Racer
                {
                    RacerImg = "~/Content/images/danil.jpg",
                    RacerName = "Danil Kviat",
                    RacerNation = "Russia",
                    RacerAge = 21,
                    RacerNum = 26,
                    RaceWins = 0,
                    ChampWins = 0,
                },
                new Racer
                {
                    RacerImg = "~/Content/images/felipe.jpg",
                    RacerName = "Felipe Massa",
                    RacerNation = "Brazil",
                    RacerAge = 34,
                    RacerNum = 19,
                    RaceWins = 11,
                    ChampWins = 0,
                },
                new Racer
                {
                    RacerImg = "~/Content/images/FelipeN.jpg",
                    RacerName = "Felipe Nasr",
                    RacerNation = "Brazil",
                    RacerAge = 23,
                    RacerNum = 12,
                    RaceWins = 0,
                    ChampWins = 0,
                },
                new Racer
                {
                    RacerImg = "~/Content/images/fernando.jpg",
                    RacerName = "Fernando Alonso",
                    RacerNation = "Spain",
                    RacerAge = 34,
                    RacerNum = 14,
                    RaceWins = 32,
                    ChampWins = 2,
                }, new Racer
                {
                    RacerImg = "~/Content/images/jenson.jpg",
                    RacerName = "Jenson Button",
                    RacerNation = "England",
                    RacerAge = 35,
                    RacerNum = 22,
                    RaceWins = 15,
                    ChampWins = 1,
                },
                new Racer
                {
                    RacerImg = "~/Content/images/kimi.jpg",
                    RacerName = "Kimi Räikkönen",
                    RacerNation = "Brazil",
                    RacerAge = 36,
                    RacerNum = 7,
                    RaceWins = 20,
                    ChampWins = 1,
                },
                new Racer
                {
                    RacerImg = "~/Content/images/lewis.jpg",
                    RacerName = "Lewis Hamilton",
                    RacerNation = "England",
                    RacerAge = 30,
                    RacerNum = 44,
                    RaceWins = 43,
                    ChampWins = 3,
                },
                new Racer
                {
                    RacerImg = "~/Content/images/marcus.jpg",
                    RacerName = "Marcus Erricsson",
                    RacerNation = "Sweden",
                    RacerAge = 25,
                    RacerNum = 9,
                    RaceWins = 0,
                    ChampWins = 0,
                },
                new Racer
                {
                    RacerImg = "~/Content/images/max.jpg",
                    RacerName = "Max Verstappen",
                    RacerNation = "Neatherlands",
                    RacerAge = 18,
                    RacerNum = 33,
                    RaceWins = 0,
                    ChampWins = 0,
                },
                new Racer
                {
                    RacerImg = "~/Content/images/nico.jpg",
                    RacerName = "Nico Rosberg",
                    RacerNation = "Germany",
                    RacerAge = 30,
                    RacerNum = 6,
                    RaceWins = 14,
                    ChampWins = 0,
                },
                new Racer
                {
                    RacerImg = "~/Content/images/nicoh.jpg",
                    RacerName = "Nico Hulkenberg",
                    RacerNation = "Germany",
                    RacerAge = 28,
                    RacerNum = 27,
                    RaceWins = 0,
                    ChampWins = 0,
                },
                new Racer
                {
                    RacerImg = "~/Content/images/pastor.jpg",
                    RacerName = "Pastor Maldonado",
                    RacerNation = "Venezuela",
                    RacerAge = 36,
                    RacerNum = 13,
                    RaceWins = 1,
                    ChampWins = 0,
                },
                new Racer
                {
                    RacerImg = "~/Content/images/roberto.jpg",
                    RacerName = "Roberto Merhi",
                    RacerNation = "Spain",
                    RacerAge = 24,
                    RacerNum = 98,
                    RaceWins = 0,
                    ChampWins = 0,
                },
                new Racer
                {
                    RacerImg = "~/Content/images/romain.jpg",
                    RacerName = "Romain Grosjean",
                    RacerNation = "France",
                    RacerAge = 29,
                    RacerNum = 9,
                    RaceWins = 0,
                    ChampWins = 0,
                },
                new Racer
                {
                    RacerImg = "~/Content/images/seb.jpg",
                    RacerName = "Sebastian Vettel",
                    RacerNation = "Germany",
                    RacerAge = 28,
                    RacerNum = 5,
                    RaceWins = 42,
                    ChampWins = 4,
                },
                new Racer
                {
                    RacerImg = "~/Content/images/sergio.jpg",
                    RacerName = "Sergio Perez",
                    RacerNation = "Mexico",
                    RacerAge = 25,
                    RacerNum = 11,
                    RaceWins = 0,
                    ChampWins = 0,
                },
                new Racer
                {
                    RacerImg = "~/Content/images/valteri.jpg",
                    RacerName = "Valteri Bottas",
                    RacerNation = "Finland",
                    RacerAge = 26,
                    RacerNum = 77,
                    RaceWins = 0,
                    ChampWins = 0,
                },
                new Racer
                {
                    RacerImg = "~/Content/images/will.jpg",
                    RacerName = "Will Stevens",
                    RacerNation = "England",
                    RacerAge = 24,
                    RacerNum = 28,
                    RaceWins = 0,
                    ChampWins = 0,
                }       //add a comma in here if ya wanna add any more seeds Rich, 

                );

           
            context.RaceTracks.AddOrUpdate(r => r.Trackname,         //seeding the race tracks
                new RaceTrack
                {
                    TrackImg = "~/Content/images/Tracks/australia.png",
                    Trackname = "Melbourne Park",
                    RaceTrackNum = 1,
                    Location = "Australia",
                    EstablishedDate = 1996,
                    RaceMonth = "March",
                },
                new RaceTrack
                {
                    TrackImg = "~/Content/images/Tracks/malaysia.png",
                    Trackname = "Sepang International Circuit",
                    RaceTrackNum = 2,
                    Location = "Malaysia",
                    EstablishedDate = 1999,
                    RaceMonth = "March",
                },
                new RaceTrack
                {
                    TrackImg = "~/Content/images/Tracks/china.png",
                    Trackname = "Shanghai International Circuit",
                    RaceTrackNum = 3,
                    Location = "China",
                    EstablishedDate = 2004,
                    RaceMonth = "April",
                },
                new RaceTrack
                {
                    TrackImg = "~/Content/images/Tracks/bahrain.png",
                    Trackname = "Bahrain International Circuit",
                    RaceTrackNum = 4,
                    Location = "Bahrain",
                    EstablishedDate = 2004,
                    RaceMonth = "April",
                },
                new RaceTrack
                {
                    TrackImg = "~/Content/images/Tracks/spain.png",
                    Trackname = "Circuit De Barcalona-Catalunya",
                    RaceTrackNum = 5,
                    Location = "Spain",
                    EstablishedDate = 1991,
                    RaceMonth = "May",
                },
                new RaceTrack
                {
                    TrackImg = "~/Content/images/Tracks/monaco.png",
                    Trackname = "Circuit De Monaco",
                    RaceTrackNum = 6,
                    Location = "Monaco",
                    EstablishedDate = 1950,
                    RaceMonth = "May",
                },
                new RaceTrack
                {
                    TrackImg = "~/Content/images/Tracks/canada.png",
                    Trackname = "Circuit De Gilles-Villenueve",
                    RaceTrackNum = 7,
                    Location = "Canada",
                    EstablishedDate = 1978,
                    RaceMonth = "June",
                },
                new RaceTrack
                {
                    TrackImg = "~/Content/images/Tracks/austria.png",
                    Trackname = "RedBull Ring",
                    RaceTrackNum = 8,
                    Location = "Austria",
                    EstablishedDate = 1970,
                    RaceMonth = "June",
                },
                new RaceTrack
                {
                    TrackImg = "~/Content/images/Tracks/england.png",
                    Trackname = "Silverstone Racing Circuit",
                    RaceTrackNum = 9,
                    Location = "England",
                    EstablishedDate = 1950,
                    RaceMonth = "June",
                },
                new RaceTrack
                {
                    TrackImg = "~/Content/images/Tracks/hungary.png",
                    Trackname = "Hungaroring",
                    RaceTrackNum = 10,
                    Location = "Hungary",
                    EstablishedDate = 1986,
                    RaceMonth = "July",
                },
                new RaceTrack
                {
                    TrackImg = "~/Content/images/Tracks/belgium.png",
                    Trackname = "Spa-Francorchamps",
                    RaceTrackNum = 11,
                    Location = "Belgium",
                    EstablishedDate = 1950,
                    RaceMonth = "August",
                },
                new RaceTrack
                {
                    TrackImg = "~/Content/images/Tracks/italy.png",
                    Trackname = "Monza",
                    RaceTrackNum = 12,
                    Location = "Italy",
                    EstablishedDate = 1950,
                    RaceMonth = "September",
                },
                new RaceTrack
                {
                    TrackImg = "~/Content/images/Tracks/singapore.png",
                    Trackname = "Marina Bay Street Circuit",
                    RaceTrackNum = 13,
                    Location = "Singapore",
                    EstablishedDate = 2008,
                    RaceMonth = "September",
                },
                new RaceTrack
                {
                    TrackImg = "~/Content/images/Tracks/japan.png",
                    Trackname = "Suzuka International Racing Course",
                    RaceTrackNum = 14,
                    Location = "Japan",
                    EstablishedDate = 1987,
                    RaceMonth = "September",
                },
                new RaceTrack
                {
                    TrackImg = "~/Content/images/Tracks/russia.png",
                    Trackname = "Sochi",
                    RaceTrackNum = 15,
                    Location = "Russia",
                    EstablishedDate = 2014,
                    RaceMonth = "October",
                },
                new RaceTrack
                {
                    TrackImg = "~/Content/images/Tracks/america.png",
                    Trackname = "Circuit of The Americas",
                    RaceTrackNum = 16,
                    Location = "United States of America",
                    EstablishedDate = 2012,
                    RaceMonth = "October",
                },
                new RaceTrack
                {
                    TrackImg = "~/Content/images/Tracks/mexico.png",
                    Trackname = "Autodromo Hermanos Rodríguez",
                    RaceTrackNum = 17,
                    Location = "Mexico",
                    EstablishedDate = 1963,
                    RaceMonth = "November",
                },
                new RaceTrack
                {
                    TrackImg = "~/Content/images/Tracks/brazil.png",
                    Trackname = "Interlagos",
                    RaceTrackNum = 18,
                    Location = "Brazil",
                    EstablishedDate = 1973,
                    RaceMonth = "November",
                },
                new RaceTrack
                {
                    TrackImg = "~/Content/images/Tracks/abudhabi.png",
                    Trackname = "Yas Marina Circuit",
                    RaceTrackNum = 19,
                    Location = "Abu Dhabi",
                    EstablishedDate = 2009,
                    RaceMonth = "November",
                }
                );
            
            context.Sponsors.AddOrUpdate(s => s.SponsorName,                //seeding the sponsors
                new Sponsor
                {
                    SponsorName = "Petronas",
                    SponsorCountry = "Germany",
                    DateFounded = 1921,
                },
                new Sponsor
                {
                    SponsorName = "Miscrosoft",
                    SponsorCountry = "America",
                    DateFounded = 1967,
                },
                new Sponsor
                {
                    SponsorName = "Vodafone",
                    SponsorCountry = "Switzerland",
                    DateFounded = 1994,
                });
            
            context.RaceTeams.AddOrUpdate(s => s.RaceTeamName,             //seeding the race teams
                new RaceTeam
                {
                    TeamImg = "~/Content/images/mercedes.jpg",
                    RaceTeamName = "Mercedes F1",
                    RaceTeamNum = 1,
                    RaceTeamNation = "Germany",
                    EngineMaker = "Mercedes AMG",
                    TyreMaker = "Pirreli",
                    ChampionshipWins = 3,
                    EstablishedDate = 2011,
                },
                new RaceTeam
                {
                    TeamImg = "~/Content/images/williams.jpg",
                    RaceTeamName = "Williams F1",
                    RaceTeamNum = 2,
                    RaceTeamNation = "England",
                    EngineMaker = "Mercedes AMG",
                    TyreMaker = "Pirreli",
                    ChampionshipWins = 7,
                    EstablishedDate = 1974,
                },
                new RaceTeam
                {
                    TeamImg = "~/Content/images/lotus.jpg",
                    RaceTeamName = "Lotus F1",
                    RaceTeamNum = 3,
                    RaceTeamNation = "England",
                    EngineMaker = "Renault",
                    TyreMaker = "Pirreli",
                    ChampionshipWins = 5,
                    EstablishedDate = 1965,
                },
                new RaceTeam
                {
                    TeamImg = "~/Content/images/redbull.jpg",
                    RaceTeamName = "RedBull",
                    RaceTeamNum = 4,
                    RaceTeamNation = "Indonisia",
                    EngineMaker = "Renault",
                    TyreMaker = "Pirreli",
                    ChampionshipWins = 4,
                    EstablishedDate = 1950,
                },
                new RaceTeam
                {
                    TeamImg = "~/Content/images/torrorosso.jpg",
                    RaceTeamName = "TorroRosso",
                    RaceTeamNum = 5,
                    RaceTeamNation = "Spain",
                    EngineMaker = "Ferrari",
                    TyreMaker = "Pirreli",
                    ChampionshipWins = 0,
                    EstablishedDate = 2007,
                },
                new RaceTeam
                {
                    TeamImg = "~/Content/images/forceindia.jpg",
                    RaceTeamName = "Force India",
                    RaceTeamNum = 6,
                    RaceTeamNation = "India",
                    EngineMaker = "Mercedes AMG",
                    TyreMaker = "Pirreli",
                    ChampionshipWins = 0,
                    EstablishedDate = 2008,
                },
                new RaceTeam
                {
                    TeamImg = "~/Content/images/sauber.jpg",
                    RaceTeamName = "Sauber F1",
                    RaceTeamNum = 7,
                    RaceTeamNation = "Italy",
                    EngineMaker = "Ferrari",
                    TyreMaker = "Pirreli",
                    ChampionshipWins = 0,
                    EstablishedDate = 1987,
                },
                new RaceTeam
                {
                    TeamImg = "~/Content/images/mclaren.jpg",
                    RaceTeamName = "McLaren",
                    RaceTeamNum = 8,
                    RaceTeamNation = "England",
                    EngineMaker = "Honda F1",
                    TyreMaker = "Pirreli",
                    ChampionshipWins = 14,
                    EstablishedDate = 1955,
                },
                new RaceTeam
                {
                    TeamImg = "~/Content/images/marussia.jpg",
                    RaceTeamName = "Marussia",
                    RaceTeamNum = 9,
                    RaceTeamNation = "Russia",
                    EngineMaker = "Ferrari",
                    TyreMaker = "Pirreli",
                    ChampionshipWins = 0,
                    EstablishedDate = 2009,
                },
                new RaceTeam
                {
                    TeamImg = "~/Content/images/ferrari.jpg",
                    RaceTeamName = "Ferrari",
                    RaceTeamNum = 10,
                    RaceTeamNation = "Italy",
                    EngineMaker = "Ferrari",
                    TyreMaker = "Pirreli",
                    ChampionshipWins = 14,
                    EstablishedDate = 1950,
                });
        }
    }
}
