using Framework.Utilities2023.Log;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Utilities2023.Repository
{
    public class RepositoryLogBook
    {
        private readonly string _sqlStr;

        public RepositoryLogBook()
        {
            _sqlStr = ConnectionStr.Instance.ConnectionFramework;
        }
        public void Save(LogBook book)
        {
            string insertStr = @"INSERT INTO LogBook VALUES(@id, @className,@methodName, @typeName, @messageName, @dateCreated);";
            using (SqlConnection sqlConnection = new SqlConnection(_sqlStr))
            {
                sqlConnection.Open();
                SqlCommand cmd = sqlConnection.CreateCommand();
                cmd.CommandText = insertStr;
                cmd.Parameters.AddWithValue("id",book.IdName);
                cmd.Parameters.AddWithValue("className", book.ClassName);
                cmd.Parameters.AddWithValue("methodName", book.MethodName);
                cmd.Parameters.AddWithValue("typeName", book.TypeName);
                cmd.Parameters.AddWithValue("messageName", book.MessageName);
                cmd.Parameters.AddWithValue("dateCreated", book.DateCreated);
                cmd.ExecuteNonQuery();

            }
        }
    }
}
