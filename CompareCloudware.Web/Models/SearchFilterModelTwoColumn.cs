using CompareCloudware.Web;
using System;
using System.Runtime.CompilerServices;


namespace CompareCloudware.Web.Models
{
    public class SearchFilterModelTwoColumn : BaseModel
    {
        public SearchFilterModelTwoColumn()
        {
        }

        public SearchFilterModelTwoColumn(ICustomSession session)
        {
            base.CustomSession = session;
        }

        public SearchFilterModelTwoColumn(ICustomSession session, bool isFromToValueBased)
        {
            base.CustomSession = session;
            IsFromToValueBased = isFromToValueBased;
        }

        public CategoryModel Category { get; set; }
        public string Col1SearchFilterName { get; set; }
        public string Col1SearchFilterType { get; set; }
        public bool Col1Selected { get; set; }
        public string Col1Value { get; set; }

        public string Col2SearchFilterName { get; set; }
        public string Col2SearchFilterType { get; set; }
        public bool Col2Selected { get; set; }
        public string Col2Value { get; set; }
        
        public int SearchFilterID { get; set; }
        public int SearchFilterParentID { get; set; }
        public bool SuppressFilterBehaviour { get; set; }
        public bool CanBeBooleanAndDataDriven { get; set; }

        public bool IsFromToValueBased { get; private set; }
        public string Col1ValueFrom { get; set; }
        public string Col1ValueTo { get; set; }
        public string Col2ValueFrom { get; set; }
        public string Col2ValueTo { get; set; }

    }
}

