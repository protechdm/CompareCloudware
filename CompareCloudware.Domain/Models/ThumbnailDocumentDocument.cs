using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompareCloudware.Domain.Models
{
    #region ThumbnailDocumentDocument
    public class ThumbnailDocumentDocument
    {
        public virtual int ThumbnailDocumentDocumentID { get; set; }
        //public virtual ThumbnailDocument ThumbnailDocument { get; set; }
        public virtual byte[] ThumbnailDocumentBytes { get; set; }
        public virtual byte[] RowVersion { get; set; }
    }
    #endregion

}
