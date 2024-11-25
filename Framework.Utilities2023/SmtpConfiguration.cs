using Microsoft.Extensions.Configuration;

namespace Framework.Utilities2023
{
    public class SmtpConfiguration
    {
        private readonly IConfiguration _configuration;
        public SmtpConfiguration(IConfiguration configuration)
        {
            this._configuration = configuration;
        }

        public int Port
        {
            get
            {
                return Convert.ToInt32(this._configuration["Smtp:Default:Port"]);
            }
        }

        public bool EnableSsl
        {
            get
            {
                return Convert.ToBoolean(this._configuration["Smtp:Default:EnableSsl"]);
            }
        }

        public string UserName
        {
            get
            {
                string userName = this._configuration["Smtp:Default:UserName"];
                ArgumentException.ThrowIfNullOrWhiteSpace(userName);
                return userName;
            }

        }

        public string Password
        {
            get
            {
                string password = this._configuration["Smtp:Default:Password"];
                ArgumentException.ThrowIfNullOrWhiteSpace(password);
                return password;
            }

        }
    }
}
