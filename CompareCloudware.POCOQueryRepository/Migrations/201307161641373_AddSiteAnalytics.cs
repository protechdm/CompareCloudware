namespace CompareCloudware.POCOQueryRepository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSiteAnalytics : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SiteAnalytics",
                c => new
                    {
                        SiteAnalyticID = c.Int(nullable: false, identity: true),
                        SiteAnalyticDate = c.DateTime(nullable: false),
                        CloudApplicationID = c.Int(),
                        CategoryID = c.Int(),
                        PersonID = c.Int(),
                        SessionID = c.String(nullable: false, maxLength: 24),
                        FeatureID = c.Int(),
                        FeatureTypeID = c.Int(),
                        AddDate = c.DateTime(nullable: false),
                        LastUpdateDate = c.DateTime(),
                        RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                        SiteAnalyticType_SiteAnalyticTypeID = c.Int(),
                    })
                .PrimaryKey(t => t.SiteAnalyticID)
                .ForeignKey("dbo.SiteAnalyticTypes", t => t.SiteAnalyticType_SiteAnalyticTypeID)
                .Index(t => t.SiteAnalyticType_SiteAnalyticTypeID);
            
            CreateTable(
                "dbo.SiteAnalyticTypes",
                c => new
                    {
                        SiteAnalyticTypeID = c.Int(nullable: false, identity: true),
                        SiteAnalyticTypeName = c.String(nullable: false),
                        AddDate = c.DateTime(nullable: false),
                        LastUpdateDate = c.DateTime(),
                        RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    })
                .PrimaryKey(t => t.SiteAnalyticTypeID);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.SiteAnalytics", new[] { "SiteAnalyticType_SiteAnalyticTypeID" });
            DropForeignKey("dbo.SiteAnalytics", "SiteAnalyticType_SiteAnalyticTypeID", "dbo.SiteAnalyticTypes");
            DropTable("dbo.SiteAnalyticTypes");
            DropTable("dbo.SiteAnalytics");
        }
    }
}
