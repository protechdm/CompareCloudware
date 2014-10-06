using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using CompareCloudware.Domain.Models;

namespace CompareCloudware.POCOQueryRepository.Configurations
{
    public class TagConfiguration : EntityTypeConfiguration<Tag>
    {
        public TagConfiguration()
        {
            ToTable("Tags");
            Property(d => d.TagName).IsRequired();
            Property(d => d.TagName).HasMaxLength(105);
            //Property(d => d.TagStatus).IsRequired();
            this.HasRequired(x => x.TagStatus);
            Property(d => d.RowVersion).IsRowVersion();

            //this.HasOptional(x => x.CloudApplication);
        }
    }
}
