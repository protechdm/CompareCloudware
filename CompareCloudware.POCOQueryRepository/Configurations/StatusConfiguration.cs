using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using CompareCloudware.Domain.Models;

namespace CompareCloudware.POCOQueryRepository.Configurations
{
    public class StatusConfiguration : EntityTypeConfiguration<Status>
    {
        public StatusConfiguration()
        {
            ToTable("Statuses");
            Property(d => d.StatusName).IsRequired();
            Property(d => d.StatusName).HasMaxLength(105);
            Property(d => d.RowVersion).IsRowVersion();
        }
    }
}
