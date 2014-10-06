using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Net.Mail;
using Alpinely.TownCrier;
using CompareCloudware.Domain.Models;
using System.Net;
using System.Net.Mail;

namespace CompareCloudware.Web.Helpers
{
    public class SendEMail : ISendEMail
    //public class SendEmail
    {
        //private readonly IDataAccess _dataAccess;

        //public SendEmail(IDataAccess dataAccess)
        //{
        //    _dataAccess = dataAccess;
        //}

        //public void Execute(JobExecutionContext context)
        //public void Execute(Case newCase, User user)
        public bool Execute(Person p, CloudApplicationRequest car, MailRequest mr, Stream attachment, string attachmentName)
        {
            bool retVal = true;
            try
            {
                //string templateResourceName;
                //templateResourceName = @"CompareCloudware.Web.Helpers.Receipt.txt";

                //string subject = "Your requested cloudware application is attached";

                //switch (emailType)
                //{
                //    case EmailType.CarRented:
                //        templateResourceName = @"AvisDenmark.ApplicationServices.EmailTemplates.CarRentalEmail.txt";
                //        subject = "Car has been rented";
                //        break;
                //    case EmailType.CarReturned:
                //        templateResourceName = @"AvisDenmark.ApplicationServices.EmailTemplates.CarReturnedEmail.txt";
                //        subject = "Car has been returned";
                //        break;
                //    default:
                //        throw new InvalidOperationException("Invalid email type");
                //}

                var templateStream = this.GetType().Assembly.GetManifestResourceStream(mr.MailTemplateResourceName);
                var sr = new StreamReader(templateStream);
                var template = sr.ReadToEnd();

                var factory = new MergedEmailFactory(new TemplateParser());

                var tokenValues = mr.MailTemplateResourceTokens;

                MailMessage message = factory
                    .WithTokenValues(tokenValues)
                    .WithSubject(mr.MailSubject)
                    .WithMarkdownBody(template)
                    .Create();

                //message.From = new MailAddress(p.EMail, mr.SMTPClientUserDisplayName);
                message.From = new MailAddress(mr.SMTPClientUserID, mr.SMTPClientUserDisplayName);
                message.To.Add(p.EMail);
                //message.CC.Add("protechdm@btopenworld.com");

                Attachment a = new Attachment(attachment, attachmentName);
                message.Attachments.Add(a);

                var smtpClient = new SmtpClient();
                smtpClient.Host = mr.SMTPClientHost;
                //smtpClient.Credentials = new NetworkCredential(mr.SMTPClientUserID, mr.SMTPClientUserPassword);
                smtpClient.EnableSsl = mr.SMTPEnableSSL;
                smtpClient.Port = mr.SMTPPort;
                //smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;

                smtpClient.Send(message);
            }
            catch (SmtpException e)
            {
                retVal = false;
                throw new SmtpException(e.Message);
            }
            catch (Exception e)
            {
                retVal = false;
                throw new Exception(e.Message);
            }
            return retVal;
        }
    }

    public interface ISendEMail
    {
        bool Execute(Person p, CloudApplicationRequest car, MailRequest mr, Stream attachment, string attachmentName);
    }

    public class MailRequest
    {
        public string MailTemplateResourceName { get; set; }
        public Dictionary<string, string> MailTemplateResourceTokens { get; set; }
        public string MailTo { get; set; }
        public string MailSubject { get; set; }
        public string SMTPClientUserDisplayName { get; set; }
        public string SMTPClientHost { get; set; }
        public string SMTPClientUserID { get; set; }
        public string SMTPClientUserPassword { get; set; }
        public bool SMTPEnableSSL { get; set; }
        public int SMTPPort { get; set; }
    }
}