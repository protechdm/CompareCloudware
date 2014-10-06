using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using CompareCloudware.Domain.Models;

namespace CompareCloudware.POCOQueryRepository.Configurations
{
    public class CloudApplicationRequestConfiguration : EntityTypeConfiguration<CloudApplicationRequest>
    {
        public CloudApplicationRequestConfiguration()
        {
            ToTable("CloudApplicationRequests");
            Property(d => d.PersonID).IsRequired();
            Property(d => d.RowVersion).IsRowVersion();
        }
    }
}
