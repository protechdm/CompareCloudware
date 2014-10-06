using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CompareCloudware.Domain.Contracts.Repositories;

namespace CompareCloudware.Domain.Models
{
    public class SiteAnalyticType : IValidate
    {
        public virtual int SiteAnalyticTypeID { get; set; }
        public virtual string SiteAnalyticTypeName { get; set; }
        public virtual decimal ScoreValue { get; set; }
        public virtual DateTime AddDate { get; set; }
        public virtual DateTime? LastUpdateDate { get; set; }
        public virtual byte[] RowVersion { get; set; }

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
