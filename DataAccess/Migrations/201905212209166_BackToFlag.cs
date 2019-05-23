namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BackToFlag : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Flags",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        Description = c.String(),
                        IndexNo = c.Int(nullable: false, identity: true),
                        ImageFile = c.String(),
                        FlagType = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            DropTable("dbo.CountryFlags");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.CountryFlags",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        CountryCode = c.String(),
                        Description = c.String(),
                        IndexNo = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.ID);
            
            DropTable("dbo.Flags");
        }
    }
}
