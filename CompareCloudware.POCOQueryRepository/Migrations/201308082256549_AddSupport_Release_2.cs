namespace CompareCloudware.POCOQueryRepository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSupport_Release_2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.SupportCategories", "SupportAreaQA_SupportAreaQAID", "dbo.SupportAreaQAs");
            DropIndex("dbo.SupportCategories", new[] { "SupportAreaQA_SupportAreaQAID" });
            CreateTable(
                "dbo.SupportAreaQACategories",
                c => new
                    {
                        SupportAreaQACategoryID = c.Int(nullable: false, identity: true),
                        RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                        SupportAreaQA_SupportAreaQAID = c.Int(nullable: false),
                        SupportCategory_SupportCategoryID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SupportAreaQACategoryID)
                .ForeignKey("dbo.SupportAreaQAs", t => t.SupportAreaQA_SupportAreaQAID)
                .ForeignKey("dbo.SupportCategories", t => t.SupportCategory_SupportCategoryID)
                .Index(t => t.SupportAreaQA_SupportAreaQAID)
                .Index(t => t.SupportCategory_SupportCategoryID);
            
            DropColumn("dbo.SupportCategories", "SupportAreaQA_SupportAreaQAID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.SupportCategories", "SupportAreaQA_SupportAreaQAID", c => c.Int());
            DropIndex("dbo.SupportAreaQACategories", new[] { "SupportCategory_SupportCategoryID" });
            DropIndex("dbo.SupportAreaQACategories", new[] { "SupportAreaQA_SupportAreaQAID" });
            DropForeignKey("dbo.SupportAreaQACategories", "SupportCategory_SupportCategoryID", "dbo.SupportCategories");
            DropForeignKey("dbo.SupportAreaQACategories", "SupportAreaQA_SupportAreaQAID", "dbo.SupportAreaQAs");
            DropTable("dbo.SupportAreaQACategories");
            CreateIndex("dbo.SupportCategories", "SupportAreaQA_SupportAreaQAID");
            AddForeignKey("dbo.SupportCategories", "SupportAreaQA_SupportAreaQAID", "dbo.SupportAreaQAs", "SupportAreaQAID");
        }
    }
}
