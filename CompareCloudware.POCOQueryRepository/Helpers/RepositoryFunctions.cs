using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CompareCloudware.Domain.Models;
using System.Linq.Expressions;

namespace CompareCloudware.POCOQueryRepository.Helpers
{
    public static class RepositoryFunctions
    {
        #region GetShopTag
        /// <summary>
        /// Filters a list of projects by the generic search criteria for the Modify Search Functionality
        /// </summary>
        /// <param name="searchCriteria"></param>
        /// <returns>A List of filtered projects</returns>
        public static Expression<Func<CloudApplication, string>> GetShopTag()
        {
            return cloudApplication => (cloudApplication.CloudApplicationShopTag.TagName);
        }
        #endregion

    
    }

}