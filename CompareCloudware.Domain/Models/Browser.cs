using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompareCloudware.Domain.Models
{
    #region Browser
    public class Browser
    {
        public virtual int BrowserID { get; set; }
        public virtual string BrowserName { get; set; }
        public virtual int BrowserColumnNumber { get; set; }
        public virtual int BrowserRowNumber { get; set; }
        public virtual Status BrowserStatus { get; set; }
        public virtual byte[] RowVersion { get; set; }
        public virtual List<CloudApplication> CloudApplications { get; set; }
    }
    #endregion

}
