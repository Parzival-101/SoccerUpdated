namespace SoccerUpdated.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LegueIdUpdateAndSeeding : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Clubs", "League_Id", "dbo.Leagues");
            DropIndex("dbo.Clubs", new[] { "League_Id" });
            DropPrimaryKey("dbo.Leagues");
            AlterColumn("dbo.Clubs", "League_Id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Leagues", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Leagues", "Id");
            CreateIndex("dbo.Clubs", "League_Id");
            AddForeignKey("dbo.Clubs", "League_Id", "dbo.Leagues", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Clubs", "League_Id", "dbo.Leagues");
            DropIndex("dbo.Clubs", new[] { "League_Id" });
            DropPrimaryKey("dbo.Leagues");
            AlterColumn("dbo.Leagues", "Id", c => c.Byte(nullable: false));
            AlterColumn("dbo.Clubs", "League_Id", c => c.Byte());
            AddPrimaryKey("dbo.Leagues", "Id");
            CreateIndex("dbo.Clubs", "League_Id");
            AddForeignKey("dbo.Clubs", "League_Id", "dbo.Leagues", "Id");
        }
    }
}
