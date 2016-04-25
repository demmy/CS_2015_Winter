namespace ISD_13.Migrations
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
                        Id = c.Int(nullable: false, identity: true),
                        CombatTypePVP = c.Boolean(nullable: false),
                        Experience = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        Player_Id = c.Int(),
                        FirstPlayer_Id = c.Int(),
                        SecondPlayer_Id = c.Int(),
                        Winner_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Players", t => t.Player_Id)
                .ForeignKey("dbo.Players", t => t.FirstPlayer_Id)
                .ForeignKey("dbo.Players", t => t.SecondPlayer_Id)
                .ForeignKey("dbo.Players", t => t.Winner_Id)
                .Index(t => t.Player_Id)
                .Index(t => t.FirstPlayer_Id)
                .Index(t => t.SecondPlayer_Id)
                .Index(t => t.Winner_Id);
            
            CreateTable(
                "dbo.HitLogs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        HitValue = c.Int(nullable: false),
                        Part = c.Int(nullable: false),
                        Result = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        Combat_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Combats", t => t.Combat_Id)
                .Index(t => t.Combat_Id);
            
            CreateTable(
                "dbo.Players",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Login = c.String(),
                        Password = c.String(),
                        EMail = c.String(),
                        EMailValid = c.Boolean(nullable: false),
                        Date = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        Combat_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Combats", t => t.Combat_Id)
                .Index(t => t.Combat_Id);
            
            CreateTable(
                "dbo.Transactions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Sum = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        Player_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Players", t => t.Player_Id)
                .Index(t => t.Player_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Combats", "Winner_Id", "dbo.Players");
            DropForeignKey("dbo.Combats", "SecondPlayer_Id", "dbo.Players");
            DropForeignKey("dbo.Players", "Combat_Id", "dbo.Combats");
            DropForeignKey("dbo.Combats", "FirstPlayer_Id", "dbo.Players");
            DropForeignKey("dbo.Transactions", "Player_Id", "dbo.Players");
            DropForeignKey("dbo.Combats", "Player_Id", "dbo.Players");
            DropForeignKey("dbo.HitLogs", "Combat_Id", "dbo.Combats");
            DropIndex("dbo.Transactions", new[] { "Player_Id" });
            DropIndex("dbo.Players", new[] { "Combat_Id" });
            DropIndex("dbo.HitLogs", new[] { "Combat_Id" });
            DropIndex("dbo.Combats", new[] { "Winner_Id" });
            DropIndex("dbo.Combats", new[] { "SecondPlayer_Id" });
            DropIndex("dbo.Combats", new[] { "FirstPlayer_Id" });
            DropIndex("dbo.Combats", new[] { "Player_Id" });
            DropTable("dbo.Transactions");
            DropTable("dbo.Players");
            DropTable("dbo.HitLogs");
            DropTable("dbo.Combats");
        }
    }
}
