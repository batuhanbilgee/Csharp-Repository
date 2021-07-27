namespace BBticaret_DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ProductToCategory : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ProductToCategories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SortOrder = c.Int(),
                        ProductId = c.Int(nullable: false),
                        CategoryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.ProductId)
                .Index(t => t.CategoryId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProductToCategories", "ProductId", "dbo.Products");
            DropForeignKey("dbo.ProductToCategories", "CategoryId", "dbo.Categories");
            DropIndex("dbo.ProductToCategories", new[] { "CategoryId" });
            DropIndex("dbo.ProductToCategories", new[] { "ProductId" });
            DropTable("dbo.ProductToCategories");
        }
    }
}
