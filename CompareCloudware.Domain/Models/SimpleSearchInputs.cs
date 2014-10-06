using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompareCloudware.Domain.Models
{
    #region SimpleSearchInputs
    public class SimpleSearchInputs
    {
        //public virtual List<Category> Categories { get; set; }
        //public virtual List<OperatingSystem> OperatingSystems { get; set; }
        //public virtual string Name { get; set; }
        //public virtual string EMailAddress { get; set; }

        public List<Category> Categories { get; set; }
        public List<OperatingSystem> OperatingSystems { get; set; }
        public string Name { get; set; }
        public string EMailAddress { get; set; }

    }
    #endregion

}
