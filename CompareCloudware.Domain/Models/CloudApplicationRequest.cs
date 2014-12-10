using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompareCloudware.Domain.Models
{
    #region CloudApplicationRequest
    public class CloudApplicationRequest
    {
        public virtual int CloudApplicationRequestID { get; set; }
        public virtual int PersonID { get; set; }
        public virtual int CloudApplicationID { get; set; }
        public virtual string CloudApplicationServiceName { get; set; }
        //public virtual bool? FreeTrial { get; set; }
        //public virtual bool? BuyNow { get; set; }
        public virtual int RequestTypeID { get; set; }
        public virtual byte[] RowVersion { get; set; }
        public virtual bool? EMail { get; set; }
        public virtual DateTime? Serviced { get; set; }

        public bool? Servicing { get; set; }
        public virtual string RequestData { get; set; }
    }
    #endregion

}
