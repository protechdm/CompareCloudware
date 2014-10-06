using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CompareCloudware.Web.FluentSecurity
{
    public interface IWhatDoIHaveBuilder
    {
        string WhatDoIHave(ISecurityConfiguration configuration);
    }
}