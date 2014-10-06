namespace CompareCloudware.POCOQueryRepository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SiteAnalytic_RemoveDateStampsAndRowVersion : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.SiteAnalytics", "AddDate");
            DropColumn("dbo.SiteAnalytics", "LastUpdateDate");
            DropColumn("dbo.SiteAnalytics", "RowVersion");
        }
        
        public override void Down()
        {
            AddColumn("dbo.SiteAnalytics", "RowVersion", c => c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"));
            AddColumn("dbo.SiteAnalytics", "LastUpdateDate", c => c.DateTime());
            AddColumn("dbo.SiteAnalytics", "AddDate", c => c.DateTime(nullable: false));
        }
    }
}
