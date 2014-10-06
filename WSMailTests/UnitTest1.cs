using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using NUnit.Framework;
using CompareCloudware.Web.Helpers;
using CompareCloudware.Domain.Models;
using System.IO;
using WSMailPDF;
using System.Diagnostics;
using Castle.Windsor;
using Castle.Windsor.Installer;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;

namespace WSMailTests
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    //[TestClass]
    [TestFixture]
    public class UnitTest1
    {
        public UnitTest1()
        {
            //
            // TODO: Add constructor logic here
            //
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

        //[TestMethod]
        [Test]
        public void TestMethod1()
        {
            //
            // TODO: Add test logic here
            //
            //ARRANGE
            var mockSendMail = new Mock<ISendEMail>();
            mockSendMail.Setup(x => x.Execute(It.IsAny<Person>(),It.IsAny<CloudApplicationRequest>(),It.IsAny<MailRequest>(),It.IsAny<Stream>(),It.IsAny<string>())).Returns(true);

            EMailHost emh = new EMailHost(new EventLog() { Source = "CC_EMAIL"}, mockSendMail.Object);

            //ACT
            bool success = emh.ServiceCloudApplicationMailRequests();

            //ASSERT
            Assert.AreEqual(true, success);
        }


        [Test]
        public void CheckHostCannotBeRunWithoutAnEventLogSource()
        {
            //
            // TODO: Add test logic here
            //
            //ARRANGE
            IWindsorContainer container = new WindsorContainer().Install(FromAssembly.This());
            //HomeController hc = container.Resolve<HomeController>();
            EMailHost emh = container.Resolve<EMailHost>();

            var mockSendMail = new Mock<ISendEMail>();
            mockSendMail.Setup(x => x.Execute(It.IsAny<Person>(), It.IsAny<CloudApplicationRequest>(), It.IsAny<MailRequest>(), It.IsAny<Stream>(), It.IsAny<string>())).Returns(true);

            //EMailHost emh = new EMailHost(new EventLog(), mockSendMail.Object);

            //ACT
            bool success = emh.ServiceCloudApplicationMailRequests();

            //ASSERT
            //Assert.Throws(true, success);
        }
    
    }
}
