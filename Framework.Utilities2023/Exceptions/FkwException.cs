using Framework.Utilities2023.Log;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Utilities2023.Exceptions
{
    public class FkwException : Exception
    {
        private ServiceLogBook _logService = new ServiceLogBook();

        private string _Message  { get; set; }
        private string _ClassEx  { get; set; }
        private string _MethodEx { get; set; }

        public FkwException(string message, string classEx, string methodEx, string typeEx) : base(message)
        {
            _Message = message;
            _ClassEx = classEx;
            _MethodEx = methodEx;

            LogBook logBook = LogBook.Create(classEx, methodEx, typeEx, message);

            _logService.SaveLog(logBook);
        }


    }
}
