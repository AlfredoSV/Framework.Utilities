using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public string ConnectionFramework { get; set; }

    }
}
