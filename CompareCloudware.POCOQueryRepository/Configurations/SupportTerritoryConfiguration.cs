using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using CompareCloudware.Domain.Models;

namespace CompareCloudware.POCOQueryRepository.Configurations
{
    public class SupportTerritoryConfiguration : EntityTypeConfiguration<SupportTerritory>
    {
        public SupportTerritoryConfiguration()
        {
            ToTable("SupportTerritories");
            Property(d => d.SupportTerritoryName).IsRequired();
            Property(d => d.SupportTerritoryName).HasMaxLength(105);
            //Property(d => d.SupportTerritoryStatus).IsRequired();
            this.HasRequired(x => x.SupportTerritoryStatus);
            Property(d => d.RowVersion).IsRowVersion();
        }
    }
}
