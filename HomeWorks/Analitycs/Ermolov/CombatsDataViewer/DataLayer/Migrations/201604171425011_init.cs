namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BattleLogs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        Part = c.Int(nullable: false),
                        Result = c.Int(nullable: false),
                        HitValue = c.Int(nullable: false),
                        FirstPlayer_PlayerId = c.Int(),
                        SecondPlayer_PlayerId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Players", t => t.FirstPlayer_PlayerId)
                .ForeignKey("dbo.Players", t => t.SecondPlayer_PlayerId)
                .Index(t => t.FirstPlayer_PlayerId)
                .Index(t => t.SecondPlayer_PlayerId);
            
            CreateTable(
                "dbo.Players",
                c => new
                    {
                        PlayerId = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        UserId = c.Int(nullable: false),
                        Name = c.String(),
                        Hp = c.Int(nullable: false),
                        MaxHP = c.Int(nullable: false),
                        Damage = c.Int(nullable: false),
                        Experience = c.Int(nullable: false),
                        Statistics_Wins = c.Int(nullable: false),
                        Statistics_Loses = c.Int(nullable: false),
                        Statistics_Draws = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PlayerId);
            
            CreateTable(
                "dbo.Battles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        Type = c.Int(nullable: false),
                        Result = c.Int(nullable: false),
                        ExpGained = c.Int(nullable: false),
                        BattleLog_Id = c.Int(),
                        FirstPlayer_PlayerId = c.Int(),
                        SecondPlayer_PlayerId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.BattleLogs", t => t.BattleLog_Id)
                .ForeignKey("dbo.Players", t => t.FirstPlayer_PlayerId)
                .ForeignKey("dbo.Players", t => t.SecondPlayer_PlayerId)
                .Index(t => t.BattleLog_Id)
                .Index(t => t.FirstPlayer_PlayerId)
                .Index(t => t.SecondPlayer_PlayerId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        Login = c.String(),
                        Password = c.String(),
                        EMail = c.String(),
                        IsEMailValid = c.Boolean(nullable: false),
                        Character_PlayerId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Players", t => t.Character_PlayerId)
                .Index(t => t.Character_PlayerId);
            
            CreateTable(
                "dbo.UserTransactions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        Description = c.String(),
                        Sum = c.Decimal(precision: 18, scale: 2),
                        User_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .Index(t => t.User_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserTransactions", "User_Id", "dbo.Users");
            DropForeignKey("dbo.Users", "Character_PlayerId", "dbo.Players");
            DropForeignKey("dbo.Battles", "SecondPlayer_PlayerId", "dbo.Players");
            DropForeignKey("dbo.Battles", "FirstPlayer_PlayerId", "dbo.Players");
            DropForeignKey("dbo.Battles", "BattleLog_Id", "dbo.BattleLogs");
            DropForeignKey("dbo.BattleLogs", "SecondPlayer_PlayerId", "dbo.Players");
            DropForeignKey("dbo.BattleLogs", "FirstPlayer_PlayerId", "dbo.Players");
            DropIndex("dbo.UserTransactions", new[] { "User_Id" });
            DropIndex("dbo.Users", new[] { "Character_PlayerId" });
            DropIndex("dbo.Battles", new[] { "SecondPlayer_PlayerId" });
            DropIndex("dbo.Battles", new[] { "FirstPlayer_PlayerId" });
            DropIndex("dbo.Battles", new[] { "BattleLog_Id" });
            DropIndex("dbo.BattleLogs", new[] { "SecondPlayer_PlayerId" });
            DropIndex("dbo.BattleLogs", new[] { "FirstPlayer_PlayerId" });
            DropTable("dbo.UserTransactions");
            DropTable("dbo.Users");
            DropTable("dbo.Battles");
            DropTable("dbo.Players");
            DropTable("dbo.BattleLogs");
        }
    }
}
