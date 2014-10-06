namespace CompareCloudware.Web.Controllers
{
    using CompareCloudware.Domain.Models;
    using System;
    using System.IO;
    using System.Linq;
    using System.Web.Mvc;

    public class PdfResult : ActionResult
    {
        private byte[] pdfBytes;

        public PdfResult(ThumbnailDocument td)
        {
            this.pdfBytes = File.ReadAllBytes(td.ThumbnailDocumentPhysicalFilePath + td.ThumbnailDocumentFileName);
        }

        public override void ExecuteResult(ControllerContext context)
        {
            context.HttpContext.Response.Clear();
            context.HttpContext.Response.ContentType = "application/pdf";
            context.HttpContext.Response.AddHeader("content-disposition", "inline;");
            context.HttpContext.Response.OutputStream.Write(this.pdfBytes.ToArray<byte>(), 0, this.pdfBytes.ToArray<byte>().Length);
            context.HttpContext.Response.End();
        }
    }
}

