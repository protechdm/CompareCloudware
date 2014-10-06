namespace CompareCloudware.Web.Helpers
{
    using System;
    using System.Runtime.Serialization;

    [DataContract]
    public class CompositeType
    {
        private bool boolValue = true;
        private string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get
            {
                return this.boolValue;
            }
            set
            {
                this.boolValue = value;
            }
        }

        [DataMember]
        public string StringValue
        {
            get
            {
                return this.stringValue;
            }
            set
            {
                this.stringValue = value;
            }
        }
    }
}

