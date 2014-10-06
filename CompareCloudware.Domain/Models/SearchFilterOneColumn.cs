using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompareCloudware.Domain.Models
{
    public interface ISearchFilterOneColumn
    {
        int SearchFilterID { get; set; }
        int SearchFilterParentID { get; set; }
        string SearchFilterNameCol1 { get; set; }
        Category CategoryCol1 { get; set; }
        FeatureType SearchFilterTypeCol1 { get; set; }
        string SearchFilterTypeNameCol1 { get; set; }
        int SearchFilterColumnNumberCol1 { get; set; }
        int SearchFilterRowNumberCol1 { get; set; }

        bool IsDataDrivenCol1 { get; set; }
        string DataDrivenFieldCol1 { get; set; }

        bool IsDataFloorDrivenCol1 { get; set; }
        bool IsDataCeilingDrivenCol1 { get; set; }
        bool IsDataFloorDrivenCol2 { get; set; }
        bool IsDataCeilingDrivenCol2 { get; set; }

        bool SuppressFilterBehaviour { get; set; }
        bool CanBeBooleanAndDataDriven { get; set; }

    }

    #region SearchFilter
    public class SearchFilterOneColumn : ISearchFilterOneColumn
    {
        public virtual int SearchFilterID { get; set; }
        public virtual int SearchFilterParentID { get; set; }
        public virtual string SearchFilterNameCol1 { get; set; }
        public virtual Category CategoryCol1 { get; set; }
        public virtual FeatureType SearchFilterTypeCol1 { get; set; }
        public virtual string SearchFilterTypeNameCol1 { get; set; }
        public virtual int SearchFilterColumnNumberCol1 { get; set; }
        public virtual int SearchFilterRowNumberCol1 { get; set; }

        public virtual bool IsDataDrivenCol1 { get; set; }
        public virtual string DataDrivenFieldCol1 { get; set; }

        public virtual bool IsDataFloorDrivenCol1 { get; set; }
        public virtual bool IsDataCeilingDrivenCol1 { get; set; }
        public virtual bool IsDataFloorDrivenCol2 { get; set; }
        public virtual bool IsDataCeilingDrivenCol2 { get; set; }

        public virtual bool SuppressFilterBehaviour { get; set; }
        public virtual bool CanBeBooleanAndDataDriven { get; set; }
    }
    #endregion
}
