using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompareCloudware.Domain.Models
{
    #region CategoryParameters
    public class CategoryParameters
    {
        public virtual int CategoryParametersID { get; set; }
        public virtual string SearchResultsCloudwareProviderColumnHeader { get; set; }
        public virtual string SearchResultsSetupFeeColumnHeader { get; set; }
        public virtual string SearchResultsFreeTrialColumnHeader { get; set; }
        public virtual string SearchResultsMonthlyPriceColumnHeader { get; set; }
        public virtual string SearchResultsAnnualPriceColumnHeader { get; set; }


        public virtual string SearchResultCloudwareProviderColumnHeader { get; set; }
        public virtual string SearchResultSetupFeeColumnHeader { get; set; }
        public virtual string SearchResultFreeTrialColumnHeader { get; set; }
        public virtual string SearchResultMonthlyPriceColumnHeader { get; set; }
        public virtual string SearchResultAnnualPriceColumnHeader { get; set; }
        public virtual byte[] RowVersion { get; set; }
        public virtual Category Category { get; set; }
    }
    #endregion
}
