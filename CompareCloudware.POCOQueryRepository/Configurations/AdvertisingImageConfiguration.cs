using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using CompareCloudware.Domain.Models;

namespace CompareCloudware.POCOQueryRepository.Configurations
{
    public class AdvertisingImageConfiguration : EntityTypeConfiguration<AdvertisingImage>
    {
        public AdvertisingImageConfiguration()
        {
            ToTable("AdvertisingImages");
            Property(d => d.AdvertisingImageFileName).IsRequired();
            Property(d => d.AdvertisingImageFileName).HasMaxLength(105);
            //Property(d => d.AdvertisingImageStatus).IsRequired();
            this.HasRequired(x => x.AdvertisingImageStatus);
            Property(d => d.RowVersion).IsRowVersion();
        }
    }
}
