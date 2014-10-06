using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using CompareCloudware.Domain.Models;

namespace CompareCloudware.POCOQueryRepository.Configurations
{
    public class TimeZoneConfiguration : EntityTypeConfiguration<CompareCloudware.Domain.Models.TimeZone>
    {
        public TimeZoneConfiguration()
        {
            ToTable("TimeZones");
            Property(d => d.TimeZoneName).IsRequired();
            Property(d => d.TimeZoneName).HasMaxLength(10);
            //Property(d => d.TimeZoneStatus).IsRequired();
            this.HasRequired(x => x.TimeZoneStatus);
            Property(d => d.RowVersion).IsRowVersion();
        }
    }
}
