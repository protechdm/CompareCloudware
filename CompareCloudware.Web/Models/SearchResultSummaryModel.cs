namespace CompareCloudware.Web.Models
{
    using CompareCloudware.Web;
    using CompareCloudware.Web.Helpers;
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    public class SearchResultSummaryModel : BaseModel, IComparable
    {
        public SearchResultSummaryModel()
        {
        }

        public SearchResultSummaryModel(ICustomSession session)
        {
            base.CustomSession = session;
        }

        public decimal ApplicationCostOneOff { get; set; }

        public decimal ApplicationCostPerAnnum { get; set; }
        public decimal ApplicationCostPerAnnumFrom { get; set; }
        public decimal ApplicationCostPerAnnumTo { get; set; }
        public bool ApplicationCostPerAnnumPOA { get; set; }
        public bool ApplicationCostPerAnnumOffered { get; set; }
        public bool ApplicationCostPerAnnumFree { get; set; }
        public bool ApplicationCostPerAnnumIsForUnlimitedUsers { get; set; }

        public decimal ApplicationCostPerMonth { get; set; }
        public decimal ApplicationCostPerMonthFrom { get; set; }
        public decimal ApplicationCostPerMonthTo { get; set; }
        public string ApplicationCostPerMonthExtra { get; set; }
        public bool ApplicationCostPerMonthPOA { get; set; }
        public bool ApplicationCostPerMonthOffered { get; set; }
        public bool ApplicationCostPerMonthFree { get; set; }
        public bool ApplicationCostPerMonthIsForUnlimitedUsers { get; set; }

        public bool PayAsYouGo { get; set; }

        public decimal CallsPackageCostPerMonth { get; set; }
        public List<CloudApplicationFeatureModel> CloudApplicationFeatures { get; set; }
        public int CloudApplicationID { get; set; }
        public string Description { get; set; }
        public string FreeTrialPeriod { get; set; }
        public bool IsLastInCollectionSummary { get; set; }
        public List<LanguageModel> Languages { get; set; }
        public List<OperatingSystemModelSearchResults> OperatingSystems { get; set; }
        public List<DeviceModel> Devices { get; set; }
        public SearchResultDisplayFormat ResultDisplayFormat { get; set; }
        public int SearchResultID { get; set; }
        public string ServiceName { get; set; }
        public string SetupFee { get; set; }
        public SupportDaysModel SupportDays { get; set; }
        public SupportHoursModel SupportHours { get; set; }
        public List<SupportTypeModel> SupportTypes { get; set; }
        public int VendorID { get; set; }
        public byte[] VendorLogo { get; set; }
        public string VendorLogoURL { get; set; }
        public string VendorName { get; set; }

        public string CloudApplicationCategoryTag { get; set; }
        public string CloudApplicationShopTag { get; set; }

        public CurrencyModel Currency { get; set; }

        public bool DemoOffered { get; set; }

        #region CompareTo
        public int CompareTo(object obj)
        {
            return 0;
            //throw new NotImplementedException();
        }
        #endregion

        #region CompareToPrice
        public int CompareToPrice(SearchResultSummaryModel s2, ComparisonType comparisonMethod)
        {

            //string whichPrice = "MONTHLY";
            //SearchResultModelOneColumn stringA = (SearchResultModelOneColumn)objStringA;
            //SearchResultModelOneColumn stringB = (SearchResultModelOneColumn)objStringB;

            int retVal = -2;
            bool normalMonthlyPriceThis = false;
            bool normalAnnualPriceThis = false;
            bool POAMonthlyThis = false;
            bool POAAnnualThis = false;
            bool PAYGThis = false;
            bool normalPriceMonthlyCompareAgainst = false;
            bool normalPriceAnnualCompareAgainst = false;
            bool POAMonthlyCompareAgainst = false;
            bool POAAnnualCompareAgainst = false;
            bool PAYGCompareAgainst = false;

            if (!s2.ApplicationCostPerMonthPOA && !s2.PayAsYouGo)
            {
                normalPriceMonthlyCompareAgainst = true;
            }
            if (s2.ApplicationCostPerMonthPOA)
            {
                POAMonthlyCompareAgainst = true;
            }
            if (s2.PayAsYouGo)
            {
                PAYGCompareAgainst = true;
            }
            if (!ApplicationCostPerMonthPOA && !PayAsYouGo)
            {
                normalMonthlyPriceThis = true;
            }
            if (ApplicationCostPerMonthPOA)
            {
                POAMonthlyThis = true;
            }
            if (PayAsYouGo)
            {
                PAYGThis = true;
            }

            if (!s2.ApplicationCostPerAnnumPOA && !s2.PayAsYouGo)
            {
                normalPriceAnnualCompareAgainst = true;
            }
            if (!ApplicationCostPerAnnumPOA && !PayAsYouGo)
            {
                normalAnnualPriceThis = true;
            }
            if (ApplicationCostPerAnnumPOA)
            {
                POAAnnualThis = true;
            }
            if (s2.ApplicationCostPerAnnumPOA)
            {
                POAAnnualCompareAgainst = true;
            }

            switch (comparisonMethod)
            {

                case ComparisonType.MonthlyAscending:

                    #region MONTHLY ASCENDING
                    if (normalMonthlyPriceThis && normalPriceMonthlyCompareAgainst)
                    {
                        if (ApplicationCostPerMonth >= s2.ApplicationCostPerMonth)
                        {
                            retVal = 1;
                        }
                        else
                        {
                            retVal = -1;
                        }
                    }
                    else
                    {
                        //at least one of the terms is either POA or PAYG
                        if (normalMonthlyPriceThis)
                        {
                            retVal = -1;
                        }
                        else
                        {
                            if ((PAYGThis && PAYGCompareAgainst) || (POAMonthlyThis && POAMonthlyCompareAgainst))
                            {
                                retVal = 0;
                            }
                            else
                            {
                                //one of the terms is either POA or PAYG
                                if (POAMonthlyThis || POAMonthlyCompareAgainst)
                                {
                                    if (POAMonthlyThis)
                                    {
                                        retVal = 1;
                                    }
                                }
                                if (PAYGThis && !PAYGCompareAgainst)
                                {
                                    if (POAMonthlyCompareAgainst)
                                    {
                                        retVal = -1;
                                    }
                                    else
                                    {
                                        retVal = 0;
                                    }
                                }
                                if (!PAYGThis && PAYGCompareAgainst)
                                {
                                    if (POAMonthlyThis)
                                    {
                                        retVal = 1;
                                    }
                                    else
                                    {
                                        retVal = 0;
                                    }
                                }
                            }
                        }
                    }
                    #endregion
                    break;
                case ComparisonType.MonthlyDescending:

                    #region MONTHLY DESCENDING
                    if (normalMonthlyPriceThis && normalPriceMonthlyCompareAgainst)
                    {
                        if (ApplicationCostPerMonth <= s2.ApplicationCostPerMonth)
                        {
                            retVal = 1;
                        }
                        else
                        {
                            retVal = -1;
                        }
                    }
                    else
                    {
                        //at least one of the terms is either POA or PAYG
                        if (normalMonthlyPriceThis)
                        {
                            retVal = -1;
                        }
                        else
                        {
                            if ((PAYGThis && PAYGCompareAgainst) || (POAMonthlyThis && POAMonthlyCompareAgainst))
                            {
                                retVal = 0;
                            }
                            else
                            {
                                //one of the terms is either POA or PAYG
                                if (POAMonthlyThis || POAMonthlyCompareAgainst)
                                {
                                    if (POAMonthlyThis)
                                    {
                                        retVal = 1;
                                    }
                                }
                                if (PAYGThis && !PAYGCompareAgainst)
                                {
                                    if (POAMonthlyCompareAgainst)
                                    {
                                        retVal = -1;
                                    }
                                    else
                                    {
                                        retVal = 0;
                                    }
                                }
                                if (!PAYGThis && PAYGCompareAgainst)
                                {
                                    if (POAMonthlyThis)
                                    {
                                        retVal = 1;
                                    }
                                    else
                                    {
                                        retVal = 0;
                                    }
                                }
                            }
                        }
                    }
                    #endregion
                    break;
                case ComparisonType.AnnualAscending:

                    #region ANNUAL ASCENDING
                    if (normalAnnualPriceThis && normalPriceAnnualCompareAgainst)
                    {
                        if (ApplicationCostPerAnnum >= s2.ApplicationCostPerAnnum)
                        {
                            retVal = 1;
                        }
                        else
                        {
                            retVal = -1;
                        }
                    }
                    else
                    {
                        //at least one of the terms is either POA or PAYG
                        if (normalAnnualPriceThis)
                        {
                            retVal = -1;
                        }
                        else
                        {
                            if ((PAYGThis && PAYGCompareAgainst) || (POAAnnualThis && POAAnnualCompareAgainst))
                            {
                                retVal = 0;
                            }
                            else
                            {
                                //one of the terms is either POA or PAYG
                                if (POAAnnualThis || POAAnnualCompareAgainst)
                                {
                                    if (POAAnnualThis)
                                    {
                                        retVal = 1;
                                    }
                                }
                                if (PAYGThis && !PAYGCompareAgainst)
                                {
                                    if (POAAnnualCompareAgainst)
                                    {
                                        retVal = -1;
                                    }
                                    else
                                    {
                                        retVal = 0;
                                    }
                                }
                                if (!PAYGThis && PAYGCompareAgainst)
                                {
                                    if (POAAnnualThis)
                                    {
                                        retVal = 1;
                                    }
                                    else
                                    {
                                        retVal = 0;
                                    }
                                }
                            }
                        }
                    }
                    #endregion
                    break;
                default:

                    #region ANNUAL DESCENDING
                    if (normalAnnualPriceThis && normalPriceAnnualCompareAgainst)
                    {
                        if (ApplicationCostPerAnnum <= s2.ApplicationCostPerAnnum)
                        {
                            retVal = 1;
                        }
                        else
                        {
                            retVal = -1;
                        }
                    }
                    else
                    {
                        //at least one of the terms is either POA or PAYG
                        if (normalAnnualPriceThis)
                        {
                            retVal = -1;
                        }
                        else
                        {
                            if ((PAYGThis && PAYGCompareAgainst) || (POAAnnualThis && POAAnnualCompareAgainst))
                            {
                                retVal = 0;
                            }
                            else
                            {
                                //one of the terms is either POA or PAYG
                                if (POAAnnualThis || POAAnnualCompareAgainst)
                                {
                                    if (POAAnnualThis)
                                    {
                                        retVal = 1;
                                    }
                                }
                                if (PAYGThis && !PAYGCompareAgainst)
                                {
                                    if (POAAnnualCompareAgainst)
                                    {
                                        retVal = -1;
                                    }
                                    else
                                    {
                                        retVal = 0;
                                    }
                                }
                                if (!PAYGThis && PAYGCompareAgainst)
                                {
                                    if (POAAnnualThis)
                                    {
                                        retVal = 1;
                                    }
                                    else
                                    {
                                        retVal = 0;
                                    }
                                }
                            }
                        }
                    }
                    #endregion
                    break;
            }
            if (retVal == -2)
            {
                retVal = 0;
            }
            return retVal;
        }
        #endregion

    }

    #region PriceComparer
    //public class PriceComparer : IComparer<Object>
    public class PriceComparerSummary : IComparer<SearchResultSummaryModel>
    {
        private ComparisonType _comparisonType;

        public ComparisonType ComparisonMethod
        {
            get { return _comparisonType; }
            set { _comparisonType = value; }
        }

        //public int Compare(object x, object y)
        public int Compare(SearchResultSummaryModel x, SearchResultSummaryModel y)
        {
            SearchResultSummaryModel s1 = x as SearchResultSummaryModel;
            SearchResultSummaryModel s2 = y as SearchResultSummaryModel;
            int retVal = s1.CompareToPrice(s2, _comparisonType);
            return retVal;

            //if (whichPrice == "MONTHLY")
            //{
            //}
            //if (whichPrice == "ANNUAL")
            //{
            //    if (stringA.ApplicationCostPerAnnumPOA && !stringB.ApplicationCostPerAnnumPOA)
            //    {
            //        retVal = 1;
            //    }
            //    if (!stringA.ApplicationCostPerAnnumPOA && stringB.ApplicationCostPerAnnumPOA)
            //    {
            //        retVal = -1;
            //    }
            //    if (!stringA.ApplicationCostPerAnnumPOA && !stringB.ApplicationCostPerAnnumPOA)
            //    {
            //        if (stringA.ApplicationCostPerAnnum > stringB.ApplicationCostPerAnnum)
            //        {
            //            retVal = 1;
            //        }
            //        else
            //        {
            //            retVal = -1;
            //        }
            //    }
            //    if (stringA.ApplicationCostPerAnnumPOA && stringB.ApplicationCostPerAnnumPOA)
            //    {
            //        retVal = 0;
            //    }
            //}
            //else
            //{
            //    retVal = 0;
            //}
            //return retVal;

            //String[] valueA = stringA.ToString().Split('/');
            //String[] valueB = stringB.ToString().Split('/');

            //if (valueA.Length != 2 || valueB.Length != 2)
            //    return String.Compare(stringA.ToString(), stringB.ToString());

            //if (valueA[0] == valueB[0])
            //{
            //    return String.Compare(valueA[1], valueB[1]);
            //}
            //else
            //{
            //    return String.Compare(valueA[0], valueB[0]);
            //}

        }

    }
    #endregion

}

