using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using CompareCloudware.Domain.Models;

namespace CompareCloudware.POCOQueryRepository.Configurations
{
    public class CloudApplicationApplicationConfiguration : EntityTypeConfiguration<CloudApplicationApplication>
    {
        public CloudApplicationApplicationConfiguration()
        {
            ToTable("CloudApplicationApplications");
            //Property(d => d.FeatureName).IsRequired();
            //Property(d => d.FeatureName).HasMaxLength(105);
            HasOptional(p => p.Feature);
            //Property(d => d.CloudApplicationApplicationStatus).IsRequired();
            this.HasRequired(x => x.CloudApplicationApplicationStatus);
            Property(d => d.RowVersion).IsRowVersion();
        }
    }
}
