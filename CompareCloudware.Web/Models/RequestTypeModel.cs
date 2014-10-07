using CompareCloudware.Web;
using System;
using System.Runtime.CompilerServices;

namespace CompareCloudware.Web.Models
{
    public class RequestTypeModel : BaseModel
    {
        public RequestTypeModel()
        {
        }

        public RequestTypeModel(ICustomSession session)
        {
            base.CustomSession = session;
        }

        public int RequestTypeID { get; set; }
        public string RequestTypeName { get; set; }
        public bool Selected { get; set; }
    }
}

