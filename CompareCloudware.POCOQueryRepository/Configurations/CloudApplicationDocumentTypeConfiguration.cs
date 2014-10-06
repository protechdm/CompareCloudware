using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using CompareCloudware.Domain.Models;

namespace CompareCloudware.POCOQueryRepository.Configurations
{
    public class CloudApplicationDocumentTypeConfiguration : EntityTypeConfiguration<CloudApplicationDocumentType>
    {
        public CloudApplicationDocumentTypeConfiguration()
        {
            ToTable("CloudApplicationDocumentTypes");
            Property(d => d.CloudApplicationDocumentTypeName).IsRequired();
            Property(d => d.CloudApplicationDocumentTypeName).HasMaxLength(105);
            //Property(d => d.CloudApplicationDocumentTypeStatus).IsRequired();
            this.HasRequired(x => x.CloudApplicationDocumentTypeStatus);
            Property(d => d.RowVersion).IsRowVersion();
        }
    }
}
