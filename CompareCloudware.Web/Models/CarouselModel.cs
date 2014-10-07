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
                            Image1 = ConfigurationManager.AppSettings["CarouselCategoryCustomerManagement1"];
                            Image2 = ConfigurationManager.AppSettings["CarouselCategoryCustomerManagement2"];
                            Image3 = ConfigurationManager.AppSettings["CarouselCategoryCustomerManagement3"];
                            Image4 = ConfigurationManager.AppSettings["CarouselCategoryCustomerManagement4"];
                            Image5 = ConfigurationManager.AppSettings["CarouselCategoryCustomerManagement5"];
                            ID1 = ConfigurationManager.AppSettings["CarouselCategoryCustomerManagementID1"];
                            ID2 = ConfigurationManager.AppSettings["CarouselCategoryCustomerManagementID2"];
                            ID3 = ConfigurationManager.AppSettings["CarouselCategoryCustomerManagementID3"];
                            ID4 = ConfigurationManager.AppSettings["CarouselCategoryCustomerManagementID4"];
                            ID5 = ConfigurationManager.AppSettings["CarouselCategoryCustomerManagementID5"];
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

        public CarouselType CarouselType { get; set; }
    }
}

