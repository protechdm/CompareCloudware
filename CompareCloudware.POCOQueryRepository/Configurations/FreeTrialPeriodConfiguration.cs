using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using CompareCloudware.Domain.Models;

namespace CompareCloudware.POCOQueryRepository.Configurations
{
    public class FreeTrialPeriodConfiguration : EntityTypeConfiguration<FreeTrialPeriod>
    {
        public FreeTrialPeriodConfiguration()
        {
            ToTable("FreeTrialPeriods");
            Property(d => d.FreeTrialPeriodName).IsRequired();
            Property(d => d.FreeTrialPeriodName).HasMaxLength(105);
            //Property(d => d.FreeTrialPeriodStatus).IsRequired();
            this.HasRequired(x => x.FreeTrialPeriodStatus);
            Property(d => d.RowVersion).IsRowVersion();
        }
    }
}
