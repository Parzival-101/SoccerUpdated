namespace SoccerUpdated.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDataannotation : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Clubs", "Name", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Leagues", "Name", c => c.String(maxLength: 255));
            AlterColumn("dbo.Players", "Name", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Players", "Name", c => c.String());
            AlterColumn("dbo.Leagues", "Name", c => c.String());
            AlterColumn("dbo.Clubs", "Name", c => c.String());
        }
    }
}
