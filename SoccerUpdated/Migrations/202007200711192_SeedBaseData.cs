namespace SoccerUpdated.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedBaseData : DbMigration
    {
        public override void Up()
        {


            Sql("INSERT INTO[dbo].[Leagues]([Id], [Name], [Description], [Founded]) VALUES(1, N'Bundesliga', N'German FootballAssociation', N'1963-01-01 00:00:00')");
            Sql("INSERT INTO[dbo].[Leagues]([Id], [Name], [Description], [Founded]) VALUES(2, N'Premier League', N'English football league', N'1888-01-01 00:00:00')");
            Sql("INSERT INTO[dbo].[Leagues]([Id], [Name], [Description], [Founded]) VALUES(3, N'Champions League', N'Supranational sports Competition', N'1955-01-01 00:00:00')");


             }

        public override void Down()
        {
        }
    }
}
