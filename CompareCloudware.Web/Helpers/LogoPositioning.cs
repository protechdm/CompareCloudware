namespace CompareCloudware.Web.Helpers
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;

    [DataContract]
    public class LogoPositioning
    {
        public LogoPositioning()
        {
        }

        public LogoPositioning(float x, float y)
        {
            this.X_Position = x;
            this.Y_Position = y;
        }

        [DataMember]
        public float LogoHeightInMM { get; set; }

        [DataMember]
        public float LogoWidthInMM { get; set; }

        [DataMember]
        public float X_Position { get; set; }

        [DataMember]
        public float Y_Position { get; set; }
    }
}

