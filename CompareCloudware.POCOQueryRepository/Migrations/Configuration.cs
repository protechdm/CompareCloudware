// enable-migrations
// add-migration base
// add-migration AddSiteAnalytic
// add-migration AddSiteAnalyticType
// Update-Database -ConnectionStringName "CompareCloudware.POCOQueryRepository.CompareCloudwareContext"
// Update-Database –TargetMigration: Add_AdvertisingImage_CloudApplicationID
// Update-Database –TargetMigration: AddURLTagsToCloudApplication
//AddAdvertisingImageServerPhase2Categories
namespace CompareCloudware.POCOQueryRepository.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CompareCloudware.POCOQueryRepository.CompareCloudwareContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CompareCloudware.POCOQueryRepository.CompareCloudwareContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
