using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompareCloudware.Domain.Models
{
    #region Currency
    public class Currency
    {
        public virtual int CurrencyID { get; set; }
        public virtual string CurrencyShortName { get; set; }
        public virtual string CurrencyName { get; set; }
        public virtual string CurrencySymbol { get; set; }
        public virtual decimal ExchangeRateSterling { get; set; }
        public virtual Status CurrencyStatus { get; set; }
        public virtual byte[] RowVersion { get; set; }
    }
    #endregion

}
