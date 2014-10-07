namespace CompareCloudware.Web.Models
{
    using CompareCloudware.Web;
    using System;
    using System.Runtime.CompilerServices;

    public class LicenceTypeMinimumModel : BaseModel
    {
        public LicenceTypeMinimumModel()
        {
        }

        public LicenceTypeMinimumModel(ICustomSession session)
        {
            base.CustomSession = session;
        }

        public int LicenceTypeMinimumID { get; set; }

        public string LicenceTypeMinimumName { get; set; }

        public int SearchFilterID { get; set; }
    }
}

