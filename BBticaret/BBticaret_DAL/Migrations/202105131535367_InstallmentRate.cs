namespace BBticaret_DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InstallmentRate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.InstallmentRates",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Installment = c.Int(nullable: false),
                        Rate = c.Int(nullable: false),
                        PaymentGatewayId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.PaymentGateways", t => t.PaymentGatewayId, cascadeDelete: true)
                .Index(t => t.PaymentGatewayId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.InstallmentRates", "PaymentGatewayId", "dbo.PaymentGateways");
            DropIndex("dbo.InstallmentRates", new[] { "PaymentGatewayId" });
            DropTable("dbo.InstallmentRates");
        }
    }
}
