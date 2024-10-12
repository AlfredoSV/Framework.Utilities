using Framework.Utilities202.Entities;
using Framework.Utilities2023.Log;
using Framework.Utilities2023.Log.Services;
using System;

namespace Framework.Utilities2023.Entities
{
    public class FkwException : Exception
    {
        private readonly ServiceLogBook _logService;
        private string Message { get; set; }
        private string ClassEx { get; set; }
        private string MethodEx { get; set; }

        public FkwException(ServiceLogBook serviceLogBook)
        {
            this._logService = serviceLogBook;
        }

        public FkwException(string message, string classEx, string methodEx) : base(message)
        {
            this.Message = message;
            this.ClassEx = classEx;
            this.MethodEx = methodEx;

            LogBook logBook = LogBook.Create(classEx, methodEx, message);

            _logService.SaveErrorLog(logBook);
        }

    }
}
