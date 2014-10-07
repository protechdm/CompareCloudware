using CompareCloudware.Web;
using System;
using System.Runtime.CompilerServices;

namespace CompareCloudware.Web.Models
{
    public class ContentTextTypeModel : BaseModel
    {
        public ContentTextTypeModel()
        {
        }

        public ContentTextTypeModel(ICustomSession session)
        {
            base.CustomSession = session;
        }

        public int ContentTextTypeID { get; set; }
        public string ContentTextTypeName { get; set; }
    }
}

