namespace CompareCloudware.POCOQueryRepository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddContentText_LineBreakBeforeAfter : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ContentText", "LineBreakBefore", c => c.Boolean());
            AddColumn("dbo.ContentText", "LineBreakAfter", c => c.Boolean());
        }
        
        public override void Down()
        {
            DropColumn("dbo.ContentText", "LineBreakAfter");
            DropColumn("dbo.ContentText", "LineBreakBefore");
        }
    }
}
