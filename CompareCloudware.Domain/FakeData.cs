using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CloudCompare.Domain;
using CloudCompare.POCOQueryRepository;
using Moq;
using NUnit.Framework;

namespace CloudCompare.POCOQueryRepository
{
    class FakeData
    {
        private ICloudCompareContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public ICloudCompareContext FakeContext
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

        //[TestMethod]
        public void LoadFakeData()
        {
            //set the context to a fake stub
            this.FakeContext = new CloudCompareContext();

            //_context = new StationEntities();

            //now use this fake stub as the repository
            var repository = new QueryRepository(this.FakeContext);

            //add our sample fake station entities to the repository
            CloudApplication ca;
            ca = new CloudApplication()
            {
                AddDate = DateTime.Now,
                ApplicationContentStatusID = 1,
                ApprovalAssignedPersonID = 1,
                ApprovalStatusID = 1,
                AverageEaseOfUse = 1,
                AverageFunctionality = 1,
                AverageOverallRating = 1,
                AverageValueForMoney = 1,
                Brand = "BRAND",
                CategoryID = 1,
                CloudApplicationID = 1,
                CostPerAnnum = 1,
                CostPerMonth = 1,
                Description = "DESCRIPTION",
                FacebookFollowers = 1,
                FacebookURL = "FACEBOOKURL",
                Features = new List<Feature>(),
                FreeTrialID = 1,
                FreeTrialPeriodID = 1,
                IsPromotional = true,
                LanguageID = 1,
                LicenceTypeID = 1,
                LinkedInFollowers = 1,
                LinkedInURL = "LINKEDINURL",
                MaximumMeetingAttendees = 1,
                MaximumWebinarAttendees = 1,
                MinimumContractID = 1,
                OperatingSystemID = 1,
                PaymentFrequencyID = 1,
                PaymentOptions = new List<PaymentOption>(),
                SetupFee = 1,
                SupportDaysID = 1,
                SupportHoursID = 1,
                SupportTypeID = 1,
                ThumbnailDocuments = new List<ThumbnailDocument>(),
                Title = "TITLE",
                TwitterFollowers = 1,
                TwitterURL = "TWITTERURL",
                Vendor = new Vendor(),
                VideoTrainingSupport = true
            };
            repository.AddCloudApplication(ca);


            // Mock the Products Repository using Moq
            Mock<ICloudCompareContext> mockCloudCompareRepository = new Mock<ICloudCompareContext>();

            // Try finding a product by id
            CloudApplication testCloudApplication = mockCloudCompareRepository.Object.FindById(2);

            Assert.IsNotNull(testCloudApplication); // Test if null
            Assert.IsInstanceOfType(typeof(CloudApplication),testCloudApplication); // Test type
            Assert.AreEqual("TITLE", testCloudApplication.Title); // Verify it is the right product
        }
    }
}
