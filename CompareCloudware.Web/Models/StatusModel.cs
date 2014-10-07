using CompareCloudware.Web;
using System;
using System.Runtime.CompilerServices;

namespace CompareCloudware.Web.Models
{
    public class StatusModel : BaseModel
    {
        public StatusModel()
        {
        }

        public StatusModel(ICustomSession session)
        {
            base.CustomSession = session;
        }

        public int StatusID { get; set; }
        public string StatusName { get; set; }
    }
}

