using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using CompareCloudware.Domain.Models;

namespace CompareCloudware.POCOQueryRepository.Configurations
{
    public class DeviceConfiguration : EntityTypeConfiguration<Device>
    {
        public DeviceConfiguration()
        {
            ToTable("Devices");
            Property(d => d.DeviceName).IsRequired();
            Property(d => d.DeviceName).HasMaxLength(105);
            //Property(d => d.DeviceStatus).IsRequired();
            this.HasRequired(x => x.DeviceStatus);
            Property(d => d.RowVersion).IsRowVersion();
        }
    }
}
