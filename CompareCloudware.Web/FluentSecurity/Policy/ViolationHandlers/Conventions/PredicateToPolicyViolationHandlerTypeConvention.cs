using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CompareCloudware.Web.FluentSecurity.Policy.ViolationHandlers.Conventions
{
    public class PredicateToPolicyViolationHandlerTypeConvention<TPolicyViolationHandler> : LazyTypePolicyViolationHandlerConvention<TPolicyViolationHandler> where TPolicyViolationHandler : class, IPolicyViolationHandler
    {
        public PredicateToPolicyViolationHandlerTypeConvention(Func<PolicyResult, bool> predicate) : base(predicate) { }
    }
}