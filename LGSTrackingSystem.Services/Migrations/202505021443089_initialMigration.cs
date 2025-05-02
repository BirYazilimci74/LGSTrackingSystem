namespace LGSTrackingSystem.Services.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admins",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Email = c.String(),
                        PhoneNumber = c.String(),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Username = c.String(),
                        Password = c.String(),
                        Role = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Exams",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ExamDate = c.DateTime(nullable: false),
                        EnteredBy = c.String(),
                        MathCorrect = c.Int(nullable: false),
                        MathIncorrect = c.Int(nullable: false),
                        MathNet = c.Int(nullable: false),
                        ScienceCorrect = c.Int(nullable: false),
                        ScienceIncorrect = c.Int(nullable: false),
                        ScienceNet = c.Int(nullable: false),
                        TurkishCorrect = c.Int(nullable: false),
                        TurkishIncorrect = c.Int(nullable: false),
                        TurkishNet = c.Int(nullable: false),
                        HistoryCorrect = c.Int(nullable: false),
                        HistoryIncorrect = c.Int(nullable: false),
                        HistoryNet = c.Int(nullable: false),
                        ReligionCorrect = c.Int(nullable: false),
                        ReligionIncorrect = c.Int(nullable: false),
                        ReligionNet = c.Int(nullable: false),
                        EnglishCorrect = c.Int(nullable: false),
                        EnglishIncorrect = c.Int(nullable: false),
                        EnglishNet = c.Int(nullable: false),
                        StudentId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Students", t => t.StudentId, cascadeDelete: true)
                .Index(t => t.StudentId);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Email = c.String(),
                        PhoneNumber = c.String(),
                        SchoolName = c.String(),
                        Class = c.String(),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "UserId", "dbo.Users");
            DropForeignKey("dbo.Exams", "StudentId", "dbo.Students");
            DropForeignKey("dbo.Admins", "UserId", "dbo.Users");
            DropIndex("dbo.Students", new[] { "UserId" });
            DropIndex("dbo.Exams", new[] { "StudentId" });
            DropIndex("dbo.Admins", new[] { "UserId" });
            DropTable("dbo.Students");
            DropTable("dbo.Exams");
            DropTable("dbo.Users");
            DropTable("dbo.Admins");
        }
    }
}
