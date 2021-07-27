namespace BBticaret_DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ProductToCountDown : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ProductToCountDowns",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StartDate = c.DateTime(precision: 7, storeType: "datetime2"),
                        EndDate = c.DateTime(precision: 7, storeType: "datetime2"),
                        ExpireDate = c.DateTime(precision: 7, storeType: "datetime2"),
                        UseCountDown = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ProductToCountDowns");
        }
    }
}
