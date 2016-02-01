namespace RichF1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTeamImages : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.RaceTeams", "TeamImg", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.RaceTeams", "TeamImg");
        }
    }
}
