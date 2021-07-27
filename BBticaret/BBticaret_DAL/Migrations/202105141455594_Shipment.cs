namespace BBticaret_DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Shipment : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Shipments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Barcode = c.String(maxLength: 255),
                        WaybillNo = c.String(maxLength: 255),
                        InvoiceKey = c.String(maxLength: 255),
                        CargoOffice = c.String(maxLength: 255),
                        Code = c.String(maxLength: 255),
                        DeliveryType = c.String(maxLength: 255),
                        InvoiceIncluded = c.Boolean(),
                        PayAtDoorAmount = c.Single(),
                        CreatedAt = c.DateTime(precision: 7, storeType: "datetime2"),
                        Status = c.Boolean(nullable: false),
                        OrderId = c.Int(nullable: false),
                        BarcodeImage = c.String(),
                        TrackingUrl = c.String(maxLength: 255),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Orders", t => t.OrderId, cascadeDelete: true)
                .Index(t => t.OrderId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Shipments", "OrderId", "dbo.Orders");
            DropIndex("dbo.Shipments", new[] { "OrderId" });
            DropTable("dbo.Shipments");
        }
    }
}
