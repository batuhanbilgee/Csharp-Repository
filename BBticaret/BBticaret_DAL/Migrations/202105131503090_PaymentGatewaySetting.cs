namespace BBticaret_DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PaymentGatewaySetting : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PaymentGatewaySettings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Varkey = c.String(nullable: false, maxLength: 255),
                        VarValue = c.String(nullable: false, maxLength: 255),
                        PaymentGatewayId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.PaymentGateways", t => t.PaymentGatewayId)
                .Index(t => t.PaymentGatewayId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PaymentGatewaySettings", "PaymentGatewayId", "dbo.PaymentGateways");
            DropIndex("dbo.PaymentGatewaySettings", new[] { "PaymentGatewayId" });
            DropTable("dbo.PaymentGatewaySettings");
        }
    }
}
