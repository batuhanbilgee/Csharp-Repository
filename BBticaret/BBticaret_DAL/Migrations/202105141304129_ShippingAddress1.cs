namespace BBticaret_DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ShippingAddress1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ShippingAddresses", "OrderId", c => c.Int());
            CreateIndex("dbo.ShippingAddresses", "OrderId");
            AddForeignKey("dbo.ShippingAddresses", "OrderId", "dbo.Orders", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ShippingAddresses", "OrderId", "dbo.Orders");
            DropIndex("dbo.ShippingAddresses", new[] { "OrderId" });
            DropColumn("dbo.ShippingAddresses", "OrderId");
        }
    }
}
