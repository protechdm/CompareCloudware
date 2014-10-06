namespace CompareCloudware.POCOQueryRepository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SiteAnalyticType_AddScoreValue : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SiteAnalyticTypes", "ScoreValue", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.SiteAnalyticTypes", "ScoreValue");
        }
    }
}
