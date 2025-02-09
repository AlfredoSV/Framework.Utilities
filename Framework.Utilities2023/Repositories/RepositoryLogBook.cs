using Framework.Utilities202.Entities;
using System.Data.SqlClient;

namespace Framework.Utilities.Repository
{
    public class RepositoryLogBook
    {
        private readonly string _sqlStr;

        public RepositoryLogBook(ConnectionStrUtilities connectionStrUtilities)
        {
            _sqlStr = connectionStrUtilities.StrConnectionFrameworkUtilities;
        }

        public async Task Save(LogBook book)
        {
            try
            {
                string insertStr = @"INSERT INTO LogBook VALUES(@id, @class, @method, @type, @message, @createdAt);";
                using (SqlConnection sqlConnection = new SqlConnection(_sqlStr))
                {
                    await sqlConnection.OpenAsync();
                    SqlCommand cmd = sqlConnection.CreateCommand();
                    cmd.CommandText = insertStr;
                    cmd.Parameters.AddWithValue("@id", book.Id);
                    cmd.Parameters.AddWithValue("@class", book.Class);
                    cmd.Parameters.AddWithValue("@method", book.Method);
                    cmd.Parameters.AddWithValue("@type", book.Type);
                    cmd.Parameters.AddWithValue("@message", book.Message);
                    cmd.Parameters.AddWithValue("@createdAt", book.CreatedAt);
                    await cmd.ExecuteNonQueryAsync();
                }
            }
            catch (Exception)
            {
                throw;
            }       
        }
    }
}
