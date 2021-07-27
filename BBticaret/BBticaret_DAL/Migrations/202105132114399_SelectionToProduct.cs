namespace BBticaret_DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SelectionToProduct : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SelectionToProducts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SelectionId = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .ForeignKey("dbo.Selections", t => t.SelectionId, cascadeDelete: true)
                .Index(t => t.SelectionId)
                .Index(t => t.ProductId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SelectionToProducts", "SelectionId", "dbo.Selections");
            DropForeignKey("dbo.SelectionToProducts", "ProductId", "dbo.Products");
            DropIndex("dbo.SelectionToProducts", new[] { "ProductId" });
            DropIndex("dbo.SelectionToProducts", new[] { "SelectionId" });
            DropTable("dbo.SelectionToProducts");
        }
    }
}
