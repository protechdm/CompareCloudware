using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using CompareCloudware.Domain.Models;

namespace CompareCloudware.POCOQueryRepository.Configurations
{
    public class SupportAreaQACategoryConfiguration : EntityTypeConfiguration<SupportAreaQACategory>
    {
        public SupportAreaQACategoryConfiguration()
        {
            ToTable("SupportAreaQACategories");
            this.HasRequired(x => x.SupportAreaQA);
            this.HasRequired(x => x.SupportCategory);
            Property(d => d.RowVersion).IsRowVersion();
        }
    }
}
