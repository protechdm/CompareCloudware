namespace CompareCloudware.Web.Models
{
    using CompareCloudware.Web;
    using System;
    using System.Runtime.CompilerServices;

    public class LicenceTypeMaximumModel : BaseModel
    {
        public LicenceTypeMaximumModel()
        {
        }

        public LicenceTypeMaximumModel(ICustomSession session)
        {
            base.CustomSession = session;
        }

        public int LicenceTypeMaximumID { get; set; }

        public string LicenceTypeMaximumName { get; set; }

        public int SearchFilterID { get; set; }
    }
}

