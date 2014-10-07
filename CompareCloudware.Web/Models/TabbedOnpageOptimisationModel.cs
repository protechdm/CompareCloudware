using CompareCloudware.Web;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CompareCloudware.Web.Models
{
    public class TabbedOnpageOptimisationModel : BaseModel
    {
        public TabbedOnpageOptimisationModel()
        {
        }

        public TabbedOnpageOptimisationModel(ICustomSession session)
        {
            base.CustomSession = session;
        }

        public IList<ContentTextModel> Tab1 { get; set; }
        public IList<ContentTextModel> Tab2 { get; set; }
        public IList<ContentTextModel> Tab3 { get; set; }
        public bool Tab1Visible { get; set; }
        public bool Tab2Visible { get; set; }
        public bool Tab3Visible { get; set; }
        public bool CategoryBasedContentText { get; set; }
        public int? CategoryID { get; set; }

        public OnpageOptimisationTab1Model OnpageOptimisationTab1 { get; set; }
        public OnpageOptimisationTab1Model OnpageOptimisationTab2 { get; set; }
        public OnpageOptimisationTab1Model OnpageOptimisationTab3 { get; set; }

        public string Tab1Title { get; set; }
        public string Tab2Title { get; set; }
        public string Tab3Title { get; set; }

    }
}

