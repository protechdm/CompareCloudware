namespace CompareCloudware.POCOQueryRepository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSupport : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SupportCategories",
                c => new
                    {
                        SupportCategoryID = c.Int(nullable: false, identity: true),
                        SupportCategoryName = c.String(nullable: false),
                        RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                        SupportCategoryStatus_StatusID = c.Int(nullable: false),
                        SupportAreaQA_SupportAreaQAID = c.Int(),
                    })
                .PrimaryKey(t => t.SupportCategoryID)
                .ForeignKey("dbo.Statuses", t => t.SupportCategoryStatus_StatusID)
                .ForeignKey("dbo.SupportAreaQAs", t => t.SupportAreaQA_SupportAreaQAID)
                .Index(t => t.SupportCategoryStatus_StatusID)
                .Index(t => t.SupportAreaQA_SupportAreaQAID);
            
            CreateTable(
                "dbo.SupportAreas",
                c => new
                    {
                        SupportAreaID = c.Int(nullable: false, identity: true),
                        SupportAreaName = c.String(nullable: false),
                        RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                        SupportAreaStatus_StatusID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SupportAreaID)
                .ForeignKey("dbo.Statuses", t => t.SupportAreaStatus_StatusID)
                .Index(t => t.SupportAreaStatus_StatusID);
            
            CreateTable(
                "dbo.QAStatuses",
                c => new
                    {
                        QAStatusID = c.Int(nullable: false, identity: true),
                        QAStatusName = c.String(nullable: false),
                        RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                        QuestionStatus_StatusID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.QAStatusID)
                .ForeignKey("dbo.Statuses", t => t.QuestionStatus_StatusID)
                .Index(t => t.QuestionStatus_StatusID);
            
            CreateTable(
                "dbo.SupportAreaQAs",
                c => new
                    {
                        SupportAreaQAID = c.Int(nullable: false, identity: true),
                        SupportCategoryOther = c.String(),
                        SupportAreaCloudApplicationID = c.Int(),
                        SupportAreaCloudApplicationServiceName = c.String(),
                        Question = c.String(nullable: false),
                        QuestionDate = c.DateTime(nullable: false),
                        Answer = c.String(),
                        AnswerDate = c.DateTime(nullable: false),
                        RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                        SupportArea_SupportAreaID = c.Int(nullable: false),
                        SubmittedPerson_PersonID = c.Int(),
                        AssignedPerson_PersonID = c.Int(),
                        QAStatus_QAStatusID = c.Int(),
                        SupportAreaQAStatus_StatusID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SupportAreaQAID)
                .ForeignKey("dbo.SupportAreas", t => t.SupportArea_SupportAreaID)
                .ForeignKey("dbo.Persons", t => t.SubmittedPerson_PersonID)
                .ForeignKey("dbo.Persons", t => t.AssignedPerson_PersonID)
                .ForeignKey("dbo.QAStatuses", t => t.QAStatus_QAStatusID)
                .ForeignKey("dbo.Statuses", t => t.SupportAreaQAStatus_StatusID)
                .Index(t => t.SupportArea_SupportAreaID)
                .Index(t => t.SubmittedPerson_PersonID)
                .Index(t => t.AssignedPerson_PersonID)
                .Index(t => t.QAStatus_QAStatusID)
                .Index(t => t.SupportAreaQAStatus_StatusID);
            
            AddColumn("dbo.Persons", "IsInUserGroup", c => c.Boolean());
            AddColumn("dbo.CloudApplicationRequests", "CloudApplicationServiceName", c => c.String());
        }
        
        public override void Down()
        {
            DropIndex("dbo.SupportAreaQAs", new[] { "SupportAreaQAStatus_StatusID" });
            DropIndex("dbo.SupportAreaQAs", new[] { "QAStatus_QAStatusID" });
            DropIndex("dbo.SupportAreaQAs", new[] { "AssignedPerson_PersonID" });
            DropIndex("dbo.SupportAreaQAs", new[] { "SubmittedPerson_PersonID" });
            DropIndex("dbo.SupportAreaQAs", new[] { "SupportArea_SupportAreaID" });
            DropIndex("dbo.QAStatuses", new[] { "QuestionStatus_StatusID" });
            DropIndex("dbo.SupportAreas", new[] { "SupportAreaStatus_StatusID" });
            DropIndex("dbo.SupportCategories", new[] { "SupportAreaQA_SupportAreaQAID" });
            DropIndex("dbo.SupportCategories", new[] { "SupportCategoryStatus_StatusID" });
            DropForeignKey("dbo.SupportAreaQAs", "SupportAreaQAStatus_StatusID", "dbo.Statuses");
            DropForeignKey("dbo.SupportAreaQAs", "QAStatus_QAStatusID", "dbo.QAStatuses");
            DropForeignKey("dbo.SupportAreaQAs", "AssignedPerson_PersonID", "dbo.Persons");
            DropForeignKey("dbo.SupportAreaQAs", "SubmittedPerson_PersonID", "dbo.Persons");
            DropForeignKey("dbo.SupportAreaQAs", "SupportArea_SupportAreaID", "dbo.SupportAreas");
            DropForeignKey("dbo.QAStatuses", "QuestionStatus_StatusID", "dbo.Statuses");
            DropForeignKey("dbo.SupportAreas", "SupportAreaStatus_StatusID", "dbo.Statuses");
            DropForeignKey("dbo.SupportCategories", "SupportAreaQA_SupportAreaQAID", "dbo.SupportAreaQAs");
            DropForeignKey("dbo.SupportCategories", "SupportCategoryStatus_StatusID", "dbo.Statuses");
            DropColumn("dbo.CloudApplicationRequests", "CloudApplicationServiceName");
            DropColumn("dbo.Persons", "IsInUserGroup");
            DropTable("dbo.SupportAreaQAs");
            DropTable("dbo.QAStatuses");
            DropTable("dbo.SupportAreas");
            DropTable("dbo.SupportCategories");
        }
    }
}
