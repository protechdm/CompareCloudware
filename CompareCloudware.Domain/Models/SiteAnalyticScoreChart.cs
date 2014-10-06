using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CompareCloudware.Domain.Contracts.Repositories;

namespace CompareCloudware.Domain.Models
{
    public class SiteAnalyticScoreChart : IValidate
    {
        public virtual Int64 ChartPosition { get; set; }
        public virtual string ServiceName { get; set; }
        public virtual string Brand { get; set; }
        public virtual Int32 CloudApplicationID { get; set; }
        public virtual Int32 CategoryID { get; set; }
        public virtual Int32 StatusID { get; set; }
        public virtual decimal Score { get; set; }

        public void Validate(ChangeAction action)
        {
            //    if (action == ChangeAction.Insert)
            //    {
            //        //prevent double-posting of Comments
            //        if (this.ActionID == 0)
            //            throw new InvalidOperationException(
            //        "An action must be specified");
            //    }
        }
    }
}
