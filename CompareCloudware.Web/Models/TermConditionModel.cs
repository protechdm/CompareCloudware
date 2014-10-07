using CompareCloudware.Web;
using System;
using System.Runtime.CompilerServices;

namespace CompareCloudware.Web.Models
{
    public class TermConditionModel : BaseModel
    {
        public TermConditionModel()
        {
        }

        public TermConditionModel(ICustomSession session)
        {
            base.CustomSession = session;
        }

        public int TermConditionID { get; set; }
        public int DisplayID { get; set; }
        public int ParentDisplayID { get; set; }
        public int Section { get; set; }

        public int Order { get; set; }
        public int Indent { get; set; }
        public int ColumnSpan { get; set; }
        public bool IsBold { get; set; }

        
        public string SectionNumber { get; set; }
        public string SectionText1 { get; set; }
        public string SectionText2 { get; set; }
        public string SectionText3 { get; set; }
        public string SectionText4 { get; set; }
        public string SectionText5 { get; set; }
        public bool SectionText1IsURL { get; set; }
        public bool SectionText2IsURL { get; set; }
        public bool SectionText3IsURL { get; set; }
        public bool SectionText4IsURL { get; set; }
        public bool SectionText5IsURL { get; set; }
        public string SectionText1URL { get; set; }
        public string SectionText2URL { get; set; }
        public string SectionText3URL { get; set; }
        public string SectionText4URL { get; set; }
        public string SectionText5URL { get; set; }
        public bool SectionText1IsMailRef { get; set; }
        public bool SectionText2IsMailRef { get; set; }
        public bool SectionText3IsMailRef { get; set; }
        public bool SectionText4IsMailRef { get; set; }
        public bool SectionText5IsMailRef { get; set; }
        public string SectionText1MailRef { get; set; }
        public string SectionText2MailRef { get; set; }
        public string SectionText3MailRef { get; set; }
        public string SectionText4MailRef { get; set; }
        public string SectionText5MailRef { get; set; }
    }
}

