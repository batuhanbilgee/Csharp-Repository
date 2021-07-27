namespace BBticaret_DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OptionGroup : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.OptionGroups",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 255),
                        Slug = c.String(maxLength: 255),
                        SortOrder = c.Int(),
                        FilterStatus = c.Boolean(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.OptionGroups");
        }
    }
}
