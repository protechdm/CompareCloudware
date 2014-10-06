using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CompareCloudware.Web.FluentSecurity
{
    public interface IRequestDescription
    {
        string AreName { get; }
        string ControllerName { get; }
        string ActionName { get; }
    }
}