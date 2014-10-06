﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CompareCloudware.Web.FluentSecurity.Policy.ViolationHandlers.Conventions
{
    public class PolicyTypeToPolicyViolationHandlerTypeConvention<TSecurityPolicy, TPolicyViolationHandler> : LazyTypePolicyViolationHandlerConvention<TPolicyViolationHandler>
        where TPolicyViolationHandler : class, IPolicyViolationHandler
        where TSecurityPolicy : class, ISecurityPolicy
    {
        public PolicyTypeToPolicyViolationHandlerTypeConvention() : base(policyResult => policyResult.PolicyType == typeof(TSecurityPolicy)) { }
    }
}