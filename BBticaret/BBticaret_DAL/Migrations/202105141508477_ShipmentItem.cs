namespace BBticaret_DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ShipmentItem : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ShipmentItems",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RootProductId = c.Single(),
                        Amount = c.Single(nullable: false),
                        Price = c.Single(nullable: false),
                        ProductLabel = c.String(maxLength: 255),
                        Currency = c.Int(nullable: false),
                        Tax = c.Single(),
                        Dm3 = c.Single(nullable: false),
                        CreatedAt = c.DateTime(precision: 7, storeType: "datetime2"),
                        Status = c.Boolean(nullable: false),
                        UpdatedAt = c.DateTime(precision: 7, storeType: "datetime2"),
                        OrderItemId = c.Int(nullable: false),
                        ProductId = c.Int(),
                        ShipmentId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.OrderItems", t => t.OrderItemId, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.ProductId)
                .ForeignKey("dbo.Shipments", t => t.ShipmentId)
                .Index(t => t.OrderItemId)
                .Index(t => t.ProductId)
                .Index(t => t.ShipmentId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ShipmentItems", "ShipmentId", "dbo.Shipments");
            DropForeignKey("dbo.ShipmentItems", "ProductId", "dbo.Products");
            DropForeignKey("dbo.ShipmentItems", "OrderItemId", "dbo.OrderItems");
            DropIndex("dbo.ShipmentItems", new[] { "ShipmentId" });
            DropIndex("dbo.ShipmentItems", new[] { "ProductId" });
            DropIndex("dbo.ShipmentItems", new[] { "OrderItemId" });
            DropTable("dbo.ShipmentItems");
        }
    }
}
