namespace BBticaret_DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ShippingProviderSetting : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ShippingProviderSettings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        VarKey = c.String(nullable: false, maxLength: 255),
                        VarValue = c.String(nullable: false),
                        ShippingProviderId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ShippingProviders", t => t.ShippingProviderId)
                .Index(t => t.ShippingProviderId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ShippingProviderSettings", "ShippingProviderId", "dbo.ShippingProviders");
            DropIndex("dbo.ShippingProviderSettings", new[] { "ShippingProviderId" });
            DropTable("dbo.ShippingProviderSettings");
        }
    }
}
