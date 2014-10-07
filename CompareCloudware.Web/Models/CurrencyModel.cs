using CompareCloudware.Web;
using System;
using System.Runtime.CompilerServices;

namespace CompareCloudware.Web.Models
{
    public class CurrencyModel : BaseModel
    {
        public CurrencyModel()
        {
        }

        public CurrencyModel(ICustomSession session)
        {
            base.CustomSession = session;
        }

        public int CurrencyID { get; set; }
        public string CurrencyShortName { get; set; }
        public string CurrencyName { get; set; }
        public string CurrencySymbol { get; set; }
        public decimal ExchangeRateSterling { get; set; }
        public bool UseExchangeRateForSorting { get; set; }
    }
}

