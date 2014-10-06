namespace CompareCloudware.Web.Helpers
{
    using System;
    using System.Runtime.CompilerServices;

    public class CoordinateValue<T>
    {
        public T Value { get; set; }

        public int X { get; set; }

        public int Y { get; set; }
    }
}

