namespace BBticaret_DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OrderUserNote : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.OrderUserNotes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserEmail = c.String(nullable: false, maxLength: 255),
                        UserFirstname = c.String(maxLength: 255),
                        UserSurname = c.String(maxLength: 255),
                        Note = c.String(nullable: false),
                        CreatedAt = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        UpdatedAt = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        OrderId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Orders", t => t.OrderId, cascadeDelete: true)
                .Index(t => t.OrderId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OrderUserNotes", "OrderId", "dbo.Orders");
            DropIndex("dbo.OrderUserNotes", new[] { "OrderId" });
            DropTable("dbo.OrderUserNotes");
        }
    }
}
