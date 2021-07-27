namespace BBticaret_DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LabelToProduct : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.LabelToProducts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LabelId = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Labels", t => t.LabelId, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.LabelId)
                .Index(t => t.ProductId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.LabelToProducts", "ProductId", "dbo.Products");
            DropForeignKey("dbo.LabelToProducts", "LabelId", "dbo.Labels");
            DropIndex("dbo.LabelToProducts", new[] { "ProductId" });
            DropIndex("dbo.LabelToProducts", new[] { "LabelId" });
            DropTable("dbo.LabelToProducts");
        }
    }
}
