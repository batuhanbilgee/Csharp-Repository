namespace BBticaret_DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ProductToCountDown1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ProductToCountDowns", "ProductId", c => c.Int());
            CreateIndex("dbo.ProductToCountDowns", "ProductId");
            AddForeignKey("dbo.ProductToCountDowns", "ProductId", "dbo.Products", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProductToCountDowns", "ProductId", "dbo.Products");
            DropIndex("dbo.ProductToCountDowns", new[] { "ProductId" });
            DropColumn("dbo.ProductToCountDowns", "ProductId");
        }
    }
}
