using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using CompareCloudware.Domain.Models;

namespace CompareCloudware.POCOQueryRepository.Configurations
{
    public class IndustryConfiguration : EntityTypeConfiguration<Industry>
    {
        public IndustryConfiguration()
        {
            ToTable("Industries");
            Property(d => d.Code).IsRequired();
            Property(d => d.Description).IsRequired();
            //Property(d => d.IndustryStatus).IsRequired();
            this.HasRequired(x => x.IndustryStatus);
        }
    }
}
