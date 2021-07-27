namespace BBticaret_DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PaymentGateway : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PaymentGateways",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(nullable: false, maxLength: 255),
                        Name = c.String(nullable: false, maxLength: 255),
                        Status = c.Boolean(nullable: false),
                        SortOrder = c.Single(),
                        PaymentProviderId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.PaymentProviders", t => t.PaymentProviderId, cascadeDelete: true)
                .Index(t => t.PaymentProviderId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PaymentGateways", "PaymentProviderId", "dbo.PaymentProviders");
            DropIndex("dbo.PaymentGateways", new[] { "PaymentProviderId" });
            DropTable("dbo.PaymentGateways");
        }
    }
}
