using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompareCloudware.Domain.Models
{
    #region Language
    public class Language
    {
        public virtual int LanguageID { get; set; }
        public virtual string LanguageName { get; set; }
        public virtual Status LanguageStatus { get; set; }
        public virtual byte[] RowVersion { get; set; }
        public virtual List<CloudApplication> CloudApplications { get; set; }
    }
    #endregion

}
