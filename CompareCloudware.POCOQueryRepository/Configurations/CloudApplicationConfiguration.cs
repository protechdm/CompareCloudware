using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using CompareCloudware.Domain.Models;

namespace CompareCloudware.POCOQueryRepository.Configurations
{
    public class CloudApplicationConfiguration : EntityTypeConfiguration<CloudApplication>
    {
        public CloudApplicationConfiguration()
        {
            ToTable("CloudApplications");
            Property(d => d.ServiceName).IsRequired().HasMaxLength(102);
            Property(d => d.Description).IsRequired().HasMaxLength(4000);
            //Property(d => d.CloudApplicationStatus).IsRequired();
            
            //this.HasRequired(x => x.CloudApplicationStatus).WithRequiredDependent().WillCascadeOnDelete(false);
            this.HasRequired(x => x.CloudApplicationStatus);
            Property(d => d.RowVersion).IsRowVersion();

            //this.HasOptional(x => x.CloudApplicationShopTag);
        }
    }
}
