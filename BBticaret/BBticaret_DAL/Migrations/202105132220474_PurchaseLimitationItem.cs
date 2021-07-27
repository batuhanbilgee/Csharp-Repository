namespace BBticaret_DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PurchaseLimitationItem : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PurchaseLimitationItems",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BrandId = c.Int(),
                        CategoryId = c.Int(),
                        LimitationId = c.Int(),
                        MemberGroupId = c.Int(),
                        ProductId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Brands", t => t.BrandId)
                .ForeignKey("dbo.Categories", t => t.CategoryId)
                .ForeignKey("dbo.MemberGroups", t => t.MemberGroupId)
                .ForeignKey("dbo.Products", t => t.ProductId)
                .ForeignKey("dbo.PurchaseLimitation", t => t.LimitationId)
                .Index(t => t.BrandId)
                .Index(t => t.CategoryId)
                .Index(t => t.LimitationId)
                .Index(t => t.MemberGroupId)
                .Index(t => t.ProductId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PurchaseLimitationItems", "LimitationId", "dbo.PurchaseLimitation");
            DropForeignKey("dbo.PurchaseLimitationItems", "ProductId", "dbo.Products");
            DropForeignKey("dbo.PurchaseLimitationItems", "MemberGroupId", "dbo.MemberGroups");
            DropForeignKey("dbo.PurchaseLimitationItems", "CategoryId", "dbo.Categories");
            DropForeignKey("dbo.PurchaseLimitationItems", "BrandId", "dbo.Brands");
            DropIndex("dbo.PurchaseLimitationItems", new[] { "ProductId" });
            DropIndex("dbo.PurchaseLimitationItems", new[] { "MemberGroupId" });
            DropIndex("dbo.PurchaseLimitationItems", new[] { "LimitationId" });
            DropIndex("dbo.PurchaseLimitationItems", new[] { "CategoryId" });
            DropIndex("dbo.PurchaseLimitationItems", new[] { "BrandId" });
            DropTable("dbo.PurchaseLimitationItems");
        }
    }
}
