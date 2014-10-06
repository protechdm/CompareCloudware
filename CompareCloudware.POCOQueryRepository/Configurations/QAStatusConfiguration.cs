using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using CompareCloudware.Domain.Models;

namespace CompareCloudware.POCOQueryRepository.Configurations
{
    public class QAStatusConfiguration : EntityTypeConfiguration<QAStatus>
    {
        public QAStatusConfiguration()
        {
            ToTable("QAStatuses");
            Property(d => d.QAStatusName).IsRequired();
            //Property(d => d.BrowserName).HasMaxLength(105);
            //Property(d => d.BrowserStatus).IsRequired();
            this.HasRequired(x => x.QuestionStatus);
            Property(d => d.RowVersion).IsRowVersion();
        }
    }
}
