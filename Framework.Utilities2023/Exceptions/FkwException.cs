using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Utilities2023.Exceptions
{
    public class FkwException : Exception
    {
        public FkwException(string message) : base(message)
        {
            
        }
    }
}
