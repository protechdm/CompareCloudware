namespace CompareCloudware.POCOQueryRepository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_AdvertisingImageServer_IsServing : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AdvertisingImageServer", "IsServing", c => c.Boolean());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AdvertisingImageServer", "IsServing");
        }
    }
}
