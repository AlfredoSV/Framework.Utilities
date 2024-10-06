
using System;

namespace Framework.Utilities202.Entities
{
    public class LogBook
    {
        private Guid _idName;
   
        public Guid IdName
        {
            get { return this._idName; }
            set { this._idName = value; }
        }

        private string _className;

        public string ClassName
        {
            get { return _className; }
            set { _className = value; }
        }

        private string _methodName;

        public string MethodName
        {
            get { return _methodName; }
            set { _methodName = value; }
        }

        private ErrorType _type;

        public ErrorType Type
        {

            get { return this._type; }
            set { this._type = value; }

        }

        private string _meessage;

        public string Message
        {

            get { return this._meessage; }
            set { this._meessage = value; }

        }

        public DateTime DateCreated
        {
            get { return DateTime.Now; }
        }


        private LogBook(string classEx, string method, string message)
        {
            IdName = Guid.NewGuid();
            ClassName = classEx;
            MethodName = method;
            Message = message;
        }


        public static LogBook Create(string classEx, string method, string message)
        {
            return new LogBook(classEx, method, message);
        }
    }

    public enum ErrorType
    {
        Error = -1,
        Warning = 1,
        Information = 0,
    }

}
