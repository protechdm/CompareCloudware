using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CompareCloudware.Web.Models
{
    public class OnpageOptimisationTab2Model : BaseModel
    {
        public OnpageOptimisationTab2Model()
        {
        }

        public OnpageOptimisationTab2Model(ICustomSession session)
        {
            base.CustomSession = session;
        }

        public IList<ContentTextModel> OnpageOptimisationTab2 { get; set; }
        //public IList<SearchResultModel> NewCloudware { get; set; }
        //public IList<SearchResultModel> TopTenCloudware { get; set; }
        //public bool FeaturedCloudwareSearchResultsVisible { get; set; }
        //public bool NewCloudwareSearchResultsVisible { get; set; }
        //public bool TopTenCloudwareSearchResultsVisible { get; set; }
        //public bool CategoryBasedResults { get; set; }
        //public int? CategoryID { get; set; }
    }
}