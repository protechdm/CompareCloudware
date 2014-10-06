//using System.Web.Mvc;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using CompareCloudware.Domain.Contracts.Repositories;
//using CompareCloudware.POCOQueryRepository;
//using CompareCloudware.POCOQueryRepository.Caching;
using CompareCloudware.Web.Helpers;
using WSMailPDF;
using System.Diagnostics;

namespace WSMailPDF.Installers
{
    public class ControllersInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            //container.Register(Classes.FromAssemblyNamed("CompareCloudware.Web")
            //                    .BasedOn<ISendEMail>()
            //                    .LifestyleTransient());
            container.Register(Classes.FromAssemblyNamed("CompareCloudware.POCOQueryRepository")
                                .BasedOn<ICompareCloudwareContext>()
                                .LifestyleTransient()
                                );
            container.Register(Component.For<EventLog>().LifestyleTransient()
                //.DependsOn(Parameter.ForKey("detectedBrowserID").Eq("dummybrowser"))
                .DependsOn(Dependency.OnValue("source","CC_EMAIL"))
                );
            container.Register(Component.For<ISendEMail>().ImplementedBy<SendEMail>().LifestyleTransient());

            container.Register(Classes.FromAssemblyNamed("CompareCloudware.POCOQueryRepository")
                    .BasedOn<ICompareCloudwareRepository>()
                    .LifestyleTransient()
                    );

            container.Register(Classes.FromAssemblyNamed("WSMailPDF")
                                .BasedOn<WSMailPDF.EMailHost>()
                                .LifestyleTransient()
                                );
            //container.Register(Component
                
            //    .For<ICompareCloudwareContext>()
            //    .ImplementedBy<CompareCloudwareContext>()
            //    //.LifestyleScoped<WebSessionScopeAccessor>()
            //    .LifestyleTransient()
            //);

            //container.Register(Component
            //    .For<ICompareCloudwareRepository>()
            //    .ImplementedBy<QueryRepository>()
            //    //.LifestyleScoped<WebSessionScopeAccessor>()
            //    .LifestyleTransient()
            //);

            //container.Register(Component
            //    .For<ICacheProvider>()
            //    .ImplementedBy<DefaultCacheProvider>()
            //    //.LifestyleScoped<WebSessionScopeAccessor>()
            //    .LifestyleTransient()
            //);

        }
    }
}