namespace EF_Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Combats",
                c => new
                    {
                        CombatId = c.Int(nullable: false, identity: true),
                        Winner = c.String(),
                        Date = c.DateTime(nullable: false, storeType: "date"),
                    })
                .PrimaryKey(t => t.CombatId);
            
            CreateTable(
                "dbo.HitLogs",
                c => new
                    {
                        CombatId = c.Int(nullable: false),
                        PlayerLogin = c.String(),
                        EnemyLogin = c.String(),
                        PlayerHitValue = c.Int(nullable: false),
                        EnemyHitValue = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CombatId)
                .ForeignKey("dbo.Combats", t => t.CombatId)
                .Index(t => t.CombatId);
            
            CreateTable(
                "dbo.Players",
                c => new
                    {
                        PlayerId = c.Int(nullable: false, identity: true),
                        Login = c.String(),
                        Password = c.String(),
                        Email = c.String(),
                        IsValidEmail = c.Boolean(nullable: false),
                        Date = c.DateTime(nullable: false, storeType: "date"),
                        CombatId = c.Int(),
                    })
                .PrimaryKey(t => t.PlayerId)
                .ForeignKey("dbo.Combats", t => t.CombatId)
                .Index(t => t.CombatId);
            
            CreateTable(
                "dbo.Transactions",
                c => new
                    {
                        TransactId = c.Int(nullable: false, identity: true),
                        Sum = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false, storeType: "date"),
                        PlayerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TransactId)
                .ForeignKey("dbo.Players", t => t.PlayerId, cascadeDelete: true)
                .Index(t => t.PlayerId);
            
            CreateTable(
                "dbo.Pves",
                c => new
                    {
                        PveId = c.Int(nullable: false, identity: true),
                        CombatId = c.Int(nullable: false),
                        PlayerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PveId)
                .ForeignKey("dbo.Combats", t => t.CombatId, cascadeDelete: true)
                .ForeignKey("dbo.Players", t => t.PlayerId)
                .Index(t => t.CombatId)
                .Index(t => t.PlayerId);
            
            CreateTable(
                "dbo.Pvps",
                c => new
                    {
                        PvpId = c.Int(nullable: false, identity: true),
                        CombatId = c.Int(nullable: false),
                        Enemy_PlayerId = c.Int(),
                        Player_PlayerId = c.Int(),
                    })
                .PrimaryKey(t => t.PvpId)
                .ForeignKey("dbo.Players", t => t.Enemy_PlayerId)
                .ForeignKey("dbo.Players", t => t.Player_PlayerId)
                .ForeignKey("dbo.Combats", t => t.CombatId, cascadeDelete: true)
                .Index(t => t.CombatId)
                .Index(t => t.Enemy_PlayerId)
                .Index(t => t.Player_PlayerId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Pvps", "CombatId", "dbo.Combats");
            DropForeignKey("dbo.Pvps", "Player_PlayerId", "dbo.Players");
            DropForeignKey("dbo.Pvps", "Enemy_PlayerId", "dbo.Players");
            DropForeignKey("dbo.Pves", "PlayerId", "dbo.Players");
            DropForeignKey("dbo.Pves", "CombatId", "dbo.Combats");
            DropForeignKey("dbo.Transactions", "PlayerId", "dbo.Players");
            DropForeignKey("dbo.Players", "CombatId", "dbo.Combats");
            DropForeignKey("dbo.HitLogs", "CombatId", "dbo.Combats");
            DropIndex("dbo.Pvps", new[] { "Player_PlayerId" });
            DropIndex("dbo.Pvps", new[] { "Enemy_PlayerId" });
            DropIndex("dbo.Pvps", new[] { "CombatId" });
            DropIndex("dbo.Pves", new[] { "PlayerId" });
            DropIndex("dbo.Pves", new[] { "CombatId" });
            DropIndex("dbo.Transactions", new[] { "PlayerId" });
            DropIndex("dbo.Players", new[] { "CombatId" });
            DropIndex("dbo.HitLogs", new[] { "CombatId" });
            DropTable("dbo.Pvps");
            DropTable("dbo.Pves");
            DropTable("dbo.Transactions");
            DropTable("dbo.Players");
            DropTable("dbo.HitLogs");
            DropTable("dbo.Combats");
        }
    }
}
