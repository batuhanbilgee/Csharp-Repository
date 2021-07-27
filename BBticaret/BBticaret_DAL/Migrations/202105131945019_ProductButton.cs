namespace BBticaret_DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ProductButton : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ProductButtons",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FastShipping = c.Boolean(),
                        SameDayShipping = c.Boolean(),
                        ThreeDaysDelivery = c.Boolean(),
                        FiveDaysDelivery = c.Boolean(),
                        SevenDaysDelivery = c.Boolean(),
                        FreeShipping = c.Boolean(),
                        DeliveryFromStock = c.Boolean(),
                        PreOrderedProduct = c.Boolean(),
                        LimitedStock = c.Boolean(),
                        AskStock = c.Boolean(),
                        CampaignedProduct = c.Boolean(),
                        ProductId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.ProductId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProductButtons", "ProductId", "dbo.Products");
            DropIndex("dbo.ProductButtons", new[] { "ProductId" });
            DropTable("dbo.ProductButtons");
        }
    }
}
