namespace _21_OOP_Hamburgerci.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EkstraMalzeme",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EkstraMalzemeAdi = c.String(nullable: false, maxLength: 100),
                        EkstraMalzemeFiyati = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SiparisToExtraMalzemes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SiparisId = c.Int(nullable: false),
                        ExtraMalzemeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.EkstraMalzeme", t => t.ExtraMalzemeId, cascadeDelete: true)
                .ForeignKey("dbo.Siparis", t => t.SiparisId, cascadeDelete: true)
                .Index(t => t.SiparisId)
                .Index(t => t.ExtraMalzemeId);
            
            CreateTable(
                "dbo.Siparis",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MenuId = c.Int(nullable: false),
                        Boyutu = c.Int(nullable: false),
                        UrunAdeti = c.Int(nullable: false),
                        ToplamTutar = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Menu", t => t.MenuId, cascadeDelete: true)
                .Index(t => t.MenuId);
            
            CreateTable(
                "dbo.Menu",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MenuAdi = c.String(nullable: false, maxLength: 100),
                        MenuFiyati = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SiparisToExtraMalzemes", "SiparisId", "dbo.Siparis");
            DropForeignKey("dbo.Siparis", "MenuId", "dbo.Menu");
            DropForeignKey("dbo.SiparisToExtraMalzemes", "ExtraMalzemeId", "dbo.EkstraMalzeme");
            DropIndex("dbo.Siparis", new[] { "MenuId" });
            DropIndex("dbo.SiparisToExtraMalzemes", new[] { "ExtraMalzemeId" });
            DropIndex("dbo.SiparisToExtraMalzemes", new[] { "SiparisId" });
            DropTable("dbo.Menu");
            DropTable("dbo.Siparis");
            DropTable("dbo.SiparisToExtraMalzemes");
            DropTable("dbo.EkstraMalzeme");
        }
    }
}
