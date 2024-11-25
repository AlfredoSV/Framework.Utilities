
using System;

namespace Framework.Utilities202.Entities
{
    public class LogBook
    {
        private Guid _id;
   
        public Guid Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        private string _class;

        public string Class
        {
            get { return _class; }
            set { _class = value; }
        }

        private string _method;

        public string Method
        {
            get { return _method; }
            set { _method = value; }
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

        public DateTime CreatedAt
        {
            get { return DateTime.Now; }
        }


        private LogBook(string classEx, string method, string message)
        {
            Id = Guid.NewGuid();
            Class = classEx;
            Method = method;
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
