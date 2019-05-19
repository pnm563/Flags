namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class QuestionClass : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Questions",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        TimeStamp = c.DateTime(nullable: false),
                        AspNetUserID = c.Guid(nullable: false),
                        UserAnswer = c.Guid(nullable: false),
                        CorrectAnswer = c.Guid(nullable: false),
                        QuestionText = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Questions");
        }
    }
}
