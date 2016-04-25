namespace FightClubReports.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class New : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Players", "DateOfRegistrations", c => c.DateTime(nullable: false));
            DropColumn("dbo.Players", "DateOfRegistr");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Players", "DateOfRegistr", c => c.DateTime(nullable: false));
            DropColumn("dbo.Players", "DateOfRegistrations");
        }
    }
}
