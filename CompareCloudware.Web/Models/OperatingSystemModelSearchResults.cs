using CompareCloudware.Web;
using System;
using System.Runtime.CompilerServices;

namespace CompareCloudware.Web.Models
{
    public class OperatingSystemModelSearchResults : BaseModel
    {
        public OperatingSystemModelSearchResults()
        {
        }

        public OperatingSystemModelSearchResults(ICustomSession session)
        {
            base.CustomSession = session;
        }

        public virtual int OperatingSystemID { get; set; }
        public virtual string OperatingSystemName { get; set; }
    }
}

