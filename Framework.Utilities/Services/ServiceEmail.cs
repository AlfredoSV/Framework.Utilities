using Framework.Utilities.Email.IServices;
using System.Net;
using System.Net.Mail;
using Framework.Utilities.Repositories;
using Framework.Utilities.Entities;
using Framework.Utilities.IServices;

namespace Framework.Utilities.Email.Services
{
    public class ServiceEmail : IServiceEmail
    {
        private readonly RepositoryTemplatesEmail _repositoryTemplatesEmail;
        private readonly SmtpConfiguration _smtpConfiguration;
        private readonly IServiceLogBook _serviceLogBook;

        public ServiceEmail(RepositoryTemplatesEmail repositoryTemplatesEmail,
            SmtpConfiguration smtpConfiguration, IServiceLogBook serviceLogBook)
        {
            this._repositoryTemplatesEmail = repositoryTemplatesEmail;
            this._smtpConfiguration = smtpConfiguration;
            this._serviceLogBook = serviceLogBook;
        }

        private TemplateEmail GenerateBody(Guid idTemplate, Dictionary<string, string> paramsBody)
        {
            TemplateEmail template = _repositoryTemplatesEmail.GetByid(idTemplate);

            if (template is null)
            {
                throw new NullReferenceException("template is null");
            }

            foreach (KeyValuePair<string,string> paraBo in paramsBody)
            {
                template.Body = template.Body.Replace(paraBo.Key, paraBo.Value);
            }

            return template;
            
        }

        public void SendEmail(string email,string emailTo,
            Guid idTemplate, Dictionary<string,string> paramsBody)
        {
            try
            {
                TemplateEmail template = GenerateBody(idTemplate, paramsBody);
                MailMessage message = new MailMessage();
                message.From = new MailAddress(email);
                message.To.Add(emailTo);
                message.Body =  template.Body;

                using (SmtpClient smtpClient = new SmtpClient("smtp.gmail.com"))
                {
                    smtpClient.Port = _smtpConfiguration.Port;
                    smtpClient.EnableSsl = _smtpConfiguration.EnableSsl;
                    NetworkCredential networkCredential = new NetworkCredential();
                    networkCredential.UserName = _smtpConfiguration.UserName;
                    networkCredential.Password = _smtpConfiguration.Password;
                    smtpClient.DeliveryFormat = SmtpDeliveryFormat.International;
                    smtpClient.Credentials = networkCredential;
                    smtpClient.Send(message);
                }

            }catch(Exception)
            {
                throw;
            }                  
        }
    }
}
