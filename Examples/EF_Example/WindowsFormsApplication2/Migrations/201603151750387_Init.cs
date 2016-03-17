namespace WindowsFormsApplication2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.People",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FName = c.String(maxLength: 4000),
                        LName = c.String(maxLength: 4000),
                        Address_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Addresses", t => t.Address_Id)
                .Index(t => t.Address_Id);
            
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        City = c.String(maxLength: 4000),
                        Street = c.String(maxLength: 4000),
                        Flat = c.String(maxLength: 4000),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.People", "Address_Id", "dbo.Addresses");
            DropIndex("dbo.People", new[] { "Address_Id" });
            DropTable("dbo.Addresses");
            DropTable("dbo.People");
        }
    }
}
