namespace BBticaret_DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Location : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Location",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 255),
                        Status = c.Boolean(nullable: false),
                        Predefined = c.Int(),
                        CountryId = c.Int(),
                        RegionId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Countries", t => t.CountryId)
                .ForeignKey("dbo.Regions", t => t.RegionId)
                .Index(t => t.CountryId)
                .Index(t => t.RegionId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Location", "RegionId", "dbo.Regions");
            DropForeignKey("dbo.Location", "CountryId", "dbo.Countries");
            DropIndex("dbo.Location", new[] { "RegionId" });
            DropIndex("dbo.Location", new[] { "CountryId" });
            DropTable("dbo.Location");
        }
    }
}
