namespace CompareCloudware.Web.Models
{
    using CompareCloudware.Web;
    using System;
    using System.Collections.Generic;

    public class SearchFiltersForFeatureTypeModel : BaseModel
    {
        private List<SearchFilterModelTwoColumn> _featureFilters;

        public SearchFiltersForFeatureTypeModel()
        {
        }

        public SearchFiltersForFeatureTypeModel(ICustomSession session)
        {
            base.CustomSession = session;
        }

        public List<SearchFilterModelTwoColumn> FeatureFilters
        {
            get
            {
                return this._featureFilters;
            }
            set
            {
                this._featureFilters = value;
            }
        }
    }
}

