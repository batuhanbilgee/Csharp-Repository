namespace BBticaret_DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PaymentProviderSetting : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PaymentProviderSetting",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Varkey = c.String(nullable: false, maxLength: 255),
                        VarValue = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.PaymentProviderSetting");
        }
    }
}
