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
        //public IList<ContentTextModel> Tab4 { get; set; }

        public bool Tab1Visible { get; set; }
        public bool Tab2Visible { get; set; }
        public bool Tab3Visible { get; set; }
        public bool Tab4Visible { get; set; }
        public bool CategoryBasedContentText { get; set; }
        public int? CategoryID { get; set; }

        public OnpageOptimisationTabModel OnpageOptimisationTab1 { get; set; }
        public OnpageOptimisationTabModel OnpageOptimisationTab2 { get; set; }
        public OnpageOptimisationTabModel OnpageOptimisationTab3 { get; set; }
        public OnpageOptimisationTabModel OnpageOptimisationTab4 { get; set; }

        public string Tab1Title { get; set; }
        public string Tab2Title { get; set; }
        public string Tab3Title { get; set; }
        public string Tab4Title { get; set; }

    }
}

