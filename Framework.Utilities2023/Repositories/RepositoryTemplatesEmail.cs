using System;
using System.Data.SqlClient;

namespace Framework.Utilities2023.Repositories
{
    public class RepositoryTemplatesEmail
    {
        private readonly string _sqlStr;

        public RepositoryTemplatesEmail()
        {
            _sqlStr = ConnectionStr.Instance.ConnectionFramework;
        }
        public void GetByid(Guid idTemplate)
        {
            string insertStr = @"";
            using (SqlConnection sqlConnection = new SqlConnection(_sqlStr))
            {
                sqlConnection.Open();
                SqlCommand cmd = sqlConnection.CreateCommand();
                cmd.CommandText = insertStr;
                cmd.Parameters.AddWithValue("id", idTemplate);
                cmd.ExecuteNonQuery();

            }
        }
    }
}
