using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompareCloudware.Domain.Models
{
    #region SiteActivity
    public class SiteActivity
    {
        public virtual int SiteActivityID { get; set; }
        public virtual string UserAgent { get; set; }
        public virtual string UserHostAddress { get; set; }
        public virtual string BrowserName { get; set; }
        public virtual string BrowserID { get; set; }
        public virtual string RequestedURL { get; set; }
        public virtual DateTime RequestDate { get; set; }
        public virtual string UserLanguage { get; set; }
        public virtual int InterfaceID { get; set; }
    }
    #endregion

}
