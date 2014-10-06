using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CompareCloudware.Domain.Models;
using CompareCloudware.Domain.Contracts.Repositories;
using System.Configuration;

namespace CompareCloudware.Web.Helpers
{
    public class SiteAnalyticsProcessor
    {
        ISiteAnalyticTransactionReader _reader;
        ISiteAnalyticsLogger _logger;

        public SiteAnalyticsProcessor(ISiteAnalyticTransactionReader reader, ISiteAnalyticsLogger logger)
        {
            _reader = reader;
            _logger = logger;
        }

        public List<SiteAnalytic> GetTransactionsByDate(DateTime start, DateTime end)
        {
            List<SiteAnalytic> transactions = _reader.GetTransactionsByDate(start, end);
            //int count = raw.Length / 67;
            //List<SiteAnalyticTransaction> transactions = new List<SiteAnalyticTransaction>();
            //for (int i = 0; i < count; i++)
            //    transactions.Add(ExtractTransaction(raw, i));
            return transactions;
        }

        //private SiteAnalyticTransaction ExtractTransaction(string rawData, int transactionNumber)
        //{
        //    string transactionData = rawData.Substring(transactionNumber * 67, 67);
        //    return BuildTransaction(transactionData);
        //}

        //private SiteAnalyticTransaction BuildTransaction(string transactionData)
        //{
        //    string date = transactionData.Substring(0, 8);
        //    DateTime trxDate = DateTime.ParseExact(
        //        date, "yyyyMMdd", CultureInfo.InvariantCulture);
        //    SiteAnalyticTransaction transaction = new SiteAnalyticTransaction();
        //    transaction.SiteAnalyticDate = trxDate;
        //    transaction.ActionID = int.Parse(transactionData.Substring(9, 2).Trim());
        //    transaction.CloudApplicationID = int.Parse(transactionData.Substring(12, 5));
        //    transaction.CategoryID = int.Parse(transactionData.Substring(18, 3));
        //    transaction.PersonID = int.Parse(transactionData.Substring(22, 10));
        //    transaction.SessionID = transactionData.Substring(33, 24);
        //    transaction.FeatureID = int.Parse(transactionData.Substring(58, 4));
        //    transaction.FeatureTypeID = int.Parse(transactionData.Substring(63, 4));
        //    return transaction;
        //}

        public void Log(ICompareCloudwareRepository context, ActionType actionID, int cloudApplicationID)
        {
            _logger.Log(context, actionID, cloudApplicationID);
            //throw new NotImplementedException();
        }
    }

    public class SiteAnalyticsLogger : ISiteAnalyticsLogger
    {

        //public void Log(ITMDRepository context, ActionType actionID, int cloudApplicationID)
        //{
        //    context.AddSiteAnalytic(new SiteAnalytic()
        //    {
        //        ActionID = (int)actionID,
        //        CategoryID = 2,
        //        CloudApplicationID = cloudApplicationID,
        //        FeatureID = 4,
        //        FeatureTypeID = 5,
        //        PersonID = 6,
        //        SessionID = "abcdefg",
        //        SiteAnalyticDate = DateTime.Now,
        //    });
        //}

        private bool _loggingEnabled;
        public SiteAnalyticsLogger()
        {
            _loggingEnabled = LoggingEnabled();
        }

        public void Log(ICompareCloudwareRepository context, ActionType actionID)
        {
            AddSiteAnalytic(context, actionID, null, null, null, null, null);
        }

        public void Log(ICompareCloudwareRepository context, ActionType actionID, int cloudApplicationID)
        {
            AddSiteAnalytic(context, actionID, cloudApplicationID, null, null, null, null);
        }

        public void Log(ICompareCloudwareRepository context, ActionType actionID, int? cloudApplicationID, int categoryID)
        {
            AddSiteAnalytic(context, actionID, cloudApplicationID, categoryID, null, null, null);
        }

        public void Log(ICompareCloudwareRepository context, ActionType actionID, int? cloudApplicationID, int? categoryID, int? personID)
        {
            AddSiteAnalytic(context, actionID, cloudApplicationID, categoryID, personID, null, null);
        }

        public void Log(ICompareCloudwareRepository context, ActionType actionID, int? cloudApplicationID, int categoryID, int? personID, int featureTypeID)
        {
            AddSiteAnalytic(context, actionID, cloudApplicationID, categoryID, personID, featureTypeID, null);
        }

        public void Log(ICompareCloudwareRepository context, ActionType actionID, int? cloudApplicationID, int categoryID, int? personID, int featureTypeID, int referenceDataRowID)
        {
            AddSiteAnalytic(context, actionID, cloudApplicationID, categoryID, personID, featureTypeID, referenceDataRowID);
        }

        private void AddSiteAnalytic(ICompareCloudwareRepository context, ActionType actionID, int? cloudApplicationID, int? categoryID, int? personID, int? featureTypeID, int? referenceDataRowID)
        {
            if (!HttpContext.Current.Request.Browser.Crawler)
            {
                if (_loggingEnabled)
                {
                    if (LoggingEnabledForAction(actionID))
                    {
                        context.AddSiteAnalytic(new SiteAnalytic()
                        {
                            //SiteAnalyticType = context.FindSiteAnalyticType((int)actionID),
                            CategoryID = categoryID,
                            CloudApplicationID = cloudApplicationID,
                            ReferenceDataRowID = referenceDataRowID,
                            FeatureTypeID = featureTypeID,
                            PersonID = personID,
                            SessionID = System.Web.HttpContext.Current != null ? HttpContext.Current.Session.SessionID : "NO SESSION",
                            SiteAnalyticDate = DateTime.Now,
                            //AddDate = DateTime.Now,
                        }, (int)actionID);
                    }
                }
            }
        }

        public bool LoggingEnabled()
        {
            bool retVal = false;
            try
            {
                retVal = Convert.ToBoolean(ConfigurationManager.AppSettings["SiteAnalyticLoggingEnabled"]);
            }
            catch { }

            return retVal;
        }

        public bool LoggingEnabledForAction(ActionType actionID)
        {
            bool retVal = false;
            switch (actionID)
            {
                case ActionType.BuyFormSubmission: return Convert.ToBoolean(ConfigurationManager.AppSettings["LogBuyFormSubmission"]);
                case ActionType.ClickCaseStudy: return Convert.ToBoolean(ConfigurationManager.AppSettings["LogClickCaseStudy"]);
                case ActionType.ClickCategory: return Convert.ToBoolean(ConfigurationManager.AppSettings["LogClickCategory"]);
                case ActionType.ClickCategoryPageCompare: return Convert.ToBoolean(ConfigurationManager.AppSettings["LogClickCategoryPageCompare"]);
                case ActionType.ClickFilter: return Convert.ToBoolean(ConfigurationManager.AppSettings["LogClickFilter"]);
                case ActionType.ClickHomePageCompare: return Convert.ToBoolean(ConfigurationManager.AppSettings["LogClickHomePageCompare"]);
                case ActionType.ClickProductReview: return Convert.ToBoolean(ConfigurationManager.AppSettings["LogClickProductReview"]);
                case ActionType.ClickSearchAutoComplete: return Convert.ToBoolean(ConfigurationManager.AppSettings["LogClickSearchAutoComplete"]);
                case ActionType.ClickVideo: return Convert.ToBoolean(ConfigurationManager.AppSettings["LogClickVideo"]);
                case ActionType.ClickWhitePaper: return Convert.ToBoolean(ConfigurationManager.AppSettings["LogClickWhitePaper"]);
                case ActionType.EMailSubmission: return Convert.ToBoolean(ConfigurationManager.AppSettings["LogEMailSubmission"]);
                case ActionType.InComparisonResultsFromClickCategoryPageCompare: return Convert.ToBoolean(ConfigurationManager.AppSettings["LogInComparisonResultsFromClickCategoryPageCompare"]);
                case ActionType.InComparisonResultsFromClickHomePageCompare: return Convert.ToBoolean(ConfigurationManager.AppSettings["LogInComparisonResultsFromClickHomePageCompare"]);
                case ActionType.InViewResultsFeaturedOnCategoryPage: return Convert.ToBoolean(ConfigurationManager.AppSettings["LogInViewResultsFeaturedOnCategoryPage"]);
                case ActionType.InViewResultsFeaturedOnHomePage: return Convert.ToBoolean(ConfigurationManager.AppSettings["LogInViewResultsFeaturedOnHomePage"]);
                case ActionType.InViewResultsNewOnCategoryPage: return Convert.ToBoolean(ConfigurationManager.AppSettings["LogInViewResultsNewOnCategoryPage"]);
                case ActionType.InViewResultsNewOnHomePage: return Convert.ToBoolean(ConfigurationManager.AppSettings["LogInViewResultsNewOnHomePage"]);
                case ActionType.InViewResultsTop10OnCategoryPage: return Convert.ToBoolean(ConfigurationManager.AppSettings["LogInViewResultsTop10OnCategoryPage"]);
                case ActionType.InViewResultsTop10OnHomePage: return Convert.ToBoolean(ConfigurationManager.AppSettings["LogInViewResultsTop10OnHomePage"]);
                case ActionType.ShopVisitNonCategory: return Convert.ToBoolean(ConfigurationManager.AppSettings["LogShopVisitNonCategory"]);
                case ActionType.ShopVisitNonCategoryIdentified: return Convert.ToBoolean(ConfigurationManager.AppSettings["LogShopVisitNonCategoryIdentified"]);
                case ActionType.ShopVisitViaCategory: return Convert.ToBoolean(ConfigurationManager.AppSettings["LogShopVisitViaCategory"]);
                case ActionType.ShopVisitViaCategoryIdentified: return Convert.ToBoolean(ConfigurationManager.AppSettings["LogShopVisitViaCategoryIdentified"]);
                case ActionType.TryFormSubmission: return Convert.ToBoolean(ConfigurationManager.AppSettings["LogTryFormSubmission"]);
            }
            return retVal;
        }
    }

    public interface ISiteAnalyticTransactionReader
    {
        List<SiteAnalytic> GetTransactionsByDate(DateTime start, DateTime end);
    }

    public interface ISiteAnalyticsLogger
    {
        //public ISiteAnalyticsLogger(ITMDRepository repository);
        //void Log(ITMDRepository context, ActionType actionID, int cloudApplicationID); //1,5,6,7,8,9,10,11,14
        //void Log(ITMDRepository context, ActionType actionID, int cloudApplicationID, int categoryID); //2,15
        //void Log(ITMDRepository context, ActionType actionID, int cloudApplicationID, int personID); //3
        //void Log(ITMDRepository context, ActionType actionID, int cloudApplicationID, int categoryID, int personID); //4
        //void Log(ITMDRepository context, ActionType actionID, int personID); //12
        //void Log(ITMDRepository context, ActionType actionID, int categoryID, int personID); //13
        //void Log(ITMDRepository context, ActionType actionID, int categoryID, int featureTypeID, int featureID); //16
        //void Log(ITMDRepository context, ActionType actionID, int categoryID); //17
        //void Log(ITMDRepository context, ActionType actionID); //18

        void Log(ICompareCloudwareRepository context, ActionType actionID);
        void Log(ICompareCloudwareRepository context, ActionType actionID, int cloudApplicationID);
        void Log(ICompareCloudwareRepository context, ActionType actionID, int? cloudApplicationID, int categoryID); //2,15
        void Log(ICompareCloudwareRepository context, ActionType actionID, int? cloudApplicationID, int? categoryID, int? personID);
        void Log(ICompareCloudwareRepository context, ActionType actionID, int? cloudApplicationID, int categoryID, int? personID, int featureTypeID);
        void Log(ICompareCloudwareRepository context, ActionType actionID, int? cloudApplicationID, int categoryID, int? personID, int featureTypeID, int referenceDataRowID);
        bool LoggingEnabled();
        bool LoggingEnabledForAction(ActionType actionID);

    }

    public enum ActionType
    {
        ShopVisitNonCategory = 1,
        ShopVisitViaCategory = 2,
        ShopVisitNonCategoryIdentified = 3,
        ShopVisitViaCategoryIdentified = 4,
        TryFormSubmission = 5,
        BuyFormSubmission = 6,
        EMailSubmission = 7,
        ClickCaseStudy = 8,
        ClickWhitePaper = 9,
        ClickVideo = 10,
        ClickProductReview = 11,
        ClickHomePageCompare = 12,
        ClickCategoryPageCompare = 13,
        InComparisonResultsFromClickHomePageCompare = 14,
        InComparisonResultsFromClickCategoryPageCompare = 15,
        InViewResultsTop10OnHomePage = 16,
        InViewResultsNewOnHomePage = 17,
        InViewResultsFeaturedOnHomePage = 18,
        InViewResultsTop10OnCategoryPage = 19,
        InViewResultsNewOnCategoryPage = 20,
        InViewResultsFeaturedOnCategoryPage = 21,
        ClickFilter = 22,
        ClickCategory = 23,
        ClickSearchAutoComplete = 24,

    }
}