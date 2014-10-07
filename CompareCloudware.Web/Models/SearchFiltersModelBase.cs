using CompareCloudware.Web;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace CompareCloudware.Web.Models
{

    public class SearchFiltersModelBase : BaseModel
    {
        public SearchFiltersModelBase()
        {
        }

        public SearchFiltersModelBase(ICustomSession session)
        {
            base.CustomSession = session;
        }

        public bool SearchFiltersBrowsersCollapsed { get; set; }
        public bool SearchFiltersCategoriesCollapsed { get; set; }
        public bool SearchFiltersFeaturesCollapsed { get; set; }
        public bool SearchFiltersApplicationFeaturesCollapsed { get; set; }
        public bool SearchFiltersLanguagesCollapsed { get; set; }
        public bool SearchFiltersMobilePlatformsCollapsed { get; set; }
        public bool SearchFiltersOperatingSystemsCollapsed { get; set; }
        public bool SearchFiltersDevicesCollapsed { get; set; }
        public bool SearchFiltersSupportDaysCollapsed { get; set; }
        public bool SearchFiltersSupportHoursCollapsed { get; set; }
        public bool SearchFiltersSupportTypesCollapsed { get; set; }
        public bool SearchFiltersUsersCollapsed { get; set; }
        public bool SearchFiltersTimeZonesCollapsed { get; set; }
    }
}

