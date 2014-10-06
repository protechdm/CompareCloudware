namespace CompareCloudware.POCOQueryRepository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddServicingFlagToCloudApplicationRequests : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CloudApplicationRequests", "Servicing", c => c.Boolean());
        }
        
        public override void Down()
        {
            DropColumn("dbo.CloudApplicationRequests", "Servicing");
        }
    }
}
