namespace BBticaret_DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ProductToTag : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ProductToTags",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductId = c.Int(nullable: false),
                        TagId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .ForeignKey("dbo.Tag", t => t.TagId, cascadeDelete: true)
                .Index(t => t.ProductId)
                .Index(t => t.TagId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProductToTags", "TagId", "dbo.Tag");
            DropForeignKey("dbo.ProductToTags", "ProductId", "dbo.Products");
            DropIndex("dbo.ProductToTags", new[] { "TagId" });
            DropIndex("dbo.ProductToTags", new[] { "ProductId" });
            DropTable("dbo.ProductToTags");
        }
    }
}
