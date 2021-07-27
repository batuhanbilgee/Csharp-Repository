namespace BBticaret_DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PaymentProvider : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PaymentProviders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(nullable: false, maxLength: 255),
                        Name = c.String(nullable: false, maxLength: 255),
                        Status = c.Boolean(nullable: false),
                        PaymentTypeId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.PaymentTypes", t => t.PaymentTypeId)
                .Index(t => t.PaymentTypeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PaymentProviders", "PaymentTypeId", "dbo.PaymentTypes");
            DropIndex("dbo.PaymentProviders", new[] { "PaymentTypeId" });
            DropTable("dbo.PaymentProviders");
        }
    }
}
