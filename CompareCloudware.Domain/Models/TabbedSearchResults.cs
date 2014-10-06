using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompareCloudware.Domain.Models
{
    #region TabbedSearchResults
    public class TabbedSearchResults
    {
        public virtual IList<SearchResult> FeaturedCloudware { get; set; }
        public virtual IList<SearchResult> NewCloudware { get; set; }
        public virtual IList<SearchResult> TopTenCloudware { get; set; }
    }
    #endregion

}
