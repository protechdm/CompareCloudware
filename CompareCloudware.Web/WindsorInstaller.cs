namespace CompareCloudware.Web
{
    using Castle.MicroKernel.Registration;
    using Castle.MicroKernel.SubSystems.Configuration;
    using Castle.Windsor;
    using CompareCloudware.Web.FluentSecurity;
    using System;

    public class WindsorInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(new IRegistration[] { AllTypes.FromThisAssembly().BasedOn(typeof(IPolicyViolationHandler)).Configure(h => h.LifestyleSingleton()) });
        }
    }
}

