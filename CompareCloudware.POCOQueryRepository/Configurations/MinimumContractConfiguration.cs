using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using CompareCloudware.Domain.Models;

namespace CompareCloudware.POCOQueryRepository.Configurations
{
    public class MinimumContractConfiguration : EntityTypeConfiguration<MinimumContract>
    {
        public MinimumContractConfiguration()
        {
            ToTable("MinimumContracts");
            Property(d => d.MinimumContractName).IsRequired();
            Property(d => d.MinimumContractName).HasMaxLength(105);
            //Property(d => d.MinimumContractStatus).IsRequired();
            this.HasRequired(x => x.MinimumContractStatus);
            Property(d => d.RowVersion).IsRowVersion();
        }
    }
}
