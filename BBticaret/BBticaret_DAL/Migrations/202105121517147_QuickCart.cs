namespace BBticaret_DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class QuickCart : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.QuickCarts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 255),
                        Url = c.String(nullable: false, maxLength: 2048),
                        ShortUrl = c.String(maxLength: 255),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.QuickCarts");
        }
    }
}
