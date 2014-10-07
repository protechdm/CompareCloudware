using CompareCloudware.Web;
using System;
using System.Runtime.CompilerServices;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CompareCloudware.Web.Models
{
    public class ContentTextsModel : BaseModel
    {
        public ContentTextsModel()
        {
        }

        public ContentTextsModel(ICustomSession session)
        {
            base.CustomSession = session;
        }

        public List<ContentTextModel> ContentTexts { get; set; }

        public bool CloudwareExplainedVisible { get; set; }
        public bool TenReasonsForUsingCloudwareVisible { get; set; }
        public bool WhatDoesMyBusinessNeedToRunCloudwareVisible { get; set; }

        public bool AboutUsVisible { get; set; }
        public bool ManagementTeamVisible { get; set; }
        public bool VisionVisible { get; set; }
        public bool FAQsVisible { get; set; }
        public bool CareersVisible { get; set; }
        public bool PressVisible { get; set; }
        public bool ContactUsVisible { get; set; }

        public int ActiveTab { get; set; }
    
    }
}

