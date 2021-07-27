namespace BBticaret_DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Product : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 255),
                        Slug = c.String(),
                        FullName = c.String(nullable: false, maxLength: 255),
                        Sku = c.String(nullable: false, maxLength: 255),
                        Barcode = c.String(maxLength: 255),
                        Price1 = c.Single(nullable: false),
                        Warranty = c.Single(),
                        Tax = c.Single(),
                        StockAmount = c.Single(),
                        VolumetricWeight = c.Single(),
                        BuyingPrice = c.Single(),
                        StockTypeLabel = c.Int(nullable: false),
                        Discount = c.Single(),
                        DiscountType = c.Boolean(),
                        MoneyOrderDiscount = c.Single(),
                        Status = c.Boolean(nullable: false),
                        TaxIncluded = c.Boolean(nullable: false),
                        Distributor = c.String(maxLength: 255),
                        IsGifted = c.Boolean(),
                        Gift = c.String(maxLength: 255),
                        CustomShippingDisabled = c.Boolean(),
                        CustomShippingCost = c.Single(),
                        MarketPriceDetail = c.String(maxLength: 255),
                        CreatedAt = c.DateTime(precision: 7, storeType: "datetime2"),
                        UpdatedAt = c.DateTime(precision: 7, storeType: "datetime2"),
                        MetaKeywords = c.String(),
                        MetaDescription = c.String(),
                        PageTitle = c.String(maxLength: 255),
                        HasOption = c.Boolean(),
                        ShortDetails = c.String(maxLength: 512),
                        SearchKeywords = c.String(maxLength: 255),
                        InstallmentThreshold = c.String(maxLength: 10),
                        HomeSortOrder = c.Int(),
                        PopularSortOrder = c.Int(),
                        BrandSortOrder = c.Int(),
                        FeaturedSortOrder = c.Int(),
                        CampaignedSortOrder = c.Int(),
                        NewSortOrder = c.Int(),
                        DiscountedSortOrder = c.Int(),
                        BrandId = c.Int(),
                        CurrencyId = c.Int(),
                        ProductId = c.Int(),
                        ProductToCountDownId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Brands", t => t.BrandId)
                .ForeignKey("dbo.Currency", t => t.CurrencyId)
                .ForeignKey("dbo.Products", t => t.ProductId)
                .ForeignKey("dbo.ProductToCountDowns", t => t.ProductToCountDownId)
                .Index(t => t.BrandId)
                .Index(t => t.CurrencyId)
                .Index(t => t.ProductId)
                .Index(t => t.ProductToCountDownId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "ProductToCountDownId", "dbo.ProductToCountDowns");
            DropForeignKey("dbo.Products", "ProductId", "dbo.Products");
            DropForeignKey("dbo.Products", "CurrencyId", "dbo.Currency");
            DropForeignKey("dbo.Products", "BrandId", "dbo.Brands");
            DropIndex("dbo.Products", new[] { "ProductToCountDownId" });
            DropIndex("dbo.Products", new[] { "ProductId" });
            DropIndex("dbo.Products", new[] { "CurrencyId" });
            DropIndex("dbo.Products", new[] { "BrandId" });
            DropTable("dbo.Products");
        }
    }
}
