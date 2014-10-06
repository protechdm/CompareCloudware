﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CompareCloudware.Web.FluentSecurity.Policy.Contexts
{
    public class SecurityContextWrapper : ISecurityContext
    {
        private readonly ISecurityContext _securityContext;

        public SecurityContextWrapper(ISecurityContext securityContext)
        {
            if (securityContext == null)
                throw new ArgumentNullException("securityContext");

            _securityContext = securityContext;
        }

        public dynamic Data
        {
            get { return _securityContext.Data; }
        }

        public bool CurrenUserAuthenticated()
        {
            return _securityContext.CurrenUserAuthenticated();
        }

        public IEnumerable<object> CurrenUserRoles()
        {
            return _securityContext.CurrenUserRoles();
        }
    }
}