using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
//using CompareCloudware.Web.Models;

namespace CompareCloudware.WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface ICompareCloudwareService
    {

        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: Add your service operations here
        [OperationContract]
        string SendSearchResultToRAZORAndCreatePDF(CloudApplicationModel searchResult, int pageNumber, string filePath, string fileName, bool overwriteIfExists, AdditionalOutput additionalOutput);

        [OperationContract]
        string SendRAZORDataReturnHTML(CloudApplicationModel searchResult, int pageNumber, string filePath, string fileName, bool overwriteIfExists, AdditionalOutput additionalOutput);

        [OperationContract]
        bool GetObjects1(
            SearchPageModel spm,
            SearchPageContainerModel spcm,
            SearchFiltersModel sfm,
            SearchResultsModel srm,
            CloudApplicationModel cam,
            SearchFiltersModelOneColumn sfsmoc,
            SearchFiltersModelTwoColumn sfsmtc,
            SearchResultsModelOneColumn srsmoc,
            SearchResultModelOneColumn srmoc,
            VendorModel vm,
            SetupFeeModel setfm,
            FreeTrialPeriodModel ftpm,
            BrowserModel bm,
            MobilePlatformModel mpm,
            LicenceTypeMinimumModel ltminm,
            LicenceTypeMaximumModel ltmaxm,
            SupportTypeModel stm,
            SupportHoursModel shm,
            SupportTerritoryModel sterrm,
            LanguageModel lm,
            CloudApplicationFeatureModel cafm
    );



        [OperationContract]
        bool GetObjects2(
            ThumbnailDocumentModel tdm,
            CategoryModel cm,
            MinimumContractModel mcm,
            PaymentFrequencyModel pfm,
            PaymentOptionModel pom,
            CloudApplicationReviewModel carevm,
            CloudApplicationRatingModel caratm,
            FreeTrialBuyNowModel ftbnm,
            NumberOfUsersModel noum,
            SearchFilterModelOneColumn sfmoc,
            SearchFilterModelTwoColumn sfmtc,
            SearchResultSummaryModel srsm,
            CloudApplicationModel cam,
            FeatureModel fm,
            ThumbnailDocumentTypeModel tdtm,
            AdditionalOutput additionalOutput);


    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }

    [DataContract]
    public class AdditionalOutput
    {
        [DataMember]
        public string OutputFileName { get; set; }
        [DataMember]
        public PDFEngineType PDFEngineType { get; set; }
        //[DataMember]
        //public int PDFEngineType { get; set; }
    }

    [DataContract]
    public enum PDFEngineType
    {
        [EnumMember]
        ASPPDF = 0,
        [EnumMember]
        PDFTRON = 1,
        [EnumMember]
        EVOPDF = 2
    }

}
