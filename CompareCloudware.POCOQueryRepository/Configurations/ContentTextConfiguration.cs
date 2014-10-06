using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using CompareCloudware.Domain.Models;

namespace CompareCloudware.POCOQueryRepository.Configurations
{
    public class ContentTextConfiguration : EntityTypeConfiguration<ContentText>
    {
        public ContentTextConfiguration()
        {
            ToTable("ContentText");
            Property(d => d.ContentTextData).IsRequired();
            Property(d => d.NiceName).HasMaxLength(105);
            //Property(d => d.ContentTextStatus).IsRequired();
            this.HasRequired(x => x.ContentTextStatus);
            Property(d => d.RowVersion).IsRowVersion();
        }
    }
}
