using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompareCloudware.Domain.Models
{
    #region HomePage
    public class HomePage
    {
        //public virtual SimpleSearchInputs SimpleSearchInputs { get; set; }
        //public virtual TabbedSearchResults TabbedSearchResults { get; set; }

        public SimpleSearchInputs SimpleSearchInputs { get; set; }
        public TabbedSearchResults TabbedSearchResults { get; set; }

    }
    #endregion

}
