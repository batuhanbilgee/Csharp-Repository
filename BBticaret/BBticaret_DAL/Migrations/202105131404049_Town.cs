namespace BBticaret_DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Town : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Towns",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 255),
                        Status = c.Boolean(nullable: false),
                        LocationId = c.Int(),
                        TownGroupId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Location", t => t.LocationId)
                .ForeignKey("dbo.TownGroups", t => t.TownGroupId)
                .Index(t => t.LocationId)
                .Index(t => t.TownGroupId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Towns", "TownGroupId", "dbo.TownGroups");
            DropForeignKey("dbo.Towns", "LocationId", "dbo.Location");
            DropIndex("dbo.Towns", new[] { "TownGroupId" });
            DropIndex("dbo.Towns", new[] { "LocationId" });
            DropTable("dbo.Towns");
        }
    }
}
