namespace BBticaret_DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ShippingProvider : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ShippingProviders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(nullable: false, maxLength: 64),
                        Name = c.String(nullable: false, maxLength: 255),
                        TrackingUrl = c.String(nullable: false, maxLength: 1024),
                        TrackingFormMethod = c.Int(),
                        PayLoad = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ShippingProviders");
        }
    }
}
