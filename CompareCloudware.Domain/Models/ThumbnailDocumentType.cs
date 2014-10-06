using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompareCloudware.Domain.Models
{
    #region ThumbnailDocumentType
    public class ThumbnailDocumentType
    {
        public virtual int ThumbnailDocumentTypeID { get; set; }
        public virtual string ThumbnailDocumentTypeName { get; set; }
        public virtual byte[] RowVersion { get; set; }
    }
    #endregion

}
