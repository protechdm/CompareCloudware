//using System.Web.Mvc;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using CompareCloudware.Domain.Contracts.Repositories;
//using CompareCloudware.POCOQueryRepository;
//using CompareCloudware.POCOQueryRepository.Caching;
//using CompareCloudware.Web.Helpers;
//using WSMailPDF;
using System.Diagnostics;

namespace WSMailTryBuy.Installers
{
    public class ControllersInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Classes.FromThisAssembly()
                                .BasedOn<WSMailTryBuy.EMailHost>()
                                .LifestyleTransient());
            container.Register(Classes.FromAssemblyNamed("CompareCloudware.POCOQueryRepository")
                                .BasedOn<ICompareCloudwareContext>()
                                .LifestyleTransient()
                                );
            container.Register(Component.For<EventLog>().LifestyleTransient());
            container.Register(Component.For<ISendEMail>().ImplementedBy<SendEMail>().LifestyleTransient());

            container.Register(Classes.FromAssemblyNamed("CompareCloudware.POCOQueryRepository")
                    .BasedOn<ICompareCloudwareRepository>()
                    .LifestyleTransient()
                    );


        }
    }
}