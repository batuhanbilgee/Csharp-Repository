namespace BBticaret_DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ProductDetail : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ProductDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Sku = c.String(maxLength: 255),
                        Details = c.String(),
                        ExtraDetails = c.String(),
                        ProductId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Products", t => t.ProductId)
                .Index(t => t.ProductId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProductDetails", "ProductId", "dbo.Products");
            DropIndex("dbo.ProductDetails", new[] { "ProductId" });
            DropTable("dbo.ProductDetails");
        }
    }
}
