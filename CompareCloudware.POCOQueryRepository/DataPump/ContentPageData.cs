using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CompareCloudware.Domain.Models;
using System.IO;

namespace CompareCloudware.POCOQueryRepository.DataPump
{
    public static class ContentPageData
    {
        public static bool PumpContentPageData(QueryRepository repository)
        {

            bool retVal = true;

            #region CONTENT PAGES
            ContentPage cp;

            #region HOME
            cp = new ContentPage()
            {
                Slug = "home",
                Title = "Home",
                Author = "Glyn Threadgold",
                GooglePlusId = null,
                SortOrder = 0,
                MetaTitle = "Compare Cloudware | Compare & Review Cloud Software, Applications & Services",
                MetaKeywords = "compare cloudware, compare cloudware services, cloud comparison site, compare IT and communication services, saas comparison website, saas comparison site, compare cloud services, saas providers, top saas providers, saas cloud providers, cloud computing comparison, cloud hosting comparison, cloud hosting comparison, software as a service comparison site, software comparison site, compare cloud apps, best cloud applications, compare cloud business services, business cloud services, best cloud services",
                MetaDescription = "Compare cloud software, services and applications. Choose and review the latest products from the top communication, IT and software-as-a-service (SaaS) providers.",
                Modified = DateTime.Now,
                NoSearch = false,
                Frequency = SiteMapFrequencyEnum.Always,
                Route = "Home",
            };
            repository.AddContentPage(cp);
            #endregion

            #region WEB CONFERENCING
            cp = new ContentPage()
            {
                Slug = "conferencing",
                Title = "Conferencing",
                Author = "Glyn Threadgold",
                GooglePlusId = null,
                SortOrder = 0,
                MetaTitle = "Compare Web Conferencing Software & Services | Online Conferencing Reviews",
                MetaKeywords = "Compare conferencing, compare conference software, compare online conferencing, conferencing review, compare web conferencing, web conferencing reviews, web conferencing comparison, web conferencing choices, choosing web conferencing, buy web conferencing, compare online conferencing, compare cloud conferencing, compare hosted conferencing, cloud conferencing, ",
                MetaDescription = "Compare, choose and buy the latest web conferencing software with Compare Cloudware. View independent reviews of the best online or web-based conferencing services. ",
                Modified = DateTime.Now,
                NoSearch = false,
                Frequency = SiteMapFrequencyEnum.Always,
                Route = "Web Conferencing",
            };
            repository.AddContentPage(cp);
            #endregion

            #region EMAIL
            cp = new ContentPage()
            {
                Slug = "email",
                Title = "EMail",
                Author = "Glyn Threadgold",
                GooglePlusId = null,
                SortOrder = 0,
                MetaTitle = "Compare Cloud Email Services | Choose the Best Webmail Service",
                MetaKeywords = "compare business email, compare hosted email, compare cloud email, compare webmail, compare saas email, buy business email, email comparison, compare email services, best email, best business email",
                MetaDescription = "Compare the latest SaaS email services from leading UK providers here. Package information and reviews to help you find the right business email solution.",
                Modified = DateTime.Now,
                NoSearch = false,
                Frequency = SiteMapFrequencyEnum.Always,
                Route = "Email",
            };
            repository.AddContentPage(cp);
            #endregion

            #region STORAGE
            cp = new ContentPage()
            {
                Slug = "storage",
                Title = "Storage",
                Author = "Glyn Threadgold",
                GooglePlusId = null,
                SortOrder = 0,
                MetaTitle = "Compare Online Storage Services | Buy Backup Software",
                MetaKeywords = "compare online storage, online storage options, online storage reviews, compare backup software, buy backup software, best online storage, compare storage services, compare back-up services, cloud storage comparison, best cloud storage",
                MetaDescription = "Compare and buy the latest cloud storage and backup solutions from leading providers. View independent reviews of best cloud storage.",
                Modified = DateTime.Now,
                NoSearch = false,
                Frequency = SiteMapFrequencyEnum.Always,
                Route = "Storage And Backup",
            };
            repository.AddContentPage(cp);
            #endregion

            #region COMMUNICATIONS
            cp = new ContentPage()
            {
                Slug = "communications",
                Title = "Communications",
                Author = "Glyn Threadgold",
                GooglePlusId = null,
                SortOrder = 0,
                MetaTitle = "Compare Communication Services |VoIP and IP Telephony Reviews",
                MetaKeywords = "compare internet telephony, compare IP telephony, best communications software, compare internet phone, compare voip, compare ip phones, compare pc phones, compare PBX, compare hosted phone systems, phone system review, best internet phone service, voip comparison, cloud PBX, best cloud PBX, cloud contact centres, cloud telephone system, best telephone system",
                MetaDescription = "Compare the best cloud communication  services and find information on the latest internet phones, including VoIP services, IP phones and PC phones. Reviews available.",
                Modified = DateTime.Now,
                NoSearch = false,
                Frequency = SiteMapFrequencyEnum.Always,
                Route = "Communications",
            };
            repository.AddContentPage(cp);
            #endregion

            #region OFFICE
            cp = new ContentPage()
            {
                Slug = "office",
                Title = "Office",
                Author = "Glyn Threadgold",
                GooglePlusId = null,
                SortOrder = 0,
                MetaTitle = "Compare Office Software | Office Apps Reviews",
                MetaKeywords = "compare office software, compare online office software, compare office apps, compare cloud office software, online office software options, office software reviews, buy office software, compare saas office",
                MetaDescription = "Looking for an alternative to Microsoft Office? Compare, buy and review the latest cloud office software apps right here with Compare Cloudware. ",
                Modified = DateTime.Now,
                NoSearch = false,
                Frequency = SiteMapFrequencyEnum.Always,
                Route = "Office",
            };
            repository.AddContentPage(cp);
            #endregion

            #region FINANCIAL
            cp = new ContentPage()
            {
                Slug = "financial",
                Title = "Financial",
                Author = "Glyn Threadgold",
                GooglePlusId = null,
                SortOrder = 0,
                MetaTitle = "Compare Accounting Software | Cloud Finance Software ",
                MetaKeywords = "compare accounting software, compare accounts software, compare payroll software, compare finance software, finance software reviews, buy cloud accounting software, compare saas accounting, accounts software comparison, compare online accounting software, best accounting software, best financial software",
                MetaDescription = "Compare accounting software and buy online with the help of the UK’s leading independent comparison website for cloud-based services. ",
                Modified = DateTime.Now,
                NoSearch = false,
                Frequency = SiteMapFrequencyEnum.Always,
                Route = "Financial",
            };
            repository.AddContentPage(cp);
            #endregion

            #region CRM
            cp = new ContentPage()
            {
                Slug = "crm",
                Title = "CRM",
                Author = "Glyn Threadgold",
                GooglePlusId = null,
                SortOrder = 0,
                MetaTitle = "Compare Customer Management Software | CRM Reviews | Compare CRM",
                MetaKeywords = "compare CRM, compare CRM software, buy customer management software, compare customer management software, best customer management software, customer management reviews, CRM reviews",
                MetaDescription = "Compare customer management software and CRM systems from market leading and specialist brands . Compare CRM features  and buy online.",
                Modified = DateTime.Now,
                NoSearch = false,
                Frequency = SiteMapFrequencyEnum.Always,
                Route = "CRM",
            };
            repository.AddContentPage(cp);
            #endregion

            #region PROJECT
            cp = new ContentPage()
            {
                Slug = "project",
                Title = "Project",
                Author = "Glyn Threadgold",
                GooglePlusId = null,
                SortOrder = 0,
                MetaTitle = "Compare Project Management Software | Best Cloud-Based Solutions",
                MetaKeywords = "compare project management software, compare project software, project management software comparison, compare project management software, compare cloud project management, compare saas project management, best project management software",
                MetaDescription = "View, compare and buy cloud project management software with the help of Compare Cloudware. Choose the right SaaS application for home or business here.",
                Modified = DateTime.Now,
                NoSearch = false,
                Frequency = SiteMapFrequencyEnum.Always,
                Route = "Project Management",
            };
            repository.AddContentPage(cp);
            #endregion

            #region SECURITY
            cp = new ContentPage()
            {
                Slug = "security",
                Title = "Security",
                Author = "Glyn Threadgold",
                GooglePlusId = null,
                SortOrder = 0,
                MetaTitle = "Compare Internet Security Software | Best Cloud Security",
                MetaKeywords = "compare internet security software, compare online security, security software comparison, compare security software, compare cloud security, best internet security, best anti virus, internet security reviews",
                MetaDescription = "Protect your devices and data with the latest internet security software packages from cloud-based providers. Buy online. Reviews available.",
                Modified = DateTime.Now,
                NoSearch = false,
                Frequency = SiteMapFrequencyEnum.Always,
                Route = "Security",
            };
            repository.AddContentPage(cp);
            #endregion

            #region MARKETING
            cp = new ContentPage()
            {
                Slug = "marketing",
                Title = "Marketing",
                Author = "Glyn Threadgold",
                GooglePlusId = null,
                SortOrder = 0,
                MetaTitle = "Compare Cloud Hosting |Cloud Hosting Reviews Compare |Best Hosting Providers",
                MetaKeywords = "Cloud hosting, Cloud hosting services, Cloud web hosting, Cloud hosting UK, UK cloud hosting, US cloud hosting, Managed cloud hosting, Managed web hosting, Web hosting services, Web hosting packages, Review Cloud Hosting, Compare web hosting, Compare cloud hosting, Best hosting provider, Web hosting comparison, Compare web hosting UK, Compare hosting, Compare website hosting, Top web hosting companies",
                MetaDescription = "Review and compare cloud and web hosting providers. Find the best hosting provider with Compare Cloudware",
                Modified = DateTime.Now,
                NoSearch = false,
                Frequency = SiteMapFrequencyEnum.Always,
                Route = "Marketing",
            };
            repository.AddContentPage(cp);
            #endregion

            #region WEBSITE
            cp = new ContentPage()
            {
                Slug = "website",
                Title = "Website",
                Author = "Glyn Threadgold",
                GooglePlusId = null,
                SortOrder = 0,
                MetaTitle = "Compare Website Building Software | Website and Hosting Reviews | Best Website Providers",
                MetaKeywords = "Website builder software, Website building software, Website editor, Online website editor, Web editing software, Website editing software, Landing page builder, Landing page software, Landing page creator, Social media integration, Social media integration software, Social media integration apps, Website graphics software, Cloud ecommerce software, Cloud ecommerce, Ecommerce website builder, Eshop builder, Compare website builder, Compare website software, Best Website Builder, Top Website Building Software",
                MetaDescription = "Review, compare, choose and buy the latest website building software with Compare Cloudware. View independent reviews of the best website software.",
                Modified = DateTime.Now,
                NoSearch = false,
                Frequency = SiteMapFrequencyEnum.Always,
                Route = "Website",
            };
            repository.AddContentPage(cp);
            #endregion

            #region CREATIVE
            cp = new ContentPage()
            {
                Slug = "creative",
                Title = "Creative",
                Author = "Glyn Threadgold",
                GooglePlusId = null,
                SortOrder = 0,
                MetaTitle = "Compare Creative and Design Software | Creative and Design Software Reviews",
                MetaKeywords = "Graphic design software, Illustration software, Image manipulation software, Creative software, Graphics suite, Design software, Retouching software, New potential keywords, Video editing software, App building software, App creation software, Publishing software, DTP software, Desktop publishing software, eBook publishing software, e book software, Web animation software, Photo editing software, Image editing software",
                MetaDescription = "Review, compare and choose Creative and Design software with the help of Compare Cloudware. Choose the right Creative and Design application.",
                Modified = DateTime.Now,
                NoSearch = false,
                Frequency = SiteMapFrequencyEnum.Always,
                Route = "Creative",
            };
            repository.AddContentPage(cp);
            #endregion

            #region BUSINESS INTELLIGENCE REPORTING
            cp = new ContentPage()
            {
                Slug = "intelligence-and-reporting",
                Title = "Intelligence And Reporting",
                Author = "Glyn Threadgold",
                GooglePlusId = null,
                SortOrder = 0,
                MetaTitle = "Compare Intelligence and Reporting Software | Intelligence and Analytics Software Reviews",
                MetaKeywords = "Cloud business intelligence, Cloud business intelligence software, Cloud business reporting software, Cloud BI, Business intelligence software, Business intelligence tools, BI software , BI tools, Business analytics, Business analytics software, Business intelligence and analytics, Business intelligence software vendors, Business intelligence applications, Business intelligence apps, Reporting dashboard software, Dashboard software, Analytics software",
                MetaDescription = "Compare the best Business Intelligence and Analytics software. Compare, review and choose latest cloud based Business Intelligence, Reporting and Analytics services on Compare Cloudware.",
                Modified = DateTime.Now,
                NoSearch = false,
                Frequency = SiteMapFrequencyEnum.Always,
                Route = "Business Intelligence Reporting",
            };
            repository.AddContentPage(cp);
            #endregion

            #region HOSTING
            cp = new ContentPage()
            {
                Slug = "hosting",
                Title = "Hosting",
                Author = "Glyn Threadgold",
                GooglePlusId = null,
                SortOrder = 0,
                MetaTitle = "Compare Marketing Software | Review Marketing Software | Best Cloud Marketing Software ",
                MetaKeywords = "Marketing software, Marketing management software, Marketing project management software, Marketing project management, Marketing automation tools, Email automation software, E marketing software, Marketing analytics software, Cloud marketing software, Marketing survey software, Cloud survey software, Market research software, Marketing analytics software, Campaign management software, Marketing campaign management software, Email broadcast software, Email campaign software, e-newsletter software, Survey software, Online survey software, SEO software, Search marketing software, Social content software, Social media software, Ad tracking software, Telemarketing software, Landing page software, Webinar software, Event management software, PR software",
                MetaDescription = "Compare Marketing software with the help of the UK’s leading independent comparison website for cloud-based services.",
                Modified = DateTime.Now,
                NoSearch = false,
                Frequency = SiteMapFrequencyEnum.Always,
                Route = "Hosting",
            };
            repository.AddContentPage(cp);
            #endregion

            #region HR
            cp = new ContentPage()
            {
                Slug = "hr",
                Title = "HR",
                Author = "Glyn Threadgold",
                GooglePlusId = null,
                SortOrder = 0,
                MetaTitle = "Compare Online HR Services | Review HR Services | Cloud HR Services",
                MetaKeywords = "HR software, Online HR software, Cloud HR software, HR management software, Cloud recruitment software, Cloud timesheet software, Cloud task management software, Task management software, Workforce management software, Talent management software, Timesheet software, Expense management software, Training software, Human resource management software, Performance management software, Compare HR software, Compare recruitment software, Compare task management software",
                MetaDescription = "Review, compare and choose the latest cloud HR services. View independent reviews of best HR cloud services.",
                Modified = DateTime.Now,
                NoSearch = false,
                Frequency = SiteMapFrequencyEnum.Always,
                Route = "HR",
            };
            repository.AddContentPage(cp);
            #endregion

            #region PAYMENTS
            cp = new ContentPage()
            {
                Slug = "payments",
                Title = "Payments",
                Author = "Glyn Threadgold",
                GooglePlusId = null,
                SortOrder = 0,
                MetaTitle = "Compare Payment Services | Best Payment Services |Review Payment Services",
                MetaKeywords = "Online payment systems, Online payment gateway, Online payment processing, Online payment apps, Cloud payment gateway, Money transfer software, Money transfer apps, Cloud payment systems, Cloud payment software, Compare payment gateways, Payment gateway comparison, Payment gateways comparison, Payment gateway comparison UK, Online payment systems comparison",
                MetaDescription = "Compare the latest SaaS email services from leading UK providers here. Package information and reviews to help you find the right business email solution.",
                Modified = DateTime.Now,
                NoSearch = false,
                Frequency = SiteMapFrequencyEnum.Always,
                Route = "Payments",
            };
            repository.AddContentPage(cp);
            #endregion

            #region BUSINESS & OPERATIONS
            cp = new ContentPage()
            {
                Slug = "business-and-operations",
                Title = "Business And Operations",
                Author = "Glyn Threadgold",
                GooglePlusId = null,
                SortOrder = 0,
                MetaTitle = "Compare Business Operations Software | Business Operations Reviews",
                MetaKeywords = "Scheduling software, Appointment software, Appointment management software, Business plan software, Stock control software, Stock management software, Inventory software, Inventory management software, Order management software, Stock control software, Stock management software, Order processing software, Purchase order software, PO software, Project management software, eSignature software, Electronic signature software, Digital signature software, Electronic approval software, eContract software, Helpdesk software, Customer support software, Help desk software, Field management software, Field staff software, Logistics management software",
                MetaDescription = "Compare Business Operations software and systems from market leading and specialist brands.",
                Modified = DateTime.Now,
                NoSearch = false,
                Frequency = SiteMapFrequencyEnum.Always,
                Route = "Business And Operations",
            };
            repository.AddContentPage(cp);
            #endregion

            #region SALES
            cp = new ContentPage()
            {
                Slug = "sales",
                Title = "Sales",
                Author = "Glyn Threadgold",
                GooglePlusId = null,
                SortOrder = 0,
                MetaTitle = "Compare Sales Software |Sales Software Reviews | Cloud Sales Software",
                MetaKeywords = "Sales force automation, Sales force automation software, Sales automation software, Sales automation tools, Sales forecasting, Sales forecasting software, Sales software, Sales database software, SFA software, Cloud sales software, Cloud sales management software, Best Sales Software, Compare Sales Software, Best Sales CRM, Review Sales Software",
                MetaDescription = "Compare the best Sales Software and find reviews on the latest services focusing on sales automation and forecasting.",
                Modified = DateTime.Now,
                NoSearch = false,
                Frequency = SiteMapFrequencyEnum.Always,
                Route = "Sales",
            };
            repository.AddContentPage(cp);
            #endregion

            #region CLOUDWARE EXPLAINED
            cp = new ContentPage()
            {
                Slug = "cloudware-explained",
                Title = "Cloudware Explained",
                Author = "Glyn Threadgold",
                GooglePlusId = null,
                SortOrder = 0,
                MetaTitle = "",
                MetaKeywords = "",
                MetaDescription = "",
                Modified = DateTime.Now,
                NoSearch = false,
                Frequency = SiteMapFrequencyEnum.Always,
                Route = "",
            };
            repository.AddContentPage(cp);
            #endregion

            #region CORPORATE
            cp = new ContentPage()
            {
                Slug = "corporate",
                Title = "Corporate",
                Author = "Glyn Threadgold",
                GooglePlusId = null,
                SortOrder = 0,
                MetaTitle = "",
                MetaKeywords = "",
                MetaDescription = "",
                Modified = DateTime.Now,
                NoSearch = false,
                Frequency = SiteMapFrequencyEnum.Always,
                Route = "",
            };
            repository.AddContentPage(cp);
            #endregion

            #region ABOUT
            cp = new ContentPage()
            {
                Slug = "about",
                Title = "About Us",
                Author = "Glyn Threadgold",
                GooglePlusId = null,
                SortOrder = 0,
                MetaTitle = "",
                MetaKeywords = "",
                MetaDescription = "",
                Modified = DateTime.Now,
                NoSearch = false,
                Frequency = SiteMapFrequencyEnum.Always,
                Route = "",
            };
            repository.AddContentPage(cp);
            #endregion

            #region MANAGEMENT TEAM
            cp = new ContentPage()
            {
                Slug = "management-team",
                Title = "Management Team",
                Author = "Glyn Threadgold",
                GooglePlusId = null,
                SortOrder = 0,
                MetaTitle = "",
                MetaKeywords = "",
                MetaDescription = "",
                Modified = DateTime.Now,
                NoSearch = false,
                Frequency = SiteMapFrequencyEnum.Always,
                Route = "",
            };
            repository.AddContentPage(cp);
            #endregion

            #region VISION
            cp = new ContentPage()
            {
                Slug = "vision",
                Title = "Vision",
                Author = "Glyn Threadgold",
                GooglePlusId = null,
                SortOrder = 0,
                MetaTitle = "",
                MetaKeywords = "",
                MetaDescription = "",
                Modified = DateTime.Now,
                NoSearch = false,
                Frequency = SiteMapFrequencyEnum.Always,
                Route = "",
            };
            repository.AddContentPage(cp);
            #endregion

            #region FAQS
            cp = new ContentPage()
            {
                Slug = "faqs",
                Title = "FAQs",
                Author = "Glyn Threadgold",
                GooglePlusId = null,
                SortOrder = 0,
                MetaTitle = "",
                MetaKeywords = "",
                MetaDescription = "",
                Modified = DateTime.Now,
                NoSearch = false,
                Frequency = SiteMapFrequencyEnum.Always,
                Route = "",
            };
            repository.AddContentPage(cp);
            #endregion

            #region CAREERS
            cp = new ContentPage()
            {
                Slug = "careers",
                Title = "Careers",
                Author = "Glyn Threadgold",
                GooglePlusId = null,
                SortOrder = 0,
                MetaTitle = "",
                MetaKeywords = "",
                MetaDescription = "",
                Modified = DateTime.Now,
                NoSearch = false,
                Frequency = SiteMapFrequencyEnum.Always,
                Route = "",
            };
            repository.AddContentPage(cp);
            #endregion

            #region PRESS
            cp = new ContentPage()
            {
                Slug = "press",
                Title = "Press",
                Author = "Glyn Threadgold",
                GooglePlusId = null,
                SortOrder = 0,
                MetaTitle = "",
                MetaKeywords = "",
                MetaDescription = "",
                Modified = DateTime.Now,
                NoSearch = false,
                Frequency = SiteMapFrequencyEnum.Always,
                Route = "",
            };
            repository.AddContentPage(cp);
            #endregion

            #region CONTACT
            cp = new ContentPage()
            {
                Slug = "contact",
                Title = "Contact Us",
                Author = "Glyn Threadgold",
                GooglePlusId = null,
                SortOrder = 0,
                MetaTitle = "",
                MetaKeywords = "",
                MetaDescription = "",
                Modified = DateTime.Now,
                NoSearch = false,
                Frequency = SiteMapFrequencyEnum.Always,
                Route = "",
            };
            repository.AddContentPage(cp);
            #endregion

            #region REGISTER
            cp = new ContentPage()
            {
                Slug = "register",
                Title = "Register Cloudware",
                Author = "Glyn Threadgold",
                GooglePlusId = null,
                SortOrder = 0,
                MetaTitle = "",
                MetaKeywords = "",
                MetaDescription = "",
                Modified = DateTime.Now,
                NoSearch = false,
                Frequency = SiteMapFrequencyEnum.Always,
                Route = "",
            };
            repository.AddContentPage(cp);
            #endregion

            #region UPDATECLOUDWARE
            cp = new ContentPage()
            {
                Slug = "updatecloudware",
                Title = "Update Cloudware",
                Author = "Glyn Threadgold",
                GooglePlusId = null,
                SortOrder = 0,
                MetaTitle = "",
                MetaKeywords = "",
                MetaDescription = "",
                Modified = DateTime.Now,
                NoSearch = false,
                Frequency = SiteMapFrequencyEnum.Always,
                Route = "",
            };
            repository.AddContentPage(cp);
            #endregion

            #region PRIVACY
            cp = new ContentPage()
            {
                Slug = "privacy",
                Title = "Privacy Policy",
                Author = "Glyn Threadgold",
                GooglePlusId = null,
                SortOrder = 0,
                MetaTitle = "",
                MetaKeywords = "",
                MetaDescription = "",
                Modified = DateTime.Now,
                NoSearch = false,
                Frequency = SiteMapFrequencyEnum.Always,
                Route = "",
            };
            repository.AddContentPage(cp);
            #endregion

            #region TERMS
            cp = new ContentPage()
            {
                Slug = "terms",
                Title = "Terms",
                Author = "Glyn Threadgold",
                GooglePlusId = null,
                SortOrder = 0,
                MetaTitle = "",
                MetaKeywords = "",
                MetaDescription = "",
                Modified = DateTime.Now,
                NoSearch = false,
                Frequency = SiteMapFrequencyEnum.Always,
                Route = "",
            };
            repository.AddContentPage(cp);
            #endregion

            #region SITE MAP
            cp = new ContentPage()
            {
                Slug = "sitemap",
                Title = "Site Map",
                Author = "Glyn Threadgold",
                GooglePlusId = null,
                SortOrder = 0,
                MetaTitle = "",
                MetaKeywords = "",
                MetaDescription = "",
                Modified = DateTime.Now,
                NoSearch = false,
                Frequency = SiteMapFrequencyEnum.Always,
                Route = "",
            };
            repository.AddContentPage(cp);
            #endregion

            var shopPages = repository.GetShopTags();
            foreach (Tag t in shopPages)
            {
                cp = new ContentPage()
                {
                    Slug = t.TagName,
                    Title = t.TagName,
                    Author = "Glyn Threadgold",
                    GooglePlusId = null,
                    SortOrder = 0,
                    MetaTitle = "",
                    MetaKeywords = "",
                    MetaDescription = "",
                    Modified = DateTime.Now,
                    NoSearch = false,
                    Frequency = SiteMapFrequencyEnum.Always,
                    Route = "",
                };
                repository.AddContentPage(cp);

            }

            return retVal;

            #endregion
        }


    }
}
