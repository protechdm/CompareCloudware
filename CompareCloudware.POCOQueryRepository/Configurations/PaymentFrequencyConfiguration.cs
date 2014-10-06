using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using CompareCloudware.Domain.Models;

namespace CompareCloudware.POCOQueryRepository.Configurations
{
    public class PaymentFrequencyConfiguration : EntityTypeConfiguration<PaymentFrequency>
    {
        public PaymentFrequencyConfiguration()
        {
            ToTable("PaymentFrequencies");
            Property(d => d.PaymentFrequencyName).IsRequired();
            Property(d => d.PaymentFrequencyName).HasMaxLength(105);
            //Property(d => d.PaymentFrequencyStatus).IsRequired();
            this.HasRequired(x => x.PaymentFrequencyStatus);
            Property(d => d.RowVersion).IsRowVersion();
        }
    }
}
