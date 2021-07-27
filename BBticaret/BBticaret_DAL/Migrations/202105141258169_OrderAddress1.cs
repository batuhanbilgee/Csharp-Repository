namespace BBticaret_DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OrderAddress1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.OrderAddresses", "OrderId", c => c.Int());
            CreateIndex("dbo.OrderAddresses", "OrderId");
            AddForeignKey("dbo.OrderAddresses", "OrderId", "dbo.Orders", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OrderAddresses", "OrderId", "dbo.Orders");
            DropIndex("dbo.OrderAddresses", new[] { "OrderId" });
            DropColumn("dbo.OrderAddresses", "OrderId");
        }
    }
}
