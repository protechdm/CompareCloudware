using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CompareCloudware.Web.Models
{
    public class ContentPageModel : BaseModel
    {
        public int ContentPageID { get; set; }
        public string Slug { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string GooglePlusId { get; set; }
        public float SortOrder { get; set; }
        public string Keywords { get; set; }
        public string Markdown { get; set; }
        public DateTime Modified { get; set; }
        public bool NoSearch { get; set; }
        public short Frequency { get; set; }
        public double? Priority { get; set; }

        public string MetaTitle { get; set; }
        public string MetaKeywords { get; set; }
        public string MetaDescription { get; set; }

        public string Route { get; set; }
    }
}
