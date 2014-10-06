using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompareCloudware.Domain.Models
{
    #region CloudApplicationVideo
    public class CloudApplicationVideo
    {
        public virtual int CloudApplicationVideoID { get; set; }
        public virtual bool IsLocalDomain { get; set; }
        //public virtual bool IsLive { get; set; }
        public virtual Status CloudApplicationVideoStatus { get; set; }
        public virtual bool IsYouTubeStream { get; set; }
        public virtual string CloudApplicationVideoURL { get; set; }
        public virtual string CloudApplicationVideoFileName { get; set; }
        public virtual string CloudApplicationVideoFileFormat { get; set; }

        public virtual byte[] RowVersion { get; set; }
        public virtual CloudApplication CloudApplication { get; set; }
    }
    #endregion

}
