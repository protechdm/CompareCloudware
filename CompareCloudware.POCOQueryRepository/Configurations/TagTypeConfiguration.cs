using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using CompareCloudware.Domain.Models;

namespace CompareCloudware.POCOQueryRepository.Configurations
{
    public class TagTypeConfiguration : EntityTypeConfiguration<TagType>
    {
        public TagTypeConfiguration()
        {
            ToTable("TagTypes");
            Property(d => d.TagTypeName).IsRequired();
            Property(d => d.TagTypeName).HasMaxLength(105);
            //Property(d => d.TagTypeStatus).IsRequired();
            this.HasRequired(x => x.TagTypeStatus);
            Property(d => d.RowVersion).IsRowVersion();
        }
    }
}
