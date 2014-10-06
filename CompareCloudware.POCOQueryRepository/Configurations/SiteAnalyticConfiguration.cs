using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using CompareCloudware.Domain.Models;

namespace CompareCloudware.POCOQueryRepository.Configurations
{
    public class SiteAnalyticConfiguration : EntityTypeConfiguration<SiteAnalytic>
    {
        public SiteAnalyticConfiguration()
        {
            ToTable("SiteAnalytics");
            //Property(d => d.SiteAnalyticType).IsRequired();
            Property(d => d.SessionID).IsRequired();
            Property(d => d.SessionID).HasMaxLength(24);
            //Property(d => d.RowVersion).IsRowVersion();
        }
    }
}
