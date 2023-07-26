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

        public Guid Id { 
            get { return this._Id; } 
            set{ this._Id = value; }
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
