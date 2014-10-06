using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompareCloudware.Domain.Models
{
    #region CloudApplicationUserReview
    public class CloudApplicationUserReview
    {
        public virtual int CloudApplicationUserReviewID { get; set; }
        public virtual string CloudApplicationUserReviewForename { get; set; }
        public virtual string CloudApplicationUserReviewSurname { get; set; }
        public virtual string CloudApplicationUserReviewTitle { get; set; }
        public virtual string CloudApplicationUserReviewCompany { get; set; }
        public virtual string CloudApplicationUserReviewText { get; set; }
        public virtual decimal CloudApplicationUserReviewOverallRating { get; set; }
        public virtual decimal CloudApplicationUserReviewEaseOfUse { get; set; }
        public virtual decimal CloudApplicationUserReviewValueForMoney { get; set; }
        public virtual decimal CloudApplicationUserReviewFunctionality { get; set; }

        public virtual Industry CloudApplicationUserReviewIndustry { get; set; }
        public virtual int CloudApplicationUserReviewEmployeeCount { get; set; }
        public virtual Guid UniqueRowID { get; set; }

        //public bool IsLive { get; set; }
        public virtual Status CloudApplicationUserReviewStatus { get; set; }

        public virtual byte[] RowVersion { get; set; }
        public virtual CloudApplication CloudApplication { get; set; }

        public virtual DateTime CloudApplicationUserReviewDate { get; set; }
    }
    #endregion

}

