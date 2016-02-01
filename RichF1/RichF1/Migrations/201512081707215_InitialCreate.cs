namespace RichF1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Racers",
                c => new
                    {
                        RacerId = c.Int(nullable: false, identity: true),
                        RacerName = c.String(),
                        RacerAge = c.Int(nullable: false),
                        RacerNation = c.String(),
                        RacerNum = c.Int(nullable: false),
                        RaceWins = c.Int(nullable: false),
                        ChampWins = c.Int(nullable: false),
                        Sponsor_SponsorId = c.Int(),
                    })
                .PrimaryKey(t => t.RacerId)
                .ForeignKey("dbo.Sponsors", t => t.Sponsor_SponsorId)
                .Index(t => t.Sponsor_SponsorId);
            
            CreateTable(
                "dbo.RaceTeams",
                c => new
                    {
                        RaceTeamId = c.Int(nullable: false, identity: true),
                        RaceTeamName = c.String(),
                        RaceTeamNum = c.Int(nullable: false),
                        RaceTeamNation = c.String(),
                        EngineMaker = c.String(),
                        TyreMaker = c.String(),
                        ChampionshipWins = c.Int(nullable: false),
                        EstablishedDate = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.RaceTeamId);
            
            CreateTable(
                "dbo.RaceTracks",
                c => new
                    {
                        RaceTrackId = c.Int(nullable: false, identity: true),
                        Trackname = c.String(),
                        RaceTrackNum = c.Int(nullable: false),
                        Location = c.String(),
                        EstablishedDate = c.Int(nullable: false),
                        RaceMonth = c.String(),
                    })
                .PrimaryKey(t => t.RaceTrackId);
            
            CreateTable(
                "dbo.Sponsors",
                c => new
                    {
                        SponsorId = c.Int(nullable: false, identity: true),
                        SponsorName = c.String(),
                        SponsorCountry = c.String(),
                        DateFounded = c.Int(nullable: false),
                        RaceTrack_RaceTrackId = c.Int(),
                    })
                .PrimaryKey(t => t.SponsorId)
                .ForeignKey("dbo.RaceTracks", t => t.RaceTrack_RaceTrackId)
                .Index(t => t.RaceTrack_RaceTrackId);
            
            CreateTable(
                "dbo.RaceTeamRacers",
                c => new
                    {
                        RaceTeam_RaceTeamId = c.Int(nullable: false),
                        Racer_RacerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.RaceTeam_RaceTeamId, t.Racer_RacerId })
                .ForeignKey("dbo.RaceTeams", t => t.RaceTeam_RaceTeamId, cascadeDelete: true)
                .ForeignKey("dbo.Racers", t => t.Racer_RacerId, cascadeDelete: true)
                .Index(t => t.RaceTeam_RaceTeamId)
                .Index(t => t.Racer_RacerId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Sponsors", "RaceTrack_RaceTrackId", "dbo.RaceTracks");
            DropForeignKey("dbo.Racers", "Sponsor_SponsorId", "dbo.Sponsors");
            DropForeignKey("dbo.RaceTeamRacers", "Racer_RacerId", "dbo.Racers");
            DropForeignKey("dbo.RaceTeamRacers", "RaceTeam_RaceTeamId", "dbo.RaceTeams");
            DropIndex("dbo.RaceTeamRacers", new[] { "Racer_RacerId" });
            DropIndex("dbo.RaceTeamRacers", new[] { "RaceTeam_RaceTeamId" });
            DropIndex("dbo.Sponsors", new[] { "RaceTrack_RaceTrackId" });
            DropIndex("dbo.Racers", new[] { "Sponsor_SponsorId" });
            DropTable("dbo.RaceTeamRacers");
            DropTable("dbo.Sponsors");
            DropTable("dbo.RaceTracks");
            DropTable("dbo.RaceTeams");
            DropTable("dbo.Racers");
        }
    }
}
