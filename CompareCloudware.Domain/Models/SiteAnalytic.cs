﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CompareCloudware.Domain.Contracts.Repositories;

namespace CompareCloudware.Domain.Models
{
    public class SiteAnalytic : IValidate
    {
        public virtual int SiteAnalyticID { get; set; }
        public virtual DateTime SiteAnalyticDate { get; set; }
        public virtual SiteAnalyticType SiteAnalyticType { get; set; }
        public virtual int? CloudApplicationID { get; set; }
        public virtual int? CategoryID { get; set; }
        public virtual int? PersonID { get; set; }
        public virtual string SessionID { get; set; }
        public virtual int? ReferenceDataRowID { get; set; }
        public virtual int? FeatureTypeID { get; set; }
        //public virtual DateTime AddDate { get; set; }
        //public virtual DateTime? LastUpdateDate { get; set; }
        //public virtual byte[] RowVersion { get; set; }

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
