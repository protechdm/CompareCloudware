using System.Web.Mvc;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using CompareCloudware.Domain.Contracts.Repositories;
using CompareCloudware.POCOQueryRepository;
using CompareCloudware.POCOQueryRepository.Caching;
using CompareCloudware.Web.Helpers;

namespace CompareCloudware.Web.Installers
{
    public class ControllersInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Classes.FromThisAssembly()
                                .BasedOn<IController>()
                                .LifestyleTransient());

            container.Register(Component
.For<ICompareCloudwareContext>()
.ImplementedBy<CompareCloudwareContext>()
//.LifestyleScoped<WebSessionScopeAccessor>()
.LifestylePerWebRequest()
);

            container.Register(Component
.For<ICompareCloudwareRepository>()
.ImplementedBy<QueryRepository>()
//.LifestyleScoped<WebSessionScopeAccessor>()
.LifestylePerWebRequest()
);

            container.Register(Component
.For<ICacheProvider>()
.ImplementedBy<DefaultCacheProvider>()
//.LifestyleScoped<WebSessionScopeAccessor>()
.LifestylePerWebRequest()
);

            container.Register(Component
.For<ISiteAnalyticsLogger>()
.ImplementedBy<SiteAnalyticsLogger>()
.LifestylePerWebRequest());

        }
    }
}