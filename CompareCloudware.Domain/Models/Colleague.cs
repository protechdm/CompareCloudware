using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompareCloudware.Domain.Models
{
    #region Colleague
    public class Colleague
    {
        public virtual int ColleagueID { get; set; }
        public virtual Person Introducer { get; set; }
        public virtual Person ColleagueOfIntroducer { get; set; }
        public virtual byte[] RowVersion { get; set; }
    }
    #endregion

}
