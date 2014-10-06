using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompareCloudware.Domain.Models
{
    #region QAStatus
    public class QAStatus
    {
        public virtual int QAStatusID { get; set; }
        public virtual string QAStatusName { get; set; }
        public virtual Status QuestionStatus { get; set; }
        public virtual byte[] RowVersion { get; set; }
    }
    #endregion

}
