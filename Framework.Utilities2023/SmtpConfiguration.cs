namespace Framework.Utilities2023
{
    public class SmtpConfiguration
    {
        private static SmtpConfiguration _instance;

        public static SmtpConfiguration Instance
        {
            get
            {

                if (_instance is null)
                    _instance = new SmtpConfiguration();
                return _instance;

            }
            private set { }
        }

        public int Port { get; private set; }

        public bool EnableSsl { get; private set; }

        public string UserName { get; private set; }

        public string Password { get; private set; }
    
        public void SetConfiguration(int port, bool
            enableSsl, string userName, string password)
        {
            this.Port = port;
            this.EnableSsl = enableSsl;
            this.UserName = userName;
            this.Password = password;
        }
    
    }
}
