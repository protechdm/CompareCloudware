using CompareCloudware.Web;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using CompareCloudware.Web.Validation;
using System.Collections.Generic;
using System.Configuration;
using CompareCloudware.Web.Helpers;

namespace CompareCloudware.Web.Models
{

    public class PartnerProgrammeModel : BaseModel
    {
        public PartnerProgrammeModel()
        {
        }

        public PartnerProgrammeModel(ICustomSession session)
        {
            base.CustomSession = session;
        }


        public CompareCloudware.Web.Models.TabbedOnpageOptimisationModel TabbedOnpageOptimisationModel { get; set; }
        public ContentTextsModel H1H2ContentText { get; set; }
        public ContentTextsModel ContentTextsModel { get; set; }

        public string HeaderStrap { get; set; }
        public bool ShowHeaderStrapImage { get; set; }

        public CarouselModel CarouselSocial { get; set; }



    }
}

