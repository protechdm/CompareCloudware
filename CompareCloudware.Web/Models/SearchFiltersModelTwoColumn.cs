using CompareCloudware.Web;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
namespace CompareCloudware.Web.Models
{
    public class SearchFiltersModelTwoColumn : BaseModel
    {
        public SearchFiltersModelTwoColumn()
        {
        }

        public SearchFiltersModelTwoColumn(ICustomSession session)
        {
            base.CustomSession = session;
        }

        [Display(Name="Categories")]
        public IList<CategoryModel> Categories { get; set; }

        public int? ChosenCategoryID { get; set; }

        public int? ChosenNumberOfUsers { get; set; }

        [Display(Name="Users")]
        public IList<NumberOfUsersModel> NumberOfUsers { get; set; }

        public int? PreviouslyChosenCategoryID { get; set; }

        [Display(Name="Search Filters")]
        public IEnumerable<SearchFilterModelTwoColumn> SearchFiltersBrowsers { get; set; }

        public IEnumerable<SearchFilterModelOneColumn> SearchFiltersFeatures { get; set; }

        public IEnumerable<SearchFilterModelTwoColumn> SearchFiltersLanguages { get; set; }

        public IEnumerable<SearchFilterModelTwoColumn> SearchFiltersMobilePlatforms { get; set; }

        public IEnumerable<SearchFilterModelTwoColumn> SearchFiltersOperatingSystems { get; set; }

        public IEnumerable<SearchFilterModelTwoColumn> SearchFiltersDevices { get; set; }

        public IEnumerable<SearchFilterModelTwoColumn> SearchFiltersSupportDays { get; set; }

        public IEnumerable<SearchFilterModelTwoColumn> SearchFiltersSupportHours { get; set; }

        public IEnumerable<SearchFilterModelTwoColumn> SearchFiltersSupportTypes { get; set; }

        public IEnumerable<SearchFilterModelOneColumn> SearchFiltersTimeZones { get; set; }

        [Display(Name="Test Value")]
        public string TestValue { get; set; }
    }
}

