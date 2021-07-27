namespace BBticaret_DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OrderItemCustomization : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.OrderItemCustomizations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductCustomizationGroupId = c.Int(),
                        ProductCustomizationGroupName = c.String(maxLength: 255),
                        ProductCustomizationGroupSortOrder = c.Int(),
                        ProductCustomizationFieldId = c.Int(),
                        ProductCustomizationFieldType = c.String(maxLength: 64),
                        ProductCustomizationFieldName = c.String(maxLength: 255),
                        ProductCustomizationFieldValue = c.String(),
                        CartItemAttributeId = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.OrderItemCustomizations");
        }
    }
}
