namespace BBticaret_DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Maillist : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Maillists",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 255),
                        Email = c.String(nullable: false, maxLength: 255),
                        LastMailSentDate = c.DateTime(precision: 7, storeType: "datetime2"),
                        CreatorIpAddress = c.String(maxLength: 64),
                        CreatedAt = c.DateTime(precision: 7, storeType: "datetime2"),
                        UpdatedAt = c.DateTime(precision: 7, storeType: "datetime2"),
                        MailListGroupId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.MaillistGroups", t => t.MailListGroupId)
                .Index(t => t.MailListGroupId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Maillists", "MailListGroupId", "dbo.MaillistGroups");
            DropIndex("dbo.Maillists", new[] { "MailListGroupId" });
            DropTable("dbo.Maillists");
        }
    }
}
