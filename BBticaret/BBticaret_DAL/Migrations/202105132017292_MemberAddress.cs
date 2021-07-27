namespace BBticaret_DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MemberAddress : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MemberAddresses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 255),
                        Type = c.Int(),
                        FirstName = c.String(maxLength: 255),
                        SurName = c.String(maxLength: 255),
                        Address = c.String(),
                        SubLocationName = c.String(maxLength: 255),
                        PhoneNumber = c.String(maxLength: 32),
                        MobilePhoneNumber = c.String(maxLength: 32),
                        TCLD = c.String(maxLength: 55),
                        TaxNumber = c.String(maxLength: 255),
                        TaxOffice = c.String(maxLength: 255),
                        InvoiceType = c.Int(),
                        IsEinvoiceUser = c.Boolean(),
                        CreatedAt = c.DateTime(precision: 7, storeType: "datetime2"),
                        UpdatedAt = c.DateTime(precision: 7, storeType: "datetime2"),
                        MemberId = c.Int(),
                        CountryId = c.Int(),
                        LocationId = c.Int(),
                        SubLocationId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Countries", t => t.CountryId)
                .ForeignKey("dbo.Location", t => t.LocationId)
                .ForeignKey("dbo.Members", t => t.MemberId)
                .ForeignKey("dbo.Towns", t => t.SubLocationId)
                .Index(t => t.MemberId)
                .Index(t => t.CountryId)
                .Index(t => t.LocationId)
                .Index(t => t.SubLocationId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MemberAddresses", "SubLocationId", "dbo.Towns");
            DropForeignKey("dbo.MemberAddresses", "MemberId", "dbo.Members");
            DropForeignKey("dbo.MemberAddresses", "LocationId", "dbo.Location");
            DropForeignKey("dbo.MemberAddresses", "CountryId", "dbo.Countries");
            DropIndex("dbo.MemberAddresses", new[] { "SubLocationId" });
            DropIndex("dbo.MemberAddresses", new[] { "LocationId" });
            DropIndex("dbo.MemberAddresses", new[] { "CountryId" });
            DropIndex("dbo.MemberAddresses", new[] { "MemberId" });
            DropTable("dbo.MemberAddresses");
        }
    }
}
