namespace CompareCloudware.POCOQueryRepository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSEO : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ContentPages",
                c => new
                    {
                        ContentPageID = c.Int(nullable: false, identity: true),
                        Slug = c.String(),
                        Title = c.String(),
                        Author = c.String(),
                        GooglePlusId = c.String(),
                        SortOrder = c.Single(nullable: false),
                        Keywords = c.String(),
                        Markdown = c.String(),
                        Modified = c.DateTime(nullable: false),
                        NoSearch = c.Boolean(nullable: false),
                        Frequency = c.Short(nullable: false),
                        Priority = c.Double(),
                        MetaTitle = c.String(),
                        MetaKeywords = c.String(),
                        MetaDescription = c.String(),
                        Route = c.String(),
                        RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    })
                .PrimaryKey(t => t.ContentPageID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ContentPages");
        }
    }
}
