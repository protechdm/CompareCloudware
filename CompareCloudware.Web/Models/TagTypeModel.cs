using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompareCloudware.Web.Models
{
    public class TagTypeModel : BaseModel
    {
        public virtual int TagTypeID { get; set; }
        public virtual string TagTypeName { get; set; }
    }
}
