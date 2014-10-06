using System.Web.Mvc;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using Castle.Facilities.Logging;
using System.Web;
using CompareCloudware.Web.Models;

namespace WSMailPDF.Installers
{
    public class CustomSessionInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            //container.Register(Classes.FromThisAssembly()
            //                    .BasedOn<IController>()
            //                    .LifestyleTransient());
            //container.AddFacility<LoggingFacility>(f => f.UseLog4Net());

            //container.Register(
            //Component.For<CustomSessionInstaller>().UsingFactoryMethod(
            //    () => new CustomClassProvider(new CustomClass())).LifestylePerWebRequest());

            //container.Register(
            //    Component.For<HttpContextBase>()
            //        .LifeStyle.Singleton
            //        .UsingFactoryMethod(() => new HttpContextWrapper(HttpContext.Current)));

            //container.Register(
            //    Component.For<ICustomSession>()
            //        .LifeStyle.Singleton
            //        .ImplementedBy<CustomSession>());

            //container.Register(Component
            //    .For<ICustomSession>()
            //    .ImplementedBy<CustomSession>()
            //    //.LifestyleScoped<WebSessionScopeAccessor>()
            //    .LifestyleTransient()
            //    //.Parameters(Parameter.ForKey("start_at").Eq("1")))
            //    .DependsOn(Parameter.ForKey("detectedBrowserID").Eq("dummybrowser"))
            //);

            //container.Register(Component
            //    .For<IBaseModel>()
            //    .ImplementedBy<HeaderModel>()
            //    //.LifestyleScoped<WebSessionScopeAccessor>()
            //    .LifestyleTransient()
            //    );

        }
    }
}