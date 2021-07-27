namespace BBticaret_DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PaymentToError : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Payments", "ErrorId", c => c.Int());
            CreateIndex("dbo.Payments", "ErrorId");
            AddForeignKey("dbo.Payments", "ErrorId", "dbo.Errors", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Payments", "ErrorId", "dbo.Errors");
            DropIndex("dbo.Payments", new[] { "ErrorId" });
            DropColumn("dbo.Payments", "ErrorId");
        }
    }
}
