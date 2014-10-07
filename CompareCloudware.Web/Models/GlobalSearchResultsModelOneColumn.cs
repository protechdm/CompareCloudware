using CompareCloudware.Web;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using PagedList;

namespace CompareCloudware.Web.Models
{
    public class GlobalSearchResultsModelOneColumn : BaseModel
    {
        public GlobalSearchResultsModelOneColumn()
        {
        }

        public GlobalSearchResultsModelOneColumn(ICustomSession session)
        {
            base.CustomSession = session;
        }

        public IEnumerable<GlobalSearchResultModelOneColumn> SearchResults { get; set; }
        public PagedList<GlobalSearchResultModelOneColumn> SearchResultsPage { get; set; }
        public int SearchResultsPerPage { get; set; }
    }
}

