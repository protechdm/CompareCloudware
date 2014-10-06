using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompareCloudware.Domain.Models
{
    #region DocumentImage
    public class CloudApplicationDocumentImage
    {
        public virtual int CloudApplicationDocumentImageID { get; set; }
        //public virtual ThumbnailDocument ThumbnailDocument { get; set; }
        public virtual byte[] CloudApplicationDocumentBytes { get; set; }
        public virtual Status CloudApplicationDocumentImageStatus { get; set; }
        public virtual byte[] RowVersion { get; set; }
    }
    #endregion

}
