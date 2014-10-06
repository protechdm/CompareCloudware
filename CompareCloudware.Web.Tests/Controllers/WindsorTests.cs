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

namespace CompareCloudware.Web.Tests
{
    /// <summary>
    /// Summary description for WindsorTests
    /// </summary>
    [TestFixture]
    public class WindsorTests
    {
        private readonly IWindsorContainer containerWithControllers;

        //[SetUp]
        public WindsorTests()
        {
            //
            // TODO: Add constructor logic here
            //

            containerWithControllers = new WindsorContainer()
                .Install(new ControllersInstaller());
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [Test]
        public void All_controllers_implement_IController()
        {
            var allHandlers = GetAllHandlers(containerWithControllers);
            var controllerHandlers = GetHandlersFor(typeof(IController), containerWithControllers);

            Assert.IsNotEmpty(allHandlers);
            Assert.AreEqual(allHandlers, controllerHandlers);
        }

        private IHandler[] GetAllHandlers(IWindsorContainer container)
        {
            return GetHandlersFor(typeof(object), container);
        }

        private IHandler[] GetHandlersFor(Type type, IWindsorContainer container)
        {
            return container.Kernel.GetAssignableHandlers(type);
        }





        [Test]
        public void All_controllers_are_registered()
        {
            // Is<TType> is an helper, extension method from Windsor in the Castle.Core.Internal namespace
            // which behaves like 'is' keyword in C# but at a Type, not instance level
            var allControllers = GetPublicClassesFromApplicationAssembly(c => c.Is<IController>());
            var registeredControllers = GetImplementationTypesFor(typeof(IController), containerWithControllers);
            Assert.AreEqual(allControllers, registeredControllers);
        }

        private Type[] GetImplementationTypesFor(Type type, IWindsorContainer container)
        {
            return GetHandlersFor(type, container)
                .Select(h => h.ComponentModel.Implementation)
                .OrderBy(t => t.Name)
                .ToArray();
        }

        private Type[] GetPublicClassesFromApplicationAssembly(Predicate<Type> where)
        {
            return typeof(HomeController).Assembly.GetExportedTypes()
                .Where(t => t.IsClass)
                .Where(t => t.IsAbstract == false)
                .Where(where.Invoke)
                .OrderBy(t => t.Name)
                .ToArray();
        }




        [Test]
        public void All_and_only_controllers_have_Controllers_suffix()
        {
            var allControllers = GetPublicClassesFromApplicationAssembly(c => c.Name.EndsWith("Controller"));
            var registeredControllers = GetImplementationTypesFor(typeof(IController), containerWithControllers);
            Assert.AreEqual(allControllers, registeredControllers, "ALL" + allControllers.Count().ToString());
        }

        [Test]
        public void All_and_only_controllers_live_in_Controllers_namespace()
        {
            var allControllers = GetPublicClassesFromApplicationAssembly(c => c.Namespace.Contains("Controllers"));
            var registeredControllers = GetImplementationTypesFor(typeof(IController), containerWithControllers);
            //Assert.IsEmpty(allControllers);
            Assert.AreEqual(allControllers, registeredControllers, "ALL:" + registeredControllers.Count().ToString());
        }




        [Test]
        public void All_controllers_are_transient()
        {
            var nonTransientControllers = GetHandlersFor(typeof(IController), containerWithControllers)
                .Where(controller => controller.ComponentModel.LifestyleType != LifestyleType.Transient)
                .ToArray();

            Assert.IsEmpty(nonTransientControllers);
        }

        [Test]
        public void All_controllers_expose_themselves_as_service()
        {
            var controllersWithWrongName = GetHandlersFor(typeof(IController), containerWithControllers)
                .Where(controller => controller.ComponentModel.Services.Single() != controller.ComponentModel.Implementation)
                .ToArray();

            Assert.IsEmpty(controllersWithWrongName);
        }
    }
}
