namespace CompareCloudware.Web.Helpers
{
    using CompareCloudware.Web.Models;
    using System;
    using System.ServiceModel;

    [ServiceContract]
    public interface ICompareCloudwareService
    {
        [OperationContract]
        string GetData(int value);
        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);
        [OperationContract]
        bool GetObjects1(SearchPageModel spm, SearchPageContainerModel spcm, SearchFiltersModel sfm, SearchResultsModel srm, CloudApplicationModel cam, SearchFiltersModelOneColumn sfsmoc, SearchFiltersModelTwoColumn sfsmtc, SearchResultsModelOneColumn srsmoc, SearchResultModelOneColumn srmoc, VendorModel vm, SetupFeeModel setfm, FreeTrialPeriodModel ftpm, BrowserModel bm, MobilePlatformModel mpm, LicenceTypeMinimumModel ltminm, LicenceTypeMaximumModel ltmaxm, SupportTypeModel stm, SupportHoursModel shm, SupportTerritoryModel sterrm, LanguageModel lm, CloudApplicationFeatureModel cafm);
        [OperationContract]
        bool GetObjects2(CloudApplicationDocumentModel tdm, CategoryModel cm, MinimumContractModel mcm, PaymentFrequencyModel pfm, PaymentOptionModel pom, CloudApplicationProductReviewModel carevm, CloudApplicationUserReviewModel caratm, FreeTrialBuyNowModel ftbnm, NumberOfUsersModel noum, SearchFilterModelOneColumn sfmoc, SearchFilterModelTwoColumn sfmtc, SearchResultSummaryModel srsm, CloudApplicationModel cam, FeatureModel fm, CloudApplicationDocumentTypeModel tdtm, AdditionalOutput additionalOutput);
        [OperationContract]
        string SendRAZORDataReturnHTML(CloudApplicationModel searchResult, int pageNumber, string filePath, string fileName, bool overwriteIfExists, AdditionalOutput additionalOutput);
        [OperationContract]
        string SendSearchResultToRAZORAndCreatePDF(CloudApplicationModel searchResult, int pageNumber, string filePath, string fileName, bool overwriteIfExists, AdditionalOutput additionalOutput);
    }
}

