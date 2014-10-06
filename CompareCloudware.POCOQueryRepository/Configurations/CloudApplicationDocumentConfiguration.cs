using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using CompareCloudware.Domain.Models;

namespace CompareCloudware.POCOQueryRepository.Configurations
{
    public class CloudApplicationDocumentConfiguration : EntityTypeConfiguration<CloudApplicationDocument>
    {
        public CloudApplicationDocumentConfiguration()
        {
            ToTable("CloudApplicationDocuments");
            Property(d => d.CloudApplicationDocumentTitle).IsRequired();
            Property(d => d.CloudApplicationDocumentTitle).HasMaxLength(105);
            //Property(d => d.CloudApplicationDocumentStatus).IsRequired();
            this.HasRequired(x => x.CloudApplicationDocumentStatus);
            Property(d => d.RowVersion).IsRowVersion();
        }
    }
}
