using CompareCloudware.Web;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CompareCloudware.Web.Models
{
    public class TabbedSearchResultsModel : BaseModel
    {
        public TabbedSearchResultsModel()
        {
        }

        public TabbedSearchResultsModel(ICustomSession session)
        {
            base.CustomSession = session;
        }

        public IList<SearchResultModel> FeaturedCloudware { get; set; }
        public IList<SearchResultModel> NewCloudware { get; set; }
        public IList<SearchResultModel> TopTenCloudware { get; set; }
        public bool FeaturedCloudwareSearchResultsVisible { get; set; }
        public bool NewCloudwareSearchResultsVisible { get; set; }
        public bool TopTenCloudwareSearchResultsVisible { get; set; }
        public bool CategoryBasedResults { get; set; }
        public int? CategoryID { get; set; }

        public FeaturedCloudwareModel FeaturedCloudwareNew { get; set; }
        public NewCloudwareModel NewCloudwareNew { get; set; }
        public TopTenCloudwareModel TopTenCloudwareNew { get; set; }

    }
}

