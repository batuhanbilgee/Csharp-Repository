namespace BBticaret_DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ProductProtection : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ProductProtections",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IsPriceProtected = c.Boolean(nullable: false),
                        IsStockProtected = c.Boolean(nullable: false),
                        ProductId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.ProductId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProductProtections", "ProductId", "dbo.Products");
            DropIndex("dbo.ProductProtections", new[] { "ProductId" });
            DropTable("dbo.ProductProtections");
        }
    }
}
