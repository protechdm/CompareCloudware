namespace CompareCloudware.POCOQueryRepository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAdvertisingImageServer : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AdvertisingImageServer",
                c => new
                    {
                        AdvertisingImageServerID = c.Int(nullable: false, identity: true),
                        NextMPUID = c.Int(),
                        NextSkyscraperID = c.Int(),
                        NextCarouselHomeID = c.Int(),
                        NextMPUCustomerManagementID = c.Int(),
                        NextMPUEMailID = c.Int(),
                        NextMPUFinancialID = c.Int(),
                        NextMPUOfficeID = c.Int(),
                        NextMPUProjectManagementID = c.Int(),
                        NextMPUSecurityID = c.Int(),
                        NextMPUStorageAndBackupID = c.Int(),
                        NextMPUVoiceID = c.Int(),
                        NextMPUWebConferencingID = c.Int(),
                        NextSkyscraperCustomerManagementID = c.Int(),
                        NextSkyscraperEMailID = c.Int(),
                        NextSkyscraperFinancialID = c.Int(),
                        NextSkyscraperOfficeID = c.Int(),
                        NextSkyscraperProjectManagementID = c.Int(),
                        NextSkyscraperSecurityID = c.Int(),
                        NextSkyscraperStorageAndBackupID = c.Int(),
                        NextSkyscraperVoiceID = c.Int(),
                        NextSkyscraperWebConferencingID = c.Int(),
                        RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    })
                .PrimaryKey(t => t.AdvertisingImageServerID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.AdvertisingImageServer");
        }
    }
}
