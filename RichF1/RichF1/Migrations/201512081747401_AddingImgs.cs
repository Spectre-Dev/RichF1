namespace RichF1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingImgs : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Racers", "RacerImg", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Racers", "RacerImg");
        }
    }
}
