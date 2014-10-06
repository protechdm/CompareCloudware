namespace CompareCloudware.POCOQueryRepository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeIsDateToNullableInContentText : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ContentText", "IsDate", c => c.Boolean());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ContentText", "IsDate", c => c.Boolean(nullable: false));
        }
    }
}
