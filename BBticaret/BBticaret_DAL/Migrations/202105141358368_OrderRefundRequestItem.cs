namespace BBticaret_DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OrderRefundRequestItem : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.OrderRefundRequestItems",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Amount = c.Single(nullable: false),
                        Reason = c.Int(nullable: false),
                        Details = c.String(nullable: false),
                        CreatedAt = c.DateTime(precision: 7, storeType: "datetime2"),
                        UpdatedAt = c.DateTime(precision: 7, storeType: "datetime2"),
                        OrderItemId = c.Int(nullable: false),
                        OrderRefundRequestId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.OrderItems", t => t.OrderItemId, cascadeDelete: true)
                .ForeignKey("dbo.OrderRefundRequests", t => t.OrderRefundRequestId, cascadeDelete: true)
                .Index(t => t.OrderItemId)
                .Index(t => t.OrderRefundRequestId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OrderRefundRequestItems", "OrderRefundRequestId", "dbo.OrderRefundRequests");
            DropForeignKey("dbo.OrderRefundRequestItems", "OrderItemId", "dbo.OrderItems");
            DropIndex("dbo.OrderRefundRequestItems", new[] { "OrderRefundRequestId" });
            DropIndex("dbo.OrderRefundRequestItems", new[] { "OrderItemId" });
            DropTable("dbo.OrderRefundRequestItems");
        }
    }
}
