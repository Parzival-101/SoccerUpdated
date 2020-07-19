namespace SoccerUpdated.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LeagueAndPlayersModelChanged : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Leagues", "Founded", c => c.DateTime());
            AddColumn("dbo.Players", "Position", c => c.String());
            AddColumn("dbo.Players", "Country", c => c.String());
            AddColumn("dbo.Players", "Club_Id", c => c.Int());
            CreateIndex("dbo.Players", "Club_Id");
            AddForeignKey("dbo.Players", "Club_Id", "dbo.Clubs", "Id");
            DropColumn("dbo.Players", "Club");
            DropColumn("dbo.Players", "Description");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Players", "Description", c => c.String());
            AddColumn("dbo.Players", "Club", c => c.String());
            DropForeignKey("dbo.Players", "Club_Id", "dbo.Clubs");
            DropIndex("dbo.Players", new[] { "Club_Id" });
            DropColumn("dbo.Players", "Club_Id");
            DropColumn("dbo.Players", "Country");
            DropColumn("dbo.Players", "Position");
            DropColumn("dbo.Leagues", "Founded");
        }
    }
}
