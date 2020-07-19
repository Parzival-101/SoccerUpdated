namespace SoccerUpdated.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ClubModelUpdated : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Players", "Club_Id", "dbo.Clubs");
            DropIndex("dbo.Players", new[] { "Club_Id" });
            AddColumn("dbo.Clubs", "Stadium", c => c.String());
            AddColumn("dbo.Clubs", "City", c => c.String());
            DropColumn("dbo.Clubs", "Sponsor");
            DropColumn("dbo.Players", "Club_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Players", "Club_Id", c => c.Int());
            AddColumn("dbo.Clubs", "Sponsor", c => c.String());
            DropColumn("dbo.Clubs", "City");
            DropColumn("dbo.Clubs", "Stadium");
            CreateIndex("dbo.Players", "Club_Id");
            AddForeignKey("dbo.Players", "Club_Id", "dbo.Clubs", "Id");
        }
    }
}
