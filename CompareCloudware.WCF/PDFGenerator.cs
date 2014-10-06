using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ASPPDFLib;

namespace CompareCloudware.WCF
{
    public static class PDFGenerator
    {
        private const string RegistrationKey = "IWezKLfzUgLJIAc213KacCXF1UAgYg6v9goKALDDvZxrFIz9sZiyaZhCMCaNmKXzSJ1bnm47UCcA";

        #region CreatePdfFileUsingASPPDF
        /// <summary>
        /// Creates a PDF file using the specified HTML, and saving the PDF to the specified file name. 
        /// </summary>
        /// <param name="fileName">
        /// The name of the pdf file that will be created, this should be an absolute file path and name.
        /// </param>
        /// <param name="html">
        /// The HTML from which the PDF will be created. Note that the AspPDF component only supports a subset
        /// of standard html.
        /// </param>
        public static string CreatePdfFileUsingASPPDF(string filePath, string fileName, bool overwriteIfExists, string html, LogoPositioning logoPosition)
        {
            // Once the html has been rendered, save it to a pdf file.
            IPdfManager objPdf = null;
            IPdfDocument objDoc = null;
            string retVal;
            try
            {
                objPdf = new PdfManager();
                objPdf.RegKey = RegistrationKey;


                int multiplyFactor = 72;
                decimal inchesToMMFactor = 25.4m;

                decimal pageWidthInches = 8.3m;
                decimal pageWidthDecimal = (pageWidthInches * multiplyFactor);
                int pageWidth = (int)System.Math.Floor(pageWidthDecimal);

                decimal pageHeightInches = 11.9m;
                decimal pageHeightDecimal = (pageHeightInches * multiplyFactor);
                int pageHeight = (int)System.Math.Floor(pageHeightDecimal);

                //aspnet says page width is 612 or 8.5"
                //aspnet says page height is 792 or 11"
                //haigh say page width is 210.566mm which is 8.29"
                //haigh say page height is 302.066mm which is 11.89"
                //1" = 25.4mm
                //so 612 equals 210.566/25.4 which is 8.29
                //and 792 equals 302.066/25.4 which is 11.89
                //A4 is 210*297 or 8.3*11.7

                //IPdfPages x = objDoc.Pages;
                string param;
                //param = "leftmargin=40";
                param = "landscape=false";
                IPdfParam p = objPdf.CreateParam(param);
                p.Add("leftmargin=0");
                p.Add("rightmargin=0");
                p.Add("bottommargin=0");
                p.Add("topmargin=0");
                p.Add("pagewidth=" + pageWidth.ToString());
                p.Add("pageheight=" + pageHeight.ToString());
                //p.Add("scale=1");

                objDoc = objPdf.CreateDocument(Type.Missing);

                //objDoc = LoadFont(objPdf, objDoc, "ocrb", filePath);
                //objDoc.ImportFromUrl(html, p, Type.Missing, Type.Missing);
                objDoc.ImportFromUrl(html);

                //logo
                //IPdfImage objImage = objDoc.OpenImage(Server.MapPath("painting.jpg"), Missing.Value);
                IPdfPage objPage = objDoc.Pages[1];

                //IPdfImage objImage = objDoc.OpenImage("c:\\gt\\wcfrazor\\wcfrazor\\avislogo.jpg", Type.Missing);

                //Bitmap logo = WcfRAZOR.GenericInvoiceResources.avislogo;
                //System.Drawing.Image i = WcfRAZOR.GenericInvoiceResources.avislogo;

                //MemoryStream ms = new MemoryStream();
                // Save to memory using the Jpeg format
                //logo.Save(ms, ImageFormat.Jpeg);

                // read to end
                //byte[] bmpBytes = ms.GetBuffer();
                //logo.Dispose();
                //ms.Close();


                //IPdfImage objImage = objDoc.OpenImageBinary(bmpBytes, Type.Missing);
                //IPdfParam objParam = objPdf.CreateParam(Type.Missing);
                //for (int i = 1; i <= 3; i++)
                //{
                //objParam["x"].Value = (objPage.Width - objImage.Width / i) / 2.0f;
                //objParam["y"].Value = objPage.Height - objImage.Height * i / 2.0f - 200;
                //objParam["ScaleX"].Value = 1.0f / i;
                //objParam["ScaleY"].Value = 1.0f / i;

                //objParam["x"].Value = logoPosition.X_Position;
                //objParam["y"].Value = logoPosition.Y_Position;
                //objParam["ScaleX"].Value = 1.0f / i;
                //objParam["ScaleY"].Value = 1.0f / i;

                //objPage.Canvas.DrawImage(objImage, objParam);
                //}

                retVal = filePath + objDoc.Save(filePath + fileName, overwriteIfExists);


            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("An error occurred saving the PDF document to disk. The message was : " + ex.Message, ex);
            }
            finally
            {
                if (objDoc != null)
                {
                    objDoc.Close();
                }
            }
            return retVal;
        }
        #endregion

    }
}