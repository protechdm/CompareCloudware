namespace CompareCloudware.Web.FluentSecurity.ServiceLocation
{
    using CompareCloudware.Web.FluentSecurity.ServiceLocation.Lifecycles;
    using System;
    using System.Runtime.CompilerServices;

    internal static class Lifecycle<TLifecycle> where TLifecycle: ILifecycle, new()
    {
        static Lifecycle()
        {
            Lifecycle<TLifecycle>.Instance = new TLifecycle();
        }

        public static ILifecycle Instance
        {
            [CompilerGenerated]
            get
            {
                return Lifecycle<TLifecycle>.<Instance>k__BackingField;
            }
            [CompilerGenerated]
            private set
            {
                Lifecycle<TLifecycle>.<Instance>k__BackingField = value;
            }
        }
    }
}

