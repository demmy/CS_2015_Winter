namespace FightClubReports.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newDate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Players", "RegistrationDate", c => c.DateTime(nullable: false));
            DropColumn("dbo.Players", "DateOfRegistrations");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Players", "DateOfRegistrations", c => c.DateTime(nullable: false));
            DropColumn("dbo.Players", "RegistrationDate");
        }
    }
}
