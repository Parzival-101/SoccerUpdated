namespace SoccerUpdated.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ALterClubIdAndSeedClubAndPlayers : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Clubs", "Id", c => c.Int(nullable: false, identity: true));

        }

    public override void Down()
        {
        }
    }
}
