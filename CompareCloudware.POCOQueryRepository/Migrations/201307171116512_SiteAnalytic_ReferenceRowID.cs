namespace CompareCloudware.POCOQueryRepository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SiteAnalytic_ReferenceRowID : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SiteAnalytics", "ReferenceDataRowID", c => c.Int());
            DropColumn("dbo.SiteAnalytics", "FeatureID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.SiteAnalytics", "FeatureID", c => c.Int());
            DropColumn("dbo.SiteAnalytics", "ReferenceDataRowID");
        }
    }
}
