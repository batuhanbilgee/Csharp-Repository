namespace BBticaret_DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ExtraInfoToProduct : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ExtraInfoToProducts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Value = c.String(nullable: false),
                        ExtraInfoId = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ExtraInfos", t => t.ExtraInfoId, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.ExtraInfoId)
                .Index(t => t.ProductId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ExtraInfoToProducts", "ProductId", "dbo.Products");
            DropForeignKey("dbo.ExtraInfoToProducts", "ExtraInfoId", "dbo.ExtraInfos");
            DropIndex("dbo.ExtraInfoToProducts", new[] { "ProductId" });
            DropIndex("dbo.ExtraInfoToProducts", new[] { "ExtraInfoId" });
            DropTable("dbo.ExtraInfoToProducts");
        }
    }
}
