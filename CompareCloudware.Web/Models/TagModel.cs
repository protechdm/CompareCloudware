using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompareCloudware.Web.Models
{
    public class TagModel : BaseModel
    {
        public int TagID { get; set; }
        public string TagName { get; set; }
        public TagTypeModel TagType { get; set; }
        public CategoryModel Category { get; set; }
        public CloudApplicationAutoCompleteModel CloudApplicationModel { get; set; }
        //public string TagType { get; set; }
    }
}
