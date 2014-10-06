using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using CompareCloudware.Domain.Models;

namespace CompareCloudware.POCOQueryRepository.Configurations
{
    public class VendorDashboardRolePersonConfiguration : EntityTypeConfiguration<VendorDashboardRolePerson>
    {
        public VendorDashboardRolePersonConfiguration()
        {
            ToTable("VendorDashboardRolePersons");
            
            //Property(d => d.VendorName).IsRequired();
            //Property(d => d.VendorName).HasMaxLength(103);
            //Property(d => d.VendorName).HasColumnName("VendorName");
            //Property(d => d.VendorLogo).HasColumnType("image");
            //Property(d => d.VendorDashboardRoleStatus).IsRequired();
            this.HasRequired(x => x.VendorDashboardRolePersonStatus);
            Property(d => d.RowVersion).IsRowVersion();
            //HasMany(d => d.CloudApplications).WithRequired(v => v.Vendor);

        }
    }
}
