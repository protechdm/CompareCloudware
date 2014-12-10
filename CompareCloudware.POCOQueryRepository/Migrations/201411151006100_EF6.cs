namespace CompareCloudware.POCOQueryRepository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EF6 : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.CategoryFeatures", new[] { "Category_CategoryID" });
            DropIndex("dbo.CategoryFeatures", new[] { "Feature_FeatureID" });
            //DropPrimaryKey("dbo.CategoryFeatures");
            //DropPrimaryKey("dbo.FeatureCategories");
            RenameTable(name: "dbo.CategoryFeatures", newName: "FeatureCategories");
            AddPrimaryKey("dbo.FeatureCategories", new[] { "Feature_FeatureID", "Category_CategoryID" });
            CreateIndex("dbo.FeatureCategories", "Feature_FeatureID");
            CreateIndex("dbo.FeatureCategories", "Category_CategoryID");
        }
        
        public override void Down()
        {
            DropIndex("dbo.FeatureCategories", new[] { "Category_CategoryID" });
            DropIndex("dbo.FeatureCategories", new[] { "Feature_FeatureID" });
            //DropPrimaryKey("dbo.FeatureCategories");
            //AddPrimaryKey("dbo.FeatureCategories", new[] { "Category_CategoryID", "Feature_FeatureID" });
            RenameTable(name: "dbo.FeatureCategories", newName: "CategoryFeatures");
            CreateIndex("dbo.CategoryFeatures", "Feature_FeatureID");
            CreateIndex("dbo.CategoryFeatures", "Category_CategoryID");
        }
    }
}
