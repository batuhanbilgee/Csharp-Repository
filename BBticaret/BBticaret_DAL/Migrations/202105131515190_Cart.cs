namespace BBticaret_DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Cart : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Carts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SessionId = c.String(nullable: false, maxLength: 255),
                        Locked = c.Boolean(nullable: false),
                        CreatedAt = c.DateTime(precision: 7, storeType: "datetime2"),
                        UpdatedAt = c.DateTime(precision: 7, storeType: "datetime2"),
                        ShopCampaingsId = c.Int(),
                        MemberId = c.Int(),
                        ShopTokenId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Members", t => t.MemberId)
                .ForeignKey("dbo.ShopCampaigns", t => t.ShopCampaingsId)
                .ForeignKey("dbo.ShopTokens", t => t.ShopTokenId)
                .Index(t => t.ShopCampaingsId)
                .Index(t => t.MemberId)
                .Index(t => t.ShopTokenId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Carts", "ShopTokenId", "dbo.ShopTokens");
            DropForeignKey("dbo.Carts", "ShopCampaingsId", "dbo.ShopCampaigns");
            DropForeignKey("dbo.Carts", "MemberId", "dbo.Members");
            DropIndex("dbo.Carts", new[] { "ShopTokenId" });
            DropIndex("dbo.Carts", new[] { "MemberId" });
            DropIndex("dbo.Carts", new[] { "ShopCampaingsId" });
            DropTable("dbo.Carts");
        }
    }
}
