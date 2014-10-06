using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using CompareCloudware.Domain.Models;

namespace CompareCloudware.POCOQueryRepository.Configurations
{
    public class AdvertisingImageTypeConfiguration : EntityTypeConfiguration<AdvertisingImageType>
    {
        public AdvertisingImageTypeConfiguration()
        {
            ToTable("AdvertisingImageTypes");
            Property(d => d.AdvertisingImageTypeName).IsRequired();
            Property(d => d.AdvertisingImageTypeName).HasMaxLength(105);
            //Property(d => d.AdvertisingImageTypeStatus).IsRequired();
            this.HasRequired(x => x.AdvertisingImageTypeStatus);
            Property(d => d.RowVersion).IsRowVersion();
        }
    }
}
