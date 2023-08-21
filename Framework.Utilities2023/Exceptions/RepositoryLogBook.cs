using Framework.Utilities2023.Log;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Utilities2023.Exceptions
{
    public class RepositoryLogBook
    {
        private readonly string _sqlStr;

        public RepositoryLogBook(string sqlStr)
        {
            _sqlStr = sqlStr;
        }
        public void Save(LogBook book)
        {
            string insertStr = string.Empty;
            using (SqlConnection sqlConnection = new SqlConnection(_sqlStr))
            {
                sqlConnection.Open();
                SqlCommand cmd = sqlConnection.CreateCommand();
                cmd.CommandText = insertStr;
                cmd.ExecuteNonQuery();

            }
        }
    }
}
