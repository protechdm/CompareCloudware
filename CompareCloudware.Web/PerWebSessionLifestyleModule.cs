namespace CompareCloudware.Web
{
    using Castle.MicroKernel.Lifestyle.Scoped;
    using System;
    using System.Web;
    using System.Web.SessionState;

    public class PerWebSessionLifestyleModule : IHttpModule
    {
        private const string key = "castle.per-web-session-lifestyle-cache";

        public void Dispose()
        {
        }

        internal static ILifetimeScope GetScope()
        {
            HttpContext current = HttpContext.Current;
            if (current == null)
            {
                throw new InvalidOperationException("HttpContext.Current is null. PerWebSessionLifestyle can only be used in ASP.Net");
            }
            return GetScope(current.Session, true);
        }

        private static ILifetimeScope GetScope(HttpSessionState session, bool createIfNotPresent)
        {
            ILifetimeScope lifetimeScope = (ILifetimeScope) session["castle.per-web-session-lifestyle-cache"];
            if ((lifetimeScope == null) && createIfNotPresent)
            {
                lifetimeScope = new DefaultLifetimeScope(new ScopeCache(), null);
                session["castle.per-web-session-lifestyle-cache"] = lifetimeScope;
                return lifetimeScope;
            }
            return lifetimeScope;
        }

        public void Init(HttpApplication context)
        {
            SessionStateModule sessionState = (SessionStateModule) context.Modules["Session"];
            sessionState.End += new EventHandler(PerWebSessionLifestyleModule.SessionEnd);
        }

        private static void SessionEnd(object sender, EventArgs e)
        {
            HttpApplication app = (HttpApplication) sender;
            ILifetimeScope scope = GetScope(app.Context.Session, false);
            if (scope != null)
            {
                scope.Dispose();
            }
        }

        internal static ILifetimeScope YieldScope()
        {
            HttpContext context = HttpContext.Current;
            if (context == null)
            {
                return null;
            }
            ILifetimeScope scope = GetScope(context.Session, true);
            if (scope != null)
            {
                context.Session.Remove("castle.per-web-session-lifestyle-cache");
            }
            return scope;
        }
    }
}

