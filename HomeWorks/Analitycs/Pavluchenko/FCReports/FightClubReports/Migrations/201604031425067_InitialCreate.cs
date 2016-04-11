namespace FightClubReports.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Combats",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TimeOfStart = c.DateTime(nullable: false),
                        Type = c.String(),
                        WinnerIsExist = c.Boolean(nullable: false),
                        Player_Id = c.Int(),
                        Player1_Id = c.Int(),
                        Player2_Id = c.Int(),
                        Winner_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Players", t => t.Player_Id)
                .ForeignKey("dbo.Players", t => t.Player1_Id)
                .ForeignKey("dbo.Players", t => t.Player2_Id)
                .ForeignKey("dbo.Players", t => t.Winner_Id)
                .Index(t => t.Player_Id)
                .Index(t => t.Player1_Id)
                .Index(t => t.Player2_Id)
                .Index(t => t.Winner_Id);
            
            CreateTable(
                "dbo.RoundLogs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Player1_Id = c.Int(),
                        Player2_Id = c.Int(),
                        Combat_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ActionLogs", t => t.Player1_Id)
                .ForeignKey("dbo.ActionLogs", t => t.Player2_Id)
                .ForeignKey("dbo.Combats", t => t.Combat_Id)
                .Index(t => t.Player1_Id)
                .Index(t => t.Player2_Id)
                .Index(t => t.Combat_Id);
            
            CreateTable(
                "dbo.ActionLogs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BlockLog_Id = c.Int(),
                        HitLog_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.BlockLogs", t => t.BlockLog_Id)
                .ForeignKey("dbo.Hitlogs", t => t.HitLog_Id)
                .Index(t => t.BlockLog_Id)
                .Index(t => t.HitLog_Id);
            
            CreateTable(
                "dbo.BlockLogs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Part = c.Int(nullable: false),
                        isSuccess = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Hitlogs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Part = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Players",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Login = c.String(),
                        Password = c.String(),
                        EMail = c.String(),
                        IsEmaillValid = c.Boolean(nullable: false),
                        DateOfRegistr = c.DateTime(nullable: false),
                        Statistics_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Statistics", t => t.Statistics_Id)
                .Index(t => t.Statistics_Id);
            
            CreateTable(
                "dbo.Statistics",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Combats = c.Int(nullable: false),
                        Wins = c.Int(nullable: false),
                        Draws = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Transactions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        Sum = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Player_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Players", t => t.Player_Id)
                .Index(t => t.Player_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Combats", "Winner_Id", "dbo.Players");
            DropForeignKey("dbo.Combats", "Player2_Id", "dbo.Players");
            DropForeignKey("dbo.Combats", "Player1_Id", "dbo.Players");
            DropForeignKey("dbo.Transactions", "Player_Id", "dbo.Players");
            DropForeignKey("dbo.Players", "Statistics_Id", "dbo.Statistics");
            DropForeignKey("dbo.Combats", "Player_Id", "dbo.Players");
            DropForeignKey("dbo.RoundLogs", "Combat_Id", "dbo.Combats");
            DropForeignKey("dbo.RoundLogs", "Player2_Id", "dbo.ActionLogs");
            DropForeignKey("dbo.RoundLogs", "Player1_Id", "dbo.ActionLogs");
            DropForeignKey("dbo.ActionLogs", "HitLog_Id", "dbo.Hitlogs");
            DropForeignKey("dbo.ActionLogs", "BlockLog_Id", "dbo.BlockLogs");
            DropIndex("dbo.Transactions", new[] { "Player_Id" });
            DropIndex("dbo.Players", new[] { "Statistics_Id" });
            DropIndex("dbo.ActionLogs", new[] { "HitLog_Id" });
            DropIndex("dbo.ActionLogs", new[] { "BlockLog_Id" });
            DropIndex("dbo.RoundLogs", new[] { "Combat_Id" });
            DropIndex("dbo.RoundLogs", new[] { "Player2_Id" });
            DropIndex("dbo.RoundLogs", new[] { "Player1_Id" });
            DropIndex("dbo.Combats", new[] { "Winner_Id" });
            DropIndex("dbo.Combats", new[] { "Player2_Id" });
            DropIndex("dbo.Combats", new[] { "Player1_Id" });
            DropIndex("dbo.Combats", new[] { "Player_Id" });
            DropTable("dbo.Transactions");
            DropTable("dbo.Statistics");
            DropTable("dbo.Players");
            DropTable("dbo.Hitlogs");
            DropTable("dbo.BlockLogs");
            DropTable("dbo.ActionLogs");
            DropTable("dbo.RoundLogs");
            DropTable("dbo.Combats");
        }
    }
}
