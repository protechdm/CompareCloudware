using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompareCloudware.Domain.Models
{
    #region CloudApplicationRating
    public class CloudApplicationRating
    {
        public virtual int CloudApplicationRatingID { get; set; }
        public virtual string CloudApplicationRatingReviewerForename { get; set; }
        public virtual string CloudApplicationRatingReviewerSurname { get; set; }
        public virtual string CloudApplicationRatingReviewerTitle { get; set; }
        public virtual string CloudApplicationRatingReviewerCompany { get; set; }
        public virtual string CloudApplicationRatingText { get; set; }
        public virtual decimal CloudApplicationOverallRating { get; set; }
        public virtual decimal CloudApplicationEaseOfUse { get; set; }
        public virtual decimal CloudApplicationValueForMoney { get; set; }
        public virtual decimal CloudApplicationFunctionality { get; set; }

        public virtual Industry CloudApplicationReviewIndustry { get; set; }
        public virtual int CloudApplicationReviewEmployeeCount { get; set; }
        

        public virtual byte[] RowVersion { get; set; }
        public virtual CloudApplication CloudApplication { get; set; }
    }
    #endregion

}

