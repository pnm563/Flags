namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class HereComesTheIndexNo : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CountryFlags", "IndexNo", c => c.Int(nullable: false, identity: true));
        }
        
        public override void Down()
        {
            DropColumn("dbo.CountryFlags", "IndexNo");
        }
    }
}
