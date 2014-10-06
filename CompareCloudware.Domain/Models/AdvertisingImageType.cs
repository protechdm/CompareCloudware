using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompareCloudware.Domain.Models
{
    #region AdvertisingImageType
    public class AdvertisingImageType
    {
        public virtual int AdvertisingImageTypeID { get; set; }
        public virtual string AdvertisingImageTypeName { get; set; }
        public virtual Status AdvertisingImageTypeStatus { get; set; }
        public virtual byte[] RowVersion { get; set; }
    }
    #endregion

}
