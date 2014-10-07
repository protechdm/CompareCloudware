using CompareCloudware.Web;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace CompareCloudware.Web.Models
{

    public class SearchFiltersModelOneColumn : BaseModel
    {
        public SearchFiltersModelOneColumn()
        {
        }

        public SearchFiltersModelOneColumn(ICustomSession session)
        {
            base.CustomSession = session;
        }

        [Display(Name="Categories")]
        public IList<CategoryModel> Categories { get; set; }
        public int? ChosenCategoryID { get; set; }
        public int? ChosenNumberOfUsers { get; set; }

        public int? ChosenSupportDays { get; set; }
        public int? ChosenSupportHours { get; set; }
        public int? ChosenTimeZone { get; set; }

        [Display(Name="Users")]
        public IList<NumberOfUsersModel> NumberOfUsers { get; set; }

        public int? PreviouslyChosenCategoryID { get; set; }

        [Display(Name="Search Filters")]
        public IEnumerable<SearchFilterModelOneColumn> SearchFiltersBrowsers { get; set; }
        public IEnumerable<SearchFilterModelOneColumn> SearchFiltersFeatures { get; set; }
        public IEnumerable<SearchFilterModelOneColumn> SearchFiltersApplicationFeatures { get; set; }
        public IEnumerable<SearchFilterModelOneColumn> SearchFiltersLanguages { get; set; }
        public IEnumerable<SearchFilterModelOneColumn> SearchFiltersMobilePlatforms { get; set; }
        public IEnumerable<SearchFilterModelOneColumn> SearchFiltersOperatingSystems { get; set; }
        public IEnumerable<SearchFilterModelOneColumn> SearchFiltersDevices { get; set; }
        //public IEnumerable<SearchFilterModelOneColumn> SearchFiltersSupportDays { get; set; }
        //public IEnumerable<SearchFilterModelOneColumn> SearchFiltersSupportHours { get; set; }
        public IList<SearchFilterModelOneColumn> SearchFiltersSupportDays { get; set; }
        public IList<SearchFilterModelOneColumn> SearchFiltersSupportHours { get; set; }
        public IList<SearchFilterModelOneColumn> SearchFiltersTimeZones { get; set; }
        public IEnumerable<SearchFilterModelOneColumn> SearchFiltersSupportTypes { get; set; }
        public IEnumerable<SearchResultModelOneColumn> SearchResults { get; set; }

        [Display(Name="Test Value")]
        public string TestValue { get; set; }
    }
}

