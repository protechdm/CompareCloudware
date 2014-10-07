using CompareCloudware.Web;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace CompareCloudware.Web.Models
{
    public class CloudApplicationModelAlternative : BaseModel
    {
        public CloudApplicationModelAlternative()
        {
        }

        public CloudApplicationModelAlternative(ICustomSession session)
        {
            base.CustomSession = session;
        }


        public string Brand { get; set; }
        [Display(Name="Buy now"), DataType(DataType.Text)]
        public int CloudApplicationID { get; set; }
        public byte[] CloudApplicationLogo { get; set; }
        public string CompanyURL { get; set; }
        public string Description { get; set; }
        public string ServiceName { get; set; }
        public string Title { get; set; }
        public VendorModel Vendor { get; set; }
        public bool VideoTrainingSupport { get; set; }

        public string CloudApplicationCategoryTag { get; set; }
        public string CloudApplicationShopTag { get; set; }

    }
}

