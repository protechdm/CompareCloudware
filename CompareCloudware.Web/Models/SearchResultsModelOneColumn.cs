using CompareCloudware.Web;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using PagedList;
using System.Runtime.Serialization;
using System.Linq;

namespace CompareCloudware.Web.Models
{
    public class SearchResultsModelOneColumn : BaseModel
    {
        public SearchResultsModelOneColumn()
        {
        }

        public SearchResultsModelOneColumn(ICustomSession session)
        {
            base.CustomSession = session;
        }

        [Display(Name="Categories")]
        public IList<CategoryModel> Categories { get; set; }

        public int? ChosenCategoryID { get; set; }

        public int? ChosenNumberOfUsers { get; set; }

        public bool DisplayAsSummary { get; set; }

        [Display(Name="Users")]
        public IList<NumberOfUsersModel> NumberOfUsers { get; set; }

        public int? PreviouslyChosenCategoryID { get; set; }

        public IEnumerable<SearchFilterModelOneColumn> SearchFiltersLanguages { get; set; }

        public IEnumerable<SearchFilterModelOneColumn> SearchFiltersMobilePlatforms { get; set; }

        public IEnumerable<SearchFilterModelOneColumn> SearchFiltersOperatingSystems { get; set; }

        public IEnumerable<SearchFilterModelOneColumn> SearchFiltersSupportDays { get; set; }

        public IEnumerable<SearchFilterModelOneColumn> SearchFiltersSupportHours { get; set; }

        public IEnumerable<SearchFilterModelOneColumn> SearchFiltersSupportTypes { get; set; }

        [Display(Name="Search Filters")]
        public IList<SearchResultModelOneColumn> SearchResults { get; set; }

        public IList<SearchResultSummaryModel> SearchResultsSummary { get; set; }

        [Display(Name="Test Value")]
        public string TestValue { get; set; }

        public PagedList<SearchResultModelOneColumn> SearchResultsPage { get; set; }

    }

}

