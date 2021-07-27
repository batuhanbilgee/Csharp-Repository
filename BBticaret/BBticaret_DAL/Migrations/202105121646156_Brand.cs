namespace BBticaret_DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Brand : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Brands",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 255),
                        Slug = c.String(maxLength: 255),
                        SortOrder = c.Int(nullable: false),
                        Status = c.Boolean(nullable: false),
                        DistributorCode = c.String(maxLength: 255),
                        Distributor = c.String(maxLength: 255),
                        ImageFile = c.String(maxLength: 255),
                        ShowcaseContent = c.String(),
                        DisplayShowcaseContent = c.Boolean(nullable: false),
                        MetaKeywords = c.String(),
                        MetaDescription = c.String(),
                        PageTitle = c.String(maxLength: 255),
                        Attachment = c.String(),
                        CreatedAt = c.DateTime(precision: 7, storeType: "datetime2"),
                        UpdatedAt = c.DateTime(precision: 7, storeType: "datetime2"),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Brands");
        }
    }
}
