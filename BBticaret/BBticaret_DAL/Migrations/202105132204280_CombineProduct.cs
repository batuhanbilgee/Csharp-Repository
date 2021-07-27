namespace BBticaret_DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CombineProduct : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CombineProducts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CombineProductId = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CombineProducts", t => t.CombineProductId)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.CombineProductId)
                .Index(t => t.ProductId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CombineProducts", "ProductId", "dbo.Products");
            DropForeignKey("dbo.CombineProducts", "CombineProductId", "dbo.CombineProducts");
            DropIndex("dbo.CombineProducts", new[] { "ProductId" });
            DropIndex("dbo.CombineProducts", new[] { "CombineProductId" });
            DropTable("dbo.CombineProducts");
        }
    }
}
