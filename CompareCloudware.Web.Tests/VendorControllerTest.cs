//using CloudCompare.Web.Controllers;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting.Web;
//using CloudCompare.Web.Models;
using System.Web.Mvc;
using NUnit.Framework;
using FluentSecurity.TestHelper;
using FluentSecurity.Policy;
using FluentSecurity;
using System.Web;
//using CloudCompare.Web;
using System.Collections.Generic;
using System.Linq;

namespace CloudCompare.Web.Tests
{

    [TestFixture]
    public class FluentSecuritySetupTests
    {
        //[SetUp]
        //public void Setup()
        //{
        //    //Bootstrapper
        //    //SecurityBootstrapper.BootUp();
        //    SecurityConfigurator.Configure(configuration =>
        //    {
        //        configuration.GetAuthenticationStatusFrom(() => HttpContext.Current.User.Identity.IsAuthenticated);
        //        configuration.For<HomeController>().DenyAnonymousAccess();
        //        configuration.For<AccountController>(ac => ac.LogOn()).Ignore();
        //    });

        //    var results = FluentSecurity.SecurityConfiguration.Current.Verify(expectations =>
        //        {
        //            expectations.Expect<HomeController>().Has<DenyAnonymousAccessPolicy>();
        //            expectations.Expect<AccountController>().Has<DenyAnonymousAccessPolicy>();
        //            expectations.Expect<AccountController>(ac => ac.LogOn()).Has<IgnorePolicy>();
        //        });

        //    bool isValidConfiguration = results.Valid();
        //    Assert.IsTrue(isValidConfiguration);
        //}

        //[Test]
        //public void Test()
        //{
        //    //Bootstrapper
        //    //SecurityBootstrapper.BootUp();
        //    //new SecurityBootstrapper().Execute();

        //    //SecurityConfigurator.Configure(configuration =>
        //    //{
        //    //    configuration.GetAuthenticationStatusFrom(() => HttpContext.Current.User.Identity.IsAuthenticated);
        //    //    configuration.For<HomeController>().DenyAnonymousAccess();
        //    //    configuration.For<AccountController>(ac => ac.LogOn()).Ignore();
        //    //});

        //    var results = FluentSecurity.SecurityConfiguration.Current.Verify(expectations =>
        //        {
        //            expectations.Expect<HomeController>().Has<DenyAnonymousAccessPolicy>();
        //            //expectations.Expect<HomeController>().Has<DenyAnonymousAccessPolicy>();
        //            //expectations.Expect<AccountController>().Has<DenyAnonymousAccessPolicy>();
        //            //expectations.Expect<AccountController>(ac => ac.LogOn()).Has<DenyAnonymousAccessPolicy>();
        //            //expectations.Expect<AccountController>(ac => ac.LogOn()).Has<DenyAnonymousAccessPolicy>();

        //            //expectations.Expect<AccountController>(ac => ac.LogOn()).Has<RequireRolePolicy>(policy => policy.RolesRequired.Contains(UserRole.Administrator));
        //        });

        //    bool isValidConfiguration = results.Valid();
        //    Assert.IsTrue(isValidConfiguration);
        //}


    }

    ///// <summary>
    /////This is a test class for VendorControllerTest and is intended
    /////to contain all VendorControllerTest Unit Tests
    /////</summary>
    //[TestClass()]
    //public class VendorControllerTest
    //{


    //    private TestContext testContextInstance;

    //    /// <summary>
    //    ///Gets or sets the test context which provides
    //    ///information about and functionality for the current test run.
    //    ///</summary>
    //    public TestContext TestContext
    //    {
    //        get
    //        {
    //            return testContextInstance;
    //        }
    //        set
    //        {
    //            testContextInstance = value;
    //        }
    //    }

    //    #region Additional test attributes
    //    // 
    //    //You can use the following additional attributes as you write your tests:
    //    //
    //    //Use ClassInitialize to run code before running the first test in the class
    //    //[ClassInitialize()]
    //    //public static void MyClassInitialize(TestContext testContext)
    //    //{
    //    //}
    //    //
    //    //Use ClassCleanup to run code after all tests in a class have run
    //    //[ClassCleanup()]
    //    //public static void MyClassCleanup()
    //    //{
    //    //}
    //    //
    //    //Use TestInitialize to run code before running each test
    //    //[TestInitialize()]
    //    //public void MyTestInitialize()
    //    //{
    //    //}
    //    //
    //    //Use TestCleanup to run code after each test has run
    //    //[TestCleanup()]
    //    //public void MyTestCleanup()
    //    //{
    //    //}
    //    //
    //    #endregion


    //    /// <summary>
    //    ///A test for VendorController Constructor
    //    ///</summary>
    //    // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
    //    // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
    //    // whether you are testing a page, web service, or a WCF service.
    //    [TestMethod()]
    //    [HostType("ASP.NET")]
    //    [AspNetDevelopmentServerHost("J:\\CloudCompare\\CloudCompare.Web", "/")]
    //    [UrlToTest("http://localhost:4262/")]
    //    public void VendorControllerConstructorTest()
    //    {
    //        VendorController target = new VendorController();
    //        Assert.Inconclusive("TODO: Implement code to verify target");
    //    }

    //    /// <summary>
    //    ///A test for AddNewVendor
    //    ///</summary>
    //    // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
    //    // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
    //    // whether you are testing a page, web service, or a WCF service.
    //    [TestMethod()]
    //    [HostType("ASP.NET")]
    //    [AspNetDevelopmentServerHost("J:\\CloudCompare\\CloudCompare.Web", "/")]
    //    [UrlToTest("http://localhost:4262/")]
    //    public void AddNewVendorTest()
    //    {
    //        VendorController target = new VendorController(); // TODO: Initialize to an appropriate value
    //        VendorModel model = null; // TODO: Initialize to an appropriate value
    //        ActionResult expected = null; // TODO: Initialize to an appropriate value
    //        ActionResult actual;
    //        actual = target.AddNewVendor(model);
    //        Assert.AreEqual(expected, actual);
    //        Assert.Inconclusive("Verify the correctness of this test method.");
    //    }

    //    /// <summary>
    //    ///A test for AddNewVendor
    //    ///</summary>
    //    // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
    //    // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
    //    // whether you are testing a page, web service, or a WCF service.
    //    [TestMethod()]
    //    [HostType("ASP.NET")]
    //    [AspNetDevelopmentServerHost("J:\\CloudCompare\\CloudCompare.Web", "/")]
    //    [UrlToTest("http://localhost:4262/")]
    //    public void AddNewVendorTest1()
    //    {
    //        VendorController target = new VendorController(); // TODO: Initialize to an appropriate value
    //        ActionResult expected = null; // TODO: Initialize to an appropriate value
    //        ActionResult actual;
    //        actual = target.AddNewVendor();
    //        Assert.AreEqual(expected, actual);
    //        Assert.Inconclusive("Verify the correctness of this test method.");
    //    }

    //    /// <summary>
    //    ///A test for Create
    //    ///</summary>
    //    // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
    //    // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
    //    // whether you are testing a page, web service, or a WCF service.
    //    [TestMethod()]
    //    [HostType("ASP.NET")]
    //    [AspNetDevelopmentServerHost("J:\\CloudCompare\\CloudCompare.Web", "/")]
    //    [UrlToTest("http://localhost:4262/")]
    //    public void CreateTest()
    //    {
    //        VendorController target = new VendorController(); // TODO: Initialize to an appropriate value
    //        FormCollection collection = null; // TODO: Initialize to an appropriate value
    //        ActionResult expected = null; // TODO: Initialize to an appropriate value
    //        ActionResult actual;
    //        actual = target.Create(collection);
    //        Assert.AreEqual(expected, actual);
    //        Assert.Inconclusive("Verify the correctness of this test method.");
    //    }

    //    /// <summary>
    //    ///A test for Create
    //    ///</summary>
    //    // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
    //    // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
    //    // whether you are testing a page, web service, or a WCF service.
    //    [TestMethod()]
    //    [HostType("ASP.NET")]
    //    [AspNetDevelopmentServerHost("J:\\CloudCompare\\CloudCompare.Web", "/")]
    //    [UrlToTest("http://localhost:4262/")]
    //    public void CreateTest1()
    //    {
    //        VendorController target = new VendorController(); // TODO: Initialize to an appropriate value
    //        ActionResult expected = null; // TODO: Initialize to an appropriate value
    //        ActionResult actual;
    //        actual = target.Create();
    //        Assert.AreEqual(expected, actual);
    //        Assert.Inconclusive("Verify the correctness of this test method.");
    //    }

    //    /// <summary>
    //    ///A test for Delete
    //    ///</summary>
    //    // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
    //    // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
    //    // whether you are testing a page, web service, or a WCF service.
    //    [TestMethod()]
    //    [HostType("ASP.NET")]
    //    [AspNetDevelopmentServerHost("J:\\CloudCompare\\CloudCompare.Web", "/")]
    //    [UrlToTest("http://localhost:4262/")]
    //    public void DeleteTest()
    //    {
    //        VendorController target = new VendorController(); // TODO: Initialize to an appropriate value
    //        int id = 0; // TODO: Initialize to an appropriate value
    //        ActionResult expected = null; // TODO: Initialize to an appropriate value
    //        ActionResult actual;
    //        actual = target.Delete(id);
    //        Assert.AreEqual(expected, actual);
    //        Assert.Inconclusive("Verify the correctness of this test method.");
    //    }

    //    /// <summary>
    //    ///A test for Delete
    //    ///</summary>
    //    // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
    //    // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
    //    // whether you are testing a page, web service, or a WCF service.
    //    [TestMethod()]
    //    [HostType("ASP.NET")]
    //    [AspNetDevelopmentServerHost("J:\\CloudCompare\\CloudCompare.Web", "/")]
    //    [UrlToTest("http://localhost:4262/")]
    //    public void DeleteTest1()
    //    {
    //        VendorController target = new VendorController(); // TODO: Initialize to an appropriate value
    //        int id = 0; // TODO: Initialize to an appropriate value
    //        FormCollection collection = null; // TODO: Initialize to an appropriate value
    //        ActionResult expected = null; // TODO: Initialize to an appropriate value
    //        ActionResult actual;
    //        actual = target.Delete(id, collection);
    //        Assert.AreEqual(expected, actual);
    //        Assert.Inconclusive("Verify the correctness of this test method.");
    //    }

    //    /// <summary>
    //    ///A test for Details
    //    ///</summary>
    //    // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
    //    // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
    //    // whether you are testing a page, web service, or a WCF service.
    //    [TestMethod()]
    //    [HostType("ASP.NET")]
    //    [AspNetDevelopmentServerHost("J:\\CloudCompare\\CloudCompare.Web", "/")]
    //    [UrlToTest("http://localhost:4262/")]
    //    public void DetailsTest()
    //    {
    //        VendorController target = new VendorController(); // TODO: Initialize to an appropriate value
    //        int id = 0; // TODO: Initialize to an appropriate value
    //        ActionResult expected = null; // TODO: Initialize to an appropriate value
    //        ActionResult actual;
    //        actual = target.Details(id);
    //        Assert.AreEqual(expected, actual);
    //        Assert.Inconclusive("Verify the correctness of this test method.");
    //    }

    //    /// <summary>
    //    ///A test for Edit
    //    ///</summary>
    //    // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
    //    // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
    //    // whether you are testing a page, web service, or a WCF service.
    //    [TestMethod()]
    //    [HostType("ASP.NET")]
    //    [AspNetDevelopmentServerHost("J:\\CloudCompare\\CloudCompare.Web", "/")]
    //    [UrlToTest("http://localhost:4262/")]
    //    public void EditTest()
    //    {
    //        VendorController target = new VendorController(); // TODO: Initialize to an appropriate value
    //        int id = 0; // TODO: Initialize to an appropriate value
    //        ActionResult expected = null; // TODO: Initialize to an appropriate value
    //        ActionResult actual;
    //        actual = target.Edit(id);
    //        Assert.AreEqual(expected, actual);
    //        Assert.Inconclusive("Verify the correctness of this test method.");
    //    }

    //    /// <summary>
    //    ///A test for Edit
    //    ///</summary>
    //    // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
    //    // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
    //    // whether you are testing a page, web service, or a WCF service.
    //    [TestMethod()]
    //    [HostType("ASP.NET")]
    //    [AspNetDevelopmentServerHost("J:\\CloudCompare\\CloudCompare.Web", "/")]
    //    [UrlToTest("http://localhost:4262/")]
    //    public void EditTest1()
    //    {
    //        VendorController target = new VendorController(); // TODO: Initialize to an appropriate value
    //        int id = 0; // TODO: Initialize to an appropriate value
    //        FormCollection collection = null; // TODO: Initialize to an appropriate value
    //        ActionResult expected = null; // TODO: Initialize to an appropriate value
    //        ActionResult actual;
    //        actual = target.Edit(id, collection);
    //        Assert.AreEqual(expected, actual);
    //        Assert.Inconclusive("Verify the correctness of this test method.");
    //    }

    //    /// <summary>
    //    ///A test for Index
    //    ///</summary>
    //    // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
    //    // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
    //    // whether you are testing a page, web service, or a WCF service.
    //    [TestMethod()]
    //    [HostType("ASP.NET")]
    //    [AspNetDevelopmentServerHost("J:\\CloudCompare\\CloudCompare.Web", "/")]
    //    [UrlToTest("http://localhost:4262/")]
    //    public void IndexTest()
    //    {
    //        VendorController target = new VendorController(); // TODO: Initialize to an appropriate value
    //        ActionResult expected = null; // TODO: Initialize to an appropriate value
    //        ActionResult actual;
    //        actual = target.Index();
    //        Assert.AreEqual(expected, actual);
    //        Assert.Inconclusive("Verify the correctness of this test method.");
    //    }
    //}
}
