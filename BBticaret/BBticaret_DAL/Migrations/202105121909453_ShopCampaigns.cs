namespace BBticaret_DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ShopCampaigns : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ShopCampaigns",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Label = c.String(maxLength: 255),
                        CreatedAt = c.DateTime(precision: 7, storeType: "datetime2"),
                        UpdatedAt = c.DateTime(precision: 7, storeType: "datetime2"),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ShopCampaigns");
        }
    }
}
