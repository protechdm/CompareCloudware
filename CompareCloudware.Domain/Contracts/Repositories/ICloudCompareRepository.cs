using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CompareCloudware.Domain.Models;
using System.Web;

namespace CompareCloudware.Domain.Contracts.Repositories
{
    public interface ICloudCompareRepository : IBaseRepository
    {
        IList<SearchFilterOneColumn> GetFiltersOneColumn(int categoryID, int numberOfUsers);
        IList<SearchFilterTwoColumn> GetFiltersTwoColumn(int categoryID, int numberOfUsers);
        IList<Category> GetCategories();
        IList<SupportDays> GetSupportDays();
        IList<SupportHours> GetSupportHours();
        IList<Domain.Models.OperatingSystem> GetOperatingSystems();
        IList<SearchResult> GetFeaturedCloudware(int count);
        IList<SearchResult> GetTopTenCloudware(int count);
        IList<SearchResult> GetNewCloudware(int count);
        IList<SearchResult> GetFeaturedCloudware(int categoryID, int count);
        IList<SearchResult> GetTopTenCloudware(int categoryID, int count);
        IList<SearchResult> GetNewCloudware(int categoryID, int count);
        IList<SearchFilterOneColumn> GetSearchOptionsOneColumn(int categoryID);
        IList<SearchFilterTwoColumn> GetSearchOptionsTwoColumn(int categoryID);
        IList<CloudApplication> GetSearchResults(System.Linq.Expressions.Expression<Func<CloudApplication, bool>> predicate);
        CloudApplication GetCloudApplication(int cloudApplicationID);
        IList<CloudApplication> GetCloudApplicationsByVendor(int vendorID);
        ThumbnailDocument GetCloudApplicationThumbnailDocument(int thumbnailDocumentID);
        AdvertisingImage GetAdvertisingImage(int advertisingImageID);
        AdvertisingImage GetAdvertisingImage(int advertisingImageID, string advertSize);
        Vendor FindVendorByID(int vendorID);
        //bool InsertCase(string userId, string hostAddress, string hostName, string insertAction, Case model);
        //QueueAndUserID GetQueueAndUserIDBasedOnRA(Case inputCase, string country, string invoiceNumber);
        //IList<User> GetUsers(string EMailAddress, string passWord);
        //IList<User> GetUsers(string EMailAddress);
        //IList<User> GetUsers();
        IList<NumberOfUsers> GetNumberOfUsers();
        //bool InsertUser(User model);
        //IList<Case> GetCases();
        //IList<Case> GetCases(string user);
        //Case GetCase(string caseNumber);
        IList<Tag> GetTags(string searchText);
        IList<TagResult> GetApplicationsFromTags(string searchText);
        IEnumerable<CloudApplication> GetSearchResultsFromTags(string searchText);
        IList<ContentText> GetContentData(int[] IDs);
        IList<ContentText> GetContentData(string keyTitle, string keyBody);
        IList<ContentText> GetContentData(string[] IDs);
        IList<TermCondition> GetTermsOfUseData(string policyType);
        ContentText FindContentTextByID(int contentTextID);
        Person GetPersonByEMail(string eMail);
        Person GetPersonByPersonID(int personID);
        CloudApplicationRequest GetCloudApplicationRequestByPersonID(int personID);
        bool LogSiteActivity(HttpRequestBase request);
        //bool LogError(string message);
        bool InsertRatingReview(CloudApplicationRating rating);
        //bool AddPerson(Person person);
        IList<RequestType> GetRequestTypes();
        bool AddRequestType(RequestType rt);
        bool AddIndustry(Industry i);
        IList<Industry> GetIndustries();
        Industry GetIndustry(int industryID);
        IList<CloudApplicationRequest> GetUnservicedCloudApplicationRequests();
        bool MarkCloudApplicationRequestAsServiced(int cloudApplicationRequestID);
        SupportDays GetSupportDays(int supportDaysID);
        SupportHours GetSupportHours(int supportHoursID);
        IList<GenericSingleValue> GetValuesForFeature(string featureName, int categoryID);
        CategoryParameters GetCategoryParameters(int categoryID);

        void ClearCache();
    }
}
