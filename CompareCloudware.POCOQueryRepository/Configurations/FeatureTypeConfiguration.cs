using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using CompareCloudware.Domain.Models;

namespace CompareCloudware.POCOQueryRepository.Configurations
{
    public class FeatureTypeConfiguration : EntityTypeConfiguration<FeatureType>
    {
        public FeatureTypeConfiguration()
        {
            ToTable("FeatureTypes");
            Property(d => d.FeatureTypeName).IsRequired();
            Property(d => d.FeatureTypeName).HasMaxLength(105);
            //Property(d => d.FeatureTypeStatus).IsRequired();
            this.HasRequired(x => x.FeatureTypeStatus);
            Property(d => d.RowVersion).IsRowVersion();
            
        }
    }
}
