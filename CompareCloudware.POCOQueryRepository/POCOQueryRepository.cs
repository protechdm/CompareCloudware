using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Configuration;
using System.Data.Entity;
using CompareCloudware.Domain.Models;
using CompareCloudware.Domain.Contracts.Repositories;
using LinqKit;
using CompareCloudware.POCOQueryRepository.Helpers;
using CompareCloudware.POCOQueryRepository.Caching;
using System.Configuration;
using CompareCloudware.SocialNetworking;
//using System.Data.Objects;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Core;

using System.Transactions;

using System.Data.Entity.Infrastructure;

namespace CompareCloudware.POCOQueryRepository
{
    public class QueryRepository : BaseRepository, ICompareCloudwareRepository, IDisposable
    {
        //const string FILTER_BROWSERS = "BROWSERS";
        const string FILTER_BROWSERS = "BROWSER";
        //const string FILTER_FEATURES = "FEATURES";
        const string FILTER_FEATURES = "FEATURE";
        //const string FILTER_APPLICATIONFEATURES = "APPLICATIONFEATURES";
        const string FILTER_APPLICATIONFEATURES = "APPLICATIONFEATURE";
        //const string FILTER_OPERATINGSYSTEMS = "OPERATINGSYSTEMS";
        const string FILTER_OPERATINGSYSTEMS = "OPERATINGSYSTEM";
        //const string FILTER_DEVICES = "DEVICES";
        const string FILTER_DEVICES = "DEVICE";
        //const string FILTER_SUPPORTTYPES = "SUPPORTTYPES";
        const string FILTER_SUPPORTTYPES = "SUPPORTTYPE";
        const string FILTER_SUPPORTDAYS = "SUPPORTDAYS";
        const string FILTER_SUPPORTHOURS = "SUPPORTHOURS";
        //const string FILTER_LANGUAGES = "LANGUAGES";
        const string FILTER_LANGUAGES = "LANGUAGE";
        //const string FILTER_MOBILEPLATFORMS = "MOBILEPLATFORMS";
        const string FILTER_MOBILEPLATFORMS = "MOBILEPLATFORM";
        //const string FILTER_TIMEZONES = "TIMEZONES";
        const string FILTER_TIMEZONES = "TIMEZONE";

        const int CATEGORY_ID_PHONE = 1;
        const int CATEGORY_ID_CRM = 2;
        const int CATEGORY_ID_WEB_CONFERENCING = 3;
        const int CATEGORY_ID_EMAIL = 4;
        const int CATEGORY_ID_OFFICE = 5;
        const int CATEGORY_ID_STORAGE_AND_BACKUP = 6;
        const int CATEGORY_ID_PROJECT_MANAGEMENT = 7;
        const int CATEGORY_ID_FINANCIAL = 8;
        const int CATEGORY_ID_SECURITY = 9;
        const int CATEGORY_ID_COMMUNICATIONS = 19;

        const int CATEGORY_ID_MARKETING = 10;
        const int CATEGORY_ID_WEBSITE = 11;
        const int CATEGORY_ID_CREATIVE = 12;
        const int CATEGORY_ID_BUSINESS_INTELLIGENCE_REPORTING = 13;
        const int CATEGORY_ID_HOSTING = 14;
        const int CATEGORY_ID_HR = 15;
        const int CATEGORY_ID_PAYMENTS = 16;
        const int CATEGORY_ID_BUSINESS_AND_OPERATIONS = 17;
        const int CATEGORY_ID_SALES = 18;

        const string TAG_CATEGORY_URL = "CATEGORY URL";
        const string TAG_SHOP_URL = "SHOP URL";

        ICompareCloudwareContext _context;

        public ICacheProvider Cache { get; set; }

        #region Constructors
        //public QueryRepository()
        //{
        //    _context = new CloudCompareContext();
        //}

        public QueryRepository(ICompareCloudwareContext context)
            : base(context as CompareCloudwareContext)
        {
            _context = context;
        }

        public QueryRepository(CompareCloudwareContext context)
            : base(context)
        {
            _context = context;
        }

        public QueryRepository(ICompareCloudwareContext context, ICacheProvider cacheProvider)
            : base(context as CompareCloudwareContext)
        {
            _context = context;
            this.Cache = cacheProvider;
        }


        #endregion

        #region GetCloudApplicationsForVendor
        public IList<CloudApplication> GetCloudApplicationsForVendor(int? vendorID)
        {
            if (!vendorID.HasValue || vendorID.Value < 1)
            {
                throw new ArgumentOutOfRangeException();
            }
            return _context.CloudApplications.
              Where(ca => ca.Vendor.VendorID == vendorID).ToList();
        }
        #endregion

        #region Save
        public string Save()
        {
            string validationErrors = "";
            if (PreSavingValidations(out validationErrors) == true)
            {
                //this Save is not taking n-tier issues into account
                _context.SaveChanges();
                return "";
            }
            else
                return "Data Not Saved due to Validation Errors: " + validationErrors;
        }
        #endregion

        #region PreSavingValidations
        public bool PreSavingValidations(out string validationErrors)
        {
            bool isvalid = true;
            validationErrors = "";

            //foreach (Reservation res in _context.ManagedReservations)
            //{
            //    try
            //    {
            //        bool isResValid;
            //        string validationError;
            //        isResValid = res.ValidateBeforeSave(out validationError);
            //        if (!isResValid)
            //        {
            //            isvalid = false;
            //            validationErrors += validationError;
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        throw ex;
            //    }
            //}
            return isvalid;
        }
        #endregion

        #region AddCloudApplication
        public void AddCloudApplication(CloudApplication ca)
        {
            _context.CloudApplications.Add(ca);

            
            //_context.CloudApplications.Add(ca);

            //var objectContext = _context.ObjectContext();
            //var modified1 = objectContext.ObjectStateManager.GetObjectStateEntries(System.Data.EntityState.Added).OfType<CloudApplication>();
            //var modified2 = objectContext.ObjectStateManager.GetObjectStateEntries(System.Data.EntityState.Deleted).OfType<CloudApplication>();
            //var modified3 = objectContext.ObjectStateManager.GetObjectStateEntries(System.Data.EntityState.Modified).OfType<CloudApplication>();
            //var modified4 = objectContext.ObjectStateManager.GetObjectStateEntries(System.Data.EntityState.Unchanged).OfType<CloudApplication>();

            //var modified5 = objectContext.ObjectStateManager.GetObjectStateEntries(System.Data.EntityState.Added).Select(e => e.Entity).OfType<CloudApplication>();
            //var modified6 = objectContext.ObjectStateManager.GetObjectStateEntries(System.Data.EntityState.Deleted);
            //var modified7 = objectContext.ObjectStateManager.GetObjectStateEntries(System.Data.EntityState.Modified);
            //var modified8 = objectContext.ObjectStateManager.GetObjectStateEntries(System.Data.EntityState.Unchanged);

        }
        #endregion

        #region UpdateCloudApplication
        public void UpdateCloudApplication(CloudApplication ca)
        {
            _context.CloudApplications.Add(ca);

            _context.CloudApplications.Add(ca);

            var objectContext = _context.ObjectContext();
            //var modified1 = objectContext.ObjectStateManager.GetObjectStateEntries(System.Data.EntityState.Added).OfType<CloudApplication>();
            //var modified2 = objectContext.ObjectStateManager.GetObjectStateEntries(System.Data.EntityState.Deleted).OfType<CloudApplication>();
            //var modified3 = objectContext.ObjectStateManager.GetObjectStateEntries(System.Data.EntityState.Modified).OfType<CloudApplication>();
            //var modified4 = objectContext.ObjectStateManager.GetObjectStateEntries(System.Data.EntityState.Unchanged).OfType<CloudApplication>();

            var modified5 = objectContext.ObjectStateManager.GetObjectStateEntries(EntityState.Added).Select(e => e.Entity).OfType<CloudApplication>();
            
            //var modified6 = objectContext.ObjectStateManager.GetObjectStateEntries(System.Data.EntityState.Deleted);
            //var modified7 = objectContext.ObjectStateManager.GetObjectStateEntries(System.Data.EntityState.Modified);
            //var modified8 = objectContext.ObjectStateManager.GetObjectStateEntries(System.Data.EntityState.Unchanged);

        }
        #endregion

        #region GetCloudApplicationContextAdded
        public CloudApplication GetCloudApplicationContextAdded()
        {

            //var retVal2 = (from ca in _context.CloudApplications select ca).FirstOrDefault();
            //var objectContext = ((IObjectContextAdapter)this).ObjectContext;
            var objectContext = _context.ObjectContext();
            var added = objectContext.ObjectStateManager.GetObjectStateEntries(EntityState.Added).Select(e => e.Entity).OfType<CloudApplication>().FirstOrDefault();
            //return retVal2;
            return added;
        }
        #endregion

        #region GetCloudApplicationContextModified
        public CloudApplication GetCloudApplicationContextModified()
        {

            //var retVal2 = (from ca in _context.CloudApplications select ca).FirstOrDefault();
            //var objectContext = ((IObjectContextAdapter)this).ObjectContext;
            var objectContext = _context.ObjectContext();
            var modified = objectContext.ObjectStateManager.GetObjectStateEntries(EntityState.Modified).Select(e => e.Entity).OfType<CloudApplication>().FirstOrDefault();
            //return retVal2;
            return modified;
        }
        #endregion

        #region GetCloudApplicationContextUnchanged
        public IList<CloudApplication> GetCloudApplicationContextUnchanged()
        {

            //var retVal2 = (from ca in _context.CloudApplications select ca).FirstOrDefault();
            //var objectContext = ((IObjectContextAdapter)this).ObjectContext;
            var objectContext = _context.ObjectContext();
            var modified = objectContext.ObjectStateManager.GetObjectStateEntries(EntityState.Unchanged).Select(e => e.Entity).OfType<CloudApplication>()
                .ToList();
                //.FirstOrDefault();
            //return retVal2;
            return modified;
        }
        #endregion

        #region AddFeature
        public void AddFeature(Feature f)
        {
            _context.Features.Add(f);
        }
        #endregion

        #region AddFeatureType
        public void AddFeatureType(FeatureType ft)
        {
            _context.FeatureTypes.Add(ft);
        }
        #endregion

        #region AddOperatingSystem
        public void AddOperatingSystem(CompareCloudware.Domain.Models.OperatingSystem os)
        {
            _context.OperatingSystems.Add(os);
        }
        #endregion

        #region AddMobilePlatform
        public void AddMobilePlatform(MobilePlatform mp)
        {
            _context.MobilePlatforms.Add(mp);
        }
        #endregion

        #region AddBrowser
        public void AddBrowser(Browser b)
        {
            _context.Browsers.Add(b);
        }
        #endregion

        #region AddLicenceTypeMinimum
        public bool AddLicenceTypeMinimum(LicenceTypeMinimum ltm)
        {
            _context.LicenceTypeMinimums.Add(ltm);
            return true;
        }
        #endregion

        #region AddLicenceTypeMaximum
        public bool AddLicenceTypeMaximum(LicenceTypeMaximum ltm)
        {
            _context.LicenceTypeMaximums.Add(ltm);
            return true;
        }
        #endregion

        #region AddLanguage
        public void AddLanguage(Language l)
        {
            _context.Languages.Add(l);
        }
        #endregion

        #region AddSupportType
        public void AddSupportType(SupportType st)
        {
            _context.SupportTypes.Add(st);
        }
        #endregion

        #region AddSupportDays
        public bool AddSupportDays(SupportDays sd)
        {
            bool retVal = true;
            try
            {
                _context.SupportDays.Add(sd);
            }
            catch
            {
                retVal = false;
            }
            return retVal;
        }
        #endregion

        #region AddSupportHours
        public void AddSupportHours(SupportHours sh)
        {
            _context.SupportHours.Add(sh);
        }
        #endregion

        #region AddTimeZone
        public void AddTimeZone(CompareCloudware.Domain.Models.TimeZone tz)
        {
            _context.TimeZones.Add(tz);
        }
        #endregion

        #region AddSupportTerritory
        public void AddSupportTerritory(SupportTerritory st)
        {
            _context.SupportTerritories.Add(st);
        }
        #endregion

        #region AddCategory
        public void AddCategory(Category c)
        {
            _context.Categories.Add(c);
        }
        #endregion

        #region AddCurrency
        public bool AddCurrency(Currency cur)
        {
            _context.Currencies.Add(cur);
            return true;
        }
        #endregion

        #region AddCategoryParameters
        public void AddCategoryParameters(CategoryParameters cp)
        {
            _context.CategoryParameters.Add(cp);
        }
        #endregion

        #region AddMinimumContract
        public void AddMinimumContract(MinimumContract mc)
        {
            _context.MinimumContracts.Add(mc);
        }
        #endregion

        #region AddPaymentFrequency
        public void AddPaymentFrequency(PaymentFrequency pf)
        {
            _context.PaymentFrequencies.Add(pf);
        }
        #endregion

        #region AddSetupFee
        public void AddSetupFee(SetupFee sf)
        {
            _context.SetupFees.Add(sf);
        }
        #endregion

        #region AddPaymentOption
        public void AddPaymentOption(PaymentOption po)
        {
            _context.PaymentOptions.Add(po);
        }
        #endregion

        #region AddFreeTrialPeriod
        public void AddFreeTrialPeriod(FreeTrialPeriod ftp)
        {
            _context.FreeTrialPeriods.Add(ftp);
        }
        #endregion

        #region AddVendor
        public void AddVendor(Vendor v)
        {
            _context.Vendors.Add(v);
        }
        #endregion

        #region AddCloudApplicationDocumentType
        public void AddCloudApplicationDocumentType(CloudApplicationDocumentType dt)
        {
            _context.CloudApplicationDocumentTypes.Add(dt);
        }
        #endregion

        #region AddCloudApplicationDocument
        public void AddCloudApplicationDocument(CloudApplicationDocument cad)
        {
            _context.CloudApplicationDocuments.Add(cad);
        }
        #endregion

        #region AddCloudApplicationDocumentFormat
        public void AddCloudApplicationDocumentFormat(CloudApplicationDocumentFormat df)
        {
            _context.CloudApplicationDocumentFormats.Add(df);
        }
        #endregion

        #region AddAdvertisingImageType
        public void AddAdvertisingImageType(AdvertisingImageType ait)
        {
            _context.AdvertisingImageTypes.Add(ait);
        }
        #endregion

        #region AddAdvertisingImage
        public void AddAdvertisingImage(AdvertisingImage ai)
        {
            _context.AdvertisingImages.Add(ai);
        }
        #endregion

        #region AddTagType
        public void AddTagType(TagType tt)
        {
            _context.TagTypes.Add(tt);
        }
        #endregion

        #region AddTag
        public void AddTag(Tag t)
        {
            _context.Tags.Add(t);
        }
        #endregion

        #region AddContentTextType
        public void AddContentTextType(ContentTextType ctt)
        {
            _context.ContentTextTypes.Add(ctt);
        }
        #endregion

        #region AddContentText
        public void AddContentText(ContentText ct)
        {
            _context.ContentText.Add(ct);
        }
        #endregion

        #region AddTermCondition
        public void AddTermCondition(TermCondition tc)
        {
            _context.TermsConditions.Add(tc);
        }
        #endregion

        #region AddColleagueLink
        public bool AddColleagueLink(Colleague c)
        {
            _context.Colleagues.Add(c);
            int retVal = _context.SaveChanges();
            return retVal >= 1;
        }
        #endregion

        #region FindRecommender
        public Colleague FindRecommender(int colleaguePersonID)
        {
            Colleague c1 = _context.Colleagues.Where(x => x.ColleagueOfIntroducer.PersonID == colleaguePersonID).FirstOrDefault();
            Colleague c2 = (from cf in _context.Colleagues
                                  where cf.ColleagueOfIntroducer.PersonID == colleaguePersonID
                                  select cf).FirstOrDefault();

            if (c2 == null)
            {
                throw new Exception("Cannot find colleague");
            }
            return c2;
        }
        #endregion

        #region AddDevice
        public void AddDevice(Device d)
        {
            _context.Devices.Add(d);
        }
        #endregion

        #region AddIndustry
        public bool AddIndustry(Industry i)
        {
            _context.Industries.Add(i);
            return true;
        }
        #endregion

        #region FindCategoryByName
        public Category FindCategoryByName(string categoryName)
        {
            Category f1 = _context.Categories.Where(x => x.CategoryName.ToUpper().StartsWith(categoryName.ToUpper())).FirstOrDefault();
            Category f2 = (from cf in _context.Categories
                           where cf.CategoryName.ToUpper().StartsWith(categoryName.ToUpper())
                           select cf).FirstOrDefault();

            if (f2 == null)
            {
                throw new Exception("Cannot find category");
            }
            return f2;
        }
        #endregion

        #region FindCategoryByID
        public Category FindCategoryByID(int categoryID)
        {
            //Category f1 = _context.Categories.Where(x => x.CategoryName.ToUpper().StartsWith(categoryName.ToUpper())).FirstOrDefault();
            Category f2 = (from cf in _context.Categories
                           where cf.CategoryID == categoryID
                           select cf)
                           //.AsNoTracking()
                           .Include(c => c.CategoryStatus)
                           .FirstOrDefault();

            if (f2 == null)
            {
                throw new Exception("Cannot find category");
            }
            return f2;
        }
        #endregion

        #region FindFeatureByName
        public CloudApplicationFeature FindFeatureByName(string featureName)
        {
            Feature f1 = _context.Features.Where(x => x.FeatureName.ToUpper().StartsWith(featureName.ToUpper())).FirstOrDefault();
            var f2 = (from cf in _context.Features
                          where cf.FeatureName.ToUpper().StartsWith(featureName.ToUpper())
                          select cf);

            if (f2 == null)
            {
                throw new Exception("Cannot find feature");
            }
            if (f2.Count() > 1)
            {
                throw new Exception("More than 1 feature with this name : " + featureName);
            }

            return new CloudApplicationFeature()
            {
                Feature = f2.FirstOrDefault(),
                CloudApplicationFeatureStatus = f2.FirstOrDefault().FeatureStatus,
            }
            ;
            
        }

        public CloudApplicationFeature FindFeatureByName(string featureName, int categoryID)
        {
            Feature f1 = _context.Features.Where(x => x.FeatureName.ToUpper().StartsWith(featureName.ToUpper())).FirstOrDefault();
            var f2 = (from cf in _context.Features
                      where cf.FeatureName.ToUpper().StartsWith(featureName.ToUpper())
                      && cf.Categories.Any(x => x.CategoryID == categoryID)
                      select cf);

            if (f2 == null)
            {
                throw new Exception("Cannot find feature");
            }
            if (f2.Count() > 1)
            {
                throw new Exception("More than 1 feature with this name : " + featureName);
            }
            return new CloudApplicationFeature()
            {
                Feature = f2.FirstOrDefault(),
                CloudApplicationFeatureStatus = f2.FirstOrDefault().FeatureStatus,
            }
            ;

        }

        public CloudApplicationFeature FindFeatureByName(string featureName, int categoryID, bool exactMatch)
        {
            Feature f1 = null;
            IQueryable<Feature> f2 = null;
            if (exactMatch)
            {
                f1 = _context.Features.Where(x => x.FeatureName.ToUpper().StartsWith(featureName.ToUpper())).FirstOrDefault();
                f2 = (from cf in _context.Features
                          where cf.FeatureName.ToUpper() == featureName
                          && cf.Categories.Any(x => x.CategoryID == categoryID)
                          select cf);
            }
            else
            {
                f1 = _context.Features.Where(x => x.FeatureName.ToUpper().StartsWith(featureName.ToUpper())).FirstOrDefault();
                f2 = (from cf in _context.Features
                          where cf.FeatureName.ToUpper().StartsWith(featureName.ToUpper())
                          && cf.Categories.Any(x => x.CategoryID == categoryID)
                          select cf);
            }

            if (f2 == null)
            {
                throw new Exception("Cannot find feature");
            }
            if (f2.Count() > 1)
            {
                throw new Exception("More than 1 feature with this name : " + featureName);
            }
            return new CloudApplicationFeature()
            {
                Feature = f2.FirstOrDefault(),
                CloudApplicationFeatureStatus = f2.FirstOrDefault().FeatureStatus,
            }
            ;
            
        }

        #endregion

        #region FindCloudApplicationFeatureByName
        public CloudApplicationFeature FindCloudApplicationFeatureByName(string featureName)
        {
            Feature f1 = _context.Features.Where(x => x.FeatureName.ToUpper().StartsWith(featureName.ToUpper())).FirstOrDefault();
            var f2 = (from cf in _context.Features
                      where cf.FeatureName.ToUpper().StartsWith(featureName.ToUpper())
                      select cf);

            if (f2 == null)
            {
                throw new Exception("Cannot find feature");
            }
            if (f2.Count() > 1)
            {
                throw new Exception("More than 1 feature with this name : " + featureName);
            }

            return new CloudApplicationFeature()
            {
                Feature = f2.FirstOrDefault(),
                CloudApplicationFeatureStatus = f2.FirstOrDefault().FeatureStatus,
            }
            ;

        }

        public CloudApplicationFeature FindCloudApplicationFeatureByName(string featureName, int categoryID)
        {
            Feature f1 = _context.Features.Where(x => x.FeatureName.ToUpper().StartsWith(featureName.ToUpper())).FirstOrDefault();
            var f2 = (from cf in _context.Features
                      where cf.FeatureName.ToUpper().StartsWith(featureName.ToUpper())
                      && cf.Categories.Any(x => x.CategoryID == categoryID)
                      select cf);

            if (f2 == null)
            {
                throw new Exception("Cannot find feature");
            }
            if (f2.Count() > 1)
            {
                throw new Exception("More than 1 feature with this name : " + featureName);
            }
            return new CloudApplicationFeature()
            {
                Feature = f2.FirstOrDefault(),
                CloudApplicationFeatureStatus = f2.FirstOrDefault().FeatureStatus,
            }
            ;

        }

        public CloudApplicationFeature FindCloudApplicationFeatureByName(string featureName, int cloudApplicationID, int categoryID, bool exactMatch)
        {
            IQueryable<Feature> f1 = null;
            IQueryable<CloudApplicationFeature> f2 = null;
            if (exactMatch)
            {
                //f1 = _context.CloudApplicationFeatures.Where(x => x.Feature.FeatureName.ToUpper().StartsWith(featureName.ToUpper())).FirstOrDefault();
                f2 = (from cf in _context.CloudApplicationFeatures
                      where cf.Feature.FeatureName.ToUpper() == featureName
                      && cf.Feature.Categories.Any(x => x.CategoryID == categoryID)
                      && cf.CloudApplication.CloudApplicationID == cloudApplicationID
                      select cf);
            }
            else
            {
                //f1 = _context.CloudApplicationFeatures.Where(x => x.Feature.FeatureName.ToUpper().StartsWith(featureName.ToUpper())).FirstOrDefault();
                f2 = (from cf in _context.CloudApplicationFeatures
                      where cf.Feature.FeatureName.ToUpper().StartsWith(featureName.ToUpper())
                      && cf.Feature.Categories.Any(x => x.CategoryID == categoryID)
                      && cf.CloudApplication.CloudApplicationID == cloudApplicationID
                      select cf);
            }

            if (f2 == null)
            {
                if (exactMatch)
                {
                    f1 = (from cf in _context.Features
                          where cf.FeatureName.ToUpper() == featureName
                          && cf.Categories.Any(x => x.CategoryID == categoryID)
                          select cf);

                    if (f1 == null)
                    {
                        throw new Exception("Cannot find feature");
                    }
                    if (f1.Count() > 1)
                    {
                        throw new Exception("More than 1 feature with this name : " + featureName);
                    }

                    return new CloudApplicationFeature()
                    {
                        Feature = f1.FirstOrDefault(),
                        CloudApplicationFeatureStatus = f1.FirstOrDefault().FeatureStatus,
                    }
                    ;
                }
                else
                {
                    f1 = (from cf in _context.Features
                          where cf.FeatureName.ToUpper() == featureName
                          && cf.Categories.Any(x => x.CategoryID == categoryID)
                          select cf);

                    if (f1 == null)
                    {
                        throw new Exception("Cannot find feature");
                    }
                    if (f1.Count() > 1)
                    {
                        throw new Exception("More than 1 feature with this name : " + featureName);
                    }

                    return new CloudApplicationFeature()
                    {
                        Feature = f1.FirstOrDefault(),
                        CloudApplicationFeatureStatus = f1.FirstOrDefault().FeatureStatus,
                    }
                    ;
                }
            }
            else
            {
                if (f2.Count() > 1)
                {
                    throw new Exception("More than 1 feature with this name : " + featureName);
                }
                return f2.FirstOrDefault();
            }
            ;

        }

        #endregion

        #region FindCloudApplicationApplicationByName
        public CloudApplicationApplication FindCloudApplicationApplicationByName(string featureName)
        {
            Feature f1 = _context.Features.Where(x => x.FeatureName.ToUpper().StartsWith(featureName.ToUpper())).FirstOrDefault();
            var f2 = (from cf in _context.Features
                      where cf.FeatureName.ToUpper().StartsWith(featureName.ToUpper())
                      select cf);

            if (f2 == null)
            {
                throw new Exception("Cannot find feature");
            }
            if (f2.Count() > 1)
            {
                throw new Exception("More than 1 feature with this name : " + featureName);
            }

            return new CloudApplicationApplication()
            {
                Feature = f2.FirstOrDefault(),
                CloudApplicationApplicationStatus = f2.FirstOrDefault().FeatureStatus,
            }
            ;

        }

        public CloudApplicationApplication FindCloudApplicationApplicationByName(string featureName, int categoryID)
        {
            Feature f1 = _context.Features.Where(x => x.FeatureName.ToUpper().StartsWith(featureName.ToUpper())).FirstOrDefault();
            var f2 = (from cf in _context.Features
                      where cf.FeatureName.ToUpper().StartsWith(featureName.ToUpper())
                      && cf.Categories.Any(x => x.CategoryID == categoryID)
                      select cf);

            if (f2 == null)
            {
                throw new Exception("Cannot find feature");
            }
            if (f2.Count() > 1)
            {
                throw new Exception("More than 1 feature with this name : " + featureName);
            }
            return new CloudApplicationApplication()
            {
                Feature = f2.FirstOrDefault(),
                CloudApplicationApplicationStatus = f2.FirstOrDefault().FeatureStatus,
            }
            ;

        }

        public CloudApplicationApplication FindCloudApplicationApplicationByName(string featureName, int cloudApplicationID, int categoryID, bool exactMatch)
        {
            IQueryable<Feature> f1 = null;
            IQueryable<CloudApplicationApplication> f2 = null;
            if (exactMatch)
            {
                //f1 = _context.CloudApplicationFeatures.Where(x => x.Feature.FeatureName.ToUpper().StartsWith(featureName.ToUpper())).FirstOrDefault();
                f2 = (from cf in _context.CloudApplicationApplications
                      where cf.Feature.FeatureName.ToUpper() == featureName
                      && cf.Feature.Categories.Any(x => x.CategoryID == categoryID)
                      && cf.CloudApplication.CloudApplicationID == cloudApplicationID
                      select cf);
            }
            else
            {
                //f1 = _context.CloudApplicationFeatures.Where(x => x.Feature.FeatureName.ToUpper().StartsWith(featureName.ToUpper())).FirstOrDefault();
                f2 = (from cf in _context.CloudApplicationApplications
                      where cf.Feature.FeatureName.ToUpper().StartsWith(featureName.ToUpper())
                      && cf.Feature.Categories.Any(x => x.CategoryID == categoryID)
                      && cf.CloudApplication.CloudApplicationID == cloudApplicationID
                      select cf);
            }

            if (f2 == null)
            {
                if (exactMatch)
                {
                    f1 = (from cf in _context.Features
                          where cf.FeatureName.ToUpper() == featureName
                          && cf.Categories.Any(x => x.CategoryID == categoryID)
                          select cf);

                    if (f1 == null)
                    {
                        throw new Exception("Cannot find application");
                    }
                    if (f1.Count() > 1)
                    {
                        throw new Exception("More than 1 application with this name");
                    }

                    return new CloudApplicationApplication()
                    {
                        Feature = f1.FirstOrDefault(),
                        CloudApplicationApplicationStatus = f1.FirstOrDefault().FeatureStatus,
                    }
                    ;
                }
                else
                {
                    f1 = (from cf in _context.Features
                          where cf.FeatureName.ToUpper() == featureName
                          && cf.Categories.Any(x => x.CategoryID == categoryID)
                          select cf);

                    if (f1 == null)
                    {
                        throw new Exception("Cannot find application");
                    }
                    if (f1.Count() > 1)
                    {
                        throw new Exception("More than 1 application with this name");
                    }

                    return new CloudApplicationApplication()
                    {
                        Feature = f1.FirstOrDefault(),
                        CloudApplicationApplicationStatus = f1.FirstOrDefault().FeatureStatus,
                    }
                    ;
                }
            }
            else
            {
                if (f2.Count() > 1)
                {
                    throw new Exception("More than 1 application with this name");
                }
                return f2.FirstOrDefault();
            }
            ;

        }

        #endregion

        #region FindFeatureTypeByName
        public FeatureType FindFeatureTypeByName(string featureTypeName)
        {
            FeatureType f1 = _context.FeatureTypes.Where(x => x.FeatureTypeName.ToUpper().StartsWith(featureTypeName.ToUpper())).FirstOrDefault();
            var f2 = (from cf in _context.FeatureTypes
                      where cf.FeatureTypeName.ToUpper().StartsWith(featureTypeName.ToUpper())
                      select cf);

            if (f2.Count() == 0)
            {
                throw new Exception("Cannot find feature type");
            }
            if (f2.Count() > 1)
            {
                throw new Exception("More than 1 feature type with this name");
            }

            return f2.FirstOrDefault();
        }
        #endregion

        #region FindApplicationByName
        public CloudApplicationApplication FindApplicationByName(string applicationName)
        {
            Feature f1 = _context.Features.Where(x => x.FeatureName.ToUpper() == applicationName.ToUpper()).FirstOrDefault();
            var f2 = (from cf in _context.Features
                      where cf.FeatureName.ToUpper() == applicationName.ToUpper()
                      select cf);

            if (f2 == null)
            {
                throw new Exception("Cannot find feature");
            }
            if (f2.Count() == 0)
            {
                throw new Exception("Cannot find feature");
            }
            if (f2.Count() > 1)
            {
                throw new Exception("More than 1 application-feature with this name : " + applicationName);
            }

            //CloudApplicationApplication caa = new CloudApplicationApplication();
            //caa.Feature = f2.FirstOrDefault();
            //return caa;

            return new CloudApplicationApplication()
            {
                Feature = f2.FirstOrDefault(),
                CloudApplicationApplicationStatus = f2.FirstOrDefault().FeatureStatus,
            }
            ;

        }

        public CloudApplicationApplication FindApplicationByName(string applicationName, int categoryID)
        {
            Feature f1 = _context.Features.Where(x => x.FeatureName.ToUpper().StartsWith(applicationName.ToUpper())).FirstOrDefault();
            var f2 = (from cf in _context.Features
                      where cf.FeatureName.ToUpper().StartsWith(applicationName.ToUpper())
                      && cf.Categories.Any(x => x.CategoryID == categoryID)
                      select cf);

            if (f2 == null)
            {
                throw new Exception("Cannot find feature : " + applicationName);
            }
            if (f2.Count() > 1)
            {
                throw new Exception("More than 1 application-feature with this name : " + applicationName);
            }
            return new CloudApplicationApplication()
            {
                Feature = f2.FirstOrDefault(),
                CloudApplicationApplicationStatus = f2.FirstOrDefault().FeatureStatus,
            }
            ;

        }

        public CloudApplicationApplication FindApplicationByName(string applicationName, int categoryID, bool exactMatch)
        {
            Feature f1 = null;
            IQueryable<Feature> f2 = null;
            if (exactMatch)
            {
                //f1 = _context.Features.Where(x => x.FeatureName.ToUpper().StartsWith(featureName.ToUpper())).FirstOrDefault();
                f2 = (from cf in _context.Features
                      where cf.FeatureName.ToUpper() == applicationName
                      && cf.Categories.Any(x => x.CategoryID == categoryID)
                      select cf);
            }
            else
            {
                //f1 = _context.Features.Where(x => x.FeatureName.ToUpper().StartsWith(featureName.ToUpper())).FirstOrDefault();
                f2 = (from cf in _context.Features
                      where cf.FeatureName.ToUpper().StartsWith(applicationName.ToUpper())
                      && cf.Categories.Any(x => x.CategoryID == categoryID)
                      select cf);
            }

            if (f2 == null)
            {
                throw new Exception("Cannot find application feature");
            }
            if (f2.Count() > 1)
            {
                throw new Exception("More than 1 application feature with this name : " + applicationName);
            }
            return new CloudApplicationApplication()
            {
                Feature = f2.FirstOrDefault(),
                CloudApplicationApplicationStatus = f2.FirstOrDefault().FeatureStatus,
            }
            ;

        }

        #endregion

        #region FindOperatingSystemByName
        public Domain.Models.OperatingSystem FindOperatingSystemByName(string operatingSystemName)
        {
            Domain.Models.OperatingSystem f1 = _context.OperatingSystems.Where(x => x.OperatingSystemName.ToUpper().StartsWith(operatingSystemName.ToUpper())).FirstOrDefault();
            Domain.Models.OperatingSystem f2 = (from cf in _context.OperatingSystems
                                                where cf.OperatingSystemName.ToUpper().StartsWith(operatingSystemName.ToUpper())
                                                select cf).FirstOrDefault();

            if (f2 == null)
            {
                throw new Exception("Cannot find O/S");
            }
            return f2;
        }
        #endregion

        #region FindDeviceByName
        public Device FindDeviceByName(string deviceName)
        {
            Domain.Models.Device f1 = _context.Devices.Where(x => x.DeviceName.ToUpper().StartsWith(deviceName.ToUpper())).FirstOrDefault();
            Domain.Models.Device f2 = (from cf in _context.Devices
                                                where cf.DeviceName.ToUpper().StartsWith(deviceName.ToUpper())
                                                select cf).FirstOrDefault();

            if (f2 == null)
            {
                throw new Exception("Cannot find device");
            }
            return f2;
        }
        #endregion

        #region GetAllMobilePlatforms
        public List<MobilePlatform> GetAllMobilePlatforms()
        {
            return _context.MobilePlatforms.ToList();
        }
        #endregion

        #region FindMobilePlatformByName
        public MobilePlatform FindMobilePlatformByName(string mobilePlatformName)
        {
            MobilePlatform f1 = _context.MobilePlatforms.Where(x => x.MobilePlatformName.ToUpper().StartsWith(mobilePlatformName.ToUpper())).FirstOrDefault();
            MobilePlatform f2 = (from cf in _context.MobilePlatforms
                                 where cf.MobilePlatformName.ToUpper().StartsWith(mobilePlatformName.ToUpper())
                                 select cf).FirstOrDefault();

            if (f2 == null)
            {
                throw new Exception("Cannot find mobile platform");
            }
            return f2;
        }
        #endregion

        #region FindBrowserByName
        public Browser FindBrowserByName(string browserName)
        {
            Browser f1 = _context.Browsers.Where(x => x.BrowserName.ToUpper().StartsWith(browserName.ToUpper())).FirstOrDefault();
            Browser f2 = (from cf in _context.Browsers
                          where cf.BrowserName.ToUpper().StartsWith(browserName.ToUpper())
                          select cf).FirstOrDefault();

            if (f2 == null)
            {
                throw new Exception("Cannot find browser");
            }
            return f2;
        }
        #endregion

        #region FindLicenceTypeMinimumByName
        public LicenceTypeMinimum FindLicenceTypeMinimumByName(int licenceTypeMinimumName)
        {
            return FindLicenceTypeMinimumByName(licenceTypeMinimumName,false);
        }

        public LicenceTypeMinimum FindLicenceTypeMinimumByName(int licenceTypeMinimumName, bool ignoreException)
        {
            //LicenceTypeMinimum f1 = _context.LicenceTypeMinimums.Where(x => x.LicenceTypeMinimumName.ToUpper().StartsWith(licenceTypeMinimumName.ToUpper())).FirstOrDefault();
            //LicenceTypeMinimum f2 = (from cf in _context.LicenceTypeMinimums
            //              where cf.LicenceTypeMinimumName.ToUpper().StartsWith(licenceTypeMinimumName.ToUpper())
            //              select cf).FirstOrDefault();

            LicenceTypeMinimum f1 = _context.LicenceTypeMinimums.Where(x => x.LicenceTypeMinimumName == licenceTypeMinimumName).FirstOrDefault();
            LicenceTypeMinimum f2 = (from cf in _context.LicenceTypeMinimums
                                     where cf.LicenceTypeMinimumName == licenceTypeMinimumName
                                     select cf).FirstOrDefault();

            if (f2 == null && !ignoreException)
            {
                throw new Exception("Cannot find licence type minimum");
            }
            return f2;
        }
        #endregion

        #region FindLicenceTypeMinimumByID
        public LicenceTypeMinimum FindLicenceTypeMinimumByID(int licenceTypeMinimumID)
        {
            //LicenceTypeMinimum f1 = _context.LicenceTypeMinimums.Where(x => x.LicenceTypeMinimumName.ToUpper().StartsWith(licenceTypeMinimumName.ToUpper())).FirstOrDefault();
            //LicenceTypeMinimum f2 = (from cf in _context.LicenceTypeMinimums
            //              where cf.LicenceTypeMinimumName.ToUpper().StartsWith(licenceTypeMinimumName.ToUpper())
            //              select cf).FirstOrDefault();

            //LicenceTypeMinimum f1 = _context.LicenceTypeMinimums.Where(x => x.LicenceTypeMinimumName == licenceTypeMinimumName).FirstOrDefault();
            LicenceTypeMinimum f2 = (from cf in _context.LicenceTypeMinimums
                                     where cf.LicenceTypeMinimumID == licenceTypeMinimumID
                                     select cf).FirstOrDefault();

            if (f2 == null)
            {
                throw new Exception("Cannot find licence type minimum");
            }
            return f2;
        }
        #endregion

        #region FindLicenceTypeMaximumByName
        public LicenceTypeMaximum FindLicenceTypeMaximumByName(int licenceTypeMaximumName)
        {
            return FindLicenceTypeMaximumByName(licenceTypeMaximumName,false);
        }

        public LicenceTypeMaximum FindLicenceTypeMaximumByName(int licenceTypeMaximumName, bool ignoreException)
        {
            //LicenceTypeMaximum f1 = _context.LicenceTypeMaximums.Where(x => x.LicenceTypeMaximumName.ToUpper().StartsWith(licenceTypeMaximumName.ToUpper())).FirstOrDefault();
            //LicenceTypeMaximum f2 = (from cf in _context.LicenceTypeMaximums
            //                         where cf.LicenceTypeMaximumName.ToUpper().StartsWith(licenceTypeMaximumName.ToUpper())
            //                         select cf).FirstOrDefault();

            LicenceTypeMaximum f1 = _context.LicenceTypeMaximums.Where(x => x.LicenceTypeMaximumName == licenceTypeMaximumName).FirstOrDefault();
            LicenceTypeMaximum f2 = (from cf in _context.LicenceTypeMaximums
                                     where cf.LicenceTypeMaximumName == licenceTypeMaximumName
                                     select cf).FirstOrDefault();

            if (f2 == null && !ignoreException)
            {
                throw new Exception("Cannot find licence type maximum");
            }
            return f2;
        }
        
        #endregion

        #region FindLicenceTypeMaximumByID
        public LicenceTypeMaximum FindLicenceTypeMaximumByID(int licenceTypeMaximumID)
        {
            //LicenceTypeMaximum f1 = _context.LicenceTypeMaximums.Where(x => x.LicenceTypeMaximumName.ToUpper().StartsWith(licenceTypeMaximumName.ToUpper())).FirstOrDefault();
            //LicenceTypeMaximum f2 = (from cf in _context.LicenceTypeMaximums
            //                         where cf.LicenceTypeMaximumName.ToUpper().StartsWith(licenceTypeMaximumName.ToUpper())
            //                         select cf).FirstOrDefault();

            //LicenceTypeMaximum f1 = _context.LicenceTypeMaximums.Where(x => x.LicenceTypeMaximumName == licenceTypeMaximumName).FirstOrDefault();
            LicenceTypeMaximum f2 = (from cf in _context.LicenceTypeMaximums
                                     where cf.LicenceTypeMaximumID == licenceTypeMaximumID
                                     select cf).FirstOrDefault();

            if (f2 == null)
            {
                throw new Exception("Cannot find licence type maximum");
            }
            return f2;
        }
        #endregion

        #region FindLanguageByName
        public Language FindLanguageByName(string languageName)
        {
            Language f1 = _context.Languages.Where(x => x.LanguageName.ToUpper().StartsWith(languageName.ToUpper())).FirstOrDefault();
            Language f2 = (from cf in _context.Languages
                           where cf.LanguageName.ToUpper().StartsWith(languageName.ToUpper())
                           select cf).FirstOrDefault();

            if (f2 == null)
            {
                throw new Exception("Cannot find language");
            }
            return f2;
        }
        #endregion


        #region FindSupportHoursByName
        public SupportHours FindSupportHoursByName(string supportHoursName)
        {
            //SupportHours f1 = _context.SupportHours.Where(x => x.SupportHoursName.ToUpper().StartsWith(supportHoursName.ToUpper())).FirstOrDefault();
            SupportHours f2 = (from cf in _context.SupportHours
                               where cf.SupportHoursName.ToUpper() == supportHoursName.ToUpper()
                               select cf).FirstOrDefault();

            if (f2 == null)
            {
                throw new Exception("Cannot find support hours");
            }
            return f2;
        }

        public SupportHours FindSupportHoursByName(int supportHoursFrom, int supportHoursTo)
        {
            //SupportHours f1 = _context.SupportHours.Where(x => x.SupportHoursName.ToUpper().StartsWith(supportHoursName.ToUpper())).FirstOrDefault();
            SupportHours f2 = (from cf in _context.SupportHours
                               where cf.SupportHoursFrom == supportHoursFrom && cf.SupportHoursTo == supportHoursTo
                               && !cf.IgnoreFilterPredicate
                               select cf).FirstOrDefault();

            if (f2 == null)
            {
                //throw new Exception("Cannot find support hours");
            }
            return f2;
        }
        #endregion

        #region FindSupportHoursByID
        public SupportHours FindSupportHoursByID(int supportHoursID)
        {
            //SupportHours f1 = _context.SupportHours.Where(x => x.SupportHoursName.ToUpper().StartsWith(supportHoursName.ToUpper())).FirstOrDefault();
            SupportHours f2 = (from cf in _context.SupportHours
                               where cf.SupportHoursID == supportHoursID
                               select cf).FirstOrDefault();

            if (f2 == null)
            {
                throw new Exception("Cannot find support hours");
            }
            return f2;
        }
        #endregion

        #region FindSupportTypeByID
        public SupportType FindSupportTypeByID(int supportTypeID)
        {
            //SupportHours f1 = _context.SupportHours.Where(x => x.SupportHoursName.ToUpper().StartsWith(supportHoursName.ToUpper())).FirstOrDefault();
            SupportType f2 = (from cf in _context.SupportTypes
                               where cf.SupportTypeID == supportTypeID
                               select cf).FirstOrDefault();

            if (f2 == null)
            {
                throw new Exception("Cannot find support type");
            }
            return f2;
        }
        #endregion

        #region FindSupportTypeByName
        public SupportType FindSupportTypeByName(string supportTypeName, bool exactMatch)
        {
            //SupportHours f1 = _context.SupportHours.Where(x => x.SupportHoursName.ToUpper().StartsWith(supportHoursName.ToUpper())).FirstOrDefault();
            SupportType f2 = (from cf in _context.SupportTypes
                              where cf.SupportTypeName.Trim().ToUpper() == supportTypeName.Trim().ToUpper()
                              select cf).FirstOrDefault();

            if (f2 == null)
            {
                throw new Exception("Cannot find support type");
            }
            return f2;
        }
        #endregion

        #region FindSupportTypeByName
        public SupportType FindSupportTypeByName(string supportTypeName)
        {
            SupportType f1 = _context.SupportTypes.Where(x => x.SupportTypeName.ToUpper().StartsWith(supportTypeName.ToUpper())).FirstOrDefault();
            SupportType f2 = (from cf in _context.SupportTypes
                              where cf.SupportTypeName.ToUpper().StartsWith(supportTypeName.ToUpper())
                              select cf).FirstOrDefault();

            if (f2 == null)
            {
                throw new Exception("Cannot find support type");
            }
            return f2;
        }
        #endregion

        #region FindTimeZoneByName
        public Domain.Models.TimeZone FindTimeZoneByName(string timeZoneName)
        {
            //SupportHours f1 = _context.SupportHours.Where(x => x.SupportHoursName.ToUpper().StartsWith(supportHoursName.ToUpper())).FirstOrDefault();
            Domain.Models.TimeZone f2 = (from cf in _context.TimeZones
                               where cf.TimeZoneName.ToUpper() == timeZoneName.ToUpper()
                               select cf).FirstOrDefault();

            if (f2 == null)
            {
                throw new Exception("Cannot find time zone");
            }
            return f2;
        }
        #endregion

        #region FindTimeZoneByID
        public Domain.Models.TimeZone FindTimeZoneByID(int timeZoneID)
        {
            //SupportHours f1 = _context.SupportHours.Where(x => x.SupportHoursName.ToUpper().StartsWith(supportHoursName.ToUpper())).FirstOrDefault();
            Domain.Models.TimeZone f2 = (from cf in _context.TimeZones
                                         where cf.TimeZoneID == timeZoneID
                                         select cf).FirstOrDefault();

            if (f2 == null)
            {
                throw new Exception("Cannot find time zone");
            }
            return f2;
        }
        #endregion

        #region FindSupportDaysByName
        public SupportDays FindSupportDaysByName(string supportDaysName)
        {
            return FindSupportDaysByName(supportDaysName, false);
        }

        public SupportDays FindSupportDaysByName(string supportDaysName, bool ignoreException)
        {
            SupportDays f1 = _context.SupportDays.Where(x => x.SupportDaysName.ToUpper().StartsWith(supportDaysName.ToUpper())).FirstOrDefault();
            SupportDays f2 = (from cf in _context.SupportDays
                              where cf.SupportDaysName.ToUpper().StartsWith(supportDaysName.ToUpper())
                              select cf).FirstOrDefault();

            if (f2 == null && !ignoreException)
            {
                throw new Exception("Cannot find support days");
            }
            return f2;
        }
        
        #endregion

        #region FindSupportTerritoryByName
        public SupportTerritory FindSupportTerritoryByName(string supportTerritoryName)
        {
            SupportTerritory f1 = _context.SupportTerritories.Where(x => x.SupportTerritoryName.ToUpper().StartsWith(supportTerritoryName.ToUpper())).FirstOrDefault();
            SupportTerritory f2 = (from cf in _context.SupportTerritories
                                   where cf.SupportTerritoryName.ToUpper().StartsWith(supportTerritoryName.ToUpper())
                                   select cf).FirstOrDefault();

            if (f2 == null)
            {
                throw new Exception("Cannot find support territory");
            }
            return f2;
        }
        #endregion

        #region FindSupportTerritoryByID
        public SupportTerritory FindSupportTerritoryByID(int supportTerritoryID)
        {
            //SupportTerritory f1 = _context.SupportTerritories.Where(x => x.SupportTerritoryName.ToUpper().StartsWith(supportTerritoryName.ToUpper())).FirstOrDefault();
            SupportTerritory f2 = (from cf in _context.SupportTerritories
                                   where cf.SupportTerritoryID == supportTerritoryID
                                   select cf).FirstOrDefault();

            if (f2 == null)
            {
                throw new Exception("Cannot find support territory");
            }
            return f2;
        }
        #endregion

        #region FindSetupFeeByName
        public SetupFee FindSetupFeeByName(string setupFeeName)
        {
            SetupFee f1 = _context.SetupFees.Where(x => x.SetupFeeName.ToUpper().StartsWith(setupFeeName.ToUpper())).FirstOrDefault();
            SetupFee f2 = (from cf in _context.SetupFees
                           where cf.SetupFeeName.ToUpper().StartsWith(setupFeeName.ToUpper())
                           select cf).FirstOrDefault();

            if (f2 == null)
            {
                throw new Exception("Cannot find setup fee");
            }
            return f2;
        }
        #endregion

        #region FindMinimumContractByName
        public MinimumContract FindMinimumContractByName(string minimumContractName)
        {
            MinimumContract f1 = _context.MinimumContracts.Where(x => x.MinimumContractName.ToUpper().StartsWith(minimumContractName.ToUpper())).FirstOrDefault();
            MinimumContract f2 = (from cf in _context.MinimumContracts
                                  where cf.MinimumContractName.ToUpper().StartsWith(minimumContractName.ToUpper())
                                  select cf).FirstOrDefault();

            if (f2 == null)
            {
                throw new Exception("Cannot find minimum contract");
            }
            return f2;
        }
        #endregion

        #region FindMinimumContractByID
        public MinimumContract FindMinimumContractByID(int minimumContractID)
        {
            //MinimumContract f1 = _context.MinimumContracts.Where(x => x.MinimumContractName.ToUpper().StartsWith(minimumContractName.ToUpper())).FirstOrDefault();
            MinimumContract f2 = (from cf in _context.MinimumContracts
                                  where cf.MinimumContractID == minimumContractID
                                  select cf).FirstOrDefault();

            if (f2 == null)
            {
                throw new Exception("Cannot find minimum contract");
            }
            return f2;
        }
        #endregion

        #region FindPaymentFrequencyByName
        public PaymentFrequency FindPaymentFrequencyByName(string paymentFrequencyName)
        {
            PaymentFrequency f1 = _context.PaymentFrequencies.Where(x => x.PaymentFrequencyName.ToUpper().StartsWith(paymentFrequencyName.ToUpper())).FirstOrDefault();
            PaymentFrequency f2 = (from cf in _context.PaymentFrequencies
                                   where cf.PaymentFrequencyName.ToUpper().StartsWith(paymentFrequencyName.ToUpper())
                                   select cf).FirstOrDefault();

            if (f2 == null)
            {
                throw new Exception("Cannot find payment frequency");
            }
            return f2;
        }
        #endregion

        #region FindPaymentFrequencyByID
        public PaymentFrequency FindPaymentFrequencyByID(int paymentFrequencyID)
        {
            //PaymentFrequency f1 = _context.PaymentFrequencies.Where(x => x.PaymentFrequencyName.ToUpper().StartsWith(paymentFrequencyName.ToUpper())).FirstOrDefault();
            PaymentFrequency f2 = (from cf in _context.PaymentFrequencies
                                   where cf.PaymentFrequencyID == paymentFrequencyID
                                   select cf).FirstOrDefault();

            if (f2 == null)
            {
                throw new Exception("Cannot find payment frequency");
            }
            return f2;
        }
        #endregion

        #region FindPaymentOptionByName
        public PaymentOption FindPaymentOptionByName(string paymentOptionName)
        {
            PaymentOption f1 = _context.PaymentOptions.Where(x => x.PaymentOptionName.ToUpper().StartsWith(paymentOptionName.ToUpper())).FirstOrDefault();
            PaymentOption f2 = (from cf in _context.PaymentOptions
                                where cf.PaymentOptionName.ToUpper().StartsWith(paymentOptionName.ToUpper())
                                select cf).FirstOrDefault();

            if (f2 == null)
            {
                throw new Exception("Cannot find payment option");
            }
            return f2;
        }
        #endregion

        #region FindFreeTrialPeriodByName
        public FreeTrialPeriod FindFreeTrialPeriodByName(string freeTrialPeriodName)
        {
            FreeTrialPeriod f1 = _context.FreeTrialPeriods.Where(x => x.FreeTrialPeriodName.ToUpper().StartsWith(freeTrialPeriodName.ToUpper())).FirstOrDefault();
            FreeTrialPeriod f2 = (from cf in _context.FreeTrialPeriods
                                  where cf.FreeTrialPeriodName.ToUpper().StartsWith(freeTrialPeriodName.ToUpper())
                                  select cf).FirstOrDefault();

            if (f2 == null)
            {
                throw new Exception("Cannot find free trial period");
            }
            return f2;
        }
        #endregion

        #region FindFreeTrialPeriodByID
        public FreeTrialPeriod FindFreeTrialPeriodByID(int freeTrialPeriodID)
        {
            //FreeTrialPeriod f1 = _context.FreeTrialPeriods.Where(x => x.FreeTrialPeriodName.ToUpper().StartsWith(freeTrialPeriodName.ToUpper())).FirstOrDefault();
            FreeTrialPeriod f2 = (from cf in _context.FreeTrialPeriods
                                  where cf.FreeTrialPeriodID == freeTrialPeriodID
                                  select cf).FirstOrDefault();

            if (f2 == null)
            {
                throw new Exception("Cannot find free trial period");
            }
            return f2;
        }
        #endregion

        #region FindVendorByName
        public Vendor FindVendorByName(string vendorName)
        {
            Vendor f1 = _context.Vendors.Where(x => x.VendorName.ToUpper().StartsWith(vendorName.ToUpper())).FirstOrDefault();
            Vendor f2 = (from cf in _context.Vendors
                         where cf.VendorName.ToUpper().StartsWith(vendorName.ToUpper())
                         select cf).FirstOrDefault();

            if (f2 == null)
            {
                throw new Exception("Cannot find vendor");
            }
            return f2;
        }
        #endregion

        #region FindVendorsByName
        public IList<Vendor> FindVendorsByName(string vendorName)
        {
            //Vendor f1 = _context.Vendors.Where(x => x.VendorName.ToUpper().StartsWith(vendorName.ToUpper())).FirstOrDefault();
            IList<Vendor> f2 = (from cf in _context.Vendors
                         where cf.VendorName.ToUpper().StartsWith(vendorName.ToUpper())
                         select cf).ToList();

            if (f2 == null)
            {
                throw new Exception("Cannot find vendor");
            }
            return f2;
        }
        #endregion

        #region FindVendorByID
        public Vendor FindVendorByID(int vendorID)
        {
            Vendor v = null;
            if (Cache != null)
            {
                v = Cache.Get("VENDOR_" + vendorID.ToString()) as Vendor;
            }
            //v = null;
            if (v == null)
            {
                //Vendor f1 = _context.Vendors.Where(x => x.VendorID == vendorID).FirstOrDefault();
                Vendor f2 = (from cf in _context.Vendors
                             where cf.VendorID == vendorID
                             select cf).FirstOrDefault();

                if (f2 == null)
                {
                    throw new Exception("Cannot find vendor");
                }
                else
                {
                    if (Cache != null)
                    {
                        int cacheTimeInHours = int.Parse(ConfigurationManager.AppSettings["CacheVendorLogoDurationHours"]);
                        Cache.Set("VENDOR_" + vendorID.ToString(), f2, cacheTimeInHours);
                    }
                }
                return f2;
            }
            else
            {
                return v;
            }
        }
        #endregion

        #region FindVendorByCloudApplicationID
        public Vendor FindVendorByCloudApplicationID(int cloudApplicationID)
        {
            //Vendor v = Cache.Get("VENDOR_" + vendorID.ToString()) as Vendor;
            //v = null;
            //if (v == null)
            {
                int vendorID;
                CloudApplication ca = _context.CloudApplications.Where(x => x.CloudApplicationID == cloudApplicationID).FirstOrDefault();
                if (ca != null)
                {
                    vendorID = ca.Vendor.VendorID;
                    Vendor f1 = _context.Vendors.Where(x => x.VendorID == vendorID).FirstOrDefault();
                    Vendor f2 = (from cf in _context.Vendors
                                 where cf.VendorID == vendorID
                                 select cf).FirstOrDefault();

                    if (f2 == null)
                    {
                        throw new Exception("Cannot find vendor");
                    }
                    else
                    {
                        int cacheTimeInHours = int.Parse(ConfigurationManager.AppSettings["CacheVendorLogoDurationHours"]);
                        Cache.Set("VENDOR_" + vendorID.ToString(), f2, cacheTimeInHours);
                    }
                    return f2;
                }
                else
                {
                    return null;
                }
            }
            //else
            //{
            //    return v;
            //}
        }
        #endregion

        #region FindCloudApplicationDocumentTypeByName
        public CloudApplicationDocumentType FindCloudApplicationDocumentTypeByName(string documentTypeName)
        {
            CloudApplicationDocumentType f1 = _context.CloudApplicationDocumentTypes.Where(x => x.CloudApplicationDocumentTypeName.ToUpper().StartsWith(documentTypeName.ToUpper())).FirstOrDefault();
            CloudApplicationDocumentType f2 = (from cf in _context.CloudApplicationDocumentTypes
                                               where cf.CloudApplicationDocumentTypeName.ToUpper().StartsWith(documentTypeName.ToUpper())
                                        select cf).FirstOrDefault();

            if (f2 == null)
            {
                throw new Exception("Cannot find document type");
            }
            return f2;
        }
        #endregion

        #region FindCloudApplicationDocumentFormatByShortName
        public CloudApplicationDocumentFormat FindCloudApplicationDocumentFormatByShortName(string documentFormatShortName)
        {
            CloudApplicationDocumentFormat f1 = _context.CloudApplicationDocumentFormats.Where(x => x.CloudApplicationDocumentFormatShortName.ToUpper().StartsWith(documentFormatShortName.ToUpper())).FirstOrDefault();
            CloudApplicationDocumentFormat f2 = (from cf in _context.CloudApplicationDocumentFormats
                                                 where cf.CloudApplicationDocumentFormatShortName.ToUpper().StartsWith(documentFormatShortName.ToUpper())
                               select cf).FirstOrDefault();

            if (f2 == null)
            {
                throw new Exception("Cannot find document format");
            }
            return f2;
        }
        #endregion

        #region FindAdvertisingImageTypeByName
        public AdvertisingImageType FindAdvertisingImageTypeByName(string advertisingImageTypeName)
        {
            AdvertisingImageType f1 = _context.AdvertisingImageTypes.Where(x => x.AdvertisingImageTypeName.ToUpper().StartsWith(advertisingImageTypeName.ToUpper())).FirstOrDefault();
            AdvertisingImageType f2 = (from cf in _context.AdvertisingImageTypes
                                       where cf.AdvertisingImageTypeName.ToUpper().StartsWith(advertisingImageTypeName.ToUpper())
                                       select cf).FirstOrDefault();

            if (f2 == null)
            {
                throw new Exception("Cannot find advertising image type");
            }
            return f2;
        }
        #endregion

        #region FindTagTypeByName
        public TagType FindTagTypeByName(string tagTypeName)
        {
            TagType f1 = _context.TagTypes.Where(x => x.TagTypeName.ToUpper().StartsWith(tagTypeName.ToUpper())).FirstOrDefault();
            TagType f2 = (from cf in _context.TagTypes
                          where cf.TagTypeName.ToUpper().StartsWith(tagTypeName.ToUpper())
                          select cf)
                          .Include(t => t.TagTypeStatus)
                          //.AsNoTracking()
                          .FirstOrDefault()
                          
                          ;

            if (f2 == null)
            {
                throw new Exception("Cannot find tag type");
            }
            return f2;
        }
        #endregion

        #region FindContentTypeByName
        public ContentTextType FindContentTextTypeByName(string contentTextTypeName)
        {
            ContentTextType f1 = _context.ContentTextTypes.Where(x => x.ContentTextTypeName.ToUpper().StartsWith(contentTextTypeName.ToUpper())).FirstOrDefault();
            ContentTextType f2 = (from cf in _context.ContentTextTypes
                           where cf.ContentTextTypeName.ToUpper().StartsWith(contentTextTypeName.ToUpper())
                           select cf).FirstOrDefault();

            if (f2 == null)
            {
                throw new Exception("Cannot find content type");
            }
            return f2;
        }
        #endregion

        #region FindContentTextByID
        public ContentText FindContentTextByID(int contentTextID)
        {
            ContentText f1 = _context.ContentText.Where(x => x.ContentTextID == contentTextID).FirstOrDefault();
            ContentText f2 = (from ct in _context.ContentText
                         where ct.ContentTextID == contentTextID
                         select ct).FirstOrDefault();

            if (f2 == null)
            {
                throw new Exception("Cannot find content text");
            }
            return f2;
        }
        #endregion

        #region GetDescription
        public string GetDescription()
        {
            return Ipsum.GetPhrase(100);
        }

        public string GetDescription(int length)
        {
            return Ipsum.GetPhrase(length);
        }
        #endregion

        #region GetFiltersOneColumn
        public IList<SearchFilterOneColumn> GetFiltersOneColumn(int categoryID, int numberOfUsers)
        {
            #region Crap
            //Data Source=.\SQLEXPRESS;Initial Catalog=CloudCompare.POCOQueryRepository.CloudCompareContext;Integrated Security=True;MultipleActiveResultSets=True
            //int n = 1;
            //var list = (
            //        from x
            //            in _context.Features
            //        where x.Category.CategoryID == 3
            //        group x by x.FeatureID into g
            //        orderby g.Count() descending
            //        select new 
            //        { 
            //            SearchFeatureID = g.Key,
            //            //Feature = g
            //        }).ToList();

            //var oddList = list.Where((cat, index) => index % 2 == 0).ToArray();
            //var evenList = list.Where((cat, index) => index % 2 == 1).ToList();

            //var retVal = 
            //    from y
            //    in _context.Features
            //    where oddList.Select(x => x.SearchFeatureID).Contains(1)
            //    select y;

            //Feature f = _context.Features.Where(x => x.FeatureID == 1).FirstOrDefault();

            //Func<Feature,SearchFeature,bool> newFunc = this.GetFirstColumn;
            //List<Feature> featurelist = _context.Features.Where(x => x.Category.CategoryID == 3)
            //    .ToList();
            #endregion


            //List<Browser> featurelist = _context.Browsers.ToList();
            IList<SearchFilterTwoColumn> allFeatures = GetSearchOptionsTwoColumn(categoryID);
            //List<Browser> featurelist = _context.Browsers.ToList();
            //IList<NumberOfUsers> numberOfUsersList = GetNumberOfUsers();
            IList<SearchFilterTwoColumn> browserList = (IList<SearchFilterTwoColumn>)GetSearchFiltersForFilterType<SearchFilterTwoColumn, SearchFilterOneColumn>(allFeatures, FILTER_BROWSERS);
            IList<SearchFilterTwoColumn> featureList = (IList<SearchFilterTwoColumn>)GetSearchFiltersForFilterType<SearchFilterTwoColumn, SearchFilterOneColumn>(allFeatures, FILTER_FEATURES);
            IList<SearchFilterTwoColumn> languageList = (IList<SearchFilterTwoColumn>)GetSearchFiltersForFilterType<SearchFilterTwoColumn, SearchFilterOneColumn>(allFeatures, FILTER_LANGUAGES);
            IList<SearchFilterTwoColumn> mobilePlatformList = (IList<SearchFilterTwoColumn>)GetSearchFiltersForFilterType<SearchFilterTwoColumn, SearchFilterOneColumn>(allFeatures, FILTER_MOBILEPLATFORMS);
            IList<SearchFilterTwoColumn> operatingSystemList = (IList<SearchFilterTwoColumn>)GetSearchFiltersForFilterType<SearchFilterTwoColumn, SearchFilterOneColumn>(allFeatures, FILTER_OPERATINGSYSTEMS);
            IList<SearchFilterTwoColumn> deviceList = (IList<SearchFilterTwoColumn>)GetSearchFiltersForFilterType<SearchFilterTwoColumn, SearchFilterOneColumn>(allFeatures, FILTER_DEVICES);
            IList<SearchFilterTwoColumn> supportDaysList = (IList<SearchFilterTwoColumn>)GetSearchFiltersForFilterType<SearchFilterTwoColumn, SearchFilterOneColumn>(allFeatures, FILTER_SUPPORTDAYS);
            IList<SearchFilterTwoColumn> supportHoursList = (IList<SearchFilterTwoColumn>)GetSearchFiltersForFilterType<SearchFilterTwoColumn, SearchFilterOneColumn>(allFeatures, FILTER_SUPPORTHOURS);
            IList<SearchFilterTwoColumn> supportTypesList = (IList<SearchFilterTwoColumn>)GetSearchFiltersForFilterType<SearchFilterTwoColumn, SearchFilterOneColumn>(allFeatures, FILTER_SUPPORTTYPES);
            IList<SearchFilterTwoColumn> applicationFeatureList = (IList<SearchFilterTwoColumn>)GetSearchFiltersForFilterType<SearchFilterTwoColumn, SearchFilterOneColumn>(allFeatures, FILTER_APPLICATIONFEATURES);
            IList<SearchFilterTwoColumn> timezoneList = (IList<SearchFilterTwoColumn>)GetSearchFiltersForFilterType<SearchFilterTwoColumn, SearchFilterOneColumn>(allFeatures, FILTER_TIMEZONES);

            browserList.ToList().AddRange(featureList.ToList());
            browserList.ToList().AddRange(languageList);
            browserList.ToList().AddRange(mobilePlatformList);
            browserList.ToList().AddRange(operatingSystemList);
            browserList.ToList().AddRange(deviceList);
            browserList.ToList().AddRange(supportDaysList);
            browserList.ToList().AddRange(supportHoursList);
            browserList.ToList().AddRange(supportTypesList);
            browserList.ToList().AddRange(applicationFeatureList);
            browserList.ToList().AddRange(timezoneList);
            //IList<SearchFilterTwoColumn> index = browserList;
            var index = (from browsers in browserList select browsers)
                .Union(from features in featureList select features)
                .Union(from languages in languageList select languages)
                .Union(from mobileplatforms in mobilePlatformList select mobileplatforms)
                .Union(from operatingsystems in operatingSystemList select operatingsystems)
                .Union(from devices in deviceList select devices)
                .Union(from supportdays in supportDaysList select supportdays)
                .Union(from supporthours in supportHoursList select supporthours)
                .Union(from supporttypes in supportTypesList select supporttypes)
                .Union(from applicationfeatures in applicationFeatureList select applicationfeatures)
                .Union(from timezones in timezoneList select timezones)
                ;

            var retVal = index.Select(x => new SearchFilterOneColumn()
                {
                    CategoryCol1 = x.CategoryCol1,
                    SearchFilterColumnNumberCol1 = x.SearchFilterColumnNumberCol1,
                    SearchFilterID = x.SearchFilterID,
                    SearchFilterParentID = x.SearchFilterParentID,
                    SearchFilterNameCol1 = x.SearchFilterNameCol1,
                    SearchFilterRowNumberCol1 = x.SearchFilterRowNumberCol1,
                    SearchFilterTypeCol1 = x.SearchFilterTypeCol1,
                    SearchFilterTypeNameCol1 = x.SearchFilterTypeNameCol1,
                    DataDrivenFieldCol1 = x.DataDrivenFieldCol1,
                    IsDataDrivenCol1 = x.IsDataDrivenCol1,
                    IsDataFloorDrivenCol1 = x.IsDataFloorDrivenCol1,
                    IsDataCeilingDrivenCol1 = x.IsDataCeilingDrivenCol1,
                    SuppressFilterBehaviour = x.SuppressFilterBehaviour,
                    CanBeBooleanAndDataDriven = x.CanBeBooleanAndDataDriven,
                });
            return retVal.ToList();
            //return null;

        }
        #endregion

        #region GetFiltersTwoColumn
        public IList<SearchFilterTwoColumn> GetFiltersTwoColumn(int categoryID, int numberOfUsers)
        {
            #region Crap
            //Data Source=.\SQLEXPRESS;Initial Catalog=CloudCompare.POCOQueryRepository.CloudCompareContext;Integrated Security=True;MultipleActiveResultSets=True
            //int n = 1;
            //var list = (
            //        from x
            //            in _context.Features
            //        where x.Category.CategoryID == 3
            //        group x by x.FeatureID into g
            //        orderby g.Count() descending
            //        select new 
            //        { 
            //            SearchFeatureID = g.Key,
            //            //Feature = g
            //        }).ToList();

            //var oddList = list.Where((cat, index) => index % 2 == 0).ToArray();
            //var evenList = list.Where((cat, index) => index % 2 == 1).ToList();

            //var retVal = 
            //    from y
            //    in _context.Features
            //    where oddList.Select(x => x.SearchFeatureID).Contains(1)
            //    select y;

            //Feature f = _context.Features.Where(x => x.FeatureID == 1).FirstOrDefault();

            //Func<Feature,SearchFeature,bool> newFunc = this.GetFirstColumn;
            //List<Feature> featurelist = _context.Features.Where(x => x.Category.CategoryID == 3)
            //    .ToList();
            #endregion


            //List<Browser> featurelist = _context.Browsers.ToList();
            IList<SearchFilterTwoColumn> allFeatures = GetSearchOptionsTwoColumn(categoryID);
            //List<Browser> featurelist = _context.Browsers.ToList();
            //IList<NumberOfUsers> numberOfUsersList = GetNumberOfUsers();
            IList<SearchFilterTwoColumn> browserList = GetSearchFiltersForFilterType<SearchFilterTwoColumn, SearchFilterTwoColumn>(allFeatures, FILTER_BROWSERS);
            IList<SearchFilterTwoColumn> featureList = (IList<SearchFilterTwoColumn>)GetSearchFiltersForFilterType<SearchFilterTwoColumn, SearchFilterOneColumn>(allFeatures, FILTER_FEATURES);
            IList<SearchFilterTwoColumn> languageList = GetSearchFiltersForFilterType<SearchFilterTwoColumn, SearchFilterTwoColumn>(allFeatures, FILTER_LANGUAGES);
            IList<SearchFilterTwoColumn> mobilePlatformList = GetSearchFiltersForFilterType<SearchFilterTwoColumn, SearchFilterTwoColumn>(allFeatures, FILTER_MOBILEPLATFORMS);
            IList<SearchFilterTwoColumn> operatingSystemList = GetSearchFiltersForFilterType<SearchFilterTwoColumn, SearchFilterTwoColumn>(allFeatures, FILTER_OPERATINGSYSTEMS);
            IList<SearchFilterTwoColumn> deviceList = GetSearchFiltersForFilterType<SearchFilterTwoColumn, SearchFilterTwoColumn>(allFeatures, FILTER_DEVICES);
            IList<SearchFilterTwoColumn> supportDaysList = GetSearchFiltersForFilterType<SearchFilterTwoColumn, SearchFilterTwoColumn>(allFeatures, FILTER_SUPPORTDAYS);
            IList<SearchFilterTwoColumn> supportHoursList = GetSearchFiltersForFilterType<SearchFilterTwoColumn, SearchFilterTwoColumn>(allFeatures, FILTER_SUPPORTHOURS);
            IList<SearchFilterTwoColumn> supportTypesList = GetSearchFiltersForFilterType<SearchFilterTwoColumn, SearchFilterTwoColumn>(allFeatures, FILTER_SUPPORTTYPES);


            browserList.ToList().AddRange(featureList.ToList());
            browserList.ToList().AddRange(languageList);
            browserList.ToList().AddRange(mobilePlatformList);
            browserList.ToList().AddRange(operatingSystemList);
            browserList.ToList().AddRange(deviceList);
            browserList.ToList().AddRange(supportDaysList);
            browserList.ToList().AddRange(supportHoursList);
            browserList.ToList().AddRange(supportTypesList);
            //IList<SearchFilterTwoColumn> index = browserList;
            var index = (from browsers in browserList select browsers)
                .Union(from features in featureList select features)
                .Union(from languages in languageList select languages)
                .Union(from mobileplatforms in mobilePlatformList select mobileplatforms)
                .Union(from operatingsystems in operatingSystemList select operatingsystems)
                .Union(from devices in deviceList select devices)
                .Union(from supportdays in supportDaysList select supportdays)
                .Union(from supporthours in supportHoursList select supporthours)
                .Union(from supporttypes in supportTypesList select supporttypes)
                ;

            return index.ToList();
            //return null;

        }
        #endregion

        //private IList<SearchFilterOneColumn> GetSearchFiltersForFilterType<T>(IList<SearchFilterOneColumn> allFilters, string filterType)
        //where T : SearchFilterOneColumn
        //{
        //    return null;
        //}

        #region GetSearchFiltersForFilterType
        private IList<Source> GetSearchFiltersForFilterType<Source, Results>(IList<Source> allFilters, string filterType)
        {
            IList<Source> retVal = null;
            if (typeof(Results) == typeof(SearchFilterOneColumn))
            {
                //IList<SearchFilterOneColumn> retVal1 = GetSearchFiltersForFilterTypeOneCol<SearchFilterOneColumn>(allFilters as IList<SearchFilterOneColumn>, filterType);
                retVal = (IList<Source>)GetSearchFiltersForFilterTypeOneCol<SearchFilterOneColumn>(allFilters as IList<SearchFilterTwoColumn>, filterType);
                //return (IList<SearchFilterOneColumn>)retVal;
                //retVal = (IList<T>)retVal1;
                //return (IList<T>)retVal;
            }
            else if (typeof(Results) == typeof(SearchFilterTwoColumn))
            {
                retVal = (IList<Source>)GetSearchFiltersForFilterTypeTwoCol<SearchFilterTwoColumn>(allFilters as IList<SearchFilterTwoColumn>, filterType);
                //return (IList<T>)retVal;
            }
            return retVal;

        }
        #endregion

        #region GetSearchFiltersForFilterTypeOneCol
        private IList<SearchFilterTwoColumn> GetSearchFiltersForFilterTypeOneCol<T>(IList<SearchFilterTwoColumn> allFilters, string filterType)
        //where T : SearchFilterTwoColumn
        {
            int nStep = 2;
            List<SearchFilterTwoColumn> filterlist = allFilters.Where(x => x.SearchFilterTypeNameCol1 == filterType).ToList();


            List<SearchFilterTwoColumn> test1 = filterlist.Select((item, i) => new SearchFilterTwoColumn()
            {
                SearchFilterNameCol1 = item.SearchFilterNameCol1,
                SearchFilterRowNumberCol1 = i,
                SearchFilterTypeNameCol1 = filterType,
                SearchFilterID = item.SearchFilterID,
                SearchFilterParentID = item.SearchFilterParentID,
                IsDataDrivenCol1 = item.IsDataDrivenCol1,
                DataDrivenFieldCol1 = item.DataDrivenFieldCol1,
                IsDataFloorDrivenCol1 = item.IsDataFloorDrivenCol1,
                IsDataCeilingDrivenCol1 = item.IsDataCeilingDrivenCol1,
                SuppressFilterBehaviour = item.SuppressFilterBehaviour,
                CanBeBooleanAndDataDriven = item.CanBeBooleanAndDataDriven,
            }).ToList();

            return (IList<SearchFilterTwoColumn>)test1.ToList();
        }
        #endregion

        #region GetValuesForFeature
        public IList<GenericSingleValue> GetValuesForFeature(Type entityType, string featureName, int categoryID)
        {
            IList<GenericSingleValue> listTemp2 = null;
            IList<GenericSingleValue> retVal2;

            if (entityType == typeof(CloudApplicationFeature))
            {
                listTemp2 = (
                    from x
                    in _context.CloudApplicationFeatures

                    //where x.Category.CategoryID == categoryID
                    where x.Feature.Categories.Any(y => y.CategoryID == categoryID)
                    && x.Feature.FeatureName == featureName
                    && x.CloudApplication != null
                    select new GenericSingleValue()
                    {
                        ValueAsDecimal = x.Count,
                        ValueSuffix = x.CountSuffix,
                        OutputDisplayType = x.Feature.OutputDisplayType,
                        OutputDisplayDescriptor = x.Feature.OutputDisplayDescriptor,
                    }
                ).Distinct().ToList();
            }
            if (entityType == typeof(CloudApplicationApplication))
            {
                listTemp2 = (
                    from x
                    in _context.CloudApplicationApplications

                    //where x.Category.CategoryID == categoryID
                    where x.Feature.Categories.Any(y => y.CategoryID == categoryID)
                    && x.Feature.FeatureName == featureName
                    && x.CloudApplication != null
                    select new GenericSingleValue()
                    {
                        ValueAsDecimal = x.Count,
                        ValueSuffix = x.CountSuffix,
                        OutputDisplayType = x.Feature.OutputDisplayType,
                        OutputDisplayDescriptor = x.Feature.OutputDisplayDescriptor,
                    }
                ).Distinct().ToList();


            }

            if (!listTemp2.ToList().Exists(x => x.ValueAsDecimal == 16384))
            {
                string valueSuffix = listTemp2[0].ValueSuffix;
                string outputDisplayType = listTemp2[0].OutputDisplayType;
                string outputDisplayDescriptor = listTemp2[0].OutputDisplayDescriptor;

                listTemp2.Add(new GenericSingleValue()
                {
                    ValueAsDecimal = 16384,
                    ValueSuffix = valueSuffix,
                    OutputDisplayType = outputDisplayType,
                    OutputDisplayDescriptor = outputDisplayDescriptor,
                });
            }

            retVal2 = listTemp2.Select(x => new GenericSingleValue()
            {
                //Value = x.Value == 16384 ? "UNLIMITED" : (x.OutputDisplayType == "INT" ? ((int)x.Value).ToString() : x.Value.ToString()),
                ValueAsDecimal = x.ValueAsDecimal == 16384 ? 16384 : x.ValueAsDecimal,
                ValueAsString = x.ValueAsDecimal == 16384 ? "UNLIMITED" : x.ValueAsDecimal.ToString(),
                ValueSuffix = x.ValueSuffix,
                OutputDisplayType = x.OutputDisplayType,
                OutputDisplayDescriptor = x.OutputDisplayDescriptor,
            }
            ).ToList();





            //if (!listTemp.Exists(x => x.Value == 16384))
            //{
            //    string valueSuffix = listTemp[0].ValueSuffix;
            //    string outputDisplayType = listTemp[0].OutputDisplayType;
            //    string outputDisplayDescriptor = listTemp[0].OutputDisplayDescriptor;

            //    listTemp.Add(new
            //    {
            //        Value = 16384M,
            //        ValueSuffix = valueSuffix,
            //        OutputDisplayType = outputDisplayType,
            //        OutputDisplayDescriptor = outputDisplayDescriptor,
            //    });
            //}

            //foreach (GenericSingleValue gsv in retVal)
            //{

            //}

            //var retVal = listTemp.Select(x => new GenericSingleValue()
            //{
            //    //Value = x.Value == 16384 ? "UNLIMITED" : (x.OutputDisplayType == "INT" ? ((int)x.Value).ToString() : x.Value.ToString()),
            //    Value = x.Value == 16384 ? "UNLIMITED" : x.Value.ToString(),
            //    ValueSuffix = x.ValueSuffix,
            //    OutputDisplayType = x.OutputDisplayType,
            //    OutputDisplayDescriptor = x.OutputDisplayDescriptor,
            //}
            //).ToList();

            return retVal2;
        }
        #endregion

        #region GetSearchFiltersForFilterTypeTwoCol
        private IList<SearchFilterTwoColumn> GetSearchFiltersForFilterTypeTwoCol<T>(IList<SearchFilterTwoColumn> allFilters, string filterType)
        //where T : SearchFilterTwoColumn
        {
            int nStep = 2;
            List<SearchFilterTwoColumn> filterlist = allFilters.Where(x => x.SearchFilterTypeNameCol1 == filterType).ToList();

            var test1 = filterlist.WhereExtended((x, i) => i % nStep == 0)
                .Select((item, i) => new SearchFilterTwoColumn()
                {
                    SearchFilterRowNumberCol1 = i,
                    SearchFilterColumnNumberCol1 = 1,
                    SearchFilterID = item.SearchFilterID,
                    SearchFilterNameCol1 = item.SearchFilterNameCol1,
                    SearchFilterTypeNameCol1 = filterType,
                })
                //.GroupBy(x => x.SearchFeatureID)
                .ToList();
            var test2 = filterlist.Where((x, i) => i % nStep == 1)
                .Select((item, i) => new SearchFilterTwoColumn()
                {
                    SearchFilterRowNumberCol1 = i,
                    SearchFilterColumnNumberCol1 = 2,
                    SearchFilterID = item.SearchFilterID,
                    SearchFilterNameCol1 = item.SearchFilterNameCol1,
                    SearchFilterTypeNameCol1 = filterType,
                })
                //.GroupBy(x => x.SearchFeatureID)
                .ToList();
            //List<SearchFeature> test3 = featurelist.Where((x, i) => i % nStep == 0)
            //    .Select(x => new SearchFeature() { SearchFeatureColumnNumber = 2, SearchFeatureID = x.FeatureID, SearchFeatureName = x.FeatureName })
            //    //.GroupBy(x => x.SearchFeatureID)
            //    .ToList();
            //var retVal = test1.ToListExtended(test2);            
            //test1.AddRange(test2);

            List<SearchFilterTwoColumn> index = test1.Select((item, i) => new SearchFilterTwoColumn()
            {
                SearchFilterNameCol1 = item.SearchFilterNameCol1,
                SearchFilterRowNumberCol1 = i,
                SearchFilterTypeNameCol1 = filterType,
                SearchFilterID = item.SearchFilterID,
                SearchFilterNameCol2 = test2.Where(x => x.SearchFilterRowNumberCol1 == item.SearchFilterRowNumberCol1).Select(x => x.SearchFilterNameCol1).FirstOrDefault(),
                SearchFilterRowNumberCol2 =
                    test2
                    .Where(x => x.SearchFilterRowNumberCol1 == item.SearchFilterRowNumberCol1)
                    .Select(x => x.SearchFilterRowNumberCol1).FirstOrDefault(),
                SearchFilterTypeNameCol2 = filterType,
            }).ToList();
            //    .First(x => x.Item == search).Index;

            //// or
            //var tagged = list.Select((item, i) => new { Item = item, Index = i });
            //int index = (from pair in tagged
            //             where pair.Item == search
            //             select pair.Index).First();

            return (IList<SearchFilterTwoColumn>)index.ToList();
            //as List<SearchFilterTwoColumn>;
            return null;

        }
        #endregion

        #region GetFirstColumn
        public bool GetFirstColumn(Feature f, SearchFilterOneColumn row)
        {
            return false;
            //int counter = 0;
            ////This will yield when counter is 0 or 1, and not when it's 2, 3, or 4.
            ////The result is yield two, skip 3, repeat.
            //foreach (Browser line in GetBrowsers())
            //{
            //    if (counter == 1)
            //        yield return line;

            //    //add one to the counter and have it wrap, 
            //    //so it is always between 0 and 4 (inclusive).
            //    counter = (counter + 1) % 2;
            //}
        }
        #endregion

        #region GetCategories
        public IList<Category> GetCategories()
        {
            Logger.Debug("GetCategories()");
            IList<Category> list = null;
            try
            {
                list = (from x in _context.Categories
                        select x)
                        .Where(x => x.CategoryStatus.StatusName.ToUpper() == "LIVE")
                        .OrderBy(x => x.CategoryName)
                    .ToList();

            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message, ex);
            }
            return list;
        }
        #endregion

        #region GetSupportDays
        public IList<SupportDays> GetSupportDays()
        {
            Logger.Debug("GetSupportDays()");
            IList<SupportDays> list = null;
            try
            {
                list = (from x in _context.SupportDays where x.SupportDaysStatus.StatusName.ToUpper() == "LIVE"
                        select x)
                        .OrderBy(x => x.SupportDaysID)
                    .ToList();

            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message, ex);
            }
            return list;
        }

        public IList<SupportDays> GetSupportDays(int categoryID)
        {
            Logger.Debug("GetSupportDays()");
            IList<SupportDays> list = null;
            try
            {
                var list2 =
                (
                        from sd in _context.SupportDays
                        where (sd.CloudApplications.Any(x => x.Category.CategoryID == categoryID) && sd.SupportDaysStatus.StatusName.ToUpper() == "LIVE")
                        || sd.SupportDaysName.ToUpper() == "ALL"
                        group sd by sd.SupportDaysID into y
                        select new
                        {
                            SupportDaysID = y.Key,
                            SupportDaysName = y.FirstOrDefault().SupportDaysName,
                        }
                )

                .AsEnumerable()
                .Select(x => new SupportDays
                {
                    SupportDaysID = x.SupportDaysID,
                    SupportDaysName = x.SupportDaysName,
                }
                ).ToList()
                .OrderBy(z => z.SupportDaysName).ToList()
                ;

                list = list2;
            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message, ex);
            }
            return list;
        }

        public SupportDays GetSupportDay(int supportDaysID)
        {
            Logger.Debug("GetSupportDays(" + supportDaysID + ")");
            SupportDays sd = null;
            try
            {
                sd = (from x in _context.SupportDays
                      where x.SupportDaysID == supportDaysID && x.SupportDaysStatus.StatusName.ToUpper() == "LIVE"
                      select x)
                    .FirstOrDefault();

            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message, ex);
            }
            return sd;
        }
        #endregion

        #region GetSupportHours
        public IList<SupportHours> GetSupportHours()
        {
            Logger.Debug("GetSupportHours()");
            IList<SupportHours> list = null;
            try
            {
                //list = (from x in _context.SupportHours
                //        select x)
                //        .OrderBy(x => x.IgnoreFilterPredicate).ThenBy(x => x.SupportHoursName)
                //    .ToList();

                var list2 =
                (
                    from x in _context.SupportHours
                    join ca in _context.CloudApplications
                    on x.SupportHoursID equals ca.SupportHours.SupportHoursID
                    where x.SupportHoursStatus.StatusName.ToUpper() == "LIVE"
                    //where ca.SupportHoursTimeZone.Any(x => x.CategoryID == categoryID)
                    group x by x.SupportHoursID into y
                    select new
                    //Domain.Models.TimeZone()
                    {
                        SupportHoursFrom = y.FirstOrDefault().SupportHoursFrom,
                        SupportHoursTo = y.FirstOrDefault().SupportHoursTo,
                        SupportHoursName = y.FirstOrDefault().SupportHoursName,
                        IgnoreFilterPredicate = y.FirstOrDefault().IgnoreFilterPredicate,
                        SupportHoursID = y.Key,
                    }
                )
                .Union
                (
                    from x in _context.SupportHours
                    where x.IgnoreFilterPredicate
                    && x.SupportHoursStatus.StatusName.ToUpper() == "LIVE"
                    select new
                    //Domain.Models.TimeZone()
                    {
                        SupportHoursFrom = x.SupportHoursFrom,
                        SupportHoursTo = x.SupportHoursTo,
                        SupportHoursName = x.SupportHoursName,
                        IgnoreFilterPredicate = x.IgnoreFilterPredicate,
                        SupportHoursID = x.SupportHoursID,
                    }
                )

                .AsEnumerable()
                .Select(x => new Domain.Models.SupportHours
                {
                    SupportHoursFrom = x.SupportHoursFrom,
                    SupportHoursTo = x.SupportHoursTo,
                    IgnoreFilterPredicate = x.IgnoreFilterPredicate,
                    SupportHoursID = x.SupportHoursID,
                    SupportHoursName = x.SupportHoursName,
                }
                ).ToList()
                .OrderBy(z => z.SupportHoursName).ToList()
                ;

                //list = list2.Select(x => new Domain.Models.TimeZone 
                //{
                //    GMTDifference = x.GMTDifference,
                //    IgnoreFilterPredicate = x.IgnoreFilterPredicate,
                //    TimeZoneID = x.TimeZoneID,
                //    TimeZoneName = x.TimeZoneName,
                //}
                //).ToList();

                //list = list2.ToList<Domain.Models.TimeZone>();
                list = list2;

            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message, ex);
            }
            return list;
        }


        public IList<SupportHours> GetSupportHours(int categoryID)
        {
            Logger.Debug("GetSupportHours()");
            IList<SupportHours> list = null;
            try
            {
                //list = (from x in _context.SupportHours
                //        select x)
                //        .OrderBy(x => x.IgnoreFilterPredicate).ThenBy(x => x.SupportHoursName)
                //    .ToList();

                var list2 =
                (
                    from x in _context.SupportHours
                    join ca in _context.CloudApplications
                    on x.SupportHoursID equals ca.SupportHours.SupportHoursID
                    //where ca.SupportHoursTimeZone.Any(x => x.CategoryID == categoryID)
                    where ca.Category.CategoryID == categoryID
                    && x.SupportHoursStatus.StatusName.ToUpper() == "LIVE"
                    group x by x.SupportHoursID into y
                    select new
                    //Domain.Models.TimeZone()
                    {
                        SupportHoursFrom = y.FirstOrDefault().SupportHoursFrom,
                        SupportHoursTo = y.FirstOrDefault().SupportHoursTo,
                        SupportHoursName = y.FirstOrDefault().SupportHoursName,
                        IgnoreFilterPredicate = y.FirstOrDefault().IgnoreFilterPredicate,
                        SupportHoursID = y.Key,
                    }
                )
                .Union
                (
                    from x in _context.SupportHours
                    where x.IgnoreFilterPredicate
                    && x.SupportHoursStatus.StatusName.ToUpper() == "LIVE"
                    select new
                    //Domain.Models.TimeZone()
                    {
                        SupportHoursFrom = x.SupportHoursFrom,
                        SupportHoursTo = x.SupportHoursTo,
                        SupportHoursName = x.SupportHoursName,
                        IgnoreFilterPredicate = x.IgnoreFilterPredicate,
                        SupportHoursID = x.SupportHoursID,
                    }
                )

                .AsEnumerable()
                .Select(x => new Domain.Models.SupportHours
                {
                    SupportHoursFrom = x.SupportHoursFrom,
                    SupportHoursTo = x.SupportHoursTo,
                    IgnoreFilterPredicate = x.IgnoreFilterPredicate,
                    SupportHoursID = x.SupportHoursID,
                    SupportHoursName = x.SupportHoursName,
                }
                ).ToList()
                .OrderBy(z => z.SupportHoursName).ToList()
                ;

                //list = list2.Select(x => new Domain.Models.TimeZone 
                //{
                //    GMTDifference = x.GMTDifference,
                //    IgnoreFilterPredicate = x.IgnoreFilterPredicate,
                //    TimeZoneID = x.TimeZoneID,
                //    TimeZoneName = x.TimeZoneName,
                //}
                //).ToList();

                //list = list2.ToList<Domain.Models.TimeZone>();
                list = list2;

            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message, ex);
            }
            return list;
        }

        public SupportHours GetSupportHour(int supportHoursID)
        {
            Logger.Debug("GetSupportHours(" + supportHoursID + ")");
            SupportHours sh = null;
            try
            {
                sh = (from x in _context.SupportHours where x.SupportHoursID == supportHoursID
                        select x)
                    .FirstOrDefault();

            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message, ex);
            }
            return sh;
        }
        
        #endregion

        #region GetSupportHoursAll
        public IList<SupportHours> GetSupportHoursAll()
        {
            Logger.Debug("GetSupportHoursAll()");
            IList<SupportHours> list = null;
            try
            {
                //list = (from x in _context.SupportHours
                //        select x)
                //        .OrderBy(x => x.IgnoreFilterPredicate).ThenBy(x => x.SupportHoursName)
                //    .ToList();

                list =
                (
                    from x in _context.SupportHours
                    where !x.IgnoreFilterPredicate
                    && x.SupportHoursStatus.StatusName.ToUpper() == "LIVE"
                    select x
                )
                .OrderBy(x => x.SupportHoursFrom).ThenBy(x => x.SupportHoursTo)
                .ToList();

            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message, ex);
            }
            return list;
        }
        #endregion

        #region GetTimeZones
        public IList<Domain.Models.TimeZone> GetTimeZones()
        {
            Logger.Debug("GetTimeZones()");
            IList<Domain.Models.TimeZone> list = null;
            try
            {
                var list2 = 
                (
                        from x in _context.TimeZones
                        join ca in _context.CloudApplications
                        on x.TimeZoneID equals ca.SupportHoursTimeZone.TimeZoneID
                        //where ca.SupportHoursTimeZone.Any(x => x.CategoryID == categoryID)
                        group x by x.TimeZoneID into y
                        select new 
                            //Domain.Models.TimeZone()
                        {
                            GMTDifference = y.FirstOrDefault().GMTDifference,
                            IgnoreFilterPredicate = y.FirstOrDefault().IgnoreFilterPredicate,
                            TimeZoneID = y.Key,
                            TimeZoneName = y.FirstOrDefault().TimeZoneName,
                        }
                )
                .Union
                (
                        from x in _context.TimeZones
                        where x.IgnoreFilterPredicate
                        select new
                        //Domain.Models.TimeZone()
                        {
                            GMTDifference = x.GMTDifference,
                            IgnoreFilterPredicate = x.IgnoreFilterPredicate,
                            TimeZoneID = x.TimeZoneID,
                            TimeZoneName = x.TimeZoneName,
                        }
                )

                .AsEnumerable()
                .Select(x => new Domain.Models.TimeZone
                {
                    GMTDifference = x.GMTDifference,
                    IgnoreFilterPredicate = x.IgnoreFilterPredicate,
                    TimeZoneID = x.TimeZoneID,
                    TimeZoneName = x.TimeZoneName,
                }
                ).ToList()
                .OrderBy(z => z.TimeZoneName).ToList()
                ;

                //list = list2.Select(x => new Domain.Models.TimeZone 
                //{
                //    GMTDifference = x.GMTDifference,
                //    IgnoreFilterPredicate = x.IgnoreFilterPredicate,
                //    TimeZoneID = x.TimeZoneID,
                //    TimeZoneName = x.TimeZoneName,
                //}
                //).ToList();

                //list = list2.ToList<Domain.Models.TimeZone>();
                list = list2;
            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message, ex);
            }
            return list;
        }


        public IList<Domain.Models.TimeZone> GetTimeZones(int categoryID)
        {
            Logger.Debug("GetTimeZones()");
            IList<Domain.Models.TimeZone> list = null;
            try
            {
                var list2 =
                (
                        from x in _context.TimeZones
                        join ca in _context.CloudApplications
                        on x.TimeZoneID equals ca.SupportHoursTimeZone.TimeZoneID
                        where ca.Category.CategoryID == categoryID
                        && x.TimeZoneStatus.StatusName.ToUpper() == "LIVE"
                        group x by x.TimeZoneID into y
                        select new
                        //Domain.Models.TimeZone()
                        {
                            GMTDifference = y.FirstOrDefault().GMTDifference,
                            IgnoreFilterPredicate = y.FirstOrDefault().IgnoreFilterPredicate,
                            TimeZoneID = y.Key,
                            TimeZoneName = y.FirstOrDefault().TimeZoneName,
                        }
                )
                .Union
                (
                        from x in _context.TimeZones
                        where x.IgnoreFilterPredicate
                        && x.TimeZoneStatus.StatusName.ToUpper() == "LIVE"
                        select new
                        //Domain.Models.TimeZone()
                        {
                            GMTDifference = x.GMTDifference,
                            IgnoreFilterPredicate = x.IgnoreFilterPredicate,
                            TimeZoneID = x.TimeZoneID,
                            TimeZoneName = x.TimeZoneName,
                        }
                )

                .AsEnumerable()
                .Select(x => new Domain.Models.TimeZone
                {
                    GMTDifference = x.GMTDifference,
                    IgnoreFilterPredicate = x.IgnoreFilterPredicate,
                    TimeZoneID = x.TimeZoneID,
                    TimeZoneName = x.TimeZoneName,
                }
                ).ToList()
                .OrderBy(z => z.TimeZoneName).ToList()
                ;

                //list = list2.Select(x => new Domain.Models.TimeZone 
                //{
                //    GMTDifference = x.GMTDifference,
                //    IgnoreFilterPredicate = x.IgnoreFilterPredicate,
                //    TimeZoneID = x.TimeZoneID,
                //    TimeZoneName = x.TimeZoneName,
                //}
                //).ToList();

                //list = list2.ToList<Domain.Models.TimeZone>();
                list = list2;
            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message, ex);
            }
            return list;
        }

        public Domain.Models.TimeZone GetTimeZone(int timeZoneID)
        {
            Logger.Debug("GetTimeZone(" + timeZoneID + ")");
            Domain.Models.TimeZone tz = null;
            try
            {
                tz = (from x in _context.TimeZones
                      where x.TimeZoneID == timeZoneID
                      select x)
                    .FirstOrDefault();

            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message, ex);
            }
            return tz;
        }

        public IList<Domain.Models.TimeZone> GetTimeZones(bool filterPredicatesOnly)
        {
            Logger.Debug("GetTimeZones(" + filterPredicatesOnly.ToString() + ")");
            IList<Domain.Models.TimeZone> tz = null;
            try
            {
                if (filterPredicatesOnly)
                {
                    tz = (from x in _context.TimeZones
                          where x.IgnoreFilterPredicate == false
                          && x.TimeZoneStatus.StatusName.ToUpper() == "LIVE"
                          select x).ToList();
                }
                else
                {
                    tz = (from x in _context.TimeZones where x.TimeZoneStatus.StatusName.ToUpper() == "LIVE"

                          select x).ToList();
                }

            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message, ex);
            }
            return tz;
        }

        #endregion

        public void Dispose()
        {
            //System.Diagnostics.Debugger.Break();
            //throw new NotImplementedException();
        }

        #region GetOperatingSystems
        public IList<Domain.Models.OperatingSystem> GetOperatingSystems()
        {
            Logger.Debug("GetOperatingSystems()");
            IList<Domain.Models.OperatingSystem> list = null;
            try
            {
                list = (from x in _context.OperatingSystems where x.OperatingSystemStatus.StatusName.ToUpper() == "LIVE"
                        select x)
                        .OrderBy(x => x.OperatingSystemName)
                    .ToList();

            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message, ex);
            }
            return list;
        }

        public IList<Domain.Models.OperatingSystem> GetOperatingSystems(int categoryID)
        {
            Logger.Debug("GetOperatingSystems()");
            IList<Domain.Models.OperatingSystem> list = null;
            try
            {
                var list2 =
                (
                        //from ca in _context.CloudApplications
                        from os in _context.OperatingSystems
                        //on ca.CloudApplicationID equals os.SupportHoursTimeZone.TimeZoneID
                        //where ca.Category.CategoryID == categoryID
                        where os.CloudApplications.Any(x => x.Category.CategoryID == categoryID)
                        && os.OperatingSystemStatus.StatusName.ToUpper() == "LIVE"
                        group os by os.OperatingSystemID into y
                        select new
                        //Domain.Models.TimeZone()
                        {
                            OperatingSystemID = y.Key,
                            OperatingSystemName = y.FirstOrDefault().OperatingSystemName,
                        }
                )

                .AsEnumerable()
                .Select(x => new Domain.Models.OperatingSystem
                {
                    OperatingSystemID = x.OperatingSystemID,
                    OperatingSystemName = x.OperatingSystemName,
                }
                ).ToList()
                .OrderBy(z => z.OperatingSystemName).ToList()
                ;

                list = list2;
            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message, ex);
            }
            return list;
        }


        #endregion

        #region GetBrowsers
        public IList<Domain.Models.Browser> GetBrowsers()
        {
            Logger.Debug("GetBrowsers()");
            IList<Domain.Models.Browser> list = null;
            try
            {
                list = (from x in _context.Browsers where x.BrowserStatus.StatusName.ToUpper() == "LIVE" 
                        select x)
                        .OrderBy(x => x.BrowserName)
                    .ToList();

            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message, ex);
            }
            return list;
        }

        public IList<Domain.Models.Browser> GetBrowsers(int categoryID)
        {
            Logger.Debug("GetBrowsers()");
            IList<Domain.Models.Browser> list = null;
            try
            {
                var list2 =
                (
                    //from ca in _context.CloudApplications
                        from os in _context.Browsers
                        //on ca.CloudApplicationID equals os.SupportHoursTimeZone.TimeZoneID
                        //where ca.Category.CategoryID == categoryID
                        where os.CloudApplications.Any(x => x.Category.CategoryID == categoryID)
                        && os.BrowserStatus.StatusName.ToUpper() == "LIVE"
                        group os by os.BrowserID into y
                        select new
                        //Domain.Models.TimeZone()
                        {
                            BrowserID = y.Key,
                            BrowserName = y.FirstOrDefault().BrowserName,
                        }
                )

                .AsEnumerable()
                .Select(x => new Domain.Models.Browser
                {
                    BrowserID = x.BrowserID,
                    BrowserName = x.BrowserName,
                }
                ).ToList()
                .OrderBy(z => z.BrowserName).ToList()
                ;

                list = list2;
            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message, ex);
            }
            return list;
        }
        
        
        #endregion

        #region GetFeaturedCloudware
        public IList<SearchResult> GetFeaturedCloudware(int count, bool liveApplicationsOnly)
        {
            var expression = RepositoryFunctions.GetShopTag();

            string imagesPath = System.Configuration.ConfigurationManager.AppSettings["LogosFolder"].ToString();
            IQueryable<SearchResult> f4 = null;

            if (Logger != null)
            {
                //Logger.Debug("GetFeaturedCloudware START");
            }
            if (liveApplicationsOnly)
            {
                f4 = (from cf in _context.CloudApplications
                          where cf.Vendor.VendorLogoFileName.Trim().Length > 0
                          && cf.CloudApplicationStatus.StatusName.ToUpper() == "LIVE"
                      orderby cf.SearchResultWeighting
                      descending
                      select new SearchResult
                          {
                              CloudApplicationID = cf.CloudApplicationID,
                              VendorID = cf.Vendor.VendorID,
                              VendorName = cf.Vendor.VendorName,
                              VendorLogoURL = imagesPath + cf.Vendor.VendorLogoFileName,
                              ServiceName = cf.ServiceName,
                              Description = cf.Description,
                              CloudApplicationCategoryTag = cf.CloudApplicationCategoryTag.TagName,
                              CloudApplicationShopTag = cf.CloudApplicationShopTag.TagName,
                              CategoryID = cf.Category.CategoryID,
                          }).Take(count);
            }
            else
            {
                f4 = (from cf in _context.CloudApplications
                          where cf.Vendor.VendorLogoFileName.Trim().Length > 0
                          select new SearchResult
                          {
                              CloudApplicationID = cf.CloudApplicationID,
                              VendorID = cf.Vendor.VendorID,
                              VendorName = cf.Vendor.VendorName,
                              VendorLogoURL = imagesPath + cf.Vendor.VendorLogoFileName,
                              ServiceName = cf.ServiceName,
                              Description = cf.Description,
                              CloudApplicationCategoryTag = cf.CloudApplicationCategoryTag.TagName,
                              CloudApplicationShopTag = cf.CloudApplicationShopTag.TagName,
                              CategoryID = cf.Category.CategoryID,
                          }).Take(count);
            }

            if (Logger != null)
            {
                //Logger.Debug("GetFeaturedCloudware BEFORE TOLIST()");
            }
            IList<SearchResult> retVal = f4.ToList();
            if (Logger != null)
            {
                //Logger.Debug("GetFeaturedCloudware END");
            }
            return retVal;
        }

        public IList<SearchResult> GetFeaturedCloudware(int categoryID, int count, bool liveApplicationsOnly)
        {

            string imagesPath = System.Configuration.ConfigurationManager.AppSettings["LogosFolder"].ToString();

            IQueryable<SearchResult> f4 = null;
            if (liveApplicationsOnly)
            {
                f4 = (from cf in _context.CloudApplications
                          where cf.Category.CategoryID == categoryID
                          && cf.CloudApplicationStatus.StatusName.ToUpper() == "LIVE"
                          orderby cf.SearchResultWeighting
                          descending
                      select new SearchResult
                          {
                              CloudApplicationID = cf.CloudApplicationID,
                              VendorID = cf.Vendor.VendorID,
                              VendorName = cf.Vendor.VendorName,
                              VendorLogoURL = imagesPath + cf.Vendor.VendorLogoFileName,
                              ServiceName = cf.ServiceName,
                              Description = cf.Description,
                              CloudApplicationCategoryTag = cf.CloudApplicationCategoryTag.TagName,
                              CloudApplicationShopTag = cf.CloudApplicationShopTag.TagName,
                              CategoryID = cf.Category.CategoryID,
                          }).Take(count)
                          ;
            }
            else
            {
                f4 = (from cf in _context.CloudApplications
                          where cf.Category.CategoryID == categoryID
                          select new SearchResult
                          {
                              CloudApplicationID = cf.CloudApplicationID,
                              VendorID = cf.Vendor.VendorID,
                              VendorName = cf.Vendor.VendorName,
                              VendorLogoURL = imagesPath + cf.Vendor.VendorLogoFileName,
                              ServiceName = cf.ServiceName,
                              Description = cf.Description,
                              CloudApplicationCategoryTag = cf.CloudApplicationCategoryTag.TagName,
                              CloudApplicationShopTag = cf.CloudApplicationShopTag.TagName,
                              CategoryID = cf.Category.CategoryID,
                          }).Take(count);

            }

            return f4.ToList();
        }

        #endregion

        #region GetTopTenCloudware
        public IList<SearchResult> GetTopTenCloudware(int count, bool liveApplicationsOnly)
        {
            string imagesPath = System.Configuration.ConfigurationManager.AppSettings["LogosFolder"].ToString();

            List<SiteAnalyticScoreChart> scoreChart = GetCurrentRankings().Take(count).ToList();
            int[] topTenIDs = scoreChart.Select(x => x.CloudApplicationID).ToArray();

            IQueryable<SearchResult> f4 = null;
            if (liveApplicationsOnly)
            {
                f4 = (from cf in _context.CloudApplications
                          where 
                          //cf.CloudApplicationID % 2 == 0
                          //&& 
                          cf.CloudApplicationStatus.StatusName.ToUpper() == "LIVE"
                          &&
                          topTenIDs.Contains(cf.CloudApplicationID)
                      //orderby cf.AddDate
                          select new SearchResult
                          {
                              CloudApplicationID = cf.CloudApplicationID,
                              VendorID = cf.Vendor.VendorID,
                              VendorName = cf.Vendor.VendorName,
                              VendorLogoURL = imagesPath + cf.Vendor.VendorLogoFileName,
                              ServiceName = cf.ServiceName,
                              Description = cf.Description,
                              CloudApplicationCategoryTag = cf.CloudApplicationCategoryTag.TagName,
                              CloudApplicationShopTag = cf.CloudApplicationShopTag.TagName,
                              CategoryID = cf.Category.CategoryID,
                              //Rank = scoreChart.Where(x => x.CloudApplicationID == cf.CloudApplicationID).FirstOrDefault().ChartPosition,
                          }
                          )
                          //.Take(count)
                          ;
            }
            else
            {
                throw new Exception("Illegal TOP 10 operation");
                f4 = (from cf in _context.CloudApplications
                          where cf.CloudApplicationID % 2 == 0
                          orderby cf.AddDate
                          select new SearchResult
                          {
                              CloudApplicationID = cf.CloudApplicationID,
                              VendorID = cf.Vendor.VendorID,
                              VendorName = cf.Vendor.VendorName,
                              VendorLogoURL = imagesPath + cf.Vendor.VendorLogoFileName,
                              ServiceName = cf.ServiceName,
                              Description = cf.Description,
                              CloudApplicationCategoryTag = cf.CloudApplicationCategoryTag.TagName,
                              CloudApplicationShopTag = cf.CloudApplicationShopTag.TagName,
                              CategoryID = cf.Category.CategoryID,
                          }
                          ).Take(count);
            }
            //return f4.OrderBy(x => x.Rank).ToList();

            List<SearchResult> retVal = f4.ToList();
            retVal.ForEach(x => x.Rank = scoreChart.Where(y => y.CloudApplicationID == x.CloudApplicationID).FirstOrDefault().ChartPosition);
            //Rank = scoreChart.Where(x => x.CloudApplicationID == cf.CloudApplicationID).FirstOrDefault().ChartPosition,

            //return f4.ToList();
            return retVal.OrderBy(x => x.Rank).ToList();
        }

        public IList<SearchResult> GetTopTenCloudware(int categoryID, int count, bool liveApplicationsOnly)
        {
            string imagesPath = System.Configuration.ConfigurationManager.AppSettings["LogosFolder"].ToString();

            List<SiteAnalyticScoreChart> scoreChart = GetCurrentRankings().Where(x => x.CategoryID == categoryID).Take(count).ToList();
            int[] topTenIDs = scoreChart.Select(x => x.CloudApplicationID).ToArray();

            IQueryable<SearchResult> f4 = null;
            if (liveApplicationsOnly)
            {
                f4 = (from cf in _context.CloudApplications
                          where 
                          //cf.CloudApplicationID % 2 == 0
                          //&& 
                          cf.Category.CategoryID == categoryID
                          && 
                          cf.CloudApplicationStatus.StatusName.ToUpper() == "LIVE"
                          &&
                          topTenIDs.Contains(cf.CloudApplicationID)
                      //orderby cf.AddDate
                          select new SearchResult
                          {
                              CloudApplicationID = cf.CloudApplicationID,
                              VendorID = cf.Vendor.VendorID,
                              VendorName = cf.Vendor.VendorName,
                              VendorLogoURL = imagesPath + cf.Vendor.VendorLogoFileName,
                              ServiceName = cf.ServiceName,
                              Description = cf.Description,
                              CloudApplicationCategoryTag = cf.CloudApplicationCategoryTag.TagName,
                              CloudApplicationShopTag = cf.CloudApplicationShopTag.TagName,
                              CategoryID = cf.Category.CategoryID,
                              //Rank = (int)scoreChart.Where(x => x.CloudApplicationID == cf.CloudApplicationID).FirstOrDefault().ChartPosition,
                          }
                          )
                          //.Take(count)
                          ;
            }
            else
            {
                throw new Exception("Illegal TOP 10 operation");
                f4 = (from cf in _context.CloudApplications
                          where cf.CloudApplicationID % 2 == 0
                          && cf.Category.CategoryID == categoryID
                          orderby cf.AddDate
                          select new SearchResult
                          {
                              CloudApplicationID = cf.CloudApplicationID,
                              VendorID = cf.Vendor.VendorID,
                              VendorName = cf.Vendor.VendorName,
                              VendorLogoURL = imagesPath + cf.Vendor.VendorLogoFileName,
                              ServiceName = cf.ServiceName,
                              Description = cf.Description,
                              CloudApplicationCategoryTag = cf.CloudApplicationCategoryTag.TagName,
                              CloudApplicationShopTag = cf.CloudApplicationShopTag.TagName,
                              CategoryID = cf.Category.CategoryID,
                          }
                          ).Take(count);
            }

            List<SearchResult> retVal = f4.ToList();
            retVal.ForEach(x => x.Rank = scoreChart.Where(y => y.CloudApplicationID == x.CloudApplicationID).FirstOrDefault().ChartPosition);
            
            return retVal.OrderBy(x => x.Rank).ToList();
        }

        #endregion

        #region GetNewCloudware
        public IList<SearchResult> GetNewCloudware(int count, bool liveApplicationsOnly)
        {
            string imagesPath = System.Configuration.ConfigurationManager.AppSettings["LogosFolder"].ToString();

            IQueryable<SearchResult> f4 = null;
            if (liveApplicationsOnly)
            {
                f4 = (from cf in _context.CloudApplications
                      where cf.CloudApplicationStatus.StatusName.ToUpper() == "LIVE"
                      orderby cf.AddDate descending
                          select new SearchResult
                          {
                              CloudApplicationID = cf.CloudApplicationID,
                              VendorID = cf.Vendor.VendorID,
                              VendorName = cf.Vendor.VendorName,
                              VendorLogoURL = imagesPath + cf.Vendor.VendorLogoFileName,
                              ServiceName = cf.ServiceName,
                              Description = cf.Description,
                              CloudApplicationCategoryTag = cf.CloudApplicationCategoryTag.TagName,
                              CloudApplicationShopTag = cf.CloudApplicationShopTag.TagName,
                              CategoryID = cf.Category.CategoryID,
                          }
                          ).Take(count);
            }
            else
            {
                f4 = (from cf in _context.CloudApplications
                          orderby cf.AddDate descending
                          select new SearchResult
                          {
                              CloudApplicationID = cf.CloudApplicationID,
                              VendorID = cf.Vendor.VendorID,
                              VendorName = cf.Vendor.VendorName,
                              VendorLogoURL = imagesPath + cf.Vendor.VendorLogoFileName,
                              ServiceName = cf.ServiceName,
                              Description = cf.Description,
                              CloudApplicationCategoryTag = cf.CloudApplicationCategoryTag.TagName,
                              CloudApplicationShopTag = cf.CloudApplicationShopTag.TagName,
                              CategoryID = cf.Category.CategoryID,
                          }
                          ).Take(count);

            }
            return f4.ToList();
        }

        public IList<SearchResult> GetNewCloudware(int categoryID, int count, bool liveApplicationsOnly)
        {
            string imagesPath = System.Configuration.ConfigurationManager.AppSettings["LogosFolder"].ToString();

            IQueryable<SearchResult> f4 = null;
            if (liveApplicationsOnly)
            {
                f4 = (from cf in _context.CloudApplications
                          where cf.Category.CategoryID == categoryID
                      && cf.CloudApplicationStatus.StatusName.ToUpper() == "LIVE"
                      orderby cf.AddDate descending
                          select new SearchResult
                          {
                              CloudApplicationID = cf.CloudApplicationID,
                              VendorID = cf.Vendor.VendorID,
                              VendorName = cf.Vendor.VendorName,
                              VendorLogoURL = imagesPath + cf.Vendor.VendorLogoFileName,
                              ServiceName = cf.ServiceName,
                              Description = cf.Description,
                              CloudApplicationCategoryTag = cf.CloudApplicationCategoryTag.TagName,
                              CloudApplicationShopTag = cf.CloudApplicationShopTag.TagName,
                              CategoryID = cf.Category.CategoryID,
                          }
                          ).Take(count);
            }
            else
            {
                f4 = (from cf in _context.CloudApplications
                          where cf.Category.CategoryID == categoryID
                          orderby cf.AddDate descending
                          select new SearchResult
                          {
                              CloudApplicationID = cf.CloudApplicationID,
                              VendorID = cf.Vendor.VendorID,
                              VendorName = cf.Vendor.VendorName,
                              VendorLogoURL = imagesPath + cf.Vendor.VendorLogoFileName,
                              ServiceName = cf.ServiceName,
                              Description = cf.Description,
                              CloudApplicationCategoryTag = cf.CloudApplicationCategoryTag.TagName,
                              CloudApplicationShopTag = cf.CloudApplicationShopTag.TagName,
                              CategoryID = cf.Category.CategoryID,
                          }
                          ).Take(count);
            }
            return f4.ToList();
        }

        #endregion

        #region GetSearchOptionsOneColumn
        public IList<SearchFilterOneColumn> GetSearchOptionsOneColumn(int categoryID)
        {
            Logger.Debug("GetSearchFiltersOneColumn()");
            //IList<SearchFeature> list = null;
            try
            {

                var listTemp = (
                    from x
                    in _context.Features
                    //where x.Category.CategoryID == categoryID
                    where x.Categories.Any(y => y.CategoryID == categoryID)
                    select new SearchFilterTwoColumn()
                    {
                        CategoryCol1 = x.Categories.FirstOrDefault(z => z.CategoryID == categoryID),
                        //CategoryCol1 = x.Categories.AsQueryable().FirstOrDefault(z => z.CategoryID == FindCategoryByName),
                        SearchFilterID = x.FeatureID,
                        SearchFilterNameCol1 = x.FeatureName,
                        SearchFilterTypeNameCol1 = FILTER_FEATURES,
                    }
                ).ToList();

                var list = (
                    //from x 
                    //    in _context.Features
                    //    //where x.Category.CategoryID == categoryID
                    //where x.Categories.Any(y => y.CategoryID == categoryID)
                    //select new SearchFilterTwoColumn()
                    //{
                    //    //CategoryCol1 = x.Category,
                    //    SearchFilterID = x.FeatureID,
                    //    SearchFilterNameCol1 = x.FeatureName,
                    //    SearchFilterTypeNameCol1 = FILTER_FEATURES,
                    //}
                    //)

                                        from x
                    in _context.Features
                                        //where x.Category.CategoryID == categoryID
                                        where x.Categories.Any(y => y.CategoryID == categoryID)
                                        select new SearchFilterOneColumn()
                                        {
                                            CategoryCol1 = x.Categories.FirstOrDefault(z => z.CategoryID == categoryID),
                                            //CategoryCol1 = x.Categories.AsQueryable().FirstOrDefault(z => z.CategoryID == FindCategoryByName),
                                            SearchFilterID = x.FeatureID,
                                            SearchFilterNameCol1 = x.FeatureName,
                                            SearchFilterTypeNameCol1 = FILTER_FEATURES,
                                        }
                )
                    .Union(
                    from x
                        in _context.OperatingSystems
                    //where x.Category.CategoryID == categoryID
                    select new SearchFilterOneColumn()
                    {
                        CategoryCol1 = null,
                        SearchFilterID = x.OperatingSystemID,
                        SearchFilterNameCol1 = x.OperatingSystemName,
                        SearchFilterTypeNameCol1 = FILTER_OPERATINGSYSTEMS,
                    }
                    )

                    .Union(
                    from x
                        in _context.Browsers
                    //where x.Category.CategoryID == categoryID
                    select new SearchFilterOneColumn()
                    {
                        CategoryCol1 = null,
                        SearchFilterID = x.BrowserID,
                        SearchFilterNameCol1 = x.BrowserName,
                        SearchFilterTypeNameCol1 = FILTER_BROWSERS,
                    }
                    )

                    .Union(
                    from x
                        in _context.MobilePlatforms
                    //where x.Category.CategoryID == categoryID
                    select new SearchFilterOneColumn()
                    {
                        CategoryCol1 = null,
                        SearchFilterID = x.MobilePlatformID,
                        SearchFilterNameCol1 = x.MobilePlatformName,
                        SearchFilterTypeNameCol1 = FILTER_MOBILEPLATFORMS,
                    }
                    )

                    .Union(
                    from x
                        in _context.SupportTypes
                    //where x.Category.CategoryID == categoryID
                    select new SearchFilterOneColumn()
                    {
                        CategoryCol1 = null,
                        SearchFilterID = x.SupportTypeID,
                        SearchFilterNameCol1 = x.SupportTypeName,
                        SearchFilterTypeNameCol1 = FILTER_SUPPORTTYPES,
                    }
                    )

                    .Union(
                    from x
                        in _context.SupportDays
                    //where x.Category.CategoryID == categoryID
                    select new SearchFilterOneColumn()
                    {
                        CategoryCol1 = null,
                        SearchFilterID = x.SupportDaysID,
                        SearchFilterNameCol1 = x.SupportDaysName,
                        SearchFilterTypeNameCol1 = FILTER_SUPPORTDAYS,
                    }
                    )

                    .Union(
                    from x
                        in _context.SupportHours
                    //where x.Category.CategoryID == categoryID
                    select new SearchFilterOneColumn()
                    {
                        CategoryCol1 = null,
                        SearchFilterID = x.SupportHoursID,
                        SearchFilterNameCol1 = x.SupportHoursName,
                        SearchFilterTypeNameCol1 = FILTER_SUPPORTHOURS,
                    }
                    )

                    .Union(
                    from x
                        in _context.Languages
                    //where x.Category.CategoryID == categoryID
                    select new SearchFilterOneColumn()
                    {
                        CategoryCol1 = null,
                        SearchFilterID = x.LanguageID,
                        SearchFilterNameCol1 = x.LanguageName,
                        SearchFilterTypeNameCol1 = FILTER_LANGUAGES,
                    }
                    )

                    .OrderBy(x => x.SearchFilterTypeNameCol1)
                    .ToList();
                return list;

            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message, ex);
            }
            return null;
        }
        #endregion

        #region GetSearchOptionsTwoColumn
        public IList<SearchFilterTwoColumn> GetSearchOptionsTwoColumn(int categoryID)
        {
            Logger.Debug("GetSearchFilters()");
            //IList<SearchFeature> list = null;

            var test = (
    from x
    in _context.Features
    //where x.Category.CategoryID == categoryID
    where x.Categories.Any(y => y.CategoryID == categoryID)
    && x.FeatureType.FeatureTypeName.ToUpper() == "FEATURE"
    && x.FeatureStatus.StatusName.ToUpper() == "LIVE"
    select new SearchFilterTwoColumn()
    {
        CategoryCol1 = x.Categories.FirstOrDefault(z => z.CategoryID == categoryID),
        //CategoryCol1 = x.Categories.AsQueryable().FirstOrDefault(z => z.CategoryID == FindCategoryByName),
        SearchFilterID = x.FeatureID,
        SearchFilterParentID = 0,
        SearchFilterNameCol1 = x.FeatureName,
        SearchFilterTypeNameCol1 = FILTER_FEATURES,
        DataDrivenFieldCol1 = x.DataDrivenField,
        IsDataDrivenCol1 = x.IsDataDriven,
        IsDataFloorDrivenCol1 = x.IsDataFloorDriven,
        IsDataCeilingDrivenCol1 = x.IsDataCeilingDriven,
        SuppressFilterBehaviour = x.SuppressFilterBehaviour,
        CanBeBooleanAndDataDriven = x.CanBeBooleanAndDataDriven
    }
);

            var test2 = test.ToList();
            
            try
            {
                var list = (
                    from x
                    in _context.Features
                                        //where x.Category.CategoryID == categoryID
                                        where x.Categories.Any(y => y.CategoryID == categoryID)
                                        && x.FeatureType.FeatureTypeName.ToUpper() == "FEATURE"
                                        && x.FeatureStatus.StatusName.ToUpper() == "LIVE"
                                        select new SearchFilterTwoColumn()
                                        {
                                            CategoryCol1 = x.Categories.FirstOrDefault(z => z.CategoryID == categoryID),
                                            //CategoryCol1 = x.Categories.AsQueryable().FirstOrDefault(z => z.CategoryID == FindCategoryByName),
                                            SearchFilterID = x.FeatureID,
                                            SearchFilterParentID = 0,
                                            SearchFilterNameCol1 = x.FeatureName,
                                            SearchFilterTypeNameCol1 = FILTER_FEATURES,
                                            DataDrivenFieldCol1 = x.DataDrivenField,
                                            IsDataDrivenCol1 = x.IsDataDriven,
                                            IsDataFloorDrivenCol1 = x.IsDataFloorDriven,
                                            IsDataCeilingDrivenCol1 = x.IsDataCeilingDriven,
                                            SuppressFilterBehaviour = x.SuppressFilterBehaviour,
                                            CanBeBooleanAndDataDriven = x.CanBeBooleanAndDataDriven
                                        }
                )

                #region UNION APPLICATION FEATURES

.Union(
                                        from x
                    in _context.Features
                                        //where x.Category.CategoryID == categoryID
                                        where x.Categories.Any(y => y.CategoryID == categoryID)
                                        && x.FeatureType.FeatureTypeName.ToUpper() == "APPLICATIONFEATURE"
                                        && x.FeatureStatus.StatusName.ToUpper() == "LIVE"
                                        select new SearchFilterTwoColumn()
                                        {
                                            CategoryCol1 = x.Categories.FirstOrDefault(z => z.CategoryID == categoryID),
                                            //CategoryCol1 = x.Categories.AsQueryable().FirstOrDefault(z => z.CategoryID == FindCategoryByName),
                                            SearchFilterID = x.FeatureID,
                                            SearchFilterParentID = x.ParentFeature != null ? x.ParentFeature.FeatureID : 0,
                                            SearchFilterNameCol1 = x.FeatureName,
                                            SearchFilterTypeNameCol1 = FILTER_APPLICATIONFEATURES,
                                            DataDrivenFieldCol1 = x.DataDrivenField,
                                            IsDataDrivenCol1 = x.IsDataDriven,
                                            IsDataFloorDrivenCol1 = x.IsDataFloorDriven,
                                            IsDataCeilingDrivenCol1 = x.IsDataCeilingDriven,
                                            SuppressFilterBehaviour = x.SuppressFilterBehaviour,
                                            CanBeBooleanAndDataDriven = x.CanBeBooleanAndDataDriven
                                        }


                )

                #endregion




                #region UNION MOBILE PLATFORMS

.Union(
                    from x
                        in _context.MobilePlatforms
                    //where x.Category.CategoryID == categoryID
                    select new SearchFilterTwoColumn()
                    {
                        CategoryCol1 = null,
                        SearchFilterID = x.MobilePlatformID,
                        SearchFilterParentID = 0,
                        SearchFilterNameCol1 = x.MobilePlatformName,
                        SearchFilterTypeNameCol1 = FILTER_MOBILEPLATFORMS,
                        DataDrivenFieldCol1 = null,
                        IsDataDrivenCol1 = false,
                        IsDataFloorDrivenCol1 = false,
                        IsDataCeilingDrivenCol1 = false,
                        SuppressFilterBehaviour = false,
                        CanBeBooleanAndDataDriven = false,
                    }
                    )

                #endregion

                #region UNION SUPPORT TYPES
                    //.Union(
                    //from x
                    //    in _context.SupportTypes
                    ////where x.Category.CategoryID == categoryID
                    //select new SearchFilterTwoColumn()
                    //{
                    //    CategoryCol1 = null,
                    //    SearchFilterID = x.SupportTypeID,
                    //    SearchFilterParentID = 0,
                    //    SearchFilterNameCol1 = x.SupportTypeName,
                    //    SearchFilterTypeNameCol1 = FILTER_SUPPORTTYPES,
                    //    DataDrivenFieldCol1 = null,
                    //    IsDataDrivenCol1 = false,
                    //    IsDataFloorDrivenCol1 = false,
                    //    IsDataCeilingDrivenCol1 = false,
                    //    SuppressFilterBehaviour = false,
                    //    CanBeBooleanAndDataDriven = false,
                    //}
                    //)
                #endregion

                #region UNION SUPPORT DAYS
                    //.Union(
                    //from x
                    //    in _context.SupportDays
                    ////where x.Category.CategoryID == categoryID
                    //select new SearchFilterTwoColumn()
                    //{
                    //    CategoryCol1 = null,
                    //    SearchFilterID = x.SupportDaysID,
                    //    SearchFilterParentID = 0,
                    //    SearchFilterNameCol1 = x.SupportDaysName,
                    //    SearchFilterTypeNameCol1 = FILTER_SUPPORTDAYS,
                    //    DataDrivenFieldCol1 = null,
                    //    IsDataDrivenCol1 = false,
                    //    IsDataFloorDrivenCol1 = false,
                    //    IsDataCeilingDrivenCol1 = false,
                    //    SuppressFilterBehaviour = false,
                    //    CanBeBooleanAndDataDriven = false,
                    //}
                    //)
                #endregion

                #region UNION SUPPORT HOURS
                    //.Union(
                    //from x
                    //    in _context.SupportHours
                    ////where x.Category.CategoryID == categoryID
                    //where x.CloudApplications.Any(y => y.SupportHours.SupportHoursID == x.SupportHoursID)
                    //select new SearchFilterTwoColumn()
                    //{
                    //    CategoryCol1 = null,
                    //    SearchFilterID = x.SupportHoursID,
                    //    SearchFilterParentID = 0,
                    //    SearchFilterNameCol1 = x.SupportHoursName,
                    //    SearchFilterTypeNameCol1 = FILTER_SUPPORTHOURS,
                    //    DataDrivenFieldCol1 = null,
                    //    IsDataDrivenCol1 = false,
                    //    IsDataFloorDrivenCol1 = false,
                    //    IsDataCeilingDrivenCol1 = false,
                    //    SuppressFilterBehaviour = false,
                    //    CanBeBooleanAndDataDriven = false,
                    //}
                    //)

                #endregion

                #region UNION LANGUAGES

                    //.Union(
                    //from x
                    //    in _context.Languages
                    ////where x.Category.CategoryID == categoryID
                    //select new SearchFilterTwoColumn()
                    //{
                    //    CategoryCol1 = null,
                    //    SearchFilterID = x.LanguageID,
                    //    SearchFilterParentID = 0,
                    //    SearchFilterNameCol1 = x.LanguageName,
                    //    SearchFilterTypeNameCol1 = FILTER_LANGUAGES,
                    //    DataDrivenFieldCol1 = null,
                    //    IsDataDrivenCol1 = false,
                    //    IsDataFloorDrivenCol1 = false,
                    //    IsDataCeilingDrivenCol1 = false,
                    //    SuppressFilterBehaviour = false,
                    //    CanBeBooleanAndDataDriven = false,
                    //}
                    //)


                //    .Union(
                    
                #endregion

                #region UNION TIMEZONES
                    //    //from x
                //    //    //in _context.TimeZones
                //    //    in this.GetTimeZones()
                //    ////where x.Category.CategoryID == categoryID
                //    //select new SearchFilterTwoColumn()
                //    //{
                //    //    CategoryCol1 = null,
                //    //    SearchFilterID = x.TimeZoneID,
                //    //    SearchFilterParentID = 0,
                //    //    SearchFilterNameCol1 = x.TimeZoneName,
                //    //    SearchFilterTypeNameCol1 = FILTER_TIMEZONES,
                //    //    DataDrivenFieldCol1 = null,
                //    //    IsDataDrivenCol1 = false,
                //    //    IsDataFloorDrivenCol1 = false,
                //    //    IsDataCeilingDrivenCol1 = false,
                //    //    SuppressFilterBehaviour = false,
                //    //    CanBeBooleanAndDataDriven = false,
                //    //}





                //(from x in _context.TimeZones
                // join ca in _context.CloudApplications
                // on x.TimeZoneID equals ca.SupportHoursTimeZone.TimeZoneID
                // //where ca.SupportHoursTimeZone.Any(x => x.CategoryID == categoryID)
                // group x by x.TimeZoneID into y

                // select new
                // //Domain.Models.TimeZone()
                // {
                //     GMTDifference = y.FirstOrDefault().GMTDifference,
                //     IgnoreFilterPredicate = y.FirstOrDefault().IgnoreFilterPredicate,
                //     TimeZoneID = y.Key,
                //     TimeZoneName = y.FirstOrDefault().TimeZoneName,
                // }

                //        )
                //        .AsEnumerable()
                //        .Select(x => new SearchFilterTwoColumn()
                //        {
                //            //CategoryCol1 = null,
                //            //SearchFilterID = x.TimeZoneID,
                //            //SearchFilterParentID = 0,
                //            //SearchFilterNameCol1 = x.TimeZoneName,
                //            //SearchFilterTypeNameCol1 = FILTER_TIMEZONES,
                //            //DataDrivenFieldCol1 = null,
                //            //IsDataDrivenCol1 = false,
                //            //IsDataFloorDrivenCol1 = false,
                //            //IsDataCeilingDrivenCol1 = false,
                //            //SuppressFilterBehaviour = false,
                //            //CanBeBooleanAndDataDriven = false,
                //        }
                //)
                ////.ToList()
                ////.OrderBy(z => z.SearchFilterNameCol1).ToList()




                //    )

                #endregion

                    .OrderBy(x => x.SearchFilterTypeNameCol1)
                    .ToList();

                var timeZones = this.GetTimeZones(categoryID).AsEnumerable()
                        .Select(x => new SearchFilterTwoColumn()
                        {
                            CategoryCol1 = null,
                            SearchFilterID = x.TimeZoneID,
                            SearchFilterParentID = 0,
                            SearchFilterNameCol1 = x.TimeZoneName,
                            SearchFilterTypeNameCol1 = FILTER_TIMEZONES,
                            DataDrivenFieldCol1 = null,
                            IsDataDrivenCol1 = false,
                            IsDataFloorDrivenCol1 = false,
                            IsDataCeilingDrivenCol1 = false,
                            SuppressFilterBehaviour = false,
                            CanBeBooleanAndDataDriven = false,
                        });

                list = list.Union(timeZones).ToList();

                var supportHours = this.GetSupportHours(categoryID).AsEnumerable()
                        .Select(x => new SearchFilterTwoColumn()
                        {
                            CategoryCol1 = null,
                            SearchFilterID = x.SupportHoursID,
                            SearchFilterParentID = 0,
                            SearchFilterNameCol1 = x.SupportHoursName,
                            SearchFilterTypeNameCol1 = FILTER_SUPPORTHOURS,
                            DataDrivenFieldCol1 = null,
                            IsDataDrivenCol1 = false,
                            IsDataFloorDrivenCol1 = false,
                            IsDataCeilingDrivenCol1 = false,
                            SuppressFilterBehaviour = false,
                            CanBeBooleanAndDataDriven = false,
                        });

                list = list.Union(supportHours).ToList();

                var operatingSystems = this.GetOperatingSystems(categoryID).AsEnumerable()
                        .Select(x => new SearchFilterTwoColumn()
                        {
                            CategoryCol1 = null,
                            SearchFilterID = x.OperatingSystemID,
                            SearchFilterParentID = 0,
                            SearchFilterNameCol1 = x.OperatingSystemName,
                            SearchFilterTypeNameCol1 = FILTER_OPERATINGSYSTEMS,
                            DataDrivenFieldCol1 = null,
                            IsDataDrivenCol1 = false,
                            IsDataFloorDrivenCol1 = false,
                            IsDataCeilingDrivenCol1 = false,
                            SuppressFilterBehaviour = false,
                            CanBeBooleanAndDataDriven = false,
                        });

                list = list.Union(operatingSystems).ToList();

                var browsers = this.GetBrowsers(categoryID).AsEnumerable()
                        .Select(x => new SearchFilterTwoColumn()
                        {
                            CategoryCol1 = null,
                            SearchFilterID = x.BrowserID,
                            SearchFilterParentID = 0,
                            SearchFilterNameCol1 = x.BrowserName,
                            SearchFilterTypeNameCol1 = FILTER_BROWSERS,
                            DataDrivenFieldCol1 = null,
                            IsDataDrivenCol1 = false,
                            IsDataFloorDrivenCol1 = false,
                            IsDataCeilingDrivenCol1 = false,
                            SuppressFilterBehaviour = false,
                            CanBeBooleanAndDataDriven = false,
                        });

                list = list.Union(browsers).ToList();

                var supportTypes = this.GetSupportTypes(categoryID).AsEnumerable()
                        .Select(x => new SearchFilterTwoColumn()
                        {
                            CategoryCol1 = null,
                            SearchFilterID = x.SupportTypeID,
                            SearchFilterParentID = 0,
                            SearchFilterNameCol1 = x.SupportTypeName,
                            SearchFilterTypeNameCol1 = FILTER_SUPPORTTYPES,
                            DataDrivenFieldCol1 = null,
                            IsDataDrivenCol1 = false,
                            IsDataFloorDrivenCol1 = false,
                            IsDataCeilingDrivenCol1 = false,
                            SuppressFilterBehaviour = false,
                            CanBeBooleanAndDataDriven = false,
                        });

                list = list.Union(supportTypes).ToList();

                var devices = this.GetDevices(categoryID).AsEnumerable()
                        .Select(x => new SearchFilterTwoColumn()
                        {
                            CategoryCol1 = null,
                            SearchFilterID = x.DeviceID,
                            SearchFilterParentID = 0,
                            SearchFilterNameCol1 = x.DeviceName,
                            SearchFilterTypeNameCol1 = FILTER_DEVICES,
                            DataDrivenFieldCol1 = null,
                            IsDataDrivenCol1 = false,
                            IsDataFloorDrivenCol1 = false,
                            IsDataCeilingDrivenCol1 = false,
                            SuppressFilterBehaviour = false,
                            CanBeBooleanAndDataDriven = false,
                        });

                list = list.Union(devices).ToList();

                var supportDays = this.GetSupportDays(categoryID).AsEnumerable()
                        .Select(x => new SearchFilterTwoColumn()
                        {
                            CategoryCol1 = null,
                            SearchFilterID = x.SupportDaysID,
                            SearchFilterParentID = 0,
                            SearchFilterNameCol1 = x.SupportDaysName,
                            SearchFilterTypeNameCol1 = FILTER_SUPPORTDAYS,
                            DataDrivenFieldCol1 = null,
                            IsDataDrivenCol1 = false,
                            IsDataFloorDrivenCol1 = false,
                            IsDataCeilingDrivenCol1 = false,
                            SuppressFilterBehaviour = false,
                            CanBeBooleanAndDataDriven = false,
                        });

                list = list.Union(supportDays).ToList();

                var languages = this.GetLanguages(categoryID).AsEnumerable()
                        .Select(x => new SearchFilterTwoColumn()
                        {
                            CategoryCol1 = null,
                            SearchFilterID = x.LanguageID,
                            SearchFilterParentID = 0,
                            SearchFilterNameCol1 = x.LanguageName,
                            SearchFilterTypeNameCol1 = FILTER_LANGUAGES,
                            DataDrivenFieldCol1 = null,
                            IsDataDrivenCol1 = false,
                            IsDataFloorDrivenCol1 = false,
                            IsDataCeilingDrivenCol1 = false,
                            SuppressFilterBehaviour = false,
                            CanBeBooleanAndDataDriven = false,
                        });

                list = list.Union(languages).ToList();

                return list;

            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message, ex);
            }
            return null;
        }
        #endregion

        #region GetSearchResults
        public IList<CloudApplication> GetSearchResults(System.Linq.Expressions.Expression<Func<CloudApplication, bool>> predicate, bool liveApplicationsOnly)
        {
            var retVal1 = _context.CloudApplications
                .Include("Vendor")
                .Include("FreeTrialPeriod")
                .Include("SetupFee")
                .Include("OperatingSystems")
                .Include("Devices")
                .Include("SupportTypes")
                .Include("SupportDays")
                .Include("SupportHours")
                .Include("Languages")
                .Include("CloudApplicationFeatures")
                .Include("CloudApplicationFeatures.Feature")
                .AsExpandable().Where(predicate.Expand());

            var retVal2 = _context.CloudApplications
                .Include(p => p.Vendor)
                .Include(p => p.FreeTrialPeriod)
                .Include(p => p.SetupFee)
                .Include(p => p.OperatingSystems)
                .Include(p => p.Devices)
                .Include(p => p.SupportTypes)
                .Include(p => p.SupportDays)
                .Include(p => p.SupportHours)
                .Include(p => p.Languages)
                .Include(p => p.CloudApplicationFeatures)
                .AsExpandable().Where(predicate.Expand());

            //var retVal2 = _context.CloudApplications.Where(x => x.Browsers.Any(y => y.BrowserName == "Firefox")).ToList();
            //var retVal3 = _context.CloudApplications
            //    .Where(x => x.CloudApplicationFeatures.Any(y => y.Feature.FeatureName == "High Definition Video"))
            //    .Where(x => x.CloudApplicationFeatures.Any(y => y.Feature.FeatureName == "Multiple Meeting Hosts/Chairperson"))
            //    .Select(y => new CloudApplication()
            //    {
            //        CloudApplicationID = y.CloudApplicationID,
            //        Description = y.Description,
            //        ServiceName = y.ServiceName,
            //        Vendor = y.Vendor,
            //        ApplicationCostOneOff = y.ApplicationCostOneOff,
            //        ApplicationCostPerAnnum = y.ApplicationCostPerAnnum,
            //        ApplicationCostPerMonth = y.ApplicationCostPerMonth,
            //        ApplicationCostPerMonthExtra = y.ApplicationCostPerMonthExtra,
            //        CallsPackageCostPerMonth = y.CallsPackageCostPerMonth,
            //        FreeTrialPeriod = y.FreeTrialPeriod,
            //        SetupFee = y.SetupFee,

            //    }
            //    );

            //retVal.Include("Vendor");
            //retVal.Include("Vendors");
            //retVal.Include("Browsers");

            //var test1 = retVal1.ToList();
            //var test2 = retVal2.ToList();
            return retVal2.OrderByDescending(x => x.SearchResultWeighting).ToList();
        }
        #endregion

        #region GetSearchResultsCount
        public int GetSearchResultsCount(System.Linq.Expressions.Expression<Func<CloudApplication, bool>> predicate, bool liveApplicationsOnly)
        {

            var retVal2 = _context.CloudApplications
                .Include(p => p.Vendor)
                .Include(p => p.FreeTrialPeriod)
                .Include(p => p.SetupFee)
                .Include(p => p.OperatingSystems)
                .Include(p => p.Devices)
                .Include(p => p.SupportTypes)
                .Include(p => p.SupportDays)
                .Include(p => p.SupportHours)
                .Include(p => p.Languages)
                .Include(p => p.CloudApplicationFeatures)
                .AsExpandable().Where(predicate.Expand());

            return retVal2.Count();
        }
        #endregion

        #region GetCloudApplication
        public CloudApplication GetCloudApplication(int cloudApplicationID, bool pingSocialNetworks)
        {
            return this.GetCloudApplication(cloudApplicationID, pingSocialNetworks, true);
        }
        
        public CloudApplication GetCloudApplication(int cloudApplicationID, bool pingSocialNetworks, bool liveOnly)
        {
            bool linkedInPingActive = Convert.ToBoolean(ConfigurationManager.AppSettings["LinkedInPingActive"]);
            bool facebookPingActive = Convert.ToBoolean(ConfigurationManager.AppSettings["FacebookPingActive"]);
            bool twitterPingActive = Convert.ToBoolean(ConfigurationManager.AppSettings["TwitterPingActive"]);
            //return _context.FindById(cloudApplicationID);
            //var retVal1 = _context.CloudApplications.Where(x => x.CloudApplicationID == cloudApplicationID)
            //    .Include(x => x.Languages.Where(y => y.LanguageID == 1))
                
            //    ;
            //var retVal2 = (from ca in _context.CloudApplications where ca.CloudApplicationID == cloudApplicationID select ca).FirstOrDefault();


            var objectStateEntries = this._context.ObjectContext()
                             .ObjectStateManager
                             .GetObjectStateEntries(EntityState.Unchanged);

            IList<CloudApplication> objectStateEntries2 = this.GetCloudApplicationContextUnchanged();

            if (objectStateEntries2 != null)
            {
                foreach (CloudApplication entry in objectStateEntries2)
                {
                    //this._context.ObjectContext().Detach(objectStateEntries2);
                    this._context.ObjectContext().Detach(entry);
                }
            }
            
            CloudApplication retVal2 = 
                (from ca in
                _context.CloudApplications 
                where ca.CloudApplicationID == cloudApplicationID 
                select ca)
                //.AsNoTracking()
                .FirstOrDefault();

            //db.Entry(model).State = EntityState.Modified;
            //_requestLifeTimeContext.Entry(model).State = EntityState.Modified;
            //_requestLifeTimeContext.SaveChanges();
            //insertStatus = true;
            //_context.ObjectContext().Refresh(RefreshMode.StoreWins, retVal2);
            //throw new Exception("Unable to save - ");

            retVal2.Languages = retVal2.Languages != null ? retVal2.Languages.Where(x => x.LanguageStatus == FindStatusByName("LIVE")).ToList() : null;
            retVal2.Browsers = retVal2.Browsers != null ? retVal2.Browsers.Where(x => x.BrowserStatus == FindStatusByName("LIVE")).ToList() : null;
            retVal2.MobilePlatforms = retVal2.MobilePlatforms != null ? retVal2.MobilePlatforms.Where(x => x.MobilePlatformStatus == FindStatusByName("LIVE")).ToList() : null;
            retVal2.OperatingSystems = retVal2.OperatingSystems != null ? retVal2.OperatingSystems.Where(x => x.OperatingSystemStatus == FindStatusByName("LIVE")).ToList() : null;
            retVal2.PaymentOptions = retVal2.PaymentOptions != null ? retVal2.PaymentOptions.Where(x => x.PaymentOptionStatus == FindStatusByName("LIVE")).ToList() : null;
            retVal2.SupportTerritories = retVal2.SupportTerritories != null ? retVal2.SupportTerritories.Where(x => x.SupportTerritoryStatus == FindStatusByName("LIVE")).ToList() : null;
            retVal2.SupportTypes = retVal2.SupportTypes != null ? retVal2.SupportTypes.Where(x => x.SupportTypeStatus == FindStatusByName("LIVE")).ToList() : null;

            if (liveOnly)
            {
                retVal2.CloudApplicationFeatures = retVal2.CloudApplicationFeatures != null ? retVal2.CloudApplicationFeatures.Where(x => x.Feature != null).Where(x => x.Feature.FeatureStatus == FindStatusByName("LIVE")).ToList() : null;
                retVal2.CloudApplicationDocuments = retVal2.CloudApplicationDocuments != null ? retVal2.CloudApplicationDocuments.Where(x => x.CloudApplicationDocumentStatus == FindStatusByName("LIVE")).ToList() : null;
                retVal2.CloudApplicationProductReviews = retVal2.CloudApplicationProductReviews != null ? retVal2.CloudApplicationProductReviews.Where(x => x.CloudApplicationProductReviewStatus == FindStatusByName("LIVE")).ToList() : null;
                retVal2.CloudApplicationUserReviews = retVal2.CloudApplicationUserReviews != null ? retVal2.CloudApplicationUserReviews.Where(x => x.CloudApplicationUserReviewStatus == FindStatusByName("LIVE")).ToList() : null;
                retVal2.CloudApplicationVideos = retVal2.CloudApplicationVideos != null ? retVal2.CloudApplicationVideos.Where(x => x.CloudApplicationVideoStatus == FindStatusByName("LIVE")).ToList() : null;

                retVal2.CloudApplicationApplications = retVal2.CloudApplicationApplications != null ? retVal2.CloudApplicationApplications.Where(x => x.CloudApplicationApplicationStatus == FindStatusByName("LIVE")).ToList() : null;
                //retVal2.Devices = retVal2.Devices.Where(x => x.DeviceStatus == FindStatusByName("LIVE")).ToList();

                //retVal2.Include(x => x.Languages.Where(y => y.LanguageStatus == FindStatusByName("LIVE")));
                //retVal2.Languages.Include(x => x.Languages).Where(z => z.Languages.Contains(q => q. .LanguageID == 1));
                //.Where(y => y.LanguageStatus.StatusID == 1));
                //retVal2 = retVal2.FirstOrDefault();
            }
            else
            {
                retVal2.CloudApplicationFeatures = retVal2.CloudApplicationFeatures != null ? retVal2.CloudApplicationFeatures.ToList() : null;
                retVal2.CloudApplicationApplications = retVal2.CloudApplicationApplications != null ? retVal2.CloudApplicationApplications.ToList() : null;
                retVal2.CloudApplicationDocuments = retVal2.CloudApplicationDocuments != null ? retVal2.CloudApplicationDocuments.ToList() : null;
                retVal2.CloudApplicationProductReviews = retVal2.CloudApplicationProductReviews != null ? retVal2.CloudApplicationProductReviews.ToList() : null;
                retVal2.CloudApplicationUserReviews = retVal2.CloudApplicationUserReviews != null ? retVal2.CloudApplicationUserReviews.ToList() : null;
                retVal2.CloudApplicationVideos = retVal2.CloudApplicationVideos != null ? retVal2.CloudApplicationVideos.ToList() : null;
            }

            #region PING SOCIAL NETWORKS
            if (pingSocialNetworks)
            {
                //DateTime? lastPing = retVal2.LastFacebookPing == null ? DateTime.Now.AddHours(-25) : retVal2.LastFacebookPing;
                if (linkedInPingActive && (retVal2.LastLinkedInPing < DateTime.Now.AddHours(-24) || retVal2.LastLinkedInPing == null))
                {
                    LinkedIn linkedIn = new LinkedIn();
                    long followers;
                    //followers = linkedIn.GetLinkedInFollowerCount(retVal2.Vendor.VendorName);
                    followers = linkedIn.GetLinkedInFollowerCount(retVal2.LinkedInCompanyID.ToString());
                    if (followers > 0)
                    {
                        retVal2.LinkedInFollowers = followers;
                        retVal2.LastLinkedInPing = DateTime.Now;
                    }
                }
                if (facebookPingActive && (retVal2.LastFacebookPing < DateTime.Now.AddHours(-24) || retVal2.LastFacebookPing == null))
                {
                    Facebook facebook = new Facebook();
                    long followers;
                    //followers = facebook.GetFacebookFans(retVal2.Vendor.VendorName);
                    followers = facebook.GetFacebookFans(retVal2.FacebookName);
                    if (followers > 0)
                    {
                        retVal2.FacebookFollowers = followers;
                        retVal2.LastFacebookPing = DateTime.Now;
                    }
                }
                if (twitterPingActive && (retVal2.LastTwitterPing < DateTime.Now.AddHours(-24) || retVal2.LastTwitterPing == null))
                {
                    Twitter twitter = new Twitter();
                    long followers;
                    //followers = twitter.GetTwitterFollowerCount(retVal2.Vendor.VendorName);
                    followers = twitter.GetTwitterFollowerCount(retVal2.TwitterName);
                    if (followers > 0)
                    {
                        retVal2.TwitterFollowers = followers;
                        retVal2.LastTwitterPing = DateTime.Now;
                    }
                }
                Logger.Debug("Updating social networking stats for cloud application ID : " + retVal2.CloudApplicationID.ToString());
                this.Update<CloudApplication>("1", retVal2,RefreshMode.StoreWins);
            }
            #endregion

            //_context.ObjectContext().Detach(retVal2);

            return retVal2;
        }

        public CloudApplication GetCloudApplication(int cloudApplicationID, bool pingSocialNetworks, bool liveOnly, RefreshMode refreshMode)
        {
            if (Logger != null)
            {
                Logger.Debug("Getting cloud application IN");
            }
            bool linkedInPingActive = Convert.ToBoolean(ConfigurationManager.AppSettings["LinkedInPingActive"]);
            bool facebookPingActive = Convert.ToBoolean(ConfigurationManager.AppSettings["FacebookPingActive"]);
            bool twitterPingActive = Convert.ToBoolean(ConfigurationManager.AppSettings["TwitterPingActive"]);
            //return _context.FindById(cloudApplicationID);
            //var retVal1 = _context.CloudApplications.Where(x => x.CloudApplicationID == cloudApplicationID)
            //    .Include(x => x.Languages.Where(y => y.LanguageID == 1))

            //    ;
            //var retVal2 = (from ca in _context.CloudApplications where ca.CloudApplicationID == cloudApplicationID select ca).FirstOrDefault();
            CloudApplication retVal2 =
                (from ca in
                     _context.CloudApplications
                 where ca.CloudApplicationID == cloudApplicationID
                 select ca).FirstOrDefault();

            if (refreshMode == RefreshMode.StoreWins)
            {
                Logger.Debug("Refreshing context");
                this._context.ObjectContext().Refresh(refreshMode, retVal2);
                if (retVal2.Languages != null)
                {
                    Logger.Debug("Refreshing languages");
                    this._context.ObjectContext().Refresh(refreshMode, retVal2.Languages);
                }
                if (retVal2.Browsers != null)
                {
                    Logger.Debug("Refreshing browsers");
                    this._context.ObjectContext().Refresh(refreshMode, retVal2.Browsers);
                }
                if (retVal2.CloudApplicationVideos != null)
                {
                    Logger.Debug("Refreshing videos");
                    this._context.ObjectContext().Refresh(refreshMode, retVal2.CloudApplicationVideos);
                }
                if (retVal2.MobilePlatforms != null)
                {
                    Logger.Debug("Refreshing mobile platforms");
                    this._context.ObjectContext().Refresh(refreshMode, retVal2.MobilePlatforms);
                }
                if (retVal2.OperatingSystems != null)
                {
                    Logger.Debug("Refreshing operating systems");
                    this._context.ObjectContext().Refresh(refreshMode, retVal2.OperatingSystems);
                }
                if (retVal2.PaymentOptions != null)
                {
                    Logger.Debug("Refreshing payment options");
                    this._context.ObjectContext().Refresh(refreshMode, retVal2.PaymentOptions);
                }
                if (retVal2.SupportTerritories != null)
                {
                    Logger.Debug("Refreshing support territories");
                    this._context.ObjectContext().Refresh(refreshMode, retVal2.SupportTerritories);
                }
                if (retVal2.SupportTypes != null)
                {
                    Logger.Debug("Refreshing support types");
                    this._context.ObjectContext().Refresh(refreshMode, retVal2.SupportTypes);
                }
                if (retVal2.CloudApplicationFeatures != null)
                {
                    Logger.Debug("Refreshing cloud application features");
                    this._context.ObjectContext().Refresh(refreshMode, retVal2.CloudApplicationFeatures);
                }
                if (retVal2.CloudApplicationDocuments != null)
                {
                    Logger.Debug("Refreshing documents");
                    this._context.ObjectContext().Refresh(refreshMode, retVal2.CloudApplicationDocuments);
                }
                if (retVal2.CloudApplicationProductReviews != null)
                {
                    Logger.Debug("Refreshing product reviews");
                    this._context.ObjectContext().Refresh(refreshMode, retVal2.CloudApplicationProductReviews);
                }
                if (retVal2.CloudApplicationUserReviews != null)
                {
                    Logger.Debug("Refreshing user reviews");
                    this._context.ObjectContext().Refresh(refreshMode, retVal2.CloudApplicationUserReviews);

                    //CloudApplicationUserReview test = this._context.CloudApplicationUserReviews.AsEnumerable().First();
                    //string test2 = test.CloudApplicationUserReviewTitle;
                    //this._context.ObjectContext().Refresh(refreshMode, retVal2.CloudApplicationUserReviews.AsEnumerable());
                }
                if (retVal2.CloudApplicationApplications != null)
                {
                    Logger.Debug("Refreshing cloud application applications");
                    this._context.ObjectContext().Refresh(refreshMode, retVal2.CloudApplicationApplications);
                }
            }

            #region PING SOCIAL NETWORKS
            if (pingSocialNetworks)
            {
                //DateTime? lastPing = retVal2.LastFacebookPing == null ? DateTime.Now.AddHours(-25) : retVal2.LastFacebookPing;
                if (linkedInPingActive && (retVal2.LastLinkedInPing < DateTime.Now.AddHours(-24) || retVal2.LastLinkedInPing == null))
                {
                    Logger.Debug("Refreshing LinkedIn");
                    LinkedIn linkedIn = new LinkedIn();
                    long followers;
                    //followers = linkedIn.GetLinkedInFollowerCount(retVal2.Vendor.VendorName);
                    followers = linkedIn.GetLinkedInFollowerCount(retVal2.LinkedInCompanyID.ToString());
                    if (followers > 0)
                    {
                        retVal2.LinkedInFollowers = followers;
                        retVal2.LastLinkedInPing = DateTime.Now;
                    }
                }
                if (facebookPingActive && (retVal2.LastFacebookPing < DateTime.Now.AddHours(-24) || retVal2.LastFacebookPing == null))
                {
                    Logger.Debug("Refreshing Facebook");
                    Facebook facebook = new Facebook();
                    long followers;
                    //followers = facebook.GetFacebookFans(retVal2.Vendor.VendorName);
                    followers = facebook.GetFacebookFans(retVal2.FacebookName);
                    if (followers > 0)
                    {
                        retVal2.FacebookFollowers = followers;
                        retVal2.LastFacebookPing = DateTime.Now;
                    }
                }
                if (twitterPingActive && (retVal2.LastTwitterPing < DateTime.Now.AddHours(-24) || retVal2.LastTwitterPing == null))
                {
                    Logger.Debug("Refreshing twitter");
                    Twitter twitter = new Twitter();
                    long followers;
                    //followers = twitter.GetTwitterFollowerCount(retVal2.Vendor.VendorName);
                    followers = twitter.GetTwitterFollowerCount(retVal2.TwitterName);
                    if (followers > 0)
                    {
                        retVal2.TwitterFollowers = followers;
                        retVal2.LastTwitterPing = DateTime.Now;
                    }
                }
                Logger.Debug("Updating social networking stats for cloud application ID : " + retVal2.CloudApplicationID.ToString());
                this.Update<CloudApplication>("1", retVal2, RefreshMode.StoreWins);
            }
            #endregion

            Logger.Debug("TOLIST()");
            retVal2.Languages = retVal2.Languages != null ? retVal2.Languages.Where(x => x.LanguageStatus == FindStatusByName("LIVE")).ToList() : null;
            retVal2.Browsers = retVal2.Browsers != null ? retVal2.Browsers.Where(x => x.BrowserStatus == FindStatusByName("LIVE")).ToList() : null;
            retVal2.CloudApplicationVideos = retVal2.CloudApplicationVideos != null ? retVal2.CloudApplicationVideos.Where(x => x.CloudApplicationVideoStatus == FindStatusByName("LIVE")).ToList() : null;
            retVal2.MobilePlatforms = retVal2.MobilePlatforms != null ? retVal2.MobilePlatforms.Where(x => x.MobilePlatformStatus == FindStatusByName("LIVE")).ToList() : null;
            retVal2.OperatingSystems = retVal2.OperatingSystems != null ? retVal2.OperatingSystems.Where(x => x.OperatingSystemStatus == FindStatusByName("LIVE")).ToList() : null;
            retVal2.PaymentOptions = retVal2.PaymentOptions != null ? retVal2.PaymentOptions.Where(x => x.PaymentOptionStatus == FindStatusByName("LIVE")).ToList() : null;
            retVal2.SupportTerritories = retVal2.SupportTerritories != null ? retVal2.SupportTerritories.Where(x => x.SupportTerritoryStatus == FindStatusByName("LIVE")).ToList() : null;
            retVal2.SupportTypes = retVal2.SupportTypes != null ? retVal2.SupportTypes.Where(x => x.SupportTypeStatus == FindStatusByName("LIVE")).ToList() : null;

            if (liveOnly)
            {
                Logger.Debug("LIVEONLY TOLIST()");
                retVal2.CloudApplicationFeatures = retVal2.CloudApplicationFeatures != null ? retVal2.CloudApplicationFeatures.Where(x => x.Feature.FeatureStatus == FindStatusByName("LIVE")).Where(x => x.CloudApplicationFeatureStatus == FindStatusByName("LIVE")).ToList() : null;
                retVal2.CloudApplicationDocuments = retVal2.CloudApplicationDocuments != null ? retVal2.CloudApplicationDocuments.Where(x => x.CloudApplicationDocumentStatus == FindStatusByName("LIVE")).ToList() : null;
                retVal2.CloudApplicationProductReviews = retVal2.CloudApplicationProductReviews != null ? retVal2.CloudApplicationProductReviews.Where(x => x.CloudApplicationProductReviewStatus == FindStatusByName("LIVE")).ToList() : null;
                retVal2.CloudApplicationUserReviews = retVal2.CloudApplicationUserReviews != null ? retVal2.CloudApplicationUserReviews.Where(x => x.CloudApplicationUserReviewStatus == FindStatusByName("LIVE")).ToList() : null;

                retVal2.CloudApplicationApplications = retVal2.CloudApplicationApplications != null ? retVal2.CloudApplicationApplications.Where(x => x.CloudApplicationApplicationStatus == FindStatusByName("LIVE")).ToList() : null;
                //retVal2.Devices = retVal2.Devices.Where(x => x.DeviceStatus == FindStatusByName("LIVE")).ToList();

                //retVal2.Include(x => x.Languages.Where(y => y.LanguageStatus == FindStatusByName("LIVE")));
                //retVal2.Languages.Include(x => x.Languages).Where(z => z.Languages.Contains(q => q. .LanguageID == 1));
                //.Where(y => y.LanguageStatus.StatusID == 1));
                //retVal2 = retVal2.FirstOrDefault();
            }
            else
            {
                retVal2.CloudApplicationFeatures = retVal2.CloudApplicationFeatures != null ? retVal2.CloudApplicationFeatures.ToList() : null;
                retVal2.CloudApplicationApplications = retVal2.CloudApplicationApplications != null ? retVal2.CloudApplicationApplications.ToList() : null;
                retVal2.CloudApplicationDocuments = retVal2.CloudApplicationDocuments != null ? retVal2.CloudApplicationDocuments.ToList() : null;
                retVal2.CloudApplicationProductReviews = retVal2.CloudApplicationProductReviews != null ? retVal2.CloudApplicationProductReviews.ToList() : null;
                retVal2.CloudApplicationUserReviews = retVal2.CloudApplicationUserReviews != null ? retVal2.CloudApplicationUserReviews.ToList() : null;
            }

            if (Logger != null)
            {
                Logger.Debug("Getting cloud application OUT");
            }
            return retVal2;
        }

        public CloudApplication GetCloudApplicationAsReadOnly(int cloudApplicationID)
        {
            CloudApplication retVal2 =
                (from ca in
                     _context.CloudApplications
                 where ca.CloudApplicationID == cloudApplicationID
                 select ca).AsNoTracking().FirstOrDefault();
            return retVal2;
        }

        #endregion

        #region GetCloudApplications
        public IQueryable<CloudApplication> GetCloudApplications(int vendorID)
        {
            //return _context.FindById(cloudApplicationID);
            //var retVal1 = _context.CloudApplications.Where(x => x.CloudApplicationID == cloudApplicationID);
            var retVal2 = (from ca in _context.CloudApplications where ca.Vendor.VendorID == vendorID select ca);
            return retVal2;
        }

        public IQueryable<CloudApplication> GetCloudApplications(int vendorID, int categoryID, bool liveOnly)
        {
            //return _context.FindById(cloudApplicationID);
            //var retVal1 = _context.CloudApplications.Where(x => x.CloudApplicationID == cloudApplicationID);
            var retVal2 = (from ca in _context.CloudApplications where ca.Vendor.VendorID == vendorID && ca.Category.CategoryID == categoryID select ca);
            if (liveOnly)
            {
                return retVal2.Where(x => x.CloudApplicationStatus.StatusName.ToUpper() == "LIVE");
            }
            else
            {
                return retVal2;
            }

        }
        #endregion

        #region GetCloudApplicationsByVendor
        public IList<CloudApplication> GetCloudApplicationsByVendor(int vendorID)
        {
            //return _context.FindById(cloudApplicationID);
            //var retVal1 = _context.CloudApplications.Where(x => x.CloudApplicationID == cloudApplicationID).FirstOrDefault();
            //var retVal2 = (from ca in _context.CloudApplications where ca.CloudApplicationID == cloudApplicationID select ca).FirstOrDefault();

            //var retVal3 = _context.CloudApplications.Where(x => x.Vendor.VendorID == vendorID);
            var retVal4 = (from ca in _context.CloudApplications where ca.Vendor.VendorID == vendorID select ca);
            
            
            return retVal4.ToList();
        }

        public IList<CloudApplication> GetCloudApplicationsByVendor(int vendorID, int categoryID, bool liveOnly)
        {
            if (Logger != null)
            {
                Logger.Debug("Getting cloud applications by vendor IN");
            }
            //return _context.FindById(cloudApplicationID);
            //var retVal1 = _context.CloudApplications.Where(x => x.CloudApplicationID == cloudApplicationID).FirstOrDefault();
            //var retVal2 = (from ca in _context.CloudApplications where ca.CloudApplicationID == cloudApplicationID select ca).FirstOrDefault();

            //var retVal3 = _context.CloudApplications.Where(x => x.Vendor.VendorID == vendorID);
            var retVal4 = (from ca in _context.CloudApplications where ca.Vendor.VendorID == vendorID && ca.Category.CategoryID == categoryID select ca);

            if (liveOnly)
            {
                return retVal4.Where(x => x.CloudApplicationStatus.StatusName.ToUpper() == "LIVE").ToList();
            }
            else
            {
                return retVal4.ToList();
            }
        }

        #endregion

        #region GetCloudApplicationDocument
        public CloudApplicationDocument GetCloudApplicationDocument(int documentID)
        {
            //return _context.FindById(cloudApplicationID);
            //var retVal1 = _context.ThumbnailDocuments.Where(x => x.ThumbnailDocumentID == thumbnailDocumentID);
            var retVal2 = (from ca in _context.CloudApplicationDocuments where ca.CloudApplicationDocumentID == documentID select ca).FirstOrDefault();
            return retVal2;
        }
        #endregion

        #region GetCloudApplicationDocument
        public CloudApplicationDocumentImage GetCloudApplicationDocumentImage(int documentID)
        {
            //return _context.FindById(cloudApplicationID);
            //var retVal1 = _context.ThumbnailDocuments.Where(x => x.ThumbnailDocumentID == thumbnailDocumentID);
            var retVal2 = (from ca in _context.CloudApplicationDocuments where ca.CloudApplicationDocumentID == documentID select ca).FirstOrDefault();
            return retVal2.CloudApplicationDocumentImage;
        }
        #endregion

        #region GetNumberOfUsers
        public IList<NumberOfUsers> GetNumberOfUsers(bool includeZero)
        {
            List<NumberOfUsers> NumberOfUsers = new List<NumberOfUsers>();
            int startValue = includeZero ? 0 : 1;
            for (int i = startValue; i <= 50; i++)
            {
                NumberOfUsers.Add(new NumberOfUsers() { UserValue = i });
            }

            var retVal1 = _context.LicenceTypeMaximums.Select(x => new { User = x.LicenceTypeMaximumName }).ToList().Select(y => y.User).Where(z => z > 50);

            //var retVal2 = _context.LicenceTypeMinimums.Where(x => int.Parse(x.LicenceTypeMinimumName) > 50).OrderBy(x => int.Parse(x.LicenceTypeMinimumName));

            retVal1.ForEach(x => NumberOfUsers.Add(new NumberOfUsers() { UserValue = x }));
            return NumberOfUsers;
        }
        #endregion

        #region GetAdvertisingImage
        public AdvertisingImage GetAdvertisingImage(int advertisingImageID, int? categoryID)
        {
            //return _context.FindById(cloudApplicationID);
            //var retVal1 = _context.AdvertisingImages.Where(x => x.AdvertisingImageID == advertisingImageID);
            var retVal2 = (from ca in _context.AdvertisingImages where ca.AdvertisingImageID == advertisingImageID select ca).FirstOrDefault();
            return retVal2;
        }
        #endregion

        #region GetAdvertisingImage
        public AdvertisingImage GetAdvertisingImage(int advertisingImageID, string advertisingImageType, int? categoryID)
        {
            return GetAdvertisingImage(advertisingImageID, advertisingImageType, categoryID, false);
        }
        #endregion

        #region GetAdvertisingImage
        public AdvertisingImage GetAdvertisingImage(int advertisingImageID, string advertisingImageType, int? categoryID, bool liveOnly)
        {
            AdvertisingImage ai = null;
            int skyScraperImageCount = 0;
            int? cachedSkyScraperImageCount;
            int MPUImageCount = 0;
            int? cachedMPUImageCount;

            if ((categoryID ?? 0) == 0)
            {
                categoryID = new Random().Next(1, 9);
            }

            #region Get Image Counts
            cachedSkyScraperImageCount = (int?)Cache.Get("SKYSCRAPER_IMAGECOUNT");
            if (liveOnly)
            {
                skyScraperImageCount = (from ca in _context.AdvertisingImages 
                                        where ca.AdvertisingImageType.AdvertisingImageTypeID == 3
                                        && ca.AdvertisingImageStatus.StatusName.ToUpper() == "LIVE"
                                        select ca).Count();
            }
            else
            {
                skyScraperImageCount = (from ca in _context.AdvertisingImages where ca.AdvertisingImageType.AdvertisingImageTypeID == 3 select ca).Count();
            }

            if (cachedSkyScraperImageCount != skyScraperImageCount)
            {
                int cacheDuration = int.Parse(ConfigurationManager.AppSettings["CacheSkyScraperCountDuration"]);
                Cache.Set("SKYSCRAPER_IMAGECOUNT", skyScraperImageCount, cacheDuration);
            }

            cachedMPUImageCount = (int?)Cache.Get("MPU_IMAGECOUNT");
            if (liveOnly)
            {
                MPUImageCount = (from ca in _context.AdvertisingImages 
                                 where ca.AdvertisingImageType.AdvertisingImageTypeID == 1
                                 && ca.AdvertisingImageStatus.StatusName.ToUpper() == "LIVE"
                                 select ca).Count();
            }
            else
            {
                MPUImageCount = (from ca in _context.AdvertisingImages where ca.AdvertisingImageType.AdvertisingImageTypeID == 1 select ca).Count();
            }
            if (cachedMPUImageCount != MPUImageCount)
            {
                int cacheDuration = int.Parse(ConfigurationManager.AppSettings["CacheMPUCountDuration"]);
                Cache.Set("MPU_IMAGECOUNT", MPUImageCount, cacheDuration);
            }
            #endregion

            Logger.Debug("Getting advertising image ID " + advertisingImageID.ToString() + " for " + advertisingImageType + " in category ID " + categoryID.ToString());

            if (advertisingImageType == "SKYSCRAPER")
            {
                if (advertisingImageID == 0)
                {
                    //advertisingImageID = new Random().Next(1, skyScraperImageCount);
                    advertisingImageID = GetNextAdvertisingImageID(advertisingImageType, categoryID);
                }
                ai = Cache.Get("SKYSCRAPER_" + advertisingImageID.ToString()) as AdvertisingImage;

                if (ai == null)
                {
                    if (liveOnly)
                    {
                        var images = from ca in _context.AdvertisingImages
                                     where 
                                     //ca.AdvertisingImageType.AdvertisingImageTypeID == 3
                                     ca.AdvertisingImageStatus.StatusName.ToUpper() == "LIVE"
                                     && ca.AdvertisingImageID == advertisingImageID
                                     select ca;
                        //var retVal3 = (from ca in _context.AdvertisingImages select ca).ToList()[advertisingImageID];
                        //var retVal3 = images.ToList()[advertisingImageID];

                        if (images.Count() > 0)
                        {
                            var retVal3 = images.First();
                            int cacheDuration = int.Parse(ConfigurationManager.AppSettings["CacheSkyScraperDuration"]);
                            Cache.Set("SKYSCRAPER_" + advertisingImageID.ToString(), retVal3, cacheDuration);
                            ai = retVal3;
                            //return retVal3;
                        }
                        else
                        {
                            Logger.Debug("Error getting advertising image ID " + advertisingImageID.ToString() + " for " + advertisingImageType + " in category ID " + categoryID.ToString() + ". Count is zero");
                        }
                    }
                    else
                    {
                        var images = from ca in _context.AdvertisingImages
                                     where ca.AdvertisingImageType.AdvertisingImageTypeID == 3
                                     select ca;
                        //var retVal3 = (from ca in _context.AdvertisingImages select ca).ToList()[advertisingImageID];
                        var retVal3 = images.ToList()[advertisingImageID];
                        int cacheDuration = int.Parse(ConfigurationManager.AppSettings["CacheSkyScraperDuration"]);
                        Cache.Set("SKYSCRAPER_" + advertisingImageID.ToString(), retVal3, cacheDuration);
                        ai = retVal3;
                        //return retVal3;
                    }

                }
                else
                {
                    //ai = retVal3;
                    //return ai;
                }
            }
            if (advertisingImageType == "MPU")
            {
                if (advertisingImageID == 0)
                {
                    //advertisingImageID = new Random().Next(1, MPUImageCount);
                    advertisingImageID = GetNextAdvertisingImageID(advertisingImageType, categoryID);
                }
                ai = Cache.Get("MPU_" + advertisingImageID.ToString()) as AdvertisingImage;

                if (ai == null)
                {
                    if (liveOnly)
                    {
                        if (advertisingImageID == 0)
                        {

                        }
                        var images = from ca in _context.AdvertisingImages
                                     where 
                                     //ca.AdvertisingImageType.AdvertisingImageTypeID == 1
                                     ca.AdvertisingImageStatus.StatusName.ToUpper() == "LIVE"
                                     //&& ca.Category.CategoryID == categoryID
                                     //&& 
                                     && ca.AdvertisingImageID == advertisingImageID
                                     select ca;
                        //var retVal3 = (from ca in _context.AdvertisingImages select ca).ToList()[advertisingImageID];
                        //var retVal3 = images.ToList()[advertisingImageID];

                        if (images.Count() > 0)
                        {

                            var retVal3 = images.First();
                            int cacheDuration = int.Parse(ConfigurationManager.AppSettings["CacheMPUDuration"]);
                            Cache.Set("MPU_" + advertisingImageID.ToString(), retVal3, cacheDuration);
                            ai = retVal3;
                            //return retVal3;
                        }
                        else
                        {
                            Logger.Debug("Error getting advertising image ID " + advertisingImageID.ToString() + " for " + advertisingImageType + " in category ID " + categoryID.ToString() + ". Count is zero");
                            SetNextAdvertisingImageID(advertisingImageType, null, categoryID);
                        }
                    }
                    else
                    {
                        var images = from ca in _context.AdvertisingImages
                                     where ca.AdvertisingImageType.AdvertisingImageTypeID == 1
                                     select ca;
                        //var retVal3 = (from ca in _context.AdvertisingImages select ca).ToList()[advertisingImageID];
                        var retVal3 = images.ToList()[advertisingImageID];
                        int cacheDuration = int.Parse(ConfigurationManager.AppSettings["CacheMPUDuration"]);
                        Cache.Set("MPU_" + advertisingImageID.ToString(), retVal3, cacheDuration);
                        ai = retVal3;
                        //return retVal3;
                    }
                }
                else
                {
                    //return ai;
                }
            }
            //return _context.FindById(cloudApplicationID);
            //var retVal1 = _context.AdvertisingImages.Where(x => x.AdvertisingImageID == advertisingImageID);
            //var retVal2 = (from ca in _context.AdvertisingImages where ca.AdvertisingImageID == advertisingImageID select ca).FirstOrDefault();

            //return null;
            //return retVal3;
            if (ai != null)
            {
                SetNextAdvertisingImageID(advertisingImageType, ai.AdvertisingImageID, categoryID);
            }
            return ai;
        }
        #endregion

        #region GetNextAdvertisingImageID
        private int GetNextAdvertisingImageID(string advertisingImageType, int? categoryID)
        {
            int? retVal = 0;
            AdvertisingImageServer ais = _context.AdvertisingImageServer.First();
            if (advertisingImageType == "MPU")
            {
                switch (categoryID)
                {
                    case CATEGORY_ID_PHONE:
                    case CATEGORY_ID_COMMUNICATIONS:
                        retVal = ais.NextMPUVoiceID;
                        break;
                    case CATEGORY_ID_CRM:
                        retVal = ais.NextMPUCRMID;
                        break;
                    case CATEGORY_ID_WEB_CONFERENCING:
                        retVal = ais.NextMPUWebConferencingID;
                        break;
                    case CATEGORY_ID_EMAIL:
                        retVal = ais.NextMPUEMailID;
                        break;
                    case CATEGORY_ID_OFFICE:
                        retVal = ais.NextMPUOfficeID;
                        break;
                    case CATEGORY_ID_STORAGE_AND_BACKUP:
                        retVal = ais.NextMPUStorageAndBackupID;
                        break;
                    case CATEGORY_ID_PROJECT_MANAGEMENT:
                        retVal = ais.NextMPUProjectManagementID;
                        break;
                    case CATEGORY_ID_FINANCIAL:
                        retVal = ais.NextMPUFinancialID;
                        break;
                    case CATEGORY_ID_SECURITY:
                        retVal = ais.NextMPUSecurityID;
                        break;
                    case CATEGORY_ID_MARKETING:
                        retVal = ais.NextMPUSecurityID;
                        break;
                    case CATEGORY_ID_WEBSITE:
                        retVal = ais.NextMPUSecurityID;
                        break;
                    case CATEGORY_ID_CREATIVE:
                        retVal = ais.NextMPUSecurityID;
                        break;
                    case CATEGORY_ID_BUSINESS_INTELLIGENCE_REPORTING:
                        retVal = ais.NextMPUSecurityID;
                        break;
                    case CATEGORY_ID_HOSTING:
                        retVal = ais.NextMPUSecurityID;
                        break;
                    case CATEGORY_ID_HR:
                        retVal = ais.NextMPUSecurityID;
                        break;
                    case CATEGORY_ID_PAYMENTS:
                        retVal = ais.NextMPUSecurityID;
                        break;
                    case CATEGORY_ID_BUSINESS_AND_OPERATIONS:
                        retVal = ais.NextMPUSecurityID;
                        break;
                    case CATEGORY_ID_SALES:
                        retVal = ais.NextMPUSecurityID;
                        break;
                }
            }
            if (advertisingImageType == "SKYSCRAPER")
            {
                switch (categoryID)
                {
                    case CATEGORY_ID_PHONE:
                    case CATEGORY_ID_COMMUNICATIONS:
                        retVal = ais.NextSkyscraperVoiceID;
                        break;
                    case CATEGORY_ID_CRM:
                        retVal = ais.NextSkyscraperCRMID;
                        break;
                    case CATEGORY_ID_WEB_CONFERENCING:
                        retVal = ais.NextSkyscraperWebConferencingID;
                        break;
                    case CATEGORY_ID_EMAIL:
                        retVal = ais.NextSkyscraperEMailID;
                        break;
                    case CATEGORY_ID_OFFICE:
                        retVal = ais.NextSkyscraperOfficeID;
                        break;
                    case CATEGORY_ID_STORAGE_AND_BACKUP:
                        retVal = ais.NextSkyscraperStorageAndBackupID;
                        break;
                    case CATEGORY_ID_PROJECT_MANAGEMENT:
                        retVal = ais.NextSkyscraperProjectManagementID;
                        break;
                    case CATEGORY_ID_FINANCIAL:
                        retVal = ais.NextSkyscraperFinancialID;
                        break;
                    case CATEGORY_ID_SECURITY:
                        retVal = ais.NextSkyscraperSecurityID;
                        break;
                    case CATEGORY_ID_MARKETING:
                        retVal = ais.NextSkyscraperSecurityID;
                        break;
                    case CATEGORY_ID_WEBSITE:
                        retVal = ais.NextSkyscraperSecurityID;
                        break;
                    case CATEGORY_ID_CREATIVE:
                        retVal = ais.NextSkyscraperSecurityID;
                        break;
                    case CATEGORY_ID_BUSINESS_INTELLIGENCE_REPORTING:
                        retVal = ais.NextSkyscraperSecurityID;
                        break;
                    case CATEGORY_ID_HOSTING:
                        retVal = ais.NextSkyscraperSecurityID;
                        break;
                    case CATEGORY_ID_HR:
                        retVal = ais.NextSkyscraperSecurityID;
                        break;
                    case CATEGORY_ID_PAYMENTS:
                        retVal = ais.NextSkyscraperSecurityID;
                        break;
                    case CATEGORY_ID_BUSINESS_AND_OPERATIONS:
                        retVal = ais.NextSkyscraperSecurityID;
                        break;
                    case CATEGORY_ID_SALES:
                        retVal = ais.NextSkyscraperSecurityID;
                        break;
                }
            }
            if (retVal == null)
            {
                var images = (from ca in _context.AdvertisingImages
                             where
                             ca.Category.CategoryID == categoryID
                             && ca.AdvertisingImageType.AdvertisingImageTypeName == advertisingImageType
                             && ca.AdvertisingImageStatus.StatusName.ToUpper() == "LIVE"
                             select ca)
                             .FirstOrDefault();
                if (images != null)
                {
                    retVal = images.AdvertisingImageID;
                }

            }
            return (int)(retVal ?? 0);
        }
        #endregion

        #region SetNextAdvertisingImageID
        private void SetNextAdvertisingImageID(string advertisingImageType, int? currentAdvertisingImageID, int? categoryID)
        {
            int? advertisingImageTypeAsInt = null;


            using (TransactionScope scope = new TransactionScope(TransactionScopeOption.Required, new TransactionOptions { IsolationLevel = IsolationLevel.RepeatableRead }))
            {
                AdvertisingImageServer ais = _context.AdvertisingImageServer.First();
                ais.IsServing = true;
                this.Update<AdvertisingImageServer>("1", ais, RefreshMode.StoreWins);


                if (advertisingImageType == "SKYSCRAPER")
                {
                    advertisingImageTypeAsInt = 3;
                }
                if (advertisingImageType == "MPU")
                {
                    advertisingImageTypeAsInt = 1;
                }

                if (advertisingImageTypeAsInt != null)
                {
                    var images = (
                                 from ca in _context.AdvertisingImages
                                 where ca.AdvertisingImageType.AdvertisingImageTypeID == advertisingImageTypeAsInt
                                 && ca.AdvertisingImageStatus.StatusName.ToUpper() == "LIVE"
                                 && ca.Category.CategoryID == categoryID
                                 && ca.AdvertisingImageID > currentAdvertisingImageID
                                 select ca
                                 ).FirstOrDefault();
                    if (images == null)
                    {
                        images = (
                                 from ca in _context.AdvertisingImages
                                 where ca.AdvertisingImageType.AdvertisingImageTypeID == advertisingImageTypeAsInt
                                 && ca.AdvertisingImageStatus.StatusName.ToUpper() == "LIVE"
                                 && ca.Category.CategoryID == categoryID
                                 select ca
                                 ).First();
                    }

                    #region MPU
                    if (advertisingImageType == "MPU")
                    {
                        switch (categoryID)
                        {
                            case CATEGORY_ID_PHONE:
                            case CATEGORY_ID_COMMUNICATIONS:
                                ais.NextMPUVoiceID = images.AdvertisingImageID;
                                break;
                            case CATEGORY_ID_CRM:
                                ais.NextMPUCRMID = images.AdvertisingImageID;
                                break;
                            case CATEGORY_ID_WEB_CONFERENCING:
                                ais.NextMPUWebConferencingID = images.AdvertisingImageID;
                                break;
                            case CATEGORY_ID_EMAIL:
                                ais.NextMPUEMailID = images.AdvertisingImageID;
                                break;
                            case CATEGORY_ID_OFFICE:
                                ais.NextMPUOfficeID = images.AdvertisingImageID;
                                break;
                            case CATEGORY_ID_STORAGE_AND_BACKUP:
                                ais.NextMPUStorageAndBackupID = images.AdvertisingImageID;
                                break;
                            case CATEGORY_ID_PROJECT_MANAGEMENT:
                                ais.NextMPUProjectManagementID = images.AdvertisingImageID;
                                break;
                            case CATEGORY_ID_FINANCIAL:
                                ais.NextMPUFinancialID = images.AdvertisingImageID;
                                break;
                            case CATEGORY_ID_SECURITY:
                                ais.NextMPUSecurityID = images.AdvertisingImageID;
                                break;
                            case CATEGORY_ID_MARKETING:
                                ais.NextMPUMarketingID = images.AdvertisingImageID;
                                break;
                            case CATEGORY_ID_WEBSITE:
                                ais.NextMPUWebsiteID = images.AdvertisingImageID;
                                break;
                            case CATEGORY_ID_CREATIVE:
                                ais.NextMPUCreativeID = images.AdvertisingImageID;
                                break;
                            case CATEGORY_ID_BUSINESS_INTELLIGENCE_REPORTING:
                                ais.NextMPUBusinessIntelligenceReportingID = images.AdvertisingImageID;
                                break;
                            case CATEGORY_ID_HOSTING:
                                ais.NextMPUHostingID = images.AdvertisingImageID;
                                break;
                            case CATEGORY_ID_HR:
                                ais.NextMPUHRID = images.AdvertisingImageID;
                                break;
                            case CATEGORY_ID_PAYMENTS:
                                ais.NextMPUPaymentsID = images.AdvertisingImageID;
                                break;
                            case CATEGORY_ID_BUSINESS_AND_OPERATIONS:
                                ais.NextMPUBusinessAndOperationsID = images.AdvertisingImageID;
                                break;
                            case CATEGORY_ID_SALES:
                                ais.NextMPUSalesID = images.AdvertisingImageID;
                                break;
                        }
                    }
                    #endregion

                    #region SKYSCRAPER
                    if (advertisingImageType == "SKYSCRAPER")
                    {
                        switch (categoryID)
                        {
                            case CATEGORY_ID_PHONE:
                            case CATEGORY_ID_COMMUNICATIONS:
                                ais.NextSkyscraperVoiceID = images.AdvertisingImageID;
                                break;
                            case CATEGORY_ID_CRM:
                                ais.NextSkyscraperCRMID = images.AdvertisingImageID;
                                break;
                            case CATEGORY_ID_WEB_CONFERENCING:
                                ais.NextSkyscraperWebConferencingID = images.AdvertisingImageID;
                                break;
                            case CATEGORY_ID_EMAIL:
                                ais.NextSkyscraperEMailID = images.AdvertisingImageID;
                                break;
                            case CATEGORY_ID_OFFICE:
                                ais.NextSkyscraperOfficeID = images.AdvertisingImageID;
                                break;
                            case CATEGORY_ID_STORAGE_AND_BACKUP:
                                ais.NextSkyscraperStorageAndBackupID = images.AdvertisingImageID;
                                break;
                            case CATEGORY_ID_PROJECT_MANAGEMENT:
                                ais.NextSkyscraperProjectManagementID = images.AdvertisingImageID;
                                break;
                            case CATEGORY_ID_FINANCIAL:
                                ais.NextSkyscraperFinancialID = images.AdvertisingImageID;
                                break;
                            case CATEGORY_ID_SECURITY:
                                ais.NextSkyscraperSecurityID = images.AdvertisingImageID;
                                break;
                            case CATEGORY_ID_MARKETING:
                                ais.NextSkyscraperMarketingID = images.AdvertisingImageID;
                                break;
                            case CATEGORY_ID_WEBSITE:
                                ais.NextSkyscraperWebsiteID = images.AdvertisingImageID;
                                break;
                            case CATEGORY_ID_CREATIVE:
                                ais.NextSkyscraperCreativeID = images.AdvertisingImageID;
                                break;
                            case CATEGORY_ID_BUSINESS_INTELLIGENCE_REPORTING:
                                ais.NextSkyscraperBusinessIntelligenceReportingID = images.AdvertisingImageID;
                                break;
                            case CATEGORY_ID_HOSTING:
                                ais.NextSkyscraperHostingID = images.AdvertisingImageID;
                                break;
                            case CATEGORY_ID_HR:
                                ais.NextSkyscraperHRID = images.AdvertisingImageID;
                                break;
                            case CATEGORY_ID_PAYMENTS:
                                ais.NextSkyscraperPaymentsID = images.AdvertisingImageID;
                                break;
                            case CATEGORY_ID_BUSINESS_AND_OPERATIONS:
                                ais.NextSkyscraperBusinessAndOperationsID = images.AdvertisingImageID;
                                break;
                            case CATEGORY_ID_SALES:
                                ais.NextSkyscraperSalesID = images.AdvertisingImageID;
                                break;
                        }
                    }
                    #endregion

                    ais.IsServing = false;
                    this.Update<AdvertisingImageServer>("1", ais, RefreshMode.StoreWins);
                    scope.Complete();
                }


            }
        }
        #endregion

        #region GetTags
        public IList<Tag> GetTags(string searchText)
        {
            //return _context.FindById(cloudApplicationID);
            var retVal1 = _context.Tags.Where(x => x.TagName.ToUpper().StartsWith(searchText.ToUpper()));
            var retVal2 = (from t in _context.Tags where t.TagName.ToUpper().StartsWith(searchText.ToUpper()) select t);

            var retVal3 = (
                from ca in _context.CloudApplications
                join t in _context.Tags
                on ca.Category.CategoryID equals t.Category.CategoryID
                where t.TagName.ToUpper().StartsWith(searchText.ToUpper())
                select ca
                );

            return retVal2.OrderBy(x => x.TagType.TagTypeName).ToList();
        }
        #endregion

        #region GetApplicationsFromTags
        public IList<TagResult> GetApplicationsFromTags(string searchText, bool liveApplicationsOnly)
        {
            //return _context.FindById(cloudApplicationID);
            //var retVal1 = _context.Tags.Where(x => x.TagName.ToUpper().StartsWith(searchText.ToUpper()));
            //var retVal2 = (from t in _context.Tags where t.TagName.ToUpper().StartsWith(searchText.ToUpper()) select t);

            //var retVal3 = (
            //    from ca in _context.CloudApplications
            //    join t in _context.Tags
            //    on ca.Category.CategoryID equals t.Category.CategoryID
            //    where t.TagName.ToUpper().StartsWith(searchText.ToUpper())
            //    select ca
            //    );

            //var test = from t in _context.CloudApplications where t.ServiceName == null select t;

            Logger.Debug("Getting tagResults for " + searchText + " - " + DateTime.Now.TimeOfDay.ToString());
            List<TagResult> tagResults = null;

            if (liveApplicationsOnly)
            {
                tagResults = (
                from ca in _context.CloudApplications.AsNoTracking()
                    //.Include("Vendor").AsNoTracking()
                    //.Include("Category").AsNoTracking()
                    //.Include("Status").AsNoTracking()
                    //.Include("Tags").AsNoTracking()
                join t in _context.Tags.AsNoTracking()
                    //.Include(x => x.Category).AsNoTracking()
                    //.Include(x => x.TagType).AsNoTracking()
                on ca.Category.CategoryID equals t.Category.CategoryID
                where t.TagName.ToUpper().StartsWith(searchText.ToUpper())
                && ca.CloudApplicationStatus.StatusName.ToUpper() == "LIVE"
                //orderby t.TagType.TagTypeName
                select new TagResult()
                {
                    CloudApplication = ca,
                    Tag = t,
                    TagTypeWhenTagTypeIsNull = t.TagType.TagTypeName,
                    //TagTypeWhenTagTypeIsNull = ca.Category.CategoryName
                    VendorID = ca.Vendor.VendorID,
                    VendorName = ca.Vendor.VendorName,
                    ShopTagName = ca.CloudApplicationShopTag.TagName,
                    TagCategoryID = t.Category.CategoryID,
                    TagCategoryName = t.Category.CategoryName,
                    TagTypeID = t.TagType.TagTypeID,
                    CloudApplicationCategoryID = ca.Category.CategoryID,
                    CloudApplicationCategoryName = ca.Category.CategoryName,
                    CloudApplicationCategoryTagName = ca.CloudApplicationCategoryTag.TagName,
                    CloudApplicationShopTagName = ca.CloudApplicationShopTag.TagName,
                }
                ).OrderBy(x => x.TagTypeWhenTagTypeIsNull).ToList().Distinct(new TagResultComparer())

                .ToList()
                ;
            }
            else
            {
                tagResults = (
                from ca in _context.CloudApplications.AsNoTracking()
                    //.Include("Vendor")
                join t in _context.Tags.AsNoTracking()
                on ca.Category.CategoryID equals t.Category.CategoryID
                where t.TagName.ToUpper().StartsWith(searchText.ToUpper())
                //orderby t.TagType.TagTypeName
                select new TagResult()
                {
                    CloudApplication = ca,
                    Tag = t,
                    TagTypeWhenTagTypeIsNull = t.TagType.TagTypeName,
                    //TagTypeWhenTagTypeIsNull = ca.Category.CategoryName
                    VendorID = ca.Vendor.VendorID,
                    VendorName = ca.Vendor.VendorName,
                    ShopTagName = ca.CloudApplicationShopTag.TagName,
                    TagCategoryID = t.Category.CategoryID,
                    TagCategoryName = t.Category.CategoryName,
                    TagTypeID = t.TagType.TagTypeID,
                    CloudApplicationCategoryID = ca.Category.CategoryID,
                    CloudApplicationCategoryName = ca.Category.CategoryName,
                    CloudApplicationCategoryTagName = ca.CloudApplicationCategoryTag.TagName,
                    CloudApplicationShopTagName = ca.CloudApplicationShopTag.TagName,
                }
                ).OrderBy(x => x.TagTypeWhenTagTypeIsNull).ToList().Distinct(new TagResultComparer())

                .ToList()
                ;
            }


            Logger.Debug("Getting applications for " + searchText + " - " + DateTime.Now.TimeOfDay.ToString());
            List<TagResult> applications = null;
            if (liveApplicationsOnly)
            {
                applications = (
                from ca in _context.CloudApplications.AsNoTracking()
                    //.Include("Vendor").AsNoTracking()
                    //.Include("Category").AsNoTracking()
                    //.Include("Status").AsNoTracking()
                    //.Include("Tags").AsNoTracking()
                where ca.ServiceName.StartsWith(searchText.ToUpper())
                && ca.CloudApplicationStatus.StatusName.ToUpper() == "LIVE"

                join t in _context.Tags
                on ca.ServiceName equals "" into app1
                from app2 in app1.DefaultIfEmpty()
                select new TagResult()
                {
                    CloudApplication = ca,
                    Tag = app2,
                    TagTypeWhenTagTypeIsNull = "SERVICENAME",
                    VendorID = ca.Vendor.VendorID,
                    VendorName = ca.Vendor.VendorName,
                    ShopTagName = ca.CloudApplicationShopTag.TagName,
                    CloudApplicationCategoryID = ca.Category.CategoryID,
                    CloudApplicationCategoryName = ca.Category.CategoryName,
                    CloudApplicationCategoryTagName = ca.CloudApplicationCategoryTag.TagName,
                    CloudApplicationShopTagName = ca.CloudApplicationShopTag.TagName,
                }
                ).OrderBy(x => x.TagTypeWhenTagTypeIsNull).ToList().Distinct(new TagResultComparer())
                .ToList()
                ;

                
            }
            else
            {
                applications = (
                from ca in _context.CloudApplications.AsNoTracking()
                    //.Include("Vendor")
                where ca.ServiceName.StartsWith(searchText.ToUpper())
                join t in _context.Tags
                on ca.ServiceName equals "" into app1
                from app2 in app1.DefaultIfEmpty()
                select new TagResult()
                {
                    CloudApplication = ca,
                    Tag = app2,
                    TagTypeWhenTagTypeIsNull = "SERVICENAME",
                    VendorID = ca.Vendor.VendorID,
                    VendorName = ca.Vendor.VendorName,
                    ShopTagName = ca.CloudApplicationShopTag.TagName,
                    CloudApplicationCategoryID = ca.Category.CategoryID,
                    CloudApplicationCategoryName = ca.Category.CategoryName,
                    CloudApplicationCategoryTagName = ca.CloudApplicationCategoryTag.TagName,
                    CloudApplicationShopTagName = ca.CloudApplicationShopTag.TagName,
                }
                ).OrderBy(x => x.TagTypeWhenTagTypeIsNull).ToList().Distinct(new TagResultComparer())
                .ToList()
                ;

            }
            //var applicationsByCategory = (
            //    from ca in _context.CloudApplications
            //    where ca.Category.CategoryName.Trim().ToUpper().StartsWith(searchText.Trim().ToUpper())
            //    join t in _context.Tags
            //    on ca.ServiceName equals "" into app1
            //    from app2 in app1.DefaultIfEmpty()
            //    select new TagResult()
            //    {
            //        CloudApplication = ca,
            //        Tag = app2,
            //        TagTypeWhenTagTypeIsNull = "CATEGORYNAME",
            //    }
            //    ).OrderBy(x => x.TagTypeWhenTagTypeIsNull).ToList().Distinct(new TagResultComparer());

            Logger.Debug("Getting vendors for " + searchText + " - " + DateTime.Now.TimeOfDay.ToString());
            List<TagResult> vendors = null;
            if (liveApplicationsOnly)
            {
                vendors = (
                from ca in _context.CloudApplications.AsNoTracking()
                    //.Include("Vendor").AsNoTracking()
                    //.Include("Category").AsNoTracking()
                    //.Include("Status").AsNoTracking()
                    //.Include("Tags").AsNoTracking()
                where ca.Vendor.VendorName.StartsWith(searchText.ToUpper())
                && ca.CloudApplicationStatus.StatusName.ToUpper() == "LIVE"
                join t in _context.Tags
                on ca.Vendor.VendorName equals t.TagName into app1
                from app2 in app1.DefaultIfEmpty()
                select new TagResult()
                {
                    CloudApplication = ca,
                    Tag = app2,
                    TagTypeWhenTagTypeIsNull = "VENDOR",
                    VendorID = ca.Vendor.VendorID,
                    VendorName = ca.Vendor.VendorName,
                    ShopTagName = ca.CloudApplicationShopTag.TagName,
                    CloudApplicationCategoryID = ca.Category.CategoryID,
                    CloudApplicationCategoryName = ca.Category.CategoryName,
                    CloudApplicationCategoryTagName = ca.CloudApplicationCategoryTag.TagName,
                    CloudApplicationShopTagName = ca.CloudApplicationShopTag.TagName,
                }
                ).OrderBy(x => x.TagTypeWhenTagTypeIsNull).ToList().Distinct(new TagResultComparer())
                .ToList()
                ;
            }
            else
            {
                vendors = (
                from ca in _context.CloudApplications.AsNoTracking()
                    //.Include("Vendor")
                where ca.Vendor.VendorName.ToUpper().StartsWith(searchText.ToUpper())
                join t in _context.Tags
                on ca.Vendor.VendorName equals t.TagName into app1
                from app2 in app1.DefaultIfEmpty()
                select new TagResult()
                {
                    CloudApplication = ca,
                    Tag = app2,
                    TagTypeWhenTagTypeIsNull = "VENDOR",
                    VendorID = ca.Vendor.VendorID,
                    VendorName = ca.Vendor.VendorName,
                    ShopTagName = ca.CloudApplicationShopTag.TagName,
                    CloudApplicationCategoryID = ca.Category.CategoryID,
                    CloudApplicationCategoryName = ca.Category.CategoryName,
                    CloudApplicationCategoryTagName = ca.CloudApplicationCategoryTag.TagName,
                    CloudApplicationShopTagName = ca.CloudApplicationShopTag.TagName,
                }
                ).OrderBy(x => x.TagTypeWhenTagTypeIsNull).ToList().Distinct(new TagResultComparer())
                .ToList()
                ;

            }
            Logger.Debug("Constructing autocomplete results for " + searchText + " - " + DateTime.Now.TimeOfDay.ToString());

            IEnumerable<TagResult> retVal4 = null;

            if (applications != null)
            {
                tagResults.ToList().RemoveAll(x => applications.Any(y => y.CloudApplication.CloudApplicationID == x.CloudApplication.CloudApplicationID));
            }
            //tagResults.ToList().RemoveAll(x => applicationsByCategory.Any(y => y.CloudApplication.CloudApplicationID == x.CloudApplication.CloudApplicationID));

            if (vendors != null)
            {
                tagResults.ToList().RemoveAll(x => vendors.Any(y => y.CloudApplication.CloudApplicationID == x.CloudApplication.CloudApplicationID));
            }

            retVal4 = tagResults;
            if (applications != null)
            {
                retVal4 = tagResults.Union(applications);
            }
            if (vendors != null)
            {
                retVal4 = retVal4.Union(vendors);
            }

            //var retVal4 = tagResults.Union(applications);
            //var retVal4 = tagResults;
            var retVal5 = retVal4.OrderBy(x => x.TagTypeWhenTagTypeIsNull).ToList();
            //var retVal6 = retVal4.ToList();
            return retVal5;

            
        }

        #endregion

        #region GetSearchResultsFromTags
        public IEnumerable<CloudApplication> GetSearchResultsFromTags(string searchText, bool liveApplicationsOnly)
        {
            if (liveApplicationsOnly)
            {
                var tagResults = (
                    from ca in _context.CloudApplications
                    join t in _context.Tags
                    on ca.Category.CategoryID equals t.Category.CategoryID
                    where t.TagName.ToUpper().StartsWith(searchText.ToUpper())
                    && ca.CloudApplicationStatus.StatusName.ToUpper() == "LIVE"
                    //orderby t.TagType.TagTypeName
                    select ca
                    )
                    //.OrderBy(x => x.TagTypeWhenTagTypeIsNull)
                    ;

                var applications = (
                    from ca in _context.CloudApplications
                    where ca.ServiceName.StartsWith(searchText.ToUpper())
                    && ca.CloudApplicationStatus.StatusName.ToUpper() == "LIVE"
                    join t in _context.Tags
                    on ca.ServiceName equals t.TagName into app1
                    from app2 in app1.DefaultIfEmpty()
                    select ca
                    );

                var vendors = (
                    from ca in _context.CloudApplications
                    where ca.Vendor.VendorName.StartsWith(searchText.ToUpper())
                    && ca.CloudApplicationStatus.StatusName.ToUpper() == "LIVE"
                    join t in _context.Tags
                    on ca.Vendor.VendorName equals t.TagName into app1
                    from app2 in app1.DefaultIfEmpty()
                    select ca
                    );

                var retVal4 = tagResults.Union(applications).Union(vendors);
                //var retVal5 = retVal4.OrderBy(x => x.TagTypeWhenTagTypeIsNull).ToList();
                return retVal4;
            }
            else
            {
                var tagResults = (
                    from ca in _context.CloudApplications
                    join t in _context.Tags
                    on ca.Category.CategoryID equals t.Category.CategoryID
                    where t.TagName.ToUpper().StartsWith(searchText.ToUpper())
                    //orderby t.TagType.TagTypeName
                    select ca
                    )
                    //.OrderBy(x => x.TagTypeWhenTagTypeIsNull)
                    ;

                var applications = (
                    from ca in _context.CloudApplications
                    where ca.ServiceName.StartsWith(searchText.ToUpper())
                    join t in _context.Tags
                    on ca.ServiceName equals t.TagName into app1
                    from app2 in app1.DefaultIfEmpty()
                    select ca
                    );

                var vendors = (
                    from ca in _context.CloudApplications
                    where ca.Vendor.VendorName.StartsWith(searchText.ToUpper())
                    join t in _context.Tags
                    on ca.Vendor.VendorName equals t.TagName into app1
                    from app2 in app1.DefaultIfEmpty()
                    select ca
                    );

                var retVal4 = tagResults.Union(applications).Union(vendors);
                //var retVal5 = retVal4.OrderBy(x => x.TagTypeWhenTagTypeIsNull).ToList();
                return retVal4;

            }
        }

        #endregion

        #region GetContentData
        public IList<ContentText> GetContentData(int[] IDs)
        {
            //return _context.FindById(cloudApplicationID);
            var retVal1 = _context.ContentText.Where(x => IDs.Contains(x.ContentTextID));
            var retVal2 = (from t in _context.ContentText where IDs.Contains(t.ContentTextID) select t);

            return retVal2
                .OrderBy(x => x.BodyOrder)
                .Where(x => x.ContentTextStatus.StatusName.ToUpper() == "LIVE")
                .ToList();
        }

        public IList<ContentText> GetContentData(string keyTitle, string keyBody)
        {
            //return _context.FindById(cloudApplicationID);
            var title1 = _context.ContentText.Where(x => x.ContentTextType.ContentTextTypeName ==  keyTitle);
            var title2 = (from t in _context.ContentText where t.ContentTextType.ContentTextTypeName == keyTitle select t);

            var body1 = _context.ContentText.Where(x => x.ContentTextType.ContentTextTypeName ==  keyBody);
            var body2 = (from b in _context.ContentText where b.ContentTextType.ContentTextTypeName == keyBody select b);

            return (title2.Union(body2)).OrderBy(x => x.BodyOrder).ToList();
        }

        public IList<ContentText> GetContentData(string[] IDs)
        {
            //return _context.FindById(cloudApplicationID);
            var retVal1 = _context.ContentText.Where(x => IDs.Contains(x.ContentTextType.ContentTextTypeName));
            var retVal2 = (from t in _context.ContentText where IDs.Contains(t.ContentTextType.ContentTextTypeName) select t);

            return retVal2
                .Where(x => x.ContentTextStatus.StatusName.ToUpper() == "LIVE")
                .OrderBy(x => x.BodyOrder).ToList();
        }

        #endregion

        #region GetTermsOfUseData
        public IList<TermCondition> GetTermsOfUseData(string policyType)
        {
            //return _context.FindById(cloudApplicationID);
            //var retVal1 = _context.TermsConditions;
            var retVal2 = (from t in _context.TermsConditions where t.TermConditionType == policyType select t);

            return retVal2.OrderBy(x => x.DisplayID).ThenBy(x => x.ParentDisplayID).ThenBy(x => x.Indent).ToList();
        }
        #endregion

        #region GetPersonByEMail
        public Person GetPersonByEMail(string eMail)
        {
            //return _context.FindById(cloudApplicationID);
            var retVal1 = _context.Persons.Where(x => x.EMail == eMail);
            var retVal2 = (from ca in _context.Persons where ca.EMail == eMail select ca).FirstOrDefault();
            return retVal2;
        }
        #endregion

        #region GetPersonByPersonID
        public Person GetPersonByPersonID(int personID)
        {
            //return _context.FindById(cloudApplicationID);
            var retVal1 = _context.Persons.Where(x => x.PersonID == personID);
            var retVal2 = (from ca in _context.Persons where ca.PersonID == personID select ca).FirstOrDefault();
            return retVal2;
        }
        #endregion

        #region GetPersonTypeByPersonTypeID
        public PersonType GetPersonTypeByPersonTypeID(int personTypeID)
        {
            var retVal1 = _context.PersonTypes.Where(x => x.PersonTypeID == personTypeID);
            var retVal2 = (from ca in _context.PersonTypes where ca.PersonTypeID == personTypeID select ca).FirstOrDefault();
            return retVal2;
        }
        #endregion

        #region GetPersonTypeByPersonTypeName
        public PersonType GetPersonTypeByPersonTypeName(string personTypeName)
        {
            var retVal1 = _context.PersonTypes.Where(x => x.PersonTypeName.Trim().ToUpper() == personTypeName.Trim().ToUpper());
            var retVal2 = (from ca in _context.PersonTypes where ca.PersonTypeName.Trim().ToUpper() == personTypeName.Trim().ToUpper() select ca).FirstOrDefault();
            return retVal2;
        }
        #endregion

        #region GetPerson
        public Person GetPerson(string forename, string surname, string eMail, int numberOfUsers)
        {
            var retVal2 = (
                from ca 
                in _context.Persons
                where ca.Forename.ToUpper() == forename.ToUpper()
                && ca.Surname.ToUpper() == surname.ToUpper()
                && ca.EMail.ToUpper() == eMail.ToUpper()
                && ca.NumberOfEmployees == numberOfUsers
                select ca
                ).FirstOrDefault();
            return retVal2;

        }

        public Person GetPerson(string forename, string surname, string eMail, int numberOfUsers, string telephone, string company, string position)
        {
            var retVal2 = (
                from ca
                in _context.Persons
                where (forename == null ? ca.Forename == null : ca.Forename.ToUpper() == forename.ToUpper())
                && (surname == null ? ca.Surname == null : ca.Surname.ToUpper() == surname.ToUpper())
                && (eMail == null ? ca.EMail == null : ca.EMail.ToUpper() == eMail.ToUpper())
                && ca.NumberOfEmployees == numberOfUsers
                && (telephone == null ? ca.Telephone == null : ca.Telephone.ToUpper() == telephone.ToUpper())
                && (company == null ? ca.Company == null : ca.Company.ToUpper() == company.ToUpper())
                && (position == null ? ca.Position == null : ca.Position.ToUpper() == position.ToUpper())
                select ca
                ).FirstOrDefault();
            return retVal2;

        }

        public Person GetPerson(string forename, string surname, string eMail, string country, string telephone, string company, string position, bool isInUserGroup)
        {
            var retVal2 = (
                from ca
                in _context.Persons
                where ca.Forename.ToUpper() == forename.ToUpper()
                && ca.Surname.ToUpper() == surname.ToUpper()
                && ca.EMail.ToUpper() == eMail.ToUpper()
                && ca.PersonCountry == country
                && ca.Telephone.ToUpper() == telephone.ToUpper()
                && ca.Company.ToUpper() == company.ToUpper()
                && ca.Position.ToUpper() == position.ToUpper()
                && ca.IsInUserGroup == isInUserGroup
                select ca
                ).FirstOrDefault();
            return retVal2;

        }

        public Person GetPerson(string eMail, bool isInUserGroup)
        {
            var retVal2 = (
                from ca
                in _context.Persons
                where ca.EMail.ToUpper() == eMail.ToUpper()
                && ca.IsInUserGroup == isInUserGroup
                select ca
                ).FirstOrDefault();
            return retVal2;

        }

        #endregion

        #region GetCloudApplicationRequest
        public CloudApplicationRequest GetCloudApplicationRequest(int cloudApplicationRequestID)
        {
            //var retVal1 = _context.CloudApplicationRequests.Where(x => x.CloudApplicationRequestID == cloudApplicationRequestID);
            var retVal2 = (from ca in _context.CloudApplicationRequests where ca.CloudApplicationRequestID == cloudApplicationRequestID select ca).FirstOrDefault();
            return retVal2;

        }
        #endregion

        #region GetCloudApplicationRequestByPersonID
        public CloudApplicationRequest GetCloudApplicationRequestByPersonID(int personID)
        {
            var retVal1 = _context.CloudApplicationRequests.Where(x => x.PersonID == personID);
            var retVal2 = (from ca in _context.CloudApplicationRequests where ca.PersonID == personID select ca).FirstOrDefault();
            return retVal2;

        }
        #endregion

        #region GetIndustry
        public Industry GetIndustry(int industryID)
        {
            //return _context.FindById(cloudApplicationID);
            var terVal1 = _context.Industries.Where(x => x.IndustryID == industryID);
            var retVal2 = (from ca in _context.Industries where ca.IndustryID == industryID select ca).FirstOrDefault();
            if (retVal2 == null)
            {
                throw new Exception("Cannot find industry");
            }
            return retVal2;
        }
        #endregion

        #region LogSiteActivity
        public bool LogSiteActivity(System.Web.HttpRequestBase request)
        {
            SiteActivity sa = new SiteActivity();
            sa.BrowserID = request.Browser.Id;
            sa.BrowserName = request.Browser.Browser;
            sa.InterfaceID = 1;
            sa.RequestDate = DateTime.Now;
            sa.RequestedURL = request.Url.AbsoluteUri;
            sa.UserAgent = request.UserAgent;
            if (request.UserLanguages != null)
            {
                sa.UserLanguage = request.UserLanguages.FirstOrDefault();
            }
            else
            {
                
            }
            sa.UserHostAddress = request.UserHostAddress;
            //_context.SiteActivity.Add(sa);
            //_context.SaveChanges();
            return Insert<SiteActivity>(sa);
        }
        #endregion


        #region InsertUSerReview
        public bool InsertUserReview(CloudApplicationUserReview rating)
        {
            _context.CloudApplicationUserReviews.Add(rating);
            var result = _context.SaveChanges();
            return result > 0;
            
            //return Insert<CloudApplicationRating>(rating);
        }
        #endregion

        #region GetRequestTypes
        public IList<RequestType> GetRequestTypes()
        {
            //Logger.Debug("GetRequestTypes()");
            IList<RequestType> list = null;
            try
            {
                list = (from x in _context.RequestTypes
                        select x)
                        .OrderBy(x => x.RequestTypeName)
                    .ToList();

            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message, ex);
            }
            return list;
        }
        #endregion

        #region GetRequestTypeByRequestTypeName
        public RequestType GetRequestTypeByRequestTypeName(string requestTypeName)
        {
            var retVal1 = _context.RequestTypes.Where(x => x.RequestTypeName.Trim().ToUpper() == requestTypeName.Trim().ToUpper());
            var retVal2 = (from ca in _context.RequestTypes where ca.RequestTypeName.Trim().ToUpper() == requestTypeName.Trim().ToUpper() select ca).FirstOrDefault();
            return retVal2;
        }
        #endregion

        #region AddRequestType
        public bool AddRequestType(RequestType rt)
        {
            _context.RequestTypes.Add(rt);
            return true;
        }
        #endregion

        #region AddStatus
        public bool AddStatus(Status s)
        {
            _context.Statuses.Add(s);
            return true;
        }
        #endregion

        #region AddPerson
        public bool AddPerson(Person p)
        {
            _context.Persons.Add(p);
            _context.SaveChanges();
            return true;
        }
        #endregion

        #region GetIndustries
        public IList<Industry> GetIndustries()
        {
            //Logger.Debug("GetIndustries()");
            IList<Industry> list = null;
            try
            {
                list = (from x in _context.Industries
                        select x)
                        .OrderBy(x => x.Description)
                    .ToList();

            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message, ex);
            }
            return list;
        }
        #endregion

        #region GetUnservicedCloudApplicationRequests
        public IList<CloudApplicationRequest> GetUnservicedCloudApplicationRequests()
        {
            //Logger.Debug("GetUnservicedCloudApplicationRequests()");
            IList<CloudApplicationRequest> list = null;
            try
            {

                using (TransactionScope scope = new TransactionScope(TransactionScopeOption.Required, new TransactionOptions { IsolationLevel = IsolationLevel.RepeatableRead }))
                {
                    list = (from x in _context.CloudApplicationRequests
                            where x.Serviced == null
                            && x.EMail == true
                            && (x.Servicing == null || x.Servicing == false)
                            select x)
                            .OrderBy(x => x.CloudApplicationRequestID)
                        .ToList();

                    foreach (CloudApplicationRequest car in list)
                    {
                        MarkCloudApplicationRequestAsServicing(car.CloudApplicationRequestID);
                    }
                    scope.Complete();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error fetching repository unserviced requests : " + ex.Message, ex);
                //Logger.Error(ex.Message, ex);
            }
            return list;

        }
        #endregion

        #region GetUnservicedCloudApplicationPDFRequests
        public IList<CloudApplicationRequest> GetUnservicedCloudApplicationPDFRequests()
        {
            //Logger.Debug("GetUnservicedCloudApplicationRequests()");
            IList<CloudApplicationRequest> list = null;
            try
            {

                using (TransactionScope scope = new TransactionScope(TransactionScopeOption.Required, new TransactionOptions { IsolationLevel = IsolationLevel.RepeatableRead }))
                {
                    list = (from x in _context.CloudApplicationRequests
                            where x.Serviced == null
                            //&& x.EMail == true
                            && x.RequestTypeID == 3
                            && (x.Servicing == null || x.Servicing == false)
                            select x)
                            .OrderBy(x => x.CloudApplicationRequestID)
                        .ToList();

                    foreach (CloudApplicationRequest car in list)
                    {
                        MarkCloudApplicationRequestAsServicing(car.CloudApplicationRequestID);
                    }
                    scope.Complete();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error fetching repository unserviced requests : " + ex.Message, ex);
                //Logger.Error(ex.Message, ex);
            }
            return list;

        }
        #endregion

        #region GetUnservicedCloudApplicationTryBuyRequests
        public IList<CloudApplicationRequest> GetUnservicedCloudApplicationTryBuyRequests()
        {
            //Logger.Debug("GetUnservicedCloudApplicationRequests()");
            IList<CloudApplicationRequest> list = null;
            try
            {

                using (TransactionScope scope = new TransactionScope(TransactionScopeOption.Required, new TransactionOptions { IsolationLevel = IsolationLevel.RepeatableRead }))
                {
                    list = (from x in _context.CloudApplicationRequests
                            where x.Serviced == null
                                //&& x.EMail == true
                            && (x.RequestTypeID == 1 || x.RequestTypeID == 2)
                            && (x.Servicing == null || x.Servicing == false)
                            select x)
                            .OrderBy(x => x.CloudApplicationRequestID)
                        .ToList();

                    foreach (CloudApplicationRequest car in list)
                    {
                        MarkCloudApplicationRequestAsServicing(car.CloudApplicationRequestID);
                    }
                    scope.Complete();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error fetching repository unserviced TRY/BUY requests : " + ex.Message, ex);
                //Logger.Error(ex.Message, ex);
            }
            return list;

        }
        #endregion

        #region GetUnservicedBusinessPartnerRequests
        public IList<CloudApplicationRequest> GetUnservicedBusinessPartnerRequests()
        {
            //Logger.Debug("GetUnservicedCloudApplicationRequests()");
            IList<CloudApplicationRequest> list = null;
            try
            {

                using (TransactionScope scope = new TransactionScope(TransactionScopeOption.Required, new TransactionOptions { IsolationLevel = IsolationLevel.RepeatableRead }))
                {
                    list = (from x in _context.CloudApplicationRequests
                            where x.Serviced == null
                                //&& x.EMail == true
                            && (x.RequestTypeID == 4)
                            && (x.Servicing == null || x.Servicing == false)
                            select x)
                            .OrderBy(x => x.CloudApplicationRequestID)
                        .ToList();

                    foreach (CloudApplicationRequest car in list)
                    {
                        MarkCloudApplicationRequestAsServicing(car.CloudApplicationRequestID);
                    }
                    scope.Complete();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error fetching repository unserviced BUSINESS PARTNER requests : " + ex.Message, ex);
                //Logger.Error(ex.Message, ex);
            }
            return list;

        }
        #endregion

        #region GetUnservicedStrategicPartnerRequests
        public IList<CloudApplicationRequest> GetUnservicedStrategicPartnerRequests()
        {
            //Logger.Debug("GetUnservicedCloudApplicationRequests()");
            IList<CloudApplicationRequest> list = null;
            try
            {

                using (TransactionScope scope = new TransactionScope(TransactionScopeOption.Required, new TransactionOptions { IsolationLevel = IsolationLevel.RepeatableRead }))
                {
                    list = (from x in _context.CloudApplicationRequests
                            where x.Serviced == null
                                //&& x.EMail == true
                            && (x.RequestTypeID == 5)
                            && (x.Servicing == null || x.Servicing == false)
                            select x)
                            .OrderBy(x => x.CloudApplicationRequestID)
                        .ToList();

                    foreach (CloudApplicationRequest car in list)
                    {
                        MarkCloudApplicationRequestAsServicing(car.CloudApplicationRequestID);
                    }
                    scope.Complete();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error fetching repository unserviced BUSINESS PARTNER requests : " + ex.Message, ex);
                //Logger.Error(ex.Message, ex);
            }
            return list;

        }
        #endregion

        #region GetUnservicedReferRewardRequests
        public IList<CloudApplicationRequest> GetUnservicedReferRewardRequests()
        {
            //Logger.Debug("GetUnservicedCloudApplicationRequests()");
            IList<CloudApplicationRequest> list = null;
            try
            {

                using (TransactionScope scope = new TransactionScope(TransactionScopeOption.Required, new TransactionOptions { IsolationLevel = IsolationLevel.RepeatableRead }))
                {
                    list = (from x in _context.CloudApplicationRequests
                            where x.Serviced == null
                                //&& x.EMail == true
                            && (x.RequestTypeID == 6)
                            && (x.Servicing == null || x.Servicing == false)
                            select x)
                            .OrderBy(x => x.CloudApplicationRequestID)
                        .ToList();

                    foreach (CloudApplicationRequest car in list)
                    {
                        MarkCloudApplicationRequestAsServicing(car.CloudApplicationRequestID);
                    }
                    scope.Complete();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error fetching repository unserviced BUSINESS PARTNER requests : " + ex.Message, ex);
                //Logger.Error(ex.Message, ex);
            }
            return list;

        }
        #endregion

        #region GetUnservicedMailColleagueRequests
        public IList<CloudApplicationRequest> GetUnservicedSendToColleagueRequests()
        {
            //Logger.Debug("GetUnservicedCloudApplicationRequests()");
            IList<CloudApplicationRequest> list = null;
            try
            {

                using (TransactionScope scope = new TransactionScope(TransactionScopeOption.Required, new TransactionOptions { IsolationLevel = IsolationLevel.RepeatableRead }))
                {
                    list = (from x in _context.CloudApplicationRequests
                            where x.Serviced == null
                                //&& x.EMail == true
                            && (x.RequestTypeID == 7)
                            && (x.Servicing == null || x.Servicing == false)
                            select x)
                            .OrderBy(x => x.CloudApplicationRequestID)
                        .ToList();

                    foreach (CloudApplicationRequest car in list)
                    {
                        MarkCloudApplicationRequestAsServicing(car.CloudApplicationRequestID);
                    }
                    scope.Complete();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error fetching repository unserviced BUSINESS PARTNER requests : " + ex.Message, ex);
                //Logger.Error(ex.Message, ex);
            }
            return list;

        }
        #endregion

        #region MarkCloudApplicationRequestAsServicing
        public bool MarkCloudApplicationRequestAsServicing(int cloudApplicationRequestID)
        {
            CloudApplicationRequest car = null;
            bool retVal = false;
            try
            {
                //using (System.Transactions.TransactionScope scope = new System.Transactions.TransactionScope())
                using (var db = new CompareCloudwareContext())
                {
                    //car = (from x in _context.CloudApplicationRequests
                    //       where x.Serviced == null
                    //       && x.CloudApplicationRequestID == cloudApplicationRequestID
                    //       select x)
                    //    .FirstOrDefault();
                    car = (from x in db.CloudApplicationRequests
                           where x.Serviced == null
                           && x.CloudApplicationRequestID == cloudApplicationRequestID
                           select x)
                        .FirstOrDefault();
                    if (car != null)
                    {
                        car.Servicing = true;
                        //_context.SaveChanges();
                        db.SaveChanges();
                        //scope.Complete();
                        //scope.Dispose();
                    }
                    retVal = true;
                }
            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message, ex);
            }
            return retVal;
        }
        #endregion

        #region MarkCloudApplicationRequestAsServiced
        public bool MarkCloudApplicationRequestAsServiced(int cloudApplicationRequestID)
        {
            CloudApplicationRequest car = null;
            bool retVal = false;
            try
            {
                //using (System.Transactions.TransactionScope scope = new System.Transactions.TransactionScope())
                using (var db = new CompareCloudwareContext())
                {
                    //car = (from x in _context.CloudApplicationRequests
                    //       where x.Serviced == null
                    //       && x.CloudApplicationRequestID == cloudApplicationRequestID
                    //       select x)
                    //    .FirstOrDefault();
                    car = (from x in db.CloudApplicationRequests
                           where x.Serviced == null
                           && x.CloudApplicationRequestID == cloudApplicationRequestID
                           select x)
                        .FirstOrDefault();
                    if (car != null)
                    {
                        car.Serviced = DateTime.Now;
                        car.Servicing = false;
                        //_context.SaveChanges();
                        db.SaveChanges();
                        //scope.Complete();
                        //scope.Dispose();
                    }
                    retVal = true;
                }
            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message, ex);
            }
            return retVal;
        }
        #endregion

        #region GetCategoryParameters
        public CategoryParameters GetCategoryParameters(int categoryID)
        {
            Logger.Debug("GetCategoryParameters()");
            CategoryParameters retVal = null;
            try
            {
                retVal = (from x in _context.CategoryParameters
                          where x.Category.CategoryID == categoryID
                          select x).FirstOrDefault();

            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message, ex);
            }
            return retVal;
        }
        #endregion

        #region GetCurrencyBySymbol
        public Currency GetCurrencyBySymbol(string symbolName)
        {
            //Logger.Debug("GetCurrencyBySymbol()");
            Currency retVal = null;
            try
            {
                retVal = (from x in _context.Currencies where x.CurrencySymbol == symbolName
                        select x)
                        .FirstOrDefault();
                if (retVal == null)
                {
                    throw new Exception("Cannot find currency " + symbolName);
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message,ex);
                //Logger.Error(ex.Message, ex);
            }
            return retVal;
        }
        #endregion

        #region GetCurrencyByShortName
        public Currency GetCurrencyByShortName(string shortName)
        {
            //Logger.Debug("GetCurrencyBySymbol()");
            Currency retVal = null;
            try
            {
                retVal = (from x in _context.Currencies
                          where x.CurrencyShortName == shortName
                          select x)
                        .FirstOrDefault();
                if (retVal == null)
                {
                    throw new Exception("Cannot find currency " + shortName);
                }

            }
            catch (Exception ex)
            {
                //Logger.Error(ex.Message, ex);
            }
            return retVal;
        }
        #endregion

        #region FindCurrencyByID
        public Currency FindCurrencyByID(int currencyID)
        {
            //Logger.Debug("GetCurrencyBySymbol()");
            Currency retVal = null;
            try
            {
                retVal = (from x in _context.Currencies
                          where x.CurrencyID == currencyID
                          select x)
                        .FirstOrDefault();
                if (retVal == null)
                {
                    throw new Exception("Cannot find currency " + currencyID.ToString());
                }

            }
            catch (Exception ex)
            {
                //Logger.Error(ex.Message, ex);
            }
            return retVal;
        }
        #endregion

        public void ClearCache()
        {
            Cache.Invalidate("vehicles");
        }



        #region GetDevices
        public IList<Device> GetDevices()
        {
            Logger.Debug("GetDevices()");
            IList<Device> list = null;
            try
            {
                list = (from x in _context.Devices where x.DeviceStatus.StatusName.ToUpper() == "LIVE" 
                        select x)
                        .OrderBy(x => x.DeviceID)
                    .ToList();

            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message, ex);
            }
            return list;
        }

        public IList<Device> GetDevices(int categoryID)
        {
            Logger.Debug("GetDevices()");
            IList<Device> list = null;
            try
            {
                var list2 =
                (
                        from os in _context.Devices
                        where os.CloudApplications.Any(x => x.Category.CategoryID == categoryID)
                        && os.DeviceStatus.StatusName.ToUpper() == "LIVE"
                        group os by os.DeviceID into y
                        select new
                        {
                            DeviceID = y.Key,
                            DeviceName = y.FirstOrDefault().DeviceName,
                        }
                )

                .AsEnumerable()
                .Select(x => new Device
                {
                    DeviceID = x.DeviceID,
                    DeviceName = x.DeviceName,
                }
                ).ToList()
                .OrderBy(z => z.DeviceName).ToList()
                ;

                list = list2;
            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message, ex);
            }
            return list;
        }

        #endregion

        #region GetMobilePlatforms
        public IList<MobilePlatform> GetMobilePlatforms()
        {
            Logger.Debug("GetMobilePlatforms()");
            IList<MobilePlatform> list = null;
            try
            {
                list = (from x in _context.MobilePlatforms
                        select x)
                        .OrderBy(x => x.MobilePlatformID)
                    .ToList();

            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message, ex);
            }
            return list;
        }
        #endregion

        #region GetFeatures
        public IList<Feature> GetFeatures(int categoryID)
        {
            Logger.Debug("GetFeatures()");
            IList<Feature> list = null;
            try
            {
                list = (
                    from x
                    in _context.Features
                                        //where x.Category.CategoryID == categoryID
                                        where x.Categories.Any(y => y.CategoryID == categoryID)
                                        && x.FeatureType.FeatureTypeName.ToUpper() == "FEATURE"
                                        && x.FeatureStatus.StatusName.ToUpper() == "LIVE"
                    select x).ToList();
            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message, ex);
            }
            return list;
        }
        #endregion

        #region GetApplications
        public IList<Feature> GetApplications(int categoryID)
        {
            Logger.Debug("GetApplications(" + categoryID.ToString() + ")");
            IList<Feature> list = null;
            try
            {
                list = (
                    from x
                    in _context.Features
                    //where x.Category.CategoryID == categoryID
                    where x.Categories.Any(y => y.CategoryID == categoryID)
                    && x.FeatureType.FeatureTypeName.ToUpper() == "APPLICATIONFEATURE"
                    && x.FeatureType.FeatureTypeStatus.StatusName.ToUpper() == "LIVE"
                    && !x.SuppressFilterBehaviour
                    select x).ToList();
            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message, ex);
            }
            return list;
        }
        #endregion

        #region GetLanguages
        public IList<Language> GetLanguages()
        {
            //Logger.Debug("GetLanguages()");
            IList<Language> list = null;
            try
            {
                list = (from x in _context.Languages where x.LanguageStatus.StatusName.ToUpper() == "LIVE"
                        select x)
                        .OrderBy(x => x.LanguageID)
                    .Where(l => l.LanguageStatus.StatusName.ToUpper() == "LIVE").ToList();

            }
            catch (Exception ex)
            {
                //Logger.Error(ex.Message, ex);
            }
            return list;
        }

        public IList<Language> GetLanguages(int categoryID)
        {
            Logger.Debug("GetLanguages()");
            IList<Language> list = null;
            try
            {
                var list2 =
                (
                        from sd in _context.Languages
                        where sd.CloudApplications.Any(x => x.Category.CategoryID == categoryID)
                        && sd.LanguageStatus.StatusName.ToUpper() == "LIVE"
                        group sd by sd.LanguageID into y
                        select new
                        {
                            LanguageID = y.Key,
                            LanguageName = y.FirstOrDefault().LanguageName,
                        }
                )

                .AsEnumerable()
                .Select(x => new Language
                {
                    LanguageID = x.LanguageID,
                    LanguageName = x.LanguageName,
                }
                ).ToList()
                .OrderBy(z => z.LanguageName).ToList()
                ;

                list = list2;
            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message, ex);
            }
            return list;
        }

        #endregion

        #region GetSupportTypes
        public IList<SupportType> GetSupportTypes()
        {
            Logger.Debug("GetSupportTypes()");
            IList<SupportType> list = null;
            try
            {
                list = (from x in _context.SupportTypes where x.SupportTypeStatus.StatusName.ToUpper() == "LIVE" 
                        select x)
                        .OrderBy(x => x.SupportTypeID)
                    .ToList();

            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message, ex);
            }
            return list;
        }

        public IList<SupportType> GetSupportTypes(int categoryID)
        {
            Logger.Debug("GetSupportTypes()");
            IList<SupportType> list = null;
            try
            {
                var list2 =
                (
                        from os in _context.SupportTypes
                        where os.CloudApplications.Any(x => x.Category.CategoryID == categoryID)
                        && os.SupportTypeStatus.StatusName.ToUpper() == "LIVE"
                        group os by os.SupportTypeID into y
                        select new
                        {
                            SupportTypeID = y.Key,
                            SupportTypeName = y.FirstOrDefault().SupportTypeName,
                        }
                )

                .AsEnumerable()
                .Select(x => new SupportType
                {
                    SupportTypeID = x.SupportTypeID,
                    SupportTypeName = x.SupportTypeName,
                }
                ).ToList()
                .OrderBy(z => z.SupportTypeName).ToList()
                ;

                list = list2;
            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message, ex);
            }
            return list;
        }
        
        #endregion

        #region GetSupportTerritories
        public IList<SupportTerritory> GetSupportTerritories()
        {
            Logger.Debug("GetSupportTerritories()");
            IList<SupportTerritory> list = null;
            try
            {
                list = (from x in _context.SupportTerritories where x.SupportTerritoryStatus.StatusName.ToUpper() == "LIVE"
                        select x)
                        .OrderBy(x => x.SupportTerritoryID)
                    .ToList();

            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message, ex);
            }
            return list;
        }
        #endregion

        #region GetPaymentOptions
        public IList<PaymentOption> GetPaymentOptions()
        {
            Logger.Debug("GetPaymentOptions()");
            IList<PaymentOption> list = null;
            try
            {
                list = (from x in _context.PaymentOptions where x.PaymentOptionStatus.StatusName.ToUpper() == "LIVE"
                        select x)
                        .OrderBy(x => x.PaymentOptionID)
                    .ToList();

            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message, ex);
            }
            return list;
        }
        #endregion

        #region GetFreeTrialPeriods
        public IList<FreeTrialPeriod> GetFreeTrialPeriods()
        {
            Logger.Debug("GetFreeTrialPeriods()");
            IList<FreeTrialPeriod> list = null;
            try
            {
                list = (from x in _context.FreeTrialPeriods where x.FreeTrialPeriodStatus.StatusName.ToUpper() == "LIVE"
                        select x)
                        .OrderBy(x => x.FreeTrialPeriodID)
                    .ToList();

            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message, ex);
            }
            return list;
        }
        #endregion

        #region GetMinimumContracts
        public IList<MinimumContract> GetMinimumContracts()
        {
            Logger.Debug("GetMinimumContracts()");
            IList<MinimumContract> list = null;
            try
            {
                list = (from x in _context.MinimumContracts where x.MinimumContractStatus.StatusName.ToUpper() == "LIVE"
                        select x)
                        .OrderBy(x => x.MinimumContractID)
                    .ToList();

            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message, ex);
            }
            return list;
        }
        #endregion

        #region GetPaymentFrequencies
        public IList<PaymentFrequency> GetPaymentFrequencies()
        {
            Logger.Debug("GetPaymentFrequencies()");
            IList<PaymentFrequency> list = null;
            try
            {
                list = (from x in _context.PaymentFrequencies where x.PaymentFrequencyStatus.StatusName.ToUpper() == "LIVE"
                        select x)
                        .OrderBy(x => x.PaymentFrequencyID)
                    .ToList();

            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message, ex);
            }
            return list;
        }
        #endregion

        #region GetCurrencies
        public IList<Currency> GetCurrencies()
        {
            Logger.Debug("GetCurrencies()");
            IList<Currency> list = null;
            try
            {
                list = (from x in _context.Currencies where x.CurrencyStatus.StatusName.ToUpper() == "LIVE"
                        select x)
                        .OrderBy(x => x.CurrencyShortName)
                    .ToList();

            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message, ex);
            }
            return list;
        }
        #endregion

        #region GetCloudApplicationFeatures
        public IList<CloudApplicationFeature> GetCloudApplicationFeatures(int cloudApplicationID)
        {
            Logger.Debug("GetCloudApplicationFeatures(" + cloudApplicationID.ToString() + ")");
            IList<CloudApplicationFeature> list = null;
            try
            {
                list = (
                    from x
                    in _context.CloudApplicationFeatures
                    //where x.Category.CategoryID == categoryID
                    where x.CloudApplication.CloudApplicationID == cloudApplicationID
                    && x.Feature.FeatureType.FeatureTypeName.ToUpper() == "FEATURE"
                    && x.Feature.FeatureStatus.StatusName.ToUpper() == "LIVE"
                    && x.CloudApplicationFeatureStatus.StatusName.ToUpper() == "LIVE"
                    select x).ToList();
            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message, ex);
            }
            return list;

        }
        #endregion

        #region GetCloudApplicationApplications
        public IList<CloudApplicationApplication> GetCloudApplicationApplications(int cloudApplicationID)
        {
            Logger.Debug("GetCloudApplicationApplications(" + cloudApplicationID.ToString() + ")");
            IList<CloudApplicationApplication> list = null;
            try
            {
                list = (
                    from x
                    in _context.CloudApplicationApplications
                    //where x.Category.CategoryID == categoryID
                    where x.CloudApplication.CloudApplicationID == cloudApplicationID
                    && x.Feature.FeatureType.FeatureTypeName.ToUpper() == "APPLICATIONFEATURE"
                    && x.Feature.FeatureStatus.StatusName.ToUpper() == "LIVE"
                    && x.CloudApplicationApplicationStatus.StatusName.ToUpper() == "LIVE"
                    select x).ToList();
            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message, ex);
            }
            return list;

        }
        #endregion

        #region FindStatusByName
        public Status FindStatusByName(string statusName)
        {
            //Category f1 = _context.Categories.Where(x => x.CategoryName.ToUpper().StartsWith(categoryName.ToUpper())).FirstOrDefault();
            Status f2 = (from cf in _context.Statuses
                           where cf.StatusName.ToUpper() == statusName.ToUpper()
                           select cf)
                           //.AsNoTracking()
                           .FirstOrDefault();

            if (f2 == null)
            {
                throw new Exception("Cannot find status");
            }
            return f2;
        }
        #endregion

        #region FindStatusByID
        public Status FindStatusByID(int statusID)
        {
            //Category f1 = _context.Categories.Where(x => x.CategoryName.ToUpper().StartsWith(categoryName.ToUpper())).FirstOrDefault();
            Status f2 = (from cf in _context.Statuses
                         where cf.StatusID == statusID
                         select cf).FirstOrDefault();

            if (f2 == null)
            {
                throw new Exception("Cannot find status");
            }
            return f2;
        }
        #endregion

        #region GetStatuses
        public IList<Status> GetStatuses()
        {
            Logger.Debug("GetStatuses()");
            IList<Status> list = null;
            try
            {
                list = (from x in _context.Statuses
                        select x)
                        .OrderBy(x => x.StatusName)
                    .ToList();

            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message, ex);
            }
            return list;
        }
        #endregion

        #region SetStatusAtVendorLevel
        public bool SetStatusAtVendorLevel(int vendorID, int statusID)
        {
            Logger.Debug("GetStatuses()");
            bool retVal = true;
            IList<CloudApplication> list = null;
            try
            {
                list = (from x in _context.CloudApplications
                        where x.Vendor.VendorID == vendorID
                        select x)
                    .ToList();

                foreach (CloudApplication ca in list)
                {
                    ca.CloudApplicationStatus = this.FindStatusByID(statusID);
                }
                //list.ForEach(z => z.CloudApplicationStatus = this.FindStatusByID(statusID));
                
            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message, ex);
                retVal = false;
            }



            return retVal;

        }
        #endregion

        #region FindSiteAnalyticsByDate
        //SITE ANALYTICS
        public List<SiteAnalytic> FindSiteAnalyticsByDate(DateTime actionDate)
        {
            throw new Exception("Not implemented");
        }
        #endregion

        #region AddSiteAnalytic
        public bool AddSiteAnalytic(SiteAnalytic s, int siteAnalyticTypeID)
        {
            try
            {
                //_context.SiteAnalytics.Add(s);
                //_context.SaveChanges();

                //new context
                using (var db = new CompareCloudwareContext())
                {
                    //s.SiteAnalyticType = db.SiteAnalyticTypes.Where(x => x.SiteAnalyticTypeID == siteAnalyticTypeID).AsNoTracking().FirstOrDefault();
                    s.SiteAnalyticType = db.SiteAnalyticTypes.Where(x => x.SiteAnalyticTypeID == siteAnalyticTypeID).FirstOrDefault();
                    //s.SiteAnalyticType = FindSiteAnalyticType(siteAnalyticTypeID);
                    db.Entry(s).State = EntityState.Added;
                    db.SaveChanges();
                    return true;
                }

                //different context
                //SiteAnalyticType sat = FindSiteAnalyticType(siteAnalyticTypeID);
                //_context.ObjectContext().Attach((System.Data.Objects.DataClasses.IEntityWithKey) sat);
                //System.Data.Objects.DataClasses.IEntityWithKey a = ((DbContext)(_context)).Entry(sat).Entity;
                //_context.ObjectContext().Attach((System.Data.Objects.DataClasses.IEntityWithKey)sat);
                //s.SiteAnalyticType = sat;
                //try
                //{
                //    //_context.ObjectContext().Detach(s);
                //}
                //catch { }
                //try
                //{
                //    //_context.ObjectContext().Detach(sat);
                //}
                //catch { }
                ////_context.SiteAnalyticTypes.Attach(sat);
                //return Insert<SiteAnalytic>(s);

                //THIS context
                //SiteAnalyticType sat = FindSiteAnalyticType(siteAnalyticTypeID);
                //s.SiteAnalyticType = sat;
                //((DbContext)(_context)).Entry(s).State = System.Data.EntityState.Added;
                //_context.SaveChanges();
                //return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        #endregion

        #region GetAllSiteAnalytics
        public List<SiteAnalyticOutput> GetAllSiteAnalytics()
        {
            return GetAllSiteAnalyticsBySession(null);
        }
        #endregion

        #region GetAllSiteAnalyticsBySession
        public List<SiteAnalyticOutput> GetAllSiteAnalyticsBySession(string session)
        {
            //List<SiteAnalytic> s = _context.SiteAnalytics.AsNoTracking().ToList();
            //return s;


            IEnumerable<SiteAnalyticOutput> list =
            (
                from sa in _context.SiteAnalytics
                join ca in _context.CloudApplications
                on sa.CloudApplicationID equals ca.CloudApplicationID
                into outputanalytic1

                join p in _context.Persons
                on sa.PersonID equals p.PersonID
                into outputanalytic2

                from subanalytic1 in outputanalytic1.DefaultIfEmpty()
                from subanalytic2 in outputanalytic2.DefaultIfEmpty()
                select new SiteAnalyticOutput
                {
                    Brand = subanalytic1 == null ? String.Empty : subanalytic1.Brand,
                    Category = subanalytic1 == null ? String.Empty : subanalytic1.Category.CategoryName,
                    FeatureTypeID = sa.FeatureTypeID,
                    Person = subanalytic2 == null ? String.Empty : subanalytic2.EMail,
                    //ReferenceDataRowID = sa.ReferenceDataRowID,
                    SessionID = sa.SessionID,
                    SiteAnalyticDate = sa.SiteAnalyticDate,
                    SiteAnalyticID = sa.SiteAnalyticID,
                    SiteAnalyticType = sa.SiteAnalyticType.SiteAnalyticTypeName,
                }
            ).OrderByDescending(x => x.SiteAnalyticDate);

            if (session == null)
            {
                return list.ToList();
            }
            else
            {
                return list.Where(x => x.SessionID == session).OrderByDescending(x => x.SiteAnalyticDate).ToList();
            }
            
            
            throw new Exception("Not implemented");
        }
        #endregion

        #region FindSiteAnalyticType
        //SITE ANALYTIC TYPES
        public SiteAnalyticType FindSiteAnalyticType(int siteAnalyticType)
        {
            //SiteAnalyticType sat = _context.SiteAnalyticTypes.Where(x => x.SiteAnalyticTypeID == siteAnalyticType).AsNoTracking().FirstOrDefault();
            SiteAnalyticType sat = _context.SiteAnalyticTypes.Where(x => x.SiteAnalyticTypeID == siteAnalyticType).FirstOrDefault();
            if (sat == null)
            {
                throw new Exception("Cannot find site analytic with ID : " + siteAnalyticType.ToString());
            }

            //sat = (from x in _context.SiteAnalyticTypes
            //        where x.SiteAnalyticTypeID == siteAnalyticType
            //        select x)
            //.FirstOrDefault();

            return sat;
        }
        #endregion

        #region AddSiteAnalyticType
        public bool AddSiteAnalyticType(SiteAnalyticType s)
        {
            _context.SiteAnalyticTypes.Add(s);
            return true;
        }
        #endregion

        #region GetCurrentRankings
        public List<SiteAnalyticScoreChart> GetCurrentRankings()
        {
            DateTime startDate = DateTime.Now.AddDays(-30);
            DateTime endDate = DateTime.Now;

            var spParams = new object[] {new System.Data.SqlClient.SqlParameter("@StartDate", startDate),new System.Data.SqlClient.SqlParameter("@EndDate", endDate)};
            //var listOfType = _context.ObjectContext().ExecuteStoreQuery<SiteAnalyticScoreChart>("calculatescorechart @StartDate @EndDate",new{ startDate,endDate});
            var listOfType = _context.ObjectContext().ExecuteStoreQuery<SiteAnalyticScoreChart>("dbo.CalculateScoreChart @StartDate, @EndDate",spParams).ToList();
            //var listOfType = _context.ObjectContext().ExecuteStoreQuery<SiteAnalyticScoreChart>("calculatescorechart @StartDate, @EndDate", spParams);
            return listOfType.Where(x => x.StatusID == 1).ToList();
        }
        #endregion

        #region GetSupportCategories
        public IList<SupportCategory> GetSupportCategories()
        {
            Logger.Debug("GetSupportCategories()");
            IList<SupportCategory> list = null;
            try
            {
                list = (from x in _context.SupportCategories
                        where x.SupportCategoryStatus.StatusName.ToUpper() == "LIVE"
                        select x)
                        .OrderBy(x => x.SupportCategoryName)
                    .ToList();

            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message, ex);
            }
            return list;
        }
        #endregion

        #region GetQAStatus
        public QAStatus GetQAStatus(string statusName)
        {
            Logger.Debug("GetQAStatus()");
            QAStatus status = null;
            try
            {
                status = (from x in _context.QAStatuses
                          where x.QAStatusName.ToUpper() == statusName.ToUpper()
                          && x.QuestionStatus.StatusName.ToUpper() == "LIVE"
                        select x)
                    .FirstOrDefault();

            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message, ex);
            }
            return status;
        }
        #endregion

        #region GetSupportArea
        public SupportArea GetSupportArea(string supportAreaName)
        {
            Logger.Debug("GetSupportArea()");
            SupportArea supportArea = null;
            try
            {
                supportArea = (from x in _context.SupportAreas
                          where x.SupportAreaName.ToUpper() == supportAreaName.ToUpper()
                          && x.SupportAreaStatus.StatusName.ToUpper() == "LIVE"
                          select x)
                    .FirstOrDefault();

            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message, ex);
            }
            return supportArea;
        }
        #endregion


        #region GetSupportCategory
        public SupportCategory GetSupportCategory(int supportCategoryID)
        {
            Logger.Debug("GetSupportCategory()");
            SupportCategory supportCategory = null;
            try
            {
                supportCategory = (from x in _context.SupportCategories
                               where x.SupportCategoryID == supportCategoryID
                               && x.SupportCategoryStatus.StatusName.ToUpper() == "LIVE"
                               select x)
                    .FirstOrDefault();

            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message, ex);
            }
            return supportCategory;
        }
        #endregion

        #region AddSupportAreaQA
        public bool AddSupportAreaQA(SupportAreaQA supportAreaQA)
        {
            _context.SupportAreaQAs.Add(supportAreaQA);
            _context.SaveChanges();
            return true;
        }
        #endregion

        #region GetUnservicedSupportAreaQAs
        public IList<SupportAreaQA> GetUnservicedSupportAreaQAs()
        {
            //Logger.Debug("GetUnservicedCloudApplicationRequests()");
            IList<SupportAreaQA> list = null;
            try
            {

                using (TransactionScope scope = new TransactionScope(TransactionScopeOption.Required, new TransactionOptions { IsolationLevel = IsolationLevel.RepeatableRead }))
                {
                    list = (from x in _context.SupportAreaQAs
                            where (x.Serviced == null || x.Serviced == false)
                            //&& x.EMail == true
                            && (x.Servicing == null || x.Servicing == false)
                            select x)
                            .OrderBy(x => x.SupportAreaQAID)
                        .ToList();

                    foreach (SupportAreaQA saqa in list)
                    {
                        MarkSupportAreaQAAsServicing(saqa.SupportAreaQAID);
                    }
                    scope.Complete();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error fetching repository unserviced QA requests : " + ex.Message, ex);
                //Logger.Error(ex.Message, ex);
            }
            return list;

        }
        #endregion

        #region MarkSupportAreaQAAsServicing
        public bool MarkSupportAreaQAAsServicing(int supportAreaQAID)
        {
            SupportAreaQA saqa = null;
            bool retVal = false;
            try
            {
                //using (System.Transactions.TransactionScope scope = new System.Transactions.TransactionScope())
                using (var db = new CompareCloudwareContext())
                {
                    //car = (from x in _context.CloudApplicationRequests
                    //       where x.Serviced == null
                    //       && x.CloudApplicationRequestID == cloudApplicationRequestID
                    //       select x)
                    //    .FirstOrDefault();
                    saqa = (from x in db.SupportAreaQAs
                           where x.Serviced == null
                           && x.SupportAreaQAID == supportAreaQAID
                           select x)
                        .FirstOrDefault();
                    if (saqa != null)
                    {
                        saqa.Servicing = true;
                        //_context.SaveChanges();
                        db.SaveChanges();
                        //scope.Complete();
                        //scope.Dispose();
                    }
                    retVal = true;
                }
            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message, ex);
            }
            return retVal;
        }
        #endregion

        #region MarkSupportAreaQAAsServiced
        public bool MarkSupportAreaQAAsServiced(int supportAreaQAID)
        {
            SupportAreaQA saqa = null;
            bool retVal = false;
            try
            {
                //using (System.Transactions.TransactionScope scope = new System.Transactions.TransactionScope())
                using (var db = new CompareCloudwareContext())
                {
                    //car = (from x in _context.CloudApplicationRequests
                    //       where x.Serviced == null
                    //       && x.CloudApplicationRequestID == cloudApplicationRequestID
                    //       select x)
                    //    .FirstOrDefault();
                    saqa = (from x in db.SupportAreaQAs
                            where (x.Serviced == null || x.Serviced == false)
                           && x.SupportAreaQAID == supportAreaQAID
                           select x)
                        .FirstOrDefault();
                    if (saqa != null)
                    {
                        saqa.Serviced = true;
                        saqa.ServicedDate = DateTime.Now;
                        saqa.Servicing = false;
                        //_context.SaveChanges();
                        db.SaveChanges();
                        //scope.Complete();
                        //scope.Dispose();
                    }
                    retVal = true;
                }
            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message, ex);
            }
            return retVal;
        }
        #endregion

        #region GetSiteAnalyticsForVendor
        public List<SiteAnalyticsVendorSummary> GetSiteAnalyticsForVendor(int vendorID,DateTime startDate,DateTime endDate)
        {
            //DateTime startDate = DateTime.Now.AddDays(-30);
            //DateTime endDate = DateTime.Now;

            var spParams = new object[] 
            { 
                new System.Data.SqlClient.SqlParameter("@VendorID", vendorID), 
                new System.Data.SqlClient.SqlParameter("@StartDate", startDate), 
                new System.Data.SqlClient.SqlParameter("@EndDate", endDate) 
            };
            //var listOfType = _context.ObjectContext().ExecuteStoreQuery<SiteAnalyticScoreChart>("calculatescorechart @StartDate @EndDate",new{ startDate,endDate});
            var listOfType = _context.ObjectContext().ExecuteStoreQuery<SiteAnalyticsVendorSummary>("dbo.SiteAnalyticsByVendorAndDateRange @VendorID, @StartDate, @EndDate", spParams).ToList();
            //var listOfType = _context.ObjectContext().ExecuteStoreQuery<SiteAnalyticScoreChart>("calculatescorechart @StartDate, @EndDate", spParams);
            //return listOfType.Where(x => x.StatusID == 1).ToList();
            return listOfType.ToList();
        }
        #endregion

        #region GetAllVendors
        public IList<Vendor> GetAllVendors()
        {
            var retVal1 = _context.Vendors
                .Where(x => x.VendorStatus.StatusName.ToUpper() == "LIVE")
                .AsNoTracking()
                .OrderBy(x => x.VendorName)
                .ToList();
            return retVal1;
        }
        #endregion

        #region GetCloudApplicationRequests
        public IList<WEBAPICloudApplicationRequest> GetWEBAPICloudApplicationRequests(DateTime startDate, DateTime endDate)
        {
            var f2 = (from car in _context.CloudApplicationRequests
                    join ca in _context.CloudApplications
                    on car.CloudApplicationID equals ca.CloudApplicationID
                    join p in _context.Persons
                    on car.PersonID equals p.PersonID
                      join v in _context.Vendors
                      on ca.Vendor.VendorID equals v.VendorID

                      
                      select new WEBAPICloudApplicationRequest()
            {
                Brand = ca.Brand,
                CloudApplicationID = car.CloudApplicationID,
                CloudApplicationRequestID = car.CloudApplicationRequestID,
                Company = p.Company,
                EMail = p.EMail,
                Forename = p.Forename,
                NumberOfEmployees = p.NumberOfEmployees,
                PersonAddress1 = p.PersonAddress1,
                PersonAddress2 = p.PersonAddress2,
                PersonCountry = p.PersonCountry,
                PersonID = p.PersonID,
                PersonPostCode = p.PersonPostCode,
                PersonRegion = p.PersonRegion,
                Position = p.Position,
                RequestTypeID = car.RequestTypeID,
                Serviced = car.Serviced,
                ServiceName = ca.ServiceName,
                Servicing = car.Servicing,
                Surname = p.Surname,
                Telephone = p.Telephone,
                UserName = p.UserName,
                VendorName = v.VendorName,
                
            });

            return f2.ToList();
        }
        #endregion

        #region FindCategoryByURL
        public Category FindCategoryByURL(string url)
        {
            Tag t = _context.Tags.Where(x => x.TagName.ToUpper().StartsWith(url.ToUpper()) && x.TagType.TagTypeName == "CATEGORY URL" ).FirstOrDefault();
            Category c = t != null ? (from cf in _context.Categories
                           where cf.CategoryName.ToUpper().StartsWith(t.Category.CategoryName.ToUpper())
                           select cf).FirstOrDefault() : null;

            if (c == null)
            {
                throw new Exception("Cannot find category");
            }
            return c;
        }
        #endregion

        #region FindCategoryTag
        public Tag FindCategoryTag(int categoryID)
        {
            Tag t = _context.Tags.Where(x => x.TagType.TagTypeName.ToUpper() == TAG_CATEGORY_URL && x.Category.CategoryID == categoryID).FirstOrDefault();
            if (t == null)
            {
                throw new Exception("Cannot find category tag URL");
            }
            return t;
        }
        #endregion

        #region FindCategoryURL
        public string FindCategoryURL(int categoryID)
        {
            Tag t = _context.Tags.Where(x => x.TagType.TagTypeName.ToUpper() == TAG_CATEGORY_URL && x.Category.CategoryID == categoryID).FirstOrDefault();
            if (t == null)
            {
                throw new Exception("Cannot find category URL");
            }
            return t.TagName;
        }
        #endregion

        #region GetCategoryURLs
        public IList<Tag> GetCategoryURLs()
        {
            var groupedTags = from t in _context.Tags
                        where t.TagType.TagTypeName.ToUpper() == TAG_CATEGORY_URL
                        group t.TagID by t.Category
                            into tags
                            select new
                            { 
                                Category = tags.Key,
                                Tags = tags,
                            };
            
            var distinctTagsAsArray = groupedTags
                //.ToList()
                .Select(x => x.Tags.FirstOrDefault()).ToArray();

            var returnTags = _context.Tags.Where(x => distinctTagsAsArray.Contains(x.TagID)).ToList();
            return returnTags;
        }
        #endregion

        #region GetApplicationServiceNames
        public IList<CloudApplication> GetApplicationServiceNames()
        {
            //Logger.Debug("GetApplicationServiceNames(");
            IList<CloudApplication> list = null;
            try
            {
                list = (
                    from x
                    in _context.CloudApplications
                    select x)
                    //.AsNoTracking()
                    .ToList();
            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message, ex);
            }
            return list;
        }
        #endregion

        #region GetShopTags
        public IList<Tag> GetShopTags()
        {
            IList<Tag> list = null;
            try
            {
                list = (
                    from t
                    in _context.Tags
                    where t.TagType.TagTypeName.ToUpper() == "SHOP URL"
                    select t).AsNoTracking().ToList();
            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message, ex);
            }
            return list;
        }
        #endregion

        #region FindTagByName
        public Tag FindTagByName(string tagName)
        {
            Tag tag = null;
            try
            {
                tag = (
                    from t
                    in _context.Tags
                    where t.TagName.ToUpper() == tagName
                    select t)
                    .AsNoTracking()
                    .ToList()
                    .FirstOrDefault();
            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message, ex);
            }
            return tag;
        }
        #endregion

        #region FindShopByURL
        public int FindShopByURL(string url)
        {
            Tag t = _context.Tags.Where(x => x.TagName.ToUpper().StartsWith(url.ToUpper())).FirstOrDefault();
            CloudApplication c = t != null ? (from cf in _context.CloudApplications
                                      where cf.CloudApplicationShopTag.TagID == t.TagID
                                      select cf).FirstOrDefault() : null;

            if (c == null)
            {
                throw new Exception("Cannot find shop URL");
            }
            return c.CloudApplicationID;
        }
        #endregion

        #region GetShopURL
        public string GetShopURL(int cloudApplicationID)
        {
            CloudApplication ca = _context.CloudApplications.Where(x => x.CloudApplicationID == cloudApplicationID).FirstOrDefault();
            if (ca == null)
            {
                throw new Exception("Cannot find shop URL");
            }
            return ca.CloudApplicationCategoryTag.TagName + "/" + ca.CloudApplicationShopTag.TagName;
        }
        #endregion

        public IList<ContentPage> GetContentPages()
        {
            var contentPages = _context.ContentPages;
            return contentPages.ToList();
        }

        public IList<ContentPage> GetDisallowedContentPages()
        {
            var contentPages = _context.ContentPages.Where(x => x.NoSearch);
            return contentPages.ToList();
        }

        public IList<SiteMapNode> GetSiteMapNodes()
        {
            var siteMapNodes = _context.SiteMapNodes;
            return siteMapNodes.ToList();
        }

        #region AddContentPage
        public void AddContentPage(ContentPage cp)
        {
            _context.ContentPages.Add(cp);
        }
        #endregion

        #region GetContentPage
        public ContentPage GetContentPage(string route)
        {
            ContentPage cp = _context.ContentPages.Where(x => x.Route == route).FirstOrDefault();
            return cp;
        }
        #endregion

    }


}
