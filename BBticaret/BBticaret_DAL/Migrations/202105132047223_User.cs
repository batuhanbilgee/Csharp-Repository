namespace BBticaret_DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class User : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(maxLength: 255),
                        SurName = c.String(maxLength: 255),
                        Email = c.String(nullable: false, maxLength: 255),
                        UserName = c.String(nullable: false, maxLength: 255),
                        PhoneNumber = c.String(maxLength: 255),
                        Status = c.Int(nullable: false),
                        IsOwner = c.Boolean(),
                        SmsApproved = c.Boolean(),
                        UserLevelId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ShopUserlevels", t => t.UserLevelId)
                .Index(t => t.UserLevelId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "UserLevelId", "dbo.ShopUserlevels");
            DropIndex("dbo.Users", new[] { "UserLevelId" });
            DropTable("dbo.Users");
        }
    }
}
