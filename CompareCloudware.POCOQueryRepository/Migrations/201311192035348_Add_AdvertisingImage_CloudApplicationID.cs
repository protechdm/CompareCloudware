namespace CompareCloudware.POCOQueryRepository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_AdvertisingImage_CloudApplicationID : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AdvertisingImages", "CloudApplication_CloudApplicationID", c => c.Int());
            AddForeignKey("dbo.AdvertisingImages", "CloudApplication_CloudApplicationID", "dbo.CloudApplications", "CloudApplicationID");
            CreateIndex("dbo.AdvertisingImages", "CloudApplication_CloudApplicationID");
        }
        
        public override void Down()
        {
            DropIndex("dbo.AdvertisingImages", new[] { "CloudApplication_CloudApplicationID" });
            DropForeignKey("dbo.AdvertisingImages", "CloudApplication_CloudApplicationID", "dbo.CloudApplications");
            DropColumn("dbo.AdvertisingImages", "CloudApplication_CloudApplicationID");
        }
    }
}
