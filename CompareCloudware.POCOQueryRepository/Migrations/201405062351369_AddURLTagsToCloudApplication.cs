namespace CompareCloudware.POCOQueryRepository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddURLTagsToCloudApplication : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CloudApplications", "CloudApplicationCategoryTag_TagID", c => c.Int());
            AddColumn("dbo.CloudApplications", "CloudApplicationShopTag_TagID", c => c.Int());
            AddForeignKey("dbo.CloudApplications", "CloudApplicationCategoryTag_TagID", "dbo.Tags", "TagID");
            AddForeignKey("dbo.CloudApplications", "CloudApplicationShopTag_TagID", "dbo.Tags", "TagID");
            CreateIndex("dbo.CloudApplications", "CloudApplicationCategoryTag_TagID");
            CreateIndex("dbo.CloudApplications", "CloudApplicationShopTag_TagID");
        }
        
        public override void Down()
        {
            DropIndex("dbo.CloudApplications", new[] { "CloudApplicationShopTag_TagID" });
            DropIndex("dbo.CloudApplications", new[] { "CloudApplicationCategoryTag_TagID" });
            DropForeignKey("dbo.CloudApplications", "CloudApplicationShopTag_TagID", "dbo.Tags");
            DropForeignKey("dbo.CloudApplications", "CloudApplicationCategoryTag_TagID", "dbo.Tags");
            DropColumn("dbo.CloudApplications", "CloudApplicationShopTag_TagID");
            DropColumn("dbo.CloudApplications", "CloudApplicationCategoryTag_TagID");
        }
    }
}
