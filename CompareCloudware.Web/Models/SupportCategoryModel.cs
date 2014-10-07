using CompareCloudware.Web;
using System;
using System.Runtime.CompilerServices;

namespace CompareCloudware.Web.Models
{

    public class SupportCategoryModel : BaseModel
    {
        public SupportCategoryModel()
        {
        }

        public SupportCategoryModel(ICustomSession session)
        {
            base.CustomSession = session;
        }

        public int SupportCategoryID { get; set; }
        public string SupportCategoryName { get; set; }
        public bool Selected { get; set; }
    }
}

