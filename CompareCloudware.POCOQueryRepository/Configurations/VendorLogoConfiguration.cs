using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using CompareCloudware.Domain.Models;

namespace CompareCloudware.POCOQueryRepository.Configurations
{
    public class VendorLogoConfiguration : EntityTypeConfiguration<VendorLogo>
    {
        public VendorLogoConfiguration()
        {
            ToTable("VendorLogos");
            
            Property(d => d.Logo).HasColumnType("image");
            //Property(d => d.VendorLogoStatus).IsRequired();
            this.HasRequired(x => x.VendorLogoStatus);
            Property(d => d.RowVersion).IsRowVersion();

        }
    }
}
