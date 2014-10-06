namespace CompareCloudware.POCOQueryRepository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddServicedFlagsToSupportAreaQAs : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SupportAreaQAs", "EMail", c => c.Boolean());
            AddColumn("dbo.SupportAreaQAs", "Servicing", c => c.Boolean());
            AddColumn("dbo.SupportAreaQAs", "Serviced", c => c.Boolean());
            AddColumn("dbo.SupportAreaQAs", "ServicedDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.SupportAreaQAs", "ServicedDate");
            DropColumn("dbo.SupportAreaQAs", "Serviced");
            DropColumn("dbo.SupportAreaQAs", "Servicing");
            DropColumn("dbo.SupportAreaQAs", "EMail");
        }
    }
}
