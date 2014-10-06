using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using CompareCloudware.Domain.Models;

namespace CompareCloudware.POCOQueryRepository.Configurations
{
    public class CurrencyConfiguration : EntityTypeConfiguration<Currency>
    {
        public CurrencyConfiguration()
        {
            ToTable("Currencies");
            Property(d => d.CurrencyName).IsRequired();
            Property(d => d.ExchangeRateSterling).IsRequired();
            //Property(d => d.CurrencyStatus).IsRequired();
            this.HasRequired(x => x.CurrencyStatus);
            Property(d => d.RowVersion).IsRowVersion();
        }
    }
}
