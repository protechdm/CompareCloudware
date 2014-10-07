using CompareCloudware.Web;
using System;
using System.Runtime.CompilerServices;
using System.Collections.Generic;

namespace CompareCloudware.Web.Models
{
    public class SearchFilterModelOneColumn : BaseModel
    {
        public SearchFilterModelOneColumn()
        {
        }

        public SearchFilterModelOneColumn(ICustomSession session)
        {
            base.CustomSession = session;
        }

        public SearchFilterModelOneColumn(ICustomSession session, bool isFromToValueBased)
        {
            base.CustomSession = session;
            IsFromToValueBased = isFromToValueBased;
        }

        public CategoryModel Category { get; set; }
        public string Col1SearchFilterName { get; set; }
        public string Col1SearchFilterType { get; set; }
        public bool Col1Selected { get; set; }
        public bool IsValueBased { get; set; }
        public string Col1Value { get; set; }
        public int SearchFilterID { get; set; }
        public int SearchFilterParentID { get; set; }
        public List<GenericValueModel> Col1Values { get; set; }

        public bool IsDataFloorDriven { get; set; }
        public bool IsDataCeilingDriven { get; set; }

        public bool SuppressFilterBehaviour { get; set; }
        public bool CanBeBooleanAndDataDriven { get; set; }

        public bool IsFromToValueBased { get; private set; }
        public string Col1ValueFrom { get; set; }
        public string Col1ValueTo { get; set; }

    }
}

