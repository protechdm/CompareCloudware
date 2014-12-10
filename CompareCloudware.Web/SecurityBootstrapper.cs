using CompareCloudware.Web.Controllers;
using CompareCloudware.Web.FluentSecurity;
using CompareCloudware.Web.Helpers;
using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Security;
using CompareCloudware.Web.Models;

namespace CompareCloudware.Web
{

    public class SecurityBootstrapper
    {
        public void Execute()
        {
            SecurityConfigurator.Configure(delegate (ConfigurationExpression configuration) {
                configuration.ResolveServicesUsing(delegate (Type type) {
                    List<object> results = new List<object>();
                    if (type == typeof(IPolicyViolationHandler))
                    {
                        results.Add(new DefaultPolicyViolationHandler());
                    }
                    return results;
                }, null);
                configuration.GetAuthenticationStatusFrom(() => HttpContext.Current.User.Identity.IsAuthenticated);
                configuration.GetRolesFrom(delegate {
                    HttpCookie authCookie = HttpContext.Current.Request.Cookies[FormsAuthentication.FormsCookieName];
                    if (authCookie != null)
                    {
                        FormsAuthenticationTicket authTicket = FormsAuthentication.Decrypt(authCookie.Value);
                        return SecurityHelper.Test();
                    }
                    return new string[] { "" };
                });
                configuration.For<BaseController>().Ignore();
                configuration.For<HomeController>().Ignore();
                configuration.For<HomeController>(x => x.AutoComplete(default(string), default(string), default(bool))).Ignore();
                configuration.For<HomeController>(x => x.GetThumbnail(default(int), default(string))).Ignore();
                //configuration.For<HomeController>(x => x.GetComboOptionsFromApplicationFeature(default(string), default(string), default(int))).Ignore();
                configuration.For<HomeController>(x => x.CloudwareExplainedPage()).Ignore();
                configuration.For<HomeController>(x => x.CloudwareExplainedPageNoScript(default(string), default(bool))).Ignore();
                configuration.For<HomeController>(x => x.CloudwareExplainedPartial()).Ignore();
                configuration.For<HomeController>(x => x.CorporateInformation(default(int))).Ignore();
                configuration.For<HomeController>(x => x.PrivacyPolicyPage()).Ignore();
                configuration.For<HomeController>(x => x.UserTermsOfUsePage()).Ignore();
                configuration.For<HomeController>(x => x.SiteMapPage()).Ignore();
                configuration.For<HomeController>(x => x.RegisterCloudware(default(CloudApplicationRegistrationAndUpdateModel),default(System.Web.Mvc.FormCollection))).Ignore();
                configuration.For<HomeController>(x => x.CorporateInformationPageNoScript(default(string), default(bool), default(string))).Ignore();
                configuration.For<HomeController>(x => x.CloudApplicationRegistrationOrUpdateNoScript(default(bool), default(bool))).Ignore();
                configuration.For<HomeController>(x => x.BetaSplashShown()).Ignore();
                configuration.For<HomeController>(x => x.BetaSplashShownNoScript()).Ignore();
                configuration.For<HomeController>(x => x.RedisplayBetaSplashShownNoScript()).Ignore();
                configuration.For<HomeController>(x => x.Search(default(HeaderModel),default(System.Web.Mvc.FormCollection))).Ignore();
                configuration.For<HomeController>(x => x.ThanksForComing(default(BaseModel))).Ignore();
                configuration.For<HomeController>(x => x.PartnerProgrammePage(default(RegisterNowModel))).Ignore();
                configuration.For<HomeController>(x => x.PartnerProgrammePage()).Ignore();
                configuration.For<HomeController>(x => x.TakeToSelection(default(int))).Ignore();

                configuration.For<AccountController>(ac => ac.LogOn()).Ignore();
                configuration.For<AccountController>(ac => ac.HeaderModel(default(HeaderModel),default(CustomSession))).DenyAnonymousAccess();
                configuration.For<AccountController>(ac => ac.AutoComplete(default(string),default(string),default(bool))).DenyAnonymousAccess();

                configuration.For<VendorController>().DenyAnonymousAccess();
                configuration.For<VendorController>(ac => ac.AutoComplete(default(string), default(string), default(bool))).DenyAnonymousAccess();
                configuration.For<VendorController>(x => x.LinkIsValid(default(string))).DenyAnonymousAccess();
                configuration.For<VendorController>(x => x.AddNewCloudApplicationProductReview(default(CompareCloudware.Web.Models.CloudApplicationInputModel))).DenyAnonymousAccess();
                configuration.For<VendorController>(x => x.AddNewCloudApplicationUserReview(default(CompareCloudware.Web.Models.CloudApplicationInputModel))).DenyAnonymousAccess();
                configuration.For<VendorController>(x => x.PingFacebook(default(string))).DenyAuthenticatedAccess();
                configuration.For<VendorController>(x => x.PingLinkedIn(default(string))).DenyAnonymousAccess();
                configuration.For<VendorController>(x => x.PingTwitter(default(string))).DenyAnonymousAccess();
                configuration.For<VendorController>(x => x.AutoComplete(default(string), default(string), default(bool))).DenyAnonymousAccess();
                configuration.For<VendorController>(x => x.GetThumbnail(default(int), default(string))).DenyAnonymousAccess();
                //configuration.For<VendorController>(x => x.GetComboOptionsFromApplicationFeature(default(string), default(string), default(int))).DenyAnonymousAccess();
                configuration.For<VendorController>(x => x.CloudwareExplainedPage()).DenyAnonymousAccess();
                configuration.For<VendorController>(x => x.CloudwareExplainedPageNoScript(default(string), default(bool))).DenyAnonymousAccess();
                configuration.For<VendorController>(x => x.CorporateInformation(default(int))).DenyAnonymousAccess();
                configuration.For<VendorController>(x => x.PrivacyPolicyPage()).DenyAnonymousAccess();
                configuration.For<VendorController>(x => x.UserTermsOfUsePage()).DenyAnonymousAccess();
                configuration.For<VendorController>(x => x.SiteMapPage()).DenyAnonymousAccess();
                configuration.For<VendorController>(x => x.CorporateInformationPageNoScript(default(string), default(bool), default(string))).DenyAnonymousAccess();
                configuration.For<VendorController>(x => x.CloudApplicationRegistrationOrUpdateNoScript(default(bool), default(bool))).DenyAnonymousAccess();

                configuration.For<AdminController>().Ignore();
                configuration.For<AdminController>(x => x.BusinessPartner(default(int))).Ignore();
                configuration.For<AdminController>(x => x.StrategicPartner(default(int))).Ignore();
                configuration.For<AdminController>(x => x.SendToColleague(default(int))).Ignore();

                configuration.For<SiteController>().Ignore();

            });
        }
    }
}

