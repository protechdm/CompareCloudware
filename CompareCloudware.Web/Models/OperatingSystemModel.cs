using CompareCloudware.Web;
using System;
using System.Runtime.CompilerServices;

namespace CompareCloudware.Web.Models
{

    public class OperatingSystemModel : BaseModel
    {
        public OperatingSystemModel()
        {
        }

        public OperatingSystemModel(ICustomSession session)
        {
            base.CustomSession = session;
        }

        public virtual int OperatingSystemID { get; set; }
        public virtual string OperatingSystemName { get; set; }
    }
}

