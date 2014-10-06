using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompareCloudware.Domain.Models
{
    #region AdvertisingImage
    public class AdvertisingImage
    {
        public virtual int AdvertisingImageID { get; set; }
        public virtual string AdvertisingImageTitle { get; set; }
        public virtual string AdvertisingImageURL { get; set; }
        public virtual string AdvertisingImagePhysicalFilePath { get; set; }
        public virtual string AdvertisingImageFileName { get; set; }
        public virtual Category Category { get; set; }
        public virtual CloudApplication CloudApplication { get; set; }
        public virtual AdvertisingImageType AdvertisingImageType { get; set; }
        public virtual Status AdvertisingImageStatus { get; set; }
        public virtual byte[] AdvertisingImageBytes { get; set; }
        public virtual byte[] RowVersion { get; set; }
    }
    #endregion

}
