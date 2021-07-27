namespace BBticaret_DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Asset : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Assets",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Key = c.Int(),
                        ContentType = c.String(),
                        Attachment = c.String(),
                        CreatedAt = c.DateTime(precision: 7, storeType: "datetime2"),
                        UpdatedAd = c.DateTime(precision: 7, storeType: "datetime2"),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Assets");
        }
    }
}
