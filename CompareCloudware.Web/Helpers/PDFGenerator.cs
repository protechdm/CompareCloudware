namespace CompareCloudware.Web.Helpers
{
    using ASPPDFLib;
    using System;
    using System.Drawing;
    using System.Drawing.Imaging;
    using System.IO;

    public static class PDFGenerator
    {
        private const string RegistrationKey = "IWezKLfzUgLJIAc213KacCXF1UAgYg6v9goKALDDvZxrFIz9sZiyaZhCMCaNmKXzSJ1bnm47UCcA";

        #region CREATEPDFFILEUSINGASPPDF
        public static string CreatePdfFileUsingASPPDF(string filePath, string fileName, bool overwriteIfExists, string html, ImageBag ImageBag)
        {
            IPdfManager objPdf = null;
            IPdfDocument objDoc = null;
            string retVal;
            try
            {
                objPdf = (PdfManager) Activator.CreateInstance(Type.GetTypeFromCLSID(new Guid("88578679-272B-40C0-B1FD-C3409381A450")));
                //objPdf = new PdfManager();
                objPdf.RegKey = "IWezKLfzUgLJIAc213KacCXF1UAgYg6v9goKALDDvZxrFIz9sZiyaZhCMCaNmKXzSJ1bnm47UCcA";

                
                int multiplyFactor = 0x48;
                decimal pageWidthInches = 8.3M;
                decimal pageWidthDecimal = pageWidthInches * multiplyFactor;
                int pageWidth = (int) Math.Floor(pageWidthDecimal);
                decimal pageHeightInches = 11.9M;
                decimal pageHeightDecimal = pageHeightInches * multiplyFactor;
                int pageHeight = (int) Math.Floor(pageHeightDecimal);
                string param = "landscape=false";
                IPdfParam p = objPdf.CreateParam(param);
                p.Add("leftmargin=0");
                p.Add("rightmargin=0");
                p.Add("bottommargin=0");
                p.Add("topmargin=0");
                p.Add("pagewidth=" + pageWidth.ToString());
                p.Add("pageheight=" + pageHeight.ToString());
                p.Add("debug=true");
                objDoc = objPdf.CreateDocument(Type.Missing);

                objDoc.CreateAction("type=JavaScript", "this.CheckTextHeight()");
                string errors = objDoc.ImportFromUrl(html, p, Type.Missing, Type.Missing);
                IPdfPage objPage = objDoc.Pages[1];
                foreach (PDFImageInsert ii in ImageBag.PDFImageInserts)
                {
                    Bitmap logo = ii.ImageBitmap;
                    MemoryStream ms = new MemoryStream();
                    logo.Save(ms, ImageFormat.Jpeg);
                    byte[] bmpBytes = ms.GetBuffer();
                    logo.Dispose();
                    ms.Close();
                    IPdfImage objImage = objDoc.OpenImageBinary(bmpBytes, Type.Missing);
                    IPdfParam objParam = objPdf.CreateParam(Type.Missing);
                    objParam["x"].Value = ii.LogoPositioning.X_Position;
                    objParam["y"].Value = ii.LogoPositioning.Y_Position;
                    objPage.Canvas.DrawImage(objImage, objParam);
                }
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

        #region CREATEPDFSTREAMUSINGASPPDF
        public static MemoryStream CreatePdfStreamUsingASPPDF(string filePath, string fileName, bool overwriteIfExists, string html, ImageBag ImageBag)
        {
            IPdfManager objPdf = null;
            IPdfDocument objDoc = null;
            MemoryStream retVal;
            try
            {
                //V1
                //objPdf = (PdfManager)Activator.CreateInstance(Type.GetTypeFromCLSID(new Guid("88578679-272B-40C0-B1FD-C3409381A450")));
                //V2 64 bit
                //objPdf = (PdfManager)Activator.CreateInstance(Type.GetTypeFromCLSID(new Guid("414FEE4B-2879-4090-957E-423567FFCFC6")));
                //V2 32 bit
                //objPdf = (PdfManager)Activator.CreateInstance(Type.GetTypeFromCLSID(new Guid("414FEE4B-2879-4090-957E-423567FFCFC6")));
                objPdf = new PdfManager();
                objPdf.RegKey = "IWezKLfzUgLJIAc213KacCXF1UAgYg6v9goKALDDvZxrFIz9sZiyaZhCMCaNmKXzSJ1bnm47UCcA";
                int multiplyFactor = 0x48;
                decimal pageWidthInches = 8.3M;
                decimal pageWidthDecimal = pageWidthInches * multiplyFactor;
                int pageWidth = (int)Math.Floor(pageWidthDecimal);
                decimal pageHeightInches = 11.9M;
                decimal pageHeightDecimal = pageHeightInches * multiplyFactor;
                int pageHeight = (int)Math.Floor(pageHeightDecimal);
                string param = "landscape=false";
                IPdfParam p = objPdf.CreateParam(param);
                p.Add("leftmargin=25");
                p.Add("rightmargin=25");
                p.Add("bottommargin=25");
                p.Add("topmargin=25");
                p.Add("pagewidth=" + pageWidth.ToString());
                p.Add("pageheight=" + pageHeight.ToString());
                p.Add("debug=true");
                p.Add("hyperlinks=true");
                objDoc = objPdf.CreateDocument(Type.Missing);


                //IPdfAction action = objDoc.CreateAction("type=JavaScript", "this.print(true)");
                
                string errors = objDoc.ImportFromUrl(html, p, Type.Missing, Type.Missing);
                IPdfPage objPage = objDoc.Pages[1];
                foreach (PDFImageInsert ii in ImageBag.PDFImageInserts)
                {
                    Bitmap logo = ii.ImageBitmap;
                    MemoryStream ms = new MemoryStream();
                    logo.Save(ms, ImageFormat.Jpeg);
                    byte[] bmpBytes = ms.GetBuffer();
                    logo.Dispose();
                    ms.Close();
                    IPdfImage objImage = objDoc.OpenImageBinary(bmpBytes, Type.Missing);
                    IPdfParam objParam = objPdf.CreateParam(Type.Missing);
                    objParam["x"].Value = ii.LogoPositioning.X_Position;
                    objParam["y"].Value = ii.LogoPositioning.Y_Position;
                    objPage.Canvas.DrawImage(objImage, objParam);
                }
                //retVal = filePath + objDoc.Save(filePath + fileName, overwriteIfExists);
                byte[] stream = objDoc.SaveToMemory();
                retVal = new MemoryStream(stream);
                retVal.Read(stream,0,stream.Length);

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

        #region SendHTMLStringAndReturnPDFStream
        public static MemoryStream SendHTMLStringAndReturnPDFStream(string HTML, int pageNumber, string filePath, string fileName, bool overwriteIfExists, AdditionalOutput additionalOutput)
        {
            string retVal = "";
            string htmlFileName = additionalOutput.OutputFileName;
            string serverFilePath = filePath != null ? System.Web.Hosting.HostingEnvironment.MapPath(filePath) : null;
            //string createdFileName = null;
            MemoryStream createdStream = null;
            //LogoPositioning logoPositioning = null;
            try
            {
                ImageBag searchResultImages = new ImageBag();
                PDFImageInsert ii;
                ii = new PDFImageInsert();
                //ii.ImageBitmap = CompareCloudware.Web.App_LocalResources.Images.CCW_Logo_Top;
                ii.LogoPositioning.X_Position = 10;
                ii.LogoPositioning.Y_Position = 10;
                //searchResultImages.PDFImageInserts.Add(ii);

                if (filePath != null)
                {
                    DirectoryInfo di = new DirectoryInfo(serverFilePath);
                    if (!di.Exists)
                    {
                        try
                        {
                            CompareCloudwareService.CreateFolder(serverFilePath);
                        }
                        catch (Exception e)
                        {
                            //Logger.Fatal("Tried to create the folder:" + serverFilePath + ". The error message was:" + e.Message + ".");
                            throw new Exception("Tried to create the folder:" + serverFilePath + ". The error message was:" + e.Message + ".");
                        }
                    }
                }

                if (htmlFileName == null)
                {
                    //File.WriteAllText("c:\\gt\\wcfrazor\\wcfrazor\\output.htm", pdfHtml);
                }
                else
                {
                    try
                    {
                        System.IO.File.WriteAllText(serverFilePath + htmlFileName, HTML);
                    }
                    catch (Exception e)
                    {
                        //Logger.Fatal("Tried to write the file:" + htmlFileName + " to the folder:" + serverFilePath + ". The error message was:" + e.Message + ".");
                        throw new Exception("Tried to write the file:" + htmlFileName + " to the folder:" + serverFilePath + ". The error message was:" + e.Message + ".");
                    }
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
                    createdStream = PDFGenerator.CreatePdfStreamUsingASPPDF(serverFilePath, fileName, overwriteIfExists, HTML, searchResultImages);
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
                return createdStream;

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            //return createdStream;
        }
        #endregion

    }
}

