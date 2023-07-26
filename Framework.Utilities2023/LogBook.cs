using FrameworkSql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Utilities2023.Log
{
    public class LogBook
    {
        private Guid _Id;

        [Id]
        public Guid Id { 
            get { return this._Id; } 
            set{ this._Id = value; }
        }

        private string Class;

        public string _Class
        {
            get { return Class; }
            set { Class = value; }
        }

        private string Method;

        public string MyProperty
        {
            get { return Method; }
            set { Method = value; }
        }

        private Guid IdApplication;

        public Guid _IdApplication
        {
            get { return IdApplication; }
            set { IdApplication = value; }
        }

        private string _Type;

        public string Type {

            get { return this._Type; }
            set { this._Type = value; }

        }
        
        private string _Message;

        public string Message {

            get { return this._Message; }
            set { this._Message = value; }

        }
        
        private DateTime _DateCreated;

        public DateTime DateCreated
        {
            get { return _DateCreated; }
            set { _DateCreated = value; }
        }

    }
}
