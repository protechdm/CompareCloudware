using CompareCloudware.Web.FluentSecurity.ServiceLocation.Lifecycles;

namespace CompareCloudware.Web.FluentSecurity.ServiceLocation
{
    internal static class LifecycleExtensions
    {
        public static ILifecycle Get(this Lifecycle lifecycle)
        {
            switch (lifecycle)
            {
                case Lifecycle.Singleton:
                    return Lifecycle<SingletonLifecycle>.Instance;
                case Lifecycle.HybridHttpContext:
                    return Lifecycle<HybridHttpContextLifecycle>.Instance;
                case Lifecycle.HybridHttpSession:
                    return Lifecycle<HybridHttpSessionLifecycle>.Instance;
                default: // Transient
                    return Lifecycle<TransientLifecycle>.Instance;
            }
        }
    }
}