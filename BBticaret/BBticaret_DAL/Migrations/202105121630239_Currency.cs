namespace BBticaret_DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Currency : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Currency",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Label = c.String(maxLength: 50),
                        BuyingPrice = c.Int(),
                        SellingPrice = c.Int(),
                        Abbr = c.String(maxLength: 5),
                        UpdatedAt = c.DateTime(precision: 7, storeType: "datetime2"),
                        Status = c.Boolean(),
                        IsPrimary = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Currency");
        }
    }
}
