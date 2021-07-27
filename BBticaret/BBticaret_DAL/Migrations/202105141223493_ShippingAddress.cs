namespace BBticaret_DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ShippingAddress : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ShippingAddresses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 255),
                        SurName = c.String(nullable: false, maxLength: 255),
                        Country = c.String(nullable: false, maxLength: 128),
                        Location = c.String(nullable: false, maxLength: 128),
                        SubLocation = c.String(maxLength: 128),
                        Address = c.String(nullable: false),
                        PhoneNumber = c.String(maxLength: 32),
                        MobilePhoneNumber = c.String(nullable: false, maxLength: 32),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ShippingAddresses");
        }
    }
}
