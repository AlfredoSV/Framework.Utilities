using Framework.Utilities2023.Email.IServices;
using System.Net;
using System.Net.Mail;
using System;
using System.Collections.Generic;
using Framework.Utilities2023.Repositories;
using Framework.Utilities2023.Entities;

namespace Framework.Utilities2023.Email.Services
{
    public class ServiceEmail : IServiceEmail
    {
        private readonly RepositoryTemplatesEmail _repositoryTemplatesEmail;

        public ServiceEmail()
        {
            _repositoryTemplatesEmail = new RepositoryTemplatesEmail();
        }

        public string GenerateBody(Guid idTemplate, Dictionary<string, string> paramsBody)
        {
            TemplateEmail template = _repositoryTemplatesEmail.GetByid(idTemplate);

            foreach (KeyValuePair<string,string> paraBo in paramsBody)
            {
                template.BodyTemplate.Replace(paraBo.Key, paraBo.Value);
            }

            return template.BodyTemplate;
            
        }

        public void SendEmail(string email,string emailTo,
            Guid idTemplate, Dictionary<string,string> paramsBody)
        {
            try
            {
                MailMessage message = new MailMessage();
                message.From = new MailAddress(email);
                message.To.Add(emailTo);
                message.Body = GenerateBody(idTemplate, paramsBody);

                using (SmtpClient smtpClient = new SmtpClient())
                {
                    smtpClient.Port = SmtpConfiguration.Instance.Port;
                    smtpClient.EnableSsl = SmtpConfiguration.Instance.EnableSsl;
                    NetworkCredential networkCredential = new NetworkCredential();
                    networkCredential.UserName = SmtpConfiguration.Instance.UserName;
                    networkCredential.Password = SmtpConfiguration.Instance.Password;
                    smtpClient.Credentials = networkCredential;
                    smtpClient.Send(message);
                }
            }catch(Exception ex) { }
            
            
        }
    }
}
