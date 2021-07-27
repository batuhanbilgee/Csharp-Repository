namespace BBticaret_DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CurrentAccount : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CurrentAccount",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(maxLength: 255),
                        Title = c.String(nullable: false, maxLength: 255),
                        Balance = c.Single(),
                        RiskLimit = c.Single(),
                        CreatedAt = c.DateTime(precision: 7, storeType: "datetime2"),
                        UpdatedAt = c.DateTime(precision: 7, storeType: "datetime2"),
                        MemberId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Members", t => t.MemberId)
                .Index(t => t.MemberId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CurrentAccount", "MemberId", "dbo.Members");
            DropIndex("dbo.CurrentAccount", new[] { "MemberId" });
            DropTable("dbo.CurrentAccount");
        }
    }
}
