using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CompareCloudware.Domain.Models;
using System.IO;

namespace CompareCloudware.POCOQueryRepository.DataPump
{
    public static class AdvertisingImageData
    {
        public static bool PumpAdvertisingImageData(QueryRepository repository)
        {
            string MPU_FILEPATH = "C:\\Development\\CompareCloudwareVideo\\CompareCloudware.Web\\Images\\MPUs\\";
            string MPU_FILE1 = "emulex.jpg";
            string MPU_FILE2 = "evault.jpg";
            string MPU_FILE3 = "gotomeeting.jpg";
            string MPU_FILE4 = "ibm2.jpg";
            string MPU_FILE5 = "ibm.jpg";
            string MPU_FILE6 = "rackspace.jpg";
            string MPU_FILE7 = "raritan.jpg";
            string MPU_FILE8 = "sgi_nas.jpg";
            string MPU_FILE9 = "sharesoftware.jpg";
            string MPU_FILE10 = "starline.jpg";
            string MPU_FILE11 = "webex.jpg";

            string MPU_FILE12 = "MPU-1.gif";
            string MPU_FILE13 = "MPU-1a.gif";
            string MPU_FILE14 = "MPU-1b.gif";
            string MPU_FILE15 = "MPU-1c.gif";
            string MPU_FILE16 = "MPU-1d.gif";
            string MPU_FILE17 = "MPU-1e.gif";

            string MPU_FILE18 = "CCW-Web-Banners-MPU's-1.gif";
            string MPU_FILE19 = "CCW-Web-Banners-MPU's-2.gif";
            string MPU_FILE20 = "CCW-Web-Banners-MPU's-3.gif";
            string MPU_FILE21 = "CCW-Web-Banners-MPU's-4.gif";
            string MPU_FILE22 = "CCW-Web-Banners-MPU's-5.gif";





            string MPU_FILE23 = "Click Meeting 300x250.jpg"; //WEB CONF 394
            string MPU_FILE24 = "Sugar Sync 350x200.gif"; //STORAGE 342
            string MPU_FILE25 = "1&1_MPU_250x300.jpg"; //WEB CONF 427
            string MPU_FILE26 = "iDrive_MPU.jpg"; //STORAGE 368
            string MPU_FILE27 = "Bitdefender_MPU.jpg"; //SECURITY 437
            string MPU_FILE28 = "Freshbooks.jpg"; //FINANCIAL 111
            string MPU_FILE29 = "Kashflow_MPU.jpg"; //FINANCIAL 117
            string MPU_FILE30 = "Mavenlink_MPU.jpg"; //PROJECT MANAGEMENT 263
            string MPU_FILE31 = "Intermedia.jpg"; //EMAIL 93
            string MPU_FILE32 = "Blue_camroo 300x250.jpg"; //CRM 278
            string MPU_FILE33 = "Live Drive_MPU.jpg"; //STORAGE 371
            string MPU_FILE34 = "Carbonite.jpg"; //STORAGE 315
            string MPU_FILE35 = "Panda Security_MPU.jpg"; //SECURITY 438
            string MPU_FILE36 = "Sage One_MPU.jpg"; //FINANCIAL 100
            string MPU_FILE37 = "Pipe Line Deals Carbonite_MPU.jpg"; //CRM 50
            string MPU_FILE38 = "Project Manager_MPU.jpg"; //PROJECT 282
            string MPU_FILE39 = "Eclipse_MPU.jpg"; //EMAIL 86
            string MPU_FILE40 = "Sales Boom_MPU.jpg"; //CRM 54
            string MPU_FILE41 = "Copper Project_MPU.jpg"; //PROJECT 285
            string MPU_FILE42 = "1&1_MPU_V2.jpg"; //EMAIL 94
            string MPU_FILE43 = "FreeAgent_MPU_V2.jpg"; //FINANCIAL 120
            string MPU_FILE44 = "Webfusion.jpg"; //EMAIL 82
            string MPU_FILE45 = "Meeting Zone MPU_V3.jpg"; //WEB CONF 425
            string MPU_FILE46 = "LiquidPlanner_MPU_V2.jpg"; //PROJECT MANAGEMENT 274

            // 4/2/2014
            string MPU_FILE47 = "skype_MPU.png"; //VOICE 190
            string MPU_FILE48 = "freespeech_MPU.jpg"; //VOICE 234
            string MPU_FILE49 = "hyperoffice_MPU.png"; //OFFICE 147
            string MPU_FILE50 = "prezi_MPU.jpg"; //OFFICE 166
            string MPU_FILE51 = "evernote_MPU.jpg"; //OFFICE 159
            string MPU_FILE52 = "huddle_MPU.png"; //PROJECT MANAGEMENT ???
            string MPU_FILE53 = "sageone_MPU.gif"; //FINANCIAL 100
            string MPU_FILE54 = "gotomeeting_mpu.png"; //WEB CONF 386
            string MPU_FILE55 = "omnijoin_mpu.png"; //WEB CONF ???
            string MPU_FILE56 = "mcafee_MPU.jpg"; //SECURITY 444
            string MPU_FILE57 = "trendmicro.png"; //SECURITY 448
            string MPU_FILE58 = "salesforce_MPU.png"; //CRM 6

            // 25/4/2014
            string MPU_FILE59 = "generic_MPU.jpg"; //FINANCIAL 100

            // 13/5/2014
            string MPU_FILE60 = "Ring Central MPU.png"; //VOICE 221

            // 9/7/2014
            string MPU_FILE61 = "accountsextra_MPU.jpg"; //FINANCIAL 454

            // 9/7/2014
            string MPU_FILE62 = "mm_accountsextra_MPU.jpg"; //FINANCIAL 454

            int MPU_FILE23_CLOUDAPPLICATIONID = 394;
            int MPU_FILE24_CLOUDAPPLICATIONID = 342;
            int MPU_FILE25_CLOUDAPPLICATIONID = 427;
            int MPU_FILE26_CLOUDAPPLICATIONID = 368;
            int MPU_FILE27_CLOUDAPPLICATIONID = 437;
            int MPU_FILE28_CLOUDAPPLICATIONID = 111;
            int MPU_FILE29_CLOUDAPPLICATIONID = 117;
            int MPU_FILE30_CLOUDAPPLICATIONID = 263;
            int MPU_FILE31_CLOUDAPPLICATIONID = 93;
            int MPU_FILE32_CLOUDAPPLICATIONID = 278;
            int MPU_FILE33_CLOUDAPPLICATIONID = 371;
            int MPU_FILE34_CLOUDAPPLICATIONID = 315;
            int MPU_FILE35_CLOUDAPPLICATIONID = 438;
            int MPU_FILE36_CLOUDAPPLICATIONID = 100;
            int MPU_FILE37_CLOUDAPPLICATIONID = 50;
            int MPU_FILE38_CLOUDAPPLICATIONID = 282;
            int MPU_FILE39_CLOUDAPPLICATIONID = 86;
            int MPU_FILE40_CLOUDAPPLICATIONID = 54;
            int MPU_FILE41_CLOUDAPPLICATIONID = 285;
            int MPU_FILE42_CLOUDAPPLICATIONID = 94;
            int MPU_FILE43_CLOUDAPPLICATIONID = 120;
            int MPU_FILE44_CLOUDAPPLICATIONID = 82;
            int MPU_FILE45_CLOUDAPPLICATIONID = 425;
            int MPU_FILE46_CLOUDAPPLICATIONID = 274;

            // 4/2/2014
            int MPU_FILE47_CLOUDAPPLICATIONID = 190;
            int MPU_FILE48_CLOUDAPPLICATIONID = 234;
            int MPU_FILE49_CLOUDAPPLICATIONID = 147;
            int MPU_FILE50_CLOUDAPPLICATIONID = 166;
            int MPU_FILE51_CLOUDAPPLICATIONID = 159;
            int MPU_FILE52_CLOUDAPPLICATIONID = 0;
            int MPU_FILE53_CLOUDAPPLICATIONID = 100;
            int MPU_FILE54_CLOUDAPPLICATIONID = 386;
            int MPU_FILE55_CLOUDAPPLICATIONID = 401;
            int MPU_FILE56_CLOUDAPPLICATIONID = 444;
            int MPU_FILE57_CLOUDAPPLICATIONID = 448;
            int MPU_FILE58_CLOUDAPPLICATIONID = 6;

            // 24/4/2014
            int MPU_FILE59_CLOUDAPPLICATIONID = 100;

            // 13/5/2014
            int MPU_FILE60_CLOUDAPPLICATIONID = 221;

            // 9/7/2014
            int MPU_FILE61_CLOUDAPPLICATIONID = 454;

            // 30/11/2014
            int MPU_FILE62_CLOUDAPPLICATIONID = 454;

            string SKYSCRAPER_FILEPATH = "C:\\Development\\CompareCloudwareVideo\\CompareCloudware.Web\\Images\\Skyscrapers\\";
            string SKYSCRAPER_FILE1 = "bamboo.jpg";
            string SKYSCRAPER_FILE2 = "intel.jpg";
            string SKYSCRAPER_FILE3 = "neustar.jpg";
            string SKYSCRAPER_FILE4 = "symantec.jpg";

            string SKYSCRAPER_FILE5 = "CCW-Web-Banners-Sky's-1.gif";
            string SKYSCRAPER_FILE6 = "CCW-Web-Banners-Sky's-2.gif";
            string SKYSCRAPER_FILE7 = "CCW-Web-Banners-Sky's-3.gif";
            string SKYSCRAPER_FILE8 = "CCW-Web-Banners-Sky's-4.gif";

            string SKYSCRAPER_FILE9 = "Click Meeting 120x600.jpg"; //WEB CONF 394
            string SKYSCRAPER_FILE10 = "Sugar Sync 120x600.gif"; //STORAGE 342
            string SKYSCRAPER_FILE11 = "Intercall_Skyscraper.jpg"; //WEB CONF 427
            string SKYSCRAPER_FILE12 = "iDrive_Skyscraper.jpg"; //STORAGE 368
            string SKYSCRAPER_FILE13 = "Bitdefender_Skyscraper.jpg"; //SECURITY 437
            string SKYSCRAPER_FILE14 = "Freshbooks2.jpg"; //FINANCIAL 111
            string SKYSCRAPER_FILE15 = "Kashflow_Skyscraper.jpg"; //FINANCIAL 117
            string SKYSCRAPER_FILE16 = "Mavenlink_skyscraper.jpg"; //FINANCIAL 263
            string SKYSCRAPER_FILE17 = "LiquidPlanner_Skyscraper.jpg"; //FINANCIAL 274
            string SKYSCRAPER_FILE18 = "Intermedia2.jpg"; //EMAIL 93
            string SKYSCRAPER_FILE19 = "Blue_camroo 120x600.jpg"; //CRM 278
            string SKYSCRAPER_FILE20 = "Live Drive_Skyscraper.jpg"; //STORAGE 371
            string SKYSCRAPER_FILE21 = "Carbonite2.jpg"; //STORAGE 315
            string SKYSCRAPER_FILE22 = "Panda Security_Skyscraper.jpg"; //SECURITY 438
            string SKYSCRAPER_FILE23 = "Sage One_SkyScraper.jpg"; //FINANCIAL 100
            string SKYSCRAPER_FILE24 = "Pipe Line Deals Carbonite_Skyscraper.jpg"; //CRM 50
            string SKYSCRAPER_FILE25 = "Project Manager_Skyscraper.jpg"; //PROJECT 282
            string SKYSCRAPER_FILE26 = "Eclipse_Skyscraper.jpg"; //EMAIL 86
            string SKYSCRAPER_FILE27 = "Sales Boom_Skyscraper.jpg"; //CRM 54
            string SKYSCRAPER_FILE28 = "Copper Project_Skyscraper.jpg"; //PROJECT 285
            string SKYSCRAPER_FILE29 = "1&1_Skyscraper_V2.jpg"; //WEB CONF 95
            string SKYSCRAPER_FILE30 = "FreeAgent_Skyscraper_V2.jpg"; //FINANCIAL 120
            string SKYSCRAPER_FILE31 = "Webfusion2.jpg"; //EMAIL 82
            string SKYSCRAPER_FILE32 = "Meeting Zone Skyscaper_V3.jpg"; //WEB CONF 425

            // 4/2/2014
            string SKYSCRAPER_FILE33 = "skype_ss.png"; //VOICE 190
            string SKYSCRAPER_FILE34 = "freespeech_ss.jpg"; //VOICE 234
            string SKYSCRAPER_FILE35 = "hyperoffice_ss.png"; //OFFICE 147
            string SKYSCRAPER_FILE36 = "prezi_ss.jpg"; //OFFICE 166
            string SKYSCRAPER_FILE37 = "evernote_ss.jpg"; //OFFICE 159
            string SKYSCRAPER_FILE38 = "huddle_ss.png"; //PROJECT MANAGEMENT 
            string SKYSCRAPER_FILE39 = "sage one_ss.gif"; //FINANCIAL 100
            string SKYSCRAPER_FILE40 = "gotomeeting_ss.png"; //WEB CONF 386
            string SKYSCRAPER_FILE41 = "omnijoin_ss.png"; //WEB CONF 
            string SKYSCRAPER_FILE42 = "mcafee_ss.jpg"; //SECURITY 444
            string SKYSCRAPER_FILE43 = "trendmicro2.png"; //SECURITY 448
            string SKYSCRAPER_FILE44 = "salesforce_ss.png"; //CRM 6

            // 25/4/2014
            string SKYSCRAPER_FILE45 = "generic_skyscraper.jpg"; //FINANCIAL 100

            // 13/5/2014
            string SKYSCRAPER_FILE46 = "Ring Central Skyscraper.jpg"; //FINANCIAL 221

            //9/7/2014
            string SKYSCRAPER_FILE47 = "accountsextra_skyscraper.jpg"; //FINANCIAL 454

            //30/11/2014
            string SKYSCRAPER_FILE48 = "mm_accountsextra_skyscraper.jpg"; //FINANCIAL 454

            int SKYSCRAPER_FILE9_CLOUDAPPLICATIONID = 394;
            int SKYSCRAPER_FILE10_CLOUDAPPLICATIONID = 342;
            int SKYSCRAPER_FILE11_CLOUDAPPLICATIONID = 427;
            int SKYSCRAPER_FILE12_CLOUDAPPLICATIONID = 368;
            int SKYSCRAPER_FILE13_CLOUDAPPLICATIONID = 437;
            int SKYSCRAPER_FILE14_CLOUDAPPLICATIONID = 111;
            int SKYSCRAPER_FILE15_CLOUDAPPLICATIONID = 117;
            int SKYSCRAPER_FILE16_CLOUDAPPLICATIONID = 263;
            int SKYSCRAPER_FILE17_CLOUDAPPLICATIONID = 274;
            int SKYSCRAPER_FILE18_CLOUDAPPLICATIONID = 93;
            int SKYSCRAPER_FILE19_CLOUDAPPLICATIONID = 278;
            int SKYSCRAPER_FILE20_CLOUDAPPLICATIONID = 371;
            int SKYSCRAPER_FILE21_CLOUDAPPLICATIONID = 315;
            int SKYSCRAPER_FILE22_CLOUDAPPLICATIONID = 438;
            int SKYSCRAPER_FILE23_CLOUDAPPLICATIONID = 100;
            int SKYSCRAPER_FILE24_CLOUDAPPLICATIONID = 50;
            int SKYSCRAPER_FILE25_CLOUDAPPLICATIONID = 282;
            int SKYSCRAPER_FILE26_CLOUDAPPLICATIONID = 86;
            int SKYSCRAPER_FILE27_CLOUDAPPLICATIONID = 54;
            int SKYSCRAPER_FILE28_CLOUDAPPLICATIONID = 285;
            int SKYSCRAPER_FILE29_CLOUDAPPLICATIONID = 95;
            int SKYSCRAPER_FILE30_CLOUDAPPLICATIONID = 120;
            int SKYSCRAPER_FILE31_CLOUDAPPLICATIONID = 82;
            int SKYSCRAPER_FILE32_CLOUDAPPLICATIONID = 425;

            // 4/2/2014
            int SKYSCRAPER_FILE33_CLOUDAPPLICATIONID = 190;
            int SKYSCRAPER_FILE34_CLOUDAPPLICATIONID = 234;
            int SKYSCRAPER_FILE35_CLOUDAPPLICATIONID = 147;
            int SKYSCRAPER_FILE36_CLOUDAPPLICATIONID = 166;
            int SKYSCRAPER_FILE37_CLOUDAPPLICATIONID = 159;
            int SKYSCRAPER_FILE38_CLOUDAPPLICATIONID = 0;
            int SKYSCRAPER_FILE39_CLOUDAPPLICATIONID = 100;
            int SKYSCRAPER_FILE40_CLOUDAPPLICATIONID = 386;
            int SKYSCRAPER_FILE41_CLOUDAPPLICATIONID = 401;
            int SKYSCRAPER_FILE42_CLOUDAPPLICATIONID = 444;
            int SKYSCRAPER_FILE43_CLOUDAPPLICATIONID = 448;
            int SKYSCRAPER_FILE44_CLOUDAPPLICATIONID = 6;

            // 24/4/2014
            int SKYSCRAPER_FILE45_CLOUDAPPLICATIONID = 100;

            // 13/5/2014
            int SKYSCRAPER_FILE46_CLOUDAPPLICATIONID = 221;

            // 9/7/2014
            int SKYSCRAPER_FILE47_CLOUDAPPLICATIONID = 454;

            // 30/11/2014
            int SKYSCRAPER_FILE48_CLOUDAPPLICATIONID = 454;

            bool retVal = true;

            #region ADVERTISING IMAGES
            AdvertisingImage ai;
            ai = new AdvertisingImage()
            {
                AdvertisingImagePhysicalFilePath = MPU_FILEPATH,
                AdvertisingImageFileName = MPU_FILE1,
                AdvertisingImageBytes = GetImageAsBytes(MPU_FILEPATH + MPU_FILE1),
                AdvertisingImageType = repository.FindAdvertisingImageTypeByName("MPU"),
                AdvertisingImageStatus = repository.FindStatusByName("DELETED"),
                Category = repository.FindCategoryByID(1),
            };
            repository.AddAdvertisingImage(ai);
            ai = new AdvertisingImage()
            {
                AdvertisingImagePhysicalFilePath = MPU_FILEPATH,
                AdvertisingImageFileName = MPU_FILE2,
                AdvertisingImageBytes = GetImageAsBytes(MPU_FILEPATH + MPU_FILE2),
                AdvertisingImageType = repository.FindAdvertisingImageTypeByName("MPU"),
                AdvertisingImageStatus = repository.FindStatusByName("DELETED"),
                Category = repository.FindCategoryByID(1),
            };
            repository.AddAdvertisingImage(ai);
            ai = new AdvertisingImage()
            {
                AdvertisingImagePhysicalFilePath = MPU_FILEPATH,
                AdvertisingImageFileName = MPU_FILE3,
                AdvertisingImageBytes = GetImageAsBytes(MPU_FILEPATH + MPU_FILE3),
                AdvertisingImageType = repository.FindAdvertisingImageTypeByName("MPU"),
                AdvertisingImageStatus = repository.FindStatusByName("DELETED"),
                Category = repository.FindCategoryByID(1),
            };
            repository.AddAdvertisingImage(ai);
            ai = new AdvertisingImage()
            {
                AdvertisingImagePhysicalFilePath = MPU_FILEPATH,
                AdvertisingImageFileName = MPU_FILE4,
                AdvertisingImageBytes = GetImageAsBytes(MPU_FILEPATH + MPU_FILE4),
                AdvertisingImageType = repository.FindAdvertisingImageTypeByName("MPU"),
                AdvertisingImageStatus = repository.FindStatusByName("DELETED"),
                Category = repository.FindCategoryByID(1),
            };
            repository.AddAdvertisingImage(ai);
            ai = new AdvertisingImage()
            {
                AdvertisingImagePhysicalFilePath = MPU_FILEPATH,
                AdvertisingImageFileName = MPU_FILE5,
                AdvertisingImageBytes = GetImageAsBytes(MPU_FILEPATH + MPU_FILE5),
                AdvertisingImageType = repository.FindAdvertisingImageTypeByName("MPU"),
                AdvertisingImageStatus = repository.FindStatusByName("DELETED"),
                Category = repository.FindCategoryByID(1),
            };
            repository.AddAdvertisingImage(ai);
            ai = new AdvertisingImage()
            {
                AdvertisingImagePhysicalFilePath = MPU_FILEPATH,
                AdvertisingImageFileName = MPU_FILE6,
                AdvertisingImageBytes = GetImageAsBytes(MPU_FILEPATH + MPU_FILE6),
                AdvertisingImageType = repository.FindAdvertisingImageTypeByName("MPU"),
                AdvertisingImageStatus = repository.FindStatusByName("DELETED"),
                Category = repository.FindCategoryByID(1),
            };
            repository.AddAdvertisingImage(ai);
            ai = new AdvertisingImage()
            {
                AdvertisingImagePhysicalFilePath = MPU_FILEPATH,
                AdvertisingImageFileName = MPU_FILE7,
                AdvertisingImageBytes = GetImageAsBytes(MPU_FILEPATH + MPU_FILE7),
                AdvertisingImageType = repository.FindAdvertisingImageTypeByName("MPU"),
                AdvertisingImageStatus = repository.FindStatusByName("DELETED"),
                Category = repository.FindCategoryByID(1),
            };
            repository.AddAdvertisingImage(ai);
            ai = new AdvertisingImage()
            {
                AdvertisingImagePhysicalFilePath = MPU_FILEPATH,
                AdvertisingImageFileName = MPU_FILE8,
                AdvertisingImageBytes = GetImageAsBytes(MPU_FILEPATH + MPU_FILE8),
                AdvertisingImageType = repository.FindAdvertisingImageTypeByName("MPU"),
                AdvertisingImageStatus = repository.FindStatusByName("DELETED"),
                Category = repository.FindCategoryByID(1),
            };
            repository.AddAdvertisingImage(ai);
            ai = new AdvertisingImage()
            {
                AdvertisingImagePhysicalFilePath = MPU_FILEPATH,
                AdvertisingImageFileName = MPU_FILE9,
                AdvertisingImageBytes = GetImageAsBytes(MPU_FILEPATH + MPU_FILE9),
                AdvertisingImageType = repository.FindAdvertisingImageTypeByName("MPU"),
                AdvertisingImageStatus = repository.FindStatusByName("DELETED"),
                Category = repository.FindCategoryByID(1),
            };
            repository.AddAdvertisingImage(ai);
            ai = new AdvertisingImage()
            {
                AdvertisingImagePhysicalFilePath = MPU_FILEPATH,
                AdvertisingImageFileName = MPU_FILE10,
                AdvertisingImageBytes = GetImageAsBytes(MPU_FILEPATH + MPU_FILE10),
                AdvertisingImageType = repository.FindAdvertisingImageTypeByName("MPU"),
                AdvertisingImageStatus = repository.FindStatusByName("DELETED"),
                Category = repository.FindCategoryByID(1),
            };
            repository.AddAdvertisingImage(ai);
            ai = new AdvertisingImage()
            {
                AdvertisingImagePhysicalFilePath = MPU_FILEPATH,
                AdvertisingImageFileName = MPU_FILE11,
                AdvertisingImageBytes = GetImageAsBytes(MPU_FILEPATH + MPU_FILE11),
                AdvertisingImageType = repository.FindAdvertisingImageTypeByName("MPU"),
                AdvertisingImageStatus = repository.FindStatusByName("DELETED"),
                Category = repository.FindCategoryByID(1),
            };
            repository.AddAdvertisingImage(ai);

            ai = new AdvertisingImage()
            {
                AdvertisingImagePhysicalFilePath = MPU_FILEPATH,
                AdvertisingImageFileName = MPU_FILE12,
                AdvertisingImageBytes = GetImageAsBytes(MPU_FILEPATH + MPU_FILE12),
                AdvertisingImageType = repository.FindAdvertisingImageTypeByName("MPU"),
                AdvertisingImageStatus = repository.FindStatusByName("DELETED"),
                Category = repository.FindCategoryByID(5),
            };
            repository.AddAdvertisingImage(ai);
            ai = new AdvertisingImage()
            {
                AdvertisingImagePhysicalFilePath = MPU_FILEPATH,
                AdvertisingImageFileName = MPU_FILE13,
                AdvertisingImageBytes = GetImageAsBytes(MPU_FILEPATH + MPU_FILE13),
                AdvertisingImageType = repository.FindAdvertisingImageTypeByName("MPU"),
                AdvertisingImageStatus = repository.FindStatusByName("DELETED"),
                Category = repository.FindCategoryByID(5),
            };
            repository.AddAdvertisingImage(ai);
            ai = new AdvertisingImage()
            {
                AdvertisingImagePhysicalFilePath = MPU_FILEPATH,
                AdvertisingImageFileName = MPU_FILE14,
                AdvertisingImageBytes = GetImageAsBytes(MPU_FILEPATH + MPU_FILE14),
                AdvertisingImageType = repository.FindAdvertisingImageTypeByName("MPU"),
                AdvertisingImageStatus = repository.FindStatusByName("DELETED"),
                Category = repository.FindCategoryByID(5),
            };
            repository.AddAdvertisingImage(ai);
            ai = new AdvertisingImage()
            {
                AdvertisingImagePhysicalFilePath = MPU_FILEPATH,
                AdvertisingImageFileName = MPU_FILE15,
                AdvertisingImageBytes = GetImageAsBytes(MPU_FILEPATH + MPU_FILE15),
                AdvertisingImageType = repository.FindAdvertisingImageTypeByName("MPU"),
                AdvertisingImageStatus = repository.FindStatusByName("DELETED"),
                Category = repository.FindCategoryByID(5),
            };
            repository.AddAdvertisingImage(ai);
            ai = new AdvertisingImage()
            {
                AdvertisingImagePhysicalFilePath = MPU_FILEPATH,
                AdvertisingImageFileName = MPU_FILE16,
                AdvertisingImageBytes = GetImageAsBytes(MPU_FILEPATH + MPU_FILE16),
                AdvertisingImageType = repository.FindAdvertisingImageTypeByName("MPU"),
                AdvertisingImageStatus = repository.FindStatusByName("DELETED"),
                Category = repository.FindCategoryByID(5),
            };
            repository.AddAdvertisingImage(ai);
            ai = new AdvertisingImage()
            {
                AdvertisingImagePhysicalFilePath = MPU_FILEPATH,
                AdvertisingImageFileName = MPU_FILE17,
                AdvertisingImageBytes = GetImageAsBytes(MPU_FILEPATH + MPU_FILE17),
                AdvertisingImageType = repository.FindAdvertisingImageTypeByName("MPU"),
                AdvertisingImageStatus = repository.FindStatusByName("DELETED"),
                Category = repository.FindCategoryByID(5),
            };
            repository.AddAdvertisingImage(ai);







            ai = new AdvertisingImage()
            {
                AdvertisingImagePhysicalFilePath = MPU_FILEPATH,
                AdvertisingImageFileName = MPU_FILE18,
                AdvertisingImageBytes = GetImageAsBytes(MPU_FILEPATH + MPU_FILE18),
                AdvertisingImageType = repository.FindAdvertisingImageTypeByName("MPU"),
                AdvertisingImageStatus = repository.FindStatusByName("LIVE"),
                Category = repository.FindCategoryByID(5),
            };
            repository.AddAdvertisingImage(ai);
            ai = new AdvertisingImage()
            {
                AdvertisingImagePhysicalFilePath = MPU_FILEPATH,
                AdvertisingImageFileName = MPU_FILE19,
                AdvertisingImageBytes = GetImageAsBytes(MPU_FILEPATH + MPU_FILE19),
                AdvertisingImageType = repository.FindAdvertisingImageTypeByName("MPU"),
                AdvertisingImageStatus = repository.FindStatusByName("LIVE"),
                Category = repository.FindCategoryByID(5),
            };
            repository.AddAdvertisingImage(ai);
            ai = new AdvertisingImage()
            {
                AdvertisingImagePhysicalFilePath = MPU_FILEPATH,
                AdvertisingImageFileName = MPU_FILE20,
                AdvertisingImageBytes = GetImageAsBytes(MPU_FILEPATH + MPU_FILE20),
                AdvertisingImageType = repository.FindAdvertisingImageTypeByName("MPU"),
                AdvertisingImageStatus = repository.FindStatusByName("LIVE"),
                Category = repository.FindCategoryByID(5),
            };
            repository.AddAdvertisingImage(ai);
            ai = new AdvertisingImage()
            {
                AdvertisingImagePhysicalFilePath = MPU_FILEPATH,
                AdvertisingImageFileName = MPU_FILE21,
                AdvertisingImageBytes = GetImageAsBytes(MPU_FILEPATH + MPU_FILE21),
                AdvertisingImageType = repository.FindAdvertisingImageTypeByName("MPU"),
                AdvertisingImageStatus = repository.FindStatusByName("LIVE"),
                Category = repository.FindCategoryByID(1),
            };
            repository.AddAdvertisingImage(ai);
            ai = new AdvertisingImage()
            {
                AdvertisingImagePhysicalFilePath = MPU_FILEPATH,
                AdvertisingImageFileName = MPU_FILE22,
                AdvertisingImageBytes = GetImageAsBytes(MPU_FILEPATH + MPU_FILE22),
                AdvertisingImageType = repository.FindAdvertisingImageTypeByName("MPU"),
                AdvertisingImageStatus = repository.FindStatusByName("LIVE"),
                Category = repository.FindCategoryByID(1),
            };
            repository.AddAdvertisingImage(ai);











            ai = new AdvertisingImage()
            {
                AdvertisingImagePhysicalFilePath = MPU_FILEPATH,
                AdvertisingImageFileName = MPU_FILE23,
                AdvertisingImageBytes = GetImageAsBytes(MPU_FILEPATH + MPU_FILE23),
                AdvertisingImageType = repository.FindAdvertisingImageTypeByName("MPU"),
                AdvertisingImageStatus = repository.FindStatusByName("LIVE"),
                Category = repository.FindCategoryByName("WEB CONFERENCING"),
                CloudApplication = repository.GetCloudApplication(MPU_FILE23_CLOUDAPPLICATIONID,false),
            };
            repository.AddAdvertisingImage(ai);
            ai = new AdvertisingImage()
            {
                AdvertisingImagePhysicalFilePath = MPU_FILEPATH,
                AdvertisingImageFileName = MPU_FILE24,
                AdvertisingImageBytes = GetImageAsBytes(MPU_FILEPATH + MPU_FILE24),
                AdvertisingImageType = repository.FindAdvertisingImageTypeByName("MPU"),
                AdvertisingImageStatus = repository.FindStatusByName("LIVE"),
                Category = repository.FindCategoryByName("STORAGE AND BACKUP"),
                CloudApplication = repository.GetCloudApplication(MPU_FILE24_CLOUDAPPLICATIONID,false),
            };
            repository.AddAdvertisingImage(ai);
            ai = new AdvertisingImage()
            {
                AdvertisingImagePhysicalFilePath = MPU_FILEPATH,
                AdvertisingImageFileName = MPU_FILE25,
                AdvertisingImageBytes = GetImageAsBytes(MPU_FILEPATH + MPU_FILE25),
                AdvertisingImageType = repository.FindAdvertisingImageTypeByName("MPU"),
                AdvertisingImageStatus = repository.FindStatusByName("LIVE"),
                Category = repository.FindCategoryByName("WEB CONFERENCING"),
                CloudApplication = repository.GetCloudApplication(MPU_FILE25_CLOUDAPPLICATIONID,false),
            };
            repository.AddAdvertisingImage(ai);
            ai = new AdvertisingImage()
            {
                AdvertisingImagePhysicalFilePath = MPU_FILEPATH,
                AdvertisingImageFileName = MPU_FILE26,
                AdvertisingImageBytes = GetImageAsBytes(MPU_FILEPATH + MPU_FILE26),
                AdvertisingImageType = repository.FindAdvertisingImageTypeByName("MPU"),
                AdvertisingImageStatus = repository.FindStatusByName("LIVE"),
                Category = repository.FindCategoryByName("STORAGE AND BACKUP"),
                CloudApplication = repository.GetCloudApplication(MPU_FILE26_CLOUDAPPLICATIONID, false),
            };
            repository.AddAdvertisingImage(ai);
            ai = new AdvertisingImage()
            {
                AdvertisingImagePhysicalFilePath = MPU_FILEPATH,
                AdvertisingImageFileName = MPU_FILE27,
                AdvertisingImageBytes = GetImageAsBytes(MPU_FILEPATH + MPU_FILE27),
                AdvertisingImageType = repository.FindAdvertisingImageTypeByName("MPU"),
                AdvertisingImageStatus = repository.FindStatusByName("LIVE"),
                Category = repository.FindCategoryByName("SECURITY"),
                CloudApplication = repository.GetCloudApplication(MPU_FILE27_CLOUDAPPLICATIONID, false),
            };
            repository.AddAdvertisingImage(ai);
            ai = new AdvertisingImage()
            {
                AdvertisingImagePhysicalFilePath = MPU_FILEPATH,
                AdvertisingImageFileName = MPU_FILE28,
                AdvertisingImageBytes = GetImageAsBytes(MPU_FILEPATH + MPU_FILE28),
                AdvertisingImageType = repository.FindAdvertisingImageTypeByName("MPU"),
                AdvertisingImageStatus = repository.FindStatusByName("LIVE"),
                Category = repository.FindCategoryByName("FINANCIAL"),
                CloudApplication = repository.GetCloudApplication(MPU_FILE28_CLOUDAPPLICATIONID, false),
            };
            repository.AddAdvertisingImage(ai);
            ai = new AdvertisingImage()
            {
                AdvertisingImagePhysicalFilePath = MPU_FILEPATH,
                AdvertisingImageFileName = MPU_FILE29,
                AdvertisingImageBytes = GetImageAsBytes(MPU_FILEPATH + MPU_FILE29),
                AdvertisingImageType = repository.FindAdvertisingImageTypeByName("MPU"),
                AdvertisingImageStatus = repository.FindStatusByName("LIVE"),
                Category = repository.FindCategoryByName("FINANCIAL"),
                CloudApplication = repository.GetCloudApplication(MPU_FILE29_CLOUDAPPLICATIONID, false),
            };
            repository.AddAdvertisingImage(ai);
            ai = new AdvertisingImage()
            {
                AdvertisingImagePhysicalFilePath = MPU_FILEPATH,
                AdvertisingImageFileName = MPU_FILE30,
                AdvertisingImageBytes = GetImageAsBytes(MPU_FILEPATH + MPU_FILE30),
                AdvertisingImageType = repository.FindAdvertisingImageTypeByName("MPU"),
                AdvertisingImageStatus = repository.FindStatusByName("LIVE"),
                Category = repository.FindCategoryByName("PROJECT MANAGEMENT"),
                CloudApplication = repository.GetCloudApplication(MPU_FILE30_CLOUDAPPLICATIONID, false),
            };
            repository.AddAdvertisingImage(ai);
            ai = new AdvertisingImage()
            {
                AdvertisingImagePhysicalFilePath = MPU_FILEPATH,
                AdvertisingImageFileName = MPU_FILE31,
                AdvertisingImageBytes = GetImageAsBytes(MPU_FILEPATH + MPU_FILE31),
                AdvertisingImageType = repository.FindAdvertisingImageTypeByName("MPU"),
                AdvertisingImageStatus = repository.FindStatusByName("LIVE"),
                Category = repository.FindCategoryByName("EMAIL"),
                CloudApplication = repository.GetCloudApplication(MPU_FILE31_CLOUDAPPLICATIONID, false),
            };
            repository.AddAdvertisingImage(ai);
            ai = new AdvertisingImage()
            {
                AdvertisingImagePhysicalFilePath = MPU_FILEPATH,
                AdvertisingImageFileName = MPU_FILE32,
                AdvertisingImageBytes = GetImageAsBytes(MPU_FILEPATH + MPU_FILE32),
                AdvertisingImageType = repository.FindAdvertisingImageTypeByName("MPU"),
                AdvertisingImageStatus = repository.FindStatusByName("LIVE"),
                Category = repository.FindCategoryByName("CRM"),
                CloudApplication = repository.GetCloudApplication(MPU_FILE32_CLOUDAPPLICATIONID, false),
            };
            repository.AddAdvertisingImage(ai);
            ai = new AdvertisingImage()
            {
                AdvertisingImagePhysicalFilePath = MPU_FILEPATH,
                AdvertisingImageFileName = MPU_FILE33,
                AdvertisingImageBytes = GetImageAsBytes(MPU_FILEPATH + MPU_FILE33),
                AdvertisingImageType = repository.FindAdvertisingImageTypeByName("MPU"),
                AdvertisingImageStatus = repository.FindStatusByName("LIVE"),
                Category = repository.FindCategoryByName("STORAGE AND BACKUP"),
                CloudApplication = repository.GetCloudApplication(MPU_FILE33_CLOUDAPPLICATIONID, false),
            };
            repository.AddAdvertisingImage(ai);
            ai = new AdvertisingImage()
            {
                AdvertisingImagePhysicalFilePath = MPU_FILEPATH,
                AdvertisingImageFileName = MPU_FILE34,
                AdvertisingImageBytes = GetImageAsBytes(MPU_FILEPATH + MPU_FILE34),
                AdvertisingImageType = repository.FindAdvertisingImageTypeByName("MPU"),
                AdvertisingImageStatus = repository.FindStatusByName("LIVE"),
                Category = repository.FindCategoryByName("STORAGE AND BACKUP"),
                CloudApplication = repository.GetCloudApplication(MPU_FILE34_CLOUDAPPLICATIONID, false),
            };
            repository.AddAdvertisingImage(ai);
            ai = new AdvertisingImage()
            {
                AdvertisingImagePhysicalFilePath = MPU_FILEPATH,
                AdvertisingImageFileName = MPU_FILE35,
                AdvertisingImageBytes = GetImageAsBytes(MPU_FILEPATH + MPU_FILE35),
                AdvertisingImageType = repository.FindAdvertisingImageTypeByName("MPU"),
                AdvertisingImageStatus = repository.FindStatusByName("LIVE"),
                Category = repository.FindCategoryByName("SECURITY"),
                CloudApplication = repository.GetCloudApplication(MPU_FILE35_CLOUDAPPLICATIONID, false),
            };
            repository.AddAdvertisingImage(ai);
            ai = new AdvertisingImage()
            {
                AdvertisingImagePhysicalFilePath = MPU_FILEPATH,
                AdvertisingImageFileName = MPU_FILE36,
                AdvertisingImageBytes = GetImageAsBytes(MPU_FILEPATH + MPU_FILE36),
                AdvertisingImageType = repository.FindAdvertisingImageTypeByName("MPU"),
                AdvertisingImageStatus = repository.FindStatusByName("DELETED"),
                Category = repository.FindCategoryByName("FINANCIAL"),
                CloudApplication = repository.GetCloudApplication(MPU_FILE36_CLOUDAPPLICATIONID, false),
            };
            repository.AddAdvertisingImage(ai);
            ai = new AdvertisingImage()
            {
                AdvertisingImagePhysicalFilePath = MPU_FILEPATH,
                AdvertisingImageFileName = MPU_FILE37,
                AdvertisingImageBytes = GetImageAsBytes(MPU_FILEPATH + MPU_FILE37),
                AdvertisingImageType = repository.FindAdvertisingImageTypeByName("MPU"),
                AdvertisingImageStatus = repository.FindStatusByName("LIVE"),
                Category = repository.FindCategoryByName("CRM"),
                CloudApplication = repository.GetCloudApplication(MPU_FILE37_CLOUDAPPLICATIONID, false),
            };
            repository.AddAdvertisingImage(ai);
            ai = new AdvertisingImage()
            {
                AdvertisingImagePhysicalFilePath = MPU_FILEPATH,
                AdvertisingImageFileName = MPU_FILE38,
                AdvertisingImageBytes = GetImageAsBytes(MPU_FILEPATH + MPU_FILE38),
                AdvertisingImageType = repository.FindAdvertisingImageTypeByName("MPU"),
                AdvertisingImageStatus = repository.FindStatusByName("LIVE"),
                Category = repository.FindCategoryByName("PROJECT MANAGEMENT"),
                CloudApplication = repository.GetCloudApplication(MPU_FILE38_CLOUDAPPLICATIONID, false),
            };
            repository.AddAdvertisingImage(ai);
            ai = new AdvertisingImage()
            {
                AdvertisingImagePhysicalFilePath = MPU_FILEPATH,
                AdvertisingImageFileName = MPU_FILE39,
                AdvertisingImageBytes = GetImageAsBytes(MPU_FILEPATH + MPU_FILE39),
                AdvertisingImageType = repository.FindAdvertisingImageTypeByName("MPU"),
                AdvertisingImageStatus = repository.FindStatusByName("LIVE"),
                Category = repository.FindCategoryByName("EMAIL"),
                CloudApplication = repository.GetCloudApplication(MPU_FILE39_CLOUDAPPLICATIONID, false),
            };
            repository.AddAdvertisingImage(ai);
            ai = new AdvertisingImage()
            {
                AdvertisingImagePhysicalFilePath = MPU_FILEPATH,
                AdvertisingImageFileName = MPU_FILE40,
                AdvertisingImageBytes = GetImageAsBytes(MPU_FILEPATH + MPU_FILE40),
                AdvertisingImageType = repository.FindAdvertisingImageTypeByName("MPU"),
                AdvertisingImageStatus = repository.FindStatusByName("LIVE"),
                Category = repository.FindCategoryByName("CRM"),
                CloudApplication = repository.GetCloudApplication(MPU_FILE40_CLOUDAPPLICATIONID, false),
            };
            repository.AddAdvertisingImage(ai);
            ai = new AdvertisingImage()
            {
                AdvertisingImagePhysicalFilePath = MPU_FILEPATH,
                AdvertisingImageFileName = MPU_FILE41,
                AdvertisingImageBytes = GetImageAsBytes(MPU_FILEPATH + MPU_FILE41),
                AdvertisingImageType = repository.FindAdvertisingImageTypeByName("MPU"),
                AdvertisingImageStatus = repository.FindStatusByName("LIVE"),
                Category = repository.FindCategoryByName("PROJECT MANAGEMENT"),
                CloudApplication = repository.GetCloudApplication(MPU_FILE41_CLOUDAPPLICATIONID, false),
            };
            repository.AddAdvertisingImage(ai);
            ai = new AdvertisingImage()
            {
                AdvertisingImagePhysicalFilePath = MPU_FILEPATH,
                AdvertisingImageFileName = MPU_FILE42,
                AdvertisingImageBytes = GetImageAsBytes(MPU_FILEPATH + MPU_FILE42),
                AdvertisingImageType = repository.FindAdvertisingImageTypeByName("MPU"),
                AdvertisingImageStatus = repository.FindStatusByName("LIVE"),
                Category = repository.FindCategoryByName("EMAIL"),
                CloudApplication = repository.GetCloudApplication(MPU_FILE42_CLOUDAPPLICATIONID, false),
            };
            repository.AddAdvertisingImage(ai);
            ai = new AdvertisingImage()
            {
                AdvertisingImagePhysicalFilePath = MPU_FILEPATH,
                AdvertisingImageFileName = MPU_FILE43,
                AdvertisingImageBytes = GetImageAsBytes(MPU_FILEPATH + MPU_FILE43),
                AdvertisingImageType = repository.FindAdvertisingImageTypeByName("MPU"),
                AdvertisingImageStatus = repository.FindStatusByName("LIVE"),
                Category = repository.FindCategoryByName("FINANCIAL"),
                CloudApplication = repository.GetCloudApplication(MPU_FILE43_CLOUDAPPLICATIONID, false),
            };
            repository.AddAdvertisingImage(ai);
            ai = new AdvertisingImage()
            {
                AdvertisingImagePhysicalFilePath = MPU_FILEPATH,
                AdvertisingImageFileName = MPU_FILE44,
                AdvertisingImageBytes = GetImageAsBytes(MPU_FILEPATH + MPU_FILE44),
                AdvertisingImageType = repository.FindAdvertisingImageTypeByName("MPU"),
                AdvertisingImageStatus = repository.FindStatusByName("LIVE"),
                Category = repository.FindCategoryByName("EMAIL"),
                CloudApplication = repository.GetCloudApplication(MPU_FILE44_CLOUDAPPLICATIONID, false),
            };
            repository.AddAdvertisingImage(ai);
            ai = new AdvertisingImage()
            {
                AdvertisingImagePhysicalFilePath = MPU_FILEPATH,
                AdvertisingImageFileName = MPU_FILE45,
                AdvertisingImageBytes = GetImageAsBytes(MPU_FILEPATH + MPU_FILE45),
                AdvertisingImageType = repository.FindAdvertisingImageTypeByName("MPU"),
                AdvertisingImageStatus = repository.FindStatusByName("SUSPENDED"),
                Category = repository.FindCategoryByName("WEB CONFERENCING"),
                CloudApplication = repository.GetCloudApplication(MPU_FILE45_CLOUDAPPLICATIONID, false),
            };
            repository.AddAdvertisingImage(ai);
            ai = new AdvertisingImage()
            {
                AdvertisingImagePhysicalFilePath = MPU_FILEPATH,
                AdvertisingImageFileName = MPU_FILE46,
                AdvertisingImageBytes = GetImageAsBytes(MPU_FILEPATH + MPU_FILE46),
                AdvertisingImageType = repository.FindAdvertisingImageTypeByName("MPU"),
                AdvertisingImageStatus = repository.FindStatusByName("LIVE"),
                Category = repository.FindCategoryByName("PROJECT MANAGEMENT"),
                CloudApplication = repository.GetCloudApplication(MPU_FILE46_CLOUDAPPLICATIONID, false),
            };
            repository.AddAdvertisingImage(ai);



            // 4/2/2014
            ai = new AdvertisingImage()
            {
                AdvertisingImagePhysicalFilePath = MPU_FILEPATH,
                AdvertisingImageFileName = MPU_FILE47,
                AdvertisingImageBytes = GetImageAsBytes(MPU_FILEPATH + MPU_FILE47),
                AdvertisingImageType = repository.FindAdvertisingImageTypeByName("MPU"),
                AdvertisingImageStatus = repository.FindStatusByName("LIVE"),
                Category = repository.FindCategoryByName("COMMUNICATIONS"),
                CloudApplication = repository.GetCloudApplication(MPU_FILE47_CLOUDAPPLICATIONID, false),
            };
            repository.AddAdvertisingImage(ai);
            ai = new AdvertisingImage()
            {
                AdvertisingImagePhysicalFilePath = MPU_FILEPATH,
                AdvertisingImageFileName = MPU_FILE48,
                AdvertisingImageBytes = GetImageAsBytes(MPU_FILEPATH + MPU_FILE48),
                AdvertisingImageType = repository.FindAdvertisingImageTypeByName("MPU"),
                AdvertisingImageStatus = repository.FindStatusByName("LIVE"),
                Category = repository.FindCategoryByName("COMMUNICATIONS"),
                CloudApplication = repository.GetCloudApplication(MPU_FILE48_CLOUDAPPLICATIONID, false),
            };
            repository.AddAdvertisingImage(ai);
            ai = new AdvertisingImage()
            {
                AdvertisingImagePhysicalFilePath = MPU_FILEPATH,
                AdvertisingImageFileName = MPU_FILE49,
                AdvertisingImageBytes = GetImageAsBytes(MPU_FILEPATH + MPU_FILE49),
                AdvertisingImageType = repository.FindAdvertisingImageTypeByName("MPU"),
                AdvertisingImageStatus = repository.FindStatusByName("LIVE"),
                Category = repository.FindCategoryByName("OFFICE"),
                CloudApplication = repository.GetCloudApplication(MPU_FILE49_CLOUDAPPLICATIONID, false),
            };
            repository.AddAdvertisingImage(ai);
            ai = new AdvertisingImage()
            {
                AdvertisingImagePhysicalFilePath = MPU_FILEPATH,
                AdvertisingImageFileName = MPU_FILE50,
                AdvertisingImageBytes = GetImageAsBytes(MPU_FILEPATH + MPU_FILE50),
                AdvertisingImageType = repository.FindAdvertisingImageTypeByName("MPU"),
                AdvertisingImageStatus = repository.FindStatusByName("LIVE"),
                Category = repository.FindCategoryByName("OFFICE"),
                CloudApplication = repository.GetCloudApplication(MPU_FILE50_CLOUDAPPLICATIONID, false),
            };
            repository.AddAdvertisingImage(ai);
            ai = new AdvertisingImage()
            {
                AdvertisingImagePhysicalFilePath = MPU_FILEPATH,
                AdvertisingImageFileName = MPU_FILE51,
                AdvertisingImageBytes = GetImageAsBytes(MPU_FILEPATH + MPU_FILE51),
                AdvertisingImageType = repository.FindAdvertisingImageTypeByName("MPU"),
                AdvertisingImageStatus = repository.FindStatusByName("LIVE"),
                Category = repository.FindCategoryByName("OFFICE"),
                CloudApplication = repository.GetCloudApplication(MPU_FILE51_CLOUDAPPLICATIONID, false),
            };
            repository.AddAdvertisingImage(ai);
            ai = new AdvertisingImage()
            {
                AdvertisingImagePhysicalFilePath = MPU_FILEPATH,
                AdvertisingImageFileName = MPU_FILE52,
                AdvertisingImageBytes = GetImageAsBytes(MPU_FILEPATH + MPU_FILE52),
                AdvertisingImageType = repository.FindAdvertisingImageTypeByName("MPU"),
                AdvertisingImageStatus = repository.FindStatusByName("SUSPENDED"),
                Category = repository.FindCategoryByName("PROJECT MANAGEMENT"),
                //CloudApplication = repository.GetCloudApplication(MPU_FILE52_CLOUDAPPLICATIONID, false),
            };
            repository.AddAdvertisingImage(ai);
            ai = new AdvertisingImage()
            {
                AdvertisingImagePhysicalFilePath = MPU_FILEPATH,
                AdvertisingImageFileName = MPU_FILE53,
                AdvertisingImageBytes = GetImageAsBytes(MPU_FILEPATH + MPU_FILE53),
                AdvertisingImageType = repository.FindAdvertisingImageTypeByName("MPU"),
                AdvertisingImageStatus = repository.FindStatusByName("DELETED"),
                Category = repository.FindCategoryByName("FINANCIAL"),
                CloudApplication = repository.GetCloudApplication(MPU_FILE53_CLOUDAPPLICATIONID, false),
            };
            repository.AddAdvertisingImage(ai);
            ai = new AdvertisingImage()
            {
                AdvertisingImagePhysicalFilePath = MPU_FILEPATH,
                AdvertisingImageFileName = MPU_FILE54,
                AdvertisingImageBytes = GetImageAsBytes(MPU_FILEPATH + MPU_FILE54),
                AdvertisingImageType = repository.FindAdvertisingImageTypeByName("MPU"),
                AdvertisingImageStatus = repository.FindStatusByName("LIVE"),
                Category = repository.FindCategoryByName("WEB CONFERENCING"),
                CloudApplication = repository.GetCloudApplication(MPU_FILE54_CLOUDAPPLICATIONID, false),
            };
            repository.AddAdvertisingImage(ai);
            ai = new AdvertisingImage()
            {
                AdvertisingImagePhysicalFilePath = MPU_FILEPATH,
                AdvertisingImageFileName = MPU_FILE55,
                AdvertisingImageBytes = GetImageAsBytes(MPU_FILEPATH + MPU_FILE55),
                AdvertisingImageType = repository.FindAdvertisingImageTypeByName("MPU"),
                AdvertisingImageStatus = repository.FindStatusByName("LIVE"),
                Category = repository.FindCategoryByName("WEB CONFERENCING"),
                CloudApplication = repository.GetCloudApplication(MPU_FILE55_CLOUDAPPLICATIONID, false),
            };
            repository.AddAdvertisingImage(ai);
            ai = new AdvertisingImage()
            {
                AdvertisingImagePhysicalFilePath = MPU_FILEPATH,
                AdvertisingImageFileName = MPU_FILE56,
                AdvertisingImageBytes = GetImageAsBytes(MPU_FILEPATH + MPU_FILE56),
                AdvertisingImageType = repository.FindAdvertisingImageTypeByName("MPU"),
                AdvertisingImageStatus = repository.FindStatusByName("LIVE"),
                Category = repository.FindCategoryByName("SECURITY"),
                CloudApplication = repository.GetCloudApplication(MPU_FILE56_CLOUDAPPLICATIONID, false),
            };
            repository.AddAdvertisingImage(ai);
            ai = new AdvertisingImage()
            {
                AdvertisingImagePhysicalFilePath = MPU_FILEPATH,
                AdvertisingImageFileName = MPU_FILE57,
                AdvertisingImageBytes = GetImageAsBytes(MPU_FILEPATH + MPU_FILE57),
                AdvertisingImageType = repository.FindAdvertisingImageTypeByName("MPU"),
                AdvertisingImageStatus = repository.FindStatusByName("LIVE"),
                Category = repository.FindCategoryByName("SECURITY"),
                CloudApplication = repository.GetCloudApplication(MPU_FILE57_CLOUDAPPLICATIONID, false),
            };
            repository.AddAdvertisingImage(ai);
            ai = new AdvertisingImage()
            {
                AdvertisingImagePhysicalFilePath = MPU_FILEPATH,
                AdvertisingImageFileName = MPU_FILE58,
                AdvertisingImageBytes = GetImageAsBytes(MPU_FILEPATH + MPU_FILE58),
                AdvertisingImageType = repository.FindAdvertisingImageTypeByName("MPU"),
                AdvertisingImageStatus = repository.FindStatusByName("LIVE"),
                Category = repository.FindCategoryByName("CRM"),
                CloudApplication = repository.GetCloudApplication(MPU_FILE58_CLOUDAPPLICATIONID, false),
            };
            repository.AddAdvertisingImage(ai);
            ai = new AdvertisingImage()
            {
                AdvertisingImagePhysicalFilePath = MPU_FILEPATH,
                AdvertisingImageFileName = MPU_FILE59,
                AdvertisingImageBytes = GetImageAsBytes(MPU_FILEPATH + MPU_FILE59),
                AdvertisingImageType = repository.FindAdvertisingImageTypeByName("MPU"),
                AdvertisingImageStatus = repository.FindStatusByName("SUSPENDED"),
                Category = repository.FindCategoryByName("FINANCIAL"),
                CloudApplication = repository.GetCloudApplication(MPU_FILE59_CLOUDAPPLICATIONID, false),
            };
            repository.AddAdvertisingImage(ai);

            // 13/5/2014
            ai = new AdvertisingImage()
            {
                AdvertisingImagePhysicalFilePath = MPU_FILEPATH,
                AdvertisingImageFileName = MPU_FILE60,
                AdvertisingImageBytes = GetImageAsBytes(MPU_FILEPATH + MPU_FILE60),
                AdvertisingImageType = repository.FindAdvertisingImageTypeByName("MPU"),
                AdvertisingImageStatus = repository.FindStatusByName("LIVE"),
                Category = repository.FindCategoryByName("COMMUNICATIONS"),
                CloudApplication = repository.GetCloudApplication(MPU_FILE60_CLOUDAPPLICATIONID, false),
            };
            repository.AddAdvertisingImage(ai);

            // 9/7/2014
            ai = new AdvertisingImage()
            {
                AdvertisingImagePhysicalFilePath = MPU_FILEPATH,
                AdvertisingImageFileName = MPU_FILE61,
                AdvertisingImageBytes = GetImageAsBytes(MPU_FILEPATH + MPU_FILE61),
                AdvertisingImageType = repository.FindAdvertisingImageTypeByName("MPU"),
                AdvertisingImageStatus = repository.FindStatusByName("SUSPENDED"),
                Category = repository.FindCategoryByName("FINANCIAL"),
                CloudApplication = repository.GetCloudApplication(MPU_FILE61_CLOUDAPPLICATIONID, false),
            };
            repository.AddAdvertisingImage(ai);

            // 30/11/2014
            ai = new AdvertisingImage()
            {
                AdvertisingImagePhysicalFilePath = MPU_FILEPATH,
                AdvertisingImageFileName = MPU_FILE62,
                AdvertisingImageBytes = GetImageAsBytes(MPU_FILEPATH + MPU_FILE62),
                AdvertisingImageType = repository.FindAdvertisingImageTypeByName("MPU"),
                AdvertisingImageStatus = repository.FindStatusByName("LIVE"),
                Category = repository.FindCategoryByName("FINANCIAL"),
                CloudApplication = repository.GetCloudApplication(MPU_FILE62_CLOUDAPPLICATIONID, false),
            };
            repository.AddAdvertisingImage(ai);

            ai = new AdvertisingImage()
            {
                AdvertisingImagePhysicalFilePath = SKYSCRAPER_FILEPATH,
                AdvertisingImageFileName = SKYSCRAPER_FILE1,
                AdvertisingImageBytes = GetImageAsBytes(SKYSCRAPER_FILEPATH + SKYSCRAPER_FILE1),
                AdvertisingImageType = repository.FindAdvertisingImageTypeByName("SKYSCRAPER"),
                AdvertisingImageStatus = repository.FindStatusByName("DELETED"),
            };
            repository.AddAdvertisingImage(ai);

            ai = new AdvertisingImage()
            {
                AdvertisingImagePhysicalFilePath = SKYSCRAPER_FILEPATH,
                AdvertisingImageFileName = SKYSCRAPER_FILE2,
                AdvertisingImageBytes = GetImageAsBytes(SKYSCRAPER_FILEPATH + SKYSCRAPER_FILE2),
                AdvertisingImageType = repository.FindAdvertisingImageTypeByName("SKYSCRAPER"),
                AdvertisingImageStatus = repository.FindStatusByName("DELETED"),
            };
            repository.AddAdvertisingImage(ai);

            ai = new AdvertisingImage()
            {
                AdvertisingImagePhysicalFilePath = SKYSCRAPER_FILEPATH,
                AdvertisingImageFileName = SKYSCRAPER_FILE3,
                AdvertisingImageBytes = GetImageAsBytes(SKYSCRAPER_FILEPATH + SKYSCRAPER_FILE3),
                AdvertisingImageType = repository.FindAdvertisingImageTypeByName("SKYSCRAPER"),
                AdvertisingImageStatus = repository.FindStatusByName("DELETED"),
            };
            repository.AddAdvertisingImage(ai);

            ai = new AdvertisingImage()
            {
                AdvertisingImagePhysicalFilePath = SKYSCRAPER_FILEPATH,
                AdvertisingImageFileName = SKYSCRAPER_FILE4,
                AdvertisingImageBytes = GetImageAsBytes(SKYSCRAPER_FILEPATH + SKYSCRAPER_FILE4),
                AdvertisingImageType = repository.FindAdvertisingImageTypeByName("SKYSCRAPER"),
                AdvertisingImageStatus = repository.FindStatusByName("DELETED"),
            };
            repository.AddAdvertisingImage(ai);

            ai = new AdvertisingImage()
            {
                AdvertisingImagePhysicalFilePath = SKYSCRAPER_FILEPATH,
                AdvertisingImageFileName = SKYSCRAPER_FILE5,
                AdvertisingImageBytes = GetImageAsBytes(SKYSCRAPER_FILEPATH + SKYSCRAPER_FILE5),
                AdvertisingImageType = repository.FindAdvertisingImageTypeByName("SKYSCRAPER"),
                AdvertisingImageStatus = repository.FindStatusByName("LIVE"),
                Category = repository.FindCategoryByID(5),
            };
            repository.AddAdvertisingImage(ai);
            ai = new AdvertisingImage()
            {
                AdvertisingImagePhysicalFilePath = SKYSCRAPER_FILEPATH,
                AdvertisingImageFileName = SKYSCRAPER_FILE6,
                AdvertisingImageBytes = GetImageAsBytes(SKYSCRAPER_FILEPATH + SKYSCRAPER_FILE6),
                AdvertisingImageType = repository.FindAdvertisingImageTypeByName("SKYSCRAPER"),
                AdvertisingImageStatus = repository.FindStatusByName("LIVE"),
                Category = repository.FindCategoryByID(5),
            };
            repository.AddAdvertisingImage(ai);
            ai = new AdvertisingImage()
            {
                AdvertisingImagePhysicalFilePath = SKYSCRAPER_FILEPATH,
                AdvertisingImageFileName = SKYSCRAPER_FILE7,
                AdvertisingImageBytes = GetImageAsBytes(SKYSCRAPER_FILEPATH + SKYSCRAPER_FILE7),
                AdvertisingImageType = repository.FindAdvertisingImageTypeByName("SKYSCRAPER"),
                AdvertisingImageStatus = repository.FindStatusByName("LIVE"),
                Category = repository.FindCategoryByID(1),
            };
            repository.AddAdvertisingImage(ai);
            ai = new AdvertisingImage()
            {
                AdvertisingImagePhysicalFilePath = SKYSCRAPER_FILEPATH,
                AdvertisingImageFileName = SKYSCRAPER_FILE8,
                AdvertisingImageBytes = GetImageAsBytes(SKYSCRAPER_FILEPATH + SKYSCRAPER_FILE8),
                AdvertisingImageType = repository.FindAdvertisingImageTypeByName("SKYSCRAPER"),
                AdvertisingImageStatus = repository.FindStatusByName("LIVE"),
                Category = repository.FindCategoryByID(1),
            };
            repository.AddAdvertisingImage(ai);






            ai = new AdvertisingImage()
            {
                AdvertisingImagePhysicalFilePath = SKYSCRAPER_FILEPATH,
                AdvertisingImageFileName = SKYSCRAPER_FILE9,
                AdvertisingImageBytes = GetImageAsBytes(SKYSCRAPER_FILEPATH + SKYSCRAPER_FILE9),
                AdvertisingImageType = repository.FindAdvertisingImageTypeByName("SKYSCRAPER"),
                AdvertisingImageStatus = repository.FindStatusByName("LIVE"),
                Category = repository.FindCategoryByName("WEB CONFERENCING"),
                CloudApplication = repository.GetCloudApplication(SKYSCRAPER_FILE9_CLOUDAPPLICATIONID, false),
            };
            repository.AddAdvertisingImage(ai);
            ai = new AdvertisingImage()
            {
                AdvertisingImagePhysicalFilePath = SKYSCRAPER_FILEPATH,
                AdvertisingImageFileName = SKYSCRAPER_FILE10,
                AdvertisingImageBytes = GetImageAsBytes(SKYSCRAPER_FILEPATH + SKYSCRAPER_FILE10),
                AdvertisingImageType = repository.FindAdvertisingImageTypeByName("SKYSCRAPER"),
                AdvertisingImageStatus = repository.FindStatusByName("LIVE"),
                Category = repository.FindCategoryByName("STORAGE AND BACKUP"),
                CloudApplication = repository.GetCloudApplication(SKYSCRAPER_FILE10_CLOUDAPPLICATIONID, false),
            };
            repository.AddAdvertisingImage(ai);
            ai = new AdvertisingImage()
            {
                AdvertisingImagePhysicalFilePath = SKYSCRAPER_FILEPATH,
                AdvertisingImageFileName = SKYSCRAPER_FILE11,
                AdvertisingImageBytes = GetImageAsBytes(SKYSCRAPER_FILEPATH + SKYSCRAPER_FILE11),
                AdvertisingImageType = repository.FindAdvertisingImageTypeByName("SKYSCRAPER"),
                AdvertisingImageStatus = repository.FindStatusByName("LIVE"),
                Category = repository.FindCategoryByName("WEB CONFERENCING"),
                CloudApplication = repository.GetCloudApplication(SKYSCRAPER_FILE11_CLOUDAPPLICATIONID, false),
            };
            repository.AddAdvertisingImage(ai);
            ai = new AdvertisingImage()
            {
                AdvertisingImagePhysicalFilePath = SKYSCRAPER_FILEPATH,
                AdvertisingImageFileName = SKYSCRAPER_FILE12,
                AdvertisingImageBytes = GetImageAsBytes(SKYSCRAPER_FILEPATH + SKYSCRAPER_FILE12),
                AdvertisingImageType = repository.FindAdvertisingImageTypeByName("SKYSCRAPER"),
                AdvertisingImageStatus = repository.FindStatusByName("LIVE"),
                Category = repository.FindCategoryByName("STORAGE AND BACKUP"),
                CloudApplication = repository.GetCloudApplication(SKYSCRAPER_FILE12_CLOUDAPPLICATIONID, false),
            };
            repository.AddAdvertisingImage(ai);
            ai = new AdvertisingImage()
            {
                AdvertisingImagePhysicalFilePath = SKYSCRAPER_FILEPATH,
                AdvertisingImageFileName = SKYSCRAPER_FILE13,
                AdvertisingImageBytes = GetImageAsBytes(SKYSCRAPER_FILEPATH + SKYSCRAPER_FILE13),
                AdvertisingImageType = repository.FindAdvertisingImageTypeByName("SKYSCRAPER"),
                AdvertisingImageStatus = repository.FindStatusByName("LIVE"),
                Category = repository.FindCategoryByName("SECURITY"),
                CloudApplication = repository.GetCloudApplication(SKYSCRAPER_FILE13_CLOUDAPPLICATIONID, false),
            };
            repository.AddAdvertisingImage(ai);
            ai = new AdvertisingImage()
            {
                AdvertisingImagePhysicalFilePath = SKYSCRAPER_FILEPATH,
                AdvertisingImageFileName = SKYSCRAPER_FILE14,
                AdvertisingImageBytes = GetImageAsBytes(SKYSCRAPER_FILEPATH + SKYSCRAPER_FILE14),
                AdvertisingImageType = repository.FindAdvertisingImageTypeByName("SKYSCRAPER"),
                AdvertisingImageStatus = repository.FindStatusByName("LIVE"),
                Category = repository.FindCategoryByName("FINANCIAL"),
                CloudApplication = repository.GetCloudApplication(SKYSCRAPER_FILE14_CLOUDAPPLICATIONID, false),
            };
            repository.AddAdvertisingImage(ai);
            ai = new AdvertisingImage()
            {
                AdvertisingImagePhysicalFilePath = SKYSCRAPER_FILEPATH,
                AdvertisingImageFileName = SKYSCRAPER_FILE15,
                AdvertisingImageBytes = GetImageAsBytes(SKYSCRAPER_FILEPATH + SKYSCRAPER_FILE15),
                AdvertisingImageType = repository.FindAdvertisingImageTypeByName("SKYSCRAPER"),
                AdvertisingImageStatus = repository.FindStatusByName("LIVE"),
                Category = repository.FindCategoryByName("FINANCIAL"),
                CloudApplication = repository.GetCloudApplication(SKYSCRAPER_FILE15_CLOUDAPPLICATIONID, false),
            };
            repository.AddAdvertisingImage(ai);
            ai = new AdvertisingImage()
            {
                AdvertisingImagePhysicalFilePath = SKYSCRAPER_FILEPATH,
                AdvertisingImageFileName = SKYSCRAPER_FILE16,
                AdvertisingImageBytes = GetImageAsBytes(SKYSCRAPER_FILEPATH + SKYSCRAPER_FILE16),
                AdvertisingImageType = repository.FindAdvertisingImageTypeByName("SKYSCRAPER"),
                AdvertisingImageStatus = repository.FindStatusByName("LIVE"),
                Category = repository.FindCategoryByName("FINANCIAL"),
                CloudApplication = repository.GetCloudApplication(SKYSCRAPER_FILE16_CLOUDAPPLICATIONID, false),
            };
            repository.AddAdvertisingImage(ai);
            ai = new AdvertisingImage()
            {
                AdvertisingImagePhysicalFilePath = SKYSCRAPER_FILEPATH,
                AdvertisingImageFileName = SKYSCRAPER_FILE17,
                AdvertisingImageBytes = GetImageAsBytes(SKYSCRAPER_FILEPATH + SKYSCRAPER_FILE17),
                AdvertisingImageType = repository.FindAdvertisingImageTypeByName("SKYSCRAPER"),
                AdvertisingImageStatus = repository.FindStatusByName("LIVE"),
                Category = repository.FindCategoryByName("FINANCIAL"),
                CloudApplication = repository.GetCloudApplication(SKYSCRAPER_FILE17_CLOUDAPPLICATIONID, false),
            };
            repository.AddAdvertisingImage(ai);
            ai = new AdvertisingImage()
            {
                AdvertisingImagePhysicalFilePath = SKYSCRAPER_FILEPATH,
                AdvertisingImageFileName = SKYSCRAPER_FILE18,
                AdvertisingImageBytes = GetImageAsBytes(SKYSCRAPER_FILEPATH + SKYSCRAPER_FILE18),
                AdvertisingImageType = repository.FindAdvertisingImageTypeByName("SKYSCRAPER"),
                AdvertisingImageStatus = repository.FindStatusByName("LIVE"),
                Category = repository.FindCategoryByName("EMAIL"),
                CloudApplication = repository.GetCloudApplication(SKYSCRAPER_FILE18_CLOUDAPPLICATIONID, false),
            };
            repository.AddAdvertisingImage(ai);
            ai = new AdvertisingImage()
            {
                AdvertisingImagePhysicalFilePath = SKYSCRAPER_FILEPATH,
                AdvertisingImageFileName = SKYSCRAPER_FILE19,
                AdvertisingImageBytes = GetImageAsBytes(SKYSCRAPER_FILEPATH + SKYSCRAPER_FILE19),
                AdvertisingImageType = repository.FindAdvertisingImageTypeByName("SKYSCRAPER"),
                AdvertisingImageStatus = repository.FindStatusByName("LIVE"),
                Category = repository.FindCategoryByName("CRM"),
                CloudApplication = repository.GetCloudApplication(SKYSCRAPER_FILE19_CLOUDAPPLICATIONID, false),
            };
            repository.AddAdvertisingImage(ai);
            ai = new AdvertisingImage()
            {
                AdvertisingImagePhysicalFilePath = SKYSCRAPER_FILEPATH,
                AdvertisingImageFileName = SKYSCRAPER_FILE20,
                AdvertisingImageBytes = GetImageAsBytes(SKYSCRAPER_FILEPATH + SKYSCRAPER_FILE20),
                AdvertisingImageType = repository.FindAdvertisingImageTypeByName("SKYSCRAPER"),
                AdvertisingImageStatus = repository.FindStatusByName("LIVE"),
                Category = repository.FindCategoryByName("STORAGE AND BACKUP"),
                CloudApplication = repository.GetCloudApplication(SKYSCRAPER_FILE20_CLOUDAPPLICATIONID, false),
            };
            repository.AddAdvertisingImage(ai);
            ai = new AdvertisingImage()
            {
                AdvertisingImagePhysicalFilePath = SKYSCRAPER_FILEPATH,
                AdvertisingImageFileName = SKYSCRAPER_FILE21,
                AdvertisingImageBytes = GetImageAsBytes(SKYSCRAPER_FILEPATH + SKYSCRAPER_FILE21),
                AdvertisingImageType = repository.FindAdvertisingImageTypeByName("SKYSCRAPER"),
                AdvertisingImageStatus = repository.FindStatusByName("LIVE"),
                Category = repository.FindCategoryByName("STORAGE AND BACKUP"),
                CloudApplication = repository.GetCloudApplication(SKYSCRAPER_FILE21_CLOUDAPPLICATIONID, false),
            };
            repository.AddAdvertisingImage(ai);
            ai = new AdvertisingImage()
            {
                AdvertisingImagePhysicalFilePath = SKYSCRAPER_FILEPATH,
                AdvertisingImageFileName = SKYSCRAPER_FILE22,
                AdvertisingImageBytes = GetImageAsBytes(SKYSCRAPER_FILEPATH + SKYSCRAPER_FILE22),
                AdvertisingImageType = repository.FindAdvertisingImageTypeByName("SKYSCRAPER"),
                AdvertisingImageStatus = repository.FindStatusByName("LIVE"),
                Category = repository.FindCategoryByName("SECURITY"),
                CloudApplication = repository.GetCloudApplication(SKYSCRAPER_FILE22_CLOUDAPPLICATIONID, false),
            };
            repository.AddAdvertisingImage(ai);
            ai = new AdvertisingImage()
            {
                AdvertisingImagePhysicalFilePath = SKYSCRAPER_FILEPATH,
                AdvertisingImageFileName = SKYSCRAPER_FILE23,
                AdvertisingImageBytes = GetImageAsBytes(SKYSCRAPER_FILEPATH + SKYSCRAPER_FILE23),
                AdvertisingImageType = repository.FindAdvertisingImageTypeByName("SKYSCRAPER"),
                AdvertisingImageStatus = repository.FindStatusByName("SUSPENDED"),
                Category = repository.FindCategoryByName("FINANCIAL"),
                CloudApplication = repository.GetCloudApplication(SKYSCRAPER_FILE23_CLOUDAPPLICATIONID, false),
            };
            repository.AddAdvertisingImage(ai);
            ai = new AdvertisingImage()
            {
                AdvertisingImagePhysicalFilePath = SKYSCRAPER_FILEPATH,
                AdvertisingImageFileName = SKYSCRAPER_FILE24,
                AdvertisingImageBytes = GetImageAsBytes(SKYSCRAPER_FILEPATH + SKYSCRAPER_FILE24),
                AdvertisingImageType = repository.FindAdvertisingImageTypeByName("SKYSCRAPER"),
                AdvertisingImageStatus = repository.FindStatusByName("LIVE"),
                Category = repository.FindCategoryByName("CRM"),
                CloudApplication = repository.GetCloudApplication(SKYSCRAPER_FILE24_CLOUDAPPLICATIONID, false),
            };
            repository.AddAdvertisingImage(ai);
            ai = new AdvertisingImage()
            {
                AdvertisingImagePhysicalFilePath = SKYSCRAPER_FILEPATH,
                AdvertisingImageFileName = SKYSCRAPER_FILE25,
                AdvertisingImageBytes = GetImageAsBytes(SKYSCRAPER_FILEPATH + SKYSCRAPER_FILE25),
                AdvertisingImageType = repository.FindAdvertisingImageTypeByName("SKYSCRAPER"),
                AdvertisingImageStatus = repository.FindStatusByName("LIVE"),
                Category = repository.FindCategoryByName("PROJECT MANAGEMENT"),
                CloudApplication = repository.GetCloudApplication(SKYSCRAPER_FILE25_CLOUDAPPLICATIONID, false),
            };
            repository.AddAdvertisingImage(ai);
            ai = new AdvertisingImage()
            {
                AdvertisingImagePhysicalFilePath = SKYSCRAPER_FILEPATH,
                AdvertisingImageFileName = SKYSCRAPER_FILE26,
                AdvertisingImageBytes = GetImageAsBytes(SKYSCRAPER_FILEPATH + SKYSCRAPER_FILE26),
                AdvertisingImageType = repository.FindAdvertisingImageTypeByName("SKYSCRAPER"),
                AdvertisingImageStatus = repository.FindStatusByName("LIVE"),
                Category = repository.FindCategoryByName("EMAIL"),
                CloudApplication = repository.GetCloudApplication(SKYSCRAPER_FILE26_CLOUDAPPLICATIONID, false),
            };
            repository.AddAdvertisingImage(ai);
            ai = new AdvertisingImage()
            {
                AdvertisingImagePhysicalFilePath = SKYSCRAPER_FILEPATH,
                AdvertisingImageFileName = SKYSCRAPER_FILE27,
                AdvertisingImageBytes = GetImageAsBytes(SKYSCRAPER_FILEPATH + SKYSCRAPER_FILE27),
                AdvertisingImageType = repository.FindAdvertisingImageTypeByName("SKYSCRAPER"),
                AdvertisingImageStatus = repository.FindStatusByName("LIVE"),
                Category = repository.FindCategoryByName("CRM"),
                CloudApplication = repository.GetCloudApplication(SKYSCRAPER_FILE27_CLOUDAPPLICATIONID, false),
            };
            repository.AddAdvertisingImage(ai);
            ai = new AdvertisingImage()
            {
                AdvertisingImagePhysicalFilePath = SKYSCRAPER_FILEPATH,
                AdvertisingImageFileName = SKYSCRAPER_FILE28,
                AdvertisingImageBytes = GetImageAsBytes(SKYSCRAPER_FILEPATH + SKYSCRAPER_FILE28),
                AdvertisingImageType = repository.FindAdvertisingImageTypeByName("SKYSCRAPER"),
                AdvertisingImageStatus = repository.FindStatusByName("LIVE"),
                Category = repository.FindCategoryByName("PROJECT MANAGEMENT"),
                CloudApplication = repository.GetCloudApplication(SKYSCRAPER_FILE28_CLOUDAPPLICATIONID, false),
            };
            repository.AddAdvertisingImage(ai);
            ai = new AdvertisingImage()
            {
                AdvertisingImagePhysicalFilePath = SKYSCRAPER_FILEPATH,
                AdvertisingImageFileName = SKYSCRAPER_FILE29,
                AdvertisingImageBytes = GetImageAsBytes(SKYSCRAPER_FILEPATH + SKYSCRAPER_FILE29),
                AdvertisingImageType = repository.FindAdvertisingImageTypeByName("SKYSCRAPER"),
                AdvertisingImageStatus = repository.FindStatusByName("LIVE"),
                Category = repository.FindCategoryByName("WEB CONFERENCING"),
                CloudApplication = repository.GetCloudApplication(SKYSCRAPER_FILE29_CLOUDAPPLICATIONID, false),
            };
            repository.AddAdvertisingImage(ai);
            ai = new AdvertisingImage()
            {
                AdvertisingImagePhysicalFilePath = SKYSCRAPER_FILEPATH,
                AdvertisingImageFileName = SKYSCRAPER_FILE30,
                AdvertisingImageBytes = GetImageAsBytes(SKYSCRAPER_FILEPATH + SKYSCRAPER_FILE30),
                AdvertisingImageType = repository.FindAdvertisingImageTypeByName("SKYSCRAPER"),
                AdvertisingImageStatus = repository.FindStatusByName("LIVE"),
                Category = repository.FindCategoryByName("FINANCIAL"),
                CloudApplication = repository.GetCloudApplication(SKYSCRAPER_FILE30_CLOUDAPPLICATIONID, false),
            };
            repository.AddAdvertisingImage(ai);
            ai = new AdvertisingImage()
            {
                AdvertisingImagePhysicalFilePath = SKYSCRAPER_FILEPATH,
                AdvertisingImageFileName = SKYSCRAPER_FILE31,
                AdvertisingImageBytes = GetImageAsBytes(SKYSCRAPER_FILEPATH + SKYSCRAPER_FILE31),
                AdvertisingImageType = repository.FindAdvertisingImageTypeByName("SKYSCRAPER"),
                AdvertisingImageStatus = repository.FindStatusByName("LIVE"),
                Category = repository.FindCategoryByName("EMAIL"),
                CloudApplication = repository.GetCloudApplication(SKYSCRAPER_FILE31_CLOUDAPPLICATIONID, false),
            };
            repository.AddAdvertisingImage(ai);
            ai = new AdvertisingImage()
            {
                AdvertisingImagePhysicalFilePath = SKYSCRAPER_FILEPATH,
                AdvertisingImageFileName = SKYSCRAPER_FILE32,
                AdvertisingImageBytes = GetImageAsBytes(SKYSCRAPER_FILEPATH + SKYSCRAPER_FILE32),
                AdvertisingImageType = repository.FindAdvertisingImageTypeByName("SKYSCRAPER"),
                AdvertisingImageStatus = repository.FindStatusByName("LIVE"),
                Category = repository.FindCategoryByName("WEB CONFERENCING"),
                CloudApplication = repository.GetCloudApplication(SKYSCRAPER_FILE32_CLOUDAPPLICATIONID, false),
            };
            repository.AddAdvertisingImage(ai);



            // 4/2/2014
            ai = new AdvertisingImage()
            {
                AdvertisingImagePhysicalFilePath = SKYSCRAPER_FILEPATH,
                AdvertisingImageFileName = SKYSCRAPER_FILE33,
                AdvertisingImageBytes = GetImageAsBytes(SKYSCRAPER_FILEPATH + SKYSCRAPER_FILE33),
                AdvertisingImageType = repository.FindAdvertisingImageTypeByName("SKYSCRAPER"),
                AdvertisingImageStatus = repository.FindStatusByName("LIVE"),
                Category = repository.FindCategoryByName("COMMUNICATIONS"),
                CloudApplication = repository.GetCloudApplication(SKYSCRAPER_FILE33_CLOUDAPPLICATIONID, false),
            };
            repository.AddAdvertisingImage(ai);
            ai = new AdvertisingImage()
            {
                AdvertisingImagePhysicalFilePath = SKYSCRAPER_FILEPATH,
                AdvertisingImageFileName = SKYSCRAPER_FILE34,
                AdvertisingImageBytes = GetImageAsBytes(SKYSCRAPER_FILEPATH + SKYSCRAPER_FILE34),
                AdvertisingImageType = repository.FindAdvertisingImageTypeByName("SKYSCRAPER"),
                AdvertisingImageStatus = repository.FindStatusByName("LIVE"),
                Category = repository.FindCategoryByName("COMMUNICATIONS"),
                CloudApplication = repository.GetCloudApplication(SKYSCRAPER_FILE34_CLOUDAPPLICATIONID, false),
            };
            repository.AddAdvertisingImage(ai);
            ai = new AdvertisingImage()
            {
                AdvertisingImagePhysicalFilePath = SKYSCRAPER_FILEPATH,
                AdvertisingImageFileName = SKYSCRAPER_FILE35,
                AdvertisingImageBytes = GetImageAsBytes(SKYSCRAPER_FILEPATH + SKYSCRAPER_FILE35),
                AdvertisingImageType = repository.FindAdvertisingImageTypeByName("SKYSCRAPER"),
                AdvertisingImageStatus = repository.FindStatusByName("LIVE"),
                Category = repository.FindCategoryByName("OFFICE"),
                CloudApplication = repository.GetCloudApplication(SKYSCRAPER_FILE35_CLOUDAPPLICATIONID, false),
            };
            repository.AddAdvertisingImage(ai);
            ai = new AdvertisingImage()
            {
                AdvertisingImagePhysicalFilePath = SKYSCRAPER_FILEPATH,
                AdvertisingImageFileName = SKYSCRAPER_FILE36,
                AdvertisingImageBytes = GetImageAsBytes(SKYSCRAPER_FILEPATH + SKYSCRAPER_FILE36),
                AdvertisingImageType = repository.FindAdvertisingImageTypeByName("SKYSCRAPER"),
                AdvertisingImageStatus = repository.FindStatusByName("LIVE"),
                Category = repository.FindCategoryByName("OFFICE"),
                CloudApplication = repository.GetCloudApplication(SKYSCRAPER_FILE36_CLOUDAPPLICATIONID, false),
            };
            repository.AddAdvertisingImage(ai);
            ai = new AdvertisingImage()
            {
                AdvertisingImagePhysicalFilePath = SKYSCRAPER_FILEPATH,
                AdvertisingImageFileName = SKYSCRAPER_FILE37,
                AdvertisingImageBytes = GetImageAsBytes(SKYSCRAPER_FILEPATH + SKYSCRAPER_FILE37),
                AdvertisingImageType = repository.FindAdvertisingImageTypeByName("SKYSCRAPER"),
                AdvertisingImageStatus = repository.FindStatusByName("LIVE"),
                Category = repository.FindCategoryByName("OFFICE"),
                CloudApplication = repository.GetCloudApplication(SKYSCRAPER_FILE37_CLOUDAPPLICATIONID, false),
            };
            repository.AddAdvertisingImage(ai);
            ai = new AdvertisingImage()
            {
                AdvertisingImagePhysicalFilePath = SKYSCRAPER_FILEPATH,
                AdvertisingImageFileName = SKYSCRAPER_FILE38,
                AdvertisingImageBytes = GetImageAsBytes(SKYSCRAPER_FILEPATH + SKYSCRAPER_FILE38),
                AdvertisingImageType = repository.FindAdvertisingImageTypeByName("SKYSCRAPER"),
                AdvertisingImageStatus = repository.FindStatusByName("SUSPENDED"),
                Category = repository.FindCategoryByName("PROJECT MANAGEMENT"),
                //CloudApplication = repository.GetCloudApplication(SKYSCRAPER_FILE38_CLOUDAPPLICATIONID, false),
            };
            repository.AddAdvertisingImage(ai);
            ai = new AdvertisingImage()
            {
                AdvertisingImagePhysicalFilePath = SKYSCRAPER_FILEPATH,
                AdvertisingImageFileName = SKYSCRAPER_FILE39,
                AdvertisingImageBytes = GetImageAsBytes(SKYSCRAPER_FILEPATH + SKYSCRAPER_FILE39),
                AdvertisingImageType = repository.FindAdvertisingImageTypeByName("SKYSCRAPER"),
                AdvertisingImageStatus = repository.FindStatusByName("SUSPENDED"),
                Category = repository.FindCategoryByName("FINANCIAL"),
                CloudApplication = repository.GetCloudApplication(SKYSCRAPER_FILE39_CLOUDAPPLICATIONID, false),
            };
            repository.AddAdvertisingImage(ai);
            ai = new AdvertisingImage()
            {
                AdvertisingImagePhysicalFilePath = SKYSCRAPER_FILEPATH,
                AdvertisingImageFileName = SKYSCRAPER_FILE40,
                AdvertisingImageBytes = GetImageAsBytes(SKYSCRAPER_FILEPATH + SKYSCRAPER_FILE40),
                AdvertisingImageType = repository.FindAdvertisingImageTypeByName("SKYSCRAPER"),
                AdvertisingImageStatus = repository.FindStatusByName("LIVE"),
                Category = repository.FindCategoryByName("WEB CONFERENCING"),
                CloudApplication = repository.GetCloudApplication(SKYSCRAPER_FILE40_CLOUDAPPLICATIONID, false),
            };
            repository.AddAdvertisingImage(ai);
            ai = new AdvertisingImage()
            {
                AdvertisingImagePhysicalFilePath = SKYSCRAPER_FILEPATH,
                AdvertisingImageFileName = SKYSCRAPER_FILE41,
                AdvertisingImageBytes = GetImageAsBytes(SKYSCRAPER_FILEPATH + SKYSCRAPER_FILE41),
                AdvertisingImageType = repository.FindAdvertisingImageTypeByName("SKYSCRAPER"),
                AdvertisingImageStatus = repository.FindStatusByName("LIVE"),
                Category = repository.FindCategoryByName("WEB CONFERENCING"),
                CloudApplication = repository.GetCloudApplication(SKYSCRAPER_FILE41_CLOUDAPPLICATIONID, false),
            };
            repository.AddAdvertisingImage(ai);
            ai = new AdvertisingImage()
            {
                AdvertisingImagePhysicalFilePath = SKYSCRAPER_FILEPATH,
                AdvertisingImageFileName = SKYSCRAPER_FILE42,
                AdvertisingImageBytes = GetImageAsBytes(SKYSCRAPER_FILEPATH + SKYSCRAPER_FILE42),
                AdvertisingImageType = repository.FindAdvertisingImageTypeByName("SKYSCRAPER"),
                AdvertisingImageStatus = repository.FindStatusByName("LIVE"),
                Category = repository.FindCategoryByName("SECURITY"),
                CloudApplication = repository.GetCloudApplication(SKYSCRAPER_FILE42_CLOUDAPPLICATIONID, false),
            };
            repository.AddAdvertisingImage(ai);
            ai = new AdvertisingImage()
            {
                AdvertisingImagePhysicalFilePath = SKYSCRAPER_FILEPATH,
                AdvertisingImageFileName = SKYSCRAPER_FILE43,
                AdvertisingImageBytes = GetImageAsBytes(SKYSCRAPER_FILEPATH + SKYSCRAPER_FILE43),
                AdvertisingImageType = repository.FindAdvertisingImageTypeByName("SKYSCRAPER"),
                AdvertisingImageStatus = repository.FindStatusByName("LIVE"),
                Category = repository.FindCategoryByName("SECURITY"),
                CloudApplication = repository.GetCloudApplication(SKYSCRAPER_FILE43_CLOUDAPPLICATIONID, false),
            };
            repository.AddAdvertisingImage(ai);
            ai = new AdvertisingImage()
            {
                AdvertisingImagePhysicalFilePath = SKYSCRAPER_FILEPATH,
                AdvertisingImageFileName = SKYSCRAPER_FILE44,
                AdvertisingImageBytes = GetImageAsBytes(SKYSCRAPER_FILEPATH + SKYSCRAPER_FILE44),
                AdvertisingImageType = repository.FindAdvertisingImageTypeByName("SKYSCRAPER"),
                AdvertisingImageStatus = repository.FindStatusByName("LIVE"),
                Category = repository.FindCategoryByName("CRM"),
                CloudApplication = repository.GetCloudApplication(SKYSCRAPER_FILE44_CLOUDAPPLICATIONID, false),
            };
            repository.AddAdvertisingImage(ai);
            ai = new AdvertisingImage()
            {
                AdvertisingImagePhysicalFilePath = SKYSCRAPER_FILEPATH,
                AdvertisingImageFileName = SKYSCRAPER_FILE45,
                AdvertisingImageBytes = GetImageAsBytes(SKYSCRAPER_FILEPATH + SKYSCRAPER_FILE45),
                AdvertisingImageType = repository.FindAdvertisingImageTypeByName("SKYSCRAPER"),
                AdvertisingImageStatus = repository.FindStatusByName("SUSPENDED"),
                Category = repository.FindCategoryByName("FINANCIAL"),
                CloudApplication = repository.GetCloudApplication(SKYSCRAPER_FILE45_CLOUDAPPLICATIONID, false),
            };
            repository.AddAdvertisingImage(ai);

            // 13/5/2014
            ai = new AdvertisingImage()
            {
                AdvertisingImagePhysicalFilePath = SKYSCRAPER_FILEPATH,
                AdvertisingImageFileName = SKYSCRAPER_FILE46,
                AdvertisingImageBytes = GetImageAsBytes(SKYSCRAPER_FILEPATH + SKYSCRAPER_FILE46),
                AdvertisingImageType = repository.FindAdvertisingImageTypeByName("SKYSCRAPER"),
                AdvertisingImageStatus = repository.FindStatusByName("LIVE"),
                Category = repository.FindCategoryByName("COMMUNICATIONS"),
                CloudApplication = repository.GetCloudApplication(SKYSCRAPER_FILE46_CLOUDAPPLICATIONID, false),
            };
            repository.AddAdvertisingImage(ai);

            //9/7/2014
            ai = new AdvertisingImage()
            {
                AdvertisingImagePhysicalFilePath = SKYSCRAPER_FILEPATH,
                AdvertisingImageFileName = SKYSCRAPER_FILE47,
                AdvertisingImageBytes = GetImageAsBytes(SKYSCRAPER_FILEPATH + SKYSCRAPER_FILE47),
                AdvertisingImageType = repository.FindAdvertisingImageTypeByName("SKYSCRAPER"),
                AdvertisingImageStatus = repository.FindStatusByName("SUSPENDED"),
                Category = repository.FindCategoryByName("FINANCIAL"),
                CloudApplication = repository.GetCloudApplication(SKYSCRAPER_FILE47_CLOUDAPPLICATIONID, false),
            };
            repository.AddAdvertisingImage(ai);

            //30/11/2014
            ai = new AdvertisingImage()
            {
                AdvertisingImagePhysicalFilePath = SKYSCRAPER_FILEPATH,
                AdvertisingImageFileName = SKYSCRAPER_FILE48,
                AdvertisingImageBytes = GetImageAsBytes(SKYSCRAPER_FILEPATH + SKYSCRAPER_FILE48),
                AdvertisingImageType = repository.FindAdvertisingImageTypeByName("SKYSCRAPER"),
                AdvertisingImageStatus = repository.FindStatusByName("LIVE"),
                Category = repository.FindCategoryByName("FINANCIAL"),
                CloudApplication = repository.GetCloudApplication(SKYSCRAPER_FILE48_CLOUDAPPLICATIONID, false),
            };
            repository.AddAdvertisingImage(ai);
            #endregion

            return retVal;
        }

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

    }
}
