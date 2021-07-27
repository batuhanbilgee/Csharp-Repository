namespace BBticaret_DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SpecToProduct : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SpecToProducts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductId = c.Int(),
                        SpecGroupId = c.Int(),
                        SpecNameId = c.Int(),
                        SpecValueId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Products", t => t.ProductId)
                .ForeignKey("dbo.SpecGroup", t => t.SpecGroupId)
                .ForeignKey("dbo.SpecName", t => t.SpecNameId)
                .ForeignKey("dbo.SpecValues", t => t.SpecValueId)
                .Index(t => t.ProductId)
                .Index(t => t.SpecGroupId)
                .Index(t => t.SpecNameId)
                .Index(t => t.SpecValueId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SpecToProducts", "SpecValueId", "dbo.SpecValues");
            DropForeignKey("dbo.SpecToProducts", "SpecNameId", "dbo.SpecName");
            DropForeignKey("dbo.SpecToProducts", "SpecGroupId", "dbo.SpecGroup");
            DropForeignKey("dbo.SpecToProducts", "ProductId", "dbo.Products");
            DropIndex("dbo.SpecToProducts", new[] { "SpecValueId" });
            DropIndex("dbo.SpecToProducts", new[] { "SpecNameId" });
            DropIndex("dbo.SpecToProducts", new[] { "SpecGroupId" });
            DropIndex("dbo.SpecToProducts", new[] { "ProductId" });
            DropTable("dbo.SpecToProducts");
        }
    }
}
