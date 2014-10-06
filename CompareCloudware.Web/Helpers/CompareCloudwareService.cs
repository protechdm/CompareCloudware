namespace CompareCloudware.Web.Helpers
{
    using Castle.Core.Logging;
    using CompareCloudware.Domain.Contracts.Repositories;
    using CompareCloudware.Web;
    using CompareCloudware.Web.Models;
    using System;
    using System.Collections.Generic;
    using System.Configuration;
    using System.IO;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Security.AccessControl;

    public class CompareCloudwareService : ICompareCloudwareService
    {
        //private readonly ICloudCompareRepository _repository;

        public static bool CreateFolder(string folderToCreate)
        {
            try
            {
                List<string> folderTree = folderToCreate.Split(new char[] { '\\' }).ToList<string>();
                if (!Directory.Exists(folderToCreate))
                {
                    Directory.CreateDirectory(folderToCreate);
                }
                DirectoryInfo info = new DirectoryInfo(folderToCreate);
                DirectorySecurity security = info.GetAccessControl();
                string permissions = ConfigurationManager.AppSettings["createdFolderPermissions"];
                if (permissions != null)
                {
                    permissions.ToString().Split(new char[] { ',' }).ToList<string>().ForEach(delegate (string fsa) {
                        FileSystemAccessRule fileSystemAccessRule = new FileSystemAccessRule(fsa, FileSystemRights.ReadAndExecute | FileSystemRights.Write, AccessControlType.Allow);
                        security.AddAccessRule(fileSystemAccessRule);
                    });
                }
                else
                {
                    FileSystemAccessRule fileSystemAccessRule = new FileSystemAccessRule(@"BUILTIN\IIS_IUSRS", FileSystemRights.ReadAndExecute | FileSystemRights.Write, AccessControlType.Allow);
                    FileSystemAccessRule fileSystemAccessRule2 = new FileSystemAccessRule(@"IIS AppPool\DefaultAppPool", FileSystemRights.ReadAndExecute | FileSystemRights.Write, AccessControlType.Allow);
                    security.AddAccessRule(fileSystemAccessRule);
                    security.AddAccessRule(fileSystemAccessRule2);
                }
                info.SetAccessControl(security);
                return true;
            }
            catch (Exception e)
            {
                throw new Exception("Could not create folder:" + folderToCreate);
            }
        }

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue = composite.StringValue + "Suffix";
            }
            return composite;
        }

        public bool GetObjects1(SearchPageModel spm, SearchPageContainerModel spcm, SearchFiltersModel sfm, SearchResultsModel srm, CloudApplicationModel cam, SearchFiltersModelOneColumn sfsmoc, SearchFiltersModelTwoColumn sfsmtc, SearchResultsModelOneColumn srsmoc, SearchResultModelOneColumn srmoc, VendorModel vm, SetupFeeModel setfm, FreeTrialPeriodModel ftpm, BrowserModel bm, MobilePlatformModel mpm, LicenceTypeMinimumModel ltminm, LicenceTypeMaximumModel ltmaxm, SupportTypeModel stm, SupportHoursModel shm, SupportTerritoryModel sterrm, LanguageModel lm, CloudApplicationFeatureModel cafm)
        {
            throw new NotImplementedException();
        }

        public bool GetObjects2(CloudApplicationDocumentModel tdm, CategoryModel cm, MinimumContractModel mcm, PaymentFrequencyModel pfm, PaymentOptionModel pom, CloudApplicationProductReviewModel carevm, CloudApplicationUserReviewModel caratm, FreeTrialBuyNowModel ftbnm, NumberOfUsersModel noum, SearchFilterModelOneColumn sfmoc, SearchFilterModelTwoColumn sfmtc, SearchResultSummaryModel srsm, CloudApplicationModel cam, FeatureModel fm, CloudApplicationDocumentTypeModel tdtm, AdditionalOutput additionalOutput)
        {
            throw new NotImplementedException();
        }

        public string SendRAZORDataReturnHTML(CloudApplicationModel searchResult, int pageNumber, string filePath, string fileName, bool overwriteIfExists, AdditionalOutput additionalOutput)
        {
            throw new NotImplementedException();
        }

        public string SendSearchResultToRAZORAndCreatePDF(CloudApplicationModel searchResult, int pageNumber, string filePath, string fileName, bool overwriteIfExists, AdditionalOutput additionalOutput)
        {
            return "";
        }

        private ICustomSession CustomSession { get; set; }

        public ILogger Logger { get; set; }
    }
}

