using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Framework.Utilities2023.Log
{
    public class LogBookService
    {
        private readonly string _Name;
        private readonly DateTime _Date;
        private readonly string _Detail;

        private LogBook _logBook = new LogBook();
        private RepositorieLogBook _repositorieLogBook = new RepositorieLogBook();

        public LogBookService(Type t)
        {
            this._Name = t.Name;          
        }

        public void SaveLog(string message,Array array)
        {
            this._repositorieLogBook.sqlDb.Insert(this._logBook);
        }
    }
}
