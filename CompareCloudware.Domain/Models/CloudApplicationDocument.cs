using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompareCloudware.Domain.Models
{
    #region Document
    public class CloudApplicationDocument
    {
        public virtual int CloudApplicationDocumentID { get; set; }
        public virtual string CloudApplicationDocumentTitle { get; set; }
        public virtual string CloudApplicationDocumentURL { get; set; }
        public virtual string CloudApplicationDocumentPhysicalFilePath { get; set; }
        public virtual string CloudApplicationDocumentFileName { get; set; }
        public virtual DateTime CloudApplicationDocumentReleaseDate { get; set; }
        public virtual CloudApplication CloudApplication { get; set; }
        public virtual CloudApplicationDocumentType CloudApplicationDocumentType { get; set; }
        public virtual CloudApplicationDocumentFormat CloudApplicationDocumentFormat { get; set; }
        public virtual CloudApplicationDocumentImage CloudApplicationDocumentImage { get; set; }
        public virtual Guid UniqueRowID { get; set; }
        //public bool IsLive { get; set; }
        public virtual Status CloudApplicationDocumentStatus { get; set; }

        public virtual byte[] ThumbnailImage { get; set; }
        public virtual byte[] RowVersion { get; set; }
    }
    #endregion

}
