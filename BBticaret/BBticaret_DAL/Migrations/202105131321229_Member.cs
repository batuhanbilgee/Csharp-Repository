namespace BBticaret_DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Member : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Members",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 255),
                        SurName = c.String(nullable: false, maxLength: 255),
                        Email = c.String(nullable: false, maxLength: 255),
                        Gender = c.Boolean(),
                        BirthDate = c.DateTime(precision: 7, storeType: "datetime2"),
                        PhoneNumber = c.String(maxLength: 255),
                        MobilePhoneNumber = c.String(nullable: false, maxLength: 255),
                        OtherLocation = c.String(maxLength: 255),
                        Address = c.String(),
                        TaxNumber = c.String(maxLength: 255),
                        TCLD = c.String(maxLength: 255),
                        Status = c.Int(nullable: false),
                        LastLoginDate = c.DateTime(precision: 7, storeType: "datetime2"),
                        CreatedAt = c.DateTime(precision: 7, storeType: "datetime2"),
                        UpdatedAt = c.DateTime(precision: 7, storeType: "datetime2"),
                        ZipCode = c.String(maxLength: 50),
                        CommercialName = c.String(maxLength: 255),
                        TaxOffice = c.String(maxLength: 255),
                        LastMailSentDate = c.DateTime(precision: 7, storeType: "datetime2"),
                        LastIp = c.String(maxLength: 255),
                        GainedPointAmount = c.Int(),
                        SpentPointAmount = c.Int(),
                        AllowedToCampaigns = c.Boolean(nullable: false),
                        AllowedToCampaignsUpdatedAt = c.DateTime(precision: 7, storeType: "datetime2"),
                        ReferredMemberGainedPointAmount = c.Int(),
                        District = c.String(maxLength: 255),
                        DeviceType = c.String(nullable: false, maxLength: 255),
                        DeviceInfo = c.String(),
                        CountryId = c.Int(),
                        LocationId = c.Int(),
                        MemberGroupId = c.Int(),
                        ReferredMemberId = c.Int(),
                        KvkkStatus = c.Boolean(),
                        KvkkConfirmationDate = c.DateTime(precision: 7, storeType: "datetime2"),
                        ParentMember_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Countries", t => t.CountryId)
                .ForeignKey("dbo.Location", t => t.LocationId)
                .ForeignKey("dbo.MemberGroups", t => t.MemberGroupId)
                .ForeignKey("dbo.Members", t => t.ParentMember_Id)
                .Index(t => t.CountryId)
                .Index(t => t.LocationId)
                .Index(t => t.MemberGroupId)
                .Index(t => t.ParentMember_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Members", "ParentMember_Id", "dbo.Members");
            DropForeignKey("dbo.Members", "MemberGroupId", "dbo.MemberGroups");
            DropForeignKey("dbo.Members", "LocationId", "dbo.Location");
            DropForeignKey("dbo.Members", "CountryId", "dbo.Countries");
            DropIndex("dbo.Members", new[] { "ParentMember_Id" });
            DropIndex("dbo.Members", new[] { "MemberGroupId" });
            DropIndex("dbo.Members", new[] { "LocationId" });
            DropIndex("dbo.Members", new[] { "CountryId" });
            DropTable("dbo.Members");
        }
    }
}
