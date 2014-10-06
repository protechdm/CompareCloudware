using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CompareCloudware.Web.FluentSecurity.ServiceLocation
{
    public class TypeNotRegisteredException : Exception
    {
        public TypeNotRegisteredException(string message) : base(message) { }
    }
}