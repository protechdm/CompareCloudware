using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.IO;
using CompareCloudware.Web;
//using CompareCloudware.Web.Models;
//using CompareCloudware.Web.Controllers;
using CompareCloudware.Domain.Contracts.Repositories;
using Castle.Core.Logging;
using System.Security.AccessControl;
using System.Configuration;
using System.Web.Mvc;
using System.Web;
using System.Web.Routing;
using System.Web.Helpers;

namespace CompareCloudware.WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    [DataContract()]
    [KnownType("GetTypes")]
    //[ValidateDataAnnotationsBehavior]
    public class CompareCloudwareService : ICompareCloudwareService
    {
        readonly ICloudCompareRepository _repository;

        // this is Castle.Core.Logging.ILogger, not log4net.Core.ILogger
        public ILogger Logger { get; set; }

        private ICustomSession CustomSession { get; set; }

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
                composite.StringValue += "Suffix";
            }
            return composite;
        }


        public string SendSearchResultToRAZORAndCreatePDF(CloudApplicationModel searchResult, int pageNumber, string filePath, string fileName, bool overwriteIfExists, AdditionalOutput additionalOutput)
        {
            string retVal = "";
            string HTML;
            string htmlFileName = additionalOutput.OutputFileName;
            string serverFilePath = System.Web.Hosting.HostingEnvironment.MapPath(filePath);
            string createdFileName = null;
            //LogoPositioning logoPositioning = null;
            try
            {
                DirectoryInfo di = new DirectoryInfo(serverFilePath);
                if (!di.Exists)
                {
                    CreateFolder(serverFilePath);
                }

                HTML = this.CreateSearchResultHTML(searchResult);

                if (htmlFileName == null)
                {
                    //File.WriteAllText("c:\\gt\\wcfrazor\\wcfrazor\\output.htm", pdfHtml);
                }
                else
                {
                    File.WriteAllText(serverFilePath + htmlFileName, HTML);
                }

                if (pageNumber == 1)
                {
                    //logoPositioning = invoice.LogoPositionPage1;
                }
                if (pageNumber == 2)
                {
                    //logoPositioning = invoice.LogoPositionPage2;
                }

                if (additionalOutput.PDFEngineType == PDFEngineType.ASPPDF)
                {
                    createdFileName = CompareCloudware.WCF.PDFGenerator.CreatePdfFileUsingASPPDF(serverFilePath, fileName, overwriteIfExists, HTML, null);
                }
                //else if (additionalOutput.PDFEngineType == PDFEngineType.PDFTRON)
                //{
                //    createdFileName = Avis.Invoices.Pdf.PdfGenerator.CreatePdfFileUsingPDFTRON(serverFilePath, fileName, overwriteIfExists, HTML, logoPositioning);
                //}
                //else if (additionalOutput.PDFEngineType == PDFEngineType.EVOPDF)
                //{
                //    createdFileName = Avis.Invoices.Pdf.PdfGenerator.CreatePdfFileUsingEVOPDF(serverFilePath, fileName, overwriteIfExists, HTML, logoPositioning);
                //}

                //return pdfHtml;
                return createdFileName;

            }
            catch (Exception e)
            {
                retVal = e.Message;
            }
            return retVal;
        }

        #region CreateFolder
        public static bool CreateFolder(string folderToCreate)
        {
            bool retVal = false;
            try
            {
                List<string> folderTree = folderToCreate.Split('\\').ToList<string>();
                if (!Directory.Exists(folderToCreate))
                {
                    Directory.CreateDirectory(folderToCreate);
                }

                DirectoryInfo info = new DirectoryInfo(folderToCreate);
                DirectorySecurity security = info.GetAccessControl();


                string permissions = ConfigurationManager.AppSettings["createdFolderPermissions"];
                if (permissions != null)
                {
                    List<string> permissionsList = permissions.ToString().Split(',').ToList<string>();
                    permissionsList.ForEach(fsa =>
                    {
                        var fileSystemAccessRule = new FileSystemAccessRule(fsa, FileSystemRights.Write | FileSystemRights.ReadAndExecute, AccessControlType.Allow);
                        security.AddAccessRule(fileSystemAccessRule);
                    });

                }
                else
                {
                    var fileSystemAccessRule = new FileSystemAccessRule(@"BUILTIN\IIS_IUSRS", FileSystemRights.Write | FileSystemRights.ReadAndExecute, AccessControlType.Allow);
                    var fileSystemAccessRule2 = new FileSystemAccessRule(@"IIS AppPool\DefaultAppPool", FileSystemRights.Write | FileSystemRights.ReadAndExecute, AccessControlType.Allow);

                    security.AddAccessRule(fileSystemAccessRule);
                    security.AddAccessRule(fileSystemAccessRule2);
                }

                //security.AddAccessRule(new FileSystemAccessRule(logonName, FileSystemRights.FullControl, InheritanceFlags.ContainerInherit, PropagationFlags.None, AccessControlType.Allow));
                //security.AddAccessRule(new FileSystemAccessRule(logonName, FileSystemRights.FullControl, InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Allow)); 
                info.SetAccessControl(security);



                retVal = true;
            }
            catch (Exception e)
            {
                //throw new LoggedException(e.Message);
                retVal = false;
            }
            return retVal;
        }
        #endregion

        #region CreateSearchResultHTML
        private string CreateSearchResultHTML(CloudApplicationModel model)
        {
            string HTML;
            HomeController hc = new HomeController();
            HTML = hc.CreateSearchResultPDFHTML(model, "PrintResult");
            return HTML;
        }
        #endregion

        public string SendRAZORDataReturnHTML(CloudApplicationModel searchResult, int pageNumber, string filePath, string fileName, bool overwriteIfExists, AdditionalOutput additionalOutput)
        {
            throw new NotImplementedException();
        }





        public bool GetObjects1(SearchPageModel spm, SearchPageContainerModel spcm, SearchFiltersModel sfm, SearchResultsModel srm, CloudApplicationModel cam, SearchFiltersModelOneColumn sfsmoc, SearchFiltersModelTwoColumn sfsmtc, SearchResultsModelOneColumn srsmoc, SearchResultModelOneColumn srmoc, VendorModel vm, SetupFeeModel setfm, FreeTrialPeriodModel ftpm, BrowserModel bm, MobilePlatformModel mpm, LicenceTypeMinimumModel ltminm, LicenceTypeMaximumModel ltmaxm, SupportTypeModel stm, SupportHoursModel shm, SupportTerritoryModel sterrm, LanguageModel lm, CloudApplicationFeatureModel cafm)
        {
            throw new NotImplementedException();
        }

        public bool GetObjects2(ThumbnailDocumentModel tdm, CategoryModel cm, MinimumContractModel mcm, PaymentFrequencyModel pfm, PaymentOptionModel pom, CloudApplicationReviewModel carevm, CloudApplicationRatingModel caratm, FreeTrialBuyNowModel ftbnm, NumberOfUsersModel noum, SearchFilterModelOneColumn sfmoc, SearchFilterModelTwoColumn sfmtc, SearchResultSummaryModel srsm, CloudApplicationModel cam, FeatureModel fm, ThumbnailDocumentTypeModel tdtm, AdditionalOutput additionalOutput)
        {
            throw new NotImplementedException();
        }
    }

    #region HomeController
    //    public class HomeController<T> : Controller
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to ASP.NET MVC!";

            return View();
        }

        public ActionResult About()
        {
            return View();

        }

        #region CreateSearchResultPDFHTML
        public string CreateSearchResultPDFHTML(CloudApplicationModel model, string template)
        //public string CreateGenericInvoicePdfHtml<T>(GenericInvoice<T> invoice, string template)
        {
            string pdfHtml = string.Empty;
            //var splitInvoice = invoice as SplitInvoice;
            {

                // Extract the information we require from wizard:           
                // var reservationDetails = this.WizardWebService.GetRentalAgreementFromWizard(invoice.Bill.RaNumber);

                // Create a dummy ControllerContext using a seperate response stream so we can use the standard Razor View Engine to Render the Invoices using Razor View Templates.               
                using (var htmlStream = new System.IO.MemoryStream())
                {
                    using (var htmlWriter = new System.IO.StreamWriter(htmlStream))
                    {
                        //var httpContext = new HttpContext(new HttpRequest("PdfInvoiceTemplate", this.Request.Url.ToString(), this.Request.Url.Query.ToString()), new HttpResponse(htmlWriter));
                        string filename;
                        //filename = "test";
                        //filename = "test.htm";
                        //filename = "PdfInvoiceTemplate";
                        filename = template;
                        string url;
                        url = @"http://localhost/PDFService/";
                        //url = @"http://localhost/PDFService/PdfInvoiceTemplate.cshtml";
                        //url = @"http://localhost/PDFService/PdfInvoiceTemplate.cshtml";
                        url = @"http://localhost/CompareCloudware.WCF/";


                        //int status = 0;
                        //HttpWebResponse response = null;
                        //string result = "";
                        //Uri u = new Uri(url + filename);
                        //HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(u);
                        //response= (HttpWebResponse) request.GetResponse();         
                        //Encoding responseEncoding = Encoding.GetEncoding(response.CharacterSet);         
                        //using (StreamReader sr = new StreamReader(response.GetResponseStream(), responseEncoding))         
                        //{             
                        //    result = sr.ReadToEnd();         
                        //} 




                        System.Web.UI.Page p = new System.Web.UI.Page();
                        //p.Request.Url = new Uri(url);

                        //var httpContext = new HttpContext(new HttpRequest(filename, url, null), new HttpResponse(htmlWriter));
                        var httpContext = new HttpContext(new HttpRequest(filename, url, null), new HttpResponse(htmlWriter));
                        
                        System.Web.Routing.RouteCollection routes = new System.Web.Routing.RouteCollection();
                        routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
                        routes.Add(new Route("{controller}.mvc/{action}/{id}", new MvcRouteHandler())
                        {
                            Defaults = new RouteValueDictionary(new { action = "Index", id = "" }),

                        });

                        routes.MapRoute(
                            "Default", // Route name
                            "{controller}/{action}/{id}", // URL with parameters
                            new { controller = "Home", action = "Index", id = UrlParameter.Optional } // Parameter defaults
                        );
                        System.Web.Routing.RouteData rd = new System.Web.Routing.RouteData(routes[0], new MvcRouteHandler());
                        rd.Values.Add("Controller", "Home");
                        rd.Values.Add("Action", "Index");


                        
                        var cc = new ControllerContext(new HttpContextWrapper(httpContext), rd, this);
                        //DummyModel dm = new DummyModel();
                        //dm.TestValue = "populated dummy value";
                        //this.ViewData.Model = dm;
                        //HtmlInvoiceViewModel m = new AvisSos.Web.Models.HtmlInvoiceViewModel(splitInvoice, rc);
                        this.ViewData.Model = model;
                        IView iv = new System.Web.Mvc.RazorView(cc, "~/Views/Home/" + filename + ".cshtml", "~/Views/Home", false, null);

                        try
                        {
                            this.View(filename).ExecuteResult(cc);
                        }
                        catch (Exception e)
                        {
                            throw new Exception(e.Message);
                        }

                        htmlWriter.Flush();
                        htmlStream.Position = 0;
                        using (var htmlReader = new System.IO.StreamReader(htmlStream))
                        {
                            pdfHtml = htmlReader.ReadToEnd();
                        }
                    }

                    htmlStream.Close();
                }
            }

            return pdfHtml;
        }
        #endregion

    }
    #endregion

    #region LogoPositioning
    [DataContract]
    public class LogoPositioning
    {
        public LogoPositioning() { }

        public LogoPositioning(float x, float y)
        {
            this.X_Position = x;
            this.Y_Position = y;
        }
        [DataMember]
        public float X_Position { get; set; }
        [DataMember]
        public float Y_Position { get; set; }
        [DataMember]
        public float LogoWidthInMM { get; set; }
        [DataMember]
        public float LogoHeightInMM { get; set; }
    }
    #endregion

}
