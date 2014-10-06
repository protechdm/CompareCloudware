using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using CompareCloudware.Domain.Models;

namespace CompareCloudware.POCOQueryRepository.Configurations
{
    public class CloudApplicationVideoConfiguration : EntityTypeConfiguration<CloudApplicationVideo>
    {
        public CloudApplicationVideoConfiguration()
        {
            ToTable("CloudApplicationVideos");
            //Property(d => d.CloudApplicationVideoFileFormat).IsRequired();
            Property(d => d.CloudApplicationVideoFileName).HasMaxLength(105);
            Property(d => d.CloudApplicationVideoURL).HasMaxLength(1000);
            //Property(d => d.CloudApplicationVideoStatus).IsRequired();
            this.HasRequired(x => x.CloudApplicationVideoStatus);
            Property(d => d.RowVersion).IsRowVersion();
        }
    }
}
