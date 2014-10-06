using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using CompareCloudware.Domain.Models;

namespace CompareCloudware.POCOQueryRepository.Configurations
{
    public class SiteAnalyticTypeConfiguration : EntityTypeConfiguration<SiteAnalyticType>
    {
        public SiteAnalyticTypeConfiguration()
        {
            ToTable("SiteAnalyticTypes");
            Property(d => d.SiteAnalyticTypeName).IsRequired();
            Property(d => d.RowVersion).IsRowVersion();
        }
    }
}
