﻿using System;
using System.Linq;
using System.Web.Mvc;
using CompareCloudware.Web.FluentSecurity.ServiceLocation;

namespace CompareCloudware.Web.FluentSecurity
{
    public class SecurityHandler : ISecurityHandler
    {
        public ActionResult HandleSecurityFor(string controllerName, string actionName, ISecurityContext securityContext)
        {
            if (controllerName.IsNullOrEmpty()) throw new ArgumentException("Controllername must not be null or empty", "controllerName");
            if (actionName.IsNullOrEmpty()) throw new ArgumentException("Actionname must not be null or empty", "actionName");
            if (securityContext == null) throw new ArgumentNullException("securityContext", "Security context must not be null");

            var configuration = ServiceLocator.Current.Resolve<ISecurityConfiguration>();

            var policyContainer = configuration.PolicyContainers.GetContainerFor(controllerName, actionName);
            if (policyContainer != null)
            {
                var results = policyContainer.EnforcePolicies(securityContext);
                if (results.Any(x => x.ViolationOccured))
                {
                    var result = results.First(x => x.ViolationOccured);
                    var policyViolationException = new PolicyViolationException(result);
                    var violationHandlerSelector = ServiceLocator.Current.Resolve<IPolicyViolationHandlerSelector>();
                    var matchingHandler = violationHandlerSelector.FindHandlerFor(policyViolationException) ?? new ExceptionPolicyViolationHandler();
                    return matchingHandler.Handle(policyViolationException);
                }
                return null;
            }

            if (configuration.IgnoreMissingConfiguration)
                return null;

            throw ExceptionFactory.CreateConfigurationErrorsException("Security has not been configured for controller {0}, action {1}".FormatWith(controllerName, actionName));
        }
    }
}