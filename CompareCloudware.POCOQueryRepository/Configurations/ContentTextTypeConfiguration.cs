using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using CompareCloudware.Domain.Models;

namespace CompareCloudware.POCOQueryRepository.Configurations
{
    public class ContentTextTypeConfiguration : EntityTypeConfiguration<ContentTextType>
    {
        public ContentTextTypeConfiguration()
        {
            ToTable("ContentTextTypes");
            Property(d => d.ContentTextTypeName).IsRequired();
            Property(d => d.ContentTextTypeName).HasMaxLength(105);
            //Property(d => d.ContentTextTypeStatus).IsRequired();
            this.HasRequired(x => x.ContentTextTypeStatus);
            Property(d => d.RowVersion).IsRowVersion();
        }
    }
}
