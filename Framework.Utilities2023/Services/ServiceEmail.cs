using Framework.Utilities2023.Email.IServices;
using System.Net;
using System.Net.Mail;
using System;
using System.Collections.Generic;

namespace Framework.Utilities2023.Email.Services
{
    public class ServiceEmail : IServiceEmail
    {
        public string GenerateBody(Guid idTemplate, Dictionary<string, string> paramsBody)
        {
            throw new NotImplementedException();
        }

        public void SendEmail(string email,string emailTo,
            Guid idTemplate, Dictionary<string,string> paramsBody)
        {
            MailMessage message = new MailMessage();
            message.From =  new MailAddress(email);
            message.To.Add(emailTo);
            message.Body = GenerateBody(idTemplate, paramsBody);

            using(SmtpClient smtpClient = new SmtpClient())
            {
                smtpClient.Port = SmtpConfiguration.Instance.Port;
                smtpClient.EnableSsl = SmtpConfiguration.Instance.EnableSsl;
                NetworkCredential networkCredential = new NetworkCredential();
                networkCredential.UserName = SmtpConfiguration.Instance.UserName;
                networkCredential.Password = SmtpConfiguration.Instance.Password;
                smtpClient.Credentials = networkCredential;
                smtpClient.Send(message);
            }
            
        }
    }
}
