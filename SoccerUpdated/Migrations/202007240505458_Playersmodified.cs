namespace SoccerUpdated.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Playersmodified : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Players", "BirthDate", c => c.DateTime(nullable: true));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Players", "BirthDate");
        }
    }
}
