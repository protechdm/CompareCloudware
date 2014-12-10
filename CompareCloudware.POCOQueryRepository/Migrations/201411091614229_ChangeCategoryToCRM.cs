namespace CompareCloudware.POCOQueryRepository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeCategoryToCRM : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AdvertisingImageServer", "NextMPUCRMID", c => c.Int());
            AddColumn("dbo.AdvertisingImageServer", "NextSkyscraperCRMID", c => c.Int());
            DropColumn("dbo.AdvertisingImageServer", "NextMPUCustomerManagementID");
            DropColumn("dbo.AdvertisingImageServer", "NextSkyscraperCustomerManagementID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AdvertisingImageServer", "NextSkyscraperCustomerManagementID", c => c.Int());
            AddColumn("dbo.AdvertisingImageServer", "NextMPUCustomerManagementID", c => c.Int());
            DropColumn("dbo.AdvertisingImageServer", "NextSkyscraperCRMID");
            DropColumn("dbo.AdvertisingImageServer", "NextMPUCRMID");
        }
    }
}
