using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using CompareCloudware.Domain.Models;

namespace CompareCloudware.POCOQueryRepository.Configurations
{
    public class SiteActivityConfiguration : EntityTypeConfiguration<SiteActivity>
    {
        public SiteActivityConfiguration()
        {
            ToTable("SiteActivity");
            //Property(d => d.BrowserName).IsRequired();
            //Property(d => d.BrowserName).HasMaxLength(105);
        }
    }
}
