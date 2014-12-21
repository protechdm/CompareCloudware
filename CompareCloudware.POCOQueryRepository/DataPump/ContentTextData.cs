using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CompareCloudware.Domain.Models;
using System.IO;

namespace CompareCloudware.POCOQueryRepository.DataPump
{
    public static class ContentTextData
    {
        public static bool PumpContentTextData(QueryRepository repository)
        {
            string PORTRAIT_FILEPATH = "C:\\Development\\CompareCloudwareVideo\\CompareCloudware.Web\\Images\\Portraits\\";
            //string PORTRAIT_FILEPATH = "J:\\CompareCloudware\\CompareCloudware.Web\\Images\\Portraits\\";
            //string PORTRAIT_ANDREW = "andrewmiller.jpg";
            //string PORTRAIT_CAROLINE = "carolineread.jpg";
            //string PORTRAIT_GARY = "garygould.jpg";
            //string PORTRAIT_IAN = "ianwilson.jpg";
            string PORTRAIT_ANDREW = "Andrew_Management_Shot.jpg";
            string PORTRAIT_CAROLINE = "Caroline_Management_Shot.jpg";
            string PORTRAIT_GARY = "Gary_Management_Shot.jpg";
            string PORTRAIT_IAN = "Ian_Management_Shot.jpg";

            bool retVal = true;

            #region CONTENTTEXT
            ContentText ct;
            string data;
            string compositeID;

            #region PAGE OPTIMISATION TABS
            data = "Need to know more about conferencing?";
            ct = new ContentText
            {
                NiceName = "Title for Conferencing",
                ContentTextType = repository.FindContentTextTypeByName("CONFERENCING_CATEGORY_TITLE"),
                ContentTextData = data,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            #endregion

            #region CATEGORIES TITLES
            data = "Need to know more about conferencing?";
            ct = new ContentText
            {
                NiceName = "Title for Conferencing",
                ContentTextType = repository.FindContentTextTypeByName("CONFERENCING_CATEGORY_TITLE"),
                ContentTextData = data,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "Need to know more about project management tools?";
            ct = new ContentText
            {
                NiceName = "Title for Project management",
                ContentTextType = repository.FindContentTextTypeByName("PROJECTMANAGEMENT_CATEGORY_TITLE"),
                ContentTextData = data,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "Introduction to storage & back-up";
            ct = new ContentText
            {
                NiceName = "Title for Storage & back-up",
                ContentTextType = repository.FindContentTextTypeByName("STORAGEANDBACKUP_CATEGORY_TITLE"),
                ContentTextData = data,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "Need to know more about email?";
            ct = new ContentText
            {
                NiceName = "Title for Email",
                ContentTextType = repository.FindContentTextTypeByName("EMAIL_CATEGORY_TITLE"),
                ContentTextData = data,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "Need to know more about financial apps?";
            ct = new ContentText
            {
                NiceName = "Title for Financial",
                ContentTextType = repository.FindContentTextTypeByName("FINANCIAL_CATEGORY_TITLE"),
                ContentTextData = data,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "Need to know more about office apps?";
            ct = new ContentText
            {
                NiceName = "Title for Office",
                ContentTextType = repository.FindContentTextTypeByName("OFFICE_CATEGORY_TITLE"),
                ContentTextData = data,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "Need to know more about phone services?";
            ct = new ContentText
            {
                NiceName = "Title for Phone",
                ContentTextType = repository.FindContentTextTypeByName("PHONE_CATEGORY_TITLE"),
                ContentTextData = data,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "Need to know more about customer management?";
            ct = new ContentText
            {
                NiceName = "Title for Customer management",
                ContentTextType = repository.FindContentTextTypeByName("CRM_CATEGORY_TITLE"),
                ContentTextData = data,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "Need to know more about security services?";
            ct = new ContentText
            {
                NiceName = "Title for Security",
                ContentTextType = repository.FindContentTextTypeByName("SECURITY_CATEGORY_TITLE"),
                ContentTextData = data,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            #endregion

            #region CATEGORIES BODIES
            #region CONFERENCING
            data = "Meetings are simply unavoidable and part of everyday life. Thankfully, instead of spending endless hours on the road or travelling by train or plane there is now an easier and faster way to connect to customers, colleagues and suppliers. Using your PC, laptop, tablet or smartphone you can simply schedule a web conference.";
            ct = new ContentText
            {
                NiceName = "Body for Conferencing",
                ContentTextType = repository.FindContentTextTypeByName("CONFERENCING_CATEGORY_BODY"),
                ContentTextData = data,
                BodyOrder = 1,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "Think of it as digital ‘teleportation’ where you can set-up or join a meeting instantly and invite participants out of thin air to answer specific questions or queries. Also the ability to share documents and work together on one screen is fantastic compared to a somewhat crowded and huddled affair in the real world. Some providers even use high-definition audio and video which is why we still recommend flossing!";
            ct = new ContentText
            {
                NiceName = "Body for Conferencing",
                ContentTextType = repository.FindContentTextTypeByName("CONFERENCING_CATEGORY_BODY"),
                ContentTextData = data,
                BodyOrder = 2,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "Now at Compare Cloudware, we’re not suggesting you replace all physical meetings with virtual sessions but is does mean you can prioritise the appointments that should be done face-to-face and with a firm handshake.";
            ct = new ContentText
            {
                NiceName = "Body for Conferencing",
                ContentTextType = repository.FindContentTextTypeByName("CONFERENCING_CATEGORY_BODY"),
                ContentTextData = data,
                BodyOrder = 3,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            #endregion

            #region PROJECT MANAGEMENT
            data = "Most of us try our upmost to manage our lives with a dose of common sense, perhaps the occasional ‘to do’ list and maybe even mark a calendar with a special event. For the most part that’s OK but sometimes we need a little extra help and that’s what this category is all about. Here’s how to become a project management whizz!";
            ct = new ContentText
            {
                NiceName = "Body for Project Management",
                ContentTextType = repository.FindContentTextTypeByName("PROJECTMANAGEMENT_CATEGORY_BODY"),
                ContentTextData = data,
                BodyOrder = 1,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "Successful project management is about keeping track of all the important (and seemingly unimportant things) in our more complex endeavours. Making sure certain tasks don’t fall between the cracks will help prevent wasted time, increased costs and rising blood pressure. So whether you’re building an extension, developing an app, keeping tabs on an important assignment or even doing a work project outside your normal comfort zone, we suggest ditching the self-made ‘to do’ list and get something that can really help ease the burden.";
            ct = new ContentText
            {
                NiceName = "Body for Project Management",
                ContentTextType = repository.FindContentTextTypeByName("PROJECTMANAGEMENT_CATEGORY_BODY"),
                ContentTextData = data,
                BodyOrder = 2,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "Now of course you may be able to afford hiring a professional project manager or, better still, actually be one. So if you‘re already a skilled schemer you may find something new here that can help you keep on top of your game.";
            ct = new ContentText
            {
                NiceName = "Body for Project Management",
                ContentTextType = repository.FindContentTextTypeByName("PROJECTMANAGEMENT_CATEGORY_BODY"),
                ContentTextData = data,
                BodyOrder = 3,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            #endregion

            #region STORAGE & BACK-UP
            data = "We humans love collecting things until we’re bursting to the brim with a lifetime of possessions and souvenirs. After a while we usually head to IKEA to box-up old keepsakes and maybe put those boxes in the cupboard, loft or garage for safe-keeping. Ultimately, we either get rid of the accumulating odds and ends or maybe decide to go to a yellow painted self-storage facility!";
            ct = new ContentText
            {
                NiceName = "Body for Storage & Back-Up",
                ContentTextType = repository.FindContentTextTypeByName("STORAGEANDBACKUP_CATEGORY_BODY"),
                ContentTextData = data,
                BodyOrder = 1,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "Now what about your digital life? Instead of having important files, photos and videos spread across multiple computers and moving them around when you buy new devices, wouldn’t be simpler and safer to have all those digital belongings in one manageable place? We think it is. So don’t wait for the ‘blue screen of death’, a stolen smartphone or laptop or even a fire (especially if you happen to live on a remote Caribbean island!) to ruin your digital existence.";
            ct = new ContentText
            {
                NiceName = "Body for Storage & Back-Up",
                ContentTextType = repository.FindContentTextTypeByName("STORAGEANDBACKUP_CATEGORY_BODY"),
                ContentTextData = data,
                BodyOrder = 2,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "Whether it is a lifetime of memories, a treasured music library or essential work documents, storage in the cloud is safer than houses.";
            ct = new ContentText
            {
                NiceName = "Body for Storage & Back-Up",
                ContentTextType = repository.FindContentTextTypeByName("STORAGEANDBACKUP_CATEGORY_BODY"),
                ContentTextData = data,
                BodyOrder = 3,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            #endregion

            #region EMAIL
            data = "Email is one of life’s little treasures isn’t it? In fact with all the spam, junk mail, holiday competitions, cash prizes and coupons, finding the email message you want can sometimes feel like searching for hidden Aztec gold. So ask yourself the question, when was the last time you reviewed your email set-up? Go on admit it, it was probably when the X-Files was still on primetime.";
            ct = new ContentText
            {
                NiceName = "Body for Email",
                ContentTextType = repository.FindContentTextTypeByName("EMAIL_CATEGORY_BODY"),
                ContentTextData = data,
                BodyOrder = 1,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "Now whisper it quietly but email has lived in the Cloud for quite a while and our guess is that you’re already using it with at least one account somewhere in your digital life; whether at home or out and about on your smartphone.";
            ct = new ContentText
            {
                NiceName = "Body for Email",
                ContentTextType = repository.FindContentTextTypeByName("EMAIL_CATEGORY_BODY"),
                ContentTextData = data,
                BodyOrder = 2,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "Well, like everything in the Cloud, you don’t need a dedicated box of electronics to run anything and migrating to another provider with your existing email address is simple and straightforward. Even better you can archive all your email in the Cloud for instant back-up and disaster recovery. And for those of you that are still promoting your Internet Service Provider (ISP) brand in your email address? Shame on you, you’re missing the biggest marketing opportunity since the printing press!";
            ct = new ContentText
            {
                NiceName = "Body for Email",
                ContentTextType = repository.FindContentTextTypeByName("EMAIL_CATEGORY_BODY"),
                ContentTextData = data,
                BodyOrder = 3,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            #endregion

            #region FINANCIAL
            data = "Are you still using spreadsheets to track your spending and payments? Are you still manually cross-referencing bank statements? Or worse, creating customer invoices using a word processor? Keeping track of the pennies is tough enough without creating more mess to try and keep on top of it all.";
            ct = new ContentText
            {
                NiceName = "Body for Financial",
                ContentTextType = repository.FindContentTextTypeByName("FINANCIAL_CATEGORY_BODY"),
                ContentTextData = data,
                BodyOrder = 1,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "Whether you work from home, run a shop or look after a medium sized business, there is a cloudware service for you that makes finance and accounts a picnic rather than a dog’s dinner! So whether it is recording bank payments, looking at cashflow, creating invoices, running a payroll or helping with the tax return, you’ll find something tailored to your needs in this category.";
            ct = new ContentText
            {
                NiceName = "Body for Financial",
                ContentTextType = repository.FindContentTextTypeByName("FINANCIAL_CATEGORY_BODY"),
                ContentTextData = data,
                BodyOrder = 2,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "The good news is that if it does all get too much you can give access to your accountant to help tidy things up, now try and do that with a spreadsheet!";
            ct = new ContentText
            {
                NiceName = "Body for Financial",
                ContentTextType = repository.FindContentTextTypeByName("FINANCIAL_CATEGORY_BODY"),
                ContentTextData = data,
                BodyOrder = 3,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            #endregion

            #region OFFICE
            data = "Do you buy expensive pre-loaded software because it’s less hassle than downloading or using CDs? We have all been guilty of that particular offence but now it’s no longer a sin that needs committing.";
            ct = new ContentText
            {
                NiceName = "Body for Office",
                ContentTextType = repository.FindContentTextTypeByName("OFFICE_CATEGORY_BODY"),
                ContentTextData = data,
                BodyOrder = 1,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "Like all cloud services, office applications and services are delivered on-demand, cheaper than their downloaded counterparts and using the latest version (so no more expensive upgrades!) With most office applications you can even work offline. Even better is the ability for members of a team to work on the same document in real time and retrieve files they need directly from the Cloud rather than somebody’s hard drive.";
            ct = new ContentText
            {
                NiceName = "Body for Office",
                ContentTextType = repository.FindContentTextTypeByName("OFFICE_CATEGORY_BODY"),
                ContentTextData = data,
                BodyOrder = 2,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "Forget about USB storage keys and emailing large documents, all you need is a username and a password to access your documents from anywhere. In addition to the standard fare of office suites, there is an abundance of specialist applications that enable office features on your smartphone, publish directly to a website, integrate with social media or even develop slick presentations with video. So unless you’re downloading yet another office software update or security patch, what are you waiting for?";
            ct = new ContentText
            {
                NiceName = "Body for Office",
                ContentTextType = repository.FindContentTextTypeByName("OFFICE_CATEGORY_BODY"),
                ContentTextData = data,
                BodyOrder = 3,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            #endregion

            #region PHONE
            data = "Need to know more about phone services?";
            ct = new ContentText
            {
                NiceName = "Title for Phone",
                ContentTextType = repository.FindContentTextTypeByName("PHONE_CATEGORY_TITLE"),
                ContentTextData = data,
                BodyOrder = 1,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "The humble phone, great isn’t it? When all else fails at least you can pick-up the phone and talk to somebody. The reality is that one standard phone line only goes so far, well in fact one conversation at a time! How many calls are you missing from prospective customers or worse can existing customers get through to you? In the past, the answer was to get an expensive phone system and multiple phone lines.";
            ct = new ContentText
            {
                NiceName = "Body for Phone",
                ContentTextType = repository.FindContentTextTypeByName("PHONE_CATEGORY_BODY"),
                ContentTextData = data,
                BodyOrder = 1,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "Now with Cloud based phone systems you can have a number of  lines with a single broadband connection with the ability to add smart functionality such as who answers the phone, automatic call routing, out-of-hours messaging, call forwarding, music-on-hold and separate direct dial extensions. Some providers even offer sophisticated call centre functionality with the ability to record calls.";
            ct = new ContentText
            {
                NiceName = "Body for Phone",
                ContentTextType = repository.FindContentTextTypeByName("PHONE_CATEGORY_BODY"),
                ContentTextData = data,
                BodyOrder = 2,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "In most cases you keep your existing number and buy additional extensions as you need them even for staff located in different offices or at home. You won’t need to buy any phone equipment, it’s literally another application available on-demand from the Cloud.";
            ct = new ContentText
            {
                NiceName = "Body for Phone",
                ContentTextType = repository.FindContentTextTypeByName("PHONE_CATEGORY_BODY"),
                ContentTextData = data,
                BodyOrder = 3,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            #endregion

            #region CUSTOMER MANAGEMENT
            data = "Need to know more about customer management?";
            ct = new ContentText
            {
                NiceName = "Title for Customer Management",
                ContentTextType = repository.FindContentTextTypeByName("CRM_CATEGORY_TITLE"),
                ContentTextData = data,
                BodyOrder = 1,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "What is your most important business asset? Well aside from that top of the range coffee machine that makes dreamy cappuccino, it should be your customer (even if you happen to be Costa Coffee!). The cold hard truth, however, is that customers are often neglected instead of being cherished and nurtured like an eggnog latte at Christmas.";
            ct = new ContentText
            {
                NiceName = "Body for Customer Management",
                ContentTextType = repository.FindContentTextTypeByName("CRM_CATEGORY_BODY"),
                ContentTextData = data,
                BodyOrder = 1,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "The reality is that if you’re out and about, have more than a handful of clients and a few staff that need to share customer information, you need something better than scraps of paper, post-it notes, email and office software. With Cloud based customer relationship management (known in the IT trade as CRM), you can keep in touch with customers or prospective customers at a touch of a button.";
            ct = new ContentText
            {
                NiceName = "Body for Customer Management",
                ContentTextType = repository.FindContentTextTypeByName("CRM_CATEGORY_BODY"),
                ContentTextData = data,
                BodyOrder = 2,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "Most services are easy to set-up and even work with cloud based email and phone systems. You can even integrate enquiry forms on your website to generate new business or help existing customers whilst using your smartphone to keep on top of what’s happening. Before you know it, you’ll be running customer campaigns, running a virtual helpdesk and forecasting sales like the big boys but at a tiny fraction of the cost!";
            ct = new ContentText
            {
                NiceName = "Body for Customer Management",
                ContentTextType = repository.FindContentTextTypeByName("CRM_CATEGORY_BODY"),
                ContentTextData = data,
                BodyOrder = 3,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            #endregion

            #region SECURITY
            data = "Going into overdrive with our ‘digital life’ is great – whether it’s at work or at home. But the risk to those files, records, photos, designs and recordings is immense. So many treasured and valued documents - many are irreplaceable and others are just plain valuable! With all today’s threats, what actions do you take to keep yourself safe?";
            ct = new ContentText
            {
                NiceName = "Body for Security",
                ContentTextType = repository.FindContentTextTypeByName("SECURITY_CATEGORY_BODY"),
                ContentTextData = data,
                BodyOrder = 1,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "What should you do to protect all your devices and content – from tablet to phone, from email to database? Protection from scammers, hackers, identity thieves, and chancers could seem like a full time occupation – especially in today’s get-rich-quick culture. So, how do you make sure you don’t ‘star’ in The Hustle – or just lose all your data thanks to a good old-fashioned virus?";
            ct = new ContentText
            {
                NiceName = "Body for Security",
                ContentTextType = repository.FindContentTextTypeByName("SECURITY_CATEGORY_BODY"),
                ContentTextData = data,
                BodyOrder = 2,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "The answer could be one solution. The answer could be a few. Whichever one it is, it’ll be on Compare Cloudware – and it’s waiting for you to discover it. Simply enter your requirements to get ‘digital lock-down’. You’ll get the peace of mind that you’re doing everything you should to protect and defend your stuff.";
            ct = new ContentText
            {
                NiceName = "Body for Security",
                ContentTextType = repository.FindContentTextTypeByName("SECURITY_CATEGORY_BODY"),
                ContentTextData = data,
                BodyOrder = 3,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            #endregion

            #endregion

            #region CLOUDWARE EXPLAINED
            data = "Cloudware is changing the way companies, enterprises and organisations work, but what exactly is it, what are the advantages and why is it generating so much interest? This short guide will give you the answers and turn you into a cloudware expert.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("CLOUDWAREEXPLAINEDPAGE_TITLE"),
                ContentTextData = data,
                BodyOrder = 1,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            #region CLOUDWARE EXPLAINED TAB
            compositeID = Guid.NewGuid().ToString();
            data = "Cloudware explained";
            ct = new ContentText
            {
                NiceName = "",
                CompositeID = compositeID,
                ContentTextType = repository.FindContentTextTypeByName("CLOUDWAREEXPLAINED_TAB_TITLE"),
                ContentTextData = data,
                BodyOrder = 1,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            compositeID = Guid.NewGuid().ToString();
            data = "What is the cloud?";
            ct = new ContentText
            {
                NiceName = "",
                CompositeID = compositeID,
                ContentTextType = repository.FindContentTextTypeByName("CLOUDWAREEXPLAINED_SECTION_TITLE"),
                ContentTextData = data,
                BodyOrder = 2,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "The term ‘Cloud’ or ‘Cloud Computing’ is now a common term that simply means accessing programs and services directly over the internet rather than using a local computer or network. Instead of using time-consuming CDs or downloading programs you simply access programs directly through your internet browser such as Explorer, Firefox, Safari or Chrome.";
            ct = new ContentText
            {
                NiceName = "",
                CompositeID = compositeID,
                ContentTextType = repository.FindContentTextTypeByName("CLOUDWAREEXPLAINED_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 3,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
                LineBreakBefore = true,
                LineBreakAfter = true,
            };
            repository.AddContentText(ct);

            data = "In fact you are most certainly using the Cloud already if you use Facebook or Twitter, make phonecalls on Skype, stream music on Spotify, watch a You Tube video or send an email. These are all Cloud services that require huge processing power in a centralised locations (called Data Centres) around the World.";
            ct = new ContentText
            {
                NiceName = "",
                CompositeID = compositeID,
                ContentTextType = repository.FindContentTextTypeByName("CLOUDWAREEXPLAINED_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 4,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
                LineBreakAfter = true,
            };
            repository.AddContentText(ct);
            
            
            compositeID = Guid.NewGuid().ToString();
            data = "What is cloudware?";
            ct = new ContentText
            {
                NiceName = "",
                CompositeID = compositeID,
                ContentTextType = repository.FindContentTextTypeByName("CLOUDWAREEXPLAINED_SECTION_TITLE"),
                ContentTextData = data,
                BodyOrder = 5,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
                LineBreakBefore = true,
            };
            repository.AddContentText(ct);
            //data = "Cloudware is any application or service delivered through an internet browser to PCs, laptops or smartphones. Users don’t need to buy and install software on their machines, and neither do they need high-end hardware. Because everything is accessed through the cloud, an internet connection is all that is required.";
            data = "Cloudware is simply any software, service or application that is delivered via the Cloud to any internet enabled device such as a computer, tablet or phone. Cloudware allows virtually any  IT and Communication servicess to be  available on-demand through the internet. Think of it as internet generation software and services with little or no upfront cost and without the supporting cast of bulky hardware, lengthy installations, annoying updates and expensive maintenance agreements.";
            ct = new ContentText
            {
                NiceName = "",
                CompositeID = compositeID,
                ContentTextType = repository.FindContentTextTypeByName("CLOUDWAREEXPLAINED_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 6,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
                LineBreakBefore = true,
                LineBreakAfter = true,
            };
            repository.AddContentText(ct);



            compositeID = Guid.NewGuid().ToString();
            data = "What is Compare Cloudware?";
            ct = new ContentText
            {
                NiceName = "",
                CompositeID = compositeID,
                ContentTextType = repository.FindContentTextTypeByName("CLOUDWAREEXPLAINED_SECTION_TITLE"),
                ContentTextData = data,
                BodyOrder = 7,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            //data = "Cloudware is any application or service delivered through an internet browser to PCs, laptops or smartphones. Users don’t need to buy and install software on their machines, and neither do they need high-end hardware. Because everything is accessed through the cloud, an internet connection is all that is required.";
            data = "Compare Cloudware is the first comparison website for a range of everyday and specialised IT and communication services, software and applications. It provides like-for-like comparisons against key criteria including number of users, support levels, price, languages and features. By doing this it simplifies the selection and purchase from hours (often days) to a few minutes.";
            ct = new ContentText
            {
                NiceName = "",
                CompositeID = compositeID,
                ContentTextType = repository.FindContentTextTypeByName("CLOUDWAREEXPLAINED_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 8,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
                LineBreakBefore = true,
                LineBreakAfter = true,
            };
            repository.AddContentText(ct);
            data = "Without the need for endless search, time consuming assessment and awkward evaluation, Compare Cloudware offers knowledgable search, intuitive comparison, relevant product reviews and independent user reviews which enable you to choose the right Cloudware for your needs.";
            ct = new ContentText
            {
                NiceName = "",
                CompositeID = compositeID,
                ContentTextType = repository.FindContentTextTypeByName("CLOUDWAREEXPLAINED_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 9,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
                LineBreakAfter = true,
            };
            repository.AddContentText(ct);
            data = "The result? Compare Cloudware makes IT and Communications applications and services comparable and accessible with the click of a button";
            ct = new ContentText
            {
                NiceName = "",
                CompositeID = compositeID,
                ContentTextType = repository.FindContentTextTypeByName("CLOUDWAREEXPLAINED_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 10,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
                LineBreakAfter = true,
            };
            repository.AddContentText(ct);




            compositeID = Guid.NewGuid().ToString();
            data = "What do I need to run Cloudware?";
            ct = new ContentText
            {
                NiceName = "",
                CompositeID = compositeID,
                ContentTextType = repository.FindContentTextTypeByName("CLOUDWAREEXPLAINED_SECTION_TITLE"),
                ContentTextData = data,
                BodyOrder = 11,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "To get started all you need is a broadband internet connection and a device capable of connecting to the Internet e.g. a PC, Laptop, Netbook, Tablet or Smartphone";
            ct = new ContentText
            {
                NiceName = "",
                CompositeID = compositeID,
                ContentTextType = repository.FindContentTextTypeByName("CLOUDWAREEXPLAINED_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 12,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
                LineBreakBefore = true,
                LineBreakAfter = true,
            };
            repository.AddContentText(ct);
            data = "Nearly all internet capable devices made in the last 3 years will run Cloudware quite happily. Even mobile devices such as smartphone and tablets using Apple’s IoS or Android will work effectively with most Cloudware.";
            ct = new ContentText
            {
                NiceName = "",
                CompositeID = compositeID,
                ContentTextType = repository.FindContentTextTypeByName("CLOUDWAREEXPLAINED_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 13,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
                LineBreakAfter = true,
            };
            repository.AddContentText(ct);
            data = "The majority of users will use a PC, laptops and/or netbook. Here is a run down of the minimum operating requirements as recommended by Cloudware providers.For Windows PC users: The minimum systems requirements are: Windows 7, Windows 8, or Windows 2008 R2 with .NET 3.5 or later and Microsoft Internet Explorer 8, 9, or 10; Mozilla Firefox 10.x or a later version; or Google Chrome 17.x.. For OSX Mac users: The minimum system requirements are: Mac OS X 10.6 or later; Apple Safari 5 or above.";
            ct = new ContentText
            {
                NiceName = "",
                CompositeID = compositeID,
                ContentTextType = repository.FindContentTextTypeByName("CLOUDWAREEXPLAINED_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 14,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
                LineBreakAfter = true,
            };
            repository.AddContentText(ct);
            #endregion

            #region 10 REASONS FOR USING CLOUDWARE
            data = "10 reasons for using Cloudware";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("10REASONSFORUSINGCLOUDWARE_TAB_TITLE"),
                ContentTextData = data,
                BodyOrder = 15,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);


            compositeID = Guid.NewGuid().ToString();
            data = "Reduced risk";
            ct = new ContentText
            {
                NiceName = "",
                CompositeID = compositeID,
                ContentTextType = repository.FindContentTextTypeByName("10REASONSFORUSINGCLOUDWARE_SECTION_TITLE"),
                ContentTextData = data,
                BodyOrder = 16,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "It’s distressing enough that personal data loss can mean a lifetime of memories gone forever but for a business it can be fatal. Simply put, data loss kills businesses. According to the UK’s Department of Trade & Industry, over 70% of businesses that suffer data loss close within 18 months.";
            ct = new ContentText
            {
                NiceName = "",
                CompositeID = compositeID,
                ContentTextType = repository.FindContentTextTypeByName("10REASONSFORUSINGCLOUDWARE_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 17,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
                LineBreakBefore = true,
                LineBreakAfter = true,
            };
            repository.AddContentText(ct);
            data = "All Cloudware providers have comprehensive back-up processes and procedures which ensure your data is fully protected around-the-clock in leading edge facilities using the latest infrastructure. Commonly, data is stored in multiple locations to ensure that any single point of potential failure or attack is fully mitigated.";
            ct = new ContentText
            {
                NiceName = "",
                CompositeID = compositeID,
                ContentTextType = repository.FindContentTextTypeByName("10REASONSFORUSINGCLOUDWARE_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 18,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
                LineBreakAfter = true,
            };
            repository.AddContentText(ct);


            compositeID = Guid.NewGuid().ToString();
            data = "No or little upfront costs";
            ct = new ContentText
            {
                NiceName = "",
                CompositeID = compositeID,
                ContentTextType = repository.FindContentTextTypeByName("10REASONSFORUSINGCLOUDWARE_SECTION_TITLE"),
                ContentTextData = data,
                BodyOrder = 19,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "The purchase of traditional IT and communications equipment and software is an expensive undertaking. This often involves some compromise due to sizeable upfront costs which most smaller businesses struggle to afford.";
            ct = new ContentText
            {
                NiceName = "",
                CompositeID = compositeID,
                ContentTextType = repository.FindContentTextTypeByName("10REASONSFORUSINGCLOUDWARE_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 20,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
                LineBreakBefore = true,
                LineBreakAfter = true,
            };
            repository.AddContentText(ct);
            data = "Not so with Cloudware, as there’s no upfront equipment cost or software licences to buy. With little to no commitment, Cloudware is offered on a monthly subscription allowing customers to renew or cancel their terms without major repercussions. In fact , many businesses find that Cloudware actually eases cashflow as they can usually enjoy a free trial period, paying monthly on a per-user basis with a short notice period in the event of cancellation.";
            ct = new ContentText
            {
                NiceName = "",
                CompositeID = compositeID,
                ContentTextType = repository.FindContentTextTypeByName("10REASONSFORUSINGCLOUDWARE_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 21,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
                LineBreakAfter = true,
            };
            repository.AddContentText(ct);


            compositeID = Guid.NewGuid().ToString();
            data = "More control";
            ct = new ContentText
            {
                NiceName = "",
                CompositeID = compositeID,
                ContentTextType = repository.FindContentTextTypeByName("10REASONSFORUSINGCLOUDWARE_SECTION_TITLE"),
                ContentTextData = data,
                BodyOrder = 22,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "Keeping up to date with the latest IT and Communications services has traditionally been a problem for smaller businesses. With little or no ‘IT budget’, the idea of updating software or replacing old hardware normally arrives when something doesn’t work anymore or simply breaks!";
            ct = new ContentText
            {
                NiceName = "",
                CompositeID = compositeID,
                ContentTextType = repository.FindContentTextTypeByName("10REASONSFORUSINGCLOUDWARE_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 23,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
                LineBreakBefore = true,
                LineBreakAfter = true,
            };
            repository.AddContentText(ct);
            data = "With Cloudware, there are no nasty surprises as charges are typically priced on a flat rate and you pay for what you use (rather like renting a car or paying your electricity bill). Spend can be tightly controlled and some firms have cut IT delivery costs by as much as 90% simply by switching to a Cloud alternative.";
            ct = new ContentText
            {
                NiceName = "",
                CompositeID = compositeID,
                ContentTextType = repository.FindContentTextTypeByName("10REASONSFORUSINGCLOUDWARE_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 24,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
                LineBreakAfter = true,
            };
            repository.AddContentText(ct);


            compositeID = Guid.NewGuid().ToString();
            data = "Easy management";
            ct = new ContentText
            {
                NiceName = "",
                CompositeID = compositeID,
                ContentTextType = repository.FindContentTextTypeByName("10REASONSFORUSINGCLOUDWARE_SECTION_TITLE"),
                ContentTextData = data,
                BodyOrder = 25,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "At some time or other, everyone suffers from an IT headache, it may be a simple re-boot, a software re-installation or ringing ‘IT Bob’ down the road. Most businesses don’t have IT staff on hand to fix the myriad of hardware and software problems which wastes valuable time and resources whilst trying to figure things out.";
            ct = new ContentText
            {
                NiceName = "",
                CompositeID = compositeID,
                ContentTextType = repository.FindContentTextTypeByName("10REASONSFORUSINGCLOUDWARE_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 26,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
                LineBreakBefore = true,
                LineBreakAfter = true,
            };
            repository.AddContentText(ct);
            data = "All Cloudware is available through your preferred internet browser with software patches and updates automatically applied. Cloudware is always kept ‘live’ as providers fix systems in real-time without any service disruption. This leaves you to get on with running your business trouble-free. In the world of Cloudware, you’re buying a service and not a problem waiting to happen.";
            ct = new ContentText
            {
                NiceName = "",
                CompositeID = compositeID,
                ContentTextType = repository.FindContentTextTypeByName("10REASONSFORUSINGCLOUDWARE_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 27,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
                LineBreakAfter = true,
            };
            repository.AddContentText(ct);


            compositeID = Guid.NewGuid().ToString();
            data = "Scale up or down";
            ct = new ContentText
            {
                NiceName = "",
                CompositeID = compositeID,
                ContentTextType = repository.FindContentTextTypeByName("10REASONSFORUSINGCLOUDWARE_SECTION_TITLE"),
                ContentTextData = data,
                BodyOrder = 28,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "With traditional IT and communications, small businesses often need to gaze into a crystal ball and predict their requirements long in advance. Like so many predictions, this typically ends up being wrong. The result? Wastage at one end or a shortage of available resources at the other. Either way, it’s bad news.";
            ct = new ContentText
            {
                NiceName = "",
                CompositeID = compositeID,
                ContentTextType = repository.FindContentTextTypeByName("10REASONSFORUSINGCLOUDWARE_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 29,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
                LineBreakBefore = true,
                LineBreakAfter = true,
            };
            repository.AddContentText(ct);
            data = "Even if you don’t have desk space available, there is the flexibility to work from another office or home using the same systems. This can be beneficial for any seasonal changes or where a large order comes in which may need some additional help. In any case, the crystal ball can be replaced with the certainty of real life ups and downs.";
            ct = new ContentText
            {
                NiceName = "",
                CompositeID = compositeID,
                ContentTextType = repository.FindContentTextTypeByName("10REASONSFORUSINGCLOUDWARE_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 30,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
                LineBreakAfter = true,
            };
            repository.AddContentText(ct);

            compositeID = Guid.NewGuid().ToString();
            data = "Increased security";
            ct = new ContentText
            {
                NiceName = "",
                CompositeID = compositeID,
                ContentTextType = repository.FindContentTextTypeByName("10REASONSFORUSINGCLOUDWARE_SECTION_TITLE"),
                ContentTextData = data,
                BodyOrder = 31,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "Security and safety can be a concern with anything perceived as ‘new’. Small businesses generally have lower physical security deterrents making the hardware closet and devices such as desktop computers vulnerable. Worse still, they have no or few resources available to monitor and combat cyber threats. In almost all cases Cloudware is far more robust than anything a small or even medium-sized businesses could reasonably afford.";
            ct = new ContentText
            {
                NiceName = "",
                CompositeID = compositeID,
                ContentTextType = repository.FindContentTextTypeByName("10REASONSFORUSINGCLOUDWARE_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 32,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
                LineBreakBefore = true,
                LineBreakAfter = true,
            };
            repository.AddContentText(ct);
            data = "Cloudware providers have facilities that are shielded by many layers of security, operational best practices, multi-site disaster recovery, military grade firewalls and internet security with frequent patching and testing.";
            ct = new ContentText
            {
                NiceName = "",
                CompositeID = compositeID,
                ContentTextType = repository.FindContentTextTypeByName("10REASONSFORUSINGCLOUDWARE_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 33,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
                LineBreakAfter = true,
            };
            repository.AddContentText(ct);


            compositeID = Guid.NewGuid().ToString();
            data = "Greater flexibility";
            ct = new ContentText
            {
                NiceName = "",
                CompositeID = compositeID,
                ContentTextType = repository.FindContentTextTypeByName("10REASONSFORUSINGCLOUDWARE_SECTION_TITLE"),
                ContentTextData = data,
                BodyOrder = 34,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "In the small business world, things can change very quickly. It’s a pain having to wait for new software to be deployed, phones to be set up or training to be organised. Worse still, such delays can have a major influence on taking a large order or servicing new customers.";
            ct = new ContentText
            {
                NiceName = "",
                CompositeID = compositeID,
                ContentTextType = repository.FindContentTextTypeByName("10REASONSFORUSINGCLOUDWARE_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 35,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
                LineBreakBefore = true,
                LineBreakAfter = true,
            };
            repository.AddContentText(ct);
            data = "The flexibility afforded by Cloudware can mean the difference between being an innovator or being late to the game. The Cloud’s self-service approach makes it easy to select and buy the right solution in hours rather than days. With Compare Cloudware, that job is made even easier.";
            ct = new ContentText
            {
                NiceName = "",
                CompositeID = compositeID,
                ContentTextType = repository.FindContentTextTypeByName("10REASONSFORUSINGCLOUDWARE_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 36,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
                LineBreakAfter = true,
            };
            repository.AddContentText(ct);


            compositeID = Guid.NewGuid().ToString();
            data = "Simpler IT setup";
            ct = new ContentText
            {
                NiceName = "",
                CompositeID = compositeID,
                ContentTextType = repository.FindContentTextTypeByName("10REASONSFORUSINGCLOUDWARE_SECTION_TITLE"),
                ContentTextData = data,
                BodyOrder = 37,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "As businesses grow, the need to offer more and more users more and more applications on their PCs, laptops and smartphones can become an IT headache. Because cloudware and the data it generates is accessed remotely, it removes the need for a large IT infrastructure.";
            ct = new ContentText
            {
                NiceName = "",
                CompositeID = compositeID,
                ContentTextType = repository.FindContentTextTypeByName("10REASONSFORUSINGCLOUDWARE_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 38,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
                LineBreakBefore = true,
                LineBreakAfter = true,
            };
            repository.AddContentText(ct);


            compositeID = Guid.NewGuid().ToString();
            data = "Go mobile";
            ct = new ContentText
            {
                NiceName = "",
                CompositeID = compositeID,
                ContentTextType = repository.FindContentTextTypeByName("10REASONSFORUSINGCLOUDWARE_SECTION_TITLE"),
                ContentTextData = data,
                BodyOrder = 39,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "The globe has gone mobile with more laptops,  smartphones and tablets on our little blue planet than people. This has lead to an increase in mobility working but the consequences can actually lead to disconnection. The Cloud offers the ideal opportunity to reconnect. Managers can keep in touch swiftly with real-time updates and reports.";
            ct = new ContentText
            {
                NiceName = "",
                CompositeID = compositeID,
                ContentTextType = repository.FindContentTextTypeByName("10REASONSFORUSINGCLOUDWARE_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 40,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
                LineBreakBefore = true,
                LineBreakAfter = true,
            };
            repository.AddContentText(ct);
            data = "Road warriors can follow-up on the status of an order without calling and chasing the office first. Remote workers can seamlessly integrate as part of a virtual team as though they are in the same room. Sounds great doesn’t it? It is and with Cloudware it takes little effort to hook everyone back up on any device, at anytime, wherever they may be.";
            ct = new ContentText
            {
                NiceName = "",
                CompositeID = compositeID,
                ContentTextType = repository.FindContentTextTypeByName("10REASONSFORUSINGCLOUDWARE_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 41,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
                LineBreakAfter = true,
            };
            repository.AddContentText(ct);


            compositeID = Guid.NewGuid().ToString();
            data = "Always up-to-date";
            ct = new ContentText
            {
                NiceName = "",
                CompositeID = compositeID,
                ContentTextType = repository.FindContentTextTypeByName("10REASONSFORUSINGCLOUDWARE_SECTION_TITLE"),
                ContentTextData = data,
                BodyOrder = 42,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "Office and home PCs and laptops are cluttered with old and out-of-date software. This often results in poor performance which over time gets slower and slower and increasingly frustrating for the user. The dilemma is often between the cost of replacement and the cost of doing nothing whilst waiting for another re-boot or a software patch to download.";
            ct = new ContentText
            {
                NiceName = "",
                CompositeID = compositeID,
                ContentTextType = repository.FindContentTextTypeByName("10REASONSFORUSINGCLOUDWARE_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 43,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
                LineBreakBefore = true,
                LineBreakAfter = true,
            };
            repository.AddContentText(ct);
            data = "Forget obsolete software, with Cloudware you’re always up-to-date and able to enjoy updates, new features and and improved functionality as part of the service without any disruption. Better still, there is no annoying re-purchase after three years to get the latest version of something you already have.";
            ct = new ContentText
            {
                NiceName = "",
                CompositeID = compositeID,
                ContentTextType = repository.FindContentTextTypeByName("10REASONSFORUSINGCLOUDWARE_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 44,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
                LineBreakAfter = true,
            };
            repository.AddContentText(ct);

            #endregion

            #region WHAT DOES MY BUSINESS NEED TO RUN CLOUDWARE
            compositeID = Guid.NewGuid().ToString();
            data = "What does my business need to run Cloudware?";
            ct = new ContentText
            {
                NiceName = "",
                CompositeID = compositeID,
                ContentTextType = repository.FindContentTextTypeByName("WHATDOESMYBUSINESSNEEDTORUNCLOUDWARE_TAB_TITLE"),
                ContentTextData = data,
                BodyOrder = 45,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "Cloudware is changing the way companies and organisations do business. Naturally, however, there will be some reservations about turning to a subscription-based software service.";
            ct = new ContentText
            {
                NiceName = "",
                CompositeID = compositeID,
                ContentTextType = repository.FindContentTextTypeByName("WHATDOESMYBUSINESSNEEDTORUNCLOUDWARE_TAB_HEADER"),
                ContentTextData = data,
                BodyOrder = 46,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
                LineBreakAfter = true,
            };
            repository.AddContentText(ct);

            data = "We’ve tried to answer the most commonly asked questions about how to ensure your business is ready for cloudware below, but if you have other questions, take a look through the Forums to see if they have been asked before, or raise the question yourself.";
            ct = new ContentText
            {
                NiceName = "",
                CompositeID = compositeID,
                ContentTextType = repository.FindContentTextTypeByName("WHATDOESMYBUSINESSNEEDTORUNCLOUDWARE_TAB_HEADER"),
                ContentTextData = data,
                BodyOrder = 47,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
                LineBreakAfter = true,
            };
            repository.AddContentText(ct);

            compositeID = Guid.NewGuid().ToString();
            data = "What versions of browsers are required?";
            ct = new ContentText
            {
                NiceName = "",
                CompositeID = compositeID,
                ContentTextType = repository.FindContentTextTypeByName("WHATDOESMYBUSINESSNEEDTORUNCLOUDWARE_SECTION_TITLE"),
                ContentTextData = data,
                BodyOrder = 48,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "Most cloudware applications and services run with all of the most popular internet browsers including Internet Explorer, Firefox and Safari. They will normally run using older versions of the browsers, but for optimum performance we recommend downloading the latest version. For specific details, check the ‘Internet Browser’ section of the comparison table.";
            ct = new ContentText
            {
                NiceName = "",
                CompositeID = compositeID,
                ContentTextType = repository.FindContentTextTypeByName("WHATDOESMYBUSINESSNEEDTORUNCLOUDWARE_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 49,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
                LineBreakBefore = true,
                LineBreakAfter = true,
            };
            repository.AddContentText(ct);


            compositeID = Guid.NewGuid().ToString();
            data = "What broadband speed is required?";
            ct = new ContentText
            {
                NiceName = "",
                CompositeID = compositeID,
                ContentTextType = repository.FindContentTextTypeByName("WHATDOESMYBUSINESSNEEDTORUNCLOUDWARE_SECTION_TITLE"),
                ContentTextData = data,
                BodyOrder = 50,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "Cloudware applications and services are designed to run on any broadband connection, whether at home, in the office, or through a mobile. Do be aware, however, that typical business broadband speeds are around 20 Mpbs, while broadband speeds at home and on mobiles are lower. Applications and services will therefore always run faster in office environments.";
            ct = new ContentText
            {
                NiceName = "",
                CompositeID = compositeID,
                ContentTextType = repository.FindContentTextTypeByName("WHATDOESMYBUSINESSNEEDTORUNCLOUDWARE_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 51,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
                LineBreakBefore = true,
                LineBreakAfter = true,
            };
            repository.AddContentText(ct);


            compositeID = Guid.NewGuid().ToString();
            data = "How many users can access the same cloudware at the same time?";
            ct = new ContentText
            {
                NiceName = "",
                CompositeID = compositeID,
                ContentTextType = repository.FindContentTextTypeByName("WHATDOESMYBUSINESSNEEDTORUNCLOUDWARE_SECTION_TITLE"),
                ContentTextData = data,
                BodyOrder = 52,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "This depends on the cloudware application or service being used. Some products are limited to a small number of users, others can be accessed by hundreds of users. Check the ‘Users’ section in the comparison table to confirm the exact number.";
            ct = new ContentText
            {
                NiceName = "",
                CompositeID = compositeID,
                ContentTextType = repository.FindContentTextTypeByName("WHATDOESMYBUSINESSNEEDTORUNCLOUDWARE_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 53,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
                LineBreakBefore = true,
                LineBreakAfter = true,
            };
            repository.AddContentText(ct);


            compositeID = Guid.NewGuid().ToString();
            data = "What mobile platforms are supported?";
            ct = new ContentText
            {
                NiceName = "",
                CompositeID = compositeID,
                ContentTextType = repository.FindContentTextTypeByName("WHATDOESMYBUSINESSNEEDTORUNCLOUDWARE_SECTION_TITLE"),
                ContentTextData = data,
                BodyOrder = 54,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
                LineBreakBefore = true,
            };
            repository.AddContentText(ct);
            data = "The three major mobile platforms in the UK — Apple, BlackBerry and Android — are supported by cloudware applications and services, with some vendors working on one or two platforms and others working on all of them. When you compare different products, check the ‘Mobile platform’ feature to ensure your mobile platform is included.";
            ct = new ContentText
            {
                NiceName = "",
                CompositeID = compositeID,
                ContentTextType = repository.FindContentTextTypeByName("WHATDOESMYBUSINESSNEEDTORUNCLOUDWARE_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 55,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
                LineBreakBefore = true,
                LineBreakAfter = true,
            };
            repository.AddContentText(ct);


            compositeID = Guid.NewGuid().ToString();
            data = "What level of mobile broadband is required?";
            ct = new ContentText
            {
                NiceName = "",
                CompositeID = compositeID,
                ContentTextType = repository.FindContentTextTypeByName("WHATDOESMYBUSINESSNEEDTORUNCLOUDWARE_SECTION_TITLE"),
                ContentTextData = data,
                BodyOrder = 56,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "One of the big advantages of Cloudware applications and services is their ability to be accessed on mobile devices like smartphones. To ensure the optimum performance, we recommend a minimum 3G connection. Check with your mobile phone provider to ensure your mobile devices are 3G or 4G with Wi-Fi ‘hotspot’ capability.";
            ct = new ContentText
            {
                NiceName = "",
                CompositeID = compositeID,
                ContentTextType = repository.FindContentTextTypeByName("WHATDOESMYBUSINESSNEEDTORUNCLOUDWARE_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 57,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
                LineBreakBefore = true,
                LineBreakAfter = true,
            };
            repository.AddContentText(ct);


            compositeID = Guid.NewGuid().ToString();
            data = "What settings need to be turned on within the operating system ?";
            ct = new ContentText
            {
                NiceName = "",
                CompositeID = compositeID,
                ContentTextType = repository.FindContentTextTypeByName("WHATDOESMYBUSINESSNEEDTORUNCLOUDWARE_SECTION_TITLE"),
                ContentTextData = data,
                BodyOrder = 58,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "Cloudware applications and services typically use a combination of plug-ins and Java. This allows them to work on multiple devices. You should therefore check the preferences in your browser settings to ensure plug-ins, Java and JavaScript are all enabled.";
            ct = new ContentText
            {
                NiceName = "",
                CompositeID = compositeID,
                ContentTextType = repository.FindContentTextTypeByName("WHATDOESMYBUSINESSNEEDTORUNCLOUDWARE_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 59,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
                LineBreakBefore = true,
                LineBreakAfter = true,
            };
            repository.AddContentText(ct);
            #endregion


            #endregion


            #region ABOUT US
            data = "About us";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("ABOUTUS_TITLE"),
                ContentTextData = data,
                BodyOrder = 1,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "About us";
            ct = new ContentText
            {
                NiceName = "",
                CompositeID = compositeID,
                ContentTextType = repository.FindContentTextTypeByName("ABOUTUS_SECTION_TITLE"),
                ContentTextData = data,
                BodyOrder = 1,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "Cloudware, or Software as a Service (SaaS), has been around for a long time. Think of Hotmail or Salesforce.com and you get the picture. What hasn’t emerged until now is a one-stop resource for the research, comparison and selection of cloudware.";
            ct = new ContentText
            {
                NiceName = "",
                CompositeID = compositeID,
                ContentTextType = repository.FindContentTextTypeByName("ABOUTUS_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 1,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "Compare Cloudware is the first website to recognise the importance of choice, independent advice and easy access to cloud providers. Put simply, we cut through the hype and potential confusion of choosing on-demand software and services.";
            ct = new ContentText
            {
                NiceName = "",
                CompositeID = compositeID,
                ContentTextType = repository.FindContentTextTypeByName("ABOUTUS_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 2,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            //data = "That’s where Compare Cloudware steps in. As the first website to recognise the importance of choice, independent advice and easy access to cloud providers, we cut through the hype and confusion of choosing on-demand software and services.";
            data = "We’re the first comprehensive digital sales channel for vendors and a user-friendly resource for businesses who want to take full advantage of cloudware.";
            ct = new ContentText
            {
                NiceName = "",
                CompositeID = compositeID,
                ContentTextType = repository.FindContentTextTypeByName("ABOUTUS_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 3,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            //data = "With a solid understanding of marketing and sales, cloud technologies and services, we provide the first comprehensive digital sales channel for vendors and a trusted source of advice for growing businesses.";
            data = "We help vendors reach growing businesses efficiently and cost-effectively. And we help businesses to compare the features, benefits and costs of cloud services and applications, make a choice and start using them.";
            ct = new ContentText
            {
                NiceName = "",
                CompositeID = compositeID,
                ContentTextType = repository.FindContentTextTypeByName("ABOUTUS_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 4,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            //data = "For vendors and businesses alike, Compare Cloudware offers a user experience that is focused on what they really need. Vendors can target growing businesses efficiently and cost-effectively. Businesses can access a unique guide to services and applications available in the cloud and use an online comparison tool to find the perfect solution.";
            //ct = new ContentText
            //{
            //    NiceName = "",
            //    CompositeID = compositeID,
            //    ContentTextType = repository.FindContentTextTypeByName("ABOUTUS_SECTION_BODY"),
            //    ContentTextData = data,
            //    BodyOrder = 4,
            //    ContentTextStatus = repository.FindStatusByName("LIVE"),
            //};
            //repository.AddContentText(ct);
            data = "Compare Cloudware. We’re opening the cloud for business.";
            ct = new ContentText
            {
                NiceName = "",
                CompositeID = compositeID,
                ContentTextType = repository.FindContentTextTypeByName("ABOUTUS_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 5,
                IsBold = true,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            #endregion

            #region MANAGEMENT TEAM
            data = "Management team";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("MANAGEMENTTEAM_TITLE"),
                ContentTextData = data,
                BodyOrder = 1,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            compositeID = Guid.NewGuid().ToString();
            //data = "Compare Cloudware was founded by a team of professionals who have been at the forefront of the IT sector for many years. Their combined knowledge of the technologies and systems of virtually every major IT provider has provided the insight necessary to make Compare Cloudware a unique one-stop marketplace for cloudware users and vendors.";
            data = "The founding team for Compare Cloudware is a group of professionals who have been at the forefront of the IT sector for many years. Our combined knowledge of the technologies and systems of virtually every major IT provider and frontline market experience has given us the insight and expertise to make Compare Cloudware a unique and effective marketplace for cloudware users and vendors.";
            ct = new ContentText
            {
                NiceName = "",
                CompositeID = compositeID,
                ContentTextType = repository.FindContentTextTypeByName("MANAGEMENTTEAM_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 2,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            compositeID = Guid.NewGuid().ToString();
            data = "Andrew Miller, Director";
            ct = new ContentText
            {
                NiceName = "",
                CompositeID = compositeID,
                ContentTextType = repository.FindContentTextTypeByName("MANAGEMENTTEAM_SECTION_TITLE"),
                ContentTextData = data,
                BodyOrder = 3,
                IsBold = true,
                ContentTextGraphic = GetImageAsBytes(PORTRAIT_FILEPATH + PORTRAIT_ANDREW),
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            //data = "As the Managing Director of Wilson Miller, a leading technology marketing agency, Andrew has worked with some of the leading brands in information and technology including AT&T, HP, Cisco, McAfee, Cable&Wireless, and NEC. He has over 20 years’ experience in marketing and technology and has previously worked with major players like the WPP Group and PricewaterhouseCoopers.";
            //data = "As the Managing Director of Wilson Miller, a leading technology marketing agency, Andrew has worked with global brands including AT&T, HP, Cisco, McAfee, Cable&Wireless, and NEC. He has over 20 years’ experience in marketing and technology and has previously worked for the WPP Group and PricewaterhouseCoopers.";
            data = "Andrew has worked with global brands including AT&T, HP, Cisco, McAfee and Oracle through his leadership of technology marketing agencies Wilson Miller and The Rubicon Agency. He has over 20 years’ experience in marketing and technology and has previously worked for the WPP Group and PWC. Andrew is also a Board Member of Byte Night which is the IT industry’s annual sleep out in support of Action for Children. Andrew is a co-founder of Compare Cloudware.";
            ct = new ContentText
            {
                NiceName = "",
                CompositeID = compositeID,
                ContentTextType = repository.FindContentTextTypeByName("MANAGEMENTTEAM_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 3,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            //data = "In addition to his operational responsibilities, Andrew leads the strategic direction for Compare Cloudware and is a key interface for key partners. Andrew is a co-founder of the business.";
            //ct = new ContentText
            //{
            //    NiceName = "",
            //    CompositeID = compositeID,
            //    ContentTextType = repository.FindContentTextTypeByName("MANAGEMENTTEAM_SECTION_BODY"),
            //    ContentTextData = data,
            //    BodyOrder = 4,
            //    ContentTextStatus = repository.FindStatusByName("LIVE"),
            //};
            //repository.AddContentText(ct);

            compositeID = Guid.NewGuid().ToString();
            data = "Gary Gould, Director";
            ct = new ContentText
            {
                NiceName = "",
                CompositeID = compositeID,
                ContentTextType = repository.FindContentTextTypeByName("MANAGEMENTTEAM_SECTION_TITLE"),
                ContentTextData = data,
                BodyOrder = 5,
                IsBold = true,
                ContentTextGraphic = GetImageAsBytes(PORTRAIT_FILEPATH + PORTRAIT_GARY),
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            //data = "Prior to his current role as EMEA Theatre Marketing Director for Panduit, Gary was the Global Launch marketing lead for Cisco Systems, covering the service provider, broadcast and enterprise technology franchises. An active member of two leading technology sector marketing associations and a long-standing associate of the CIM, Gary has over 15 years’ experience in the IT and Communications sector and has worked with major brands including BT, Verizon, Virgin Media, and Cable&Wireless.";
            data = "With over 20 years experience in the technology and communiactions sector, Gary has held senior marketing and commerical leadership positions with a number of gloabl brands including Cisco, BT, Verizon and Virgin Media. He is an active member of two leading technology marketing associations and an advocate of small business and entrepeneurship.";
            ct = new ContentText
            {
                NiceName = "",
                CompositeID = compositeID,
                ContentTextType = repository.FindContentTextTypeByName("MANAGEMENTTEAM_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 5,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "Gary has core responsibility for vendor partnerships, commerical policy and corporate sponsorship. He is also a key contact for investor, industry, analyst and media relations.";
            ct = new ContentText
            {
                NiceName = "",
                CompositeID = compositeID,
                ContentTextType = repository.FindContentTextTypeByName("MANAGEMENTTEAM_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 6,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            compositeID = Guid.NewGuid().ToString();
            data = "Ian Wilson, Director";
            ct = new ContentText
            {
                NiceName = "",
                CompositeID = compositeID,
                ContentTextType = repository.FindContentTextTypeByName("MANAGEMENTTEAM_SECTION_TITLE"),
                ContentTextData = data,
                BodyOrder = 7,
                IsBold = true,
                ContentTextGraphic = GetImageAsBytes(PORTRAIT_FILEPATH + PORTRAIT_IAN),
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            //data = "Ian Wilson is the founder and Creative Director of Wilson Miller, a leading technology marketing agency. For the last 15 years, he has created marketing campaigns for many leading technology brands including Cisco, Telewest, RSA Security, ICL, Verizon and Demon. Prior to founding Wilson Miller, Ian spent 15 years working in creative roles for flagship agencies such as JWT, McCann Erickson and Holmes & Marchant.";
            //data = "Ian Wilson is the founder and Creative Director of Wilson Miller, a leading technology marketing agency. He has created marketing campaigns for many leading technology brands including Cisco, Telewest, RSA Security, ICL, Verizon and Demon. Prior to founding Wilson Miller, Ian spent 15 years working in senior creative roles for flagship agencies such as JWT, McCann Erickson and Holmes & Marchant.";
            data = "Ian Wilson is a co-founder and Creative Director of the technology marketing organisation, The Rubicon Agency. With a lineage to Wilson Miller, Ian has created marketing campaigns for many leading technology brands including Cisco, RSA Security, Symantec, Verizon and Xerox for over 20 years. Prior to founding his own agencies, Ian spent 15 years working in senior creative roles for flagship agencies such as JWT, McCann Erickson and Holmes & Marchant. Ian is a co-founder of Compare Cloudware.";
            ct = new ContentText
            {
                NiceName = "",
                CompositeID = compositeID,
                ContentTextType = repository.FindContentTextTypeByName("MANAGEMENTTEAM_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 7,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            //data = "Ian’s role includes brand, communications and marketing direction for Compare Cloudware. Ian is a co-founder of the business.";
            //ct = new ContentText
            //{
            //    NiceName = "",
            //    CompositeID = compositeID,
            //    ContentTextType = repository.FindContentTextTypeByName("MANAGEMENTTEAM_SECTION_BODY"),
            //    ContentTextData = data,
            //    BodyOrder = 8,
            //    ContentTextStatus = repository.FindStatusByName("LIVE"),
            //};
            //repository.AddContentText(ct);
            compositeID = Guid.NewGuid().ToString();
            data = "Caroline Read, Finance Director";
            ct = new ContentText
            {
                NiceName = "",
                CompositeID = compositeID,
                ContentTextType = repository.FindContentTextTypeByName("MANAGEMENTTEAM_SECTION_TITLE"),
                ContentTextData = data,
                BodyOrder = 9,
                IsBold = true,
                ContentTextGraphic = GetImageAsBytes(PORTRAIT_FILEPATH + PORTRAIT_CAROLINE),
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            //data = "Caroline joined the Wilson Miller Group in 1999, bringing with her a wealth of experience in media accountancy, having previously worked in Fleet Street for several years. Key to Caroline’s skills is a deep understanding of the Wilson Miller concept and need for flexibility and understanding that each client has different requirements and therefore an individual approach to finance is required.";
            //data = "Caroline joined the Wilson Miller Group in 1999, bringing with her a wealth of experience in media accountancy and financial management, having previously worked in Fleet Street for several years.";
            data = "Caroline brings with her a wealth of experience in media accountancy and financial management, having previously worked in Fleet Street for several years. Now CFO of The Rubicon Agency, she is also responsible for the financial management of Compare Cloudware including commercial relationships with vendors.";
            ct = new ContentText
            {
                NiceName = "",
                CompositeID = compositeID,
                ContentTextType = repository.FindContentTextTypeByName("MANAGEMENTTEAM_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 9,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            //data = "In addition to her role in the Wilson Miller Group, Caroline is responsible for the financial management of Compare Cloudware and commercial relationships with vendors.";
            //ct = new ContentText
            //{
            //    NiceName = "",
            //    CompositeID = compositeID,
            //    ContentTextType = repository.FindContentTextTypeByName("MANAGEMENTTEAM_SECTION_BODY"),
            //    ContentTextData = data,
            //    BodyOrder = 10,
            //    ContentTextStatus = repository.FindStatusByName("LIVE"),
            //};
            //repository.AddContentText(ct);

            #endregion

            #region VISION


            data = "Vision";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("VISION_TITLE"),
                ContentTextData = data,
                BodyOrder = 1,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            //data = "Cloudware, or Software as a Service (SaaS), is moving into the mainstream. Its ability to reduce costs and simplify IT operations has been known for a long time, and the expansion of broadband internet access has now moved it from the wish-list to the to-do list for many businesses.";
            data = "Cloudware, or Software as a Service (SaaS) not only reduces costs and simplifies IT operations, it also empowers all types and sizes of businesses and organisations. With the expansion of broadband internet access, virtually anyone can take advantage of the latest and best developments in cloud services and applications.";
            ct = new ContentText
            {
                NiceName = "",
                CompositeID = compositeID,
                ContentTextType = repository.FindContentTextTypeByName("VISION_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 1,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            //data = "A few concerns remain, however. How do you shortlist and compare the hundreds of cloudware solutions out there? How do you cut through the jargon and get to the meat of the argument: what it can do for you? And how do you know that the cloudware you choose will deliver on its promise?";
            data = "Compare Cloudware’s vision is to be at the heart of this exciting revolution, providing the best information, guidance and access to the most comprehensive range of cloud solutions. Our aim is to open the cloud for business, streamline the sales process for vendors and take cloudware into the mainstream.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("VISION_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 2,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            //data = "That’s what Compare Cloudware is all about. Our vision is to be the one trusted source any business needs for any kind of cloudware.";
            //ct = new ContentText
            //{
            //    NiceName = "",
            //    ContentTextType = repository.FindContentTextTypeByName("VISION_SECTION_BODY"),
            //    ContentTextData = data,
            //    BodyOrder = 3,
            //    ContentTextStatus = repository.FindStatusByName("LIVE"),
            //};
            //repository.AddContentText(ct);
            //data = "A source that can be relied upon to simplify the selection and shortlist process for business, streamline the sales process for cloudware providers, and provide an open, honest forum for everything to do with cloudware.";
            //ct = new ContentText
            //{
            //    NiceName = "",
            //    ContentTextType = repository.FindContentTextTypeByName("VISION_SECTION_BODY"),
            //    ContentTextData = data,
            //    BodyOrder = 4,
            //    ContentTextStatus = repository.FindStatusByName("LIVE"),
            //};
            //repository.AddContentText(ct);
            #endregion

            #region FAQS
            data = "FAQs";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("FAQS_TITLE"),
                ContentTextData = data,
                BodyOrder = 1,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "What is Compare Cloudware?";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("FAQS_SECTION_TITLE"),
                ContentTextData = data,
                BodyOrder = 2,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            //data = "Compare Cloudware is the first ever website to provide a comprehensive, neutral and user-friendly online guide to services and applications available in the Cloud. In seconds, potential users can identify and find the cloudware they need, alongside reviews and user opinions that will inform them if it is the cloudware they really want.";
            data = "Compare Cloudware is the first ever website to provide a comprehensive, neutral and user-friendly online guide to services and applications available in the Cloud. In seconds, potential users can find and compare cloudware features and benefits against their requirements, check reviews and user opinions, access user trials and ultimately subscribe to services and applications.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("FAQS_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 2,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "Who is Compare Cloudware aimed at?";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("FAQS_SECTION_TITLE"),
                ContentTextData = data,
                BodyOrder = 3,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            //data = "There are two audiences for Compare Cloudware. Potential users can use a dynamic comparison tool to find the cloudware they need — and compare it with similar offerings. Vendors, meanwhile, can access a cost-effective route to the growing businesses they want to talk to.";
            data = "There are two audiences for Compare Cloudware. Potential users can use a dynamic comparison tool to find the cloudware they need — and compare it with similar offerings. Vendors, meanwhile, can access a cost-effective route to the growing businesses who can benefit from their solutions.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("FAQS_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 3,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "How does Compare Cloudware operate?";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("FAQS_SECTION_TITLE"),
                ContentTextData = data,
                BodyOrder = 4,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            //data = "At Compare Cloudware, we actively seek cloudware vendors and offer them the opportunity to feature their services and applications on the website. In every cloudware category, we are building relationships with every established and emerging vendor, so that potential users have a genuine opportunity to compare similar products and decide which is the best option for their needs.";
            data = "At Compare Cloudware, we actively seek cloudware vendors and offer them the opportunity to feature their services and applications on the website. In every cloudware category, we are building relationships with every established and emerging vendor, so that potential users have a comprehensive ability to compare similar products and decide which is best for their needs.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("FAQS_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 4,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "Do I pay Compare Cloudware when I trial or subscribe to Cloudware?";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("FAQS_SECTION_TITLE"),
                ContentTextData = data,
                BodyOrder = 5,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "No — Compare Cloudware operates on a commission basis with cloudware vendors. End-users enjoy every commercial advantage normally offered by vendors, including free trials and low price subscriptions.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("FAQS_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 5,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "Can I register my cloudware service or application for inclusion?";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("FAQS_SECTION_TITLE"),
                ContentTextData = data,
                BodyOrder = 6,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "Yes — we’re always looking for cloudware vendors who want an easy, cost-effective route to demonstrate and market their products. Call us on 01245 258700 and we’ll arrange a meeting to discuss the opportunities in more detail.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("FAQS_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 6,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "Is Compare Cloudware really vendor neutral?";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("FAQS_SECTION_TITLE"),
                ContentTextData = data,
                BodyOrder = 7,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            //data = "Yes, it is. The comparison engine that drives Compare Cloudware has been developed to provide a true comparison of cloudware services and applications based on a fixed set of features. End-users gain because the comparison is factual. Vendors gain because it highlights the key advantages of their products.";
            data = "Absolutely. The comparison engine that drives Compare Cloudware has been developed to provide a true comparison of cloudware services and applications based on a fixed set of features. End-users gain because the comparison is factual. Vendors gain because it highlights the key advantages of their products.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("FAQS_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 7,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            #endregion

            #region CAREERS
            data = "Careers at Compare Cloudware";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("CAREERS_TITLE"),
                ContentTextData = data,
                BodyOrder = 1,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "Careers at Compare Cloudware";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("CAREERS_SECTION_TITLE"),
                ContentTextData = data,
                BodyOrder = 1,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            //data = "Compare Cloudware is growing fast. Based in a Grade 2 listed building half an hour from London, we’re the pioneers in a rapidly transforming and dynamic market.";
            data = "Compare Cloudware is growing fast. We’re always interested in hearing from sales and marketing professionals with significant experience in the cloud and broader IT solutions.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("CAREERS_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 1,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            //data = "We’re always interested in hearing from sales and marketing professionals with significant experience in the cloud and broader IT solutions. If you’d like to join an exciting and expanding business at the forefront of cloud technologies, please contact us.";
            data = "Based half an hour from London, we’re the pioneers in a rapidly transforming and dynamic market. If you’d like to join an exciting and expanding business at the forefront of cloud technologies, please contact us";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("CAREERS_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 2,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "Please email us at #EMAILinfo@comparecloudware.com#EMAIL";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("CAREERS_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 3,
                IsEmailLink = true,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            #endregion

            #region PRESS
            data = "Press";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PRESS_TITLE"),
                ContentTextData = data,
                BodyOrder = 1,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            #region 1
            compositeID = Guid.NewGuid().ToString();

            data = "Computer Weekly";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PRESS_SECTION_TITLE_PUBLISHER"),
                ContentTextData = data,
                BodyOrder = 2,
                IsBold = false,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
                CompositeID = compositeID,
            };
            repository.AddContentText(ct);
            
            //data = "5th January 2012";
            data = new DateTime(2012, 1, 5).ToShortDateString();
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PRESS_SECTION_TITLE_DATE"),
                ContentTextData = data,
                BodyOrder = 3,
                IsBold = false,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
                CompositeID = compositeID,
                IsDate = true,
            };
            repository.AddContentText(ct);
            data = "Compare Cloudware – a revolutionary new channel to market";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PRESS_SECTION_TITLE"),
                ContentTextData = data,
                BodyOrder = 4,
                IsBold = true,
                IsHyperLink = true,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
                CompositeID = compositeID,
            };
            repository.AddContentText(ct);
            data = "Compare Cloudware was formally launched today with an agenda of simplifying the shortlist, comparison and purchase of cloud software and services – otherwise known as cloudware.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PRESS_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 5,
                //IsEmailLink = true,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
                CompositeID = compositeID,
            };
            repository.AddContentText(ct);
            data = "Compare Cloudware will pioneer a consultative approach to the selection of SaaS propositions through an innovative online platform. The announcement is the culmination of 18 months of planning, market assessment, content analysis, virtual proto-typing and self-funding.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PRESS_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 6,
                //IsEmailLink = true,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
                CompositeID = compositeID,
            };
            repository.AddContentText(ct);
            data = "SaaS has grown in popularity over the last couple of years due to significant business benefits including outsourced support, automatic updates, Enterprise quality technology, pre-formed business processes and a PAYG payment models. But, with an increasing reliance on innovative ICT, the challenge for the growing business is how to make sure they make the right technology choices – often without the guidance of a comprehensive IT function.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PRESS_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 7,
                //IsEmailLink = true,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
                CompositeID = compositeID,
            };
            repository.AddContentText(ct);
            data = "Conversely, the traditional sales channels to these buyers (retailers, telecom service providers and IT resellers) are restricted to ‘walled garden’ portfolios of their technology partners. These two dynamics have created an exciting and burgeoning market opportunity.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PRESS_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 8,
                //IsEmailLink = true,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
                CompositeID = compositeID,
            };
            repository.AddContentText(ct);
            data = "Many opportunist properties have been established over the last couple of years to jump on the cloud bandwagon. However, most are merely unsophisticated marketplaces, directories or pseudo-review sites that offer menus of cloud services – but with little or no ‘digital consultation’ to drive business users to the right service.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PRESS_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 9,
                //IsEmailLink = true,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
                CompositeID = compositeID,
            };
            repository.AddContentText(ct);
            data = "Compare Cloudware will offer more independence and intelligence in the SaaS selection process. The business will benefit from guidance to the most appropriate service in the market.  The cloudware vendor will benefit from a direct channel to the growing business buyer.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PRESS_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 10,
                //IsEmailLink = true,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
                CompositeID = compositeID,
            };
            repository.AddContentText(ct);
            data = "Compare Cloudware will be in Beta phase in Q3 2012, with an intended market launch early in 2013.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PRESS_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 11,
                //IsEmailLink = true,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
                CompositeID = compositeID,
            };
            repository.AddContentText(ct);
            #endregion

            //return retVal;
            #region 2
            compositeID = Guid.NewGuid().ToString();

            data = "Computer Weekly";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PRESS_SECTION_TITLE_PUBLISHER"),
                ContentTextData = data,
                BodyOrder = 12,
                IsBold = false,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
                CompositeID = compositeID,
            };
            repository.AddContentText(ct);

            //data = "12 April 2012";
            data = new DateTime(2012, 4, 12).ToShortDateString();
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PRESS_SECTION_TITLE_DATE"),
                ContentTextData = data,
                BodyOrder = 13,
                IsBold = false,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
                CompositeID = compositeID,
                IsDate = true,
            };
            repository.AddContentText(ct);
            data = "Software vendors are choosing to compare";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PRESS_SECTION_TITLE"),
                ContentTextData = data,
                BodyOrder = 14,
                IsBold = true,
                IsHyperLink = true,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
                CompositeID = compositeID,
            };
            repository.AddContentText(ct);
            data = "Since January, Compare Cloudware has undertaken comprehensive user-testing and focus groups to ensure the development of an optimised user experience and flexible technology platform. There has been a positive response to the operating model, ‘stepped’ vendor proposition and customer journeys.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PRESS_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 15,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
                CompositeID = compositeID,
            };
            repository.AddContentText(ct);
            data = "SaaS vendors, industry commentators and publishers alike have responded favourably to the creation of a comprehensive and independent resource for discovering the right cloudware.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PRESS_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 16,
                //IsBold = true,
                //IsUnderline = true,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
                CompositeID = compositeID,
            };
            repository.AddContentText(ct);
            data = "Vendors from CRM, finance and security have already signed-up for representation on #URLhttp://www.comparecloudware.com#URL at launch. Additionally, the inclusion of categories such as office and project management has been fast-tracked due to a positive response from providers.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PRESS_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 17,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
                CompositeID = compositeID,
            };
            repository.AddContentText(ct);
            data = "The research programme proves that SaaS vendors recognise the value in a global digital channel to buyers – avoiding the friction and operating costs of legacy sales channels. Additionally, industry commentators sympathise with a simplified shortlist/compare/select process – therefore helping businesses adopt risk-free cloud computing. Perhaps surprisingly, progressive IT resellers have seen the potential for Compare Cloudware in their go-to-market plans.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PRESS_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 18,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
                CompositeID = compositeID,
            };
            repository.AddContentText(ct);
            data = "The Compare Cloudware platform will progress to beta phase in Q3 2013.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PRESS_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 19,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
                CompositeID = compositeID,
            };
            repository.AddContentText(ct);
            #endregion

            #region 3
            compositeID = Guid.NewGuid().ToString();

            data = "Computer Weekly";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PRESS_SECTION_TITLE_PUBLISHER"),
                ContentTextData = data,
                BodyOrder = 20,
                IsBold = false,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
                CompositeID = compositeID,
            };
            repository.AddContentText(ct);

            //data = "21 June 2012";
            data = new DateTime(2012, 6, 21).ToShortDateString();
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PRESS_SECTION_TITLE_DATE"),
                ContentTextData = data,
                BodyOrder = 21,
                IsBold = false,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
                CompositeID = compositeID,
                IsDate = true,
            };
            repository.AddContentText(ct);
            data = "Customers need more than a mart";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PRESS_SECTION_TITLE"),
                ContentTextData = data,
                BodyOrder = 22,
                IsBold = true,
                IsHyperLink = true,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
                CompositeID = compositeID,
            };
            repository.AddContentText(ct);
            data = "Compare Cloudware is working closely with SMB, mid-market businesses and SaaS vendors to develop a consultative platform to shortlist, compare and purchase cloud software and services – otherwise known as cloudware.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PRESS_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 23,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
                CompositeID = compositeID,
            };
            repository.AddContentText(ct);
            data = "The close consultation period has highlighted some important challenges and opportunities in the adoption of cloud services.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PRESS_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 24,
                //IsUnderline = true,
                //IsBold = true,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
                CompositeID = compositeID,
                
            };
            repository.AddContentText(ct);
            data = "Almost 60% of businesses will be considering new or additional cloud technologies over the two years";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PRESS_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 25,
                IsNumbered = true,
                NumberOrder = 1,
                NumberSuffix = ")",
                ContentTextStatus = repository.FindStatusByName("LIVE"),
                CompositeID = compositeID,
            };
            repository.AddContentText(ct);
            data = "Over 90% of businesses say they don’t have the time, expertise and decision-making framework to compare the SaaS market";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PRESS_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 26,
                IsNumbered = true,
                NumberOrder = 2,
                NumberSuffix = ")",
                ContentTextStatus = repository.FindStatusByName("LIVE"),
                CompositeID = compositeID,
            };
            repository.AddContentText(ct);
            data = "Over two thirds of businesses want more than search results – they value a more filtered approach to selection";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PRESS_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 27,
                IsNumbered = true,
                NumberOrder = 3,
                NumberSuffix = ")",
                ContentTextStatus = repository.FindStatusByName("LIVE"),
                CompositeID = compositeID,
            };
            repository.AddContentText(ct);
            data = "When researching the market for appropriate technologies, almost 80% of businesses do not establish a formal criteria list (ie browsers, OS, support, features, integration needs) before  commencing";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PRESS_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 28,
                IsNumbered = true,
                NumberOrder = 4,
                NumberSuffix = ")",
                ContentTextStatus = repository.FindStatusByName("LIVE"),
                CompositeID = compositeID,
            };
            repository.AddContentText(ct);
            data = "Over 75% would start the research process with search engines. Less than 10% would start with their IT partners - whilst less than 5% would consider their telecom service provider. The remainder would use a combination of colleague referrals and PC retailers.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PRESS_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 29,
                IsNumbered = true,
                NumberOrder = 5,
                NumberSuffix = ")",
                ContentTextStatus = repository.FindStatusByName("LIVE"),
                CompositeID = compositeID,
            };
            repository.AddContentText(ct);
            data = "The exercise has cemented Compare Cloudware’s view that growing businesses are increasingly adopting cloud technologies for a broad range of business processes and tools. In some cases these are rapidly becoming main-stream. Against this transformation, the business currently is tasked with self-qualifying its needs and exposed to the random nature of search results to source the right solution.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PRESS_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 30,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
                CompositeID = compositeID,
            };
            repository.AddContentText(ct);
            data = "The Compare Cloudware platform will be at Beta phase in Q3 2012.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PRESS_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 31,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
                CompositeID = compositeID,
            };
            repository.AddContentText(ct);
            #endregion

            #region 4
            compositeID = Guid.NewGuid().ToString();

            data = "Computer Weekly";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PRESS_SECTION_TITLE_PUBLISHER"),
                ContentTextData = data,
                BodyOrder = 32,
                IsBold = false,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
                CompositeID = compositeID,
            };
            repository.AddContentText(ct);

            //data = "5 July 2012";
            data = new DateTime(2012, 7, 5).ToShortDateString();
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PRESS_SECTION_TITLE_DATE"),
                ContentTextData = data,
                BodyOrder = 33,
                IsBold = false,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
                CompositeID = compositeID,
                IsDate = true,
            };
            repository.AddContentText(ct);
            data = "Compare Cloudware - supporting the rise of Subscription Business";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PRESS_SECTION_TITLE"),
                ContentTextData = data,
                BodyOrder = 34,
                IsBold = true,
                IsHyperLink = true,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
                CompositeID = compositeID,
            };
            repository.AddContentText(ct);
            data = "Through Compare Cloudware’s consultation process we’re are seeing some common challenges for businesses of all sizes. Businesses are faced with a trilemma – and this is fostering a culture of Subscription Business.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PRESS_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 35,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
                CompositeID = compositeID,
            };
            repository.AddContentText(ct);
            data = "Business is coming to terms with reduced availability to funds (whether credit or extended debtor payment terms). Businesses want more value and flexibility from their working capital.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PRESS_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 36,
                IsNumbered = true,
                NumberOrder = 1,
                NumberSuffix = ")",
                ContentTextStatus = repository.FindStatusByName("LIVE"),
                CompositeID = compositeID,
            };
            repository.AddContentText(ct);
            data = "Against this, the organisation needs to innovate processes and services to provide competitive differentiation and create efficiency. New economies and markets are often in short supply – so fresh opportunity needs to be created from scratch.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PRESS_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 37,
                IsNumbered = true,
                NumberOrder = 2,
                NumberSuffix = ")",
                ContentTextStatus = repository.FindStatusByName("LIVE"),
                CompositeID = compositeID,
            };
            repository.AddContentText(ct);
            data = "Finally - business appetite for risk is low. Most leaders report a more conservative approach to long-term commitments and speculation.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PRESS_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 38,
                IsNumbered = true,
                NumberOrder = 3,
                NumberSuffix = ")",
                ContentTextStatus = repository.FindStatusByName("LIVE"),
                CompositeID = compositeID,
            };
            repository.AddContentText(ct);
            data = "Against this backdrop is easy to see why a lighter and more scalable approach to business – Subscription Business - is becoming more popular.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PRESS_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 39,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
                CompositeID = compositeID,
            };
            repository.AddContentText(ct);
            data = "Business decision makers are increasingly looking to ‘subscribe’ to the solutions they need on an incremental, pay-as-you-go basis – whether software, professional services or facilities. Compare Cloudware recognises this – but perhaps what’s commonly undervalued is the value-creation that this model can bring to enterprise.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PRESS_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 40,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
                CompositeID = compositeID,
            };
            repository.AddContentText(ct);
            data = "Subscription Business – through cloudware – has the potential to disrupt, transform and redesign how business is won, nurtured and delivered. It can revolutionise how customers, partners and markets do business. At Compare Cloudware we’re seeing how progressive businesses look beyond the more obvious operational and financial benefits – towards greater knowledge retention, service acceleration, expanded global delivery and product innovation. What we find exciting is that these aspirational business outcomes are just the tip of the iceberg.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PRESS_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 41,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
                CompositeID = compositeID,
            };
            repository.AddContentText(ct);
            data = "Subscription Business makes a lot of financial and risk sense to the Finance Director and the Board. But, with careful planning it can also be used as an enabler for the growing business too.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PRESS_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 42,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
                CompositeID = compositeID,
            };
            repository.AddContentText(ct);
            #endregion

            #region 5
            compositeID = Guid.NewGuid().ToString();

            data = "Computer Weekly";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PRESS_SECTION_TITLE_PUBLISHER"),
                ContentTextData = data,
                BodyOrder = 43,
                IsBold = false,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
                CompositeID = compositeID,
            };
            repository.AddContentText(ct);

            //data = "11 October 2012";
            data = new DateTime(2012, 10, 11).ToShortDateString();
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PRESS_SECTION_TITLE_DATE"),
                ContentTextData = data,
                BodyOrder = 44,
                IsBold = false,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
                CompositeID = compositeID,
                IsDate = true,
            };
            repository.AddContentText(ct);
            data = "Beta 2.0 – on time, on budget, on vision";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PRESS_SECTION_TITLE"),
                ContentTextData = data,
                BodyOrder = 45,
                IsBold = true,
                IsHyperLink = true,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
                CompositeID = compositeID,
            };
            repository.AddContentText(ct);
            data = "Compare Cloudware is proud to announce the early launch of the Beta 2.0 version of #URLhttp://www.comparecloudware.com#URL. This builds on the success of Beta 1.0 which was also delivered on-scope and within budget.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PRESS_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 46,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
                CompositeID = compositeID,
            };
            repository.AddContentText(ct);
            data = "Beta 2.0 retains the integrity of the user experience and ‘digital consultation’ envisioned in early prototypes. The Compare Cloudware design, user experience, development and content analysis teams have worked tirelessly to deliver an intuitive and industry-leading platform that will revolutionise the sales channel for cloud services.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PRESS_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 47,
                //IsUnderline = true,
                //IsBold = true,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
                CompositeID = compositeID,
            };
            repository.AddContentText(ct);
            data = "Additionally, the site benefits from a robust and flexible technical architecture that delivers optimised database performance and a responsive user interface. Also, the user experience and development teams have platformed for a broad range of devices, browsers and iterations of user settings.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PRESS_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 48,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
                CompositeID = compositeID,
            };
            repository.AddContentText(ct);
            data = "Beta 2.0 feedback has been extremely positive – with additional fast-track requests from security and CRM vendors. These two categories were originally planned for Phase 2 roll-out but are now been analysed and resourced for Phase 1 launch.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PRESS_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 49,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
                CompositeID = compositeID,
            };
            repository.AddContentText(ct);
            data = "Compare Cloudware is currently committed to full launch in Q2 2013.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PRESS_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 50,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
                CompositeID = compositeID,
            };
            repository.AddContentText(ct);
            #endregion

            #region 6
            compositeID = Guid.NewGuid().ToString();

            data = "Computer Weekly";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PRESS_SECTION_TITLE_PUBLISHER"),
                ContentTextData = data,
                BodyOrder = 51,
                IsBold = false,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
                CompositeID = compositeID,
            };
            repository.AddContentText(ct);

            //data = "1 November 2012";
            data = new DateTime(2012, 11, 1).ToShortDateString();
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PRESS_SECTION_TITLE_DATE"),
                ContentTextData = data,
                BodyOrder = 52,
                IsBold = false,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
                CompositeID = compositeID,
                IsDate = true,
            };
            repository.AddContentText(ct);
            data = "Team strengthened for launch";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PRESS_SECTION_TITLE"),
                ContentTextData = data,
                BodyOrder = 53,
                IsBold = true,
                IsHyperLink = true,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
                CompositeID = compositeID,
            };
            repository.AddContentText(ct);
            data = "Compare Cloudware has announced the strengthening of its team, in preparation for launch in Q2 2013.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PRESS_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 54,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
                CompositeID = compositeID,
            };
            repository.AddContentText(ct);
            data = "The company is pleased to create 3 new roles. The decision has been taken following requests to expand SaaS categories at launch - in addition to positive Beta feedback from IT publishers and industry commentators.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PRESS_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 55,
                //IsUnderline = true,
                //IsBold = true,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
                CompositeID = compositeID,
            };
            repository.AddContentText(ct);
            data = "\"The expanded team is crucial to a successful launch of Compare Cloudware’’ said Andrew Miller, Managing Director of Compare Cloudware. ‘’The addition of an Operations Manager, Business Development Manager and a Client Services Executive will help us deliver our vision of a truly innovative channel to market for cloud providers – and pioneering decision tool for growing businesses\"";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PRESS_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 56,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
                CompositeID = compositeID,
            };
            repository.AddContentText(ct);
            data = "November promises to be a busy on-boarding period for the team.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PRESS_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 57,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
                CompositeID = compositeID,
            };
            repository.AddContentText(ct);
            #endregion

            #region 7
            compositeID = Guid.NewGuid().ToString();

            data = "Computer Weekly";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PRESS_SECTION_TITLE_PUBLISHER"),
                ContentTextData = data,
                BodyOrder = 58,
                IsBold = false,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
                CompositeID = compositeID,
            };
            repository.AddContentText(ct);

            //data = "3 January 2013";
            data = new DateTime(2013, 1, 3).ToShortDateString();
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PRESS_SECTION_TITLE_DATE"),
                ContentTextData = data,
                BodyOrder = 59,
                IsBold = false,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
                CompositeID = compositeID,
                IsDate = true,
            };
            repository.AddContentText(ct);
            data = "Compare Cloudware launches User Group";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PRESS_SECTION_TITLE"),
                ContentTextData = data,
                BodyOrder = 60,
                IsBold = true,
                IsHyperLink = true,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
                CompositeID = compositeID,
            };
            repository.AddContentText(ct);
            data = "Compare Cloudware today announced the opening of its User Group – formalising the test, feedback and stakeholder collaboration programme so successful in the incubation and development of the platform.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PRESS_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 61,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
                CompositeID = compositeID,
            };
            repository.AddContentText(ct);
            data = "The group includes business users from a broad cross section of segments, sizes and technology competence levels. This constituency provides first-hand guidance on the technology platform, user experience and content presentation.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PRESS_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 62,
                //IsUnderline = true,
                //IsBold = true,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
                CompositeID = compositeID,
            };
            repository.AddContentText(ct);
            data = "In addition, cloud providers provide feedback and counsel on proposition enhancement, new product development and development roadmap.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PRESS_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 63,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
                CompositeID = compositeID,
            };
            repository.AddContentText(ct);
            data = "To join the Compare Cloudware User Group, #EMAIL#EMAILTEXTclick here#EMAILTEXT#EMAILADDRESSinfo@comparecloudware.com#EMAILADDRESS#EMAIL";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PRESS_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 64,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
                CompositeID = compositeID,
            };
            repository.AddContentText(ct);
            #endregion

            #region 8
            compositeID = Guid.NewGuid().ToString();

            data = "Computer Weekly";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PRESS_SECTION_TITLE_PUBLISHER"),
                ContentTextData = data,
                BodyOrder = 65,
                IsBold = false,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
                CompositeID = compositeID,
            };
            repository.AddContentText(ct);

            //data = "XX May 2013";
            data = new DateTime(2013, 8, 19).ToShortDateString();
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PRESS_SECTION_TITLE_DATE"),
                ContentTextData = data,
                BodyOrder = 66,
                IsBold = false,
                ContentTextStatus = repository.FindStatusByName("SUSPENDED"),
                CompositeID = compositeID,
                IsDate = true,
            };
            repository.AddContentText(ct);
            data = "Compare Cloudware – opening the cloud for business";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PRESS_SECTION_TITLE"),
                ContentTextData = data,
                BodyOrder = 67,
                IsBold = true,
                IsHyperLink = true,
                ContentTextStatus = repository.FindStatusByName("SUSPENDED"),
                CompositeID = compositeID,
            };
            repository.AddContentText(ct);
            data = "Today, #URLhttp://www.comparecloudware.com#URL went live – after 3 years of planning, 18 months of business creation and a year of platform development.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PRESS_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 68,
                ContentTextStatus = repository.FindStatusByName("SUSPENDED"),
                CompositeID = compositeID,
            };
            repository.AddContentText(ct);
            data = "Compare Cloudware cuts through the hype and confusion of choosing on-demand software and services. It’s the first website to recognise the importance of choice, independent advice and easy access to cloud providers. As the complete one-stop resource for research, absolute comparison and selection. Compare Cloudware simplifies and streamlines the buy/sell process for users and vendors.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PRESS_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 69,
                //IsUnderline = true,
                //IsBold = true,
                ContentTextStatus = repository.FindStatusByName("SUSPENDED"),
                CompositeID = compositeID,
            };
            repository.AddContentText(ct);
            data = "With 9 categories of SaaS provider and service, Compare Cloudware is proud to represent many of the leading cloud vendors – comprising over 500 service propositions.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PRESS_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 70,
                ContentTextStatus = repository.FindStatusByName("SUSPENDED"),
                CompositeID = compositeID,
            };
            repository.AddContentText(ct);
            data = "Cloud has created a market opportunity for small providers to compete with large providers - and for all to be agile on a global scale. However, the challenges for both are:";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PRESS_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 71,
                ContentTextStatus = repository.FindStatusByName("SUSPENDED"),
                CompositeID = compositeID,
            };
            repository.AddContentText(ct);
            data = "To drive maximum market awareness and education for cloud products or services";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PRESS_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 72,
                IsBulleted = true,
                ContentTextStatus = repository.FindStatusByName("SUSPENDED"),
                CompositeID = compositeID,
            };
            repository.AddContentText(ct);
            data = "Achieve low cost of sale";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PRESS_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 73,
                IsBulleted = true,
                ContentTextStatus = repository.FindStatusByName("SUSPENDED"),
                CompositeID = compositeID,
            };
            repository.AddContentText(ct);
            data = "Drive volume and recurring revenues";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PRESS_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 74,
                IsBulleted = true,
                ContentTextStatus = repository.FindStatusByName("SUSPENDED"),
                CompositeID = compositeID,
            };
            repository.AddContentText(ct);
            data = "Measure and manage return on sales and marketing investment.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PRESS_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 75,
                IsBulleted = true,
                ContentTextStatus = repository.FindStatusByName("SUSPENDED"),
                CompositeID = compositeID,
            };
            repository.AddContentText(ct);
            data = "\"The answer to these challenges can only be found in the cloud itself and Compare Cloudware‘’, said Andrew Miller, Managing Director of Compare Cloudware. ‘’We’re pioneering a new global, digitally -consultative channel to market for SaaS vendors. We provide a low-friction option for cloud players looking for a streamlined route to the growing business\".";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PRESS_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 76,
                ContentTextStatus = repository.FindStatusByName("SUSPENDED"),
                CompositeID = compositeID,
            };
            repository.AddContentText(ct);
            data = "For software providers or SaaS vendors, Compare Cloudware should be an essential part of the sales and marketing strategy:";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PRESS_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 77,
                ContentTextStatus = repository.FindStatusByName("SUSPENDED"),
                CompositeID = compositeID,
            };
            repository.AddContentText(ct);
            data = "A wide choice of cost-effective marketing packages to suit budgets and strategies";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PRESS_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 78,
                ContentTextStatus = repository.FindStatusByName("SUSPENDED"),
                CompositeID = compositeID,
            };
            repository.AddContentText(ct);
            data = "More user intelligence to support sales and marketing in a dynamic growth market";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PRESS_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 79,
                ContentTextStatus = repository.FindStatusByName("SUSPENDED"),
                CompositeID = compositeID,
            };
            repository.AddContentText(ct);
            data = "An independent resource that works harder for you and your market";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PRESS_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 80,
                ContentTextStatus = repository.FindStatusByName("SUSPENDED"),
                CompositeID = compositeID,
            };
            repository.AddContentText(ct);
            data = "Low cost of sale and more recurring revenue opportunities.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PRESS_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 81,
                ContentTextStatus = repository.FindStatusByName("SUSPENDED"),
                CompositeID = compositeID,
            };
            repository.AddContentText(ct);
            data = "Compare Cloudware has phased launch plans for further categories throughout Q3 & Q4 2013. To register your services #EMAIL#EMAILTEXTclick here#EMAILTEXT #EMAILADDRESSmarketing@comparecloudware.com#EMAILADDRESS#EMAIL";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PRESS_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 82,
                ContentTextStatus = repository.FindStatusByName("SUSPENDED"),
                CompositeID = compositeID,
            };
            repository.AddContentText(ct);

            #endregion

            #region CONTACT US
            data = "Contact us";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("CONTACTUS_TITLE"),
                ContentTextData = data,
                BodyOrder = 1,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "Contact us";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("CONTACTUS_SECTION_TITLE"),
                ContentTextData = data,
                BodyOrder = 1,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "Compare Cloudware";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("CONTACTUS_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 1,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "For general enquiries:";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("CONTACTUS_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 2,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "T:44 (0)1245 790580";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("CONTACTUS_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 3,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "E: #EMAILinfo@comparecloudware.com#EMAIL";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("CONTACTUS_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 4,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "To become a partner and have your service on Compare Cloudware:";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("CONTACTUS_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 5,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "T:44 (0)1245 790580";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("CONTACTUS_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 6,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "E: #EMAILpartner@comparecloudware.com#EMAIL";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("CONTACTUS_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 7,
                IsEmailLink = true,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            //data = "Alternatively you can submit your inquiry using the form below:";
            //ct = new ContentText
            //{
            //    NiceName = "",
            //    ContentTextType = repository.FindContentTextTypeByName("CONTACTUS_SECTION_BODY"),
            //    ContentTextData = data,
            //    BodyOrder = 1,
            //};
            //repository.AddContentText(ct);

            #endregion

            #region TOU TOU
            data = "Terms of Use";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("TOU_TOU_SECTION_TITLE"),
                ContentTextData = data,
                BodyOrder = 1,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "Terms of Use of www.comparecloudware.com, a Compare Cloudware Ltd site";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("TOU_TOU_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 1,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "This agreement applies as between you, the user of this web site and Compare Cloudware Ltd, the owner(s) of this web site.  Your agreement to comply with and be bound by these terms and conditions is deemed to occur upon your first use of the web site. If you do not agree to be bound by these terms and conditions, you should stop using the web site immediately.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("TOU_TOU_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 1,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "Compare Cloudware Ltd is the company that owns and operates www.comparecloudware.com";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("TOU_TOU_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 1,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "Compare Cloudware Ltd, a company incorporated under the laws of England with its registered office address at 145-157 St John Street, London, England, EC1V 4PW. ";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("TOU_TOU_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 1,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "Compare Cloudware Ltd is registered in the UK. Compare Cloudware Ltd registered company number 123456768 ";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("TOU_TOU_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 1,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            #endregion

            #region TOU GENERAL
            data = "1. General";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("TOU_GENERAL_SECTION_TITLE"),
                ContentTextData = data,
                BodyOrder = 1,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "Acceptance: Use of the Sites or any services offered on these Sites ('Services') by users (“You”, “the User” or “Users”) is subject to these Terms of Use ('Terms') that expressly include our Privacy Policy. Your use of these Sites constitutes your binding acceptance of these Terms, including any modifications that we make. Your use of these Sites further involves the express and full acceptance our Privacy Policy that applies to collection and processing by Compare Cloudware Ltd of certain personal and other data provided by Users through www.comparecloudware.com. You understand and agree that our Services may include the sending of commercial communications to You, such as announcements and advertisements from us or from our partners.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("TOU_GENERAL_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 1,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "Modification: We may modify without previous notice the design, layout and/or configuration of these Sites, and may revise these Terms (including the Privacy Policy). Any modification will be enforceable from the date of publication and any subsequent use of the Site will be subjected to the new Terms, hence we recommend you to read them carefully.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("TOU_GENERAL_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 1,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "Additional Conditions: Some of the Services may be subject to additional posted conditions within the Sites, in particular the area for Premium Users. Your use of those Services is subject to those conditions, which are incorporated into these Terms by reference. In the event of an inconsistency between these Terms and any additional posted conditions, the provisions of the additional conditions shall prevail.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("TOU_GENERAL_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 1,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "Possible Compare Cloudware Ltd Actions: We have the right, but not the obligation, to take any of the following actions in our sole discretion at any time and for any reason without giving you any prior notice:";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("TOU_GENERAL_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 1,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "Restrict, suspend, or terminate your access to all or any part of our Services.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("TOU_GENERAL_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 1,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "•Change, suspend, or discontinue all or any part of our Services.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("TOU_GENERAL_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 1,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "•Refuse, move, or remove any content that you submit to our Sites for any reason.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("TOU_GENERAL_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 1,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "•Deactivate or delete your accounts and all related information and files in Your account.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("TOU_GENERAL_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 1,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "•Establish general practices and limits concerning use of our Sites.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("TOU_GENERAL_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 1,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "You agree that We will not be liable to you or any third party for taking any of these actions.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("TOU_GENERAL_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 1,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "Responsibility: Users acknowledge and accept that they access and use the Sites and/or the contents included within these Sites under their full responsibility. Access to the Sites and/or to the contents included within do not entail any guarantee as for the Sites and/or contents’ adequateness for particular or specific User’ aims.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("TOU_GENERAL_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 1,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            #endregion

            #region TOU SERVICES
            data = "2. Services";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("TOU_SERVICES_SECTION_TITLE"),
                ContentTextData = data,
                BodyOrder = 1,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "Comparecloudware.com provides Users with the following principal Services:";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("TOU_SERVICES_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 1,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "•Free User services and tools to find business and IT applications (“Applications”), compare offers, choose deployment methods, including the communication with selected Applications Providers in accordance to a variety of criteria.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("TOU_SERVICES_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 1,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "•For Application Providers, possibility for publishing their Applications and enabling them to be searched (in accordance to the selected criteria). ";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("TOU_SERVICES_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 1,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "•Advertising, lead generation (Pay-Per-Click and Pay-Per-Lead) and promotional opportunities for partners and Application Providers.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("TOU_SERVICES_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 1,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "•Service of Alerts: free automatic alerts on offers via e-mail regarding Applications; newsletter Services or informative electronic communications about - Applications and deployment methods. ";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("TOU_SERVICES_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 1,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "•Other services that we may deem interesting for Users, such as advice, training, professional contact network, forums, access to news.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("TOU_SERVICES_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 1,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            #endregion

            #region TOU CONTENT
            data = "3. Content Available on Comparecloudware.com";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("TOU_CONTENT_SECTION_TITLE"),
                ContentTextData = data,
                BodyOrder = 1,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "IPR: Our Sites include a combination of content that we create, that our partners create, and that our users create. Some materials published on our Sites, including, but not limited to, written content, photographs, graphics, images, illustrations, marks, logos are protected by our intellectual property (copyright) or industrial property rights (such as trademarks) or those of our partners or Users.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("TOU_CONTENT_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 1,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "No license: Neither Compare Cloudware Ltd nor any of its partners or Users grants You a license nor use authorisation over its intellectual or industrial property rights or over any other right or property concerning the Site, its Services or its contents. Thus You may not modify, publish, transmit, participate in the transfer or sale of, reproduce, create derivative works of, distribute, publicly communicate, or in any way exploit any of the materials or content on our Sites in whole or in part.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("TOU_CONTENT_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 1,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "User Content: You are solely responsible for all materials, whether publicly posted or privately transmitted, that you upload, post, e-mail, transmit, or otherwise make available on our Sites ('Your Content'). You certify that you own all intellectual and industrial property rights in Your Content. You hereby grant us, our affiliates, and our partners a worldwide, irrevocable, royalty-free, nonexclusive, sub licensable license to use, reproduce, create derivative works of, publicly communicate and distribute Your Content and subsequent versions of Your Content for the purposes of (i) displaying Your Content on our Sites, (ii) distributing Your Content, either electronically or via other media, to Users.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("TOU_CONTENT_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 1,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            #endregion

            #region TOU THIRD PARTY SITES
            data = "4. Third-party sites, products, and services";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("TOU_THIRD_PARTY_SITES_SECTION_TITLE"),
                ContentTextData = data,
                BodyOrder = 1,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "Our Sites contain links to other Internet sites owned and managed by third parties, with the aim of enabling access to information available on the internet. Compare Cloudware Ltd makes no representation whatsoever about any third party sites which you may access from our Sites. Your use of each of those sites is subject to the conditions, if any, that each of those sites has posted. We have no control over sites that are not ours, and we are not responsible for any changes of content on them. Our inclusion on our Sites of any third-party content or a link to a third-party site is for informational purposes only and is not an endorsement of that content or third-party site, that there is a commercial or any other relationship between Compare Cloudware Ltd and the owners of such third party sites or that Compare Cloudware Ltd accepts any responsibility in relation to such third party sites.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("TOU_THIRD_PARTY_SITES_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 1,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "We do not sell, resell, or license any of the products and services that we list, review or advertise on our Sites, and we disclaim any responsibility for or liability related to any of them. Your correspondence or related activities with third parties, including payment transactions and goods-delivery transactions, are solely between you and the relevant third party. You agree that we will not be responsible or liable for any loss or damage of any sort incurred as the result of any of your transactions with third parties. Any product order, licenses, third party warranties, questions, complaints, or claims related to any product or service take place between you and the vendor and should be directed to the appropriate vendor.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("TOU_THIRD_PARTY_SITES_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 1,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "As a regular part of our business, Compare Cloudware Ltd displays advertisements and listings from a wide variety of companies. Compare Cloudware Ltd is not in a position to arbitrate disputes between the owners of intellectual property rights and companies who advertise or list their products on our Sites.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("TOU_THIRD_PARTY_SITES_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 1,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            #endregion

            #region TOU USER OBLIGATIONS
            data = "5. User’s Obligations";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("TOU_USER_OBLIGATIONS_SECTION_TITLE"),
                ContentTextData = data,
                BodyOrder = 1,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "Registration. We require our Site users to register in order to conduct a search to compare Applications. Registration is required by application providers; and from Site Users who wish to fill out a category lead form (Compare Offers and Deploy Smart) or an exclusive lead form (to obtain a personalized response to their needs) or post a review on a listing, including name, company name, email address, and phone number. This data is processed in accordance with our Privacy Policy.  ";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("TOU_USER_OBLIGATIONS_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 1,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "Registration process and submitting reviews. If we request information from you on registration and/or reviewing a product, you agree to provide us with true, accurate, current, and complete information. You will accept these terms of use, including our Privacy Policy. As regards to registration, You will promptly update your registration data to keep it accurate, current, and complete. If we issue You personal credentials (password), you may not reveal it to anyone else. It is personal and non-transferable. You may not use anyone else's credentials (password). You are responsible for maintaining the confidentiality of your accounts and passwords. You agree to immediately notify us of any Unauthorised use of your passwords or accounts or any other breach or risk of breach of security. You also agree to exit from your accounts at the end of each session. We will not be responsible for any loss or damage that may result if you fail to comply with these requirements.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("TOU_USER_OBLIGATIONS_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 1,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "Prohibited behaviour. User will use the Sites in accordance with these Terms of Use and applicable law. Without limiting the foregoing, you agree that you will not use our Sites to take any of the following actions:";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("TOU_USER_OBLIGATIONS_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 1,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "•Submit unlawful content according to the national, community or international law or content contrary to good faith; that violates other individuals’ fundamental or other rights (including intellectual and/or industrial property rights without authorisation), ";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("TOU_USER_OBLIGATIONS_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 1,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "•Submit any content that may prejudice the image, honour and reputation of the Sites, or generally any content whatsoever that we deem inappropriate. ";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("TOU_USER_OBLIGATIONS_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 1,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "•Abuse, harass, threaten, or otherwise violate the legal right of others.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("TOU_USER_OBLIGATIONS_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 1,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "•Publish, post, distribute, or disseminate any inappropriate, profane, defamatory, obscene, indecent, or unlawful content.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("TOU_USER_OBLIGATIONS_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 1,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "•Transmit surveys, contests, pyramid schemes, spam, unsolicited advertising or promotional materials, or chain letters.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("TOU_USER_OBLIGATIONS_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 1,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "•Interfere with or disrupt our Sites, servers, or networks.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("TOU_USER_OBLIGATIONS_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 1,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "•Impersonate any person or entity, including, but not limited to, a Compare Cloudware Ltd representative, or falsely state or otherwise misrepresent your affiliation with a person or entity.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("TOU_USER_OBLIGATIONS_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 1,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "•Engage in any illegal activities.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("TOU_USER_OBLIGATIONS_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 1,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "Users will be held liable to Compare Cloudware Ltd and/or third parties for any breach or violation of the said obligations and/or for any damage, ruin, overload, submission and dissemination of viruses, and interference with the proper use of materials and information included within the Sites, the information systems, documents, files and any kind of contents stored in any computer (hacking) owned by Compare Cloudware Ltd or any of its Users.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("TOU_USER_OBLIGATIONS_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 1,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "Unauthorised access to our Sites is a breach of these Terms and a violation of the law. You agree not to access our Sites by any means other than through the interface that is provided by Compare Cloudware Ltd for use in accessing our Sites. You agree not to use any automated means, including, without limitation, agents, robots, scripts, or spiders, to access, monitor, or copy any part of our Sites.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("TOU_USER_OBLIGATIONS_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 1,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "Use of our Sites is subject to existing applicable English laws and legal process. Nothing contained in these Terms shall limit our right to comply with governmental, court, and law-enforcement requests or requirements relating to your use of our Sites.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("TOU_USER_OBLIGATIONS_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 1,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "Use of our technologies. The technology and the software underlying our Sites and the Services are the property of Compare Cloudware Ltd and our partners. You agree not to copy, modify, rent, lease, loan, sell, assign, distribute, reverse engineer, grant a security interest in, or otherwise transfer any right to the contents (texts, designs, graphics, information, database, pictures, logos, etc.), technology or software underlying our Sites or the Services.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("TOU_USER_OBLIGATIONS_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 1,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            #endregion

            #region TOU IPR
            data = "6. Intellectual and Industrial Property Rights";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("TOU_IPR_SECTION_TITLE"),
                ContentTextData = data,
                BodyOrder = 1,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "Subject to the exceptions in these Terms and Conditions, all Content included on the site, unless uploaded by Users, including, but not limited to, text, graphics, logos, icons, images, sound clips, video clips, data compilations, page layout, underlying code and software is the property of Compare Cloudware Ltd, or our affiliates.  By continuing to use the site you acknowledge that such material is protected by applicable United Kingdom and International intellectual property and other laws.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("TOU_IPR_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 1,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "You may print, reproduce, copy, distribute, store or in any other fashion re-use Content from the site for personal or educational purposes only unless otherwise indicated on the site or unless given express written permission to do so by Compare Cloudware Ltd";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("TOU_IPR_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 1,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "If you believe that your intellectual or industrial property (including but not limited to copyright, trademarks, industrial designs, patents, models, etc.) have been violated by Compare Cloudware Ltd or by a third party who has included material on our Sites, please provide the following Notification of Claimed Infringement only to Compare Cloudware Ltd with the following elements:";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("TOU_IPR_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 1,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "•Your personal information: name, address, telephone/mobile number and e-mail address where Compare Cloudware Ltd can contact You;";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("TOU_IPR_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 1,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "•An identification of the work protected under the intellectual and/or industrial property that You claim has been infringed;";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("TOU_IPR_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 1,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "•A description of the material You claim is infringing and where the material that you claim is infringing is located on the Sites (e.g. the URL of the corresponding information on our Sites);";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("TOU_IPR_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 1,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "•Acts or circumstances that unravel the unlawfulness of such activities;";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("TOU_IPR_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 1,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "•An express and clear statement that You have a good-faith belief that the use is not authorized by the intellectual or industrial property rights owner or the law;";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("TOU_IPR_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 1,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "•A statement by You that the information in your notice is accurate and that You are the intellectual and/or industrial property right owner or are authorized to act on the owner's behalf;";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("TOU_IPR_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 1,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "•An electronic or physical signature of the owner or of the person authorized to act on behalf of the owner of the intellectual and/or industrial property rights.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("TOU_IPR_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 1,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "It is often difficult to determine if intellectual and/or industrial property rights have been violated. We may request additional information before we remove any infringing material.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("TOU_IPR_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 1,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            #endregion

            #region TOU LIABILITY DISCLAIMERS
            data = "7. Disclaimers of liability";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("TOU_LIABILITY_DISCLAIMERS_SECTION_TITLE"),
                ContentTextData = data,
                BodyOrder = 1,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "General disclaimer. Users acknowledge and accept that they access and use the Sites and/or the published contents of the Sites under their full responsibility. Compare Cloudware Ltd does not guarantee or promise any specific results from use of Services provided in the Sites, in particular, it does not guarantee that requestors for help will find a provider of such help, nor that any help provided will be appropriate for them. We further disclaim any responsibility for any harm resulting from accessing any information or material on the Internet using search results from our Sites.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("TOU_LIABILITY_DISCLAIMERS_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 1,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "Third party content. Our Sites contain content that we create as well as content provided by third parties. This third party or User content includes, among other things, product and services descriptions, specifications, support conditions, performance, deployment methods, pricing, reviews and associated comments.  Compare Cloudware Ltd only acts as a passive conduct for the distribution and publication of User-submitted content in the Sites and we are not responsible for the deletion, the inaccuracies or failure to display correctly of any third party information or content provided in the Sites. To the extent permitted by applicable law, we do not guarantee the accuracy, the integrity, or the quality of such third party content on our Sites. In particular, You may be exposed to content that you find offensive, indecent, or objectionable or that is inaccurate. Without limitation, we are not responsible for online reviews and comments by Users, nor for third party content included or referred to in any commercial communications which are sent out to registered Users. We have the right, but not the obligation (unless required by law or judicial authorities), to remove any content that may, in our sole discretion, violate these Terms or that is otherwise objectionable.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("TOU_LIABILITY_DISCLAIMERS_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 1,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "We do not systematically previously review or control any submitted content, offer, review, comment, opinion or any information whatsoever provided by Users. However, if we have effective knowledge, on our own or prompted by a third party, that a content, offer, review, comment, opinion or any other information that may infringe the law, these Terms of Use or other Users and third parties’ rights has been submitted, We will remove it from the Sites, without previous notice.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("TOU_LIABILITY_DISCLAIMERS_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 1,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            #endregion

            #region TOU NO WARRANTY
            data = "8. No Warranty";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("TOU_NO_WARRANTY_SECTION_TITLE"),
                ContentTextData = data,
                BodyOrder = 1,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "We do not warrant that our Sites will be uninterrupted or error free. In addition, we do not make any warranty as to the content on our Sites. Our Sites and their content are displayed on an 'as is, as available' basis without any warranty of any kind. Any content that you obtain through our Sites is done at your own discretion and risk. To the extent permitted by applicable law, neither we nor any of our partners makes any warranty that (i) our Sites will meet your requirements, (ii) our Sites will be uninterrupted, timely, secure, or error free, (iii) the results that may be obtained from the use of our Sites will be accurate or reliable, (iv) the quality of any products, services, information, or other material that you obtain through our Sites will meet your expectations, and (v) any errors will be corrected. Neither we nor any of our partners makes any warranties of any kind, either express or implied, including, without limitation, warranties of title or implied warranties of merchantability or fitness for a particular purpose, with respect to our Sites, any content, or any of our services, tools, products, or properties. You expressly agree that You will assume the entire risk as to the quality and the performance of our Sites and the accuracy or completeness of its content.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("TOU_NO_WARRANTY_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 1,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "Neither we nor our partners shall be liable for any direct, indirect, incidental, special, or consequential damages arising out of the use of or inability to use our Sites.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("TOU_NO_WARRANTY_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 1,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "Some countries and/or states do not allow exclusion of implied warranties or limitation of liability for incidental or consequential damages, so the above limitations or exclusions may not apply to you. In such countries and/or states, our liability and that of our third-party content providers and their respective agents shall be limited to the greatest extent permitted by law.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("TOU_NO_WARRANTY_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 1,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            #endregion

            #region TOU INDEMNITY
            data = "9. Indemnity";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("TOU_INDEMNITY_SECTION_TITLE"),
                ContentTextData = data,
                BodyOrder = 1,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "You hereby agree to indemnify, defend and hold Compare Cloudware Ltd and all of our directors, owners, employees, agents, information providers, affiliates, partners, advertisers and providers harmless from and against any and all liability, losses, costs, and expenses (including attorneys' fees) incurred by any Compare Cloudware Ltd Party in connection with any claim, including, but not limited to, a breach of these Terms, a breach of the applicable regulations and/or the infringement of rights owned by Compare Cloudware Ltd, its partners, other uses or any third party; claims for defamation, violation of rights of publicity and/or privacy, intellectual or industrial property rights infringement, arising out of:";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("TOU_INDEMNITY_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 1,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "•Your use of and/or connection to our Sites.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("TOU_INDEMNITY_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 1,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "•Any use or alleged use of your accounts or your passwords by any person, whether or not authorized by you.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("TOU_INDEMNITY_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 1,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "•The content, the quality, or the performance of content that You submit to our Sites.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("TOU_INDEMNITY_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 1,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "•Your violation of these Terms or applicable Regulations.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("TOU_INDEMNITY_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 1,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "•Your violation of the rights of any other person or entity.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("TOU_INDEMNITY_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 1,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "•Any submission of false, inaccurate or misleading information.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("TOU_INDEMNITY_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 1,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "•Acts that may cause direct or indirect damages to Compare Cloudware Ltd, other users or third parties.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("TOU_INDEMNITY_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 1,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "We reserve the right, at our own expense, to assume the exclusive defence and control of any matter for which you are required to indemnify us, and you agree to cooperate with our defence of these claims.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("TOU_INDEMNITY_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 1,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            #endregion

            #region TOU SITE AVAILABILITY
            data = "10. Site Availability";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("TOU_SITE_AVAILABILITY_SECTION_TITLE"),
                ContentTextData = data,
                BodyOrder = 1,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "User acknowledges that 100% availability of the Sites is not technically feasible. However, Compare Cloudware Ltd will make its best efforts to keep the Sites available in the most constant possible way. Due to special maintenance, security or capacity issues, and also to some events over which Compare Cloudware Ltd may not influence (e.g., anomalies in public communication networks, electricity cut offs, etc.), Services provided by Compare Cloudware Ltd may be temporally suspended or affected by brief anomalies.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("TOU_SITE_AVAILABILITY_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 1,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "We disclaim any responsibility for, and if you subscribe to one of our Premium Services you will not be entitled to a refund as a result of, any service outages that are caused by our maintenance on the servers or the technology that underlies our Sites, failures of our service providers (including telecommunications, hosting, and power providers), computer viruses, natural disasters or other destruction or damage of our facilities, acts of nature, war, civil disturbance, or any other cause beyond our reasonable control.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("TOU_SITE_AVAILABILITY_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 1,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            #endregion

            #region TOU MISC
            data = "11. Miscellaneous";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("TOU_MISC_SECTION_TITLE"),
                ContentTextData = data,
                BodyOrder = 1,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "We may be required by law to notify you of certain events. You hereby acknowledge and consent that such notices will be effective upon our posting them on our Sites or delivering them to You through e-mail. If you do not provide us with accurate information, we cannot be held liable if we fail to notify you. You have the right to request that we provide such notices to you in paper format, and may do so by contacting  Compare Cloudware Ltd at the address set out above.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("TOU_MISC_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 1,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "Our failure to exercise or enforce any right or provision of these Terms shall not constitute a waiver of such right or provision.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("TOU_MISC_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 1,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "You agree that regardless of any statute or law to the contrary, any claim or cause of action arising out of or related to use of our Sites or these Terms must be filed within one (1) year after such claim or cause of action arose or be forever barred.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("TOU_MISC_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 1,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "These Terms including all terms, conditions, Privacy Policy and policies that are incorporated into these terms by reference, constitute the entire agreement between you and Compare Cloudware Ltd and govern your use of our Sites, superseding any prior agreements that you may have with us.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("TOU_MISC_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 1,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "These Terms shall be construed in accordance with the laws of England & Wales, and the parties irrevocably consent to bring any action to enforce these Terms before an arbitration panel or before a court of competent jurisdiction in England & Wales if seeking interim or preliminary relief or enforcement of an arbitration award and compliance of the Terms set forth herein.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("TOU_MISC_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 1,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "Compare Cloudware Ltd may elect to resolve any controversy or claim arising out of or relating to these Terms or our Sites by binding arbitration in accordance with the commercial arbitration rules of England & Wales. Any such controversy or claim shall be arbitrated on an individual basis and shall not be consolidated in any arbitration with any claim or controversy of any other party. The arbitration shall be conducted in England, and judgment on the arbitration award may be entered in any court having jurisdiction thereof. Either You or we may seek any interim or preliminary relief from a court of competent jurisdiction in England, necessary to protect the rights or the property of You or Compare Cloudware Ltd (or its agents, suppliers, and subcontractors), pending the completion of arbitration.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("TOU_MISC_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 1,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "If any part of these Terms is determined to be invalid or unenforceable pursuant to applicable law, then the invalid or unenforceable provision will be deemed superseded by a valid, enforceable provision that most closely matches the intent of the original provision, and the remainder of the Terms shall continue in effect.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("TOU_MISC_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 1,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "If you have any queries on the Terms & Conditions, email terms@comparecloudware.com";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("TOU_MISC_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 1,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "CAPTCHA";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("TOU_MISC_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 1,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            #endregion

            #region PP PP
            data = "Privacy Policy";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PP_PP_SECTION_TITLE"),
                ContentTextData = data,
                BodyOrder = 1,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "Privacy Policy of www.comparecloudware.com, a Compare Cloudware Ltd site";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PP_PP_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 1,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "This agreement applies as between you, the user of this web site and Compare Cloudware Ltd, the owner(s) of this web site.  Your agreement to comply with and be bound by these terms and conditions is deemed to occur upon your first use of the web site. If you do not agree to be bound by these terms and conditions, you should stop using the web site immediately.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PP_PP_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 1,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "Compare Cloudware Ltd is the company that owns and operates www.comparecloudware.com";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PP_PP_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 1,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "Compare Cloudware Ltd, a company incorporated under the laws of England with its registered office address at 145-157 St John Street, London, England, EC1V 4PW. ";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PP_PP_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 1,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "Compare Cloudware Ltd is registered in the UK. Compare Cloudware Ltd registered company number 07270763. ";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PP_PP_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 1,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            #endregion

            #region PP BACKGROUND
            data = "Background";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PP_BACKGROUND_SECTION_TITLE"),
                ContentTextData = data,
                BodyOrder = 1,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "This Policy applies as between you, the User of this Web Site and Compare Cloudware Ltd the owner and provider of this Web Site.  This Policy applies to our use of any and all Data collected by us in relation to your use of the Web Site and any Services or Systems therein.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PP_BACKGROUND_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 1,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            #endregion

            #region PP DEFINITIONS
            data = "1.	Definitions and Interpretation ";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PP_DEFINITIONS_SECTION_TITLE"),
                ContentTextData = data,
                BodyOrder = 1,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "In this Policy the following terms shall have the following meanings: ";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PP_DEFINITIONS_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 1,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            #endregion

            #region PP DEFINITIONS MEANINGS
            compositeID = Guid.NewGuid().ToString();
            data = "Account";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PP_DEFINITIONS_MEANINGS_SECTION_BODY_TERM"),
                ContentTextData = data,
                BodyOrder = 1,
                CompositeID = compositeID,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "means collectively the personal information, Payment Information and credentials used by Users to access Material and / or any communications System on the Web Site;";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PP_DEFINITIONS_MEANINGS_SECTION_BODY_MEANING"),
                ContentTextData = data,
                BodyOrder = 1,
                CompositeID = compositeID,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);


            compositeID = Guid.NewGuid().ToString();
            data = "Content";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PP_DEFINITIONS_MEANINGS_SECTION_BODY_TERM"),
                ContentTextData = data,
                BodyOrder = 2,
                CompositeID = compositeID,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "means any text, graphics, images, audio, video, software, data compilations and any other form of information capable of being stored in a computer that appears on or forms part of this Web Site;";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PP_DEFINITIONS_MEANINGS_SECTION_BODY_MEANING"),
                ContentTextData = data,
                BodyOrder = 2,
                CompositeID = compositeID,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);



            compositeID = Guid.NewGuid().ToString();
            data = "Cookie";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PP_DEFINITIONS_MEANINGS_SECTION_BODY_TERM"),
                ContentTextData = data,
                BodyOrder = 3,
                CompositeID = compositeID,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "means a small text file placed on your computer by www.comparecloudware.com when you visit certain parts of this Web Site.  This allows us to identify recurring visitors and to analyse their browsing habits within the Web Site.  Where e-commerce facilities are provided, Cookies may be used to store your company, personal and/or payment details for subscription services.  Further details are contained in Clause 10 and Schedule 1 of this Policy;";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PP_DEFINITIONS_MEANINGS_SECTION_BODY_MEANING"),
                ContentTextData = data,
                BodyOrder = 3,
                CompositeID = compositeID,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);



            compositeID = Guid.NewGuid().ToString();
            data = "Data";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PP_DEFINITIONS_MEANINGS_SECTION_BODY_TERM"),
                ContentTextData = data,
                BodyOrder = 4,
                CompositeID = compositeID,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "means collectively all information that you submit to the Web Site.  This includes, but is not limited to, Account details and information submitted using any of our Services or Systems;";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PP_DEFINITIONS_MEANINGS_SECTION_BODY_MEANING"),
                ContentTextData = data,
                BodyOrder = 4,
                CompositeID = compositeID,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);



            compositeID = Guid.NewGuid().ToString();
            data = "Compare Cloudware";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PP_DEFINITIONS_MEANINGS_SECTION_BODY_TERM"),
                ContentTextData = data,
                BodyOrder = 5,
                CompositeID = compositeID,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "means www.comparecloudware.com, Compare Cloudware or Compare Cloudware Ltd a company incorporated under the laws of England with its registered office address at 145-157 St John Street, London, England, EC1V 4PW. ";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PP_DEFINITIONS_MEANINGS_SECTION_BODY_MEANING"),
                ContentTextData = data,
                BodyOrder = 5,
                CompositeID = compositeID,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);



            compositeID = Guid.NewGuid().ToString();
            data = "Service";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PP_DEFINITIONS_MEANINGS_SECTION_BODY_TERM"),
                ContentTextData = data,
                BodyOrder = 6,
                CompositeID = compositeID,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "means collectively any online facilities, tools, services or information that Compare Cloudware Ltd makes available through the Web Site either now or in the future;";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PP_DEFINITIONS_MEANINGS_SECTION_BODY_MEANING"),
                ContentTextData = data,
                BodyOrder = 6,
                CompositeID = compositeID,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);



            compositeID = Guid.NewGuid().ToString();
            data = "System";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PP_DEFINITIONS_MEANINGS_SECTION_BODY_TERM"),
                ContentTextData = data,
                BodyOrder = 7,
                CompositeID = compositeID,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "means any online communications infrastructure that Compare Cloudware Ltd makes available through the Web Site either now or in the future.  This includes, but is not limited to, web-based email, message boards, live chat facilities and email links;";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PP_DEFINITIONS_MEANINGS_SECTION_BODY_MEANING"),
                ContentTextData = data,
                BodyOrder = 7,
                CompositeID = compositeID,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);



            compositeID = Guid.NewGuid().ToString();
            data = "User / Users";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PP_DEFINITIONS_MEANINGS_SECTION_BODY_TERM"),
                ContentTextData = data,
                BodyOrder = 8,
                CompositeID = compositeID,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "means any third party that accesses the Web Site and is not employed by Compare Cloudware Ltd and acting in the course of their employment; and";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PP_DEFINITIONS_MEANINGS_SECTION_BODY_MEANING"),
                ContentTextData = data,
                BodyOrder = 8,
                CompositeID = compositeID,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);




            compositeID = Guid.NewGuid().ToString();
            data = "Web Site";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PP_DEFINITIONS_MEANINGS_SECTION_BODY_TERM"),
                ContentTextData = data,
                BodyOrder = 9,
                CompositeID = compositeID,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "means the website that you are currently using (www.comparecloudware.com) and any sub-domains of this site (e.g. subdomain.<<URL>>) unless expressly excluded by their own terms and conditions.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PP_DEFINITIONS_MEANINGS_SECTION_BODY_MEANING"),
                ContentTextData = data,
                BodyOrder = 9,
                CompositeID = compositeID,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            #endregion

            #region PP DATA COLLECTED
            data = "2.	Data Collected";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PP_DATA_COLLECTED_SECTION_TITLE"),
                ContentTextData = data,
                BodyOrder = 1,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "Without limitation, any of the following Data may be collected:";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PP_DATA_COLLECTED_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 1,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            #endregion

            #region PP DATA COLLECTED ITEMS
            compositeID = Guid.NewGuid().ToString();
            data = "2.1";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PP_DATA_COLLECTED_ITEMS_SECTION_BODY_NUMBER"),
                ContentTextData = data,
                BodyOrder = 1,
                CompositeID = compositeID,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "name;";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PP_DATA_COLLECTED_ITEMS_SECTION_BODY_ITEM"),
                ContentTextData = data,
                BodyOrder = 1,
                CompositeID = compositeID,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);


            compositeID = Guid.NewGuid().ToString();
            data = "2.2";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PP_DATA_COLLECTED_ITEMS_SECTION_BODY_NUMBER"),
                ContentTextData = data,
                BodyOrder = 2,
                CompositeID = compositeID,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "date of birth";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PP_DATA_COLLECTED_ITEMS_SECTION_BODY_ITEM"),
                ContentTextData = data,
                BodyOrder = 2,
                CompositeID = compositeID,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);


            compositeID = Guid.NewGuid().ToString();
            data = "2.3";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PP_DATA_COLLECTED_ITEMS_SECTION_BODY_NUMBER"),
                ContentTextData = data,
                BodyOrder = 3,
                CompositeID = compositeID,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "gender;";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PP_DATA_COLLECTED_ITEMS_SECTION_BODY_ITEM"),
                ContentTextData = data,
                BodyOrder = 3,
                CompositeID = compositeID,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);


            compositeID = Guid.NewGuid().ToString();
            data = "2.4";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PP_DATA_COLLECTED_ITEMS_SECTION_BODY_NUMBER"),
                ContentTextData = data,
                BodyOrder = 4,
                CompositeID = compositeID,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "job title;";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PP_DATA_COLLECTED_ITEMS_SECTION_BODY_ITEM"),
                ContentTextData = data,
                BodyOrder = 4,
                CompositeID = compositeID,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);


            compositeID = Guid.NewGuid().ToString();
            data = "2.5";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PP_DATA_COLLECTED_ITEMS_SECTION_BODY_NUMBER"),
                ContentTextData = data,
                BodyOrder = 5,
                CompositeID = compositeID,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "profession;";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PP_DATA_COLLECTED_ITEMS_SECTION_BODY_ITEM"),
                ContentTextData = data,
                BodyOrder = 5,
                CompositeID = compositeID,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);


            compositeID = Guid.NewGuid().ToString();
            data = "2.6";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PP_DATA_COLLECTED_ITEMS_SECTION_BODY_NUMBER"),
                ContentTextData = data,
                BodyOrder = 6,
                CompositeID = compositeID,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "contact information such as email addresses and telephone numbers;";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PP_DATA_COLLECTED_ITEMS_SECTION_BODY_ITEM"),
                ContentTextData = data,
                BodyOrder = 6,
                CompositeID = compositeID,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);


            compositeID = Guid.NewGuid().ToString();
            data = "2.7";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PP_DATA_COLLECTED_ITEMS_SECTION_BODY_NUMBER"),
                ContentTextData = data,
                BodyOrder = 7,
                CompositeID = compositeID,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "demographic information such as post code, preferences and interests;";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PP_DATA_COLLECTED_ITEMS_SECTION_BODY_ITEM"),
                ContentTextData = data,
                BodyOrder = 7,
                CompositeID = compositeID,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);


            compositeID = Guid.NewGuid().ToString();
            data = "2.8";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PP_DATA_COLLECTED_ITEMS_SECTION_BODY_NUMBER"),
                ContentTextData = data,
                BodyOrder = 8,
                CompositeID = compositeID,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "financial information such as credit / debit card numbers;";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PP_DATA_COLLECTED_ITEMS_SECTION_BODY_ITEM"),
                ContentTextData = data,
                BodyOrder = 8,
                CompositeID = compositeID,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);


            compositeID = Guid.NewGuid().ToString();
            data = "2.9";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PP_DATA_COLLECTED_ITEMS_SECTION_BODY_NUMBER"),
                ContentTextData = data,
                BodyOrder = 9,
                CompositeID = compositeID,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "IP address (automatically collected);";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PP_DATA_COLLECTED_ITEMS_SECTION_BODY_ITEM"),
                ContentTextData = data,
                BodyOrder = 9,
                CompositeID = compositeID,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);


            compositeID = Guid.NewGuid().ToString();
            data = "2.10";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PP_DATA_COLLECTED_ITEMS_SECTION_BODY_NUMBER"),
                ContentTextData = data,
                BodyOrder = 10,
                CompositeID = compositeID,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "web browser type and version (automatically collected);";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PP_DATA_COLLECTED_ITEMS_SECTION_BODY_ITEM"),
                ContentTextData = data,
                BodyOrder = 10,
                CompositeID = compositeID,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);


            compositeID = Guid.NewGuid().ToString();
            data = "2.11";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PP_DATA_COLLECTED_ITEMS_SECTION_BODY_NUMBER"),
                ContentTextData = data,
                BodyOrder = 11,
                CompositeID = compositeID,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "operating system (automatically collected);";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PP_DATA_COLLECTED_ITEMS_SECTION_BODY_ITEM"),
                ContentTextData = data,
                BodyOrder = 11,
                CompositeID = compositeID,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);


            compositeID = Guid.NewGuid().ToString();
            data = "2.12";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PP_DATA_COLLECTED_ITEMS_SECTION_BODY_NUMBER"),
                ContentTextData = data,
                BodyOrder = 12,
                CompositeID = compositeID,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "a list of URLS starting with a referring site, your activity on this Web Site, and the site you exit to (automatically collected); and";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PP_DATA_COLLECTED_ITEMS_SECTION_BODY_ITEM"),
                ContentTextData = data,
                BodyOrder = 12,
                CompositeID = compositeID,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);


            compositeID = Guid.NewGuid().ToString();
            data = "2.13";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PP_DATA_COLLECTED_ITEMS_SECTION_BODY_NUMBER"),
                ContentTextData = data,
                BodyOrder = 13,
                CompositeID = compositeID,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "Cookie information (see clause 10 below).";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PP_DATA_COLLECTED_ITEMS_SECTION_BODY_ITEM"),
                ContentTextData = data,
                BodyOrder = 13,
                CompositeID = compositeID,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);


            compositeID = Guid.NewGuid().ToString();
            data = "2.14";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PP_DATA_COLLECTED_ITEMS_SECTION_BODY_NUMBER"),
                ContentTextData = data,
                BodyOrder = 14,
                CompositeID = compositeID,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "Content relating to the marketing of cloudware services";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PP_DATA_COLLECTED_ITEMS_SECTION_BODY_ITEM"),
                ContentTextData = data,
                BodyOrder = 14,
                CompositeID = compositeID,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            #endregion

            #region PP DATA USE
            data = "3.	Our Use of Data";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PP_DATA_USE_SECTION_TITLE"),
                ContentTextData = data,
                BodyOrder = 1,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            #endregion

            #region PP DATA USE ITEMS
            compositeID = Guid.NewGuid().ToString();
            data = "3.1";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PP_DATA_USE_ITEMS_SECTION_BODY_NUMBER"),
                ContentTextData = data,
                BodyOrder = 1,
                CompositeID = compositeID,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "3.1	Any personal Data you submit will be retained by Compare Cloudware Ltd for as long as you use the Services and Systems provided on the Web Site.  Data that you may submit through any communications System that we may provide may be retained for a longer period of up to 10 years.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PP_DATA_USE_ITEMS_SECTION_BODY_ITEM"),
                ContentTextData = data,
                BodyOrder = 1,
                CompositeID = compositeID,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);



            compositeID = Guid.NewGuid().ToString();
            data = "3.2";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PP_DATA_USE_ITEMS_SECTION_BODY_NUMBER"),
                ContentTextData = data,
                BodyOrder = 2,
                CompositeID = compositeID,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "Unless we are obliged or permitted by law to do so, and subject to Clause 4, your Data will not be disclosed to third parties.  This does not include our affiliates and / or other companies within our group.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PP_DATA_USE_ITEMS_SECTION_BODY_ITEM"),
                ContentTextData = data,
                BodyOrder = 2,
                CompositeID = compositeID,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);



            compositeID = Guid.NewGuid().ToString();
            data = "3.3";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PP_DATA_USE_ITEMS_SECTION_BODY_NUMBER"),
                ContentTextData = data,
                BodyOrder = 3,
                CompositeID = compositeID,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "The data we collect is processed for the purposes indicated in our Terms of Use, including without limitation management of the Web Site and Users, matching Application providers with Users that are willing to learn about products and services, displaying relevant content on our Web Site, contacting Users and sending commercial communications, and such other specific purposes indicated or implicit in each part of the Site.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PP_DATA_USE_ITEMS_SECTION_BODY_ITEM"),
                ContentTextData = data,
                BodyOrder = 3,
                CompositeID = compositeID,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);



            compositeID = Guid.NewGuid().ToString();
            data = "3.4";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PP_DATA_USE_ITEMS_SECTION_BODY_NUMBER"),
                ContentTextData = data,
                BodyOrder = 4,
                CompositeID = compositeID,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "By filling in and sending your data to Compare Cloudware Ltd, you expressly consent to receive communications regarding the subject matter of the Site and other services. These commercial communications, including alerts, notices, newsletters, offers and promotions, will be always sent by Compare Cloudware Ltd, or by Application Providers to whom you have requested your data to be sent in relation to a request, lead or Application";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PP_DATA_USE_ITEMS_SECTION_BODY_ITEM"),
                ContentTextData = data,
                BodyOrder = 4,
                CompositeID = compositeID,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);



            compositeID = Guid.NewGuid().ToString();
            data = "3.5";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PP_DATA_USE_ITEMS_SECTION_BODY_NUMBER"),
                ContentTextData = data,
                BodyOrder = 5,
                CompositeID = compositeID,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "If you do not wish to receive information form this Web Site and expressly opt out by sending a notification to optout@comparecloudware.com";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PP_DATA_USE_ITEMS_SECTION_BODY_ITEM"),
                ContentTextData = data,
                BodyOrder = 5,
                CompositeID = compositeID,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);



            compositeID = Guid.NewGuid().ToString();
            data = "3.6";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PP_DATA_USE_ITEMS_SECTION_BODY_NUMBER"),
                ContentTextData = data,
                BodyOrder = 6,
                CompositeID = compositeID,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "All personal Data is stored securely in accordance with the principles of the Data Protection Act 1998. For more details on security, see clause 9 below.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PP_DATA_USE_ITEMS_SECTION_BODY_ITEM"),
                ContentTextData = data,
                BodyOrder = 6,
                CompositeID = compositeID,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);



            compositeID = Guid.NewGuid().ToString();
            data = "3.7";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PP_DATA_USE_ITEMS_SECTION_BODY_NUMBER"),
                ContentTextData = data,
                BodyOrder = 7,
                CompositeID = compositeID,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "Any or all of the above Data may be required by us from time to time in order to provide you with the best possible service and experience when using our Web Site.  Specifically, Data may be used by us for the following reasons:";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PP_DATA_USE_ITEMS_SECTION_BODY_ITEM"),
                ContentTextData = data,
                BodyOrder = 7,
                CompositeID = compositeID,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);



            compositeID = Guid.NewGuid().ToString();
            data = "3.8";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PP_DATA_USE_ITEMS_SECTION_BODY_NUMBER"),
                ContentTextData = data,
                BodyOrder = 8,
                CompositeID = compositeID,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "internal record keeping;";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PP_DATA_USE_ITEMS_SECTION_BODY_ITEM"),
                ContentTextData = data,
                BodyOrder = 8,
                CompositeID = compositeID,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);



            compositeID = Guid.NewGuid().ToString();
            data = "3.9";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PP_DATA_USE_ITEMS_SECTION_BODY_NUMBER"),
                ContentTextData = data,
                BodyOrder = 9,
                CompositeID = compositeID,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "improvement of our products / services;";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PP_DATA_USE_ITEMS_SECTION_BODY_ITEM"),
                ContentTextData = data,
                BodyOrder = 9,
                CompositeID = compositeID,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);



            compositeID = Guid.NewGuid().ToString();
            data = "3.10";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PP_DATA_USE_ITEMS_SECTION_BODY_NUMBER"),
                ContentTextData = data,
                BodyOrder = 10,
                CompositeID = compositeID,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "transmission by email of promotional materials that may be of interest to you;";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PP_DATA_USE_ITEMS_SECTION_BODY_ITEM"),
                ContentTextData = data,
                BodyOrder = 10,
                CompositeID = compositeID,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);



            compositeID = Guid.NewGuid().ToString();
            data = "3.11";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PP_DATA_USE_ITEMS_SECTION_BODY_NUMBER"),
                ContentTextData = data,
                BodyOrder = 11,
                CompositeID = compositeID,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "contact for market research purposes which may be done using email, telephone, fax or mail.  Such information may be used to customise or update the Web Site.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PP_DATA_USE_ITEMS_SECTION_BODY_ITEM"),
                ContentTextData = data,
                BodyOrder = 11,
                CompositeID = compositeID,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);



            #endregion

            #region PP THIRD PARTY SERVICES
            data = "4.	Third Party Web Sites and Services";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PP_THIRD_PARTY_SERVICES_SECTION_TITLE"),
                ContentTextData = data,
                BodyOrder = 1,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "Compare Cloudware Ltd may, from time to time, employ the services of other parties for dealing with matters that may include, but are not limited to, payment handling, delivery of purchased items, search engine facilities, advertising and marketing.  The providers of such services may have access to certain personal Data provided by Users of this Web Site. Any Data used by such parties is used only to the extent required by them to perform the services that Compare Cloudware Ltd requests.  Any use for other purposes is strictly prohibited.  Furthermore, any Data that is processed by third parties must be processed within the terms of this Policy and in accordance with the Data Protection Act 1998.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PP_THIRD_PARTY_SERVICES_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 1,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "www.comparecloudware.com contains links to other web Sites whose information practices may be different than ours.  We recommend visitors to consult the respective policies of these third parties for more information on their information practices. Compare  Cloudware Ltd privacy policy does not apply to, and we have no control over the activities or information that is submitted to, nor collected and processed by, these third parties.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PP_THIRD_PARTY_SERVICES_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 2,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "We may partner with identified third parties however we do not provide any personally identifiable information to these third parties without your consent";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PP_THIRD_PARTY_SERVICES_SECTION_BODY"),
                ContentTextData = data,
                BodyOrder = 3,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            #endregion

            #region PP COB
            data = "5.	Changes of Business Ownership and Control";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PP_COB_SECTION_TITLE"),
                ContentTextData = data,
                BodyOrder = 1,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            #endregion

            #region PP COB ITEMS
            compositeID = Guid.NewGuid().ToString();
            data = "5.1";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PP_COB_ITEMS_SECTION_BODY_NUMBER"),
                ContentTextData = data,
                BodyOrder = 1,
                CompositeID = compositeID,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "5.1	Compare Cloudware Ltd may, from time to time, expand or reduce its business and this may involve the sale of certain divisions or the transfer of control of certain divisions to other parties.  Data provided by Users will, where it is relevant to any division so transferred, be transferred along with that division and the new owner or newly controlling party will, under the terms of this Policy, be permitted to use the Data for the purposes for which it was supplied by you.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PP_COB_ITEMS_SECTION_BODY_ITEM"),
                ContentTextData = data,
                BodyOrder = 1,
                CompositeID = compositeID,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            #endregion

            #region PP COB FOOTER
            data = "In the event that any Data submitted by Users will be transferred in such a manner, you will not be contacted in advance and informed of the changes. ";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PP_COB_FOOTER"),
                ContentTextData = data,
                BodyOrder = 1,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            #endregion

            #region PP DATA ACCESS
            data = "6.	Controlling Access to your Data";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PP_DATA_ACCESS_SECTION_TITLE"),
                ContentTextData = data,
                BodyOrder = 1,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            #endregion

            #region PP DATA ACCESS ITEMS
            compositeID = Guid.NewGuid().ToString();
            data = "6.1";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PP_DATA_ACCESS_ITEMS_SECTION_BODY_NUMBER"),
                ContentTextData = data,
                BodyOrder = 1,
                CompositeID = compositeID,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "6.1	Wherever you are required to submit Data, you will be given options to restrict our use of that Data.  This may include the following:";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PP_DATA_ACCESS_ITEMS_SECTION_BODY_ITEM"),
                ContentTextData = data,
                BodyOrder = 1,
                CompositeID = compositeID,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            compositeID = Guid.NewGuid().ToString();
            data = "6.2";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PP_DATA_ACCESS_ITEMS_SECTION_BODY_NUMBER"),
                ContentTextData = data,
                BodyOrder = 1,
                CompositeID = compositeID,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "use of Data for direct marketing purposes; and";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PP_DATA_ACCESS_ITEMS_SECTION_BODY_ITEM"),
                ContentTextData = data,
                BodyOrder = 1,
                CompositeID = compositeID,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            compositeID = Guid.NewGuid().ToString();
            data = "6.3";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PP_DATA_ACCESS_ITEMS_SECTION_BODY_NUMBER"),
                ContentTextData = data,
                BodyOrder = 1,
                CompositeID = compositeID,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "sharing Data with third parties.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PP_DATA_ACCESS_ITEMS_SECTION_BODY_ITEM"),
                ContentTextData = data,
                BodyOrder = 1,
                CompositeID = compositeID,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            
            #endregion

            #region PP WITHHOLD
            data = "7.	Your Right to Withhold Information";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PP_WITHHOLD_SECTION_TITLE"),
                ContentTextData = data,
                BodyOrder = 1,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            #endregion

            #region PP WITHHOLD ITEMS
            compositeID = Guid.NewGuid().ToString();
            data = "7.1";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PP_WITHHOLD_ITEMS_SECTION_BODY_NUMBER"),
                ContentTextData = data,
                BodyOrder = 1,
                CompositeID = compositeID,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "7.1	You may access certain areas of the Web Site without providing any Data at all.  However, to use all Services and Systems available on the Web Site you may be required to submit Account information or other Data.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PP_WITHHOLD_ITEMS_SECTION_BODY_ITEM"),
                ContentTextData = data,
                BodyOrder = 1,
                CompositeID = compositeID,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            compositeID = Guid.NewGuid().ToString();
            data = "7.2";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PP_WITHHOLD_ITEMS_SECTION_BODY_NUMBER"),
                ContentTextData = data,
                BodyOrder = 1,
                CompositeID = compositeID,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "7.2	You may restrict your internet browser’s use of Cookies.  For more information see clause 10.4 below.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PP_WITHHOLD_ITEMS_SECTION_BODY_ITEM"),
                ContentTextData = data,
                BodyOrder = 1,
                CompositeID = compositeID,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            #endregion

            #region PP OWNDATA
            data = "8.	Accessing your own Data";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PP_OWNDATA_SECTION_TITLE"),
                ContentTextData = data,
                BodyOrder = 1,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            #endregion

            #region PP OWNDATA ITEMS
            compositeID = Guid.NewGuid().ToString();
            data = "8.1";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PP_OWNDATA_ITEMS_SECTION_BODY_NUMBER"),
                ContentTextData = data,
                BodyOrder = 1,
                CompositeID = compositeID,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "You may access your Account at any time to view or amend the Data.  You may need to modify or update your Data if your circumstances change.  Additional Data as to your marketing preferences may also be stored and you may change this at any time.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PP_OWNDATA_ITEMS_SECTION_BODY_ITEM"),
                ContentTextData = data,
                BodyOrder = 1,
                CompositeID = compositeID,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            compositeID = Guid.NewGuid().ToString();
            data = "8.2";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PP_OWNDATA_ITEMS_SECTION_BODY_NUMBER"),
                ContentTextData = data,
                BodyOrder = 1,
                CompositeID = compositeID,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "You have the right to ask for a copy of your personal Data on payment of a small fee.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PP_OWNDATA_ITEMS_SECTION_BODY_ITEM"),
                ContentTextData = data,
                BodyOrder = 1,
                CompositeID = compositeID,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            #endregion

            #region PP SECURITY
            data = "9.	Security";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PP_SECURITY_SECTION_TITLE"),
                ContentTextData = data,
                BodyOrder = 1,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            #endregion

            #region PP SECURITY ITEMS
            compositeID = Guid.NewGuid().ToString();
            data = "9.1";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PP_SECURITY_ITEMS_SECTION_BODY_NUMBER"),
                ContentTextData = data,
                BodyOrder = 1,
                CompositeID = compositeID,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "9.1	Data security is of great importance to Compare Cloudware Ltd and to protect your Data we have put in place suitable physical, electronic and managerial procedures to safeguard and secure Data collected online.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PP_SECURITY_ITEMS_SECTION_BODY_ITEM"),
                ContentTextData = data,
                BodyOrder = 1,
                CompositeID = compositeID,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            #endregion

            #region PP SECURITY
            data = "10.	Cookies";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PP_COOKIES_SECTION_TITLE"),
                ContentTextData = data,
                BodyOrder = 1,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            #endregion

            #region PP COOKIES ITEMS
            compositeID = Guid.NewGuid().ToString();
            data = "10.1";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PP_COOKIES_ITEMS_SECTION_BODY_NUMBER"),
                ContentTextData = data,
                BodyOrder = 1,
                CompositeID = compositeID,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "www.comparecloudware.com may set and access Cookies on your computer.  Cookies that may be placed on your computer are detailed in Schedule 1 to this Policy.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PP_COOKIES_ITEMS_SECTION_BODY_ITEM"),
                ContentTextData = data,
                BodyOrder = 1,
                CompositeID = compositeID,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            compositeID = Guid.NewGuid().ToString();
            data = "10.2";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PP_COOKIES_ITEMS_SECTION_BODY_NUMBER"),
                ContentTextData = data,
                BodyOrder = 2,
                CompositeID = compositeID,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "A Cookie is a small file that resides on your computer’s hard drive and often contains an anonymous unique identifier and is accessible only by the web site that placed it there, not any other sites.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PP_COOKIES_ITEMS_SECTION_BODY_ITEM"),
                ContentTextData = data,
                BodyOrder = 2,
                CompositeID = compositeID,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            compositeID = Guid.NewGuid().ToString();
            data = "10.3";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PP_COOKIES_ITEMS_SECTION_BODY_NUMBER"),
                ContentTextData = data,
                BodyOrder = 3,
                CompositeID = compositeID,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "You may delete Cookies, however you may lose any information that enables you to access the Web Site more quickly.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PP_COOKIES_ITEMS_SECTION_BODY_ITEM"),
                ContentTextData = data,
                BodyOrder = 3,
                CompositeID = compositeID,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            compositeID = Guid.NewGuid().ToString();
            data = "10.4";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PP_COOKIES_ITEMS_SECTION_BODY_NUMBER"),
                ContentTextData = data,
                BodyOrder = 4,
                CompositeID = compositeID,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            data = "You can choose to enable or disable Cookies in your web browser.  By default, your browser will accept Cookies, however this can be altered.  For further details please consult the help menu in your browser.  Disabling Cookies may prevent you from using the full range of Services available on the Web Site.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PP_COOKIES_ITEMS_SECTION_BODY_ITEM"),
                ContentTextData = data,
                BodyOrder = 4,
                CompositeID = compositeID,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            #endregion

            #region PP CHANGES
            data = "11.	Changes to this Policy";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PP_CHANGES_SECTION_TITLE"),
                ContentTextData = data,
                BodyOrder = 1,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            #endregion

            #region PP CHANGES ITEMS
            data = "Compare Cloudware Ltd reserves the right to change this Privacy Policy as we may deem necessary from time to time or as may be required by law.  Any changes will be immediately posted on the Web Site and you are deemed to have accepted the terms of the Policy on your first use of the Web Site following the alterations.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PP_CHANGES_ITEMS_SECTION_BODY_ITEM"),
                ContentTextData = data,
                BodyOrder = 1,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "If you have any queries on the Terms & Conditions, email privacy@comparecloudware.com";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PP_CHANGES_ITEMS_SECTION_BODY_ITEM"),
                ContentTextData = data,
                BodyOrder = 2,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            #endregion

            #region HOME PAGE H1 etc
            data = "Welcome to Compare Cloudware!";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("HOMEPAGE_H1_TITLE"),
                ContentTextData = data,
                BodyOrder = 1,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "Thank you for visiting us here at comparecloudware.com, the first IT and Communications comparison website where you can choose, compare, review, try and buy a range of market leading services. Our job is simply to make life easier for you when it comes to buying IT and communication services that suit your needs and, of course, your budget";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("HOMEPAGE_H1_BODY"),
                ContentTextData = data,
                BodyOrder = 1,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "The good news is that all of our featured brands deliver their services through the Cloud, so all you need is a broadband internet connection with a suitable PC, laptop, tablet or smartphone to get started. It doesn’t matter if you are a home worker that’s always on the move or a small-to-medium sized organisation seeking to improve your efficiency and bottom-line.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("HOMEPAGE_H1_BODY"),
                ContentTextData = data,
                BodyOrder = 2,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "If you’re looking to compare the best deals or have something specific in mind, with a little help from Billy (our friendly comparison bug) and his crew, we can help.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("HOMEPAGE_H1_BODY"),
                ContentTextData = data,
                BodyOrder = 3,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "Benefits of Cloudware";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("HOMEPAGE_H2_1_TITLE"),
                ContentTextData = data,
                BodyOrder = 1,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "Cloudware is simply any software, service or application that is delivered via the Cloud to an internet enabled device of your choice.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("HOMEPAGE_H2_1_BODY"),
                ContentTextData = data,
                BodyOrder = 1,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "The chances are you’re already using the Cloud for entertainment or leisure services, think Facebook, BBC iPlayer, You Tube or Spotify for streaming music and you’ve already got the idea. Unfortunately, the IT industry often refer to software-as-a-service (SaaS) as a way to distinguish Cloud delivered services versus traditional ‘boxed’, pre-installed or downloaded software. For simplification we prefer to use Cloudware to describe all types of cloud delivered IT and communications services.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("HOMEPAGE_H2_1_BODY"),
                ContentTextData = data,
                BodyOrder = 2,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            //data = "The chances are you’re already using the Cloud for entertainment or leisure services, think Facebook, BBC iPlayer, You Tube or Spotify for streaming music and you’ve already got the idea. Unfortunately, the IT industry often refer to software-as-a-service (SaaS) as a way to distinguish Cloud delivered services versus traditional ‘boxed’, pre-installed or downloaded software. For simplification we prefer to use Cloudware to describe all types of cloud delivered IT and communications services.";
            //ct = new ContentText
            //{
            //    NiceName = "",
            //    ContentTextType = repository.FindContentTextTypeByName("HOMEPAGE_H2_1_BODY"),
            //    ContentTextData = data,
            //    BodyOrder = 3,
            //    ContentTextStatus = repository.FindStatusByName("LIVE"),
            //};
            //repository.AddContentText(ct);


            data = "For more information and to discover the many advantages of Cloud and cloudware, take a look at our #LINK_OBJECT#LINK_TEXTWhat is Cloudware?#LINK_TEXT#LINK_URLcloudware-explained#LINK_URL#LINK_OBJECT section.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("HOMEPAGE_H2_1_BODY"),
                ContentTextData = data,
                BodyOrder = 4,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "Choosing the right Cloudware";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("HOMEPAGE_H2_2_TITLE"),
                ContentTextData = data,
                BodyOrder = 1,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "Here at Compare Cloudware, we aim to make our service as straightforward and easy to understand as possible. We are:";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("HOMEPAGE_H2_2_BODY"),
                ContentTextData = data,
                BodyOrder = 1,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "Comparative – we make feature-by-feature comparison easier";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("HOMEPAGE_H2_2_BODY"),
                ContentTextData = data,
                BodyOrder = 2,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "Consultative – we help you refine your choices that best meet your needs";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("HOMEPAGE_H2_2_BODY"),
                ContentTextData = data,
                BodyOrder = 3,
                ContentTextStatus = repository.FindStatusByName("LIVE"),

            };
            repository.AddContentText(ct);

            data = "Conclusive – we help you find answers not search results";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("HOMEPAGE_H2_2_BODY"),
                ContentTextData = data,
                BodyOrder = 4,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "Comprehensive  - we offer a broad range of cloudware solutions";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("HOMEPAGE_H2_2_BODY"),
                ContentTextData = data,
                BodyOrder = 5,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "Clear – we avoid technical jargon";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("HOMEPAGE_H2_2_BODY"),
                ContentTextData = data,
                BodyOrder = 6,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            #endregion

            #endregion

            #endregion
            
            return retVal;
        }

        public static bool PumpContextTextDataForH1H2(QueryRepository repository)
        {
            bool retVal = true;

            ContentText ct;
            string data;

            
            
            #region HOME PAGE H1 etc
            //data = "Welcome to Compare Cloudware!";
            //ct = new ContentText
            //{
            //    NiceName = "",
            //    ContentTextType = repository.FindContentTextTypeByName("HOMEPAGE_H1_TITLE"),
            //    ContentTextData = data,
            //    BodyOrder = 1,
            //    ContentTextStatus = repository.FindStatusByName("LIVE"),
            //};
            //repository.AddContentText(ct);

            //data = "Thank you for visiting us here at comparecloudware.com, the first IT and Communications comparison website where you can choose, compare, review, try and buy a range of market leading services. Our job is simply to make life easier for you when it comes to buying IT and communication services that suit your needs and, of course, your budget. The good news is that all of our featured brands deliver their services through the Cloud, so all you need is a broadband internet connection with a suitable PC, laptop, tablet or smartphone to get started. It doesn’t matter if you are a home worker that’s always on the move or a small-to-medium sized organisation seeking to improve your efficiency and bottom-line. If you’re looking to compare the best deals or have something specific in mind, with a little help from Billy (our friendly comparison bug) and his crew, we can help.";
            //ct = new ContentText
            //{
            //    NiceName = "",
            //    ContentTextType = repository.FindContentTextTypeByName("HOMEPAGE_H1_BODY"),
            //    ContentTextData = data,
            //    BodyOrder = 2,
            //    ContentTextStatus = repository.FindStatusByName("LIVE"),
            //};
            //repository.AddContentText(ct);

            //data = "What is Cloudware and how can it benefit me?";
            //ct = new ContentText
            //{
            //    NiceName = "",
            //    ContentTextType = repository.FindContentTextTypeByName("HOMEPAGE_H2_1_TITLE"),
            //    ContentTextData = data,
            //    BodyOrder = 3,
            //    ContentTextStatus = repository.FindStatusByName("LIVE"),
            //};
            //repository.AddContentText(ct);

            //data = "Cloudware is simply any software, service or application that is delivered via the Cloud to an internet enabled device of your choice. The chances are you’re already using the Cloud for entertainment or leisure services, think Facebook, BBC iPlayer, You Tube or Spotify for streaming music and you’ve already got the idea. Unfortunately, the IT industry often refer to software-as-a-service (SaaS) as a way to distinguish Cloud delivered services versus traditional ‘boxed’, pre-installed or downloaded software. For simplification we prefer to use Cloudware to describe all types of cloud delivered IT and communications services. By choosing Cloudware you’re joining millions of people that are always connected with colleagues and customers, enjoy instant access to the latest improvements and appreciate complete peace of mind with the reassurance of flexible monthly subscriptions, little or zero upfront cost, no expensive upgrades, military-grade security and rock-solid backup already built-in.";
            //ct = new ContentText
            //{
            //    NiceName = "",
            //    ContentTextType = repository.FindContentTextTypeByName("HOMEPAGE_H2_1_BODY"),
            //    ContentTextData = data,
            //    BodyOrder = 4,
            //    ContentTextStatus = repository.FindStatusByName("LIVE"),
            //};
            //repository.AddContentText(ct);

            //data = "For more information and to discover the many advantages of Cloud and cloudware, take a look at our ";
            //ct = new ContentText
            //{
            //    NiceName = "",
            //    ContentTextType = repository.FindContentTextTypeByName("HOMEPAGE_H2_1_BODY"),
            //    ContentTextData = data,
            //    BodyOrder = 5,
            //    ContentTextStatus = repository.FindStatusByName("LIVE"),
            //};
            //repository.AddContentText(ct);

            //data = "Cloudware explained";
            //ct = new ContentText
            //{
            //    NiceName = "",
            //    ContentTextType = repository.FindContentTextTypeByName("HOMEPAGE_H2_1_BODY"),
            //    ContentTextData = data,
            //    BodyOrder = 6,
            //    ContentTextStatus = repository.FindStatusByName("LIVE"),

            //};
            //repository.AddContentText(ct);

            //data = " section.";
            //ct = new ContentText
            //{
            //    NiceName = "",
            //    ContentTextType = repository.FindContentTextTypeByName("HOMEPAGE_H2_1_BODY"),
            //    ContentTextData = data,
            //    BodyOrder = 7,
            //    ContentTextStatus = repository.FindStatusByName("LIVE"),
            //};
            //repository.AddContentText(ct);

            //data = "Choosing the right cloud computing service for your home or business";
            //ct = new ContentText
            //{
            //    NiceName = "",
            //    ContentTextType = repository.FindContentTextTypeByName("HOMEPAGE_H2_2_TITLE"),
            //    ContentTextData = data,
            //    BodyOrder = 8,
            //    ContentTextStatus = repository.FindStatusByName("LIVE"),
            //};
            //repository.AddContentText(ct);

            //data = "Here at Compare Cloudware, we aim to make our service as straightforward and easy to understand as possible. We are:";
            //ct = new ContentText
            //{
            //    NiceName = "",
            //    ContentTextType = repository.FindContentTextTypeByName("HOMEPAGE_H2_2_BODY"),
            //    ContentTextData = data,
            //    BodyOrder = 9,
            //    ContentTextStatus = repository.FindStatusByName("LIVE"),
            //};
            //repository.AddContentText(ct);

            //data = "Comparative – we make feature-by-feature comparison easier";
            //ct = new ContentText
            //{
            //    NiceName = "",
            //    ContentTextType = repository.FindContentTextTypeByName("HOMEPAGE_H2_2_BODY"),
            //    ContentTextData = data,
            //    BodyOrder = 10,
            //    ContentTextStatus = repository.FindStatusByName("LIVE"),
            //};
            //repository.AddContentText(ct);

            //data = "Consultative –we help you refine your choices that best meet your needs";
            //ct = new ContentText
            //{
            //    NiceName = "",
            //    ContentTextType = repository.FindContentTextTypeByName("HOMEPAGE_H2_2_BODY"),
            //    ContentTextData = data,
            //    BodyOrder = 11,
            //    ContentTextStatus = repository.FindStatusByName("LIVE"),

            //};
            //repository.AddContentText(ct);

            //data = "Conclusive – we help you find answers not search results";
            //ct = new ContentText
            //{
            //    NiceName = "",
            //    ContentTextType = repository.FindContentTextTypeByName("HOMEPAGE_H2_2_BODY"),
            //    ContentTextData = data,
            //    BodyOrder = 12,
            //    ContentTextStatus = repository.FindStatusByName("LIVE"),
            //};
            //repository.AddContentText(ct);

            //data = "Comprehensive  - we offer a broad range of cloudware solutions";
            //ct = new ContentText
            //{
            //    NiceName = "",
            //    ContentTextType = repository.FindContentTextTypeByName("HOMEPAGE_H2_2_BODY"),
            //    ContentTextData = data,
            //    BodyOrder = 13,
            //    ContentTextStatus = repository.FindStatusByName("LIVE"),
            //};
            //repository.AddContentText(ct);

            //data = "Clear – we avoid technical jargon";
            //ct = new ContentText
            //{
            //    NiceName = "",
            //    ContentTextType = repository.FindContentTextTypeByName("HOMEPAGE_H2_2_BODY"),
            //    ContentTextData = data,
            //    BodyOrder = 14,
            //    ContentTextStatus = repository.FindStatusByName("LIVE"),
            //};
            //repository.AddContentText(ct);

            #endregion

            #region CONFERENCING H1 etc
            data = "Introduction to online conferencing";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("CONFERENCING_H1_TITLE"),
                ContentTextData = data,
                BodyOrder = 15,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "Meetings are simply unavoidable and part of everyday life. Thankfully, instead of spending endless hours on the road or travelling by train or plane, there is now an easier and faster way to connect to customers, colleagues and suppliers. Using your PC, laptop, tablet or smartphone you can simply schedule an online conference with anyone, anywhere using the power of the internet and the Cloud.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("CONFERENCING_H1_BODY"),
                ContentTextData = data,
                BodyOrder = 16,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "Think of it as a kind of digital ‘teleportation’ where you can set-up or join a meeting instantly and invite participants seemingly out of thin air to answer specific questions or queries. Also, the ability to share documents and work together on one screen is fantastic compared to a somewhat crowded and huddled affair in the real world. Some providers even use high-definition audio and video, which is why we still recommend flossing!";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("CONFERENCING_H1_BODY"),
                ContentTextData = data,
                BodyOrder = 17,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "Now at Compare Cloudware, we’re not suggesting you replace all physical meetings with virtual sessions. However, making good use of cloud-based web conferencing software does mean you can prioritise the appointments that should be done face-to-face and settle them with a firm handshake.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("CONFERENCING_H1_BODY"),
                ContentTextData = data,
                BodyOrder = 18,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "Advantages of using online conferencing";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("CONFERENCING_H2_1_TITLE"),
                ContentTextData = data,
                BodyOrder = 19,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "Combining the benefits of a good old-fashioned telephone conversation with the ability to stream live video, online conferencing gives you the opportunity to communicate with colleagues and clients however you want, whenever you need to.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("CONFERENCING_H2_1_BODY"),
                ContentTextData = data,
                BodyOrder = 20,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "Online or web-based conferencing through the Cloud allows you to share ideas, presentations, documents and even video  allowing to share, review and revise in real-time without the hassle and time of a return journey! You can even create customer facing events over the internet (known as webinars) or coach new staff remotely. If that’s not enough, with some services you can also record your meetings and keep them for future reference. Imagine never having to repeat yourself again!";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("CONFERENCING_H2_1_BODY"),
                ContentTextData = data,
                BodyOrder = 21,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "Why compare and review conferencing options?";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("CONFERENCING_H2_2_TITLE"),
                ContentTextData = data,
                BodyOrder = 22,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "Love the idea of getting to grips with cloud-based online conferencing but don’t know where to start? Don’t spend hours trawling through dozens of different website to find a package that might fit the bill - buying conferencing software is a breeze with Compare Cloudware.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("CONFERENCING_H2_2_BODY"),
                ContentTextData = data,
                BodyOrder = 23,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "If you’re new to online conferencing, we can help you find a service that meets your needs with features that match-up to your specific requirements. Put simply, we can help you get to the answers quickly and match you to the most suitable conference provider. With a wide selection of market leading and specialist conferencing vendors, you can be sure to find the best provider with the right solution. So what are you waiting for, start comparing now!";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("CONFERENCING_H2_2_BODY"),
                ContentTextData = data,
                BodyOrder = 24,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);


            #endregion

            #region EMAIL H1 etc
            data = "Introduction to email";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("EMAIL_H1_TITLE"),
                ContentTextData = data,
                BodyOrder = 25,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "Email is one of life’s little treasures isn’t it? In fact with all the spam, junk mail, holiday competitions, cash prizes and coupons cluttering up your inbox, finding the email message you want can sometimes feel like searching for hidden Aztec gold. So ask yourself this question: when was the last time you reviewed your email set-up? Go on, admit it, it was probably when the X-Files was still on primetime.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("EMAIL_H1_BODY"),
                ContentTextData = data,
                BodyOrder = 26,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "Now we’ll whisper it quietly, but email has lived in the Cloud for quite a while and our guess is that you’re already using it with at least one account somewhere in your digital life, whether at home, in the office or out and about on your smartphone.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("EMAIL_H1_BODY"),
                ContentTextData = data,
                BodyOrder = 27,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "Well, like everything in the Cloud, you don’t need a dedicated box of electronics to run anything and migrating to another provider with your existing email address is simple and straightforward. Even better, you can archive all your email in the Cloud for instant back-up and disaster recovery. And for those of you that are still promoting your Internet Service Provider (ISP) brand in your email address? Shame on you, you’re missing the biggest marketing opportunity since the printing press!";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("EMAIL_H1_BODY"),
                ContentTextData = data,
                BodyOrder = 28,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "Why compare email services?";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("EMAIL_H2_1_TITLE"),
                ContentTextData = data,
                BodyOrder = 29,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "We know, we know - your time is precious. The last thing you want to do is spend your day looking for a solution to a problem that seemingly isn’t there. Most of us tend to choose a well-known email provider and stick with them for fear that switching over to a new service is going to be too much hassle – after all, it does the job, so why review it, right?";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("EMAIL_H2_1_BODY"),
                ContentTextData = data,
                BodyOrder = 30,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "But take a look at the different business email services on offer and you may start to think differently. The fact is, cloud email services are becoming more sophisticated all the time and the today’s packages boast a whole range of exciting features that are designed to help you manage communications more efficiently, including advanced Task Managers, Notes applications and integrated Instant Chat platforms (often a real winner with staff who want to fire across a quick question to a colleague, for example).";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("EMAIL_H2_1_BODY"),
                ContentTextData = data,
                BodyOrder = 31,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "Small issues with your current business email service can soon turn into big recurring problems that affect the way you do business. Take control of your messaging and compare cloud email services with Compare Cloudware!";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("EMAIL_H2_1_BODY"),
                ContentTextData = data,
                BodyOrder = 32,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "Which cloud email service do I choose?";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("EMAIL_H2_2_TITLE"),
                ContentTextData = data,
                BodyOrder = 33,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "Things are hotting up between the world’s best-known email hosting providers. As the demand for cloud email services is growing, service packages are becoming more competitive, which is great news for you, the customer, because it means the latest tools and features are becoming readily available at great rates.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("EMAIL_H2_2_BODY"),
                ContentTextData = data,
                BodyOrder = 34,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "Compare Cloudware can help you choose which webmail hosting service that will offer the most value to your setup, regardless of whether you’re a one-man band working from home or a multi-national corporation with employees all over the world. Check out our business email reviews to discover what users have to say about each business email provider or click on a product to view a full summary. Once you’ve made your decision, we will put you in direct touch with your chosen cloud email service provider, saving you even more clicks or even an email!";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("EMAIL_H2_2_BODY"),
                ContentTextData = data,
                BodyOrder = 35,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);


            #endregion

            #region STORAGE & BACKUP H1 etc
            data = "Introduction to storage & back-up";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("STORAGEANDBACKUP_H1_TITLE"),
                ContentTextData = data,
                BodyOrder = 36,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "We humans love collecting things until we’re bursting to the brim with a lifetime of possessions and souvenirs. After a while we usually head to IKEA to box-up old keepsakes and maybe put those boxes in the cupboard, loft or garage for safe-keeping. Ultimately, we either get rid of the accumulating odds and ends or maybe decide to go to a yellow painted self-storage facility!";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("STORAGEANDBACKUP_H1_BODY"),
                ContentTextData = data,
                BodyOrder = 37,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "Now what about your digital life? Instead of having important files, photos and videos spread across multiple computers and moving them around when you buy new devices, wouldn’t be simpler and safer to have all those digital belongings in one manageable place? We think it is. So don’t wait for the ‘blue screen of death’, a stolen smartphone or laptop, or even a fire (especially if you happen to live on a remote Caribbean island!) to ruin your digital existence.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("STORAGEANDBACKUP_H1_BODY"),
                ContentTextData = data,
                BodyOrder = 38,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "Whether it is a lifetime of memories, a treasured music library or essential work documents, storage in the cloud is safer than houses.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("STORAGEANDBACKUP_H1_BODY"),
                ContentTextData = data,
                BodyOrder = 39,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "Advantages of storage and back-up";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("STORAGEANDBACKUP_H2_1_TITLE"),
                ContentTextData = data,
                BodyOrder = 40,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "Storing and backing up your files remotely offers a whole host of benefits. Aside from the savings you can make from not having to invest in external hard drives or other devices, using the Cloud is more secure than storing your data locally. All files are encrypted (often beyond military grade) while they are being transmitted and while they are not being used, making doubly sure that your sensitive information is kept well away from even the most elusive peeping Toms or 007-style spy agencies.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("STORAGEANDBACKUP_H2_1_BODY"),
                ContentTextData = data,
                BodyOrder = 41,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "Sharing and syncing files using cloud storage software is easy as a mouse click and all files are automatically updated in the Cloud, which means multiple users can collaborate on a single document or presentation without having to worry about downloading the latest version. Plus, your files can be accessed from any device, which means that as long as you have an internet connection you can work from anywhere at any time you choose.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("STORAGEANDBACKUP_H2_1_BODY"),
                ContentTextData = data,
                BodyOrder = 42,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "In terms of backing up your data, online storage systems offer a fully scalable solution that’s cheap, secure and generally much easier to manage than the ‘traditional’ backup process.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("STORAGEANDBACKUP_H2_1_BODY"),
                ContentTextData = data,
                BodyOrder = 43,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "Why compare storage and back-up? ";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("STORAGEANDBACKUP_H2_2_TITLE"),
                ContentTextData = data,
                BodyOrder = 44,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "Moving over to the Cloud really is a no brainer for most businesses, but deciding on the right cloud storage and backup provider is crucial if you’re going to make the most of this revolutionary way of working. Compare Cloudware charges through the jargon and helps you assess the great features of a range of like-for-like packages from top industry suppliers. You can also view our users’ opinions for their take on some of the best online storage services if you need help making up your mind.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("STORAGEANDBACKUP_H2_2_BODY"),
                ContentTextData = data,
                BodyOrder = 45,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            repository.AddContentText(ct);


            #endregion

            #region PHONE H1 etc
            data = "Introduction to communications";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PHONE_H1_TITLE"),
                ContentTextData = data,
                BodyOrder = 46,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "The humble phone. Great isn’t it? When all else fails at least you can pick-up the phone and talk to somebody. The reality is that one standard phone line only goes so far, well in fact one conversation at a time! How many calls are you missing from prospective customers? Or worse, can existing customers get through to you?";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PHONE_H1_BODY"),
                ContentTextData = data,
                BodyOrder = 47,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "In the past, the answer was to install an expensive phone system and get multiple phone lines. Now with Cloud based telephony and phone systems you can have a number of lines with a single broadband connection with the ability to add smart functionality, such as who answers the phone, automatic call routing, out-of-hours messaging, call forwarding, music-on-hold and separate direct dial extensions. Some providers even offer sophisticated call centre functionality with the ability to record calls.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PHONE_H1_BODY"),
                ContentTextData = data,
                BodyOrder = 48,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "In most cases you keep your existing number and buy additional extensions as you need them, even for staff located in different offices or at home. You won’t need to buy any phone equipment - it’s literally another application available on-demand from the Cloud.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PHONE_H1_BODY"),
                ContentTextData = data,
                BodyOrder = 49,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "Advantages of cloud-based communications";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PHONE_H2_1_TITLE"),
                ContentTextData = data,
                BodyOrder = 50,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "Using your broadband connection to make calls is a more cost-effective way to communicate. Using a Voice over IP (VoIP) system, you can talk to an entire group of people simultaneously at a fraction of the cost of a phone connection, even if they’re on the other side of the world.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PHONE_H2_1_BODY"),
                ContentTextData = data,
                BodyOrder = 51,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "Granted, you’ll need a pretty slick internet connection to cope with a large conference call via your computer, but you will have lower charges and you’ll still benefit from excellent sound quality which is often better than a normal phone or mobile cell phone. The flexibility provided by internet phone systems is also second to none because you can add and remove phone lines depending on the demands of your business.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PHONE_H2_1_BODY"),
                ContentTextData = data,
                BodyOrder = 52,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "Why compare cloud-based communications?";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PHONE_H2_2_TITLE"),
                ContentTextData = data,
                BodyOrder = 53,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "Take the cost and hassle out of calling your friends, colleagues and clients – take a look at the latest internet telephony and VoIP packages for home and professional use with the help of Compare Cloudware. Just enter a few basic details into our system and we’ll get back to you with the best internet phone services on offer in the UK right now. If you want to hear feedback straight from the horses’ mouths, have a read of our internet phone product reviews for independent praise and criticism from our lovely customers. It will bug you if you don’t.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PHONE_H2_2_BODY"),
                ContentTextData = data,
                BodyOrder = 54,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            #endregion

            #region OFFICE H1 etc
            data = "Introduction to office";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("OFFICE_H1_TITLE"),
                ContentTextData = data,
                BodyOrder = 55,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "Do you buy expensive pre-loaded software because it’s less hassle than downloading or using CDs? We have all been guilty of that particular offence but now it’s no longer a sin that needs committing.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("OFFICE_H1_BODY"),
                ContentTextData = data,
                BodyOrder = 56,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "Like all cloud services, office applications and services are delivered on-demand, cheaper than their downloaded counterparts and using the latest version (so no more expensive upgrades!). With most office applications you can even work offline. Even better is the ability for members of a team to work on the same document in real time and retrieve files they need directly from the Cloud rather than somebody’s hard drive.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("OFFICE_H1_BODY"),
                ContentTextData = data,
                BodyOrder = 57,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "Forget about USB storage keys and emailing large documents - all you need is a username and a password to access your documents from anywhere. In addition to the standard fare of office suites, there is an abundance of specialist applications that enable office features on your smartphone, publish directly to a website, integrate with social media or even develop slick presentations with video. So unless you’re downloading yet another office software update or security patch, what are you waiting for?";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("OFFICE_H1_BODY"),
                ContentTextData = data,
                BodyOrder = 58,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "Advantages of cloud-based office";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("OFFICE_H2_1_TITLE"),
                ContentTextData = data,
                BodyOrder = 59,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "Where would we all be without our trusty office software? Having the ability to create, edit and present content and data through office applications has changed the way we work and even the way we approach our day-to-day task management.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("OFFICE_H2_1_BODY"),
                ContentTextData = data,
                BodyOrder = 60,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "Since the late 80s there’s no denying that Microsoft Office is perhaps the best-known and most widely used office suite, but it’s not necessarily for everyone. There’s now fierce competition from a large number of other providers who are introducing new and innovative features into their office software all the time.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("OFFICE_H2_1_BODY"),
                ContentTextData = data,
                BodyOrder = 61,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "There are plenty of low-cost office packages available for home users or smaller businesses that don’t require the power-user functionality of advanced office apps; similarly, there are a range of high end services that offer more control and functionality for busy professionals. The key is to find the cloud delivered office software that ticks all of your boxes at a price that can’t be sniffed at, even during hayfever season!";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("OFFICE_H2_1_BODY"),
                ContentTextData = data,
                BodyOrder = 62,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "Why compare office services?";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("OFFICE_H2_2_TITLE"),
                ContentTextData = data,
                BodyOrder = 63,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "Our mission here at Compare Cloudware is to make it as simple as possible for you to find the right online office software for your needs and budget. All you need to do is enter a few select details about your requirements and we’ll fire our recommendations straight back at you. Our service is 100% free and because we’re an independent website all of our comparison results are completely unbiased – we just let you know what’s out there and you do the rest!";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("OFFICE_H2_2_BODY"),
                ContentTextData = data,
                BodyOrder = 64,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "And if you’re struggling to pick a cloud office package, don’t worry – you’ll find tonnes of honest reviews from previous customers on our site too.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("OFFICE_H2_2_BODY"),
                ContentTextData = data,
                BodyOrder = 65,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);


            #endregion

            #region FINANCIAL H1 etc
            data = "Introduction to accounting";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("FINANCIAL_H1_TITLE"),
                ContentTextData = data,
                BodyOrder = 66,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "Are you still using spreadsheets to track your spending and payments? Are you still manually cross-referencing bank statements? Or worse, creating customer invoices using a word processor? Keeping track of the pennies is tough enough without creating more mess to try and keep on top of it all.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("FINANCIAL_H1_BODY"),
                ContentTextData = data,
                BodyOrder = 67,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "Whether you work from home, run a shop or look after a medium sized business, there is a cloudware service for you that makes finance and accounts a picnic rather than a dog’s dinner! So whether it is recording bank payments, looking at cashflow, creating invoices, running a payroll or helping with the tax return, you’ll find something tailored to your needs in this category.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("FINANCIAL_H1_BODY"),
                ContentTextData = data,
                BodyOrder = 68,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "The good news is that if it does all get too much you can give access to your accountant to help tidy things up. Now try and do that with a spreadsheet!";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("FINANCIAL_H1_BODY"),
                ContentTextData = data,
                BodyOrder = 69,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "Advantages of cloud-based finance";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("FINANCIAL_H2_1_TITLE"),
                ContentTextData = data,
                BodyOrder = 70,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "Unless you’ve been living in a cave for the last few years, you’ll have heard all about the great benefits of sharing experiences through the cloud based services like Facebook or LinkedIn. Having the functionality to work from anywhere across all of your devices works wonders for your team’s productivity, plus all of your data is securely stored in one central location, saving the need to move files from one piece of hardware to another. Imagine if you could apply these same benefits to your accounting!";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("FINANCIAL_H2_1_BODY"),
                ContentTextData = data,
                BodyOrder = 71,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "What would you rather be doing, focusing on driving your business forward or watching great opportunities pass you by because you’re spending too much time with your head in your books? Today’s cloud accounting services  allows you to get to grips with all those tricky finance tasks and significantly reduce the number of hours you need to dedicate to your finances.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("FINANCIAL_H2_1_BODY"),
                ContentTextData = data,
                BodyOrder = 72,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "Managing your accounting in the Cloud means that all your data is sitting in one centralised location, making it easy for your accountant or finance team to pick up where they left off and ensuring that all those vital reports and forecasts are waiting for you when you need them.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("FINANCIAL_H2_1_BODY"),
                ContentTextData = data,
                BodyOrder = 73,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "Thanks to improved encryption methods, Cloud accounting is also extremely secure, too, so you can rest assured your figures will be kept well away from prying eyes or even the tax man until you’re ready. Even our fellow bugs ‘The Beatles’ would advocate that approach!";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("FINANCIAL_H2_1_BODY"),
                ContentTextData = data,
                BodyOrder = 74,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "Why compare finance and accounting?";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("FINANCIAL_H2_2_TITLE"),
                ContentTextData = data,
                BodyOrder = 75,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "You’ll be surprised by the sheer range of cloud-based finance and accounting packages on offer. Whether you’re looking for a lightweight package for your home or small business or are on the hunt for a more sophisticated system that will give you heightened functionality, Compare Cloudware can help you find an online accounting package that’s going to transform the way you handle the finances.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("FINANCIAL_H2_2_BODY"),
                ContentTextData = data,
                BodyOrder = 76,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "All you need to do is enter a few details into our comparison console and we’ll give you the results within seconds  with the  services  we think you’ll be interested in.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("FINANCIAL_H2_2_BODY"),
                ContentTextData = data,
                BodyOrder = 77,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);


            #endregion

            #region CRM H1 etc
            data = "Introduction to CRM";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("CRM_H1_TITLE"),
                ContentTextData = data,
                BodyOrder = 78,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "What is your most important business asset? Well aside from that top of the range coffee machine that makes a dreamy cappuccino, it should be your customer (even if you happen to be Costa Coffee!). The cold hard truth, however, is that customers are often neglected instead of being cherished and nurtured like an eggnog latte at Christmas.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("CRM_H1_BODY"),
                ContentTextData = data,
                BodyOrder = 79,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "The reality is that if you’re out and about, have more than a handful of clients and a few staff that need to share customer information, you need something better than scraps of paper, post-it notes, email and office software. With Cloud-based customer relationship management (known in the IT trade as CRM), you can keep in touch with customers or prospective customers at a touch of a button.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("CRM_H1_BODY"),
                ContentTextData = data,
                BodyOrder = 80,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "Most CRM services are easy to set-up and work with cloud based email and phone systems. You can even integrate enquiry forms on your website to generate new business or help existing customers whilst using your smartphone to keep on top of what’s happening. Before you know it, you’ll be running customer campaigns, running a virtual helpdesk and forecasting sales like the big boys, but at a tiny fraction of the cost!";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("CRM_H1_BODY"),
                ContentTextData = data,
                BodyOrder = 81,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "Advantages of CRM";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("CRM_H2_1_TITLE"),
                ContentTextData = data,
                BodyOrder = 82,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "If you own a business or run a busy department, you’ll know that there’s so much to manage these days. This is why a more advanced customer management system really does form the foundations of any successful business.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("CRM_H2_1_BODY"),
                ContentTextData = data,
                BodyOrder = 83,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "Cloud-based CRM software helps you store, organise and track a huge amount of data relating to your staff, customers and business contacts, ensuring that all of this information is fully backed up so you can call on it whenever you need to whether office based or on the move. So, if you want to improve sales or simply find a way to improve service to your customers so that they stay that way in the future, cloud-based CRM is the best way to keep in touch to everyone’s satisfaction.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("CRM_H2_1_BODY"),
                ContentTextData = data,
                BodyOrder = 84,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "Why compare CRM?";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("CRM_H2_2_TITLE"),
                ContentTextData = data,
                BodyOrder = 85,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "Depending on what you do and the way your organisation is set up, your CRM requirements  will probably vary greatly from those of the company in the office next door, so what works for one team may not work for another. We know you’re busy people so we’ve made sure that we’re on hand to take the hassle out of researching and choosing the right customer management software.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("CRM_H2_2_BODY"),
                ContentTextData = data,
                BodyOrder = 86,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "Using Compare Cloudware, you can refine your search so that you’re only faced with CRM packages that are designed to fit your criteria. There’s no longer any need to manually search for software on the web at your own expense – just leave a few of your details with us and we’ll do the rest!";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("CRM_H2_2_BODY"),
                ContentTextData = data,
                BodyOrder = 87,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "If you’re new to the idea of a customer management system and want to learn more about how CRM can improve or change the way you do business, we suggest heading over to the product reviews section and taking a look at all the feedback we’ve collected from our lovely users. Customers who have been there and tried out many of the packages listed on Compare Cloudware will help you get a feel for what’s on offer from different providers.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("CRM_H2_2_BODY"),
                ContentTextData = data,
                BodyOrder = 88,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            #endregion

            #region PROJECTMANAGEMENT H1 etc
            data = "Introduction to project management";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PROJECTMANAGEMENT_H1_TITLE"),
                ContentTextData = data,
                BodyOrder = 89,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "Most of us try our upmost to manage our lives with a dose of common sense, perhaps the occasional ‘to do’ list and maybe even mark a calendar with a special event. For the most part that’s OK but sometimes we need a little extra help and that’s what this category is all about. Here’s how to become a project management whizz using purpose-built software that’s up in the Cloud!";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PROJECTMANAGEMENT_H1_BODY"),
                ContentTextData = data,
                BodyOrder = 90,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "Successful project management is about keeping track of all the important (and seemingly unimportant things) in our more complex endeavours. Making sure certain tasks don’t fall between the cracks will help prevent wasted time, increased costs and rising blood pressure. So whether you’re building an extension, developing an app, keeping tabs on an important assignment or even doing a work project that sits outside your normal comfort zone, we suggest ditching the self-made ‘to do’ list and getting hold of something that can really help ease the burden.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PROJECTMANAGEMENT_H1_BODY"),
                ContentTextData = data,
                BodyOrder = 91,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "Now of course you may be able to afford hiring a professional project manager or, better still, actually be one. If this is the case and you‘re already a skilled schemer you may find new project management software here that can help you keep on top of your game.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PROJECTMANAGEMENT_H1_BODY"),
                ContentTextData = data,
                BodyOrder = 92,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "Advantages of project management";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PROJECTMANAGEMENT_H2_1_TITLE"),
                ContentTextData = data,
                BodyOrder = 93,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "Chances are you want to know how much bang you can get for your buck, so what’s on offer from today’s cloud-based project management apps?";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PROJECTMANAGEMENT_H2_1_BODY"),
                ContentTextData = data,
                BodyOrder = 94,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "Well, aside from the fact that you can access the platform from anywhere and virtually any device (meaning each user can manage their workload on the go), online project management services typically offer- a huge range of features that make life much, much easier for everyone.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PROJECTMANAGEMENT_H2_1_BODY"),
                ContentTextData = data,
                BodyOrder = 95,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "At a basic level, scheduling tools will help you delegate and manage tasks according to priority and impact, while much of the extra functionality included in each package will allow you to log your expenses, monitor how much time each task takes to complete, and keep on top of your budget to make sure you’re on track financially at each stage of the job. Many project management systems are also integrated with social platforms to make communication between team members ultra-efficient.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PROJECTMANAGEMENT_H2_1_BODY"),
                ContentTextData = data,
                BodyOrder = 96,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "Why compare project management?";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PROJECTMANAGEMENT_H2_2_TITLE"),
                ContentTextData = data,
                BodyOrder = 97,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "If you don’t know where to start when it comes to choosing the right project management tools, you’re in luck. Compare Cloudware specialises in helping home and business users find the best project management services based on specific requirements. We’ve put together a simple and intuitive comparison engine that allows you to compare and research what’s on offer from all the leading project management providers in a matter of seconds. So now, finding the best project management service no longer requires a plan!";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PROJECTMANAGEMENT_H2_2_BODY"),
                ContentTextData = data,
                BodyOrder = 98,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            #endregion

            #region SECURITY H1 etc
            data = "Introduction to cloud-based security";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("SECURITY_H1_TITLE"),
                ContentTextData = data,
                BodyOrder = 99,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "Going into overdrive with our ‘digital life’ is great – whether it’s at work or at home. But the risk to those files, records, photos, designs and recordings is immense. So many treasured and valued documents - many are irreplaceable and others are just simply priceless! With all today’s threats from malware and online viruses, what actions do you take to keep yourself safe?";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("SECURITY_H1_BODY"),
                ContentTextData = data,
                BodyOrder = 100,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "What should you do to protect all your devices and content – from tablet to phone, from email to database? Protection from scammers, hackers, identity thieves, and chancers could seem like a full time occupation, especially in today’s get-rich-quick culture. So, how do you make sure you don’t ‘star’ in The Hustle – or just lose all your data thanks to a good old-fashioned virus?";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("SECURITY_H1_BODY"),
                ContentTextData = data,
                BodyOrder = 101,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "The answer could be one solution. The answer could be a few. Whichever one it is, it’ll be on Compare Cloudware – and it’s waiting for you to discover it right now. Simply enter your requirements to get ‘digital lock-down’. You’ll get the peace of mind that you’re doing everything you should to protect and defend your stuff, regardless of whether you’re a home user or need to protect hundreds of devices across your business network.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("SECURITY_H1_BODY"),
                ContentTextData = data,
                BodyOrder = 102,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "Advantages of cloud-based security";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("SECURITY_H2_1_TITLE"),
                ContentTextData = data,
                BodyOrder = 103,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "Surprisingly (for some), choosing to run cloud-based internet security and anti-virus services offers loads of benefits over installing ‘traditional’ anti-virus packages.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("SECURITY_H2_1_BODY"),
                ContentTextData = data,
                BodyOrder = 104,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "Most cloud-based security and anti-virus applications work by running a small piece of software on the desktop and connecting to a central monitoring server up in the Cloud, so installing the product across multiple PCs or Macs is simple. In addition cloud-based security services won’t place so much of a strain on your hard drive because all the demanding work takes place away from your computer, so you’ll be freeing up resources elsewhere and experiencing  faster  performance on your device.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("SECURITY_H2_1_BODY"),
                ContentTextData = data,
                BodyOrder = 105,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "It’s worth mentioning too that cloud security and anti-virus applications are updated automatically, so there’s no need for you or your staff to remember to run an update to avoid the latest threats. Protection is continuous and you won’t need to worry about individual users turning off their anti-virus checker by mistake (or otherwise – we all get frustrated by those endless pop-ups from time to time!).";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("SECURITY_H2_1_BODY"),
                ContentTextData = data,
                BodyOrder = 106,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "Why compare security and anti-virus?";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("SECURITY_H2_2_TITLE"),
                ContentTextData = data,
                BodyOrder = 107,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "There’s so much to consider when choosing the right internet security package for your home system or business network, which is why here at Compare Cloudware we have come up with a service that allows you to compare all of the best internet security and anti-virus packages in one place. Simply provide us with a few details about you and your preferences and we’ll let you know what level of protection you’ll need to keep your digital world safe. The last thing we would want for our lovely customers is to suffer at the hands of any internet dwelling highwaymen!";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("SECURITY_H2_2_BODY"),
                ContentTextData = data,
                BodyOrder = 108,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);
            #endregion

            #region HOSTING H1 etc
            data = "Introduction to Cloud Hosting";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("HOSTING_H1_TITLE"),
                ContentTextData = data,
                BodyOrder = 99,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "In the 1970’s if you said the word “hosting” you would think of warming trolleys, fondue sets and Black Forest gateaux. In today’s computer world, ensuring your website is up to the job is a constant battle with new services, third-party apps and plug-ins becoming available to help optimise your online existence. From blogs to full-blown ecommerce platforms, choosing the right hosting partner can ensure you reduce downtime and maximise opportunity. Whilst hosting is not particularly expensive (compared with a bricks and mortar equivalent), it does pay to shop around and look at the features you need, the level of security required and how easy it is to set-up. You might also want to consider the level and type of support you need especially if you don’t have an IT expert in the house (it can often feel like finding a plumber when you need one!). So what are you waiting for? Find out who is the host with the most.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("HOSTING_H1_BODY"),
                ContentTextData = data,
                BodyOrder = 100,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "Advantages of Hosting";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("HOSTING_H2_1_TITLE"),
                ContentTextData = data,
                BodyOrder = 103,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "Most small businesses are not experts in IT and, even for those that are, it pays to have a professional hosting company to take care of your hosting requirements. The 5 critical advantages of cloud based Hosting are: -";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("HOSTING_H2_1_BODY"),
                ContentTextData = data,
                BodyOrder = 104,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "1.	Around the clock monitoring – how much would it cost if your online services were affected?";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("HOSTING_H2_1_BODY"),
                ContentTextData = data,
                BodyOrder = 105,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "2.	Reliability – hosting companies deploy the latest technology and equipment which is out-of-reach for most small businesses.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("HOSTING_H2_1_BODY"),
                ContentTextData = data,
                BodyOrder = 106,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "3.	Support – 24/7 customer service is often part of many packages.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("HOSTING_H2_1_BODY"),
                ContentTextData = data,
                BodyOrder = 107,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "4.	Security – military grade security protocols ensure your data and/or website is safe.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("HOSTING_H2_1_BODY"),
                ContentTextData = data,
                BodyOrder = 108,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "5.	Scalability – no need to buy equipment or predict what you need in the future because you don’t need any infrastructure, it’s all taken care of.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("HOSTING_H2_1_BODY"),
                ContentTextData = data,
                BodyOrder = 108,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "Why Compare Cloud Hosting?";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("HOSTING_H2_2_TITLE"),
                ContentTextData = data,
                BodyOrder = 103,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "Cloud or web hosting allows businesses to benefit from technical support and better security that is not often possible with small businesses. To ensure you have the right service and are getting value for money, it is not always about price. You may want to consider the following: -";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("HOSTING_H2_2_BODY"),
                ContentTextData = data,
                BodyOrder = 104,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "1.	Do you get 24/7 telephone based customer service or perhaps you just need online support?";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("HOSTING_H2_2_BODY"),
                ContentTextData = data,
                BodyOrder = 104,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "2.	Got enough storage and bandwidth? Is your service flexible to allow more traffic when you need it?";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("HOSTING_H2_2_BODY"),
                ContentTextData = data,
                BodyOrder = 104,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "3.	Virtual Private Services – do you need your own private data centre that is matched to specific requirements rather than a turnkey solution?";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("HOSTING_H2_2_BODY"),
                ContentTextData = data,
                BodyOrder = 104,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "4.	Does the provider offer SSL (secure socket layer) to ensure your site encrypts valuable data such as credit card numbers?";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("HOSTING_H2_2_BODY"),
                ContentTextData = data,
                BodyOrder = 104,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "5.	Do you need webtool integrations to ensure that your website performs and functions the way you want it to? ";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("HOSTING_H2_2_BODY"),
                ContentTextData = data,
                BodyOrder = 104,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "6.	You can easily discover all this and more by using Compare Cloudware.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("HOSTING_H2_2_BODY"),
                ContentTextData = data,
                BodyOrder = 104,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            #endregion

            #region WEBSITE H1 etc
            data = "Introduction to Website services";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("WEBSITE_H1_TITLE"),
                ContentTextData = data,
                BodyOrder = 99,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "Despite having the most internet savvy economy, incredibly around 15 million companies in the good ‘ol USA still don’t have websites! In the UK and the rest of Europe it’s a similar picture. Once the preserve of fast food loving web masters or local ‘Bob down the road’ IT shops, there is now an abundance of cloud based website building software where you can create everything yourself and pick features just like pizza toppings. From a simple ‘share your thoughts’ Blog to a full-blown eCommerce store, there really is no excuse in having a half-baked website. Not only can you have a professional website in just a few minutes, you can have a website that is easy to manage and update. With plenty of migration services available you can easily move to a better suited option rather than rely on Pepperoni Pete to make changes or add an image. Go on, take a slice of the online action today.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("WEBSITE_H1_BODY"),
                ContentTextData = data,
                BodyOrder = 100,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "Advantage of Website services";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("WEBSITE_H2_1_TITLE"),
                ContentTextData = data,
                BodyOrder = 103,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "Let’s face it most of struggle to remember our credit card pin number let alone understand the art and science of computing code. With the latest website building software you can create the perfect website in a matter of minutes. Here are just 5 advantages of why website software is better in the Cloud: -";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("WEBSITE_H2_1_BODY"),
                ContentTextData = data,
                BodyOrder = 104,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "1.	Error Free – why waste time writing code that may not work, even if you know some coding languages, a website builder will save time and possible aggravation.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("WEBSITE_H2_1_BODY"),
                ContentTextData = data,
                BodyOrder = 105,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "2.	Latest Designs – get beautifully designed templates at a touch of button";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("WEBSITE_H2_1_BODY"),
                ContentTextData = data,
                BodyOrder = 106,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "3.	Get Social – integrate social media plug-ins without things getting awkward!";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("WEBSITE_H2_1_BODY"),
                ContentTextData = data,
                BodyOrder = 107,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "4.	Mobile Friendly – does your current website look good on a small screen?";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("WEBSITE_H2_1_BODY"),
                ContentTextData = data,
                BodyOrder = 108,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "5.	Ease of Use – need to update your site regularly? It’s a breeze with website building service.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("WEBSITE_H2_1_BODY"),
                ContentTextData = data,
                BodyOrder = 108,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "Why Compare Website services?";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("WEBSITE_H2_2_TITLE"),
                ContentTextData = data,
                BodyOrder = 103,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "All website building services are different with specialisms in specific areas such as ecommerce and blogs. When you choose website building software you may want to consider the following: -";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("WEBSITE_H2_2_BODY"),
                ContentTextData = data,
                BodyOrder = 104,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "1.	Can I see analytics and reporting relating to my site visitors?";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("WEBSITE_H2_2_BODY"),
                ContentTextData = data,
                BodyOrder = 104,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "2.	Can I integrate with 3rd Party applications?";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("WEBSITE_H2_2_BODY"),
                ContentTextData = data,
                BodyOrder = 104,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "3.	What design tools can I choose from and does the website builder cater for my industry?";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("WEBSITE_H2_2_BODY"),
                ContentTextData = data,
                BodyOrder = 104,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "4.	Can I build a storefront that’s accepts credit cards?";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("WEBSITE_H2_2_BODY"),
                ContentTextData = data,
                BodyOrder = 104,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "5.	Can I link with my social media accounts?";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("WEBSITE_H2_2_BODY"),
                ContentTextData = data,
                BodyOrder = 104,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "6.	Is my site compatible with Google Ads?";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("WEBSITE_H2_2_BODY"),
                ContentTextData = data,
                BodyOrder = 104,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "7.	Can I improve my search engine results with in-built tools?";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("WEBSITE_H2_2_BODY"),
                ContentTextData = data,
                BodyOrder = 104,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "You can discover all this and more when you use Compare Cloudware.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("WEBSITE_H2_2_BODY"),
                ContentTextData = data,
                BodyOrder = 104,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            #endregion

            #region PAYMENTS H1 etc
            data = "Introduction to Online Payments";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PAYMENTS_H1_TITLE"),
                ContentTextData = data,
                BodyOrder = 99,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "Cold hard cash will soon be consigned to history or at least be seen as a niche as a writing a cheque. The ability to allow customers to make instant, convenient and safe payments from a PC, laptop or mobile phone will make all the difference for those wanting to run a successful business in the online world. Even in the offline world, cloud based payment systems are revolutionising the way customers receive service from restaurants using tablets to take orders (as well as ensure accurate bills) to buying the latest gadget where paper receipts are frowned upon. From buying a morning coffee with the obligatory blueberry muffin to rare white-label vinyl of a post-punk classic, the world is open for business and you can have a slice of the action for just pennies per day. So welcome to the new world of online payments, you may not be able to barter you’re way to a great deal but using Compare Cloudware you’ll certainly be able to find one that fits the bill!";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PAYMENTS_H1_BODY"),
                ContentTextData = data,
                BodyOrder = 100,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "Advantages of Payment Services";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PAYMENTS_H2_1_TITLE"),
                ContentTextData = data,
                BodyOrder = 103,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "If you sell stuff on your website, you need a fast and efficient online payment service to improve your site experience, lower overheads and ensure your customers have the best overall experience. Online shoppers now expect to pay for purchases immediately and receiving shipments quickly. Here are the 3 top advantages of using an online payment service:-";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PAYMENTS_H2_1_BODY"),
                ContentTextData = data,
                BodyOrder = 104,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "1.	Tighter Security - thanks to security features such as card number encryption and 3D fraud protection, people can buy from you with a high degree of confidence.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PAYMENTS_H2_1_BODY"),
                ContentTextData = data,
                BodyOrder = 105,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "2.	Instant Gratification – getting what you want immediately is the primary motivation for shopping online and online payment enables a customer to pay for a product immediately.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PAYMENTS_H2_1_BODY"),
                ContentTextData = data,
                BodyOrder = 106,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "3.	Recurring Payments - accepting payments online removes the problems associated with making recurring payments via standing orders, direct debit or even a cheque (remember those?). If you have a subscription-based service, you can store customers' payment information and collect payments automatically each subscription term rather than sending reminders that payments are now due.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PAYMENTS_H2_1_BODY"),
                ContentTextData = data,
                BodyOrder = 107,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "Why Compare Payment Services?";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PAYMENTS_H2_2_TITLE"),
                ContentTextData = data,
                BodyOrder = 103,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "There are a range of online payment services that specialise in different areas and have very different commercial terms in terms of transactions and cost of handling different payments methods. Depending on where you trade and who you intend to trade with will mean shopping around. Here are some other things to consider:-";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PAYMENTS_H2_2_BODY"),
                ContentTextData = data,
                BodyOrder = 104,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "1.	Does the payment service offer check-out cart integration?";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PAYMENTS_H2_2_BODY"),
                ContentTextData = data,
                BodyOrder = 104,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "2.	Can my customers make payments with all kinds of credit, charge and debit cards?";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PAYMENTS_H2_2_BODY"),
                ContentTextData = data,
                BodyOrder = 104,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "3.	Does my online payment service include telephone and mail order payments?";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PAYMENTS_H2_2_BODY"),
                ContentTextData = data,
                BodyOrder = 104,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "4.	Do I get free transaction refunds for incorrect or accidental customer orders?";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PAYMENTS_H2_2_BODY"),
                ContentTextData = data,
                BodyOrder = 104,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "5.	Can I receive multi-currency payments?";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PAYMENTS_H2_2_BODY"),
                ContentTextData = data,
                BodyOrder = 104,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "You can discover all this and more when you use Compare Cloudware.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("PAYMENTS_H2_2_BODY"),
                ContentTextData = data,
                BodyOrder = 104,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            #endregion

            #region HR H1 etc
            data = "Introduction to HR Software";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("HR_H1_TITLE"),
                ContentTextData = data,
                BodyOrder = 99,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "Some of you may remember the dreaded Personnel Department? For those that do, it would often strike fear in the hearts of anyone who was invited to attend an interview or meeting. For the most part that has all changed. Today, Human Resources (HR) may sound as though you’ve swallowed a red-coloured reality pill from The Matrix, but it’s essential to ensure your business looks after the most important asset of all, your people. It can also help attract new staff as you grow or ensure you backfill positions quickly. With the advent of cloudware, there are a range HR packages which have streamlined and automated a range of administrative tasks from time-sheets to performance reviews to hiring. Some HR services even actively encourage staff participation and collaboration with self-service access on a smartphone. Now that’s something even Keanu Reeves didn’t see coming!";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("HR_H1_BODY"),
                ContentTextData = data,
                BodyOrder = 100,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "Advantages of Cloud HR";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("HR_H2_1_TITLE"),
                ContentTextData = data,
                BodyOrder = 103,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "One of the biggest advantages HR and recruiting professionals will experience from cloud delivered services is empowering staff to do more. The ability for employees (and potential new recruits) to access information, conduct 365 degree appraisals and apply for positions from anywhere on any device is a strong signal that they are part of (or hoping to join) a progressive company. Of course corporate image and mobile access are not the only advantages, here are our Top 3 reasons why you should head into the cloud with HR:-";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("HR_H2_1_BODY"),
                ContentTextData = data,
                BodyOrder = 104,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "1.	Communications – supercharge you communications by sending information to the right people at the right time without the copy/paste.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("HR_H2_1_BODY"),
                ContentTextData = data,
                BodyOrder = 105,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "2.	Self-Service – with the rise in home and flexible working, accessing cloud based HR systems can mean finding notices quickly and self-service features such as training and development enrolment and expenses.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("HR_H2_1_BODY"),
                ContentTextData = data,
                BodyOrder = 106,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "3.	Compliance – provide easy access to the latest compliance, code of conduct, health and safety documentation.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("HR_H2_1_BODY"),
                ContentTextData = data,
                BodyOrder = 107,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "Why Compare Cloud HR services? ";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("HR_H2_2_TITLE"),
                ContentTextData = data,
                BodyOrder = 103,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "Depending on size and industry, small to medium size businesses will have different requirements that need focus on certain areas. If you run a field trade organisation then mobile access to safety information or timesheets may be necessary whereas for a sales office it could be that regular performance appraisals are essential. Here are some other reasons you may want to dig deeper when it comes to choosing the right provider:-";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("HR_H2_2_BODY"),
                ContentTextData = data,
                BodyOrder = 104,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "1.	Do you need to store and provide access to a wide range of documentation?";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("HR_H2_2_BODY"),
                ContentTextData = data,
                BodyOrder = 104,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "2.	Will you need a recruitment module to manage the interview and selection process?";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("HR_H2_2_BODY"),
                ContentTextData = data,
                BodyOrder = 104,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "3.	Do you need automated employment and on-boarding features?";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("HR_H2_2_BODY"),
                ContentTextData = data,
                BodyOrder = 104,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "4.	Are you going to run multiple training and development programmes?";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("HR_H2_2_BODY"),
                ContentTextData = data,
                BodyOrder = 104,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "5.	Do you have a robust case management system for complaints and disciplinary processes?";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("HR_H2_2_BODY"),
                ContentTextData = data,
                BodyOrder = 104,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "You can discover all this and more when you use Compare Cloudware.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("HR_H2_2_BODY"),
                ContentTextData = data,
                BodyOrder = 104,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            #endregion

            #region SALES H1 etc
            data = "Introduction to Sales software";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("SALES_H1_TITLE"),
                ContentTextData = data,
                BodyOrder = 99,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "If you can’t get leads or close leads that you generate, it’s only going to end badly for you and your business. In the seminal words from the greatest sales movie of all time Glengarry Glen Ross “put that coffee down” and start looking for online sales software which can help organise your team, provide instant deal visibility and accelerate your sales. With cloud based Sales software you can rapidly create the perfect sales dashboard for you and your team providing a visual overview of your sales data divided into different categories, split by products/services and salespeople. You can track activity goals by setting team and individual goals whilst moving deals along to the next stage so that you get the sale in fastest possible time. Today, of course, it’s not just about ‘cold call’ motivation and being more efficient with your sales funnel, it’s also about adopting new techniques such as social selling and using your website to ensure all opportunities are captured properly. Before you know it, using the right sales software will be easy as ABC which means you’ll “Always Be Closing!”";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("SALES_H1_BODY"),
                ContentTextData = data,
                BodyOrder = 100,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "Advantages of Sales software";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("SALES_H2_1_TITLE"),
                ContentTextData = data,
                BodyOrder = 103,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "If a business doesn’t focus on driving revenue then it won’t be in business for very long. Whilst whiteboards, spreadsheet trackers and even customer relationship management (CRM) applications go so far, they may not be enough to make the difference when it comes to closing the deal. Here are our Top 5 reasons why you should consider dedicated cloud-delivered sales software:-";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("SALES_H2_1_BODY"),
                ContentTextData = data,
                BodyOrder = 104,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "1.	Real-Time Reporting – why wait for the weekly sales ‘hotwash’ to see the pipeline, get up to the second reporting instantly.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("SALES_H2_1_BODY"),
                ContentTextData = data,
                BodyOrder = 105,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "2.	Performance Improvements– need a dashboard on who and what is selling?";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("SALES_H2_1_BODY"),
                ContentTextData = data,
                BodyOrder = 106,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "3.	Activity Metrics – who is performing in terms of activity but not selling?";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("SALES_H2_1_BODY"),
                ContentTextData = data,
                BodyOrder = 107,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "4.	Increased Productivity – enable your sales team to look up important details on the go allowing mobile access to contacts and deal histories before that critical meeting. ";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("SALES_H2_1_BODY"),
                ContentTextData = data,
                BodyOrder = 107,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "5.	See the Future – view ongoing deals arranged by their likely close date next to deals you've already closed.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("SALES_H2_1_BODY"),
                ContentTextData = data,
                BodyOrder = 107,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "Why Compare Sales software?";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("SALES_H2_2_TITLE"),
                ContentTextData = data,
                BodyOrder = 103,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "Products and services are not built the same and have different sales lifecycles; let’s face it buying a house if different to buying marketing services or a loaf of bread. Selling to consumers is also a completely different kettle of fish to business-to-business sales, so ensuring the right fit is a critical component of buying the right sales software for your business. You may also want to consider the following features when choosing the right sales cloudware provider:-";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("SALES_H2_2_BODY"),
                ContentTextData = data,
                BodyOrder = 104,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "1.	Do you need to track specific deals and manage them over a long period of time?";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("SALES_H2_2_BODY"),
                ContentTextData = data,
                BodyOrder = 104,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "2.	What sort of goals and targets will you be setting?";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("SALES_H2_2_BODY"),
                ContentTextData = data,
                BodyOrder = 104,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "3.	Do you need to score leads and route them to the right salesperson?";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("SALES_H2_2_BODY"),
                ContentTextData = data,
                BodyOrder = 104,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "4.	Do you need telephone integration to manage calling activity?";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("SALES_H2_2_BODY"),
                ContentTextData = data,
                BodyOrder = 104,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "5.	Do you need to import and/or export contact information?";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("SALES_H2_2_BODY"),
                ContentTextData = data,
                BodyOrder = 104,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "You can discover all this and more when you use Compare Cloudware.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("SALES_H2_2_BODY"),
                ContentTextData = data,
                BodyOrder = 104,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            #endregion

            #region INTELLIGENCE & REPORTING H1 etc
            data = "Introduction to Intelligence & Reporting";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("INTELLIGENCEANDREPORTING_H1_TITLE"),
                ContentTextData = data,
                BodyOrder = 99,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "To some, Business Intelligence may sound like the covert activity undertaken by the likes of the CIA or MI5. For the more cynical amongst us, it may conjure images of the Snowden revelations of government snooping. But for many organisations, Business Intelligence software (or BI as they call it in the trade!) can provide the guidance needed for greater success – as well as the warning signs of failure!";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("INTELLIGENCEANDREPORTING_H1_BODY"),
                ContentTextData = data,
                BodyOrder = 100,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "Whatever the size of business, management always need to know essential information – for better or for worse. What sales channels are making money – and which ones are flagging? What products are proving profitable – and what services need retiring? What trends do you need to worry about? Where are tomorrow’s sales and opportunities likely to come from? ";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("INTELLIGENCEANDREPORTING_H1_BODY"),
                ContentTextData = data,
                BodyOrder = 100,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "Oh, if every business could answer these questions. But all of this is a reality with the right business reporting and intelligence software.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("INTELLIGENCEANDREPORTING_H1_BODY"),
                ContentTextData = data,
                BodyOrder = 100,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "Business Intelligence, analytics and reporting tools are used to convert raw data into meaningful and useful information for business analysis purposes. It’s all a bit complicated under the bonnet, but the goal of BI is to allow the easy interpretation of large amounts of data.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("INTELLIGENCEANDREPORTING_H1_BODY"),
                ContentTextData = data,
                BodyOrder = 100,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "So, rather than play the role of James Bond, business managers can behave more like Richard Branson - identifying new exciting opportunities for long-term success.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("INTELLIGENCEANDREPORTING_H1_BODY"),
                ContentTextData = data,
                BodyOrder = 100,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "Advantages of Intelligence & Reporting";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("INTELLIGENCEANDREPORTING_H2_1_TITLE"),
                ContentTextData = data,
                BodyOrder = 103,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "Imagine having the essential information you need for world domination – all at your fingertips. Just pick up your smart phone, tablet or laptop to see a real-time view of what’s going on, everywhere in your empire. Oh, the power of BI and analytics!";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("INTELLIGENCEANDREPORTING_H2_1_BODY"),
                ContentTextData = data,
                BodyOrder = 104,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "Cloud-based BI can help you achieve this. What’s more, it’s quick to deploy and simple to use. It can be used to support a wide range of business decisions ranging from operational to strategic. Basic operating decisions include product positioning or pricing. Strategic business decisions include priorities, goals and directions at the broadest level.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("INTELLIGENCEANDREPORTING_H2_1_BODY"),
                ContentTextData = data,
                BodyOrder = 105,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "BI technologies provide historical, current and predictive views of business operations. Common functions of business intelligence are company reporting, understanding online activities, assessing business performance, benchmarking against competitors and forecasting. It might all sound a bit heavy and technical – but (as they say), no pain no gain.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("INTELLIGENCEANDREPORTING_H2_1_BODY"),
                ContentTextData = data,
                BodyOrder = 106,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "Why Compare Intelligence & Reporting? ";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("INTELLIGENCEANDREPORTING_H2_2_TITLE"),
                ContentTextData = data,
                BodyOrder = 103,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = " OK, we agree that Business Intelligence tools may not sound the sexiest of subject matters. But, how does increased profit, improved productivity, enhanced cash value sound to you?";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("INTELLIGENCEANDREPORTING_H2_2_BODY"),
                ContentTextData = data,
                BodyOrder = 104,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "The truth is that BI can make quite an impact. The question is – which Business Intelligence and reporting option is right for your business? ";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("INTELLIGENCEANDREPORTING_H2_2_BODY"),
                ContentTextData = data,
                BodyOrder = 104,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "•	Which cloud business intelligence offering has the right forecasting and reporting tools?";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("INTELLIGENCEANDREPORTING_H2_2_BODY"),
                ContentTextData = data,
                BodyOrder = 104,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "•	Which reporting option can you afford?";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("INTELLIGENCEANDREPORTING_H2_2_BODY"),
                ContentTextData = data,
                BodyOrder = 104,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "•	What business information options can you run on tablets and smart phones?";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("INTELLIGENCEANDREPORTING_H2_2_BODY"),
                ContentTextData = data,
                BodyOrder = 104,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "•	What solution gives the intelligence dashboard and KPI personalisation you require?";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("INTELLIGENCEANDREPORTING_H2_2_BODY"),
                ContentTextData = data,
                BodyOrder = 104,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "•	Which BI option provides the right level of support?";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("INTELLIGENCEANDREPORTING_H2_2_BODY"),
                ContentTextData = data,
                BodyOrder = 104,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "Just some of the answers that can be provided by Compare Cloudware.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("INTELLIGENCEANDREPORTING_H2_2_BODY"),
                ContentTextData = data,
                BodyOrder = 104,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            #endregion

            #region MARKETING H1 etc
            data = "Introduction to Marketing software";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("MARKETING_H1_TITLE"),
                ContentTextData = data,
                BodyOrder = 99,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "Think about marketing and you start to think of those bohemian, creative types with big bright ideas about ‘raising your profile’ and ‘building your brand’. Those guys add great value to your business – but they’ve normally overdosed on caffeine and bring overly-wild ideas to the table.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("MARKETING_H1_BODY"),
                ContentTextData = data,
                BodyOrder = 100,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "As a smaller business you’ve got a choice. Invite these crazy types in for a coffee tea, or have a go yourself. For most organisations, the reality is that they need a blend of both. But, that’s where the wonderful new world of cloud marketing tools gets interesting.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("MARKETING_H1_BODY"),
                ContentTextData = data,
                BodyOrder = 100,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "Whether you’re looking to market to new or existing customers, there’s now a rich vein of cloud-based applications to help you. Email broadcast, social marketing, PR, search, telemarketing, survey and webinar management tools – all immediately accessible by the magic of cloud. Often, these are the tools used by the pro’s. Many of them allow great team-working between agency and client – and also between client and agency. This means you can establish imaginative ways to collaborate and co-create.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("MARKETING_H1_BODY"),
                ContentTextData = data,
                BodyOrder = 100,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "So, whether you’re a professional creative type serving clients or a small business looking to ‘fly solo’, Compare Cloudware is the best place to start.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("MARKETING_H1_BODY"),
                ContentTextData = data,
                BodyOrder = 100,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "Advantages of cloud-based Marketing software";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("MARKETING_H2_1_TITLE"),
                ContentTextData = data,
                BodyOrder = 103,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "Whether you’re a ‘professional’ or ‘nominated’ marketer, you’ll love the fact that cloud-based marketing tools can be accessed from anywhere. Whether planning a campaign, sending an email, doing social ‘shouts’, creating video content, creating landing pages or carrying out research exercises - you’re not tied to an application that sits on a PC.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("MARKETING_H2_1_BODY"),
                ContentTextData = data,
                BodyOrder = 104,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "You can even go on your hols and trigger an automated campaign from the hotel’s wifi. As long as there’s a browser and Internet access, you can access your complete marketing toolbox. And remember, if you partner with those crazy agency-types, you can often share tools and resources.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("MARKETING_H2_1_BODY"),
                ContentTextData = data,
                BodyOrder = 105,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "What’s more, the flexible licensing and rapid availability of industry-leading technology often makes the use of cloud-based marketing tools a ‘no-brainer’.  Whether working directly for clients or within an in-house environment, cloud-delivered marketing services enable lightening-fast, efficient and transparent campaigns.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("MARKETING_H2_1_BODY"),
                ContentTextData = data,
                BodyOrder = 106,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "Why compare Marketing software?";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("MARKETING_H2_2_TITLE"),
                ContentTextData = data,
                BodyOrder = 103,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = " OK, it’s not brain surgery but communicating with customers and prospects can be a bit risky. Get it right and it can reap big rewards and all seem so easy. But, get it wrong and it can end up costing you goodwill, relationships and money besides. Choosing and selecting the right marketing tools is directly related to your success.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("MARKETING_H2_2_BODY"),
                ContentTextData = data,
                BodyOrder = 104,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "•	What platforms support marketing across social networks?";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("MARKETING_H2_2_BODY"),
                ContentTextData = data,
                BodyOrder = 104,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "•	How many providers can help with automated emails?";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("MARKETING_H2_2_BODY"),
                ContentTextData = data,
                BodyOrder = 104,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "•	Which marketing software and cloudware can be used for surveys?";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("MARKETING_H2_2_BODY"),
                ContentTextData = data,
                BodyOrder = 104,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "•	What solutions provide landing pages, email broadcast – and integrated reporting?";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("MARKETING_H2_2_BODY"),
                ContentTextData = data,
                BodyOrder = 104,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "•	What webinar package provides the right support?";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("MARKETING_H2_2_BODY"),
                ContentTextData = data,
                BodyOrder = 104,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "Whether you’re a professional marketer or have been nominated with the role - discover the best cloud marketing technology options on Compare Cloudware.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("MARKETING_H2_2_BODY"),
                ContentTextData = data,
                BodyOrder = 104,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            #endregion

            #region BUSINESS OPERATIONS H1 etc
            data = "Introduction to Business Operations";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("BUSINESSANDOPERATIONS_H1_TITLE"),
                ContentTextData = data,
                BodyOrder = 99,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "So, who do you think has the business X factor? Global entrepreneurs like Trump or Branson? Tech innovators such as Jobs or Ellison? Or, do you admire the shrewd, savvy type like Sugar? Whoever inspires you most, it takes more than a big character and bright idea to build and grow a successful business.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("BUSINESSANDOPERATIONS_H1_BODY"),
                ContentTextData = data,
                BodyOrder = 100,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "Now, we don’t want to sound like a boring business strategy book - but it needs systems and processes that encourage company-wide behaviours and decision-making. These should be based on the culture that the leaders want to create. Cue cloud-based business applications.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("BUSINESSANDOPERATIONS_H1_BODY"),
                ContentTextData = data,
                BodyOrder = 100,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "Cloudware running through all your business operations acts like a digital nervous system – connecting the vital organs of the organisation.  Management know the status of absolutely everything – from field staff utilisation, resources availability, inventory status, online operations, retail outlet figures, customer service metrics – right through to supplier risk and exposure. (OK, we are now we are sounding like a business strategy book!)";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("BUSINESSANDOPERATIONS_H1_BODY"),
                ContentTextData = data,
                BodyOrder = 100,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "Cloudware has the potential to transform any organisation to a modern business – allowing leaders and manager to know how they’re performing - at any point - and at a moment’s notice.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("BUSINESSANDOPERATIONS_H1_BODY"),
                ContentTextData = data,
                BodyOrder = 100,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "Advantages of cloud-based Business Operations";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("BUSINESSANDOPERATIONS_H2_1_TITLE"),
                ContentTextData = data,
                BodyOrder = 103,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "For decades, businesses looking for operations software have been tied to the high cost of licenses and costly support and implementation. This has rendered the growing business a second class user – unable to afford and embrace these tools. But at Compare Cloudware, we think that’s all about to change – with a revolution that’ll allow even the smallest business to trade blows with the big guns.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("BUSINESSANDOPERATIONS_H2_1_BODY"),
                ContentTextData = data,
                BodyOrder = 104,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "The growing business is nimble and often has a workforce spread over office, home and mobile locations. The great news is that cloud applications are a superb fit for today's teleworking and virtual enterprises. What’s more, Cloudware enables innovative and game-changing services that managers could only dream about a few years ago. Nowadays, pretty much any business service can be re-imagined and re-budgeted. The opportunities created from using cloud-based applications across your business cannot be overstated.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("BUSINESSANDOPERATIONS_H2_1_BODY"),
                ContentTextData = data,
                BodyOrder = 105,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "The growing business benefits from blue-chip grade technology, support, security and innovation – but with flexible and cost-effective subscription models and license arrangements. That sounds very tempting doesn’t it? Soon your business could be taking a swipe at Messrs Sugar and co!";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("BUSINESSANDOPERATIONS_H2_1_BODY"),
                ContentTextData = data,
                BodyOrder = 106,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "Why Compare Business Operations software";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("BUSINESSANDOPERATIONS_H2_2_TITLE"),
                ContentTextData = data,
                BodyOrder = 103,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "‘Let’s get some software’. That’s the rally call from many business managers that know they need ‘a system’ to fix their problems. But they don’t know what solutions are out there to fulfil their needs?";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("BUSINESSANDOPERATIONS_H2_2_BODY"),
                ContentTextData = data,
                BodyOrder = 104,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "•	What helpdesk software can you afford to help improve customer service?";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("BUSINESSANDOPERATIONS_H2_2_BODY"),
                ContentTextData = data,
                BodyOrder = 104,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "•	Which purchase order and quote management solution helps with inventory across all sites?";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("BUSINESSANDOPERATIONS_H2_2_BODY"),
                ContentTextData = data,
                BodyOrder = 104,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "•	How do you know what field staff management system can run on smart phones and tablets?";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("BUSINESSANDOPERATIONS_H2_2_BODY"),
                ContentTextData = data,
                BodyOrder = 104,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "•	What e-signature solution will work across the whole business?";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("BUSINESSANDOPERATIONS_H2_2_BODY"),
                ContentTextData = data,
                BodyOrder = 104,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "•	Which workforce management software helps with time and attendance – and project costing?";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("BUSINESSANDOPERATIONS_H2_2_BODY"),
                ContentTextData = data,
                BodyOrder = 104,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "We simplify the decision-making process with a simple and intuitive comparison engine that allows you to compare and research what’s on offer from all the leading business and operations management providers. All within a matter of seconds.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("BUSINESSANDOPERATIONS_H2_2_BODY"),
                ContentTextData = data,
                BodyOrder = 104,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "So, what are you waiting for? Let’s get going!";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("BUSINESSANDOPERATIONS_H2_2_BODY"),
                ContentTextData = data,
                BodyOrder = 104,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            #endregion

            #region CREATIVE H1 etc
            data = "Introduction to Creative and Design";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("CREATIVE_H1_TITLE"),
                ContentTextData = data,
                BodyOrder = 99,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "High standards in creative and design used to the reserve of boutique businesses and larger organisations. These were the ones that could afford to bring in the ‘ponytails’ and ‘arty types’ to add some ‘je ne sais quoi’ to a company’s presentation. This would be followed by an explosion of mood boards, concepts and creative brainstorming. But that’s all changed – everyone now sees the power and value of good aesthetics and design.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("CREATIVE_H1_BODY"),
                ContentTextData = data,
                BodyOrder = 100,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "We’re all getting more visually aware and literate - whether it’s our houses, electrical goods, interiors, wardrobes or even food. We want things that don’t just carry out their task – but look cracking too! Presentation of the business is no different – whether it’s reports, proposals, emails, newsletters, videos, sales collateral or the website. Customers, suppliers and prospects are more visually savvy and demanding – often making decisions on instant appeal and how professional you look.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("CREATIVE_H1_BODY"),
                ContentTextData = data,
                BodyOrder = 100,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "At Compare Cloudware, we’re not trying turn all business owners into the next Mad Men advertising executive. However, many of the design software and creative tools available are the ones used by the pros – and many of them are more straightforward to use than you’d imagine.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("CREATIVE_H1_BODY"),
                ContentTextData = data,
                BodyOrder = 100,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "Advantages of Creative and Design cloud software";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("CREATIVE_H2_1_TITLE"),
                ContentTextData = data,
                BodyOrder = 103,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "Chances are you already rely on cloud-based services for some of your business’ marketing and networking activity. Many will be using LinkedIn, Twitter, Facebook – or even a blog or web-forms already. But, this is the tip of the iceberg - professional-quality, completely cloud-based creative apps are now a reality too. Wahoo – we can all discover our inner artist!";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("CREATIVE_H2_1_BODY"),
                ContentTextData = data,
                BodyOrder = 104,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "Whether you’re a wannabe creative or jeans-wearing design guru, there’s an exciting array of intuitive and feature-rich tools out there. These include video production, app building, graphic design, email broadcast, web page creation, photo-manipulation, diagramming, eBook and animation production. These are all ready and waiting to add some pizazz to your organisations image.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("CREATIVE_H2_1_BODY"),
                ContentTextData = data,
                BodyOrder = 105,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "Furthermore, many of these design software tools are available for free-trial periods, so you can give them a text drive before you let them loose within the unsuspecting organisation.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("CREATIVE_H2_1_BODY"),
                ContentTextData = data,
                BodyOrder = 106,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "Why Compare Creative and Design software? ";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("CREATIVE_H2_2_TITLE"),
                ContentTextData = data,
                BodyOrder = 103,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "So, want to play Art Director, Publisher or Video Producer but not sure where to start? Need to produce business-winning pitches but not sure what tools are right? Or, need to improve clarity of sales and product collateral but not sure what presentation tools are best? Compare Cloudware guides you through the process of deciding what Cloudware is right for you. You tell us the features, browsers and support you require – and we’ll give you the answers.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("CREATIVE_H2_2_BODY"),
                ContentTextData = data,
                BodyOrder = 104,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "•	What cloud software can you afford for video creation?";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("CREATIVE_H2_2_BODY"),
                ContentTextData = data,
                BodyOrder = 104,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "•	Which cloud platform should be considered for publishing customer newsletters or eBooks?";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("CREATIVE_H2_2_BODY"),
                ContentTextData = data,
                BodyOrder = 104,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "•	What’s the right Cloudware for building apps from existing data and content?";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("CREATIVE_H2_2_BODY"),
                ContentTextData = data,
                BodyOrder = 104,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "•	What software options are there for photo retouching?";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("CREATIVE_H2_2_BODY"),
                ContentTextData = data,
                BodyOrder = 104,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "•	Which graphic design software helps produce animations and animated images? ";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("CREATIVE_H2_2_BODY"),
                ContentTextData = data,
                BodyOrder = 104,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            data = "Let Compare Cloudware discover the right video application to help you become the next Steven Spielberg – or the app building tool to make the next Angry Birds.";
            ct = new ContentText
            {
                NiceName = "",
                ContentTextType = repository.FindContentTextTypeByName("CREATIVE_H2_2_BODY"),
                ContentTextData = data,
                BodyOrder = 104,
                ContentTextStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentText(ct);

            #endregion

            return retVal;

        }

        public static bool PumpContextTextTypesForTabs(QueryRepository repository)
        {
            bool retVal = true;

            ContentTextType ctt;
            string data;

            ctt = new ContentTextType()
            {
                ContentTextTypeName = "CLOUDWAREEXPLAINEDPAGE_TITLE",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);

            ctt = new ContentTextType()
            {
                ContentTextTypeName = "CLOUDWAREEXPLAINED_TAB_TITLE",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);

            ctt = new ContentTextType()
            {
                ContentTextTypeName = "10REASONSFORUSINGCLOUDWARE_TAB_TITLE",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);

            ctt = new ContentTextType()
            {
                ContentTextTypeName = "WHATDOESMYBUSINESSNEEDTORUNCLOUDWARE_TAB_TITLE",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);

            ctt = new ContentTextType()
            {
                ContentTextTypeName = "CLOUDWAREEXPLAINED_TAB_HEADER",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);

            ctt = new ContentTextType()
            {
                ContentTextTypeName = "10REASONSFORUSINGCLOUDWARE_TAB_HEADER",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);

            ctt = new ContentTextType()
            {
                ContentTextTypeName = "WHATDOESMYBUSINESSNEEDTORUNCLOUDWARE_TAB_HEADER",
                ContentTextTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddContentTextType(ctt);

            return retVal;
        }

        public static byte[] GetImageAsBytes(string outputPath)
        {
            //string outputPath = MPU_FILEPATH + MPU_FILE1;
            //System.Drawing.Image i = System.Drawing.Image.FromFile(outputPath);
            //FileStream fs = new FileStream(outputPath, FileMode.Open,FileAccess.Read);
            //BinaryReader br = new BinaryReader(fs);
            //byte[] image = br.ReadBytes((int)fs.Length);
            byte[] image2 = File.ReadAllBytes(outputPath);
            return image2;
        }

    }
}
