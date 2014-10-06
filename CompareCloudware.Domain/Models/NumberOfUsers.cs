using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompareCloudware.Domain.Models
{
    #region NumberOfUsers
    public class NumberOfUsers
    {
        public virtual int UserValue { get; set; }
        public virtual int UserID { get; set; }
        public virtual Status NumberOfUsersStatus { get; set; }
    }
    #endregion

}
