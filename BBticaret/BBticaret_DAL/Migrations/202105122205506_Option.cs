namespace BBticaret_DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Option : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Options",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 255),
                        Slug = c.String(),
                        SortOrder = c.Int(nullable: false),
                        Logo = c.Int(),
                        OptionGroupId = c.Int(),
                        Attachment = c.String(),
                        UpdatedAt = c.DateTime(precision: 7, storeType: "datetime2"),
                        CreatedAt = c.DateTime(precision: 7, storeType: "datetime2"),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.OptionGroups", t => t.OptionGroupId)
                .Index(t => t.OptionGroupId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Options", "OptionGroupId", "dbo.OptionGroups");
            DropIndex("dbo.Options", new[] { "OptionGroupId" });
            DropTable("dbo.Options");
        }
    }
}
