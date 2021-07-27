namespace BBticaret_DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AssetToTheme : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Theme", "AssetId", c => c.Int());
            CreateIndex("dbo.Theme", "AssetId");
            AddForeignKey("dbo.Theme", "AssetId", "dbo.Assets", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Theme", "AssetId", "dbo.Assets");
            DropIndex("dbo.Theme", new[] { "AssetId" });
            DropColumn("dbo.Theme", "AssetId");
        }
    }
}
