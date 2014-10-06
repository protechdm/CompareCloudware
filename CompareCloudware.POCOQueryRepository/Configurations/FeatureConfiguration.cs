using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using CompareCloudware.Domain.Models;

namespace CompareCloudware.POCOQueryRepository.Configurations
{
    public class FeatureConfiguration : EntityTypeConfiguration<Feature>
    {
        public FeatureConfiguration()
        {
            ToTable("Features");
            Property(d => d.FeatureName).IsRequired();
            Property(d => d.FeatureName).HasMaxLength(105);
            //Property(d => d.FeatureStatus).IsRequired();
            //this.HasRequired(x => x.FeatureStatus).WithRequiredDependent().WillCascadeOnDelete(false);
            this.HasRequired(x => x.FeatureStatus);
            Property(d => d.RowVersion).IsRowVersion();
            
        }
    }
}
