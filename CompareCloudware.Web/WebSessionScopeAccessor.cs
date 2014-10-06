namespace CompareCloudware.Web
{
    using Castle.MicroKernel.Context;
    using Castle.MicroKernel.Lifestyle.Scoped;
    using System;

    public class WebSessionScopeAccessor : IScopeAccessor, IDisposable
    {
        public void Dispose()
        {
            ILifetimeScope scope = PerWebSessionLifestyleModule.YieldScope();
            if (scope != null)
            {
                scope.Dispose();
            }
        }

        public ILifetimeScope GetScope(CreationContext context)
        {
            return PerWebSessionLifestyleModule.GetScope();
        }
    }
}

