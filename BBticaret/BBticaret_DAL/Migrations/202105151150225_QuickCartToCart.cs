namespace BBticaret_DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class QuickCartToCart : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.QuickCarts", "CartId", c => c.Int());
            CreateIndex("dbo.QuickCarts", "CartId");
            AddForeignKey("dbo.QuickCarts", "CartId", "dbo.Carts", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.QuickCarts", "CartId", "dbo.Carts");
            DropIndex("dbo.QuickCarts", new[] { "CartId" });
            DropColumn("dbo.QuickCarts", "CartId");
        }
    }
}
