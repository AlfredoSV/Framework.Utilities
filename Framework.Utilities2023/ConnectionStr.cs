using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Utilities2023
{
    public class ConnectionStr
    {
        private static ConnectionStr _instance;

        public  static ConnectionStr Instance
        {
            get {

                if (_instance is null)
                    _instance = new ConnectionStr();
                return _instance;
            
            }
            private set { }
        }

        public string ConnectionFramework { get; set; }

    }
}
