namespace BBticaret_DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FavouritedProduct : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FavouritedProducts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MemberId = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Members", t => t.MemberId, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.MemberId)
                .Index(t => t.ProductId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.FavouritedProducts", "ProductId", "dbo.Products");
            DropForeignKey("dbo.FavouritedProducts", "MemberId", "dbo.Members");
            DropIndex("dbo.FavouritedProducts", new[] { "ProductId" });
            DropIndex("dbo.FavouritedProducts", new[] { "MemberId" });
            DropTable("dbo.FavouritedProducts");
        }
    }
}
