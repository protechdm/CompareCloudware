using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompareCloudware.Domain.Models
{
    #region CloudApplicationProductReview
    public class CloudApplicationProductReview
    {
        public virtual int CloudApplicationProductReviewID { get; set; }
        public virtual string CloudApplicationProductReviewHeadline { get; set; }
        public virtual string CloudApplicationProductReviewPublisherName { get; set; }
        public virtual string CloudApplicationProductReviewText { get; set; }
        public virtual DateTime CloudApplicationProductReviewDate { get; set; }
        public virtual string CloudApplicationProductReviewURL { get; set; }
        public virtual CloudApplicationDocumentFormat CloudApplicationProductReviewURLDocumentFormat { get; set; }
        public virtual string CloudApplicationProductReviewPhysicalFileName { get; set; }
        //public virtual bool IsLive { get; set; }
        public virtual bool IsDocument { get; set; }
        public virtual bool IsBrokenLink { get; set; }
        public virtual Guid UniqueRowID { get; set; }
        public virtual Status CloudApplicationProductReviewStatus { get; set; }
        public virtual byte[] RowVersion { get; set; }
        public virtual CloudApplication CloudApplication { get; set; }
    }
    #endregion

}
