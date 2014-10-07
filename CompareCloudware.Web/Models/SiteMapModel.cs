using CompareCloudware.Web;
using System;
using System.Runtime.CompilerServices;
using System.Collections.Generic;

namespace CompareCloudware.Web.Models
{

    public class SiteMapModel : BaseModel
    {
        public SiteMapModel()
        {
            Categories = new List<SiteMapModelItem>();
            Sections = new List<SiteMapModelItem>();
            Company = new List<SiteMapModelItem>();
        }

        public SiteMapModel(ICustomSession session)
        {
            base.CustomSession = session;
            Categories = new List<SiteMapModelItem>();
            Sections = new List<SiteMapModelItem>();
            Company = new List<SiteMapModelItem>();
        }

        public List<SiteMapModelItem> Categories { get; set; }
        public List<SiteMapModelItem> Sections { get; set; }
        public List<SiteMapModelItem> Company { get; set; }

    }

    public class SiteMapModelItem : BaseModel
    {
        public SiteMapModelItem()
        {
        }

        public SiteMapModelItem(ICustomSession session)
        {
            base.CustomSession = session;
        }

        public int SiteMapModelItemID { get; set; }
        public string SiteMapModelItemText { get; set; }
        public string SiteMapModelItemURL { get; set; }
    }

}

