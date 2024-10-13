using Framework.Utilities2023.Email.IServices;
using System.Net;
using System.Net.Mail;
using Framework.Utilities2023.Repositories;
using Framework.Utilities2023.Entities;
using Framework.Utilities2023.Log.Services;
using Framework.Utilities202.Entities;

namespace Framework.Utilities2023.Email.Services
{
    public class ServiceEmail : IServiceEmail
    {
        private readonly RepositoryTemplatesEmail _repositoryTemplatesEmail;
        private readonly SmtpConfiguration _smtpConfiguration;
        private readonly ServiceLogBook _serviceLogBook;

        public ServiceEmail(RepositoryTemplatesEmail repositoryTemplatesEmail,
            SmtpConfiguration smtpConfiguration, ServiceLogBook serviceLogBook)
        {
            this._repositoryTemplatesEmail = repositoryTemplatesEmail;
            this._smtpConfiguration = smtpConfiguration;
            this._serviceLogBook = serviceLogBook;
        }

        private string GenerateBody(Guid idTemplate, Dictionary<string, string> paramsBody)
        {
            TemplateEmail template = _repositoryTemplatesEmail.GetByid(idTemplate);

            foreach (KeyValuePair<string,string> paraBo in paramsBody)
            {
                template.BodyTemplate = template.BodyTemplate.Replace(paraBo.Key, paraBo.Value);
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

                using (SmtpClient smtpClient = new SmtpClient("smtp.gmail.com"))
                {
                    smtpClient.Port = _smtpConfiguration.Port;
                    smtpClient.EnableSsl = _smtpConfiguration.EnableSsl;
                    NetworkCredential networkCredential = new NetworkCredential();
                    networkCredential.UserName = _smtpConfiguration.UserName;
                    networkCredential.Password = _smtpConfiguration.Password;
                    smtpClient.Credentials = networkCredential;
                    smtpClient.Send(message);
                }
            }catch(Exception ex)
            {
                _serviceLogBook.SaveErrorLog(LogBook.Create(nameof(ServiceEmail), nameof(SendEmail), $"{ex.Message}-{ex.StackTrace}"));
            }
                    
        }
    }
}
