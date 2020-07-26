namespace SoccerUpdated.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ClubIdtoPlayer : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Players", name: "Club_Id", newName: "ClubId");
            RenameIndex(table: "dbo.Players", name: "IX_Club_Id", newName: "IX_ClubId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Players", name: "IX_ClubId", newName: "IX_Club_Id");
            RenameColumn(table: "dbo.Players", name: "ClubId", newName: "Club_Id");
        }
    }
}
