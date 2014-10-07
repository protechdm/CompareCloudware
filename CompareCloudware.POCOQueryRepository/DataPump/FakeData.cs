using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CompareCloudware.Domain.Contracts.Repositories;
using CompareCloudware.POCOQueryRepository;
using CompareCloudware.Domain.Models;
using GhostscriptSharp;
using System.Drawing;
using System.IO;
using CompareCloudware.SocialNetworking;
using CompareCloudware.POCOQueryRepository.DataPump;

//using Moq;
//using NUnit.Framework;

namespace CompareCloudware.POCOQueryRepository
{
    public class FakeData
    {
        private ICompareCloudwareContext testContextInstance;

        bool retVal;
        //string MULTIPLE_FILE_LOCATION = "J:\\CloudCompare\\CloudCompare.Web\\Documents\\WhitePapers\\output%d.jpg";

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public ICompareCloudwareContext FakeContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region LoadFakeReferenceData
        //[TestMethod]
        public void LoadFakeReferenceData(ICompareCloudwareContext context)
        {
            //set the context to a fake stub
            //this.FakeContext = new FakeCloudCompareContext();
            this.FakeContext = context;

            //_context = new StationEntities();

            //now use this fake stub as the repository
            var repository = new QueryRepository(this.FakeContext);

            //add our sample fake station entities to the repository
            CloudApplicationDocument td;
            AdvertisingImage ai;
            Tag t;
            ContentText ct;

            retVal = ReferenceData.PumpSiteAnalyticTypes(context);
            return;

            retVal = ReferenceData.PumpStatuses(repository);
            this.FakeContext.SaveChanges();

            retVal = ReferenceData.PumpLevel1ReferenceData(repository);
            //retVal = ReferenceData.TestLaptop(repository);

            this.FakeContext.SaveChanges();

            retVal = ReferenceData.PumpLevel2ReferenceData(repository);


            //// Mock the Products Repository using Moq
            //Mock<ICloudCompareContext> mockCloudCompareRepository = new Mock<ICloudCompareContext>();

            //// Try finding a product by id
            //CloudApplication testCloudApplication = mockCloudCompareRepository.Object.FindById(2);

            //Assert.IsNotNull(testCloudApplication); // Test if null
            //Assert.IsInstanceOfType(typeof(CloudApplication),testCloudApplication); // Test type
            //Assert.AreEqual("TITLE", testCloudApplication.Title); // Verify it is the right product
        }
        #endregion

        #region LoadFakeProductionData
        public void LoadFakeProductionData(ICompareCloudwareContext context)
        {
            #region VENDORS SCRATCHPAD
            #endregion

            //now use this fake stub as the repository
            var repository = new QueryRepository(this.FakeContext);

            //retVal = ApplicationProductionData.PumpApplicationData(repository);

            retVal = CustomerManagementProductionData.PumpCustomerManagementData(repository); //DONE
            retVal = EmailProductionData.PumpEmailData(repository); //DONE
            retVal = FinancialProductionData.PumpFinancialData(repository); //DONE
            retVal = OfficeProductionData.PumpOfficeData(repository); //DONE
            retVal = PhoneProductionData.PumpPhoneData(repository); //DONE
            retVal = ProjectManagementProductionData.PumpProjectManagementData(repository); //DONE
            retVal = StorageAndBackupProductionData.PumpStorageAndBackupData(repository); //DONE
            retVal = WebConferencingProductionData.PumpWebConferencingData(repository); //DONE
            retVal = SecurityProductionData.PumpSecurityData(repository); //DONE

            retVal = AdvertisingImageData.PumpAdvertisingImageData(repository);
            retVal = TagData.PumpTagData(repository);
            //retVal = ContentTextData.PumpContentTextData(repository);
            retVal = TermsAndConditionsData.PumpTermsConditionsData(repository);
            retVal = TermsAndConditionsData.PumpPrivacyPolicyData(repository);

        }
        #endregion

        #region LoadFakeContentTextData
        public void LoadFakeContentTextData(ICompareCloudwareContext context)
        {
            this.FakeContext = context;
            //now use this fake stub as the repository
            var repository = new QueryRepository(this.FakeContext);

            //retVal = ApplicationProductionData.PumpApplicationData(repository);

            retVal = ContentTextData.PumpContentTextData(repository);
            //retVal = TermsAndConditionsData.PumpTermsConditionsData(repository);
            //retVal = TermsAndConditionsData.PumpPrivacyPolicyData(repository);

        }
        #endregion

        #region SetLiveStatuses
        public bool SetLiveStatuses(ICompareCloudwareContext context)
        {
            bool retVal = true;
            var repository = new QueryRepository(context);

            foreach(CloudApplication ca in context.CloudApplications.ToList())
            {
            ca.Devices.ForEach(x => x.DeviceStatus = repository.FindStatusByName("LIVE"));
            ca.OperatingSystems.ForEach(x => x.OperatingSystemStatus = repository.FindStatusByName("LIVE"));
            ca.Browsers.ForEach(x => x.BrowserStatus = repository.FindStatusByName("LIVE"));
            ca.Languages.ForEach(x => x.LanguageStatus = repository.FindStatusByName("LIVE"));
            ca.SupportTypes.ForEach(x => x.SupportTypeStatus = repository.FindStatusByName("LIVE"));
            ca.SupportTerritories.ForEach(x => x.SupportTerritoryStatus = repository.FindStatusByName("LIVE"));
            ca.CloudApplicationFeatures.ForEach(x => x.CloudApplicationFeatureStatus = repository.FindStatusByName("LIVE"));
            ca.PaymentOptions.ForEach(x => x.PaymentOptionStatus = repository.FindStatusByName("LIVE"));
            ca.CloudApplicationApplications.ForEach(x => x.CloudApplicationApplicationStatus = repository.FindStatusByName("LIVE"));
            }
            return retVal;
        }
        #endregion

        #region InsertRatings
        public void InsertRatings(ICompareCloudwareContext context, Random r)
        {
            foreach (CloudApplication ca in context.CloudApplications.ToList())
            {

                ca.AverageOverallRating = (decimal)Convert.ToInt16(r.NextDouble() * 10) * 10;
                ca.AverageEaseOfUse = (decimal)Convert.ToInt16(r.NextDouble() * 10) * 10;
                ca.AverageValueForMoney = (decimal)Convert.ToInt16(r.NextDouble() * 10) * 10;
                ca.AverageFunctionality = (decimal)Convert.ToInt16(r.NextDouble() * 10) * 10;

                foreach (CloudApplicationUserReview car in ca.CloudApplicationUserReviews.ToList())
                {
                    //car.CloudApplicationUserReviewOverallRating = (decimal)r.NextDouble() * 100;
                    //car.CloudApplicationUserReviewEaseOfUse = (decimal)r.NextDouble() * 100;
                    //car.CloudApplicationUserReviewValueForMoney = (decimal)r.NextDouble() * 100;
                    //car.CloudApplicationUserReviewFunctionality = (decimal)r.NextDouble() * 100;
                    car.CloudApplicationUserReviewOverallRating = (decimal)Convert.ToInt16(r.NextDouble() * 10) * 10;
                    car.CloudApplicationUserReviewEaseOfUse = (decimal)Convert.ToInt16(r.NextDouble() * 10) * 10;
                    car.CloudApplicationUserReviewValueForMoney = (decimal)Convert.ToInt16(r.NextDouble() * 10) * 10;
                    car.CloudApplicationUserReviewFunctionality = (decimal)Convert.ToInt16(r.NextDouble() * 10) * 10;
                }
            }
        }
        #endregion

        #region InsertApplicationWeightings
        public void InsertApplicationWeightings(ICompareCloudwareContext context, Random r)
        {
            foreach (CloudApplication ca in context.CloudApplications)
            {
                ca.SearchResultWeighting = (decimal)r.NextDouble() * 100;
            }
        }
        #endregion

        #region GetImageAsBytes
        public static byte[] GetImageAsBytes(string outputPath)
        {
            //string outputPath = MPU_FILEPATH + MPU_FILE1;
            //System.Drawing.Image i = System.Drawing.Image.FromFile(outputPath);
            //FileStream fs = new FileStream(outputPath, FileMode.Open,FileAccess.Read);
            //BinaryReader br = new BinaryReader(fs);
            //byte[] image = br.ReadBytes((int)fs.Length);
            byte[] image2 = File.ReadAllBytes(outputPath);
            return image2;
        }
        #endregion

        #region InsertTwitterFollowers
        public void InsertTwitterFollowers(ICompareCloudwareContext context)
        {
            Twitter twitter = new Twitter();
            long followers;
            var cloudVendors = context.CloudApplications.Select(x => new { VendorName = x.Vendor.VendorName, TwitterFollowers = x.TwitterFollowers }).Distinct().ToList();
            //foreach (CloudApplication ca in context.CloudApplications.ToList())
            for (int i = 0; i < cloudVendors.Count; i++)
            {
                //if (ca.TwitterFollowers == 0)
                if (cloudVendors[i].TwitterFollowers == 0)
                {
                    followers = twitter.GetTwitterFollowerCount(cloudVendors[i].VendorName);

                    if (followers > 0)
                    {
                        foreach (CloudApplication ca in context.CloudApplications.ToList())
                        {
                            if (ca.Vendor.VendorName == cloudVendors[i].VendorName)
                            {
                                ca.TwitterFollowers = followers;
                                ca.LastTwitterPing = DateTime.Now;
                            }
                        }
                    }
                }
            }
        }
        #endregion

        #region InsertFacebookFans
        public void InsertFacebookFans(ICompareCloudwareContext context)
        {
            Facebook facebook = new Facebook();
            long fans;
            var cloudVendors = context.CloudApplications.Select(x => new { VendorName = x.Vendor.VendorName, FacebookFollowers = x.FacebookFollowers }).Distinct().ToList();
            //foreach (CloudApplication ca in context.CloudApplications.ToList())
            for (int i = 0; i < cloudVendors.Count; i++)
            {
                //if (ca.FacebookFollowers == 0)
                if (cloudVendors[i].FacebookFollowers == 0)
                {
                    fans = facebook.GetFacebookFans(cloudVendors[i].VendorName);
                    if (fans > 0)
                    {
                        foreach (CloudApplication ca in context.CloudApplications.ToList())
                        {
                            ca.FacebookFollowers = fans;
                            ca.LastFacebookPing = DateTime.Now;
                        }
                    }
                }
            }
        }
        #endregion

        #region CheckFacebookFan
        public long CheckFacebookFan(string name)
        {
            Facebook facebook = new Facebook();
            long fans;
            fans = facebook.GetFacebookFans(name);
            return fans;
        }
        #endregion

        #region InsertLinkedInFollowers
        public void InsertLinkedInFollowers(ICompareCloudwareContext context)
        {

            //set the context to a fake stub
            //this.FakeContext = new FakeCloudCompareContext();
            this.FakeContext = context;

            //_context = new StationEntities();

            //now use this fake stub as the repository
            //var repository = new QueryRepository(this.FakeContext);


            LinkedIn linkedIn = new LinkedIn();
            long followers;
            foreach (CloudApplication ca in context.CloudApplications.ToList())
            {
                if (ca.LinkedInFollowers == 0)
                {
                    followers = linkedIn.GetLinkedInFollowerCount(ca.Vendor.VendorName);
                    ca.LinkedInFollowers = followers;
                    ca.LastLinkedInPing = DateTime.Now;
                }
            }
        }
        #endregion

        #region InsertVideos
        public void InsertVideos(ICompareCloudwareContext context)
        {
            this.FakeContext = context;
            var repository = new QueryRepository(context);

            foreach (CloudApplication ca in context.CloudApplications.ToList())
            {
                ca.CloudApplicationVideos = new List<CloudApplicationVideo>()
                {
                    new CloudApplicationVideo()
                    {
                        CloudApplicationVideoFileFormat = "mp4",
                        CloudApplicationVideoFileName = "pr6.mp4",
                        CloudApplicationVideoURL = null,
                        //IsLive = true,
                        CloudApplicationVideoStatus = repository.FindStatusByName("LIVE"),
                        IsLocalDomain = true,
                        IsYouTubeStream = false,
                    },
                    //new CloudApplicationVideo()
                    //{
                    //    CloudApplicationVideoFileFormat = "ogv",
                    //    CloudApplicationVideoFileName = "pr6.ogv",
                    //    CloudApplicationVideoURL = null,
                    //    IsLive = true,
                    //    IsLocalDomain = true,
                    //    IsYouTubeStream = false,
                    //},
                    //new CloudApplicationVideo()
                    //{
                    //    CloudApplicationVideoFileFormat = "webm",
                    //    CloudApplicationVideoFileName = "pr6.webm",
                    //    CloudApplicationVideoURL = null,
                    //    IsLive = true,
                    //    IsLocalDomain = true,
                    //    IsYouTubeStream = false,
                    //},
                    //new CloudApplicationVideo()
                    //{
                    //    CloudApplicationVideoFileFormat = null,
                    //    CloudApplicationVideoFileName = null,
                    //    CloudApplicationVideoURL = "http://www.youtube.com/v/MrMNHwmd9Hc",
                    //    IsLive = true,
                    //    IsLocalDomain = true,
                    //    IsYouTubeStream = true,
                    //},
                    //new CloudApplicationVideo()
                    //{
                    //    CloudApplicationVideoFileFormat = "swf",
                    //    CloudApplicationVideoFileName = "win_98b.swf",
                    //    CloudApplicationVideoURL = null,
                    //    IsLive = true,
                    //    IsLocalDomain = true,
                    //    IsYouTubeStream = false,
                    //},
                    //new CloudApplicationVideo()
                    //{
                    //    CloudApplicationVideoFileFormat = "mov",
                    //    CloudApplicationVideoFileName = "sample_iTunes.mov",
                    //    CloudApplicationVideoURL = null,
                    //    IsLive = true,
                    //    IsLocalDomain = true,
                    //    IsYouTubeStream = false,
                    //},
                };
            }
        }
        #endregion

        #region InsertWhitePaperCaseStudyBytes
        public bool InsertWhitePaperCaseStudyBytes(ICompareCloudwareContext context)
        {
            this.FakeContext = context;
            bool inserted = false;
            var repository = new QueryRepository(this.FakeContext);

            //foreach (ThumbnailDocument td in context.ThumbnailDocuments.ToList())
            CloudApplicationDocument sampleTD = context.CloudApplicationDocuments.Where(x => x.CloudApplicationDocumentImage == null).FirstOrDefault();
            if (sampleTD != null)
            {
                string fileName = sampleTD.CloudApplicationDocumentPhysicalFilePath + sampleTD.CloudApplicationDocumentFileName;
                byte[] documentToInsert = File.ReadAllBytes(fileName);


                var TDs = context.CloudApplicationDocuments
                    .Where(x => (x.CloudApplicationDocumentPhysicalFilePath + x.CloudApplicationDocumentFileName) == fileName)
                    .Where(x => x.CloudApplicationDocumentImage == null)
                    .ToList();

                foreach (CloudApplicationDocument td in TDs)
                {
                    if (td.CloudApplicationDocumentImage == null)
                    {
                        CloudApplicationDocumentImage tdd = new CloudApplicationDocumentImage();
                        //tdd.ThumbnailDocumentBytes = File.ReadAllBytes(td.ThumbnailDocumentPhysicalFilePath + td.ThumbnailDocumentFileName);
                        tdd.CloudApplicationDocumentBytes = documentToInsert;
                        tdd.CloudApplicationDocumentImageStatus = repository.FindStatusByName("LIVE");
                        td.CloudApplicationDocumentImage = tdd;
                        td.CloudApplicationDocumentStatus = repository.FindStatusByName("LIVE");                        
                        //context.SaveChanges();
                        inserted = true;
                    }
                }
                context.SaveChanges();
            }
            return inserted;
        }
        #endregion

        #region GetPublisherName
        public static string GetPublisherName(int publisherID)
        {
            string REVIEW_PUBLISHER_NAME_1 = "Computer Weekly";
            string REVIEW_PUBLISHER_NAME_2 = "silicon.com";
            switch (publisherID)
            {
                case 1:
                    return REVIEW_PUBLISHER_NAME_1 ;
                case 2:
                    return REVIEW_PUBLISHER_NAME_2;
                default:
                    return "";
            }
        }
        #endregion

        #region GetPublisherHeadline
        public static string GetPublisherHeadline()
        {
            string REVIEW_HEADLINE = "Great example of SaaS for the growing business";
            return REVIEW_HEADLINE;
        }
        #endregion

        #region LoadSkyscrapersMPUs
        public void LoadSkyscrapersMPUs(ICompareCloudwareContext context)
        {
            this.FakeContext = context;

            var repository = new QueryRepository(this.FakeContext);
            retVal = AdvertisingImageData.PumpAdvertisingImageData(repository);
        }
        #endregion

        #region InsertMissingLogos
        public void InsertMissingLogos(ICompareCloudwareContext context)
        {
            this.FakeContext = context;

            var repository = new QueryRepository(this.FakeContext);
            ReferenceData.PumpMissingLogos(repository);
        }
        #endregion

        #region PumpLogs
        public void PumpLogs(ICompareCloudwareContext context)
        {
            this.FakeContext = context;

            var repository = new QueryRepository(this.FakeContext);
            ReferenceData.PumpLogs(repository);
        }
        #endregion

        #region LoadSageOneAccountsExtra
        public void LoadSageOneAccountsExtra(ICompareCloudwareContext context)
        {
            this.FakeContext = context;

            var repository = new QueryRepository(this.FakeContext);
            retVal = FinancialProductionData.PumpSageOneAccountsExtra(repository);
        }
        #endregion

        #region LoadEgnyteLogo
        public void LoadEgnyteLogo(ICompareCloudwareContext context)
        {
            this.FakeContext = context;

            var repository = new QueryRepository(this.FakeContext);
            retVal = StorageAndBackupProductionData.PumpEgnyteLogo(repository);
        }
        #endregion

        #region LoadEgnyte
        public void LoadEgnyte(ICompareCloudwareContext context)
        {
            this.FakeContext = context;

            var repository = new QueryRepository(this.FakeContext);
            retVal = CustomerManagementProductionData.PumpCommence(repository);
        }
        #endregion

        #region LoadMikogoLogo
        public void LoadMikogoLogo(ICompareCloudwareContext context)
        {
            this.FakeContext = context;

            var repository = new QueryRepository(this.FakeContext);
            retVal = WebConferencingProductionData.PumpMikogoLogo(repository);
        }
        #endregion

        #region LoadMikogo
        public void LoadMikogo(ICompareCloudwareContext context)
        {
            this.FakeContext = context;

            var repository = new QueryRepository(this.FakeContext);
            retVal = WebConferencingProductionData.PumpMikogo(repository);
        }
        #endregion

        #region LoadEgnyteBusiness
        public void LoadEgnyteBusiness(ICompareCloudwareContext context)
        {
            this.FakeContext = context;

            var repository = new QueryRepository(this.FakeContext);
            retVal = StorageAndBackupProductionData.PumpEgnyteBusiness(repository);
        }
        #endregion

        #region LoadEgnyteEnterprise
        public void LoadEgnyteEnterprise(ICompareCloudwareContext context)
        {
            this.FakeContext = context;

            var repository = new QueryRepository(this.FakeContext);
            retVal = StorageAndBackupProductionData.PumpEgnyteEnterprise(repository);
        }
        #endregion

        #region LoadGFICloudAntiVirus
        public void LoadGFICloudAntiVirus(ICompareCloudwareContext context)
        {
            this.FakeContext = context;

            var repository = new QueryRepository(this.FakeContext);
            retVal = SecurityProductionData.PumpGFICloudAntiVirus(repository);
        }
        #endregion

        #region LoadGFICloudWebProtection
        public void LoadGFICloudWebProtection(ICompareCloudwareContext context)
        {
            this.FakeContext = context;

            var repository = new QueryRepository(this.FakeContext);
            retVal = SecurityProductionData.PumpGFICloudWebProtection(repository);
        }
        #endregion

        #region LoadGFICloudRemoteSupport
        public void LoadGFICloudRemoteSupport(ICompareCloudwareContext context)
        {
            this.FakeContext = context;

            var repository = new QueryRepository(this.FakeContext);
            retVal = SecurityProductionData.PumpGFICloudRemoteSupport(repository);
        }
        #endregion

        #region LoadCommenceLogo
        public void LoadCommenceLogo(ICompareCloudwareContext context)
        {
            this.FakeContext = context;

            var repository = new QueryRepository(this.FakeContext);
            retVal = CustomerManagementProductionData.PumpCommenceLogo(repository);
        }
        #endregion

        #region LoadCommence
        public void LoadCommence(ICompareCloudwareContext context)
        {
            this.FakeContext = context;

            var repository = new QueryRepository(this.FakeContext);
            retVal = CustomerManagementProductionData.PumpCommence(repository);
        }
        #endregion

        #region LoadLiquidPlannerLogo
        public void LoadLiquidPlannerLogo(ICompareCloudwareContext context)
        {
            this.FakeContext = context;

            var repository = new QueryRepository(this.FakeContext);
            retVal = ProjectManagementProductionData.PumpLiquidPlannerLogo(repository);
        }
        #endregion

        #region LoadLiquidPlanner
        public void LoadLiquidPlanner(ICompareCloudwareContext context)
        {
            this.FakeContext = context;

            var repository = new QueryRepository(this.FakeContext);
            retVal = ProjectManagementProductionData.PumpLiquidPlannerMonthlyPlan(repository);
        }
        #endregion

        #region LoadAVGLogo
        public void LoadAVGLogo(ICompareCloudwareContext context)
        {
            this.FakeContext = context;

            var repository = new QueryRepository(this.FakeContext);
            retVal = SecurityProductionData.PumpAVGLogo(repository);
        }
        #endregion

        #region LoadAVGAntiVirus2014
        public void LoadAVGAntiVirus2014(ICompareCloudwareContext context)
        {
            this.FakeContext = context;

            var repository = new QueryRepository(this.FakeContext);
            retVal = SecurityProductionData.PumpAVGAntiVirus2014(repository);
        }
        #endregion

        #region LoadAVGInternetSecurity2014
        public void LoadAVGInternetSecurity2014(ICompareCloudwareContext context)
        {
            this.FakeContext = context;

            var repository = new QueryRepository(this.FakeContext);
            retVal = SecurityProductionData.PumpAVGInternetSecurity2014(repository);
        }
        #endregion

        #region LoadAVGPremiumSecurity2014
        public void LoadAVGPremiumSecurity2014(ICompareCloudwareContext context)
        {
            this.FakeContext = context;

            var repository = new QueryRepository(this.FakeContext);
            retVal = SecurityProductionData.PumpAVGPremiumSecurity2014(repository);
        }
        #endregion

        #region LoadAVGAntiVirusForMac2014
        public void LoadAVGAntiVirusForMac2014(ICompareCloudwareContext context)
        {
            this.FakeContext = context;

            var repository = new QueryRepository(this.FakeContext);
            retVal = SecurityProductionData.PumpAVGAntiVirusForMac(repository);
        }
        #endregion

        #region LoadAVGFileServer2014
        public void LoadAVGFileServer2014(ICompareCloudwareContext context)
        {
            this.FakeContext = context;

            var repository = new QueryRepository(this.FakeContext);
            retVal = SecurityProductionData.PumpAVGFileServer2014(repository);
        }
        #endregion

        #region LoadAVGBusinessAntiVirus
        public void LoadAVGBusinessAntiVirus(ICompareCloudwareContext context)
        {
            this.FakeContext = context;

            var repository = new QueryRepository(this.FakeContext);
            retVal = SecurityProductionData.PumpAVGBusinessAntiVirus(repository);
        }
        #endregion

        #region LoadAVGBusinessInternetSecurity
        public void LoadAVGBusinessInternetSecurity(ICompareCloudwareContext context)
        {
            this.FakeContext = context;

            var repository = new QueryRepository(this.FakeContext);
            retVal = SecurityProductionData.PumpAVGBusinessInternetSecurity(repository);
        }
        #endregion

        #region LoadAVGCloudCare
        public void LoadAVGCloudCare(ICompareCloudwareContext context)
        {
            this.FakeContext = context;

            var repository = new QueryRepository(this.FakeContext);
            retVal = SecurityProductionData.PumpAVGCloudCare(repository);
        }
        #endregion

        #region LoadKasperskyLogo
        public void LoadKasperskyLogo(ICompareCloudwareContext context)
        {
            this.FakeContext = context;

            var repository = new QueryRepository(this.FakeContext);
            retVal = SecurityProductionData.PumpKasperskyLogo(repository);
        }
        #endregion

        #region LoadKasperskyPure30
        public void LoadKasperskyPure30(ICompareCloudwareContext context)
        {
            this.FakeContext = context;

            var repository = new QueryRepository(this.FakeContext);
            retVal = SecurityProductionData.PumpKasperskyPure30(repository);
        }
        #endregion

        #region LoadKasperskyInternetSecurity2014
        public void LoadKasperskyInternetSecurity2014(ICompareCloudwareContext context)
        {
            this.FakeContext = context;

            var repository = new QueryRepository(this.FakeContext);
            retVal = SecurityProductionData.PumpKasperskyInternetSecurity2014(repository);
        }
        #endregion

        #region LoadKasperskyAntiVirus2014
        public void LoadKasperskyAntiVirus2014(ICompareCloudwareContext context)
        {
            this.FakeContext = context;

            var repository = new QueryRepository(this.FakeContext);
            retVal = SecurityProductionData.PumpKasperskyAntiVirus2014(repository);
        }
        #endregion

        #region LoadKasperskyInternetSecurityMultiDevice
        public void LoadKasperskyInternetSecurityMultiDevice(ICompareCloudwareContext context)
        {
            this.FakeContext = context;

            var repository = new QueryRepository(this.FakeContext);
            retVal = SecurityProductionData.PumpKasperskyInternetSecurityMultiDevice(repository);
        }
        #endregion

        #region LoadKasperskySecurityForMac
        public void LoadKasperskySecurityForMac(ICompareCloudwareContext context)
        {
            this.FakeContext = context;

            var repository = new QueryRepository(this.FakeContext);
            retVal = SecurityProductionData.PumpKasperskySecurityForMac(repository);
        }
        #endregion

        #region LoadKasperskyEndpointForBusinessAdvanced
        public void LoadKasperskyEndpointForBusinessAdvanced(ICompareCloudwareContext context)
        {
            this.FakeContext = context;

            var repository = new QueryRepository(this.FakeContext);
            retVal = SecurityProductionData.PumpKasperskyEndpointForBusinessAdvanced(repository);
        }
        #endregion

        #region LoadKasperskyEndpointForBusinessSelect
        public void LoadKasperskyEndpointForBusinessSelect(ICompareCloudwareContext context)
        {
            this.FakeContext = context;

            var repository = new QueryRepository(this.FakeContext);
            retVal = SecurityProductionData.PumpKasperskyEndpointForBusinessSelect(repository);
        }
        #endregion

        #region LoadKasperskyEndpointForBusinessCore
        public void LoadKasperskyEndpointForBusinessCore(ICompareCloudwareContext context)
        {
            this.FakeContext = context;

            var repository = new QueryRepository(this.FakeContext);
            retVal = SecurityProductionData.PumpKasperskyEndpointForBusinessCore(repository);
        }
        #endregion

        #region LoadKasperskyTotalSecurityForBusiness
        public void LoadKasperskyTotalSecurityForBusiness(ICompareCloudwareContext context)
        {
            this.FakeContext = context;

            var repository = new QueryRepository(this.FakeContext);
            retVal = SecurityProductionData.PumpKasperskyTotalSecurityForBusiness(repository);
        }
        #endregion

        #region LoadKasperskyTargetedSecuritySolutions
        public void LoadKasperskyTargetedSecuritySolutions(ICompareCloudwareContext context)
        {
            this.FakeContext = context;

            var repository = new QueryRepository(this.FakeContext);
            retVal = SecurityProductionData.PumpKasperskyTargetedSecuritySolutions(repository);
        }
        #endregion

        #region LoadKasperskySmallOfficeSecurity
        public void LoadKasperskySmallOfficeSecurity(ICompareCloudwareContext context)
        {
            this.FakeContext = context;

            var repository = new QueryRepository(this.FakeContext);
            retVal = SecurityProductionData.PumpKasperskySmallOfficeSecurity(repository);
        }
        #endregion

        #region LoadURLTagTypeData
        public void LoadURLTagTypeData(ICompareCloudwareContext context)
        {
            this.FakeContext = context;

            //now use this fake stub as the repository
            var repository = new QueryRepository(this.FakeContext);

            retVal = TagData.PumpURLTagTypeData(repository);
        }
        #endregion

        #region LoadTagData
        public void LoadTagData(ICompareCloudwareContext context)
        {
            this.FakeContext = context;

            //now use this fake stub as the repository
            var repository = new QueryRepository(this.FakeContext);

            retVal = TagData.PumpTagData(repository);
        }
        #endregion

        #region LoadCategoryURLTagData
        public void LoadCategoryURLTagData(ICompareCloudwareContext context)
        {
            this.FakeContext = context;

            //now use this fake stub as the repository
            var repository = new QueryRepository(this.FakeContext);

            retVal = TagData.PumpCategoryURLs(repository);
        }
        #endregion

        #region LoadShopURLTagData
        public void LoadShopURLTagData(ICompareCloudwareContext context)
        {
            this.FakeContext = context;

            //now use this fake stub as the repository
            var repository = new QueryRepository(this.FakeContext);

            retVal = TagData.PumpShopURLs(repository);
        }
        #endregion

        #region LoadContentPageData
        public void LoadContentPageData(ICompareCloudwareContext context)
        {
            this.FakeContext = context;

            //now use this fake stub as the repository
            var repository = new QueryRepository(this.FakeContext);

            retVal = ContentPageData.PumpContentPageData(repository);
        }
        #endregion

        #region LoadContextTextTypesForH1H2
        public void LoadContextTextTypesForH1H2(ICompareCloudwareContext context)
        {
            this.FakeContext = context;
            //now use this fake stub as the repository
            var repository = new QueryRepository(this.FakeContext);

            //retVal = ApplicationProductionData.PumpApplicationData(repository);

            retVal = ReferenceData.PumpContextTextTypesForH1H2(repository);
            //retVal = TermsAndConditionsData.PumpTermsConditionsData(repository);
            //retVal = TermsAndConditionsData.PumpPrivacyPolicyData(repository);

        }
        #endregion

        #region LoadContextTextDataForH1H2
        public void LoadContextTextDataForH1H2(ICompareCloudwareContext context)
        {
            this.FakeContext = context;
            //now use this fake stub as the repository
            var repository = new QueryRepository(this.FakeContext);

            //retVal = ApplicationProductionData.PumpApplicationData(repository);

            retVal = ContentTextData.PumpContextTextDataForH1H2(repository);
            //retVal = TermsAndConditionsData.PumpTermsConditionsData(repository);
            //retVal = TermsAndConditionsData.PumpPrivacyPolicyData(repository);

        }
        #endregion

        #region LoadCarboniteBusinessPlus
        public CloudApplication LoadCarboniteBusinessPlus(ICompareCloudwareContext context)
        {
            this.FakeContext = context;

            var repository = new QueryRepository(this.FakeContext);
            var ca = StorageAndBackupProductionData.PumpCarboniteBusinessPlus(repository);

            return ca;

        }
        #endregion

        #region LoadCarboniteBusinessPlusSEO
        public CloudApplication LoadCarboniteBusinessPlusSEO(ICompareCloudwareContext context, CloudApplication ca)
        {
            this.FakeContext = context;

            var repository = new QueryRepository(this.FakeContext);

            var category = repository.FindCategoryByID(ca.Category.CategoryID);
            var tagType = repository.FindTagTypeByName("SHOP URL");
            var tagStatus = repository.FindStatusByName("LIVE");

            var t = new Tag()
            {
                //TagName = ca.Vendor.VendorName.Trim().ToLower() + "-" + ca.ServiceName.ToLower().Replace(" ","-"),
                TagName = ca.Vendor.VendorName.Trim().ToLower().Replace(" ", "-").Replace(":", "-") + "-" + ca.ServiceName.ToLower().Replace(" ", "-"),
                Category = category,
                TagType = tagType,
                TagStatus = tagStatus,
            };
            repository.Insert<Tag>(t, true);

            ca.CloudApplicationShopTag = t;

            var categoryTag = repository.FindCategoryTag(ca.Category.CategoryID);
            ca.CloudApplicationCategoryTag = categoryTag;

            //repository.Update<CloudApplication>("1", ca);

            return ca;

        }
        #endregion

        #region LoadContextTextTypesForTabs
        public void LoadContextTextTypesForTabs(ICompareCloudwareContext context)
        {
            this.FakeContext = context;
            //now use this fake stub as the repository
            var repository = new QueryRepository(this.FakeContext);

            //retVal = ApplicationProductionData.PumpApplicationData(repository);

            retVal = ContentTextData.PumpContextTextTypesForTabs(repository);
            //retVal = TermsAndConditionsData.PumpTermsConditionsData(repository);
            //retVal = TermsAndConditionsData.PumpPrivacyPolicyData(repository);

        }
        #endregion

        #region LoadAvastLogo
        public void LoadAvastLogo(ICompareCloudwareContext context)
        {
            this.FakeContext = context;

            var repository = new QueryRepository(this.FakeContext);
            retVal = SecurityProductionData.PumpAvastLogo(repository);
        }
        #endregion

        #region LoadAvastEndpointProtection
        public void LoadAvastEndpointProtection(ICompareCloudwareContext context)
        {
            this.FakeContext = context;

            var repository = new QueryRepository(this.FakeContext);
            retVal = SecurityProductionData.PumpAvastEndpointProtection(repository);
        }
        #endregion

        #region LoadAvastEndpointProtectionPlus
        public void LoadAvastEndpointProtectionPlus(ICompareCloudwareContext context)
        {
            this.FakeContext = context;

            var repository = new QueryRepository(this.FakeContext);
            retVal = SecurityProductionData.PumpAvastEndpointProtectionPlus(repository);
        }
        #endregion

    }
}
