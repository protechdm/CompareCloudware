using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CompareCloudware.Domain.Models;
using System.Web;
//using System.Data.Objects;
using System.Data.Entity.Core.Objects;
using System.Data.Entity;
using System.Data.Entity.Core;

namespace CompareCloudware.Domain.Contracts.Repositories
{
    public interface ICompareCloudwareRepository : IBaseRepository
    {
        IList<SearchFilterOneColumn> GetFiltersOneColumn(int categoryID, int numberOfUsers);
        IList<SearchFilterTwoColumn> GetFiltersTwoColumn(int categoryID, int numberOfUsers);
        IList<Category> GetCategories();
        IList<SupportDays> GetSupportDays();

        IList<Domain.Models.TimeZone> GetTimeZones();
        IList<Domain.Models.TimeZone> GetTimeZones(bool filterPredicatesOnly);
        IList<Domain.Models.TimeZone> GetTimeZones(int categoryID);
        Domain.Models.TimeZone GetTimeZone(int timeZoneID);
        
        IList<Domain.Models.OperatingSystem> GetOperatingSystems();
        IList<SearchResult> GetFeaturedCloudware(int count, bool liveApplicationsOnly);
        IList<SearchResult> GetTopTenCloudware(int count, bool liveApplicationsOnly);
        IList<SearchResult> GetNewCloudware(int count, bool liveApplicationsOnly);
        IList<SearchResult> GetFeaturedCloudware(int categoryID, int count, bool liveApplicationsOnly);
        IList<SearchResult> GetTopTenCloudware(int categoryID, int count, bool liveApplicationsOnly);
        IList<SearchResult> GetNewCloudware(int categoryID, int count, bool liveApplicationsOnly);
        IList<SearchFilterOneColumn> GetSearchOptionsOneColumn(int categoryID);
        IList<SearchFilterTwoColumn> GetSearchOptionsTwoColumn(int categoryID);
        IList<CloudApplication> GetSearchResults(System.Linq.Expressions.Expression<Func<CloudApplication, bool>> predicate, bool liveApplicationsOnly);
        
        CloudApplication GetCloudApplication(int cloudApplicationID, bool pingSocialNetworks);
        CloudApplication GetCloudApplication(int cloudApplicationID, bool pingSocialNetworks, bool liveOnly);
        CloudApplication GetCloudApplication(int cloudApplicationID, bool pingSocialNetworks, bool liveOnly, RefreshMode refreshMode);
        CloudApplication GetCloudApplicationAsReadOnly(int cloudApplicationID);
        
        IQueryable<CloudApplication> GetCloudApplications(int vendorID);
        IQueryable<CloudApplication> GetCloudApplications(int vendorID, int categoryID, bool liveOnly);
        
        IList<CloudApplication> GetCloudApplicationsByVendor(int vendorID);
        IList<CloudApplication> GetCloudApplicationsByVendor(int vendorID, int categoryID, bool liveOnly);
        
        CloudApplicationDocument GetCloudApplicationDocument(int documentID);
        CloudApplicationDocumentImage GetCloudApplicationDocumentImage(int documentID);
        AdvertisingImage GetAdvertisingImage(int advertisingImageID, int? categoryID);
        AdvertisingImage GetAdvertisingImage(int advertisingImageID, string advertSize, int? categoryID);
        AdvertisingImage GetAdvertisingImage(int advertisingImageID, string advertSize, int? categoryID, bool liveOnly);

        Vendor FindVendorByID(int vendorID);
        Vendor FindVendorByCloudApplicationID(int cloudApplicationID);
        IList<Vendor> FindVendorsByName(string vendorName);
        IList<Vendor> GetAllVendors();

        //bool InsertCase(string userId, string hostAddress, string hostName, string insertAction, Case model);
        //QueueAndUserID GetQueueAndUserIDBasedOnRA(Case inputCase, string country, string invoiceNumber);
        //IList<User> GetUsers(string EMailAddress, string passWord);
        //IList<User> GetUsers(string EMailAddress);
        //IList<User> GetUsers();
        IList<NumberOfUsers> GetNumberOfUsers(bool includeZero);
        //bool InsertUser(User model);
        //IList<Case> GetCases();
        //IList<Case> GetCases(string user);
        //Case GetCase(string caseNumber);
        IList<Tag> GetTags(string searchText);
        IList<TagResult> GetApplicationsFromTags(string searchText, bool liveApplicationsOnly);
        IEnumerable<CloudApplication> GetSearchResultsFromTags(string searchText, bool liveApplicationsOnly);
        IList<ContentText> GetContentData(int[] IDs);
        IList<ContentText> GetContentData(string keyTitle, string keyBody);
        IList<ContentText> GetContentData(string[] IDs);
        IList<TermCondition> GetTermsOfUseData(string policyType);
        ContentText FindContentTextByID(int contentTextID);
        ContentTextType FindContentTextTypeByName(string contentTextTypeName);

        Person GetPersonByEMail(string eMail);
        Person GetPersonByPersonID(int personID);
        Person GetPerson(string forename, string surname, string eMail, int numberOfUsers);
        Person GetPerson(string forename, string surname, string eMail, int numberOfUsers, string telephone, string company, string position);
        Person GetPerson(string forename, string surname, string eMail, string country, string telephone, string company, string position, bool isInUserGroup);
        Person GetPerson(string eMail, bool isInUserGroup);

        CloudApplicationRequest GetCloudApplicationRequest(int cloudApplicationRequestID);
        CloudApplicationRequest GetCloudApplicationRequestByPersonID(int personID);
        bool LogSiteActivity(HttpRequestBase request);
        //bool LogError(string message);
        bool InsertUserReview(CloudApplicationUserReview rating);
        //bool AddPerson(Person person);
        IList<RequestType> GetRequestTypes();
        bool AddRequestType(RequestType rt);
        RequestType GetRequestTypeByRequestTypeName(string requestTypeName);

        bool AddIndustry(Industry i);
        IList<Industry> GetIndustries();
        Industry GetIndustry(int industryID);

        IList<CloudApplicationRequest> GetUnservicedCloudApplicationRequests();
        IList<CloudApplicationRequest> GetUnservicedCloudApplicationPDFRequests();
        IList<CloudApplicationRequest> GetUnservicedCloudApplicationTryBuyRequests();
        IList<CloudApplicationRequest> GetUnservicedBusinessPartnerRequests();
        IList<CloudApplicationRequest> GetUnservicedStrategicPartnerRequests();
        IList<CloudApplicationRequest> GetUnservicedReferRewardRequests();
        IList<CloudApplicationRequest> GetUnservicedSendToColleagueRequests();
        Colleague FindRecommender(int colleaguePersonID);
        IList<WEBAPICloudApplicationRequest> GetWEBAPICloudApplicationRequests(DateTime startDate, DateTime endDate);

        bool MarkCloudApplicationRequestAsServiced(int cloudApplicationRequestID);
        bool MarkCloudApplicationRequestAsServicing(int cloudApplicationRequestID);
        SupportDays GetSupportDay(int supportDaysID);

        IList<SupportHours> GetSupportHours();
        IList<SupportHours> GetSupportHoursAll();
        SupportHours GetSupportHour(int supportHoursID);
        IList<SupportHours> GetSupportHours(int categoryID);

        
        IList<GenericSingleValue> GetValuesForFeature(Type entityType, string featureName, int categoryID);
        CategoryParameters GetCategoryParameters(int categoryID);

        IList<Device> GetDevices();
        IList<MobilePlatform> GetMobilePlatforms();
        IList<Browser> GetBrowsers();
        IList<Language> GetLanguages();
        IList<SupportType> GetSupportTypes();
        IList<SupportTerritory> GetSupportTerritories();
        IList<PaymentOption> GetPaymentOptions();
        IList<FreeTrialPeriod> GetFreeTrialPeriods();
        IList<MinimumContract> GetMinimumContracts();
        IList<PaymentFrequency> GetPaymentFrequencies();
        Browser FindBrowserByName(string browserName);
        Category FindCategoryByName(string categoryName);
        Category FindCategoryByID(int categoryID);
        Device FindDeviceByName(string deviceName);
        Language FindLanguageByName(string languageName);
        MobilePlatform FindMobilePlatformByName(string mobilePlatformName);
        Domain.Models.OperatingSystem FindOperatingSystemByName(string operatingSystemName);
        PaymentOption FindPaymentOptionByName(string paymentOptionName);
        SupportTerritory FindSupportTerritoryByName(string supportTerritoryName);
        SupportTerritory FindSupportTerritoryByID(int supportTerritoryID);

        FreeTrialPeriod FindFreeTrialPeriodByName(string freeTrialPeriodName);
        FreeTrialPeriod FindFreeTrialPeriodByID(int freeTrialPeriodID);
        
        LicenceTypeMaximum FindLicenceTypeMaximumByName(int licenceTypeMaximumName);
        LicenceTypeMaximum FindLicenceTypeMaximumByName(int licenceTypeMaximumName, bool ignoreException);
        LicenceTypeMaximum FindLicenceTypeMaximumByID(int licenceTypeMaximumID);
        
        LicenceTypeMinimum FindLicenceTypeMinimumByName(int licenceTypeMinimumName);
        LicenceTypeMinimum FindLicenceTypeMinimumByName(int licenceTypeMinimumName, bool ignoreException);
        LicenceTypeMinimum FindLicenceTypeMinimumByID(int licenceTypeMinimumID);
        
        MinimumContract FindMinimumContractByName(string minimumContractName);
        MinimumContract FindMinimumContractByID(int minimumContractID);
        PaymentFrequency FindPaymentFrequencyByName(string paymentFrequencyName);
        PaymentFrequency FindPaymentFrequencyByID(int paymentFrequencyID);
        
        SupportDays FindSupportDaysByName(string supportDaysName);
        SupportDays FindSupportDaysByName(string supportDaysName, bool ignoreException);

        SupportHours FindSupportHoursByName(string supportHoursName);
        SupportHours FindSupportHoursByName(int supportHoursFrom, int supportHoursTo);
        SupportHours FindSupportHoursByID(int supportHoursID);

        SupportType FindSupportTypeByID(int supportTypeID);
        SupportType FindSupportTypeByName(string supportTypeName);
        SupportType FindSupportTypeByName(string supportTypeName, bool exactMatch);

        Domain.Models.TimeZone FindTimeZoneByName(string timeZoneName);
        Domain.Models.TimeZone FindTimeZoneByID(int timeZoneID);

        IList<Feature> GetFeatures(int categoryID);
        IList<Feature> GetApplications(int categoryID);

        CloudApplicationFeature FindFeatureByName(string featureName);
        CloudApplicationFeature FindFeatureByName(string featureName, int categoryID);
        CloudApplicationFeature FindFeatureByName(string featureName, int categoryID, bool exactMatch);

        CloudApplicationFeature FindCloudApplicationFeatureByName(string featureName);
        CloudApplicationFeature FindCloudApplicationFeatureByName(string featureName, int categoryID);
        CloudApplicationFeature FindCloudApplicationFeatureByName(string featureName, int cloudApplicationID, int categoryID, bool exactMatch);

        CloudApplicationApplication FindApplicationByName(string applicationName);
        CloudApplicationApplication FindApplicationByName(string applicationName, int categoryID);
        CloudApplicationApplication FindApplicationByName(string applicationName, int categoryID, bool exactMatch);

        CloudApplicationApplication FindCloudApplicationApplicationByName(string applicationName);
        CloudApplicationApplication FindCloudApplicationApplicationByName(string applicationName, int categoryID);
        CloudApplicationApplication FindCloudApplicationApplicationByName(string applicationName, int cloudApplicationID, int categoryID, bool exactMatch);

        FeatureType FindFeatureTypeByName(string featureTypeName);

        SetupFee FindSetupFeeByName(string setupFeeName);

        IList<Currency> GetCurrencies();
        Currency GetCurrencyBySymbol(string currencySymbol);
        Currency GetCurrencyByShortName(string shortName);
        Currency FindCurrencyByID(int currencyID);

        CloudApplication GetCloudApplicationContextAdded();
        CloudApplication GetCloudApplicationContextModified();

        void AddCloudApplication(CloudApplication ca);
        void UpdateCloudApplication(CloudApplication ca);
        bool AddCurrency(Currency cur);

        //IList<string> GetVideoExtensions();
        //IList<string> GetVideoDomains();
        //string[,] GetDocumentFileFormats();
        //string[,] GetDocumentTypes();
        CloudApplicationDocumentType FindCloudApplicationDocumentTypeByName(string documentTypeName);
        CloudApplicationDocumentFormat FindCloudApplicationDocumentFormatByShortName(string documentFormatShortName);

        void AddCloudApplicationDocumentType(CloudApplicationDocumentType dt);
        void AddCloudApplicationDocument(CloudApplicationDocument cad);
        void AddCloudApplicationDocumentFormat(CloudApplicationDocumentFormat df);

        IList<CloudApplicationFeature> GetCloudApplicationFeatures(int cloudApplicationID);
        IList<CloudApplicationApplication> GetCloudApplicationApplications(int cloudApplicationID);

        bool AddSupportDays(SupportDays sd);
        bool AddLicenceTypeMaximum(LicenceTypeMaximum ltm);
        bool AddLicenceTypeMinimum(LicenceTypeMinimum ltm);

        bool AddStatus(Status s);
        Status FindStatusByName(string status);
        Status FindStatusByID(int statusID);
        IList<Status> GetStatuses();
        bool SetStatusAtVendorLevel(int vendorID, int statusID);

        bool AddPerson(Person p);

        //SITE ANALYTIC
        List<SiteAnalytic> FindSiteAnalyticsByDate(DateTime actionDate);
        bool AddSiteAnalytic(SiteAnalytic s, int siteAnalyticType);
        List<SiteAnalyticOutput> GetAllSiteAnalytics();
        List<SiteAnalyticOutput> GetAllSiteAnalyticsBySession(string sessionID);

        //SITE ANALYTIC TYPE
        bool AddSiteAnalyticType(SiteAnalyticType s);
        SiteAnalyticType FindSiteAnalyticType(int siteAnalyticTypeID);

        List<SiteAnalyticScoreChart> GetCurrentRankings();

        IList<SupportCategory> GetSupportCategories();
        SupportCategory GetSupportCategory(int supportCategoryID);
        QAStatus GetQAStatus(string statusName);
        SupportArea GetSupportArea(string supportAreaName);
        bool AddSupportAreaQA(SupportAreaQA supportAreaQA);

        IList<SupportAreaQA> GetUnservicedSupportAreaQAs();
        bool MarkSupportAreaQAAsServiced(int supportAreaQAID);
        bool MarkSupportAreaQAAsServicing(int supportAreaQAID);

        //WEB API
        List<SiteAnalyticsVendorSummary> GetSiteAnalyticsForVendor(int vendorID, DateTime startDate, DateTime endDate);

        Category FindCategoryByURL(string url);
        string FindCategoryURL(int categoryID);
        IList<Tag> GetCategoryURLs();
        Tag FindCategoryTag(int categoryID);
        int FindShopByURL(string url);
        string GetShopURL(int cloudApplicationID);

        IList<CloudApplication> GetApplicationServiceNames();
        IList<Tag> GetShopTags();
        Tag FindTagByName(string tagName);

        IList<ContentPage> GetContentPages();
        IList<ContentPage> GetDisallowedContentPages();
        IList<CompareCloudware.Domain.Models.SiteMapNode> GetSiteMapNodes();
        void AddContentPage(ContentPage cp);
        ContentPage GetContentPage(string route);

        void ClearCache();

        int GetSearchResultsCount(System.Linq.Expressions.Expression<Func<CloudApplication, bool>> predicate, bool liveApplicationsOnly);

        PersonType GetPersonTypeByPersonTypeID(int personTypeID);
        PersonType GetPersonTypeByPersonTypeName(string personTypeName);
        bool AddColleagueLink(Colleague c);

    }
}
