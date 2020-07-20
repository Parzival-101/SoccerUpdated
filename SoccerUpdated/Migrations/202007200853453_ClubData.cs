namespace SoccerUpdated.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    using System.Runtime.Remoting.Contexts;

    public partial class ClubData : DbMigration
    {
        public override void Up()
        {
           Sql("SET IDENTITY_INSERT [dbo].[Clubs] ON");
           
            Sql("INSERT INTO[dbo].[Clubs] ([Id], [Name], [League_Id], [Stadium], [City]) VALUES(1, N'Borussia Dortmund', 1, N'Signal Iduna Park', N'Dortmund')");
            Sql(" INSERT INTO[dbo].[Clubs] ([Id], [Name], [League_Id], [Stadium], [City]) VALUES(2, N'FC Bayern Munchen', 1, N'Allianz Arena', N'Muchen')");
            Sql("INSERT INTO[dbo].[Clubs] ([Id], [Name], [League_Id], [Stadium], [City]) VALUES(3, N'RB Leipzig', 1, N'Red Bull Arena', N'Leipzig')");
            Sql("INSERT INTO[dbo].[Clubs] ([Id], [Name], [League_Id], [Stadium], [City]) VALUES(4, N'Eintract Frankfurt', 1, N'Commerzbank Arena', N'Frankfurt')");
            Sql("INSERT INTO[dbo].[Clubs] ([Id], [Name], [League_Id], [Stadium], [City]) VALUES(5, N'Manchester United', 2, N'Etonix', N'Man U')");
            Sql("SET IDENTITY_INSERT [dbo].[Clubs] Off");

            Sql("SET IDENTITY_INSERT [dbo].[Players] ON");

            Sql("INSERT INTO[dbo].[Players] ([Id], [Name], [Position], [Country], [Club_Id]) VALUES(1, N'Marco Rues', N'Striker', N'Germany', NULL)");
            Sql("INSERT INTO[dbo].[Players] ([Id], [Name], [Position], [Country], [Club_Id]) VALUES(2, N'Hakimi', N'Striker', N'Germany', NULL)");
            Sql("INSERT INTO[dbo].[Players] ([Id], [Name], [Position], [Country], [Club_Id]) VALUES(3, N'Philipino Cutino', N'MidFielder', N'France', NULL)");
            Sql("INSERT INTO[dbo].[Players] ([Id], [Name], [Position], [Country], [Club_Id]) VALUES(4, N'Harry Kane', N'Defender', N'England', NULL)");
            Sql("SET IDENTITY_INSERT [dbo].[Players] off");

        }

        public override void Down()
        {
        }
    }
}
