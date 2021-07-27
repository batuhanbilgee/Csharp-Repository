namespace BBticaret_DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Distributor : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Distributors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 255),
                        Email = c.String(maxLength: 255),
                        Phone = c.String(maxLength: 255),
                        ContactPerson = c.String(maxLength: 255),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Distributors");
        }
    }
}
