using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using CompareCloudware.Domain.Models;

namespace CompareCloudware.POCOQueryRepository.Configurations
{
    public class OperatingSystemConfiguration : EntityTypeConfiguration<CompareCloudware.Domain.Models.OperatingSystem>
    {
        public OperatingSystemConfiguration()
        {
            ToTable("OperatingSystems");
            Property(d => d.OperatingSystemName).IsRequired();
            Property(d => d.OperatingSystemName).HasMaxLength(105);
            //Property(d => d.OperatingSystemStatus).IsRequired();
            this.HasRequired(x => x.OperatingSystemStatus);
            Property(d => d.RowVersion).IsRowVersion();
        }
    }
}
