namespace BBticaret_DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DistributorToProduct : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DistributorToProducts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DistributorId = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Distributors", t => t.DistributorId, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.DistributorId)
                .Index(t => t.ProductId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DistributorToProducts", "ProductId", "dbo.Products");
            DropForeignKey("dbo.DistributorToProducts", "DistributorId", "dbo.Distributors");
            DropIndex("dbo.DistributorToProducts", new[] { "ProductId" });
            DropIndex("dbo.DistributorToProducts", new[] { "DistributorId" });
            DropTable("dbo.DistributorToProducts");
        }
    }
}
