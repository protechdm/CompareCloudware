using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompareCloudware.Domain.Models
{
    #region SupportAreaQA
    public class SupportAreaQA
    {
        public virtual int SupportAreaQAID { get; set; }
        public virtual SupportArea SupportArea { get; set; }
        public virtual List<SupportAreaQACategory> SupportAreaQACategories { get; set; }
        public virtual string SupportCategoryOther { get; set; }
        public virtual int? SupportAreaCloudApplicationID { get; set; }
        public virtual string SupportAreaCloudApplicationServiceName { get; set; }
        public virtual Person SubmittedPerson { get; set; }
        public virtual string Question { get; set; }
        public virtual DateTime QuestionDate { get; set; }
        public virtual string Answer { get; set; }
        public virtual DateTime? AnswerDate { get; set; }
        public virtual Person AssignedPerson { get; set; }
        public virtual QAStatus QAStatus { get; set; }
        public virtual Status SupportAreaQAStatus { get; set; }

        public virtual bool? EMail { get; set; }
        public virtual bool? Servicing { get; set; }
        public virtual bool? Serviced { get; set; }
        public virtual DateTime? ServicedDate { get; set; }
        public virtual byte[] RowVersion { get; set; }
    }
    #endregion

}
