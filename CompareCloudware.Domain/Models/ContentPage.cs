using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompareCloudware.Domain.Models
{
    public class ContentPage
    {
        public virtual int ContentPageID { get; set; }
        public virtual string Slug { get; set; }
        public virtual string Title { get; set; }
        public virtual string Author { get; set; }
        public virtual string GooglePlusId { get; set; }
        public virtual float SortOrder { get; set; }
        public virtual string Keywords { get; set; }
        public virtual string Markdown { get; set; }
        public virtual DateTime Modified { get; set; }
        public virtual bool NoSearch { get; set; }
        public virtual SiteMapFrequencyEnum Frequency { get; set; }
        public virtual double? Priority { get; set; }

        public virtual string MetaTitle { get; set; }
        public virtual string MetaKeywords { get; set; }
        public virtual string MetaDescription { get; set; }

        public virtual string Route { get; set; }
        public virtual byte[] RowVersion { get; set; }
    }
}
