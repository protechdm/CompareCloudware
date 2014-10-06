using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CompareCloudware.Web.FluentSecurity.Policy.ViolationHandlers.Conventions
{
    public class PredicateToPolicyViolationHandlerInstanceConvention<TPolicyViolationHandler> : LazyInstancePolicyViolationHandlerConvention<TPolicyViolationHandler> where TPolicyViolationHandler : class, IPolicyViolationHandler
    {
        public PredicateToPolicyViolationHandlerInstanceConvention(Func<TPolicyViolationHandler> policyViolationHandlerFactory, Func<PolicyResult, bool> predicate) : base(policyViolationHandlerFactory, predicate) { }
    }
}