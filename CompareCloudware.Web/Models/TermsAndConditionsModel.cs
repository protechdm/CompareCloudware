using CompareCloudware.Web;
using System;
using System.Runtime.CompilerServices;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CompareCloudware.Web.Models
{
    public class TermsAndConditionsModel : BaseModel
    {
        public TermsAndConditionsModel()
        {
        }

        public TermsAndConditionsModel(ICustomSession session)
        {
            base.CustomSession = session;
        }

        public List<TermConditionModel> TermsAndConditions { get; set; }

    
    }
}

