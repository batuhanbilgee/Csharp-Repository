namespace BBticaret_DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ScriptTag : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ScriptTags",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Src = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ScriptTags");
        }
    }
}
