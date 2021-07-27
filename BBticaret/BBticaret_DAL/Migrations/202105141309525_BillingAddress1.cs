namespace BBticaret_DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BillingAddress1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.BillingAddresses", "OrderId", c => c.Int());
            CreateIndex("dbo.BillingAddresses", "OrderId");
            AddForeignKey("dbo.BillingAddresses", "OrderId", "dbo.Orders", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.BillingAddresses", "OrderId", "dbo.Orders");
            DropIndex("dbo.BillingAddresses", new[] { "OrderId" });
            DropColumn("dbo.BillingAddresses", "OrderId");
        }
    }
}
