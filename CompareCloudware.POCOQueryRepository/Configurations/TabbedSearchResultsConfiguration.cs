using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using CompareCloudware.Domain.Models;

namespace CompareCloudware.POCOQueryRepository.Configurations
{
    public class TabbedSearchResultsConfiguration : EntityTypeConfiguration<TabbedSearchResults>
    {
        public TabbedSearchResultsConfiguration()
        {
            ToTable("TabbedSearchResults");
        }
    }
}
