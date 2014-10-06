using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using CompareCloudware.Domain.Models;

namespace CompareCloudware.POCOQueryRepository.Configurations
{
    public class CloudApplicationDocumentFormatConfiguration : EntityTypeConfiguration<CloudApplicationDocumentFormat>
    {
        public CloudApplicationDocumentFormatConfiguration()
        {
            ToTable("CloudApplicationDocumentFormats");
            Property(d => d.CloudApplicationDocumentFormatShortName).IsRequired();
            Property(d => d.CloudApplicationDocumentFormatShortName).HasMaxLength(10);
            //Property(d => d.CloudApplicationDocumentFormatStatus).IsRequired();
            this.HasRequired(x => x.CloudApplicationDocumentFormatStatus);
            Property(d => d.RowVersion).IsRowVersion();
        }
    }
}
