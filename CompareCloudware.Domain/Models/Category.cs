using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompareCloudware.Domain.Models
{
    #region Category
    public class Category
    {
        //public virtual int CategoryID { get; set; }
        //public virtual string CategoryName { get; set; }
        //public virtual byte[] RowVersion { get; set; }
        //public virtual List<Feature> CategoryFeatures { get; set; }
        //public virtual List<CloudApplication> CloudApplications { get; set; }

        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public virtual Status CategoryStatus { get; set; }
        public byte[] RowVersion { get; set; }
        public List<Feature> CategoryFeatures { get; set; }
        public List<CloudApplication> CloudApplications { get; set; }
    }
    #endregion
}
