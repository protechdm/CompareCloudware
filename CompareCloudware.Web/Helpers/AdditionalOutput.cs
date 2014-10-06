namespace CompareCloudware.Web.Helpers
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;

    [DataContract]
    public class AdditionalOutput
    {
        [DataMember]
        public string OutputFileName { get; set; }

        [DataMember]
        public CompareCloudware.Web.Helpers.PDFEngineType PDFEngineType { get; set; }
    }
}

