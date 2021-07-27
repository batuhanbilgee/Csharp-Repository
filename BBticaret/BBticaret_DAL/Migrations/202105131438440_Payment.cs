namespace BBticaret_DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Payment : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Payments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MemberFirstName = c.String(nullable: false, maxLength: 255),
                        MemberSurname = c.String(nullable: false, maxLength: 255),
                        MemberEmail = c.String(nullable: false, maxLength: 255),
                        MemberPhone = c.String(maxLength: 255),
                        PaymentTypeName = c.String(nullable: false, maxLength: 128),
                        PaymentProviderCode = c.String(nullable: false, maxLength: 64),
                        PaymentProviderName = c.String(nullable: false, maxLength: 128),
                        PaymentGatewayName = c.String(nullable: false, maxLength: 128),
                        PaymentGatewayCode = c.String(nullable: false, maxLength: 64),
                        BankName = c.String(maxLength: 64),
                        DeviceType = c.Int(nullable: false),
                        ClientIp = c.String(nullable: false, maxLength: 32),
                        CurrencyRates = c.String(nullable: false, maxLength: 255),
                        Amount = c.Single(nullable: false),
                        FinalAmount = c.Single(nullable: false),
                        SumOfGainedPoints = c.Single(),
                        Installment = c.Int(nullable: false),
                        InstallmentRate = c.Single(nullable: false),
                        ExtraInstallment = c.Int(),
                        Currency = c.String(nullable: false, maxLength: 32),
                        TransactionId = c.String(maxLength: 255),
                        MemberNote = c.String(),
                        UserNote = c.String(),
                        Status = c.Int(nullable: false),
                        ErrorMessage = c.String(),
                        CardSavingSystem = c.String(),
                        CreatedAt = c.DateTime(precision: 7, storeType: "datetime2"),
                        MemberId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Members", t => t.MemberId)
                .Index(t => t.MemberId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Payments", "MemberId", "dbo.Members");
            DropIndex("dbo.Payments", new[] { "MemberId" });
            DropTable("dbo.Payments");
        }
    }
}
