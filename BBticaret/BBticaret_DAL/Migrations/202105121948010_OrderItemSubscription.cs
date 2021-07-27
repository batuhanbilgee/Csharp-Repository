namespace BBticaret_DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OrderItemSubscription : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.OrderItemSubscriptions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.OrderItemSubscriptions");
        }
    }
}
