using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CompareCloudware.Domain.Models;
using System.IO;

namespace CompareCloudware.POCOQueryRepository.DataPump
{
    public static class TagData
    {
        public static bool PumpTagData(QueryRepository repository)
        {

            bool retVal = true;

            #region TAGS
            Tag t;

            #region PRIMARY

            #region WEB CONFERENCING PRIMARY
            t = new Tag()
            {
                TagName = "Conferences",
                Category = repository.FindCategoryByName("WEB CONFERENCING"),
                TagType = repository.FindTagTypeByName("PRIMARY"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);

            t = new Tag()
            {
                TagName = "Webinar",
                Category = repository.FindCategoryByName("WEB CONFERENCING"),
                TagType = repository.FindTagTypeByName("PRIMARY"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "Meetings",
                Category = repository.FindCategoryByName("WEB CONFERENCING"),
                TagType = repository.FindTagTypeByName("PRIMARY"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);

            t = new Tag()
            {
                TagName = "Online",
                Category = repository.FindCategoryByName("WEB CONFERENCING"),
                TagType = repository.FindTagTypeByName("PRIMARY"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "Business",
                Category = repository.FindCategoryByName("WEB CONFERENCING"),
                TagType = repository.FindTagTypeByName("PRIMARY"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "Audio",
                Category = repository.FindCategoryByName("WEB CONFERENCING"),
                TagType = repository.FindTagTypeByName("PRIMARY"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "Presentations",
                Category = repository.FindCategoryByName("WEB CONFERENCING"),
                TagType = repository.FindTagTypeByName("PRIMARY"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            #endregion

            #region PHONE PRIMARY
            t = new Tag()
            {
                TagName = "Communications",
                Category = repository.FindCategoryByName("COMMUNICATIONS"),
                TagType = repository.FindTagTypeByName("PRIMARY"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);

            t = new Tag()
            {
                TagName = "Phone",
                Category = repository.FindCategoryByName("COMMUNICATIONS"),
                TagType = repository.FindTagTypeByName("PRIMARY"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "Call Center",
                Category = repository.FindCategoryByName("COMMUNICATIONS"),
                TagType = repository.FindTagTypeByName("PRIMARY"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);

            t = new Tag()
            {
                TagName = "Telephone",
                Category = repository.FindCategoryByName("COMMUNICATIONS"),
                TagType = repository.FindTagTypeByName("PRIMARY"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "PBX",
                Category = repository.FindCategoryByName("COMMUNICATIONS"),
                TagType = repository.FindTagTypeByName("PRIMARY"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "VoIP",
                Category = repository.FindCategoryByName("COMMUNICATIONS"),
                TagType = repository.FindTagTypeByName("PRIMARY"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "Cheap",
                Category = repository.FindCategoryByName("COMMUNICATIONS"),
                TagType = repository.FindTagTypeByName("PRIMARY"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            #endregion

            #region STORAGE AND BACKUP PRIMARY
            t = new Tag()
            {
                TagName = "Data",
                Category = repository.FindCategoryByName("STORAGE AND BACKUP"),
                TagType = repository.FindTagTypeByName("PRIMARY"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);

            t = new Tag()
            {
                TagName = "Back Up",
                Category = repository.FindCategoryByName("STORAGE AND BACKUP"),
                TagType = repository.FindTagTypeByName("PRIMARY"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "USB",
                Category = repository.FindCategoryByName("STORAGE AND BACKUP"),
                TagType = repository.FindTagTypeByName("PRIMARY"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);

            t = new Tag()
            {
                TagName = "Drive",
                Category = repository.FindCategoryByName("STORAGE AND BACKUP"),
                TagType = repository.FindTagTypeByName("PRIMARY"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "Storage",
                Category = repository.FindCategoryByName("STORAGE AND BACKUP"),
                TagType = repository.FindTagTypeByName("PRIMARY"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "Sync",
                Category = repository.FindCategoryByName("STORAGE AND BACKUP"),
                TagType = repository.FindTagTypeByName("PRIMARY"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "File",
                Category = repository.FindCategoryByName("STORAGE AND BACKUP"),
                TagType = repository.FindTagTypeByName("PRIMARY"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            #endregion

            #region SECURITY PRIMARY
            t = new Tag()
            {
                TagName = "Anti Virus",
                Category = repository.FindCategoryByName("SECURITY"),
                TagType = repository.FindTagTypeByName("PRIMARY"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);

            t = new Tag()
            {
                TagName = "Protect",
                Category = repository.FindCategoryByName("SECURITY"),
                TagType = repository.FindTagTypeByName("PRIMARY"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "Safe",
                Category = repository.FindCategoryByName("SECURITY"),
                TagType = repository.FindTagTypeByName("PRIMARY"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);

            t = new Tag()
            {
                TagName = "Malware",
                Category = repository.FindCategoryByName("SECURITY"),
                TagType = repository.FindTagTypeByName("PRIMARY"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "Spam",
                Category = repository.FindCategoryByName("SECURITY"),
                TagType = repository.FindTagTypeByName("PRIMARY"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "Encryption",
                Category = repository.FindCategoryByName("SECURITY"),
                TagType = repository.FindTagTypeByName("PRIMARY"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            #endregion

            #region OFFICE PRIMARY
            t = new Tag()
            {
                TagName = "Management",
                Category = repository.FindCategoryByName("OFFICE"),
                TagType = repository.FindTagTypeByName("PRIMARY"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);

            t = new Tag()
            {
                TagName = "Microsoft",
                Category = repository.FindCategoryByName("OFFICE"),
                TagType = repository.FindTagTypeByName("PRIMARY"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "Suite",
                Category = repository.FindCategoryByName("OFFICE"),
                TagType = repository.FindTagTypeByName("PRIMARY"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);

            t = new Tag()
            {
                TagName = "Presentations",
                Category = repository.FindCategoryByName("OFFICE"),
                TagType = repository.FindTagTypeByName("PRIMARY"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "Spreadsheet",
                Category = repository.FindCategoryByName("OFFICE"),
                TagType = repository.FindTagTypeByName("PRIMARY"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "Documents",
                Category = repository.FindCategoryByName("OFFICE"),
                TagType = repository.FindTagTypeByName("PRIMARY"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            #endregion

            #region CRM PRIMARY
            t = new Tag()
            {
                TagName = "CRM",
                Category = repository.FindCategoryByName("CRM"),
                TagType = repository.FindTagTypeByName("PRIMARY"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);

            t = new Tag()
            {
                TagName = "Relationship",
                Category = repository.FindCategoryByName("CRM"),
                TagType = repository.FindTagTypeByName("PRIMARY"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "Software",
                Category = repository.FindCategoryByName("CRM"),
                TagType = repository.FindTagTypeByName("PRIMARY"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);

            t = new Tag()
            {
                TagName = "Businesses",
                Category = repository.FindCategoryByName("CRM"),
                TagType = repository.FindTagTypeByName("PRIMARY"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "Sales",
                Category = repository.FindCategoryByName("CRM"),
                TagType = repository.FindTagTypeByName("PRIMARY"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "Database",
                Category = repository.FindCategoryByName("CRM"),
                TagType = repository.FindTagTypeByName("PRIMARY"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            #endregion

            #region EMAIL PRIMARY
            t = new Tag()
            {
                TagName = "Mail",
                Category = repository.FindCategoryByName("EMAIL"),
                TagType = repository.FindTagTypeByName("PRIMARY"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);

            t = new Tag()
            {
                TagName = "Contact",
                Category = repository.FindCategoryByName("EMAIL"),
                TagType = repository.FindTagTypeByName("PRIMARY"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "Messages",
                Category = repository.FindCategoryByName("EMAIL"),
                TagType = repository.FindTagTypeByName("PRIMARY"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);

            t = new Tag()
            {
                TagName = "Outlook",
                Category = repository.FindCategoryByName("EMAIL"),
                TagType = repository.FindTagTypeByName("PRIMARY"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "Exchange",
                Category = repository.FindCategoryByName("EMAIL"),
                TagType = repository.FindTagTypeByName("PRIMARY"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "Webmail",
                Category = repository.FindCategoryByName("EMAIL"),
                TagType = repository.FindTagTypeByName("PRIMARY"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            #endregion

            #endregion

            #region SECONDARY

            #region WEB CONFERENCING SECONDARY
            t = new Tag()
            {
                TagName = "Teleconferencing",
                Category = repository.FindCategoryByName("WEB CONFERENCING"),
                TagType = repository.FindTagTypeByName("SECONDARY"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);

            t = new Tag()
            {
                TagName = "Chat",
                Category = repository.FindCategoryByName("WEB CONFERENCING"),
                TagType = repository.FindTagTypeByName("SECONDARY"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "Video",
                Category = repository.FindCategoryByName("WEB CONFERENCING"),
                TagType = repository.FindTagTypeByName("SECONDARY"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);

            t = new Tag()
            {
                TagName = "Events",
                Category = repository.FindCategoryByName("WEB CONFERENCING"),
                TagType = repository.FindTagTypeByName("SECONDARY"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "Sharing",
                Category = repository.FindCategoryByName("WEB CONFERENCING"),
                TagType = repository.FindTagTypeByName("SECONDARY"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "Collaboration",
                Category = repository.FindCategoryByName("WEB CONFERENCING"),
                TagType = repository.FindTagTypeByName("SECONDARY"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            #endregion

            #region PHONE SECONDARY
            t = new Tag()
            {
                TagName = "Sound",
                Category = repository.FindCategoryByName("COMMUNICATIONS"),
                TagType = repository.FindTagTypeByName("SECONDARY"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);

            t = new Tag()
            {
                TagName = "IVR",
                Category = repository.FindCategoryByName("COMMUNICATIONS"),
                TagType = repository.FindTagTypeByName("SECONDARY"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "Centrex",
                Category = repository.FindCategoryByName("COMMUNICATIONS"),
                TagType = repository.FindTagTypeByName("SECONDARY"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);

            t = new Tag()
            {
                TagName = "Calling",
                Category = repository.FindCategoryByName("COMMUNICATIONS"),
                TagType = repository.FindTagTypeByName("SECONDARY"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "Headsets",
                Category = repository.FindCategoryByName("COMMUNICATIONS"),
                TagType = repository.FindTagTypeByName("SECONDARY"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "Recorder",
                Category = repository.FindCategoryByName("COMMUNICATIONS"),
                TagType = repository.FindTagTypeByName("SECONDARY"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            #endregion

            #region STORAGE AND BACKUP SECONDARY
            t = new Tag()
            {
                TagName = "Computers",
                Category = repository.FindCategoryByName("STORAGE AND BACKUP"),
                TagType = repository.FindTagTypeByName("SECONDARY"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);

            t = new Tag()
            {
                TagName = "Portable",
                Category = repository.FindCategoryByName("STORAGE AND BACKUP"),
                TagType = repository.FindTagTypeByName("SECONDARY"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "Container",
                Category = repository.FindCategoryByName("STORAGE AND BACKUP"),
                TagType = repository.FindTagTypeByName("SECONDARY"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);

            t = new Tag()
            {
                TagName = "Folders",
                Category = repository.FindCategoryByName("STORAGE AND BACKUP"),
                TagType = repository.FindTagTypeByName("SECONDARY"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "Copy",
                Category = repository.FindCategoryByName("STORAGE AND BACKUP"),
                TagType = repository.FindTagTypeByName("SECONDARY"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "DR",
                Category = repository.FindCategoryByName("STORAGE AND BACKUP"),
                TagType = repository.FindTagTypeByName("SECONDARY"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            #endregion

            #region SECURITY SECONDARY
            t = new Tag()
            {
                TagName = "Firewall",
                Category = repository.FindCategoryByName("SECURITY"),
                TagType = repository.FindTagTypeByName("SECONDARY"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);

            t = new Tag()
            {
                TagName = "Threat",
                Category = repository.FindCategoryByName("SECURITY"),
                TagType = repository.FindTagTypeByName("SECONDARY"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "Protection",
                Category = repository.FindCategoryByName("SECURITY"),
                TagType = repository.FindTagTypeByName("SECONDARY"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);

            t = new Tag()
            {
                TagName = "Data",
                Category = repository.FindCategoryByName("SECURITY"),
                TagType = repository.FindTagTypeByName("SECONDARY"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "Attack",
                Category = repository.FindCategoryByName("SECURITY"),
                TagType = repository.FindTagTypeByName("SECONDARY"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "Hacking",
                Category = repository.FindCategoryByName("SECURITY"),
                TagType = repository.FindTagTypeByName("SECONDARY"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            #endregion

            #region OFFICE SECONDARY
            t = new Tag()
            {
                TagName = "Windows",
                Category = repository.FindCategoryByName("OFFICE"),
                TagType = repository.FindTagTypeByName("SECONDARY"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);

            t = new Tag()
            {
                TagName = "Application",
                Category = repository.FindCategoryByName("OFFICE"),
                TagType = repository.FindTagTypeByName("SECONDARY"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "Downloads",
                Category = repository.FindCategoryByName("OFFICE"),
                TagType = repository.FindTagTypeByName("SECONDARY"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);

            t = new Tag()
            {
                TagName = "Word",
                Category = repository.FindCategoryByName("OFFICE"),
                TagType = repository.FindTagTypeByName("SECONDARY"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "Excel",
                Category = repository.FindCategoryByName("OFFICE"),
                TagType = repository.FindTagTypeByName("SECONDARY"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "PowerPoint",
                Category = repository.FindCategoryByName("OFFICE"),
                TagType = repository.FindTagTypeByName("SECONDARY"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            #endregion

            #region CRM SECONDARY
            t = new Tag()
            {
                TagName = "Contact",
                Category = repository.FindCategoryByName("CRM"),
                TagType = repository.FindTagTypeByName("SECONDARY"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);

            t = new Tag()
            {
                TagName = "Support",
                Category = repository.FindCategoryByName("CRM"),
                TagType = repository.FindTagTypeByName("SECONDARY"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "Reseach",
                Category = repository.FindCategoryByName("CRM"),
                TagType = repository.FindTagTypeByName("SECONDARY"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);

            t = new Tag()
            {
                TagName = "Leads",
                Category = repository.FindCategoryByName("CRM"),
                TagType = repository.FindTagTypeByName("SECONDARY"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "Marketing",
                Category = repository.FindCategoryByName("CRM"),
                TagType = repository.FindTagTypeByName("SECONDARY"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "Client",
                Category = repository.FindCategoryByName("CRM"),
                TagType = repository.FindTagTypeByName("SECONDARY"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            #endregion

            #region EMAIL PRIMARY
            t = new Tag()
            {
                TagName = "Marketing",
                Category = repository.FindCategoryByName("EMAIL"),
                TagType = repository.FindTagTypeByName("SECONDARY"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);

            t = new Tag()
            {
                TagName = "Server",
                Category = repository.FindCategoryByName("EMAIL"),
                TagType = repository.FindTagTypeByName("SECONDARY"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "Incoming",
                Category = repository.FindCategoryByName("EMAIL"),
                TagType = repository.FindTagTypeByName("SECONDARY"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);

            t = new Tag()
            {
                TagName = "Addresses",
                Category = repository.FindCategoryByName("EMAIL"),
                TagType = repository.FindTagTypeByName("SECONDARY"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "Accounts",
                Category = repository.FindCategoryByName("EMAIL"),
                TagType = repository.FindTagTypeByName("SECONDARY"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            #endregion

            #endregion

            #region TERTIARY

            #region WEB CONFERENCING TERTIARY
            t = new Tag()
            {
                TagName = "Call",
                Category = repository.FindCategoryByName("WEB CONFERENCING"),
                TagType = repository.FindTagTypeByName("TERTIARY"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);

            t = new Tag()
            {
                TagName = "Easy",
                Category = repository.FindCategoryByName("WEB CONFERENCING"),
                TagType = repository.FindTagTypeByName("TERTIARY"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "Remote",
                Category = repository.FindCategoryByName("WEB CONFERENCING"),
                TagType = repository.FindTagTypeByName("TERTIARY"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);

            t = new Tag()
            {
                TagName = "Software",
                Category = repository.FindCategoryByName("WEB CONFERENCING"),
                TagType = repository.FindTagTypeByName("TERTIARY"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            #endregion

            #region PHONE TERTIARY
            t = new Tag()
            {
                TagName = "Professional",
                Category = repository.FindCategoryByName("COMMUNICATIONS"),
                TagType = repository.FindTagTypeByName("TERTIARY"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);

            t = new Tag()
            {
                TagName = "Features",
                Category = repository.FindCategoryByName("COMMUNICATIONS"),
                TagType = repository.FindTagTypeByName("TERTIARY"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "Mobile",
                Category = repository.FindCategoryByName("COMMUNICATIONS"),
                TagType = repository.FindTagTypeByName("TERTIARY"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);

            t = new Tag()
            {
                TagName = "Handset",
                Category = repository.FindCategoryByName("COMMUNICATIONS"),
                TagType = repository.FindTagTypeByName("TERTIARY"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "Software",
                Category = repository.FindCategoryByName("COMMUNICATIONS"),
                TagType = repository.FindTagTypeByName("TERTIARY"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            #endregion

            #region STORAGE AND BACKUP TERTIARY
            t = new Tag()
            {
                TagName = "Network",
                Category = repository.FindCategoryByName("STORAGE AND BACKUP"),
                TagType = repository.FindTagTypeByName("TERTIARY"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);

            t = new Tag()
            {
                TagName = "Upload",
                Category = repository.FindCategoryByName("STORAGE AND BACKUP"),
                TagType = repository.FindTagTypeByName("TERTIARY"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "Lock",
                Category = repository.FindCategoryByName("STORAGE AND BACKUP"),
                TagType = repository.FindTagTypeByName("TERTIARY"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);

            t = new Tag()
            {
                TagName = "Share",
                Category = repository.FindCategoryByName("STORAGE AND BACKUP"),
                TagType = repository.FindTagTypeByName("TERTIARY"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "Safe",
                Category = repository.FindCategoryByName("STORAGE AND BACKUP"),
                TagType = repository.FindTagTypeByName("TERTIARY"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            #endregion

            #region SECURITY TERTIARY
            t = new Tag()
            {
                TagName = "Hackers",
                Category = repository.FindCategoryByName("SECURITY"),
                TagType = repository.FindTagTypeByName("TERTIARY"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);

            t = new Tag()
            {
                TagName = "Software",
                Category = repository.FindCategoryByName("SECURITY"),
                TagType = repository.FindTagTypeByName("TERTIARY"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "Cloud",
                Category = repository.FindCategoryByName("SECURITY"),
                TagType = repository.FindTagTypeByName("TERTIARY"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);

            t = new Tag()
            {
                TagName = "Spyware",
                Category = repository.FindCategoryByName("SECURITY"),
                TagType = repository.FindTagTypeByName("TERTIARY"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "Scanning",
                Category = repository.FindCategoryByName("SECURITY"),
                TagType = repository.FindTagTypeByName("TERTIARY"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            #endregion

            #region OFFICE TERTIARY
            t = new Tag()
            {
                TagName = "Computer",
                Category = repository.FindCategoryByName("OFFICE"),
                TagType = repository.FindTagTypeByName("TERTIARY"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);

            t = new Tag()
            {
                TagName = "Productivity",
                Category = repository.FindCategoryByName("OFFICE"),
                TagType = repository.FindTagTypeByName("TERTIARY"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "Sharing",
                Category = repository.FindCategoryByName("OFFICE"),
                TagType = repository.FindTagTypeByName("TERTIARY"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);

            t = new Tag()
            {
                TagName = "Create",
                Category = repository.FindCategoryByName("OFFICE"),
                TagType = repository.FindTagTypeByName("TERTIARY"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "Multimedia",
                Category = repository.FindCategoryByName("OFFICE"),
                TagType = repository.FindTagTypeByName("TERTIARY"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            #endregion

            #region CRM TERTIARY
            t = new Tag()
            {
                TagName = "Management",
                Category = repository.FindCategoryByName("CRM"),
                TagType = repository.FindTagTypeByName("TERTIARY"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);

            t = new Tag()
            {
                TagName = "Forecasting",
                Category = repository.FindCategoryByName("CRM"),
                TagType = repository.FindTagTypeByName("TERTIARY"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "Chart",
                Category = repository.FindCategoryByName("CRM"),
                TagType = repository.FindTagTypeByName("TERTIARY"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);

            t = new Tag()
            {
                TagName = "Information",
                Category = repository.FindCategoryByName("CRM"),
                TagType = repository.FindTagTypeByName("TERTIARY"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "Demand",
                Category = repository.FindCategoryByName("CRM"),
                TagType = repository.FindTagTypeByName("TERTIARY"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            #endregion

            #region EMAIL TERTIARY
            t = new Tag()
            {
                TagName = "SMTP",
                Category = repository.FindCategoryByName("EMAIL"),
                TagType = repository.FindTagTypeByName("TERTIARY"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);

            t = new Tag()
            {
                TagName = "POP3",
                Category = repository.FindCategoryByName("EMAIL"),
                TagType = repository.FindTagTypeByName("TERTIARY"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "Windows",
                Category = repository.FindCategoryByName("EMAIL"),
                TagType = repository.FindTagTypeByName("TERTIARY"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);

            t = new Tag()
            {
                TagName = "Merge",
                Category = repository.FindCategoryByName("EMAIL"),
                TagType = repository.FindTagTypeByName("TERTIARY"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            #endregion

            #endregion

            #region PHRASES

            #region WEB CONFERENCING PHRASES
            t = new Tag()
            {
                TagName = "Online Meeting",
                Category = repository.FindCategoryByName("WEB CONFERENCING"),
                TagType = repository.FindTagTypeByName("PHRASE"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);

            t = new Tag()
            {
                TagName = "Free Software",
                Category = repository.FindCategoryByName("WEB CONFERENCING"),
                TagType = repository.FindTagTypeByName("PHRASE"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "Remote Meeting",
                Category = repository.FindCategoryByName("WEB CONFERENCING"),
                TagType = repository.FindTagTypeByName("PHRASE"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);

            #endregion

            #region PHONE PHRASES
            t = new Tag()
            {
                TagName = "Telephone System",
                Category = repository.FindCategoryByName("COMMUNICATIONS"),
                TagType = repository.FindTagTypeByName("PHRASE"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);

            t = new Tag()
            {
                TagName = "Hosted PBX",
                Category = repository.FindCategoryByName("COMMUNICATIONS"),
                TagType = repository.FindTagTypeByName("PHRASE"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "Virtual PBX",
                Category = repository.FindCategoryByName("COMMUNICATIONS"),
                TagType = repository.FindTagTypeByName("PHRASE"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);

            t = new Tag()
            {
                TagName = "Business Phone",
                Category = repository.FindCategoryByName("COMMUNICATIONS"),
                TagType = repository.FindTagTypeByName("PHRASE"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "Phone System",
                Category = repository.FindCategoryByName("COMMUNICATIONS"),
                TagType = repository.FindTagTypeByName("PHRASE"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            #endregion

            #region STORAGE AND BACKUP PHRASES
            t = new Tag()
            {
                TagName = "Hard Drive",
                Category = repository.FindCategoryByName("STORAGE AND BACKUP"),
                TagType = repository.FindTagTypeByName("PHRASE"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);

            t = new Tag()
            {
                TagName = "Hard Disk",
                Category = repository.FindCategoryByName("STORAGE AND BACKUP"),
                TagType = repository.FindTagTypeByName("PHRASE"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "Network Attached",
                Category = repository.FindCategoryByName("STORAGE AND BACKUP"),
                TagType = repository.FindTagTypeByName("PHRASE"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);

            t = new Tag()
            {
                TagName = "Business Continuity",
                Category = repository.FindCategoryByName("STORAGE AND BACKUP"),
                TagType = repository.FindTagTypeByName("PHRASE"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "Disaster Recovery",
                Category = repository.FindCategoryByName("STORAGE AND BACKUP"),
                TagType = repository.FindTagTypeByName("PHRASE"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            #endregion

            #region SECURITY PHRASES
            t = new Tag()
            {
                TagName = "Web Security",
                Category = repository.FindCategoryByName("SECURITY"),
                TagType = repository.FindTagTypeByName("PHRASE"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);

            t = new Tag()
            {
                TagName = "Security Software",
                Category = repository.FindCategoryByName("SECURITY"),
                TagType = repository.FindTagTypeByName("PHRASE"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "Downloads",
                Category = repository.FindCategoryByName("SECURITY"),
                TagType = repository.FindTagTypeByName("PHRASE"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);

            #endregion

            #region OFFICE PHRASES
            t = new Tag()
            {
                TagName = "Business Office",
                Category = repository.FindCategoryByName("OFFICE"),
                TagType = repository.FindTagTypeByName("PHRASE"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);

            t = new Tag()
            {
                TagName = "Office Software",
                Category = repository.FindCategoryByName("OFFICE"),
                TagType = repository.FindTagTypeByName("PHRASE"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "Desktop Software",
                Category = repository.FindCategoryByName("OFFICE"),
                TagType = repository.FindTagTypeByName("PHRASE"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);

            #endregion

            #region CRM PHRASES
            t = new Tag()
            {
                TagName = "Customer Relationship Management",
                Category = repository.FindCategoryByName("CRM"),
                TagType = repository.FindTagTypeByName("PHRASE"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);

            t = new Tag()
            {
                TagName = "Customer Services",
                Category = repository.FindCategoryByName("CRM"),
                TagType = repository.FindTagTypeByName("PHRASE"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "Salesforce Automation",
                Category = repository.FindCategoryByName("CRM"),
                TagType = repository.FindTagTypeByName("PHRASE"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);

            t = new Tag()
            {
                TagName = "Trouble Ticket",
                Category = repository.FindCategoryByName("CRM"),
                TagType = repository.FindTagTypeByName("PHRASE"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "Contact Management",
                Category = repository.FindCategoryByName("CRM"),
                TagType = repository.FindTagTypeByName("PHRASE"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            #endregion

            #region EMAIL PHRASES
            t = new Tag()
            {
                TagName = "Email Service",
                Category = repository.FindCategoryByName("EMAIL"),
                TagType = repository.FindTagTypeByName("PHRASE"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);

            t = new Tag()
            {
                TagName = "Company Email",
                Category = repository.FindCategoryByName("EMAIL"),
                TagType = repository.FindTagTypeByName("PHRASE"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "Business Email",
                Category = repository.FindCategoryByName("EMAIL"),
                TagType = repository.FindTagTypeByName("PHRASE"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);

            #endregion

            #endregion

            #region VERNACULAR

            #region WEB CONFERENCING VERNACULAR
            t = new Tag()
            {
                TagName = "Desktop sharing",
                Category = repository.FindCategoryByName("WEB CONFERENCING"),
                TagType = repository.FindTagTypeByName("VERNACULAR"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);

            t = new Tag()
            {
                TagName = "Video conferencing",
                Category = repository.FindCategoryByName("WEB CONFERENCING"),
                TagType = repository.FindTagTypeByName("VERNACULAR"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "Screen sharing",
                Category = repository.FindCategoryByName("WEB CONFERENCING"),
                TagType = repository.FindTagTypeByName("VERNACULAR"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "Remote support",
                Category = repository.FindCategoryByName("WEB CONFERENCING"),
                TagType = repository.FindTagTypeByName("VERNACULAR"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);

            t = new Tag()
            {
                TagName = "Audio Conferencing",
                Category = repository.FindCategoryByName("WEB CONFERENCING"),
                TagType = repository.FindTagTypeByName("VERNACULAR"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "Web conference",
                Category = repository.FindCategoryByName("WEB CONFERENCING"),
                TagType = repository.FindTagTypeByName("VERNACULAR"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "Free web conferencing",
                Category = repository.FindCategoryByName("WEB CONFERENCING"),
                TagType = repository.FindTagTypeByName("VERNACULAR"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);

            t = new Tag()
            {
                TagName = "Collaborate online",
                Category = repository.FindCategoryByName("WEB CONFERENCING"),
                TagType = repository.FindTagTypeByName("VERNACULAR"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "Online Service Solution",
                Category = repository.FindCategoryByName("WEB CONFERENCING"),
                TagType = repository.FindTagTypeByName("VERNACULAR"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "Web conferencing",
                Category = repository.FindCategoryByName("WEB CONFERENCING"),
                TagType = repository.FindTagTypeByName("VERNACULAR"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);

            t = new Tag()
            {
                TagName = "Online collaboration",
                Category = repository.FindCategoryByName("WEB CONFERENCING"),
                TagType = repository.FindTagTypeByName("VERNACULAR"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "Web meeting",
                Category = repository.FindCategoryByName("WEB CONFERENCING"),
                TagType = repository.FindTagTypeByName("VERNACULAR"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);

            #endregion

            #region PHONE VERNACULAR
            t = new Tag()
            {
                TagName = "Voice services",
                Category = repository.FindCategoryByName("COMMUNICATIONS"),
                TagType = repository.FindTagTypeByName("VERNACULAR"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);

            t = new Tag()
            {
                TagName = "Business phone solutions",
                Category = repository.FindCategoryByName("COMMUNICATIONS"),
                TagType = repository.FindTagTypeByName("VERNACULAR"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "Online Service",
                Category = repository.FindCategoryByName("COMMUNICATIONS"),
                TagType = repository.FindTagTypeByName("VERNACULAR"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);

            t = new Tag()
            {
                TagName = "VoIP Systems",
                Category = repository.FindCategoryByName("COMMUNICATIONS"),
                TagType = repository.FindTagTypeByName("VERNACULAR"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "VoIP call solutions",
                Category = repository.FindCategoryByName("COMMUNICATIONS"),
                TagType = repository.FindTagTypeByName("VERNACULAR"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "VoIP Service",
                Category = repository.FindCategoryByName("COMMUNICATIONS"),
                TagType = repository.FindTagTypeByName("VERNACULAR"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);

            t = new Tag()
            {
                TagName = "PC-to-phone",
                Category = repository.FindCategoryByName("COMMUNICATIONS"),
                TagType = repository.FindTagTypeByName("VERNACULAR"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "Communications Services",
                Category = repository.FindCategoryByName("COMMUNICATIONS"),
                TagType = repository.FindTagTypeByName("VERNACULAR"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);

            t = new Tag()
            {
                TagName = "Hosted phone systems",
                Category = repository.FindCategoryByName("COMMUNICATIONS"),
                TagType = repository.FindTagTypeByName("VERNACULAR"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "Online voicemail",
                Category = repository.FindCategoryByName("COMMUNICATIONS"),
                TagType = repository.FindTagTypeByName("VERNACULAR"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "Phone service",
                Category = repository.FindCategoryByName("COMMUNICATIONS"),
                TagType = repository.FindTagTypeByName("VERNACULAR"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);

            t = new Tag()
            {
                TagName = "Business communications",
                Category = repository.FindCategoryByName("COMMUNICATIONS"),
                TagType = repository.FindTagTypeByName("VERNACULAR"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "Digital",
                Category = repository.FindCategoryByName("COMMUNICATIONS"),
                TagType = repository.FindTagTypeByName("VERNACULAR"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);

            t = new Tag()
            {
                TagName = "Internet phone",
                Category = repository.FindCategoryByName("COMMUNICATIONS"),
                TagType = repository.FindTagTypeByName("VERNACULAR"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "Online phone service",
                Category = repository.FindCategoryByName("COMMUNICATIONS"),
                TagType = repository.FindTagTypeByName("VERNACULAR"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "VoIP Internet phone",
                Category = repository.FindCategoryByName("COMMUNICATIONS"),
                TagType = repository.FindTagTypeByName("VERNACULAR"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);

            t = new Tag()
            {
                TagName = "VoIP Providers",
                Category = repository.FindCategoryByName("COMMUNICATIONS"),
                TagType = repository.FindTagTypeByName("VERNACULAR"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "Wireless communications services",
                Category = repository.FindCategoryByName("COMMUNICATIONS"),
                TagType = repository.FindTagTypeByName("VERNACULAR"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);

            t = new Tag()
            {
                TagName = "Business VoIP",
                Category = repository.FindCategoryByName("COMMUNICATIONS"),
                TagType = repository.FindTagTypeByName("VERNACULAR"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "VoIP telephone solutions",
                Category = repository.FindCategoryByName("COMMUNICATIONS"),
                TagType = repository.FindTagTypeByName("VERNACULAR"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "Business Class Hosted VoIP",
                Category = repository.FindCategoryByName("COMMUNICATIONS"),
                TagType = repository.FindTagTypeByName("VERNACULAR"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "Customised VoIP Solutions",
                Category = repository.FindCategoryByName("COMMUNICATIONS"),
                TagType = repository.FindTagTypeByName("VERNACULAR"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            #endregion

            #region STORAGE AND BACKUP VERNACULAR
            t = new Tag()
            {
                TagName = "Online storage",
                Category = repository.FindCategoryByName("STORAGE AND BACKUP"),
                TagType = repository.FindTagTypeByName("VERNACULAR"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);

            t = new Tag()
            {
                TagName = "Online backup",
                Category = repository.FindCategoryByName("STORAGE AND BACKUP"),
                TagType = repository.FindTagTypeByName("VERNACULAR"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "Cloud backup",
                Category = repository.FindCategoryByName("STORAGE AND BACKUP"),
                TagType = repository.FindTagTypeByName("VERNACULAR"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);

            t = new Tag()
            {
                TagName = "PC backup",
                Category = repository.FindCategoryByName("STORAGE AND BACKUP"),
                TagType = repository.FindTagTypeByName("VERNACULAR"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "Store files online",
                Category = repository.FindCategoryByName("STORAGE AND BACKUP"),
                TagType = repository.FindTagTypeByName("VERNACULAR"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "Online storage services",
                Category = repository.FindCategoryByName("STORAGE AND BACKUP"),
                TagType = repository.FindTagTypeByName("VERNACULAR"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);

            t = new Tag()
            {
                TagName = "Online cloud storage",
                Category = repository.FindCategoryByName("STORAGE AND BACKUP"),
                TagType = repository.FindTagTypeByName("VERNACULAR"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "Backup solutions",
                Category = repository.FindCategoryByName("STORAGE AND BACKUP"),
                TagType = repository.FindTagTypeByName("VERNACULAR"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);

            t = new Tag()
            {
                TagName = "Manage",
                Category = repository.FindCategoryByName("STORAGE AND BACKUP"),
                TagType = repository.FindTagTypeByName("VERNACULAR"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "Edit",
                Category = repository.FindCategoryByName("STORAGE AND BACKUP"),
                TagType = repository.FindTagTypeByName("VERNACULAR"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "Cloud storage",
                Category = repository.FindCategoryByName("STORAGE AND BACKUP"),
                TagType = repository.FindTagTypeByName("VERNACULAR"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);

            t = new Tag()
            {
                TagName = "Unlimited online backup",
                Category = repository.FindCategoryByName("STORAGE AND BACKUP"),
                TagType = repository.FindTagTypeByName("VERNACULAR"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "Online file storage",
                Category = repository.FindCategoryByName("STORAGE AND BACKUP"),
                TagType = repository.FindTagTypeByName("VERNACULAR"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);

            t = new Tag()
            {
                TagName = "Off-site managed storage",
                Category = repository.FindCategoryByName("STORAGE AND BACKUP"),
                TagType = repository.FindTagTypeByName("VERNACULAR"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "Online backup providers",
                Category = repository.FindCategoryByName("STORAGE AND BACKUP"),
                TagType = repository.FindTagTypeByName("VERNACULAR"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "Cloud file backup",
                Category = repository.FindCategoryByName("STORAGE AND BACKUP"),
                TagType = repository.FindTagTypeByName("VERNACULAR"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);

            t = new Tag()
            {
                TagName = "Server backup",
                Category = repository.FindCategoryByName("STORAGE AND BACKUP"),
                TagType = repository.FindTagTypeByName("VERNACULAR"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "Disaster recovery",
                Category = repository.FindCategoryByName("STORAGE AND BACKUP"),
                TagType = repository.FindTagTypeByName("VERNACULAR"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);

            t = new Tag()
            {
                TagName = "Remote backup",
                Category = repository.FindCategoryByName("STORAGE AND BACKUP"),
                TagType = repository.FindTagTypeByName("VERNACULAR"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "Data backup",
                Category = repository.FindCategoryByName("STORAGE AND BACKUP"),
                TagType = repository.FindTagTypeByName("VERNACULAR"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "Computer backup",
                Category = repository.FindCategoryByName("STORAGE AND BACKUP"),
                TagType = repository.FindTagTypeByName("VERNACULAR"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);

            t = new Tag()
            {
                TagName = "Backup software",
                Category = repository.FindCategoryByName("STORAGE AND BACKUP"),
                TagType = repository.FindTagTypeByName("VERNACULAR"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "Internet backup",
                Category = repository.FindCategoryByName("STORAGE AND BACKUP"),
                TagType = repository.FindTagTypeByName("VERNACULAR"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);

            t = new Tag()
            {
                TagName = "Online IT Backup",
                Category = repository.FindCategoryByName("STORAGE AND BACKUP"),
                TagType = repository.FindTagTypeByName("VERNACULAR"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "Business Data backup",
                Category = repository.FindCategoryByName("STORAGE AND BACKUP"),
                TagType = repository.FindTagTypeByName("VERNACULAR"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "Integrated file sharing",
                Category = repository.FindCategoryByName("STORAGE AND BACKUP"),
                TagType = repository.FindTagTypeByName("VERNACULAR"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);

            t = new Tag()
            {
                TagName = "Cloud backup servers",
                Category = repository.FindCategoryByName("STORAGE AND BACKUP"),
                TagType = repository.FindTagTypeByName("VERNACULAR"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "Secure",
                Category = repository.FindCategoryByName("STORAGE AND BACKUP"),
                TagType = repository.FindTagTypeByName("VERNACULAR"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            #endregion

            #region SECURITY VERNACULAR
            t = new Tag()
            {
                TagName = "Online protection",
                Category = repository.FindCategoryByName("SECURITY"),
                TagType = repository.FindTagTypeByName("VERNACULAR"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);

            t = new Tag()
            {
                TagName = "Internet security",
                Category = repository.FindCategoryByName("SECURITY"),
                TagType = repository.FindTagTypeByName("VERNACULAR"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "Browser security",
                Category = repository.FindCategoryByName("SECURITY"),
                TagType = repository.FindTagTypeByName("VERNACULAR"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "Network security",
                Category = repository.FindCategoryByName("SECURITY"),
                TagType = repository.FindTagTypeByName("VERNACULAR"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);

            t = new Tag()
            {
                TagName = "Online security ",
                Category = repository.FindCategoryByName("SECURITY"),
                TagType = repository.FindTagTypeByName("VERNACULAR"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "Virus protection",
                Category = repository.FindCategoryByName("SECURITY"),
                TagType = repository.FindTagTypeByName("VERNACULAR"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "Anti-virus",
                Category = repository.FindCategoryByName("SECURITY"),
                TagType = repository.FindTagTypeByName("VERNACULAR"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);

            t = new Tag()
            {
                TagName = "Anti-spyware",
                Category = repository.FindCategoryByName("SECURITY"),
                TagType = repository.FindTagTypeByName("VERNACULAR"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "Security solutions",
                Category = repository.FindCategoryByName("SECURITY"),
                TagType = repository.FindTagTypeByName("VERNACULAR"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "digital privacy",
                Category = repository.FindCategoryByName("SECURITY"),
                TagType = repository.FindTagTypeByName("VERNACULAR"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);

            t = new Tag()
            {
                TagName = "Internet safety",
                Category = repository.FindCategoryByName("SECURITY"),
                TagType = repository.FindTagTypeByName("VERNACULAR"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "Security software",
                Category = repository.FindCategoryByName("SECURITY"),
                TagType = repository.FindTagTypeByName("VERNACULAR"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "Data security",
                Category = repository.FindCategoryByName("SECURITY"),
                TagType = repository.FindTagTypeByName("VERNACULAR"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);

            t = new Tag()
            {
                TagName = "Disaster recovery",
                Category = repository.FindCategoryByName("SECURITY"),
                TagType = repository.FindTagTypeByName("VERNACULAR"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "Complete protection",
                Category = repository.FindCategoryByName("SECURITY"),
                TagType = repository.FindTagTypeByName("VERNACULAR"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);

            #endregion

            #region OFFICE VERNACULAR
            t = new Tag()
            {
                TagName = "Office cloud solutions",
                Category = repository.FindCategoryByName("OFFICE"),
                TagType = repository.FindTagTypeByName("VERNACULAR"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);

            t = new Tag()
            {
                TagName = "Office suite",
                Category = repository.FindCategoryByName("OFFICE"),
                TagType = repository.FindTagTypeByName("VERNACULAR"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "Office software packages",
                Category = repository.FindCategoryByName("OFFICE"),
                TagType = repository.FindTagTypeByName("VERNACULAR"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "Productivity suite",
                Category = repository.FindCategoryByName("OFFICE"),
                TagType = repository.FindTagTypeByName("VERNACULAR"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);

            t = new Tag()
            {
                TagName = "Office web apps",
                Category = repository.FindCategoryByName("OFFICE"),
                TagType = repository.FindTagTypeByName("VERNACULAR"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "Online office",
                Category = repository.FindCategoryByName("OFFICE"),
                TagType = repository.FindTagTypeByName("VERNACULAR"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "Collaborate",
                Category = repository.FindCategoryByName("OFFICE"),
                TagType = repository.FindTagTypeByName("VERNACULAR"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);

            t = new Tag()
            {
                TagName = "Mobile office",
                Category = repository.FindCategoryByName("OFFICE"),
                TagType = repository.FindTagTypeByName("VERNACULAR"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "Office applications",
                Category = repository.FindCategoryByName("OFFICE"),
                TagType = repository.FindTagTypeByName("VERNACULAR"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);

            #endregion

            #region CRM VERNACULAR
            t = new Tag()
            {
                TagName = "Online client management",
                Category = repository.FindCategoryByName("CRM"),
                TagType = repository.FindTagTypeByName("VERNACULAR"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);

            t = new Tag()
            {
                TagName = "manage",
                Category = repository.FindCategoryByName("CRM"),
                TagType = repository.FindTagTypeByName("VERNACULAR"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "Web CRM Systems",
                Category = repository.FindCategoryByName("CRM"),
                TagType = repository.FindTagTypeByName("VERNACULAR"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);

            t = new Tag()
            {
                TagName = "Online CRM",
                Category = repository.FindCategoryByName("CRM"),
                TagType = repository.FindTagTypeByName("VERNACULAR"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "Hosted CRM",
                Category = repository.FindCategoryByName("CRM"),
                TagType = repository.FindTagTypeByName("VERNACULAR"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "Service management",
                Category = repository.FindCategoryByName("CRM"),
                TagType = repository.FindTagTypeByName("VERNACULAR"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);

            t = new Tag()
            {
                TagName = "On-Demand CRM solutions",
                Category = repository.FindCategoryByName("CRM"),
                TagType = repository.FindTagTypeByName("VERNACULAR"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "CRM solutions",
                Category = repository.FindCategoryByName("CRM"),
                TagType = repository.FindTagTypeByName("VERNACULAR"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);

            t = new Tag()
            {
                TagName = "Customer Intelligence",
                Category = repository.FindCategoryByName("CRM"),
                TagType = repository.FindTagTypeByName("VERNACULAR"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "Feedback Solutions",
                Category = repository.FindCategoryByName("CRM"),
                TagType = repository.FindTagTypeByName("VERNACULAR"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "Cloud based",
                Category = repository.FindCategoryByName("CRM"),
                TagType = repository.FindTagTypeByName("VERNACULAR"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);

            t = new Tag()
            {
                TagName = "CRM online cloud",
                Category = repository.FindCategoryByName("CRM"),
                TagType = repository.FindTagTypeByName("VERNACULAR"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "Web based CRM software",
                Category = repository.FindCategoryByName("CRM"),
                TagType = repository.FindTagTypeByName("VERNACULAR"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);

            #endregion

            #region EMAIL VERNACULAR
            t = new Tag()
            {
                TagName = "Email account",
                Category = repository.FindCategoryByName("EMAIL"),
                TagType = repository.FindTagTypeByName("VERNACULAR"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);

            t = new Tag()
            {
                TagName = "Secure access",
                Category = repository.FindCategoryByName("EMAIL"),
                TagType = repository.FindTagTypeByName("VERNACULAR"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "Business email",
                Category = repository.FindCategoryByName("EMAIL"),
                TagType = repository.FindTagTypeByName("VERNACULAR"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "Inbox",
                Category = repository.FindCategoryByName("EMAIL"),
                TagType = repository.FindTagTypeByName("VERNACULAR"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);

            t = new Tag()
            {
                TagName = "Unlimited storage",
                Category = repository.FindCategoryByName("EMAIL"),
                TagType = repository.FindTagTypeByName("VERNACULAR"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "Sign in",
                Category = repository.FindCategoryByName("EMAIL"),
                TagType = repository.FindTagTypeByName("VERNACULAR"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "Web based",
                Category = repository.FindCategoryByName("EMAIL"),
                TagType = repository.FindTagTypeByName("VERNACULAR"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);

            t = new Tag()
            {
                TagName = "Webmail ",
                Category = repository.FindCategoryByName("EMAIL"),
                TagType = repository.FindTagTypeByName("VERNACULAR"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "mobile device support",
                Category = repository.FindCategoryByName("EMAIL"),
                TagType = repository.FindTagTypeByName("VERNACULAR"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "Secure storage",
                Category = repository.FindCategoryByName("EMAIL"),
                TagType = repository.FindTagTypeByName("VERNACULAR"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);

            t = new Tag()
            {
                TagName = "Spam protection",
                Category = repository.FindCategoryByName("EMAIL"),
                TagType = repository.FindTagTypeByName("VERNACULAR"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "Email management",
                Category = repository.FindCategoryByName("EMAIL"),
                TagType = repository.FindTagTypeByName("VERNACULAR"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);

            #endregion

            #region FINANCE VERNACULAR
            t = new Tag()
            {
                TagName = "accounting",
                Category = repository.FindCategoryByName("FINANCIAL"),
                TagType = repository.FindTagTypeByName("VERNACULAR"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);

            t = new Tag()
            {
                TagName = "finance",
                Category = repository.FindCategoryByName("FINANCIAL"),
                TagType = repository.FindTagTypeByName("VERNACULAR"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "bills",
                Category = repository.FindCategoryByName("FINANCIAL"),
                TagType = repository.FindTagTypeByName("VERNACULAR"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "budget",
                Category = repository.FindCategoryByName("FINANCIAL"),
                TagType = repository.FindTagTypeByName("VERNACULAR"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);

            t = new Tag()
            {
                TagName = "financial advisors",
                Category = repository.FindCategoryByName("FINANCIAL"),
                TagType = repository.FindTagTypeByName("VERNACULAR"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "online accounting",
                Category = repository.FindCategoryByName("FINANCIAL"),
                TagType = repository.FindTagTypeByName("VERNACULAR"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "finance solution",
                Category = repository.FindCategoryByName("FINANCIAL"),
                TagType = repository.FindTagTypeByName("VERNACULAR"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);

            t = new Tag()
            {
                TagName = "IT finance",
                Category = repository.FindCategoryByName("FINANCIAL"),
                TagType = repository.FindTagTypeByName("VERNACULAR"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "financial news",
                Category = repository.FindCategoryByName("FINANCIAL"),
                TagType = repository.FindTagTypeByName("VERNACULAR"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "currency",
                Category = repository.FindCategoryByName("FINANCIAL"),
                TagType = repository.FindTagTypeByName("VERNACULAR"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);

            t = new Tag()
            {
                TagName = "assets",
                Category = repository.FindCategoryByName("FINANCIAL"),
                TagType = repository.FindTagTypeByName("VERNACULAR"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "payroll",
                Category = repository.FindCategoryByName("FINANCIAL"),
                TagType = repository.FindTagTypeByName("VERNACULAR"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "Cloud finance",
                Category = repository.FindCategoryByName("FINANCIAL"),
                TagType = repository.FindTagTypeByName("VERNACULAR"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "cashflow",
                Category = repository.FindCategoryByName("FINANCIAL"),
                TagType = repository.FindTagTypeByName("VERNACULAR"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "Credit",
                Category = repository.FindCategoryByName("FINANCIAL"),
                TagType = repository.FindTagTypeByName("VERNACULAR"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "accountant edition",
                Category = repository.FindCategoryByName("FINANCIAL"),
                TagType = repository.FindTagTypeByName("VERNACULAR"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "accountant software",
                Category = repository.FindCategoryByName("FINANCIAL"),
                TagType = repository.FindTagTypeByName("VERNACULAR"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "cloud financing",
                Category = repository.FindCategoryByName("FINANCIAL"),
                TagType = repository.FindTagTypeByName("VERNACULAR"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "SME accounting software",
                Category = repository.FindCategoryByName("FINANCIAL"),
                TagType = repository.FindTagTypeByName("VERNACULAR"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "financial management",
                Category = repository.FindCategoryByName("FINANCIAL"),
                TagType = repository.FindTagTypeByName("VERNACULAR"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "SaaS",
                Category = repository.FindCategoryByName("FINANCIAL"),
                TagType = repository.FindTagTypeByName("VERNACULAR"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "planning",
                Category = repository.FindCategoryByName("FINANCIAL"),
                TagType = repository.FindTagTypeByName("VERNACULAR"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "billing",
                Category = repository.FindCategoryByName("FINANCIAL"),
                TagType = repository.FindTagTypeByName("VERNACULAR"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "business accounting software",
                Category = repository.FindCategoryByName("FINANCIAL"),
                TagType = repository.FindTagTypeByName("VERNACULAR"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "cloud accounting",
                Category = repository.FindCategoryByName("FINANCIAL"),
                TagType = repository.FindTagTypeByName("VERNACULAR"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "finance cloud software",
                Category = repository.FindCategoryByName("FINANCIAL"),
                TagType = repository.FindTagTypeByName("VERNACULAR"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "financial reporting",
                Category = repository.FindCategoryByName("FINANCIAL"),
                TagType = repository.FindTagTypeByName("VERNACULAR"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "transactions",
                Category = repository.FindCategoryByName("FINANCIAL"),
                TagType = repository.FindTagTypeByName("VERNACULAR"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "small business accounts software",
                Category = repository.FindCategoryByName("FINANCIAL"),
                TagType = repository.FindTagTypeByName("VERNACULAR"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "bookkeeping",
                Category = repository.FindCategoryByName("FINANCIAL"),
                TagType = repository.FindTagTypeByName("VERNACULAR"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "financial services",
                Category = repository.FindCategoryByName("FINANCIAL"),
                TagType = repository.FindTagTypeByName("VERNACULAR"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "finance program",
                Category = repository.FindCategoryByName("FINANCIAL"),
                TagType = repository.FindTagTypeByName("VERNACULAR"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "web-based accounting",
                Category = repository.FindCategoryByName("FINANCIAL"),
                TagType = repository.FindTagTypeByName("VERNACULAR"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "tax",
                Category = repository.FindCategoryByName("FINANCIAL"),
                TagType = repository.FindTagTypeByName("VERNACULAR"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "invoicing",
                Category = repository.FindCategoryByName("FINANCIAL"),
                TagType = repository.FindTagTypeByName("VERNACULAR"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "invoice",
                Category = repository.FindCategoryByName("FINANCIAL"),
                TagType = repository.FindTagTypeByName("VERNACULAR"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "invoices",
                Category = repository.FindCategoryByName("FINANCIAL"),
                TagType = repository.FindTagTypeByName("VERNACULAR"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "reports",
                Category = repository.FindCategoryByName("FINANCIAL"),
                TagType = repository.FindTagTypeByName("VERNACULAR"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "supplier records",
                Category = repository.FindCategoryByName("FINANCIAL"),
                TagType = repository.FindTagTypeByName("VERNACULAR"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "payments",
                Category = repository.FindCategoryByName("FINANCIAL"),
                TagType = repository.FindTagTypeByName("VERNACULAR"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "VAT reporting",
                Category = repository.FindCategoryByName("FINANCIAL"),
                TagType = repository.FindTagTypeByName("VERNACULAR"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            t = new Tag()
            {
                TagName = "Purchase orders",
                Category = repository.FindCategoryByName("FINANCIAL"),
                TagType = repository.FindTagTypeByName("VERNACULAR"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);

            #endregion

            #endregion

            #region URLS


            #region WEB CONFERENCING
            t = new Tag()
            {
                TagName = "web-conferencing",
                Category = repository.FindCategoryByName("WEB CONFERENCING"),
                TagType = repository.FindTagTypeByName("CATEGORY URL"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            #endregion

            #region EMAIL
            t = new Tag()
            {
                TagName = "email",
                Category = repository.FindCategoryByName("EMAIL"),
                TagType = repository.FindTagTypeByName("CATEGORY URL"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);

            t = new Tag()
            {
                TagName = "business-email",
                Category = repository.FindCategoryByName("EMAIL"),
                TagType = repository.FindTagTypeByName("CATEGORY URL"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            #endregion

            #region STORAGE AND BACKUP
            t = new Tag()
            {
                TagName = "storage",
                Category = repository.FindCategoryByName("STORAGE AND BACKUP"),
                TagType = repository.FindTagTypeByName("CATEGORY URL"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);

            t = new Tag()
            {
                TagName = "online-storage",
                Category = repository.FindCategoryByName("STORAGE AND BACKUP"),
                TagType = repository.FindTagTypeByName("CATEGORY URL"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            #endregion

            #region PHONE
            t = new Tag()
            {
                TagName = "communications",
                Category = repository.FindCategoryByName("COMMUNICATIONS"),
                TagType = repository.FindTagTypeByName("CATEGORY URL"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            #endregion

            #region OFFICE
            t = new Tag()
            {
                TagName = "office",
                Category = repository.FindCategoryByName("OFFICE"),
                TagType = repository.FindTagTypeByName("CATEGORY URL"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);

            t = new Tag()
            {
                TagName = "office-software",
                Category = repository.FindCategoryByName("OFFICE"),
                TagType = repository.FindTagTypeByName("CATEGORY URL"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            #endregion

            #region FINANCIAL
            t = new Tag()
            {
                TagName = "financial",
                Category = repository.FindCategoryByName("FINANCIAL"),
                TagType = repository.FindTagTypeByName("CATEGORY URL"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);

            t = new Tag()
            {
                TagName = "financial-software",
                Category = repository.FindCategoryByName("FINANCIAL"),
                TagType = repository.FindTagTypeByName("CATEGORY URL"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);

            t = new Tag()
            {
                TagName = "finance-accounts-payroll-software",
                Category = repository.FindCategoryByName("FINANCIAL"),
                TagType = repository.FindTagTypeByName("CATEGORY URL"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            #endregion

            #region CRM
            t = new Tag()
            {
                TagName = "crm",
                Category = repository.FindCategoryByName("CRM"),
                TagType = repository.FindTagTypeByName("CATEGORY URL"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);

            t = new Tag()
            {
                TagName = "crm-software",
                Category = repository.FindCategoryByName("CRM"),
                TagType = repository.FindTagTypeByName("CATEGORY URL"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            #endregion

            #region PROJECT MANAGEMENT
            t = new Tag()
            {
                TagName = "project",
                Category = repository.FindCategoryByName("PROJECT MANAGEMENT"),
                TagType = repository.FindTagTypeByName("CATEGORY URL"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);

            t = new Tag()
            {
                TagName = "project-management",
                Category = repository.FindCategoryByName("PROJECT MANAGEMENT"),
                TagType = repository.FindTagTypeByName("CATEGORY URL"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);

            t = new Tag()
            {
                TagName = "project-management-software",
                Category = repository.FindCategoryByName("PROJECT MANAGEMENT"),
                TagType = repository.FindTagTypeByName("CATEGORY URL"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            #endregion

            #region SECURITY
            t = new Tag()
            {
                TagName = "security",
                Category = repository.FindCategoryByName("SECURITY"),
                TagType = repository.FindTagTypeByName("CATEGORY URL"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);

            t = new Tag()
            {
                TagName = "internet-security",
                Category = repository.FindCategoryByName("SECURITY"),
                TagType = repository.FindTagTypeByName("CATEGORY URL"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);

            t = new Tag()
            {
                TagName = "anti-virus-internet-security",
                Category = repository.FindCategoryByName("SECURITY"),
                TagType = repository.FindTagTypeByName("CATEGORY URL"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            #endregion

            #region MARKETING
            t = new Tag()
            {
                TagName = "marketing",
                Category = repository.FindCategoryByName("MARKETING"),
                TagType = repository.FindTagTypeByName("CATEGORY URL"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            #endregion

            #region WEBSITE
            t = new Tag()
            {
                TagName = "website",
                Category = repository.FindCategoryByName("WEBSITE"),
                TagType = repository.FindTagTypeByName("CATEGORY URL"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            #endregion

            #region CREATIVE
            t = new Tag()
            {
                TagName = "creative",
                Category = repository.FindCategoryByName("CREATIVE"),
                TagType = repository.FindTagTypeByName("CATEGORY URL"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            #endregion

            #region INTELLIGENCE & REPORTING
            t = new Tag()
            {
                TagName = "business-intelligence-reporting",
                Category = repository.FindCategoryByName("BUSINESS INTELLIGENCE REPORTING"),
                TagType = repository.FindTagTypeByName("CATEGORY URL"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            #endregion

            #region HOSTING
            t = new Tag()
            {
                TagName = "hosting",
                Category = repository.FindCategoryByName("HOSTING"),
                TagType = repository.FindTagTypeByName("CATEGORY URL"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            #endregion

            #region HR
            t = new Tag()
            {
                TagName = "hr",
                Category = repository.FindCategoryByName("HR"),
                TagType = repository.FindTagTypeByName("CATEGORY URL"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            #endregion

            #region PAYMENTS
            t = new Tag()
            {
                TagName = "payments",
                Category = repository.FindCategoryByName("PAYMENTS"),
                TagType = repository.FindTagTypeByName("CATEGORY URL"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            #endregion

            #region BUSINESS & OPERATIONS
            t = new Tag()
            {
                TagName = "business-and-operations",
                Category = repository.FindCategoryByName("BUSINESS & OPERATIONS"),
                TagType = repository.FindTagTypeByName("CATEGORY URL"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            #endregion

            #region SALES
            t = new Tag()
            {
                TagName = "sales",
                Category = repository.FindCategoryByName("SALES"),
                TagType = repository.FindTagTypeByName("CATEGORY URL"),
                TagStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTag(t);
            #endregion

            #endregion

            #endregion
            return retVal;
        }

        public static bool PumpURLTagTypeData(QueryRepository repository)
        {

            bool retVal = true;
            TagType tt;
            tt = new TagType()
            {
                TagTypeName = "CATEGORY URL",
                TagTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTagType(tt);
            tt = new TagType()
            {
                TagTypeName = "SHOP URL",
                TagTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTagType(tt);
            return retVal;
        }

        public static bool PumpCategoryURLs(QueryRepository repository)
        {
            bool retVal = true;
            Tag t;

            var cloudApplications = repository.GetApplicationServiceNames()
                //.Take(1)
                ;

            foreach (CloudApplication ca in cloudApplications)
            {
                //var categoryTag = repository.FindCategoryTag(ca.Category.CategoryID == 1 ? 6 : ca.Category.CategoryID);
                var categoryTag = repository.FindCategoryTag(ca.Category.CategoryID);
                ca.CloudApplicationCategoryTag = categoryTag;
                repository.Update<CloudApplication>("1", ca);
            }
            return retVal;
        }

        public static bool PumpShopURLs(QueryRepository repository)
        {
            bool retVal = true;
            Tag t;

            var cloudApplications = repository.GetApplicationServiceNames()
                //.Take(1)
                ;

            foreach (CloudApplication ca in cloudApplications)
            {
                var category = repository.FindCategoryByID(ca.Category.CategoryID);
                var tagType = repository.FindTagTypeByName("SHOP URL");
                var tagStatus = repository.FindStatusByName("LIVE");

                t = new Tag()
                {
                    //TagName = ca.Vendor.VendorName.Trim().ToLower() + "-" + ca.ServiceName.ToLower().Replace(" ","-"),
                    TagName = (ca.Vendor.VendorName.Trim().ToLower().Replace(" ", "-").Replace(":", "-").Replace("&", "-and-").Replace("+", "-plus-").Replace(".", "-dot-") + "-" + ca.ServiceName.ToLower().Replace(" ", "-")).Replace("--", "-"),
                    Category = category,
                    TagType = tagType,
                    TagStatus = tagStatus,
                };
                repository.Insert<Tag>(t,true);

                ca.CloudApplicationShopTag = t;
                repository.Update<CloudApplication>("1", ca);
            }
            return retVal;
        }

        public static bool PumpHeadingTagTypeData(QueryRepository repository)
        {

            bool retVal = true;
            TagType tt;
            tt = new TagType()
            {
                TagTypeName = "H1",
                TagTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTagType(tt);
            tt = new TagType()
            {
                TagTypeName = "H1 TEXT",
                TagTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTagType(tt);
            tt = new TagType()
            {
                TagTypeName = "H2_1",
                TagTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTagType(tt);
            tt = new TagType()
            {
                TagTypeName = "H2_1 TEXT",
                TagTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTagType(tt);
            tt = new TagType()
            {
                TagTypeName = "H2_2",
                TagTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTagType(tt);
            tt = new TagType()
            {
                TagTypeName = "H2_2 TEXT",
                TagTypeStatus = repository.FindStatusByName("LIVE"),
            };
            repository.AddTagType(tt);
            return retVal;
        }

        public static bool PumpHeadingTags(QueryRepository repository)
        {
            bool retVal = true;
            Tag t;

            #region WEB CONFERENCING
            t = new Tag()
            {
                TagName = "Introduction to online conferencing",
                Category = repository.FindCategoryByName("WEB CONFERENCING"),
                TagStatus = repository.FindStatusByName("LIVE"),
                TagType = repository.FindTagTypeByName("H1"),
            };
            repository.AddTag(t);

            t = new Tag()
            {
                TagName = "",
                Category = repository.FindCategoryByName("WEB CONFERENCING"),
                TagStatus = repository.FindStatusByName("LIVE"),
                TagType = repository.FindTagTypeByName("H1 TEXT"),
            };
            repository.AddTag(t);

            t = new Tag()
            {
                TagName = "",
                Category = repository.FindCategoryByName("WEB CONFERENCING"),
                TagStatus = repository.FindStatusByName("LIVE"),
                TagType = repository.FindTagTypeByName("H2_1"),
            };
            repository.AddTag(t);

            t = new Tag()
            {
                TagName = "",
                Category = repository.FindCategoryByName("WEB CONFERENCING"),
                TagStatus = repository.FindStatusByName("LIVE"),
                TagType = repository.FindTagTypeByName("H2_1 TEXT"),
            };
            repository.AddTag(t);

            t = new Tag()
            {
                TagName = "",
                Category = repository.FindCategoryByName("WEB CONFERENCING"),
                TagStatus = repository.FindStatusByName("LIVE"),
                TagType = repository.FindTagTypeByName("H2_2"),
            };
            repository.AddTag(t);

            t = new Tag()
            {
                TagName = "",
                Category = repository.FindCategoryByName("WEB CONFERENCING"),
                TagStatus = repository.FindStatusByName("LIVE"),
                TagType = repository.FindTagTypeByName("H2_2 TEXT"),
            };
            repository.AddTag(t);
            
            #endregion

            #region EMAIL
            t = new Tag()
            {
                TagName = "",
                Category = repository.FindCategoryByName(""),
                TagStatus = repository.FindStatusByName("LIVE"),
                TagType = repository.FindTagTypeByName("H1"),
            };
            repository.AddTag(t);

            t = new Tag()
            {
                TagName = "",
                Category = repository.FindCategoryByName(""),
                TagStatus = repository.FindStatusByName("LIVE"),
                TagType = repository.FindTagTypeByName("H2_1"),
            };
            repository.AddTag(t);

            t = new Tag()
            {
                TagName = "",
                Category = repository.FindCategoryByName(""),
                TagStatus = repository.FindStatusByName("LIVE"),
                TagType = repository.FindTagTypeByName("H2_2"),
            };
            repository.AddTag(t);
            #endregion

            #region EMAIL
            t = new Tag()
            {
                TagName = "",
                Category = repository.FindCategoryByName(""),
                TagStatus = repository.FindStatusByName("LIVE"),
                TagType = repository.FindTagTypeByName("H1"),
            };
            repository.AddTag(t);

            t = new Tag()
            {
                TagName = "",
                Category = repository.FindCategoryByName(""),
                TagStatus = repository.FindStatusByName("LIVE"),
                TagType = repository.FindTagTypeByName("H2_1"),
            };
            repository.AddTag(t);

            t = new Tag()
            {
                TagName = "",
                Category = repository.FindCategoryByName(""),
                TagStatus = repository.FindStatusByName("LIVE"),
                TagType = repository.FindTagTypeByName("H2_2"),
            };
            repository.AddTag(t);
            #endregion

            #region EMAIL
            t = new Tag()
            {
                TagName = "",
                Category = repository.FindCategoryByName(""),
                TagStatus = repository.FindStatusByName("LIVE"),
                TagType = repository.FindTagTypeByName("H1"),
            };
            repository.AddTag(t);

            t = new Tag()
            {
                TagName = "",
                Category = repository.FindCategoryByName(""),
                TagStatus = repository.FindStatusByName("LIVE"),
                TagType = repository.FindTagTypeByName("H2_1"),
            };
            repository.AddTag(t);

            t = new Tag()
            {
                TagName = "",
                Category = repository.FindCategoryByName(""),
                TagStatus = repository.FindStatusByName("LIVE"),
                TagType = repository.FindTagTypeByName("H2_2"),
            };
            repository.AddTag(t);
            #endregion

            #region EMAIL
            t = new Tag()
            {
                TagName = "",
                Category = repository.FindCategoryByName(""),
                TagStatus = repository.FindStatusByName("LIVE"),
                TagType = repository.FindTagTypeByName("H1"),
            };
            repository.AddTag(t);

            t = new Tag()
            {
                TagName = "",
                Category = repository.FindCategoryByName(""),
                TagStatus = repository.FindStatusByName("LIVE"),
                TagType = repository.FindTagTypeByName("H2_1"),
            };
            repository.AddTag(t);

            t = new Tag()
            {
                TagName = "",
                Category = repository.FindCategoryByName(""),
                TagStatus = repository.FindStatusByName("LIVE"),
                TagType = repository.FindTagTypeByName("H2_2"),
            };
            repository.AddTag(t);
            #endregion

            #region EMAIL
            t = new Tag()
            {
                TagName = "",
                Category = repository.FindCategoryByName(""),
                TagStatus = repository.FindStatusByName("LIVE"),
                TagType = repository.FindTagTypeByName("H1"),
            };
            repository.AddTag(t);

            t = new Tag()
            {
                TagName = "",
                Category = repository.FindCategoryByName(""),
                TagStatus = repository.FindStatusByName("LIVE"),
                TagType = repository.FindTagTypeByName("H2_1"),
            };
            repository.AddTag(t);

            t = new Tag()
            {
                TagName = "",
                Category = repository.FindCategoryByName(""),
                TagStatus = repository.FindStatusByName("LIVE"),
                TagType = repository.FindTagTypeByName("H2_2"),
            };
            repository.AddTag(t);
            #endregion

            #region EMAIL
            t = new Tag()
            {
                TagName = "",
                Category = repository.FindCategoryByName(""),
                TagStatus = repository.FindStatusByName("LIVE"),
                TagType = repository.FindTagTypeByName("H1"),
            };
            repository.AddTag(t);

            t = new Tag()
            {
                TagName = "",
                Category = repository.FindCategoryByName(""),
                TagStatus = repository.FindStatusByName("LIVE"),
                TagType = repository.FindTagTypeByName("H2_1"),
            };
            repository.AddTag(t);

            t = new Tag()
            {
                TagName = "",
                Category = repository.FindCategoryByName(""),
                TagStatus = repository.FindStatusByName("LIVE"),
                TagType = repository.FindTagTypeByName("H2_2"),
            };
            repository.AddTag(t);
            #endregion

            #region EMAIL
            t = new Tag()
            {
                TagName = "",
                Category = repository.FindCategoryByName(""),
                TagStatus = repository.FindStatusByName("LIVE"),
                TagType = repository.FindTagTypeByName("H1"),
            };
            repository.AddTag(t);

            t = new Tag()
            {
                TagName = "",
                Category = repository.FindCategoryByName(""),
                TagStatus = repository.FindStatusByName("LIVE"),
                TagType = repository.FindTagTypeByName("H2_1"),
            };
            repository.AddTag(t);

            t = new Tag()
            {
                TagName = "",
                Category = repository.FindCategoryByName(""),
                TagStatus = repository.FindStatusByName("LIVE"),
                TagType = repository.FindTagTypeByName("H2_2"),
            };
            repository.AddTag(t);
            #endregion

            #region EMAIL
            t = new Tag()
            {
                TagName = "",
                Category = repository.FindCategoryByName(""),
                TagStatus = repository.FindStatusByName("LIVE"),
                TagType = repository.FindTagTypeByName("H1"),
            };
            repository.AddTag(t);

            t = new Tag()
            {
                TagName = "",
                Category = repository.FindCategoryByName(""),
                TagStatus = repository.FindStatusByName("LIVE"),
                TagType = repository.FindTagTypeByName("H2_1"),
            };
            repository.AddTag(t);

            t = new Tag()
            {
                TagName = "",
                Category = repository.FindCategoryByName(""),
                TagStatus = repository.FindStatusByName("LIVE"),
                TagType = repository.FindTagTypeByName("H2_2"),
            };
            repository.AddTag(t);
            #endregion

            #region EMAIL
            t = new Tag()
            {
                TagName = "",
                Category = repository.FindCategoryByName(""),
                TagStatus = repository.FindStatusByName("LIVE"),
                TagType = repository.FindTagTypeByName("H1"),
            };
            repository.AddTag(t);

            t = new Tag()
            {
                TagName = "",
                Category = repository.FindCategoryByName(""),
                TagStatus = repository.FindStatusByName("LIVE"),
                TagType = repository.FindTagTypeByName("H2_1"),
            };
            repository.AddTag(t);

            t = new Tag()
            {
                TagName = "",
                Category = repository.FindCategoryByName(""),
                TagStatus = repository.FindStatusByName("LIVE"),
                TagType = repository.FindTagTypeByName("H2_2"),
            };
            repository.AddTag(t);
            #endregion

            return retVal;
        }

        public static bool PumpCategoryURL(QueryRepository repository, CloudApplication ca)
        {
            bool retVal = true;
            Tag t;

                //var categoryTag = repository.FindCategoryTag(ca.Category.CategoryID == 1 ? 6 : ca.Category.CategoryID);
                var categoryTag = repository.FindCategoryTag(ca.Category.CategoryID);
                ca.CloudApplicationCategoryTag = categoryTag;
                repository.Update<CloudApplication>("1", ca);
            return retVal;
        }

        public static bool PumpShopURL(QueryRepository repository, CloudApplication ca)
        {
            bool retVal = true;
            Tag t;


                var category = repository.FindCategoryByID(ca.Category.CategoryID);
                var tagType = repository.FindTagTypeByName("SHOP URL");
                var tagStatus = repository.FindStatusByName("LIVE");

                t = new Tag()
                {
                    //TagName = ca.Vendor.VendorName.Trim().ToLower() + "-" + ca.ServiceName.ToLower().Replace(" ","-"),
                    TagName = ca.Vendor.VendorName.Trim().ToLower().Replace(" ", "-").Replace(":", "-").Replace("&", "AND") + "-" + ca.ServiceName.ToLower().Replace(" ", "-"),
                    Category = category,
                    TagType = tagType,
                    TagStatus = tagStatus,
                };
                repository.Insert<Tag>(t, true);

                ca.CloudApplicationShopTag = t;
                repository.Update<CloudApplication>("1", ca);
            return retVal;
        }

    }
}
