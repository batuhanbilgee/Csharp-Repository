namespace BBticaret_DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PaymentProvider1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PaymentProviders", "PaymentProviderSettingId", c => c.Int());
            CreateIndex("dbo.PaymentProviders", "PaymentProviderSettingId");
            AddForeignKey("dbo.PaymentProviders", "PaymentProviderSettingId", "dbo.PaymentProviderSetting", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PaymentProviders", "PaymentProviderSettingId", "dbo.PaymentProviderSetting");
            DropIndex("dbo.PaymentProviders", new[] { "PaymentProviderSettingId" });
            DropColumn("dbo.PaymentProviders", "PaymentProviderSettingId");
        }
    }
}
