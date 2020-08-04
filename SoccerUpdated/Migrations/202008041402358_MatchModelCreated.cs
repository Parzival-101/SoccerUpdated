namespace SoccerUpdated.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MatchModelCreated : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Matches",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MatchDay = c.DateTime(),
                        Club_Id = c.Int(nullable: false),
                        League_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clubs", t => t.Club_Id, cascadeDelete: true)
                .ForeignKey("dbo.Leagues", t => t.League_Id, cascadeDelete: true)
                .Index(t => t.Club_Id)
                .Index(t => t.League_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Matches", "League_Id", "dbo.Leagues");
            DropForeignKey("dbo.Matches", "Club_Id", "dbo.Clubs");
            DropIndex("dbo.Matches", new[] { "League_Id" });
            DropIndex("dbo.Matches", new[] { "Club_Id" });
            DropTable("dbo.Matches");
        }
    }
}
