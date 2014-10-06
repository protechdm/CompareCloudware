using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompareCloudware.Domain.Models
{
    #region CloudApplicationDocumentFormat
    public class CloudApplicationDocumentFormat
    {
        public virtual int CloudApplicationDocumentFormatID { get; set; }
        public virtual string CloudApplicationDocumentFormatShortName { get; set; }
        public virtual string CloudApplicationDocumentFormatLongName { get; set; }
        public virtual string CloudApplicationDocumentFormatURLHeaderName { get; set; }
        public virtual Status CloudApplicationDocumentFormatStatus { get; set; }
        public virtual byte[] RowVersion { get; set; }
    }
    #endregion

}
