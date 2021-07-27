namespace BBticaret_DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SpecName : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SpecName",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 255),
                        Slug = c.String(nullable: false, maxLength: 255),
                        ChoiceType = c.Int(nullable: false),
                        SortOrder = c.Int(),
                        Status = c.Boolean(nullable: false),
                        SpecGroupId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.SpecGroup", t => t.SpecGroupId, cascadeDelete: true)
                .Index(t => t.SpecGroupId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SpecName", "SpecGroupId", "dbo.SpecGroup");
            DropIndex("dbo.SpecName", new[] { "SpecGroupId" });
            DropTable("dbo.SpecName");
        }
    }
}
