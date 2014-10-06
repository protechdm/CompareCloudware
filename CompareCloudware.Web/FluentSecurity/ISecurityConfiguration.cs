using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CompareCloudware.Web.FluentSecurity.Configuration;

namespace CompareCloudware.Web.FluentSecurity
{
    public interface ISecurityConfiguration
    {
        IAdvancedConfiguration Advanced { get; }
        IEnumerable<IPolicyContainer> PolicyContainers { get; }
        ISecurityServiceLocator ExternalServiceLocator { get; }
        bool IgnoreMissingConfiguration { get; }
        string WhatDoIHave();
    }
}