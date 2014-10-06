using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using CompareCloudware.Domain.Models;

namespace CompareCloudware.POCOQueryRepository.Configurations
{
    public class AdvertisingImageServerConfiguration : EntityTypeConfiguration<AdvertisingImageServer>
    {
        public AdvertisingImageServerConfiguration()
        {
            ToTable("AdvertisingImageServer");
            //Property(d => d.BrowserName).IsRequired();
            //Property(d => d.BrowserName).HasMaxLength(105);
            //Property(d => d.BrowserStatus).IsRequired();
            //this.HasRequired(x => x.BrowserStatus);
            Property(d => d.RowVersion).IsRowVersion();
        }
    }
}
