namespace BBticaret_DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ProductSpecialInfo : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ProductSpecialInfos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 255),
                        Content = c.String(nullable: false),
                        Status = c.Boolean(nullable: false),
                        ProductId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.ProductId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProductSpecialInfos", "ProductId", "dbo.Products");
            DropIndex("dbo.ProductSpecialInfos", new[] { "ProductId" });
            DropTable("dbo.ProductSpecialInfos");
        }
    }
}
