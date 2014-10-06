using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using CompareCloudware.Domain.Models;

namespace CompareCloudware.POCOQueryRepository.Configurations
{
    public class LicenceTypeMinimumConfiguration : EntityTypeConfiguration<LicenceTypeMinimum>
    {
        public LicenceTypeMinimumConfiguration()
        {
            ToTable("LicenceTypeMinimums");
            Property(d => d.LicenceTypeMinimumName).IsRequired();
            //Property(d => d.LicenceTypeMinimumName).HasMaxLength(105);
            //Property(d => d.LicenceTypeMinimumStatus).IsRequired();
            this.HasRequired(x => x.LicenceTypeMinimumStatus);
            Property(d => d.RowVersion).IsRowVersion();
        }
    }

    public class LicenceTypeMaximumConfiguration : EntityTypeConfiguration<LicenceTypeMaximum>
    {
        public LicenceTypeMaximumConfiguration()
        {
            ToTable("LicenceTypeMaximums");
            Property(d => d.LicenceTypeMaximumName).IsRequired();
            //Property(d => d.LicenceTypeMaximumName).HasMaxLength(105);
            //Property(d => d.LicenceTypeMaximumStatus).IsRequired();
            this.HasRequired(x => x.LicenceTypeMaximumStatus);
            Property(d => d.RowVersion).IsRowVersion();
        }
    }

}
