namespace FightClubReports.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Combats", "TypePVP", c => c.Boolean(nullable: false));
            DropColumn("dbo.Combats", "Type");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Combats", "Type", c => c.String());
            DropColumn("dbo.Combats", "TypePVP");
        }
    }
}
