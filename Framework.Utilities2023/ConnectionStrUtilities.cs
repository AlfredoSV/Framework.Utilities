namespace Framework.Utilities2023
{
    public class ConnectionStrUtilities
    {
        private static ConnectionStrUtilities _instance;

        public  static ConnectionStrUtilities Instance
        {
            get {

                if (_instance is null)
                    _instance = new ConnectionStrUtilities();
                return _instance;
            
            }
            private set { }
        }

        public string StrConnectionFrameworkUtilities { get; set; }

    }
}
