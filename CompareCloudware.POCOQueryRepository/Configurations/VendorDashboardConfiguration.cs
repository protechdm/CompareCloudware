using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using CompareCloudware.Domain.Models;

namespace CompareCloudware.POCOQueryRepository.Configurations
{
    public class VendorDashboardConfiguration : EntityTypeConfiguration<VendorDashboard>
    {
        public VendorDashboardConfiguration()
        {
            ToTable("VendorDashboards");
            
            //Property(d => d.VendorName).IsRequired();
            //Property(d => d.VendorName).HasMaxLength(103);
            //Property(d => d.VendorName).HasColumnName("VendorName");
            //Property(d => d.VendorLogo).HasColumnType("image");
            //Property(d => d.VendorDashboardStatus).IsRequired();
            this.HasRequired(x => x.VendorDashboardStatus);
            Property(d => d.RowVersion).IsRowVersion();
            //HasMany(d => d.CloudApplications).WithRequired(v => v.Vendor);

        }
    }
}
