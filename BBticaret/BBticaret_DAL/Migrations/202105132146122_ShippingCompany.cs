namespace BBticaret_DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ShippingCompany : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ShippingCompanies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 255),
                        Status = c.Int(nullable: false),
                        ExtraPrice = c.Single(),
                        ExtraVolumetricWeightPrice = c.Single(),
                        FreeShipmentOrderPrice = c.Single(),
                        FreeShipmentVolumetricWeightLimit = c.Single(),
                        SortOrder = c.Single(),
                        CompanyCode = c.String(maxLength: 255),
                        PaymentType = c.Int(),
                        ShippingProviderId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ShippingProviders", t => t.ShippingProviderId, cascadeDelete: true)
                .Index(t => t.ShippingProviderId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ShippingCompanies", "ShippingProviderId", "dbo.ShippingProviders");
            DropIndex("dbo.ShippingCompanies", new[] { "ShippingProviderId" });
            DropTable("dbo.ShippingCompanies");
        }
    }
}
