using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompareCloudware.Domain.Models
{
    #region TermCondition
    public class TermCondition
    {
        public virtual int TermConditionID { get; set; }
        public virtual string TermConditionType { get; set; }

        public virtual int DisplayID { get; set; }
        public virtual int ParentDisplayID { get; set; }
        public virtual int Section { get; set; }
        public virtual int Order { get; set; }
        public virtual int Indent { get; set; }
        public virtual int ColumnSpan { get; set; }
        public virtual bool IsBold { get; set; }
        public virtual string SectionNumber { get; set; }
        public virtual string SectionText1 { get; set; }
        public virtual string SectionText2 { get; set; }
        public virtual string SectionText3 { get; set; }
        public virtual string SectionText4 { get; set; }
        public virtual string SectionText5 { get; set; }
        public virtual bool SectionText1IsURL { get; set; }
        public virtual bool SectionText2IsURL { get; set; }
        public virtual bool SectionText3IsURL { get; set; }
        public virtual bool SectionText4IsURL { get; set; }
        public virtual bool SectionText5IsURL { get; set; }
        public virtual string SectionText1URL { get; set; }
        public virtual string SectionText2URL { get; set; }
        public virtual string SectionText3URL { get; set; }
        public virtual string SectionText4URL { get; set; }
        public virtual string SectionText5URL { get; set; }
        public virtual bool SectionText1IsMailRef { get; set; }
        public virtual bool SectionText2IsMailRef { get; set; }
        public virtual bool SectionText3IsMailRef { get; set; }
        public virtual bool SectionText4IsMailRef { get; set; }
        public virtual bool SectionText5IsMailRef { get; set; }
        public virtual string SectionText1MailRef { get; set; }
        public virtual string SectionText2MailRef { get; set; }
        public virtual string SectionText3MailRef { get; set; }
        public virtual string SectionText4MailRef { get; set; }
        public virtual string SectionText5MailRef { get; set; }

        public virtual Status TermConditionStatus { get; set; }
        public virtual byte[] RowVersion { get; set; }
        public virtual List<CloudApplication> CloudApplications { get; set; }
    }
    #endregion

}
