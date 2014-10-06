namespace CompareCloudware.POCOQueryRepository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSupport_Release_3 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.SupportAreaQAs", "AnswerDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.SupportAreaQAs", "AnswerDate", c => c.DateTime(nullable: false));
        }
    }
}
