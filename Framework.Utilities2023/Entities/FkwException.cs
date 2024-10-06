using Framework.Utilities202.Entities;
using Framework.Utilities2023.Log;
using Framework.Utilities2023.Log.Services;
using System;

namespace Framework.Utilities2023.Entities
{
    public class FkwException : Exception
    {
        private ServiceLogBook _logService = new ServiceLogBook();

        private string _Message  { get; set; }
        private string _ClassEx  { get; set; }
        private string _MethodEx { get; set; }

        public FkwException(string message, string classEx, string methodEx) : base(message)
        {
            _Message = message;
            _ClassEx = classEx;
            _MethodEx = methodEx;

            LogBook logBook = LogBook.Create(classEx, methodEx, message);

            _logService.SaveErrorLog(logBook);
        }

    }
}
