using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using CompareCloudware.Domain.Models;

namespace CompareCloudware.POCOQueryRepository.Configurations
{
    public class ProfileConfiguration : EntityTypeConfiguration<Profile>
    {
        public ProfileConfiguration()
        {
            ToTable("Profiles");
            
            //Property(d => d.VendorName).IsRequired();
            //Property(d => d.VendorName).HasMaxLength(103);
            //Property(d => d.VendorName).HasColumnName("VendorName");
            //Property(d => d.VendorLogo).HasColumnType("image");
            Property(d => d.RowVersion).IsRowVersion();
            //HasMany(d => d.CloudApplications).WithRequired(v => v.Vendor);
            //Property(d => d.ProfileStatus).IsRequired();
            this.HasRequired(x => x.ProfileStatus);

        }
    }
}
