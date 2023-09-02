
using System;

namespace Framework.Utilities2023.Log
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

        private string _typeName;

        public string TypeName
        {

            get { return this._typeName; }
            set { this._typeName = value; }

        }

        private string _meessageName;

        public string MessageName
        {

            get { return this._meessageName; }
            set { this._meessageName = value; }

        }

        private DateTime _dateCreated;

        public DateTime DateCreated
        {
            get { return _dateCreated; }
            set { _dateCreated = value; }
        }

        private LogBook( string classEx, string method, string type, string message)
        {
            IdName = Guid.NewGuid();
            ClassName = classEx;
            MethodName = method;
            TypeName = type;
            MessageName = message;
            DateCreated = DateTime.Now;
        }

        private LogBook(Guid id, string classEx, string method, string type, string message, DateTime dateCreated)
        {
            IdName = id;
            ClassName = classEx;
            MethodName = method;
            TypeName = type;
            MessageName = message;
            DateCreated = dateCreated;
        }

        public static LogBook Create( string classEx, string method, string type, string message)
        {
            return new LogBook(   classEx,  method,  type,  message);
        }

        public static LogBook Create(Guid id, string classEx, string method, string type, string message, DateTime dateCreated)
        {
            return new LogBook(id,classEx, method, type, message,dateCreated);
        }
    }

}
