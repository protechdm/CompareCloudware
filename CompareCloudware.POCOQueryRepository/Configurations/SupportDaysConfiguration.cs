using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using CompareCloudware.Domain.Models;

namespace CompareCloudware.POCOQueryRepository.Configurations
{
    public class SupportDaysConfiguration : EntityTypeConfiguration<SupportDays>
    {
        public SupportDaysConfiguration()
        {
            ToTable("SupportDays");
            Property(d => d.SupportDaysName).IsRequired();
            Property(d => d.SupportDaysName).HasMaxLength(105);
            //Property(d => d.SupportDaysStatus).IsRequired();
            this.HasRequired(x => x.SupportDaysStatus);
            Property(d => d.RowVersion).IsRowVersion();
        }
    }
}
