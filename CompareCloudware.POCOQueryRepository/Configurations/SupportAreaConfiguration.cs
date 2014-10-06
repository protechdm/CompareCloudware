using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using CompareCloudware.Domain.Models;

namespace CompareCloudware.POCOQueryRepository.Configurations
{
    public class SupportAreaConfiguration : EntityTypeConfiguration<SupportArea>
    {
        public SupportAreaConfiguration()
        {
            ToTable("SupportAreas");
            Property(d => d.SupportAreaName).IsRequired();
            //Property(d => d.BrowserName).HasMaxLength(105);
            //Property(d => d.BrowserStatus).IsRequired();
            this.HasRequired(x => x.SupportAreaStatus);
            Property(d => d.RowVersion).IsRowVersion();
        }
    }
}
