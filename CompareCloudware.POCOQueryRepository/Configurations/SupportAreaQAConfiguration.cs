using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using CompareCloudware.Domain.Models;

namespace CompareCloudware.POCOQueryRepository.Configurations
{
    public class SupportAreaQAConfiguration : EntityTypeConfiguration<SupportAreaQA>
    {
        public SupportAreaQAConfiguration()
        {
            ToTable("SupportAreaQAs");
            Property(d => d.Question).IsRequired();
            Property(d => d.QuestionDate).IsRequired();
            this.HasRequired(d => d.SupportArea);
            //Property(d => d.BrowserName).HasMaxLength(105);
            //Property(d => d.BrowserStatus).IsRequired();
            this.HasRequired(x => x.SupportAreaQAStatus);
            Property(d => d.RowVersion).IsRowVersion();
        }
    }
}
