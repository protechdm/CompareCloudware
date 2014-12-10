using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CompareCloudware.Web.Models
{
    public class OnpageOptimisationTabModel : BaseModel
    {
        public OnpageOptimisationTabModel()
        {
        }

        public OnpageOptimisationTabModel(ICustomSession session)
        {
            base.CustomSession = session;
        }

        public IList<ContentTextModel> OnpageOptimisationTabData { get; set; }
        //public IList<SearchResultModel> NewCloudware { get; set; }
        //public IList<SearchResultModel> TopTenCloudware { get; set; }
        //public bool FeaturedCloudwareSearchResultsVisible { get; set; }
        //public bool NewCloudwareSearchResultsVisible { get; set; }
        //public bool TopTenCloudwareSearchResultsVisible { get; set; }
        //public bool CategoryBasedResults { get; set; }
        //public int? CategoryID { get; set; }
    }
}