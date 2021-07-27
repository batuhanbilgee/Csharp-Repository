namespace BBticaret_DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Theme : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Theme",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Platform = c.Int(nullable: false),
                        Type = c.Int(),
                        Name = c.String(nullable: false, maxLength: 255),
                        Preset = c.String(maxLength: 255),
                        DirectoryName = c.String(maxLength: 255),
                        Status = c.Boolean(nullable: false),
                        Revision = c.Int(),
                        Version = c.Int(),
                        CreatedAt = c.DateTime(precision: 7, storeType: "datetime2"),
                        UpdatedAt = c.DateTime(precision: 7, storeType: "datetime2"),
                        Attachment = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Theme");
        }
    }
}
