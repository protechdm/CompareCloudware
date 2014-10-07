using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CompareCloudware.Domain.Models;
using CompareCloudware.POCOQueryRepository;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Data.Entity.Infrastructure;
using System.Diagnostics;

using Microsoft.WindowsAPICodePack;
using Microsoft.WindowsAPICodePack.Shell;
using ManagedWinapi;
using GhostscriptSharp;
using System.Configuration;

namespace CompareCloudware.Console
{
    class Program
    {

        static void Main(string[] args)
        {
            string TEST_FILE_LOCATION = "J:\\CloudCompare\\CloudCompare.Web\\Documents\\WhitePapers\\words.pdf";
            string SINGLE_FILE_LOCATION = "J:\\CloudCompare\\CloudCompare.Web\\Documents\\WhitePapers\\";
            string OUTPUT_FILE_LOCATION = "J:\\CloudCompare\\CloudCompare.Web\\Documents\\WhitePapers\\";
            string MULTIPLE_FILE_LOCATION = "J:\\CloudCompare\\CloudCompare.Web\\Documents\\WhitePapers\\output%d.jpg";
            //Database.SetInitializer(new DropCreateDatabaseIfModelChanges<CloudCompare.Domain.CloudCompareContext>());
            //Database.SetInitializer(new DropCreateDatabaseAlways<CloudCompareContext>());
            //InsertVendor();
            //LoadRatings();

            //using (var context = new CloudCompareContext())
            //{
            //    LoadTwitterFollowers(context);
            //    context.SaveChanges();
            //}

            //using (var context = new CloudCompareContext())
            //{
            //    LoadFacebookFans(context);
            //    context.SaveChanges();
            //}
            //Logs();
            //return;
            //LoadContextTextTypesForTabs(); //RUN ONCE!!!!!
            //ContentTextData();
            //LoadSkyscrapersMPUs();
            //return;

            //StageData();
            //return;
            //LoadMissingLogos();
            //LoadRatings();
            //LoadApplicationWeightings();
            //LoadTwitterFollowers();
            //LoadFacebookFans();
            //LoadLinkedInFollowers();
            //LoadVideos();
            //LoadStatuses();
            //long fans = CheckFacebookName("WebEx");
            //string outputFile = SINGLE_FILE_LOCATION + Guid.NewGuid().ToString() + ".jpg";
            //GetThumbnail("J:\\CloudCompare\\CloudCompare.Web\\Documents\\WhitePapers\\words.pdf");
            //var x = GhostscriptWrapper.GetPageThumb(TEST_FILE_LOCATION, outputFile, 3, 100, 100);
            //LoadWhitePaperCaseStudyBytes();
            //LoadSageOneAccountsExtra();
            //LoadEgnyte();
            //LoadMikogo();
            //LoadEgnyteBusiness();
            //LoadEgnyteEnterprise();

            //LoadGFICloudAntiVirus();
            //LoadGFICloudWebProtection();
            //LoadGFICloudRemoteSupport();
            //LoadCommence();
            //LoadLiquidPlanner();

            //LoadAVGLogo();
            //LoadAVGAntiVirus2014();
            //LoadAVGInternetSecurity2014();
            //LoadAVGPremiumSecurity2014();
            //LoadAVGAntiVirusForMac2014();
            //LoadAVGFileServer2014();
            //LoadAVGBusinessAntiVirus();
            //LoadAVGBusinessInternetSecurity();
            //LoadAVGCloudCare();

            //LoadKasperskyLogo();
            //LoadKasperskyPure30();
            //LoadKasperskyInternetSecurity2014();
            //LoadKasperskyAntiVirus2014();
            //LoadKasperskyInternetSecurityMultiDevice();
            //LoadKasperskySecurityForMac();
            //LoadKasperskyEndpointForBusinessAdvanced();
            //LoadKasperskyEndpointForBusinessSelect();
            //LoadKasperskyEndpointForBusinessCore();
            //LoadKasperskyTotalSecurityForBusiness();
            //LoadKasperskyTargetedSecuritySolutions();
            //LoadKasperskySmallOfficeSecurity();

            //LoadURLTagTypeData();//RUN ONCE
            //LoadTagData();
            //LoadCategorytURLTagData();
            //LoadShopURLTagData();
            //LoadContentPageData();
            //LoadContextTextTypesForH1H2(); DONT'T NEED FOR LIVE
            //LoadContextTextDataForH1H2();

            //LoadCarboniteBusinessPlus();
            //LoadSecondCategories();

            LoadAvastLogo();
            LoadAvastEndpointProtection();
            LoadAvastEndpointProtectionPlus();
        }

        #region InsertVendor
        private static void InsertVendor()
        {
            var vendor = new Vendor
            {
                VendorName = "XERO"
            };

            using (var context = new CompareCloudwareContext())
            {
                context.Vendors.Add(vendor);
                context.SaveChanges();
            }
        }
        #endregion

        #region StageData
        private static void StageData()
        {
            var data = new FakeData();
            //var context = new FakeCloudCompareContext();
            //var context = new CloudCompareContext();
            //string conn = ConfigurationManager.ConnectionStrings["CompareCloudware.POCOQueryRepository.CloudCompareContext"].ConnectionString;
            var context = new CompareCloudwareContext();
            data.LoadFakeReferenceData(context);
            try
            {
                context.SaveChanges();
            }
            catch (DbEntityValidationException dbEx)
            {
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
            }
            catch (DbUpdateException dbEx)
            {
                foreach (var validationErrors in dbEx.Entries)
                {
                    //foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        //Trace.TraceInformation("Property: {0} Error: {1}", validationErrors.Property, validationErrors.ErrorMessage);
                    }
                }
            }
            


            data.LoadFakeProductionData(context);
            //data.SetLiveStatuses(context);
            try
            {
                context.SaveChanges();
            }
            catch (DbEntityValidationException dbEx)
            {
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
            }
            catch (DbUpdateException dbEx)
            {
                foreach (var validationErrors in dbEx.Entries)
                {
                    //foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        //Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
            }

        
        
            //LoadRatings();
            //LoadApplicationWeightings();
            //LoadTwitterFollowers();
            //LoadFacebookFans();


        }
        #endregion

        #region ContentTextData
        private static void ContentTextData()
        {
            var data = new FakeData();
            //var context = new FakeCloudCompareContext();
            //var context = new CloudCompareContext();
            //string conn = ConfigurationManager.ConnectionStrings["CompareCloudware.POCOQueryRepository.CloudCompareContext"].ConnectionString;
            var context = new CompareCloudwareContext();
            data.LoadFakeContentTextData(context);
            try
            {
                context.SaveChanges();
            }
            catch (DbEntityValidationException dbEx)
            {
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
            }
            catch (DbUpdateException dbEx)
            {
                foreach (var validationErrors in dbEx.Entries)
                {
                    //foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        //Trace.TraceInformation("Property: {0} Error: {1}", validationErrors.Property, validationErrors.ErrorMessage);
                    }
                }
            }



        }
        #endregion

        #region LoadRatings
        private static void LoadRatings()
        {

            Random r = new Random();
            var data = new FakeData();
            //var context = new FakeCloudCompareContext();
            //var context = new CloudCompareContext();
            //string conn = ConfigurationManager.ConnectionStrings["CompareCloudware.POCOQueryRepository.CloudCompareContext"].ConnectionString;
            var context = new CompareCloudwareContext();
            //data.LoadFakeReferenceData(context);
            data.InsertRatings(context, r);
            try
            {
                context.SaveChanges();
            }
            catch (DbEntityValidationException dbEx)
            {
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
            }
            catch (DbUpdateException dbEx)
            {
                foreach (var validationErrors in dbEx.Entries)
                {
                    //foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        //Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
            }

        }
        #endregion

        #region LoadStatuses
        private static void LoadStatuses()
        {

            Random r = new Random();
            var data = new FakeData();
            //var context = new FakeCloudCompareContext();
            //var context = new CloudCompareContext();
            //string conn = ConfigurationManager.ConnectionStrings["CompareCloudware.POCOQueryRepository.CloudCompareContext"].ConnectionString;
            var context = new CompareCloudwareContext();
            //data.LoadFakeReferenceData(context);
            data.SetLiveStatuses(context);
            try
            {
                context.SaveChanges();
            }
            catch (DbEntityValidationException dbEx)
            {
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
            }
            catch (DbUpdateException dbEx)
            {
                foreach (var validationErrors in dbEx.Entries)
                {
                    //foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        //Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
            }

        }
        #endregion

        #region LoadApplicationWeightings
        private static void LoadApplicationWeightings()
        {

            Random r = new Random();
            var data = new FakeData();
            //var context = new FakeCloudCompareContext();
            //var context = new CloudCompareContext();
            //string conn = ConfigurationManager.ConnectionStrings["CompareCloudware.POCOQueryRepository.CloudCompareContext"].ConnectionString;
            var context = new CompareCloudwareContext();
            //data.LoadFakeReferenceData(context);
            data.InsertApplicationWeightings(context,r);
            try
            {
                context.SaveChanges();
            }
            catch (DbEntityValidationException dbEx)
            {
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
            }
            catch (DbUpdateException dbEx)
            {
                foreach (var validationErrors in dbEx.Entries)
                {
                    //foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        //Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
            }

        }
        #endregion

        #region LoadTwitterFollowers
        private static void LoadTwitterFollowers()
        {
            var data = new FakeData();
            //var context = new FakeCloudCompareContext();
            //var context = new CloudCompareContext();
            //string conn = ConfigurationManager.ConnectionStrings["CompareCloudware.POCOQueryRepository.CloudCompareContext"].ConnectionString;
            var context = new CompareCloudwareContext();
            //data.LoadFakeReferenceData(context);
            data.InsertTwitterFollowers(context);
            try
            {
                context.SaveChanges();
            }
            catch (DbEntityValidationException dbEx)
            {
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
            }
            catch (DbUpdateException dbEx)
            {
                foreach (var validationErrors in dbEx.Entries)
                {
                    //foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        //Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
            }
        }
        #endregion

        #region LoadFacebookFans
        private static void LoadFacebookFans()
        {
            var data = new FakeData();
            //var context = new FakeCloudCompareContext();
            //var context = new CloudCompareContext();
            //string conn = ConfigurationManager.ConnectionStrings["CompareCloudware.POCOQueryRepository.CloudCompareContext"].ConnectionString;
            var context = new CompareCloudwareContext();
            //data.LoadFakeReferenceData(context);
            data.InsertFacebookFans(context);
            try
            {
                context.SaveChanges();
            }
            catch (DbEntityValidationException dbEx)
            {
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
            }
            catch (DbUpdateException dbEx)
            {
                foreach (var validationErrors in dbEx.Entries)
                {
                    //foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        //Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
            }
        }
        #endregion

        #region LoadLinkedInFollowers
        private static void LoadLinkedInFollowers()
        {
            var data = new FakeData();
            //var context = new FakeCloudCompareContext();
            //var context = new CloudCompareContext();
            //string conn = ConfigurationManager.ConnectionStrings["CompareCloudware.POCOQueryRepository.CloudCompareContext"].ConnectionString;
            var context = new CompareCloudwareContext();
            //data.LoadFakeReferenceData(context);
            data.InsertLinkedInFollowers(context);
            try
            {
                context.SaveChanges();
            }
            catch (DbEntityValidationException dbEx)
            {
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
            }
            catch (DbUpdateException dbEx)
            {
                foreach (var validationErrors in dbEx.Entries)
                {
                    //foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        //Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
            }

        }
        #endregion

        #region LoadVideos
        private static void LoadVideos()
        {
            var data = new FakeData();
            //var context = new FakeCloudCompareContext();
            //var context = new CloudCompareContext();
            //string conn = ConfigurationManager.ConnectionStrings["CompareCloudware.POCOQueryRepository.CloudCompareContext"].ConnectionString;
            var context = new CompareCloudwareContext();
            //data.LoadFakeReferenceData(context);
            data.InsertVideos(context);
            try
            {
                context.SaveChanges();
            }
            catch (DbEntityValidationException dbEx)
            {
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
            }
            catch (DbUpdateException dbEx)
            {
                foreach (var validationErrors in dbEx.Entries)
                {
                    //foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        //Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
            }

        }
        #endregion

        #region LoadWhitePaperCaseStudyBytes
        private static void LoadWhitePaperCaseStudyBytes()
        {
            var data = new FakeData();
            //var context = new FakeCloudCompareContext();
            //var context = new CloudCompareContext();
            //string conn = ConfigurationManager.ConnectionStrings["CompareCloudware.POCOQueryRepository.CloudCompareContext"].ConnectionString;
            var context = new CompareCloudwareContext();
            //data.LoadFakeReferenceData(context);

            bool retVal = true;
            while (retVal == true)
            {
                retVal = data.InsertWhitePaperCaseStudyBytes(context);
            }
            try
            {
                context.SaveChanges();
            }
            catch (DbEntityValidationException dbEx)
            {
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
            }
            catch (DbUpdateException dbEx)
            {
                foreach (var validationErrors in dbEx.Entries)
                {
                    //foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        //Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
            }

        }
        #endregion

        #region CheckFacebookName
        private static long CheckFacebookName(string name)
        {
            var data = new FakeData();
            //var context = new FakeCloudCompareContext();
            //var context = new CloudCompareContext();
            //string conn = ConfigurationManager.ConnectionStrings["CompareCloudware.POCOQueryRepository.CloudCompareContext"].ConnectionString;
            var context = new CompareCloudwareContext();
            //data.LoadFakeReferenceData(context);
            long retVal = data.CheckFacebookFan(name);
            return retVal;
        }
        #endregion

        #region GetThumbnail
        private static void GetThumbnail(string fileName)
        {
            var document = ShellObject.FromParsingName(fileName);
        }
        #endregion

        #region LoadSkyscrapersMPUs
        private static void LoadSkyscrapersMPUs()
        {
            var data = new FakeData();
            //var context = new FakeCloudCompareContext();
            //var context = new CloudCompareContext();
            //string conn = ConfigurationManager.ConnectionStrings["CompareCloudware.POCOQueryRepository.CloudCompareContext"].ConnectionString;
            var context = new CompareCloudwareContext();
            //data.LoadFakeReferenceData(context);
            data.LoadSkyscrapersMPUs(context);
            try
            {
                context.SaveChanges();
            }
            catch (DbEntityValidationException dbEx)
            {
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
            }
            catch (DbUpdateException dbEx)
            {
                foreach (var validationErrors in dbEx.Entries)
                {
                    //foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        //Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
            }
        }
        #endregion

        #region LoadMissingLogos
        private static void LoadMissingLogos()
        {
            var data = new FakeData();
            var context = new CompareCloudwareContext();
            data.InsertMissingLogos(context);
            try
            {
                context.SaveChanges();
            }
            catch (DbEntityValidationException dbEx)
            {
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
            }
            catch (DbUpdateException dbEx)
            {
                foreach (var validationErrors in dbEx.Entries)
                {
                    //foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        //Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
            }

        }
        #endregion

        #region Logs
        private static void Logs()
        {
            var data = new FakeData();
            //var context = new FakeCloudCompareContext();
            //var context = new CloudCompareContext();
            //string conn = ConfigurationManager.ConnectionStrings["CompareCloudware.POCOQueryRepository.CloudCompareContext"].ConnectionString;
            var context = new CompareCloudwareContext();
            data.PumpLogs(context);
            try
            {
                context.SaveChanges();
            }
            catch (DbEntityValidationException dbEx)
            {
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
            }
            catch (DbUpdateException dbEx)
            {
                foreach (var validationErrors in dbEx.Entries)
                {
                    //foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        //Trace.TraceInformation("Property: {0} Error: {1}", validationErrors.Property, validationErrors.ErrorMessage);
                    }
                }
            }



        }
        #endregion

        #region LoadSageOneAccountsExtra
        private static void LoadSageOneAccountsExtra()
        {
            var data = new FakeData();
            var context = new CompareCloudwareContext();
            data.LoadSageOneAccountsExtra(context);
            try
            {
                context.SaveChanges();
            }
            catch (DbEntityValidationException dbEx)
            {
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
            }
            catch (DbUpdateException dbEx)
            {
                foreach (var validationErrors in dbEx.Entries)
                {
                    //foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        //Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
            }

        }
        #endregion

        #region LoadLiquidPlanner
        private static void LoadLiquidPlanner()
        {
            var data = new FakeData();
            var context = new CompareCloudwareContext();


            data.LoadLiquidPlannerLogo(context);
            try
            {
                context.SaveChanges();
            }
            catch (DbEntityValidationException dbEx)
            {
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
            }
            catch (DbUpdateException dbEx)
            {
                foreach (var validationErrors in dbEx.Entries)
                {
                    //foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        //Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
            }

            
            data.LoadLiquidPlanner(context);
            try
            {
                context.SaveChanges();
            }
            catch (DbEntityValidationException dbEx)
            {
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
            }
            catch (DbUpdateException dbEx)
            {
                foreach (var validationErrors in dbEx.Entries)
                {
                    //foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        //Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
            }

        }
        #endregion

        #region LoadMikogo
        private static void LoadMikogo()
        {
            var data = new FakeData();
            var context = new CompareCloudwareContext();


            data.LoadMikogoLogo(context);
            try
            {
                context.SaveChanges();
            }
            catch (DbEntityValidationException dbEx)
            {
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
            }
            catch (DbUpdateException dbEx)
            {
                foreach (var validationErrors in dbEx.Entries)
                {
                    //foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        //Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
            }


            data.LoadMikogo(context);
            try
            {
                context.SaveChanges();
            }
            catch (DbEntityValidationException dbEx)
            {
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
            }
            catch (DbUpdateException dbEx)
            {
                foreach (var validationErrors in dbEx.Entries)
                {
                    //foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        //Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
            }

        }
        #endregion

        #region LoadEgnyteBusiness
        private static void LoadEgnyteBusiness()
        {
            var data = new FakeData();
            var context = new CompareCloudwareContext();
            data.LoadEgnyteBusiness(context);
            try
            {
                context.SaveChanges();
            }
            catch (DbEntityValidationException dbEx)
            {
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
            }
            catch (DbUpdateException dbEx)
            {
                foreach (var validationErrors in dbEx.Entries)
                {
                    //foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        //Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
            }

        }
        #endregion

        #region LoadEgnyteEnterprise
        private static void LoadEgnyteEnterprise()
        {
            var data = new FakeData();
            var context = new CompareCloudwareContext();
            data.LoadEgnyteEnterprise(context);
            try
            {
                context.SaveChanges();
            }
            catch (DbEntityValidationException dbEx)
            {
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
            }
            catch (DbUpdateException dbEx)
            {
                foreach (var validationErrors in dbEx.Entries)
                {
                    //foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        //Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
            }

        }
        #endregion

        #region LoadGFICloudAntiVirus
        private static void LoadGFICloudAntiVirus()
        {
            var data = new FakeData();
            var context = new CompareCloudwareContext();
            data.LoadGFICloudAntiVirus(context);
            try
            {
                context.SaveChanges();
            }
            catch (DbEntityValidationException dbEx)
            {
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
            }
            catch (DbUpdateException dbEx)
            {
                foreach (var validationErrors in dbEx.Entries)
                {
                    //foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        //Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
            }

        }
        #endregion

        #region LoadGFICloudWebProtection
        private static void LoadGFICloudWebProtection()
        {
            var data = new FakeData();
            var context = new CompareCloudwareContext();
            data.LoadGFICloudWebProtection(context);
            try
            {
                context.SaveChanges();
            }
            catch (DbEntityValidationException dbEx)
            {
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
            }
            catch (DbUpdateException dbEx)
            {
                foreach (var validationErrors in dbEx.Entries)
                {
                    //foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        //Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
            }

        }
        #endregion

        #region LoadGFICloudRemoteSupport
        private static void LoadGFICloudRemoteSupport()
        {
            var data = new FakeData();
            var context = new CompareCloudwareContext();
            data.LoadGFICloudRemoteSupport(context);
            try
            {
                context.SaveChanges();
            }
            catch (DbEntityValidationException dbEx)
            {
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
            }
            catch (DbUpdateException dbEx)
            {
                foreach (var validationErrors in dbEx.Entries)
                {
                    //foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        //Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
            }

        }
        #endregion

        #region LoadCommence
        private static void LoadCommence()
        {
            var data = new FakeData();
            var context = new CompareCloudwareContext();


            data.LoadCommenceLogo(context);
            try
            {
                context.SaveChanges();
            }
            catch (DbEntityValidationException dbEx)
            {
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
            }
            catch (DbUpdateException dbEx)
            {
                foreach (var validationErrors in dbEx.Entries)
                {
                    //foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        //Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
            }


            data.LoadCommence(context);
            try
            {
                context.SaveChanges();
            }
            catch (DbEntityValidationException dbEx)
            {
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
            }
            catch (DbUpdateException dbEx)
            {
                foreach (var validationErrors in dbEx.Entries)
                {
                    //foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        //Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
            }

        }
        #endregion

        #region LoadAVGLogo
        private static void LoadAVGLogo()
        {
            var data = new FakeData();
            var context = new CompareCloudwareContext();

            data.LoadAVGLogo(context);
            try
            {
                context.SaveChanges();
            }
            catch (DbEntityValidationException dbEx)
            {
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
            }
            catch (DbUpdateException dbEx)
            {
                foreach (var validationErrors in dbEx.Entries)
                {
                    //foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        //Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
            }
        }
        #endregion

        #region LoadAVGAntiVirus2014
        private static void LoadAVGAntiVirus2014()
        {
            var data = new FakeData();
            var context = new CompareCloudwareContext();

            data.LoadAVGAntiVirus2014(context);
            try
            {
                context.SaveChanges();
            }
            catch (DbEntityValidationException dbEx)
            {
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
            }
            catch (DbUpdateException dbEx)
            {
                foreach (var validationErrors in dbEx.Entries)
                {
                    //foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        //Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
            }
        }
        #endregion

        #region LoadAVGInternetSecurity2014
        private static void LoadAVGInternetSecurity2014()
        {
            var data = new FakeData();
            var context = new CompareCloudwareContext();

            data.LoadAVGInternetSecurity2014(context);
            try
            {
                context.SaveChanges();
            }
            catch (DbEntityValidationException dbEx)
            {
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
            }
            catch (DbUpdateException dbEx)
            {
                foreach (var validationErrors in dbEx.Entries)
                {
                    //foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        //Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
            }
        }
        #endregion

        #region LoadAVGPremiumSecurity2014
        private static void LoadAVGPremiumSecurity2014()
        {
            var data = new FakeData();
            var context = new CompareCloudwareContext();

            data.LoadAVGPremiumSecurity2014(context);
            try
            {
                context.SaveChanges();
            }
            catch (DbEntityValidationException dbEx)
            {
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
            }
            catch (DbUpdateException dbEx)
            {
                foreach (var validationErrors in dbEx.Entries)
                {
                    //foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        //Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
            }
        }
        #endregion

        #region LoadAVGAntiVirusForMac2014
        private static void LoadAVGAntiVirusForMac2014()
        {
            var data = new FakeData();
            var context = new CompareCloudwareContext();

            data.LoadAVGAntiVirusForMac2014(context);
            try
            {
                context.SaveChanges();
            }
            catch (DbEntityValidationException dbEx)
            {
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
            }
            catch (DbUpdateException dbEx)
            {
                foreach (var validationErrors in dbEx.Entries)
                {
                    //foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        //Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
            }
        }
        #endregion

        #region LoadAVGFileServer2014
        private static void LoadAVGFileServer2014()
        {
            var data = new FakeData();
            var context = new CompareCloudwareContext();

            data.LoadAVGFileServer2014(context);
            try
            {
                context.SaveChanges();
            }
            catch (DbEntityValidationException dbEx)
            {
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
            }
            catch (DbUpdateException dbEx)
            {
                foreach (var validationErrors in dbEx.Entries)
                {
                    //foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        //Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
            }
        }
        #endregion

        #region LoadAVGBusinessAntiVirus
        private static void LoadAVGBusinessAntiVirus()
        {
            var data = new FakeData();
            var context = new CompareCloudwareContext();

            data.LoadAVGBusinessAntiVirus(context);
            try
            {
                context.SaveChanges();
            }
            catch (DbEntityValidationException dbEx)
            {
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
            }
            catch (DbUpdateException dbEx)
            {
                foreach (var validationErrors in dbEx.Entries)
                {
                    //foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        //Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
            }
        }
        #endregion

        #region LoadAVGBusinessInternetSecurity
        private static void LoadAVGBusinessInternetSecurity()
        {
            var data = new FakeData();
            var context = new CompareCloudwareContext();

            data.LoadAVGBusinessInternetSecurity(context);
            try
            {
                context.SaveChanges();
            }
            catch (DbEntityValidationException dbEx)
            {
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
            }
            catch (DbUpdateException dbEx)
            {
                foreach (var validationErrors in dbEx.Entries)
                {
                    //foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        //Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
            }
        }
        #endregion

        #region LoadAVGCloudCare
        private static void LoadAVGCloudCare()
        {
            var data = new FakeData();
            var context = new CompareCloudwareContext();

            data.LoadAVGCloudCare(context);
            try
            {
                context.SaveChanges();
            }
            catch (DbEntityValidationException dbEx)
            {
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
            }
            catch (DbUpdateException dbEx)
            {
                foreach (var validationErrors in dbEx.Entries)
                {
                    //foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        //Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
            }
        }
        #endregion

        #region LoadKasperskyLogo
        private static void LoadKasperskyLogo()
        {
            var data = new FakeData();
            var context = new CompareCloudwareContext();

            data.LoadKasperskyLogo(context);
            try
            {
                context.SaveChanges();
            }
            catch (DbEntityValidationException dbEx)
            {
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
            }
            catch (DbUpdateException dbEx)
            {
                foreach (var validationErrors in dbEx.Entries)
                {
                    //foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        //Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
            }
        }
        #endregion

        #region LoadKasperskyPure30
        private static void LoadKasperskyPure30()
        {
            var data = new FakeData();
            var context = new CompareCloudwareContext();

            data.LoadKasperskyPure30(context);
            try
            {
                context.SaveChanges();
            }
            catch (DbEntityValidationException dbEx)
            {
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
            }
            catch (DbUpdateException dbEx)
            {
                foreach (var validationErrors in dbEx.Entries)
                {
                    //foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        //Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
            }
        }
        #endregion

        #region LoadKasperskyInternetSecurity2014
        private static void LoadKasperskyInternetSecurity2014()
        {
            var data = new FakeData();
            var context = new CompareCloudwareContext();

            data.LoadKasperskyInternetSecurity2014(context);
            try
            {
                context.SaveChanges();
            }
            catch (DbEntityValidationException dbEx)
            {
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
            }
            catch (DbUpdateException dbEx)
            {
                foreach (var validationErrors in dbEx.Entries)
                {
                    //foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        //Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
            }
        }
        #endregion

        #region LoadKasperskyAntiVirus2014
        private static void LoadKasperskyAntiVirus2014()
        {
            var data = new FakeData();
            var context = new CompareCloudwareContext();

            data.LoadKasperskyAntiVirus2014(context);
            try
            {
                context.SaveChanges();
            }
            catch (DbEntityValidationException dbEx)
            {
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
            }
            catch (DbUpdateException dbEx)
            {
                foreach (var validationErrors in dbEx.Entries)
                {
                    //foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        //Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
            }
        }
        #endregion

        #region LoadKasperskyInternetSecurityMultiDevice
        private static void LoadKasperskyInternetSecurityMultiDevice()
        {
            var data = new FakeData();
            var context = new CompareCloudwareContext();

            data.LoadKasperskyInternetSecurityMultiDevice(context);
            try
            {
                context.SaveChanges();
            }
            catch (DbEntityValidationException dbEx)
            {
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
            }
            catch (DbUpdateException dbEx)
            {
                foreach (var validationErrors in dbEx.Entries)
                {
                    //foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        //Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
            }
        }
        #endregion

        #region LoadKasperskySecurityForMac
        private static void LoadKasperskySecurityForMac()
        {
            var data = new FakeData();
            var context = new CompareCloudwareContext();

            data.LoadKasperskySecurityForMac(context);
            try
            {
                context.SaveChanges();
            }
            catch (DbEntityValidationException dbEx)
            {
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
            }
            catch (DbUpdateException dbEx)
            {
                foreach (var validationErrors in dbEx.Entries)
                {
                    //foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        //Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
            }
        }
        #endregion

        #region LoadKasperskyEndpointForBusinessAdvanced
        private static void LoadKasperskyEndpointForBusinessAdvanced()
        {
            var data = new FakeData();
            var context = new CompareCloudwareContext();

            data.LoadKasperskyEndpointForBusinessAdvanced(context);
            try
            {
                context.SaveChanges();
            }
            catch (DbEntityValidationException dbEx)
            {
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
            }
            catch (DbUpdateException dbEx)
            {
                foreach (var validationErrors in dbEx.Entries)
                {
                    //foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        //Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
            }
        }
        #endregion

        #region LoadKasperskyEndpointForBusinessSelect
        private static void LoadKasperskyEndpointForBusinessSelect()
        {
            var data = new FakeData();
            var context = new CompareCloudwareContext();

            data.LoadKasperskyEndpointForBusinessSelect(context);
            try
            {
                context.SaveChanges();
            }
            catch (DbEntityValidationException dbEx)
            {
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
            }
            catch (DbUpdateException dbEx)
            {
                foreach (var validationErrors in dbEx.Entries)
                {
                    //foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        //Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
            }
        }
        #endregion

        #region LoadKasperskyEndpointForBusinessCore
        private static void LoadKasperskyEndpointForBusinessCore()
        {
            var data = new FakeData();
            var context = new CompareCloudwareContext();

            data.LoadKasperskyEndpointForBusinessCore(context);
            try
            {
                context.SaveChanges();
            }
            catch (DbEntityValidationException dbEx)
            {
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
            }
            catch (DbUpdateException dbEx)
            {
                foreach (var validationErrors in dbEx.Entries)
                {
                    //foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        //Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
            }
        }
        #endregion

        #region LoadKasperskyTotalSecurityForBusiness
        private static void LoadKasperskyTotalSecurityForBusiness()
        {
            var data = new FakeData();
            var context = new CompareCloudwareContext();

            data.LoadKasperskyTotalSecurityForBusiness(context);
            try
            {
                context.SaveChanges();
            }
            catch (DbEntityValidationException dbEx)
            {
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
            }
            catch (DbUpdateException dbEx)
            {
                foreach (var validationErrors in dbEx.Entries)
                {
                    //foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        //Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
            }
        }
        #endregion

        #region LoadKasperskyTargetedSecuritySolutions
        private static void LoadKasperskyTargetedSecuritySolutions()
        {
            var data = new FakeData();
            var context = new CompareCloudwareContext();

            data.LoadKasperskyTargetedSecuritySolutions(context);
            try
            {
                context.SaveChanges();
            }
            catch (DbEntityValidationException dbEx)
            {
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
            }
            catch (DbUpdateException dbEx)
            {
                foreach (var validationErrors in dbEx.Entries)
                {
                    //foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        //Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
            }
        }
        #endregion

        #region LoadKasperskySmallOfficeSecurity
        private static void LoadKasperskySmallOfficeSecurity()
        {
            var data = new FakeData();
            var context = new CompareCloudwareContext();

            data.LoadKasperskySmallOfficeSecurity(context);
            try
            {
                context.SaveChanges();
            }
            catch (DbEntityValidationException dbEx)
            {
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
            }
            catch (DbUpdateException dbEx)
            {
                foreach (var validationErrors in dbEx.Entries)
                {
                    //foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        //Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
            }
        }
        #endregion

        #region LoadURLTagTypeData
        private static void LoadURLTagTypeData()
        {
            var data = new FakeData();
            var context = new CompareCloudwareContext();

            data.LoadURLTagTypeData(context);
            try
            {
                context.SaveChanges();
            }
            catch (DbEntityValidationException dbEx)
            {
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
            }
            catch (DbUpdateException dbEx)
            {
                foreach (var validationErrors in dbEx.Entries)
                {
                    //foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        //Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
            }
        }
        #endregion

        #region LoadTagData
        private static void LoadTagData()
        {
            var data = new FakeData();
            var context = new CompareCloudwareContext();

            data.LoadTagData(context);
            try
            {
                context.SaveChanges();
            }
            catch (DbEntityValidationException dbEx)
            {
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
            }
            catch (DbUpdateException dbEx)
            {
                foreach (var validationErrors in dbEx.Entries)
                {
                    //foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        //Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
            }
        }
        #endregion

        #region LoadCategoryURLTagData
        private static void LoadCategorytURLTagData()
        {
            var data = new FakeData();
            var context = new CompareCloudwareContext();

            data.LoadCategoryURLTagData(context);
            try
            {
                context.SaveChanges();
            }
            catch (DbEntityValidationException dbEx)
            {
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
            }
            catch (DbUpdateException dbEx)
            {
                foreach (var validationErrors in dbEx.Entries)
                {
                    //foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        //Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
            }
        }
        #endregion

        #region LoadShopURLTagData
        private static void LoadShopURLTagData()
        {
            var data = new FakeData();
            var context = new CompareCloudwareContext();

            data.LoadShopURLTagData(context);
            try
            {
                context.SaveChanges();
            }
            catch (DbEntityValidationException dbEx)
            {
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
            }
            catch (DbUpdateException dbEx)
            {
                foreach (var validationErrors in dbEx.Entries)
                {
                    //foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        //Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
            }
        }
        #endregion

        #region LoadContentPageData
        private static void LoadContentPageData()
        {
            var data = new FakeData();
            var context = new CompareCloudwareContext();

            data.LoadContentPageData(context);
            try
            {
                context.SaveChanges();
            }
            catch (DbEntityValidationException dbEx)
            {
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
            }
            catch (DbUpdateException dbEx)
            {
                foreach (var validationErrors in dbEx.Entries)
                {
                    //foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        //Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
            }
        }
        #endregion

        #region LoadContextTextTypesForH1H2
        private static void LoadContextTextTypesForH1H2()
        {
            var data = new FakeData();
            var context = new CompareCloudwareContext();

            data.LoadContextTextTypesForH1H2(context);
            try
            {
                context.SaveChanges();
            }
            catch (DbEntityValidationException dbEx)
            {
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
            }
            catch (DbUpdateException dbEx)
            {
                foreach (var validationErrors in dbEx.Entries)
                {
                    //foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        //Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
            }
        }
        #endregion

        #region LoadContextTextDataForH1H2
        private static void LoadContextTextDataForH1H2()
        {
            var data = new FakeData();
            var context = new CompareCloudwareContext();

            data.LoadContextTextDataForH1H2(context);
            try
            {
                context.SaveChanges();
            }
            catch (DbEntityValidationException dbEx)
            {
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
            }
            catch (DbUpdateException dbEx)
            {
                foreach (var validationErrors in dbEx.Entries)
                {
                    //foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        //Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
            }
        }
        #endregion

        #region LoadCarboniteBusinessPlus
        private static void LoadCarboniteBusinessPlus()
        {
            var data = new FakeData();
            var context = new CompareCloudwareContext();
            CloudApplication ca = data.LoadCarboniteBusinessPlus(context);
            try
            {
                context.SaveChanges();
            }
            catch (DbEntityValidationException dbEx)
            {
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
            }
            catch (DbUpdateException dbEx)
            {
                foreach (var validationErrors in dbEx.Entries)
                {
                    //foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        //Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
            }


            ca = data.LoadCarboniteBusinessPlusSEO(context,ca);
            try
            {
                context.SaveChanges();
            }
            catch (DbEntityValidationException dbEx)
            {
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
            }
            catch (DbUpdateException dbEx)
            {
                foreach (var validationErrors in dbEx.Entries)
                {
                    //foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        //Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
            }


        }
        #endregion

        #region LoadSecondCategories
        private static void LoadSecondCategories()
        {
            var data = new FakeData();
            var context = new CompareCloudwareContext();
            var repository = new QueryRepository(context);

            var retVal = CompareCloudware.POCOQueryRepository.DataPump.ReferenceData.PumpSecondCategories(repository);
            try
            {
                context.SaveChanges();
            }
            catch (DbEntityValidationException dbEx)
            {
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
            }
            catch (DbUpdateException dbEx)
            {
                foreach (var validationErrors in dbEx.Entries)
                {
                    //foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        //Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
            }
        }
        #endregion

        #region LoadContextTextTypesForTabs
        private static void LoadContextTextTypesForTabs()
        {
            var data = new FakeData();
            var context = new CompareCloudwareContext();

            data.LoadContextTextTypesForTabs(context);
            try
            {
                context.SaveChanges();
            }
            catch (DbEntityValidationException dbEx)
            {
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
            }
            catch (DbUpdateException dbEx)
            {
                foreach (var validationErrors in dbEx.Entries)
                {
                    //foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        //Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
            }
        }
        #endregion

        #region LoadAvastLogo
        private static void LoadAvastLogo()
        {
            var data = new FakeData();
            var context = new CompareCloudwareContext();

            data.LoadAvastLogo(context);
            try
            {
                context.SaveChanges();
            }
            catch (DbEntityValidationException dbEx)
            {
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
            }
            catch (DbUpdateException dbEx)
            {
                foreach (var validationErrors in dbEx.Entries)
                {
                    //foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        //Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
            }
        }
        #endregion

        #region LoadAvastEndpointProtection
        private static void LoadAvastEndpointProtection()
        {
            var data = new FakeData();
            var context = new CompareCloudwareContext();

            data.LoadAvastEndpointProtection(context);
            try
            {
                context.SaveChanges();
            }
            catch (DbEntityValidationException dbEx)
            {
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
            }
            catch (DbUpdateException dbEx)
            {
                foreach (var validationErrors in dbEx.Entries)
                {
                    //foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        //Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
            }
        }
        #endregion

        #region LoadAvastEndpointProtectionPlus
        private static void LoadAvastEndpointProtectionPlus()
        {
            var data = new FakeData();
            var context = new CompareCloudwareContext();

            data.LoadAvastEndpointProtectionPlus(context);
            try
            {
                context.SaveChanges();
            }
            catch (DbEntityValidationException dbEx)
            {
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
            }
            catch (DbUpdateException dbEx)
            {
                foreach (var validationErrors in dbEx.Entries)
                {
                    //foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        //Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
            }
        }
        #endregion

    }
}
