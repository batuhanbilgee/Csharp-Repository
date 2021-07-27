namespace BBticaret_DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OptionToProduct : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.OptionToProducts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ParentProductId = c.Int(nullable: false),
                        OptionGroupId = c.Int(nullable: false),
                        OptionId = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Options", t => t.OptionId, cascadeDelete: true)
                .ForeignKey("dbo.OptionGroups", t => t.OptionGroupId, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.OptionGroupId)
                .Index(t => t.OptionId)
                .Index(t => t.ProductId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OptionToProducts", "ProductId", "dbo.Products");
            DropForeignKey("dbo.OptionToProducts", "OptionGroupId", "dbo.OptionGroups");
            DropForeignKey("dbo.OptionToProducts", "OptionId", "dbo.Options");
            DropIndex("dbo.OptionToProducts", new[] { "ProductId" });
            DropIndex("dbo.OptionToProducts", new[] { "OptionId" });
            DropIndex("dbo.OptionToProducts", new[] { "OptionGroupId" });
            DropTable("dbo.OptionToProducts");
        }
    }
}
