using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using CompareCloudware.Domain.Models;

namespace CompareCloudware.POCOQueryRepository.Configurations
{
    public class LanguageConfiguration : EntityTypeConfiguration<Language>
    {
        public LanguageConfiguration()
        {
            ToTable("Languages");
            Property(d => d.LanguageName).IsRequired();
            Property(d => d.LanguageName).HasMaxLength(105);
            //Property(d => d.LanguageStatus).IsRequired();
            this.HasRequired(x => x.LanguageStatus);
            Property(d => d.RowVersion).IsRowVersion();
        }
    }
}
