namespace BBticaret_DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Selection : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Selections",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(maxLength: 255),
                        SortOrder = c.Int(nullable: false),
                        SelectionGroupId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.SelectionGroups", t => t.SelectionGroupId)
                .Index(t => t.SelectionGroupId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Selections", "SelectionGroupId", "dbo.SelectionGroups");
            DropIndex("dbo.Selections", new[] { "SelectionGroupId" });
            DropTable("dbo.Selections");
        }
    }
}
