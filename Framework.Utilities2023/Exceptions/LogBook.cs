using FrameworkSql;
using System;

namespace Framework.Utilities2023.Log
{
    public class LogBook
    {
        private Guid _Id;

        [Id]
        public Guid Id
        {
            get { return this._Id; }
            set { this._Id = value; }
        }

        private string _Class;

        public string Class
        {
            get { return _Class; }
            set { _Class = value; }
        }

        private string _Method;

        public string Method
        {
            get { return _Method; }
            set { _Method = value; }
        }

        private string _Type;

        public string Type
        {

            get { return this._Type; }
            set { this._Type = value; }

        }

        private string _Message;

        public string Message
        {

            get { return this._Message; }
            set { this._Message = value; }

        }

        private DateTime _DateCreated;

        public DateTime DateCreated
        {
            get { return _DateCreated; }
            set { _DateCreated = value; }
        }


        private LogBook( string classEx, string method, string type, string message)
        {
            Id = Guid.NewGuid();
            Class = classEx;
            Method = method;
            Type = type;
            Message = message;
            DateCreated = DateTime.Now;
        }

        public static LogBook Create( string classEx, string method, string type, string message)
        {
            return new LogBook(   classEx,  method,  type,  message);
        }

    }

}
