﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CompareCloudware.Web.FluentSecurity.Policy.ViolationHandlers.Conventions;

namespace CompareCloudware.Web.FluentSecurity.Policy.ViolationHandlers
{
    public class PolicyViolationHandlerSelector : IPolicyViolationHandlerSelector
    {
        private readonly IEnumerable<IPolicyViolationHandlerConvention> _conventions;

        public PolicyViolationHandlerSelector(IEnumerable<IPolicyViolationHandlerConvention> conventions)
        {
            if (conventions == null) throw new ArgumentNullException("conventions");
            _conventions = conventions;
        }

        public IPolicyViolationHandler FindHandlerFor(PolicyViolationException exception)
        {
            IPolicyViolationHandler matchingHandler = null;
            foreach (var convention in _conventions)
            {
                matchingHandler = convention.GetHandlerFor(exception);
                if (matchingHandler != null) break;
            }
            return matchingHandler;
        }
    }
}