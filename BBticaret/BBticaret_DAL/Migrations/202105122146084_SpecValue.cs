namespace BBticaret_DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SpecValue : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SpecValues",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 255),
                        Slug = c.String(maxLength: 255),
                        SortOrder = c.Int(),
                        Logo = c.Int(),
                        Status = c.Boolean(nullable: false),
                        Attachment = c.String(),
                        SpecGroupId = c.Int(),
                        SpecNameId = c.Int(),
                        UpdatedAt = c.DateTime(),
                        CreatedAt = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.SpecGroup", t => t.SpecGroupId)
                .ForeignKey("dbo.SpecName", t => t.SpecNameId)
                .Index(t => t.SpecGroupId)
                .Index(t => t.SpecNameId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SpecValues", "SpecNameId", "dbo.SpecName");
            DropForeignKey("dbo.SpecValues", "SpecGroupId", "dbo.SpecGroup");
            DropIndex("dbo.SpecValues", new[] { "SpecNameId" });
            DropIndex("dbo.SpecValues", new[] { "SpecGroupId" });
            DropTable("dbo.SpecValues");
        }
    }
}
