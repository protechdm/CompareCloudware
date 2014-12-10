namespace CompareCloudware.POCOQueryRepository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAdvertisingImageServerPhase2Categories : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AdvertisingImageServer", "NextMPUMarketingID", c => c.Int());
            AddColumn("dbo.AdvertisingImageServer", "NextMPUWebsiteID", c => c.Int());
            AddColumn("dbo.AdvertisingImageServer", "NextMPUCreativeID", c => c.Int());
            AddColumn("dbo.AdvertisingImageServer", "NextMPUBusinessIntelligenceReportingID", c => c.Int());
            AddColumn("dbo.AdvertisingImageServer", "NextMPUHostingID", c => c.Int());
            AddColumn("dbo.AdvertisingImageServer", "NextMPUHRID", c => c.Int());
            AddColumn("dbo.AdvertisingImageServer", "NextMPUPaymentsID", c => c.Int());
            AddColumn("dbo.AdvertisingImageServer", "NextMPUBusinessAndOperationsID", c => c.Int());
            AddColumn("dbo.AdvertisingImageServer", "NextMPUSalesID", c => c.Int());
            AddColumn("dbo.AdvertisingImageServer", "NextSkyscraperMarketingID", c => c.Int());
            AddColumn("dbo.AdvertisingImageServer", "NextSkyscraperWebsiteID", c => c.Int());
            AddColumn("dbo.AdvertisingImageServer", "NextSkyscraperCreativeID", c => c.Int());
            AddColumn("dbo.AdvertisingImageServer", "NextSkyscraperBusinessIntelligenceReportingID", c => c.Int());
            AddColumn("dbo.AdvertisingImageServer", "NextSkyscraperHostingID", c => c.Int());
            AddColumn("dbo.AdvertisingImageServer", "NextSkyscraperHRID", c => c.Int());
            AddColumn("dbo.AdvertisingImageServer", "NextSkyscraperPaymentsID", c => c.Int());
            AddColumn("dbo.AdvertisingImageServer", "NextSkyscraperBusinessAndOperationsID", c => c.Int());
            AddColumn("dbo.AdvertisingImageServer", "NextSkyscraperSalesID", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AdvertisingImageServer", "NextSkyscraperSalesID");
            DropColumn("dbo.AdvertisingImageServer", "NextSkyscraperBusinessAndOperationsID");
            DropColumn("dbo.AdvertisingImageServer", "NextSkyscraperPaymentsID");
            DropColumn("dbo.AdvertisingImageServer", "NextSkyscraperHRID");
            DropColumn("dbo.AdvertisingImageServer", "NextSkyscraperHostingID");
            DropColumn("dbo.AdvertisingImageServer", "NextSkyscraperBusinessIntelligenceReportingID");
            DropColumn("dbo.AdvertisingImageServer", "NextSkyscraperCreativeID");
            DropColumn("dbo.AdvertisingImageServer", "NextSkyscraperWebsiteID");
            DropColumn("dbo.AdvertisingImageServer", "NextSkyscraperMarketingID");
            DropColumn("dbo.AdvertisingImageServer", "NextMPUSalesID");
            DropColumn("dbo.AdvertisingImageServer", "NextMPUBusinessAndOperationsID");
            DropColumn("dbo.AdvertisingImageServer", "NextMPUPaymentsID");
            DropColumn("dbo.AdvertisingImageServer", "NextMPUHRID");
            DropColumn("dbo.AdvertisingImageServer", "NextMPUHostingID");
            DropColumn("dbo.AdvertisingImageServer", "NextMPUBusinessIntelligenceReportingID");
            DropColumn("dbo.AdvertisingImageServer", "NextMPUCreativeID");
            DropColumn("dbo.AdvertisingImageServer", "NextMPUWebsiteID");
            DropColumn("dbo.AdvertisingImageServer", "NextMPUMarketingID");
        }
    }
}
