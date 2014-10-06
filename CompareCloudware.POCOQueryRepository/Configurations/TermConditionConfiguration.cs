using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using CompareCloudware.Domain.Models;

namespace CompareCloudware.POCOQueryRepository.Configurations
{
    public class TermConditionConfiguration : EntityTypeConfiguration<TermCondition>
    {
        public TermConditionConfiguration()
        {
            ToTable("TermsConditions");
            //Property(d => d.ContentTextData).IsRequired();
            //Property(d => d.NiceName).HasMaxLength(105);
            //Property(d => d.TermConditionStatus).IsRequired();
            this.HasRequired(x => x.TermConditionStatus);
            Property(d => d.RowVersion).IsRowVersion();
        }
    }
}
