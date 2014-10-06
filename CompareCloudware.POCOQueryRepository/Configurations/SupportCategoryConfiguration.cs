using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using CompareCloudware.Domain.Models;

namespace CompareCloudware.POCOQueryRepository.Configurations
{
    public class SupportCategoryConfiguration : EntityTypeConfiguration<SupportCategory>
    {
        public SupportCategoryConfiguration()
        {
            ToTable("SupportCategories");
            Property(d => d.SupportCategoryName).IsRequired();
            //Property(d => d.BrowserName).HasMaxLength(105);
            //Property(d => d.BrowserStatus).IsRequired();
            this.HasRequired(x => x.SupportCategoryStatus);
            Property(d => d.RowVersion).IsRowVersion();
        }
    }
}
