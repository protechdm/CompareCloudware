using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using CompareCloudware.Domain.Models;

namespace CompareCloudware.POCOQueryRepository.Configurations
{
    public class CloudApplicationDocumentImageConfiguration : EntityTypeConfiguration<CloudApplicationDocumentImage>
    {
        public CloudApplicationDocumentImageConfiguration()
        {
            ToTable("CloudApplicationDocumentImages");
            Property(d => d.CloudApplicationDocumentBytes).IsRequired();
            //Property(d => d.ThumbnailDocumentTitle).HasMaxLength(105);
            //Property(d => d.CloudApplicationDocumentImageStatus).IsRequired();
            this.HasRequired(x => x.CloudApplicationDocumentImageStatus);
            Property(d => d.RowVersion).IsRowVersion();
        }
    }
}
