using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Castle.Windsor;
using CompareCloudware.Web.Installers;
using System.Web.Mvc;
using System.ComponentModel;
using Castle.MicroKernel;
using Castle.Core.Internal;
using CompareCloudware.Web.Controllers;
using Castle.Core;
using Castle.Windsor.Installer;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using CompareCloudware.POCOQueryRepository;

namespace CompareCloudware.Web.Tests.Controllers
{
    [TestFixture]
    public class SiteAnalyticsTest
    {
        [Test]
        public void TestSiteAnalyticsScoreChart()
        {
            //IWindsorContainer container = new WindsorContainer().Install(FromAssembly.This());
            //IWindsorContainer container = new WindsorContainer().Install(FromAssembly.Named("TMD.Web"));
            //var c = container.Resolve<HomeController>();
            //ViewResult v = c.Index() as ViewResult;

            CompareCloudwareContext _context = new CompareCloudwareContext();
            QueryRepository _repository = new QueryRepository(_context);


            //HomeController controller = new HomeController(_repository, new SiteAnalyticsLogger());
            //ViewResult viewResult = controller.Index() as ViewResult;
            Assert.AreEqual(1, _repository.GetCurrentRankings().Count);

        }
    }
}
