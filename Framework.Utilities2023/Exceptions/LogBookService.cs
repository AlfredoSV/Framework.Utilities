using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Framework.Sql2023;

namespace Framework.Utilities2023.Log
{
    public class LogBookService
    {
        private SqlDB<LogBook> _repositorieLogBook = new SqlDB<LogBook>("");

        public void SaveLog(LogBook logBook)
        {
            this._repositorieLogBook.Insert(logBook);
        }
    }
}
