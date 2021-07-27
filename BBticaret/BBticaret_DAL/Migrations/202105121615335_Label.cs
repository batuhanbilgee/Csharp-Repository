namespace BBticaret_DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Label : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Labels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 255),
                        SortOrder = c.Int(),
                        HasChildren = c.Boolean(),
                        Slug = c.String(maxLength: 255),
                        MetaTitle = c.String(maxLength: 255),
                        MetaKeywords = c.String(maxLength: 255),
                        MetaDescription = c.String(maxLength: 255),
                        Status = c.Boolean(nullable: false),
                        LabelId = c.Int(),
                        CreatedAt = c.DateTime(nullable: false),
                        UpdatedAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Labels", t => t.LabelId)
                .Index(t => t.LabelId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Labels", "LabelId", "dbo.Labels");
            DropIndex("dbo.Labels", new[] { "LabelId" });
            DropTable("dbo.Labels");
        }
    }
}
