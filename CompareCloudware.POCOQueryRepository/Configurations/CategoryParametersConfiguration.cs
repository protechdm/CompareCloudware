using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using CompareCloudware.Domain.Models;

namespace CompareCloudware.POCOQueryRepository.Configurations

{
    public class CategoryParametersConfiguration : EntityTypeConfiguration<CategoryParameters>
    {
        public CategoryParametersConfiguration()
        {
            ToTable("CategoryParameters");
            Property(d => d.SearchResultsAnnualPriceColumnHeader).IsRequired();
            Property(d => d.SearchResultsMonthlyPriceColumnHeader).IsRequired();
            Property(d => d.RowVersion).IsRowVersion();
        }
    }
}
