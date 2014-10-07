namespace CompareCloudware.Web.Models
{
    using CompareCloudware.Web;
    using System;
    using System.Runtime.CompilerServices;

    public class CategoryModel : BaseModel
    {
        public CategoryModel()
        {
        }

        public CategoryModel(ICustomSession session)
        {
            base.CustomSession = session;
        }

        public int CategoryID { get; set; }

        public string CategoryName { get; set; }

        public int SearchFilterID { get; set; }

        public bool Selected { get; set; }
    }
}

