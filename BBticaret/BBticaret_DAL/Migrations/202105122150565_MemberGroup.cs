namespace BBticaret_DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MemberGroup : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MemberGroups",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 512),
                        PriceIndex = c.Int(nullable: false),
                        AllowedPaymentGateways = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.MemberGroups");
        }
    }
}
