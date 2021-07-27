namespace BBticaret_DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PreferenceToDistributor : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Distributors", "PreferanceId", c => c.Int());
            CreateIndex("dbo.Distributors", "PreferanceId");
            AddForeignKey("dbo.Distributors", "PreferanceId", "dbo.Preferences", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Distributors", "PreferanceId", "dbo.Preferences");
            DropIndex("dbo.Distributors", new[] { "PreferanceId" });
            DropColumn("dbo.Distributors", "PreferanceId");
        }
    }
}
