namespace CompareCloudware.Web.Models
{
    using System;
    using System.Runtime.CompilerServices;

    public class ThumbnailDocumentModel
    {
        public string ThumbnailDocumentFileName { get; set; }

        public int ThumbnailDocumentID { get; set; }

        public string ThumbnailDocumentPhysicalFilePath { get; set; }

        public string ThumbnailDocumentTitle { get; set; }

        public ThumbnailDocumentTypeModel ThumbnailDocumentType { get; set; }

        public string ThumbnailDocumentURL { get; set; }

        public byte[] ThumbnailImage { get; set; }
    }
}

