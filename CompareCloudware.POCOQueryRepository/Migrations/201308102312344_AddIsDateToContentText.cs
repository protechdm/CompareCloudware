namespace CompareCloudware.POCOQueryRepository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddIsDateToContentText : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ContentText", "IsDate", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ContentText", "IsDate");
        }
    }
}
