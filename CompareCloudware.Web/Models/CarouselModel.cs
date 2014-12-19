namespace CompareCloudware.Web.Models
{
    using CompareCloudware.Web;
    using System;
    using System.Runtime.CompilerServices;
    using System.Configuration;
    using CompareCloudware.Web.Helpers;
    using CompareCloudware.Domain.Contracts.Repositories;

    public class CarouselModel : BaseModel
    {
        public CarouselModel()
        {
        }

        public CarouselModel(ICustomSession session, ICompareCloudwareRepository repository, CarouselType carouselType)
        {
            base.CustomSession = session;

            this.URLSuffix1 = "CloudApplication?cloudApplicationID=";
            this.SelectedCategoryID = session.SelectedCategoryID;
            this.CarouselType = carouselType;
            int carouselDefaultDisplayTime = int.Parse(ConfigurationManager.AppSettings["CarouselDefaultDisplayTime"].ToString());

            DisplayTime1 = carouselDefaultDisplayTime;
            DisplayTime2 = carouselDefaultDisplayTime;
            DisplayTime3 = carouselDefaultDisplayTime;
            DisplayTime4 = carouselDefaultDisplayTime;
            DisplayTime5 = carouselDefaultDisplayTime;

            switch (carouselType)
            {
                case Helpers.CarouselType.Home:
                case Helpers.CarouselType.Category:

                    #region switch
                    switch (this.SelectedCategoryID ?? 0)
                    {
                        case 0:
                            Image1 = ConfigurationManager.AppSettings["CarouselHomeImage1"];
                            Image2 = ConfigurationManager.AppSettings["CarouselHomeImage2"];
                            Image3 = ConfigurationManager.AppSettings["CarouselHomeImage3"];
                            Image4 = ConfigurationManager.AppSettings["CarouselHomeImage4"];
                            Image5 = ConfigurationManager.AppSettings["CarouselHomeImage5"];
                            ID1 = ConfigurationManager.AppSettings["CarouselHomeID1"];
                            ID2 = ConfigurationManager.AppSettings["CarouselHomeID2"];
                            ID3 = ConfigurationManager.AppSettings["CarouselHomeID3"];
                            ID4 = ConfigurationManager.AppSettings["CarouselHomeID4"];
                            ID5 = ConfigurationManager.AppSettings["CarouselHomeID5"];
                            DisplayTime1 = ConfigurationManager.AppSettings["CarouselHomeImage1DisplayTime"] != null ? int.Parse(ConfigurationManager.AppSettings["CarouselHomeImage1DisplayTime"].ToString()) : carouselDefaultDisplayTime;
                            DisplayTime2 = ConfigurationManager.AppSettings["CarouselHomeImage2DisplayTime"] != null ? int.Parse(ConfigurationManager.AppSettings["CarouselHomeImage2DisplayTime"].ToString()) : carouselDefaultDisplayTime;
                            DisplayTime3 = ConfigurationManager.AppSettings["CarouselHomeImage3DisplayTime"] != null ? int.Parse(ConfigurationManager.AppSettings["CarouselHomeImage3DisplayTime"].ToString()) : carouselDefaultDisplayTime;
                            DisplayTime4 = ConfigurationManager.AppSettings["CarouselHomeImage4DisplayTime"] != null ? int.Parse(ConfigurationManager.AppSettings["CarouselHomeImage4DisplayTime"].ToString()) : carouselDefaultDisplayTime;
                            DisplayTime5 = ConfigurationManager.AppSettings["CarouselHomeImage5DisplayTime"] != null ? int.Parse(ConfigurationManager.AppSettings["CarouselHomeImage5DisplayTime"].ToString()) : carouselDefaultDisplayTime;
                            break;
                        case 1:
                        case 19:
                            Image1 = ConfigurationManager.AppSettings["CarouselCategoryPhone1"];
                            Image2 = ConfigurationManager.AppSettings["CarouselCategoryPhone2"];
                            Image3 = ConfigurationManager.AppSettings["CarouselCategoryPhone3"];
                            Image4 = ConfigurationManager.AppSettings["CarouselCategoryPhone4"];
                            Image5 = ConfigurationManager.AppSettings["CarouselCategoryPhone5"];
                            ID1 = ConfigurationManager.AppSettings["CarouselCategoryPhoneID1"];
                            ID2 = ConfigurationManager.AppSettings["CarouselCategoryPhoneID2"];
                            ID3 = ConfigurationManager.AppSettings["CarouselCategoryPhoneID3"];
                            ID4 = ConfigurationManager.AppSettings["CarouselCategoryPhoneID4"];
                            ID5 = ConfigurationManager.AppSettings["CarouselCategoryPhoneID5"];
                            break;
                        case 2:
                            Image1 = ConfigurationManager.AppSettings["CarouselCategoryCRM1"];
                            Image2 = ConfigurationManager.AppSettings["CarouselCategoryCRM2"];
                            Image3 = ConfigurationManager.AppSettings["CarouselCategoryCRM3"];
                            Image4 = ConfigurationManager.AppSettings["CarouselCategoryCRM4"];
                            Image5 = ConfigurationManager.AppSettings["CarouselCategoryCRM5"];
                            ID1 = ConfigurationManager.AppSettings["CarouselCategoryCRMID1"];
                            ID2 = ConfigurationManager.AppSettings["CarouselCategoryCRMID2"];
                            ID3 = ConfigurationManager.AppSettings["CarouselCategoryCRMID3"];
                            ID4 = ConfigurationManager.AppSettings["CarouselCategoryCRMID4"];
                            ID5 = ConfigurationManager.AppSettings["CarouselCategoryCRMID5"];
                            break;
                        case 3:
                            Image1 = ConfigurationManager.AppSettings["CarouselCategoryConferencing1"];
                            Image2 = ConfigurationManager.AppSettings["CarouselCategoryConferencing2"];
                            Image3 = ConfigurationManager.AppSettings["CarouselCategoryConferencing3"];
                            Image4 = ConfigurationManager.AppSettings["CarouselCategoryConferencing4"];
                            Image5 = ConfigurationManager.AppSettings["CarouselCategoryConferencing5"];
                            ID1 = ConfigurationManager.AppSettings["CarouselCategoryConferencingID1"];
                            ID2 = ConfigurationManager.AppSettings["CarouselCategoryConferencingID2"];
                            ID3 = ConfigurationManager.AppSettings["CarouselCategoryConferencingID3"];
                            ID4 = ConfigurationManager.AppSettings["CarouselCategoryConferencingID4"];
                            ID5 = ConfigurationManager.AppSettings["CarouselCategoryConferencingID5"];
                            break;
                        case 4:
                            Image1 = ConfigurationManager.AppSettings["CarouselCategoryEMail1"];
                            Image2 = ConfigurationManager.AppSettings["CarouselCategoryEMail2"];
                            Image3 = ConfigurationManager.AppSettings["CarouselCategoryEMail3"];
                            Image4 = ConfigurationManager.AppSettings["CarouselCategoryEMail4"];
                            Image5 = ConfigurationManager.AppSettings["CarouselCategoryEMail5"];
                            ID1 = ConfigurationManager.AppSettings["CarouselCategoryEMailID1"];
                            ID2 = ConfigurationManager.AppSettings["CarouselCategoryEMailID2"];
                            ID3 = ConfigurationManager.AppSettings["CarouselCategoryEMailID3"];
                            ID4 = ConfigurationManager.AppSettings["CarouselCategoryEMailID4"];
                            ID5 = ConfigurationManager.AppSettings["CarouselCategoryEMailID5"];
                            break;
                        case 5:
                            Image1 = ConfigurationManager.AppSettings["CarouselCategoryOffice1"];
                            Image2 = ConfigurationManager.AppSettings["CarouselCategoryOffice2"];
                            Image3 = ConfigurationManager.AppSettings["CarouselCategoryOffice3"];
                            Image4 = ConfigurationManager.AppSettings["CarouselCategoryOffice4"];
                            Image5 = ConfigurationManager.AppSettings["CarouselCategoryOffice5"];
                            ID1 = ConfigurationManager.AppSettings["CarouselCategoryOfficeID1"];
                            ID2 = ConfigurationManager.AppSettings["CarouselCategoryOfficeID2"];
                            ID3 = ConfigurationManager.AppSettings["CarouselCategoryOfficeID3"];
                            ID4 = ConfigurationManager.AppSettings["CarouselCategoryOfficeID4"];
                            ID5 = ConfigurationManager.AppSettings["CarouselCategoryOfficeID5"];
                            break;
                        case 6:
                            Image1 = ConfigurationManager.AppSettings["CarouselCategoryStorageAndBackup1"];
                            Image2 = ConfigurationManager.AppSettings["CarouselCategoryStorageAndBackup2"];
                            Image3 = ConfigurationManager.AppSettings["CarouselCategoryStorageAndBackup3"];
                            Image4 = ConfigurationManager.AppSettings["CarouselCategoryStorageAndBackup4"];
                            Image5 = ConfigurationManager.AppSettings["CarouselCategoryStorageAndBackup5"];
                            ID1 = ConfigurationManager.AppSettings["CarouselCategoryStorageAndBackupID1"];
                            ID2 = ConfigurationManager.AppSettings["CarouselCategoryStorageAndBackupID2"];
                            ID3 = ConfigurationManager.AppSettings["CarouselCategoryStorageAndBackupID3"];
                            ID4 = ConfigurationManager.AppSettings["CarouselCategoryStorageAndBackupID4"];
                            ID5 = ConfigurationManager.AppSettings["CarouselCategoryStorageAndBackupID5"];
                            break;
                        case 7:
                            Image1 = ConfigurationManager.AppSettings["CarouselCategoryProjectManagement1"];
                            Image2 = ConfigurationManager.AppSettings["CarouselCategoryProjectManagement2"];
                            Image3 = ConfigurationManager.AppSettings["CarouselCategoryProjectManagement3"];
                            Image4 = ConfigurationManager.AppSettings["CarouselCategoryProjectManagement4"];
                            Image5 = ConfigurationManager.AppSettings["CarouselCategoryProjectManagement5"];
                            ID1 = ConfigurationManager.AppSettings["CarouselCategoryProjectManagementID1"];
                            ID2 = ConfigurationManager.AppSettings["CarouselCategoryProjectManagementID2"];
                            ID3 = ConfigurationManager.AppSettings["CarouselCategoryProjectManagementID3"];
                            ID4 = ConfigurationManager.AppSettings["CarouselCategoryProjectManagementID4"];
                            ID5 = ConfigurationManager.AppSettings["CarouselCategoryProjectManagementID5"];
                            break;
                        case 8:
                            Image1 = ConfigurationManager.AppSettings["CarouselCategoryFinancial1"];
                            Image2 = ConfigurationManager.AppSettings["CarouselCategoryFinancial2"];
                            Image3 = ConfigurationManager.AppSettings["CarouselCategoryFinancial3"];
                            Image4 = ConfigurationManager.AppSettings["CarouselCategoryFinancial4"];
                            Image5 = ConfigurationManager.AppSettings["CarouselCategoryFinancial5"];
                            ID1 = ConfigurationManager.AppSettings["CarouselCategoryFinancialID1"];
                            ID2 = ConfigurationManager.AppSettings["CarouselCategoryFinancialID2"];
                            ID3 = ConfigurationManager.AppSettings["CarouselCategoryFinancialID3"];
                            ID4 = ConfigurationManager.AppSettings["CarouselCategoryFinancialID4"];
                            ID5 = ConfigurationManager.AppSettings["CarouselCategoryFinancialID5"];
                            break;
                        case 9:
                            Image1 = ConfigurationManager.AppSettings["CarouselCategorySecurity1"];
                            Image2 = ConfigurationManager.AppSettings["CarouselCategorySecurity2"];
                            Image3 = ConfigurationManager.AppSettings["CarouselCategorySecurity3"];
                            Image4 = ConfigurationManager.AppSettings["CarouselCategorySecurity4"];
                            Image5 = ConfigurationManager.AppSettings["CarouselCategorySecurity5"];
                            ID1 = ConfigurationManager.AppSettings["CarouselCategorySecurityID1"];
                            ID2 = ConfigurationManager.AppSettings["CarouselCategorySecurityID2"];
                            ID3 = ConfigurationManager.AppSettings["CarouselCategorySecurityID3"];
                            ID4 = ConfigurationManager.AppSettings["CarouselCategorySecurityID4"];
                            ID5 = ConfigurationManager.AppSettings["CarouselCategorySecurityID5"];
                            break;
                        case 10:
                            Image1 = ConfigurationManager.AppSettings["CarouselCategoryMarketing1"];
                            Image2 = ConfigurationManager.AppSettings["CarouselCategoryMarketing2"];
                            Image3 = ConfigurationManager.AppSettings["CarouselCategoryMarketing3"];
                            Image4 = ConfigurationManager.AppSettings["CarouselCategoryMarketing4"];
                            Image5 = ConfigurationManager.AppSettings["CarouselCategoryMarketing5"];
                            ID1 = ConfigurationManager.AppSettings["CarouselCategoryMarketingID1"];
                            ID2 = ConfigurationManager.AppSettings["CarouselCategoryMarketingID2"];
                            ID3 = ConfigurationManager.AppSettings["CarouselCategoryMarketingID3"];
                            ID4 = ConfigurationManager.AppSettings["CarouselCategoryMarketingID4"];
                            ID5 = ConfigurationManager.AppSettings["CarouselCategoryMarketingID5"];
                            break;
                        case 11:
                            Image1 = ConfigurationManager.AppSettings["CarouselCategoryWebsite1"];
                            Image2 = ConfigurationManager.AppSettings["CarouselCategoryWebsite2"];
                            Image3 = ConfigurationManager.AppSettings["CarouselCategoryWebsite3"];
                            Image4 = ConfigurationManager.AppSettings["CarouselCategoryWebsite4"];
                            Image5 = ConfigurationManager.AppSettings["CarouselCategoryWebsite5"];
                            ID1 = ConfigurationManager.AppSettings["CarouselCategoryWebsiteID1"];
                            ID2 = ConfigurationManager.AppSettings["CarouselCategoryWebsiteID2"];
                            ID3 = ConfigurationManager.AppSettings["CarouselCategoryWebsiteID3"];
                            ID4 = ConfigurationManager.AppSettings["CarouselCategoryWebsiteID4"];
                            ID5 = ConfigurationManager.AppSettings["CarouselCategoryWebsiteID5"];
                            break;
                        case 12:
                            Image1 = ConfigurationManager.AppSettings["CarouselCategoryCreative1"];
                            Image2 = ConfigurationManager.AppSettings["CarouselCategoryCreative2"];
                            Image3 = ConfigurationManager.AppSettings["CarouselCategoryCreative3"];
                            Image4 = ConfigurationManager.AppSettings["CarouselCategoryCreative4"];
                            Image5 = ConfigurationManager.AppSettings["CarouselCategoryCreative5"];
                            ID1 = ConfigurationManager.AppSettings["CarouselCategoryCreativeID1"];
                            ID2 = ConfigurationManager.AppSettings["CarouselCategoryCreativeID2"];
                            ID3 = ConfigurationManager.AppSettings["CarouselCategoryCreativeID3"];
                            ID4 = ConfigurationManager.AppSettings["CarouselCategoryCreativeID4"];
                            ID5 = ConfigurationManager.AppSettings["CarouselCategoryCreativeID5"];
                            break;
                        case 13:
                            Image1 = ConfigurationManager.AppSettings["CarouselCategoryIntelligenceAndReporting1"];
                            Image2 = ConfigurationManager.AppSettings["CarouselCategoryIntelligenceAndReporting2"];
                            Image3 = ConfigurationManager.AppSettings["CarouselCategoryIntelligenceAndReporting3"];
                            Image4 = ConfigurationManager.AppSettings["CarouselCategoryIntelligenceAndReporting4"];
                            Image5 = ConfigurationManager.AppSettings["CarouselCategoryIntelligenceAndReporting5"];
                            ID1 = ConfigurationManager.AppSettings["CarouselCategoryIntelligenceAndReportingID1"];
                            ID2 = ConfigurationManager.AppSettings["CarouselCategoryIntelligenceAndReportingID2"];
                            ID3 = ConfigurationManager.AppSettings["CarouselCategoryIntelligenceAndReportingID3"];
                            ID4 = ConfigurationManager.AppSettings["CarouselCategoryIntelligenceAndReportingID4"];
                            ID5 = ConfigurationManager.AppSettings["CarouselCategoryIntelligenceAndReportingID5"];
                            break;
                        case 14:
                            Image1 = ConfigurationManager.AppSettings["CarouselCategoryHosting1"];
                            Image2 = ConfigurationManager.AppSettings["CarouselCategoryHosting2"];
                            Image3 = ConfigurationManager.AppSettings["CarouselCategoryHosting3"];
                            Image4 = ConfigurationManager.AppSettings["CarouselCategoryHosting4"];
                            Image5 = ConfigurationManager.AppSettings["CarouselCategoryHosting5"];
                            ID1 = ConfigurationManager.AppSettings["CarouselCategoryHostingID1"];
                            ID2 = ConfigurationManager.AppSettings["CarouselCategoryHostingID2"];
                            ID3 = ConfigurationManager.AppSettings["CarouselCategoryHostingID3"];
                            ID4 = ConfigurationManager.AppSettings["CarouselCategoryHostingID4"];
                            ID5 = ConfigurationManager.AppSettings["CarouselCategoryHostingID5"];
                            break;
                        case 15:
                            Image1 = ConfigurationManager.AppSettings["CarouselCategoryHR1"];
                            Image2 = ConfigurationManager.AppSettings["CarouselCategoryHR2"];
                            Image3 = ConfigurationManager.AppSettings["CarouselCategoryHR3"];
                            Image4 = ConfigurationManager.AppSettings["CarouselCategoryHR4"];
                            Image5 = ConfigurationManager.AppSettings["CarouselCategoryHR5"];
                            ID1 = ConfigurationManager.AppSettings["CarouselCategoryHRID1"];
                            ID2 = ConfigurationManager.AppSettings["CarouselCategoryHRID2"];
                            ID3 = ConfigurationManager.AppSettings["CarouselCategoryHRID3"];
                            ID4 = ConfigurationManager.AppSettings["CarouselCategoryHRID4"];
                            ID5 = ConfigurationManager.AppSettings["CarouselCategoryHRID5"];
                            break;
                        case 16:
                            Image1 = ConfigurationManager.AppSettings["CarouselCategoryPayments1"];
                            Image2 = ConfigurationManager.AppSettings["CarouselCategoryPayments2"];
                            Image3 = ConfigurationManager.AppSettings["CarouselCategoryPayments3"];
                            Image4 = ConfigurationManager.AppSettings["CarouselCategoryPayments4"];
                            Image5 = ConfigurationManager.AppSettings["CarouselCategoryPayments5"];
                            ID1 = ConfigurationManager.AppSettings["CarouselCategoryPaymentsID1"];
                            ID2 = ConfigurationManager.AppSettings["CarouselCategoryPaymentsID2"];
                            ID3 = ConfigurationManager.AppSettings["CarouselCategoryPaymentsID3"];
                            ID4 = ConfigurationManager.AppSettings["CarouselCategoryPaymentsID4"];
                            ID5 = ConfigurationManager.AppSettings["CarouselCategoryPaymentsID5"];
                            break;
                        case 17:
                            Image1 = ConfigurationManager.AppSettings["CarouselCategoryBusinessAndOperations1"];
                            Image2 = ConfigurationManager.AppSettings["CarouselCategoryBusinessAndOperations2"];
                            Image3 = ConfigurationManager.AppSettings["CarouselCategoryBusinessAndOperations3"];
                            Image4 = ConfigurationManager.AppSettings["CarouselCategoryBusinessAndOperations4"];
                            Image5 = ConfigurationManager.AppSettings["CarouselCategoryBusinessAndOperations5"];
                            ID1 = ConfigurationManager.AppSettings["CarouselCategoryBusinessAndOperationsID1"];
                            ID2 = ConfigurationManager.AppSettings["CarouselCategoryBusinessAndOperationsID2"];
                            ID3 = ConfigurationManager.AppSettings["CarouselCategoryBusinessAndOperationsID3"];
                            ID4 = ConfigurationManager.AppSettings["CarouselCategoryBusinessAndOperationsID4"];
                            ID5 = ConfigurationManager.AppSettings["CarouselCategoryBusinessAndOperationsID5"];
                            break;
                        case 18:
                            Image1 = ConfigurationManager.AppSettings["CarouselCategorySales1"];
                            Image2 = ConfigurationManager.AppSettings["CarouselCategorySales2"];
                            Image3 = ConfigurationManager.AppSettings["CarouselCategorySales3"];
                            Image4 = ConfigurationManager.AppSettings["CarouselCategorySales4"];
                            Image5 = ConfigurationManager.AppSettings["CarouselCategorySales5"];
                            ID1 = ConfigurationManager.AppSettings["CarouselCategorySalesID1"];
                            ID2 = ConfigurationManager.AppSettings["CarouselCategorySalesID2"];
                            ID3 = ConfigurationManager.AppSettings["CarouselCategorySalesID3"];
                            ID4 = ConfigurationManager.AppSettings["CarouselCategorySalesID4"];
                            ID5 = ConfigurationManager.AppSettings["CarouselCategorySalesID5"];
                            break;
                    }
                    #endregion
                    break;
                case Helpers.CarouselType.Social:
                            Image1 = ConfigurationManager.AppSettings["CarouselSocialImage1"];
                            Image2 = ConfigurationManager.AppSettings["CarouselSocialImage2"];
                            Image3 = ConfigurationManager.AppSettings["CarouselSocialImage3"];
                            Image4 = ConfigurationManager.AppSettings["CarouselSocialImage4"];
                            Image5 = ConfigurationManager.AppSettings["CarouselSocialImage5"];
                            ID1 = ConfigurationManager.AppSettings["CarouselSocialID1"];
                            ID2 = ConfigurationManager.AppSettings["CarouselSocialID2"];
                            ID3 = ConfigurationManager.AppSettings["CarouselSocialID3"];
                            ID4 = ConfigurationManager.AppSettings["CarouselSocialID4"];
                            ID5 = ConfigurationManager.AppSettings["CarouselSocialID5"];

                    break;
            }
                if (SelectedCategoryID >= 0)
    {
    if (ID1 != "#")
    {
        //this.LinkRef1 = this.URLSuffix1 + ID1 + URLSuffix2;
        this.LinkRef1 = (carouselType == CarouselType.Home || carouselType == CarouselType.Category) ? ModelHelpers.GetShopURL(int.Parse(ID1) , repository) : ID1;
    }
    if (ID2 != "#")
    {
        //linkRef2 = URLSuffix1 + ID2 + URLSuffix2;
        this.LinkRef2 = (carouselType == CarouselType.Home || carouselType == CarouselType.Category) ? ModelHelpers.GetShopURL(int.Parse(ID2), repository) : ID2;
    }
    if (ID3 != "#")
    {
        //linkRef3 = URLSuffix1 + ID3 + URLSuffix2;
        this.LinkRef3 = (carouselType == CarouselType.Home || carouselType == CarouselType.Category) ? ModelHelpers.GetShopURL(int.Parse(ID3), repository) : ID3;
    }
    if (ID4 != "#")
    {
        //linkRef4 = URLSuffix1 + ID4 + URLSuffix2;
        this.LinkRef4 = (carouselType == CarouselType.Home || carouselType == CarouselType.Category) ? ModelHelpers.GetShopURL(int.Parse(ID4), repository) : ID4;
    }
    if ((ID5 ?? "#") != "#")
    {
        //linkRef5 = URLSuffix1 + ID5 + URLSuffix2;
        this.LinkRef5 = (carouselType == CarouselType.Home || carouselType == CarouselType.Category) ? ModelHelpers.GetShopURL(int.Parse(ID5), repository) : ID5;
    }
    }

        }
        public int? SelectedCategoryID { get; set; }

        public string Image1 { get; set; }
        public string Image2 { get; set; }
        public string Image3 { get; set; }
        public string Image4 { get; set; }
        public string Image5 { get; set; }
        public string ID1 { get; set; }
        public string ID2 { get; set; }
        public string ID3 { get; set; }
        public string ID4 { get; set; }
        public string ID5 { get; set; }
        public string URLSuffix1 { get; set; }
        public string URLSuffix2 { get; set; }
        public string LinkRef1 { get; set; }
        public string LinkRef2 { get; set; }
        public string LinkRef3 { get; set; }
        public string LinkRef4 { get; set; }
        public string LinkRef5 { get; set; }
        public int DisplayTime1 { get; set; }
        public int DisplayTime2 { get; set; }
        public int DisplayTime3 { get; set; }
        public int DisplayTime4 { get; set; }
        public int DisplayTime5 { get; set; }

        public CarouselType CarouselType { get; set; }
    }
}

