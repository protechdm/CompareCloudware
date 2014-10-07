namespace CompareCloudware.Web.Models
{
    using CompareCloudware.Web;
    using System;
    using System.Runtime.CompilerServices;

    public class BrowserModel : BaseModel
    {
        public BrowserModel()
        {
        }

        public BrowserModel(ICustomSession session)
        {
            base.CustomSession = session;
        }

        public int BrowserColumnNumber { get; set; }

        public int BrowserID { get; set; }

        public string BrowserName { get; set; }

        public int BrowserRowNumber { get; set; }
    }
}

