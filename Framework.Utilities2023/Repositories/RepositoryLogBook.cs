using Framework.Utilities202.Entities;
using System.Data.SqlClient;

namespace Framework.Utilities2023.Repository
{
    public class RepositoryLogBook
    {
        private readonly string _sqlStr;

        public RepositoryLogBook(ConnectionStrUtilities connectionStrUtilities)
        {
            _sqlStr = connectionStrUtilities.StrConnectionFrameworkUtilities;
        }

        public void Save(LogBook book)
        {
            string insertStr = 
                @"INSERT INTO LogBook VALUES(@id, @className,@methodName, @typeName, @message, @dateCreated);";
            using (SqlConnection sqlConnection = new SqlConnection(_sqlStr))
            {
                sqlConnection.Open();
                SqlCommand cmd = sqlConnection.CreateCommand();
                cmd.CommandText = insertStr;
                cmd.Parameters.AddWithValue("id",book.IdName);
                cmd.Parameters.AddWithValue("className", book.ClassName);
                cmd.Parameters.AddWithValue("methodName", book.MethodName);
                cmd.Parameters.AddWithValue("typeName", book.Type);
                cmd.Parameters.AddWithValue("message", book.Message);
                cmd.Parameters.AddWithValue("dateCreated", book.DateCreated);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
