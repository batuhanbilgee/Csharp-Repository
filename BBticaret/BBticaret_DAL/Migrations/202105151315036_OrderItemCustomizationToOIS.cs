namespace BBticaret_DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OrderItemCustomizationToOIS : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.OrderItemSubscriptions", "OrderItemCustomizationId", c => c.Int());
            CreateIndex("dbo.OrderItemSubscriptions", "OrderItemCustomizationId");
            AddForeignKey("dbo.OrderItemSubscriptions", "OrderItemCustomizationId", "dbo.OrderItemCustomizations", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OrderItemSubscriptions", "OrderItemCustomizationId", "dbo.OrderItemCustomizations");
            DropIndex("dbo.OrderItemSubscriptions", new[] { "OrderItemCustomizationId" });
            DropColumn("dbo.OrderItemSubscriptions", "OrderItemCustomizationId");
        }
    }
}
